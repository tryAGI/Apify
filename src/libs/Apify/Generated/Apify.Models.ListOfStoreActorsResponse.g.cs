
#nullable enable

namespace Apify
{
    /// <summary>
    /// Example: {"data":{"total":100,"offset":0,"limit":1000,"desc":false,"count":1,"items":[{"id":"zdc3Pyhyz3m8vjDeM","title":"My Public Actor","name":"my-public-actor","username":"jane35","userFullName":"Jane Doe","categories":["AI_AND_ML","GENERATE_LEADS"],"description":"My public Actor!","pictureUrl":"https://...","userPictureUrl":"https://...","url":"https://...","stats":{"totalRuns":16,"totalUsers":6,"totalUsers7Days":2,"totalUsers30Days":6,"totalUsers90Days":6,"actorReviewRating":4.7,"actorReviewCount":69},"currentPricingInfo":{"pricingModel":"FREE"},"isVerified":true,"isWhiteListedForAgenticPayments":true},{"id":"zdc3Pyhyz3m8vjDeM","title":"My Public Actor","name":"my-public-actor","username":"jane35","userFullName":"Jane H. Doe","categories":["ECOMMERCE"],"description":"My public Actor!","pictureUrl":"https://...","userPictureUrl":"https://...","url":"https://...","stats":{"totalRuns":16,"totalUsers":6,"totalUsers7Days":2,"totalUsers30Days":6,"totalUsers90Days":6,"actorReviewRating":4.7,"actorReviewCount":69},"currentPricingInfo":{"pricingModel":"FREE"},"isVerified":false,"isWhiteListedForAgenticPayments":false}]}}
    /// </summary>
    public sealed partial class ListOfStoreActorsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.ListOfStoreActorsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.ListOfStoreActors Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOfStoreActorsResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListOfStoreActorsResponse(
            global::Apify.ListOfStoreActors data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOfStoreActorsResponse" /> class.
        /// </summary>
        public ListOfStoreActorsResponse()
        {
        }

    }
}