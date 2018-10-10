using ePay.Data;
using ePay.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Stripe;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace ePay.Infrastructure
{
    public class StripeWebHookHandler
    {
        private readonly ILogger _log;
        private readonly DataContext _ctx;

        public StripeWebHookHandler(RequestDelegate next, ILoggerFactory logger, DataContext ctx)
        {
            _log = logger.CreateLogger<StripeWebHookHandler>();
            _ctx = ctx;
        }

        //
        //  http://localhost:5000/Webhooks/Incoming
        public async Task Invoke(HttpContext httpContext)
        {
            string json = null;

            json = await new StreamReader(httpContext.Request.Body).ReadToEndAsync();

            if (JObject.Parse(json)["data"]["object"]["metadata"]["pandadoc_document_reference"] != null && JObject.Parse(json)["data"]["object"]["customer"] != null)
            {
                string pandadocDocumentReference = JObject.Parse(json)["data"]["object"]["metadata"]["pandadoc_document_reference"].ToString();
                string customer = JObject.Parse(json)["data"]["object"]["customer"].ToString();

                if (!string.IsNullOrEmpty(pandadocDocumentReference) && !string.IsNullOrEmpty(customer))
                {
                    StripeChargeSusseeded resultChargeSusseeded = new StripeChargeSusseeded()
                    {
                        CustomerId = customer,
                        PandadocDocumentReference = pandadocDocumentReference
                    };

                    string value = await PandaDoc.GetDocumentDetailsAsync(await PandaDoc.GetDocument(pandadocDocumentReference));

                    var obj = JsonConvert.DeserializeObject<RootObject>(value);

                    var optInitial = new StripePlanCreateOptions()
                    {
                        Product = new StripePlanProductCreateOptions()
                        {
                            Name = "Initial_test_05_10_18_2"
                        },

                        Active = true,
                        Amount = int.Parse(obj.Pricing.Tables[0].Total),
                        BillingScheme = "per_unit",
                        Currency = obj.GrandTotal.Currency,
                        Interval = "month",
                        IntervalCount = 3,
                        Nickname = "Initial_test_05_10_18_2",
                        UsageType = "licensed"
                    };
                    var optExtra = new StripePlanCreateOptions()
                    {
                        Product = new StripePlanProductCreateOptions()
                        {
                            Name = "Extra_test_05_10_18_2"
                        },
                        Active = true,
                        BillingScheme = "tiered",
                        Currency = obj.GrandTotal.Currency,
                        Interval = obj.Pricing.Tables[1].Items[0].CustomColumns.Period,
                        IntervalCount = 1,
                        Nickname = "Extra_test_05_10_18_2",
                        Tiers = new List<StripePlanTierOptions>()
                            {
                                new StripePlanTierOptions()
                                {
                                    Amount =obj.Pricing.Tables[1].Items[0].Qty,
                                    UpTo = new StripePlanTierOptions.UpToInf() { }
                                }
                            },
                        TiersMode = "volume",
                        UsageType = "metered"
                    };

                    var responseJsonInitial = await StripeActions.CreateInitialPlanAsync(optInitial);
                    var responseJsonExtra = await StripeActions.CreateExtraPlanAsync(optExtra);

                    await StripeActions.CreateSubscription(resultChargeSusseeded.CustomerId, "plan_DjHBD7IMeE2vMW");

                    _log.LogWarning($"DONE");
                }
            }
        }
    }
}