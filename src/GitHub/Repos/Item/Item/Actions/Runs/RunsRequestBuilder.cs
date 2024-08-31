// <auto-generated/>
using GitHub.Repos.Item.Item.Actions.Runs.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Repos.Item.Item.Actions.Runs
{
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\actions\runs
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class RunsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the GitHub.repos.item.item.actions.runs.item collection</summary>
        /// <param name="position">The unique identifier of the workflow run.</param>
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Actions.Runs.Item.WithRun_ItemRequestBuilder"/></returns>
        public global::GitHub.Repos.Item.Item.Actions.Runs.Item.WithRun_ItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("run_id", position);
                return new global::GitHub.Repos.Item.Item.Actions.Runs.Item.WithRun_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Actions.Runs.RunsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RunsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/actions/runs{?actor*,branch*,check_suite_id*,created*,event*,exclude_pull_requests*,head_sha*,page*,per_page*,status*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Actions.Runs.RunsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RunsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/actions/runs{?actor*,branch*,check_suite_id*,created*,event*,exclude_pull_requests*,head_sha*,page*,per_page*,status*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists all workflow runs for a repository. You can use parameters to narrow the list of results. For more information about using parameters, see [Parameters](https://docs.github.com/enterprise-server@3.13/rest/guides/getting-started-with-the-rest-api#parameters).Anyone with read access to the repository can use this endpoint.OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.This API will return up to 1,000 results for each search when using the following parameters: `actor`, `branch`, `check_suite_id`, `created`, `event`, `head_sha`, `status`.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.13/rest/actions/workflow-runs#list-workflow-runs-for-a-repository" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Actions.Runs.RunsGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Repos.Item.Item.Actions.Runs.RunsGetResponse?> GetAsync(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Actions.Runs.RunsRequestBuilder.RunsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Repos.Item.Item.Actions.Runs.RunsGetResponse> GetAsync(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Actions.Runs.RunsRequestBuilder.RunsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::GitHub.Repos.Item.Item.Actions.Runs.RunsGetResponse>(requestInfo, global::GitHub.Repos.Item.Item.Actions.Runs.RunsGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists all workflow runs for a repository. You can use parameters to narrow the list of results. For more information about using parameters, see [Parameters](https://docs.github.com/enterprise-server@3.13/rest/guides/getting-started-with-the-rest-api#parameters).Anyone with read access to the repository can use this endpoint.OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.This API will return up to 1,000 results for each search when using the following parameters: `actor`, `branch`, `check_suite_id`, `created`, `event`, `head_sha`, `status`.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Actions.Runs.RunsRequestBuilder.RunsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Actions.Runs.RunsRequestBuilder.RunsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Actions.Runs.RunsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Repos.Item.Item.Actions.Runs.RunsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Repos.Item.Item.Actions.Runs.RunsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists all workflow runs for a repository. You can use parameters to narrow the list of results. For more information about using parameters, see [Parameters](https://docs.github.com/enterprise-server@3.13/rest/guides/getting-started-with-the-rest-api#parameters).Anyone with read access to the repository can use this endpoint.OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.This API will return up to 1,000 results for each search when using the following parameters: `actor`, `branch`, `check_suite_id`, `created`, `event`, `head_sha`, `status`.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class RunsRequestBuilderGetQueryParameters 
        {
            /// <summary>Returns someone&apos;s workflow runs. Use the login for the user who created the `push` associated with the check suite or workflow run.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("actor")]
            public string? Actor { get; set; }
#nullable restore
#else
            [QueryParameter("actor")]
            public string Actor { get; set; }
#endif
            /// <summary>Returns workflow runs associated with a branch. Use the name of the branch of the `push`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("branch")]
            public string? Branch { get; set; }
#nullable restore
#else
            [QueryParameter("branch")]
            public string Branch { get; set; }
#endif
            /// <summary>Returns workflow runs with the `check_suite_id` that you specify.</summary>
            [QueryParameter("check_suite_id")]
            public int? CheckSuiteId { get; set; }
            /// <summary>Returns workflow runs created within the given date-time range. For more information on the syntax, see &quot;[Understanding the search syntax](https://docs.github.com/enterprise-server@3.13/search-github/getting-started-with-searching-on-github/understanding-the-search-syntax#query-for-dates).&quot;</summary>
            [QueryParameter("created")]
            public DateTimeOffset? Created { get; set; }
            /// <summary>Returns workflow run triggered by the event you specify. For example, `push`, `pull_request` or `issue`. For more information, see &quot;[Events that trigger workflows](https://docs.github.com/enterprise-server@3.13/actions/automating-your-workflow-with-github-actions/events-that-trigger-workflows).&quot;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("event")]
            public string? Event { get; set; }
#nullable restore
#else
            [QueryParameter("event")]
            public string Event { get; set; }
#endif
            /// <summary>If `true` pull requests are omitted from the response (empty array).</summary>
            [QueryParameter("exclude_pull_requests")]
            public bool? ExcludePullRequests { get; set; }
            /// <summary>Only returns workflow runs that are associated with the specified `head_sha`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("head_sha")]
            public string? HeadSha { get; set; }
#nullable restore
#else
            [QueryParameter("head_sha")]
            public string HeadSha { get; set; }
#endif
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.13/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.13/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>Returns workflow runs with the check run `status` or `conclusion` that you specify. For example, a conclusion can be `success` or a status can be `in_progress`. Only GitHub Actions can set a status of `waiting`, `pending`, or `requested`.</summary>
            [QueryParameter("status")]
            public global::GitHub.Repos.Item.Item.Actions.Runs.GetStatusQueryParameterType? Status { get; set; }
        }
    }
}
