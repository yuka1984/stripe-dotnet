namespace StripeTests.Checkout
{
    using Newtonsoft.Json;
    using Stripe;
    using Stripe.Checkout;
    using Xunit;

    public class SessionTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            var json = GetResourceAsString("api_fixtures.checkout.session.json");
            var session = JsonConvert.DeserializeObject<Session>(json);
            Assert.NotNull(session);
            Assert.IsType<Session>(session);
            Assert.NotNull(session.Id);
            Assert.Equal("checkout.session", session.Object);
        }
    }
}
