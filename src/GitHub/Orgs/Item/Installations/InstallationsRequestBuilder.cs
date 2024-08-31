// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Orgs.Item.Installations
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\installations
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class InstallationsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.Installations.InstallationsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public InstallationsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/installations{?page*,per_page*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.Installations.InstallationsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public InstallationsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/installations{?page*,per_page*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists all GitHub Apps in an organization. The installation count includesall GitHub Apps installed on repositories in the organization.The authenticated user must be an organization owner to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `admin:read` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.13/rest/orgs/orgs#list-app-installations-for-an-organization" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Orgs.Item.Installations.InstallationsGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Orgs.Item.Installations.InstallationsGetResponse?> GetAsync(Action<RequestConfiguration<global::GitHub.Orgs.Item.Installations.InstallationsRequestBuilder.InstallationsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Orgs.Item.Installations.InstallationsGetResponse> GetAsync(Action<RequestConfiguration<global::GitHub.Orgs.Item.Installations.InstallationsRequestBuilder.InstallationsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::GitHub.Orgs.Item.Installations.InstallationsGetResponse>(requestInfo, global::GitHub.Orgs.Item.Installations.InstallationsGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists all GitHub Apps in an organization. The installation count includesall GitHub Apps installed on repositories in the organization.The authenticated user must be an organization owner to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `admin:read` scope to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Orgs.Item.Installations.InstallationsRequestBuilder.InstallationsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Orgs.Item.Installations.InstallationsRequestBuilder.InstallationsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Orgs.Item.Installations.InstallationsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Orgs.Item.Installations.InstallationsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Orgs.Item.Installations.InstallationsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists all GitHub Apps in an organization. The installation count includesall GitHub Apps installed on repositories in the organization.The authenticated user must be an organization owner to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `admin:read` scope to use this endpoint.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class InstallationsRequestBuilderGetQueryParameters 
        {
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.13/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.13/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
        }
    }
}
