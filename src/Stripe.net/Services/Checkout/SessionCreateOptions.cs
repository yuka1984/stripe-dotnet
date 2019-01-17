namespace Stripe.Checkout
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SessionCreateOptions : BaseOptions
    {
        [JsonProperty("allowed_source_types")]
        public List<string> AllowedSourceTypes { get; set; }

        [JsonProperty("cancel_url")]
        public string CancelUrl { get; set; }

        [JsonProperty("client_reference_id")]
        public string ClientReferenceId { get; set; }

        [JsonProperty("line_items")]
        public List<SessionLineItemOptions> LineItems { get; set; }

        [JsonProperty("payment_intent_data")]
        public SessionPaymentIntentDataOptions PaymentIntentData { get; set; }

        [JsonProperty("success_url")]
        public string SuccessUrl { get; set; }
    }
}
