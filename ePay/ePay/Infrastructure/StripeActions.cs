using Newtonsoft.Json;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ePay.Infrastructure
{
    public class StripeActions
    {
        public static async Task<string> ListOfPlans()
        {
            StripeConfiguration.SetApiKey("sk_test_5nCTR2UZmnOPWgZASvirbYDy");

            StripePlanService planService = new StripePlanService();
            StripeList<StripePlan> planItems = await planService.ListAsync(
                new StripePlanListOptions()
                {
                    Limit = 100
                }
            );
            return JsonConvert.SerializeObject(planItems.Data);
        }
        public static async Task<string> CreateExtraPlanAsync(StripePlanCreateOptions options)
        {
            StripeConfiguration.SetApiKey("sk_test_5nCTR2UZmnOPWgZASvirbYDy");

            StripePlanCreateOptions planOptions = new StripePlanCreateOptions()
            {
                Product = new StripePlanProductCreateOptions()
                {
                    Name = "Extra" + "" + ""
                },
                Active = options.Active,
                //Amount = 1190,
                BillingScheme = options.BillingScheme,
                Currency = options.Currency,
                Interval = options.Interval,
                IntervalCount = options.IntervalCount,
                Nickname = options.Nickname,
                Tiers = new List<StripePlanTierOptions>() {
                    new StripePlanTierOptions() {
                        Amount = options.Tiers.First().Amount,
                        UpTo = new StripePlanTierOptions.UpToInf() { }
                    }
                },
                TiersMode = "volume",
                UsageType = "metered"
                //TransformUsage = new StripePlanTransformUsageOptions()
            };

            StripePlanService planService = new StripePlanService();
            StripePlan plan = await planService.CreateAsync(planOptions);

            return plan.StripeResponse.ResponseJson;
        }
        public static async Task<string> CreateInitialPlanAsync(StripePlanCreateOptions options)
        {
            StripeConfiguration.SetApiKey("sk_test_5nCTR2UZmnOPWgZASvirbYDy");

            StripePlanCreateOptions planOptions = new StripePlanCreateOptions()
            {
                Product = new StripePlanProductCreateOptions()
                {
                    Name = "Initial_test_04_10_18_(1)"
                },
                Active = options.Active,
                Amount = 1190,
                BillingScheme = options.BillingScheme,
                Currency = options.Currency,
                Interval = options.Interval,
                IntervalCount = options.IntervalCount,
                Nickname = options.Nickname,
                TrialPeriodDays = options.TrialPeriodDays,
                UsageType = options.UsageType
            };

            StripePlanService planService = new StripePlanService();
            StripePlan plan = await planService.CreateAsync(planOptions);
            return plan.StripeResponse.ResponseJson;
        }
        public static async Task CreateSubscription(string customerId,string planId)
        {
            StripeConfiguration.SetApiKey("sk_test_5nCTR2UZmnOPWgZASvirbYDy");

            List<StripeSubscriptionItemOption> items = new List<StripeSubscriptionItemOption>
            {
                new StripeSubscriptionItemOption
                {
                    PlanId = planId
                }
            };
            StripeSubscriptionCreateOptions subscriptionOptions = new StripeSubscriptionCreateOptions
            {
                Items = items,
                BillingCycleAnchor = DateTimeOffset.FromUnixTimeSeconds(1539331009).UtcDateTime,
                Prorate = true
            };

            StripeSubscriptionService subscriptionService = new StripeSubscriptionService();
            StripeSubscription subscription = await subscriptionService.CreateAsync(customerId, subscriptionOptions);

            await RequiredInvoice(subscription.Id);
            await UpdateInvoice(await RequiredInvoice(subscription.Id));
        }

        public static async Task<string> RequiredInvoice(string subscriptionId)
        {
            StripeConfiguration.SetApiKey("sk_test_5nCTR2UZmnOPWgZASvirbYDy");

            StripeInvoiceService invoiceService = new StripeInvoiceService();
            StripeList<StripeInvoice> invoiceItems = await invoiceService.ListAsync(
                new StripeInvoiceListOptions()
                {
                    SubscriptionId = subscriptionId
                }
            );
            StripeInvoice value = invoiceItems.First<StripeInvoice>();

            return value.Id;
        }

        public static async Task<string> UpdateInvoice(string invoiceId)
        {
            StripeConfiguration.SetApiKey("sk_test_5nCTR2UZmnOPWgZASvirbYDy");

            StripeInvoiceUpdateOptions invoiceOptions = new StripeInvoiceUpdateOptions()
            {
                Closed = false
            };

            StripeInvoiceService invoiceService = new StripeInvoiceService();
            //"in_1D18zxHWpLOEdy24Tgw0TzEq"
            //             |
            //             V
            StripeInvoice invoice = await invoiceService.UpdateAsync(invoiceId, invoiceOptions);
            return "OK";
        }
    }
}