
#nullable enable

namespace Apify
{
    /// <summary>
    /// Example: {"data":{"total":100,"offset":0,"limit":1000,"desc":false,"count":1,"items":[{"id":"zdc3Pyhyz3m8vjDeM","title":"My Public Actor","name":"my-public-actor","username":"jane35","userFullName":"Jane Doe","description":"My public Actor!","pictureUrl":"https://...","userPictureUrl":"https://...","url":"https://...","stats":{"totalBuilds":9,"totalRuns":16,"totalUsers":6,"totalUsers7Days":2,"totalUsers30Days":6,"totalUsers90Days":6,"totalMetamorphs":2,"lastRunStartedAt":"2019-07-08T14:01:05.546Z"},"currentPricingInfo":{"pricingModel":"FREE"},"isWhiteListedForAgenticPayments":true},{"id":"zdc3Pyhyz3m8vjDeM","title":"My Public Actor","name":"my-public-actor","username":"jane35","userFullName":"Jane H. Doe","categories":["MARKETING","LEAD_GENERATION"],"description":"My public Actor!","pictureUrl":"https://...","userPictureUrl":"https://...","url":"https://...","stats":{"totalBuilds":9,"totalRuns":16,"totalUsers":6,"totalUsers7Days":2,"totalUsers30Days":6,"totalUsers90Days":6,"totalMetamorphs":2,"lastRunStartedAt":"2019-07-08T14:01:05.546Z"},"currentPricingInfo":{"pricingModel":"FREE"},"isWhiteListedForAgenticPayments":false}]}}
    /// </summary>
    public sealed partial class ListOfActorsInStoreResponse
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
        /// Initializes a new instance of the <see cref="ListOfActorsInStoreResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListOfActorsInStoreResponse(
            global::Apify.ListOfStoreActors data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOfActorsInStoreResponse" /> class.
        /// </summary>
        public ListOfActorsInStoreResponse()
        {
        }

    }
}