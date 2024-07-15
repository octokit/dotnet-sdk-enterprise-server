// <auto-generated/>
using GitHub.Licenses.Item;
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Licenses {
    /// <summary>
    /// Builds and executes requests for operations under \licenses
    /// </summary>
    public class LicensesRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Gets an item from the GitHub.licenses.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="WithLicenseItemRequestBuilder"/></returns>
        public WithLicenseItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("license", position);
                return new WithLicenseItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="LicensesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LicensesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/licenses{?featured*,page*,per_page*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="LicensesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LicensesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/licenses{?featured*,page*,per_page*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists the most commonly used licenses on GitHub. For more information, see &quot;[Licensing a repository ](https://docs.github.com/enterprise-server@3.12/repositories/managing-your-repositorys-settings-and-features/customizing-your-repository/licensing-a-repository).&quot;
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.12/rest/licenses/licenses#get-all-commonly-used-licenses" />
        /// </summary>
        /// <returns>A List&lt;LicenseSimple&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<LicenseSimple>?> GetAsync(Action<RequestConfiguration<LicensesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<LicenseSimple>> GetAsync(Action<RequestConfiguration<LicensesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<LicenseSimple>(requestInfo, LicenseSimple.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Lists the most commonly used licenses on GitHub. For more information, see &quot;[Licensing a repository ](https://docs.github.com/enterprise-server@3.12/repositories/managing-your-repositorys-settings-and-features/customizing-your-repository/licensing-a-repository).&quot;
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<LicensesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<LicensesRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="LicensesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public LicensesRequestBuilder WithUrl(string rawUrl)
        {
            return new LicensesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists the most commonly used licenses on GitHub. For more information, see &quot;[Licensing a repository ](https://docs.github.com/enterprise-server@3.12/repositories/managing-your-repositorys-settings-and-features/customizing-your-repository/licensing-a-repository).&quot;
        /// </summary>
        public class LicensesRequestBuilderGetQueryParameters 
        {
            [QueryParameter("featured")]
            public bool? Featured { get; set; }
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.12/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.12/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
        }
    }
}
