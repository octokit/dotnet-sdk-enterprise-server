// <auto-generated/>
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Orgs.Item.ExternalGroups
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\external-groups
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class ExternalGroupsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.ExternalGroups.ExternalGroupsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ExternalGroupsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/external-groups{?display_name*,page*,per_page*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.ExternalGroups.ExternalGroupsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ExternalGroupsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/external-groups{?display_name*,page*,per_page*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists external groups available in an organization. You can query the groups using the `display_name` parameter, only groups with a `group_name` containing the text provided in the `display_name` parameter will be returned.  You can also limit your page results using the `per_page` parameter. GitHub Enterprise Server generates a url-encoded `page` token using a cursor value for where the next page begins. For more information on cursor pagination, see &quot;[Offset and Cursor Pagination explained](https://dev.to/jackmarchant/offset-and-cursor-pagination-explained-b89).&quot;You can manage team membership with your identity provider using Enterprise Managed Users for GitHub Enterprise Cloud. For more information, see &quot;[GitHub&apos;s products](https://docs.github.com/enterprise-server@3.10/github/getting-started-with-github/githubs-products)&quot; in the GitHub Help documentation.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.10/rest/teams/external-groups#list-external-groups-in-an-organization" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.ExternalGroups"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.ExternalGroups?> GetAsync(Action<RequestConfiguration<global::GitHub.Orgs.Item.ExternalGroups.ExternalGroupsRequestBuilder.ExternalGroupsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.ExternalGroups> GetAsync(Action<RequestConfiguration<global::GitHub.Orgs.Item.ExternalGroups.ExternalGroupsRequestBuilder.ExternalGroupsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::GitHub.Models.ExternalGroups>(requestInfo, global::GitHub.Models.ExternalGroups.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists external groups available in an organization. You can query the groups using the `display_name` parameter, only groups with a `group_name` containing the text provided in the `display_name` parameter will be returned.  You can also limit your page results using the `per_page` parameter. GitHub Enterprise Server generates a url-encoded `page` token using a cursor value for where the next page begins. For more information on cursor pagination, see &quot;[Offset and Cursor Pagination explained](https://dev.to/jackmarchant/offset-and-cursor-pagination-explained-b89).&quot;You can manage team membership with your identity provider using Enterprise Managed Users for GitHub Enterprise Cloud. For more information, see &quot;[GitHub&apos;s products](https://docs.github.com/enterprise-server@3.10/github/getting-started-with-github/githubs-products)&quot; in the GitHub Help documentation.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Orgs.Item.ExternalGroups.ExternalGroupsRequestBuilder.ExternalGroupsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Orgs.Item.ExternalGroups.ExternalGroupsRequestBuilder.ExternalGroupsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Orgs.Item.ExternalGroups.ExternalGroupsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Orgs.Item.ExternalGroups.ExternalGroupsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Orgs.Item.ExternalGroups.ExternalGroupsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists external groups available in an organization. You can query the groups using the `display_name` parameter, only groups with a `group_name` containing the text provided in the `display_name` parameter will be returned.  You can also limit your page results using the `per_page` parameter. GitHub Enterprise Server generates a url-encoded `page` token using a cursor value for where the next page begins. For more information on cursor pagination, see &quot;[Offset and Cursor Pagination explained](https://dev.to/jackmarchant/offset-and-cursor-pagination-explained-b89).&quot;You can manage team membership with your identity provider using Enterprise Managed Users for GitHub Enterprise Cloud. For more information, see &quot;[GitHub&apos;s products](https://docs.github.com/enterprise-server@3.10/github/getting-started-with-github/githubs-products)&quot; in the GitHub Help documentation.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class ExternalGroupsRequestBuilderGetQueryParameters 
        {
            /// <summary>Limits the list to groups containing the text in the group name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("display_name")]
            public string? DisplayName { get; set; }
#nullable restore
#else
            [QueryParameter("display_name")]
            public string DisplayName { get; set; }
#endif
            /// <summary>Page token</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.10/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
        }
    }
}
