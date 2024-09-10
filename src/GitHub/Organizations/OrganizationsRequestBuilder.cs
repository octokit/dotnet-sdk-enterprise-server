// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Models;
using GitHub.Organizations.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Organizations
{
    /// <summary>
    /// Builds and executes requests for operations under \organizations
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class OrganizationsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the GitHub.organizations.item collection</summary>
        /// <param name="position">The unique identifier of the organization.</param>
        /// <returns>A <see cref="global::GitHub.Organizations.Item.WithOrganization_ItemRequestBuilder"/></returns>
        public global::GitHub.Organizations.Item.WithOrganization_ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("organization_id", position);
                return new global::GitHub.Organizations.Item.WithOrganization_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Organizations.OrganizationsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OrganizationsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/organizations{?per_page*,since*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Organizations.OrganizationsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OrganizationsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/organizations{?per_page*,since*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists all organizations, in the order that they were created.&gt; [!NOTE]&gt; Pagination is powered exclusively by the `since` parameter. Use the [Link header](https://docs.github.com/enterprise-server@3.13/rest/guides/using-pagination-in-the-rest-api#using-link-headers) to get the URL for the next page of organizations.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.13/rest/orgs/orgs#list-organizations" />
        /// </summary>
        /// <returns>A List&lt;global::GitHub.Models.OrganizationSimple&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::GitHub.Models.OrganizationSimple>?> GetAsync(Action<RequestConfiguration<global::GitHub.Organizations.OrganizationsRequestBuilder.OrganizationsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::GitHub.Models.OrganizationSimple>> GetAsync(Action<RequestConfiguration<global::GitHub.Organizations.OrganizationsRequestBuilder.OrganizationsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::GitHub.Models.OrganizationSimple>(requestInfo, global::GitHub.Models.OrganizationSimple.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Lists all organizations, in the order that they were created.&gt; [!NOTE]&gt; Pagination is powered exclusively by the `since` parameter. Use the [Link header](https://docs.github.com/enterprise-server@3.13/rest/guides/using-pagination-in-the-rest-api#using-link-headers) to get the URL for the next page of organizations.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Organizations.OrganizationsRequestBuilder.OrganizationsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Organizations.OrganizationsRequestBuilder.OrganizationsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Organizations.OrganizationsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Organizations.OrganizationsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Organizations.OrganizationsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists all organizations, in the order that they were created.&gt; [!NOTE]&gt; Pagination is powered exclusively by the `since` parameter. Use the [Link header](https://docs.github.com/enterprise-server@3.13/rest/guides/using-pagination-in-the-rest-api#using-link-headers) to get the URL for the next page of organizations.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class OrganizationsRequestBuilderGetQueryParameters 
        {
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.13/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>An organization ID. Only return organizations with an ID greater than this ID.</summary>
            [QueryParameter("since")]
            public int? Since { get; set; }
        }
    }
}
#pragma warning restore CS0618
