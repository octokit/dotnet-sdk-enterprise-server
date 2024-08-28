// <auto-generated/>
using GitHub.Models;
using GitHub.User.Memberships.Orgs.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.User.Memberships.Orgs
{
    /// <summary>
    /// Builds and executes requests for operations under \user\memberships\orgs
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class OrgsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the GitHub.user.memberships.orgs.item collection</summary>
        /// <param name="position">The organization name. The name is not case sensitive.</param>
        /// <returns>A <see cref="global::GitHub.User.Memberships.Orgs.Item.WithOrgItemRequestBuilder"/></returns>
        public global::GitHub.User.Memberships.Orgs.Item.WithOrgItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("org", position);
                return new global::GitHub.User.Memberships.Orgs.Item.WithOrgItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.User.Memberships.Orgs.OrgsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OrgsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/user/memberships/orgs{?page*,per_page*,state*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.User.Memberships.Orgs.OrgsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OrgsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/user/memberships/orgs{?page*,per_page*,state*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists all of the authenticated user&apos;s organization memberships.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.10/rest/orgs/members#list-organization-memberships-for-the-authenticated-user" />
        /// </summary>
        /// <returns>A List&lt;global::GitHub.Models.OrgMembership&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 401 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 403 status code</exception>
        /// <exception cref="global::GitHub.Models.ValidationError">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::GitHub.Models.OrgMembership>?> GetAsync(Action<RequestConfiguration<global::GitHub.User.Memberships.Orgs.OrgsRequestBuilder.OrgsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::GitHub.Models.OrgMembership>> GetAsync(Action<RequestConfiguration<global::GitHub.User.Memberships.Orgs.OrgsRequestBuilder.OrgsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "403", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "422", global::GitHub.Models.ValidationError.CreateFromDiscriminatorValue },
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::GitHub.Models.OrgMembership>(requestInfo, global::GitHub.Models.OrgMembership.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Lists all of the authenticated user&apos;s organization memberships.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.User.Memberships.Orgs.OrgsRequestBuilder.OrgsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.User.Memberships.Orgs.OrgsRequestBuilder.OrgsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.User.Memberships.Orgs.OrgsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.User.Memberships.Orgs.OrgsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.User.Memberships.Orgs.OrgsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists all of the authenticated user&apos;s organization memberships.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class OrgsRequestBuilderGetQueryParameters 
        {
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.10/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.10/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>Indicates the state of the memberships to return. If not specified, the API returns both active and pending memberships.</summary>
            [QueryParameter("state")]
            public global::GitHub.User.Memberships.Orgs.GetStateQueryParameterType? State { get; set; }
        }
    }
}
