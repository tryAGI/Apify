
#nullable enable

namespace Apify
{
    public partial interface ILastActorRunSMetamorphClient
    {
        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingBearer(
            string apiKey);
    }
}