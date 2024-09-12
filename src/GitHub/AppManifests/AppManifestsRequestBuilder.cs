// <auto-generated/>
#pragma warning disable CS0618
using GitHub.AppManifests.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace GitHub.AppManifests
{
    /// <summary>
    /// Builds and executes requests for operations under \app-manifests
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class AppManifestsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the GitHub.appManifests.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::GitHub.AppManifests.Item.WithCodeItemRequestBuilder"/></returns>
        public global::GitHub.AppManifests.Item.WithCodeItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("code", position);
                return new global::GitHub.AppManifests.Item.WithCodeItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.AppManifests.AppManifestsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AppManifestsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/app-manifests", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.AppManifests.AppManifestsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AppManifestsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/app-manifests", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
