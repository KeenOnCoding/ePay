using Microsoft.AspNetCore.Builder;

namespace ePay.Infrastructure
{
    public static class StripeWebhookHandlerExtensions
    {
        public static IApplicationBuilder UseStripeWebhookHandler(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<StripeWebHookHandler>();
        }
    }
}