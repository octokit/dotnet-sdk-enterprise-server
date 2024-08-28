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
namespace GitHub.Repos.Item.Item.Rules.Branches.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\rules\branches\{branch}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class WithBranchItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Rules.Branches.Item.WithBranchItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithBranchItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/rules/branches/{branch}{?page*,per_page*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Rules.Branches.Item.WithBranchItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithBranchItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/rules/branches/{branch}{?page*,per_page*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns all active rules that apply to the specified branch. The branch does not need to exist; rules that would applyto a branch with that name will be returned. All active rules that apply will be returned, regardless of the levelat which they are configured (e.g. repository or organization). Rules in rulesets with &quot;evaluate&quot; or &quot;disabled&quot;enforcement statuses are not returned.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.12/rest/repos/rules#get-rules-for-a-branch" />
        /// </summary>
        /// <returns>A List&lt;global::GitHub.Models.RepositoryRuleDetailed&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::GitHub.Models.RepositoryRuleDetailed>?> GetAsync(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Rules.Branches.Item.WithBranchItemRequestBuilder.WithBranchItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::GitHub.Models.RepositoryRuleDetailed>> GetAsync(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Rules.Branches.Item.WithBranchItemRequestBuilder.WithBranchItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::GitHub.Models.RepositoryRuleDetailed>(requestInfo, global::GitHub.Models.RepositoryRuleDetailed.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Returns all active rules that apply to the specified branch. The branch does not need to exist; rules that would applyto a branch with that name will be returned. All active rules that apply will be returned, regardless of the levelat which they are configured (e.g. repository or organization). Rules in rulesets with &quot;evaluate&quot; or &quot;disabled&quot;enforcement statuses are not returned.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Rules.Branches.Item.WithBranchItemRequestBuilder.WithBranchItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Rules.Branches.Item.WithBranchItemRequestBuilder.WithBranchItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Rules.Branches.Item.WithBranchItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Repos.Item.Item.Rules.Branches.Item.WithBranchItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Repos.Item.Item.Rules.Branches.Item.WithBranchItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns all active rules that apply to the specified branch. The branch does not need to exist; rules that would applyto a branch with that name will be returned. All active rules that apply will be returned, regardless of the levelat which they are configured (e.g. repository or organization). Rules in rulesets with &quot;evaluate&quot; or &quot;disabled&quot;enforcement statuses are not returned.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class WithBranchItemRequestBuilderGetQueryParameters 
        {
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.12/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.12/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
        }
    }
}
