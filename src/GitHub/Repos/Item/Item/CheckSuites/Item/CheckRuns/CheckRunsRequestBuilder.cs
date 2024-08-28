// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Repos.Item.Item.CheckSuites.Item.CheckRuns
{
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\check-suites\{check_suite_id}\check-runs
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class CheckRunsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.CheckSuites.Item.CheckRuns.CheckRunsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CheckRunsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/check-suites/{check_suite_id}/check-runs{?check_name*,filter*,page*,per_page*,status*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.CheckSuites.Item.CheckRuns.CheckRunsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CheckRunsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/check-suites/{check_suite_id}/check-runs{?check_name*,filter*,page*,per_page*,status*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists check runs for a check suite using its `id`.&gt; [!NOTE]&gt; The endpoints to manage checks only look for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array.OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint on a private repository.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.10/rest/checks/runs#list-check-runs-in-a-check-suite" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.CheckSuites.Item.CheckRuns.CheckRunsGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Repos.Item.Item.CheckSuites.Item.CheckRuns.CheckRunsGetResponse?> GetAsync(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.CheckSuites.Item.CheckRuns.CheckRunsRequestBuilder.CheckRunsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Repos.Item.Item.CheckSuites.Item.CheckRuns.CheckRunsGetResponse> GetAsync(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.CheckSuites.Item.CheckRuns.CheckRunsRequestBuilder.CheckRunsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::GitHub.Repos.Item.Item.CheckSuites.Item.CheckRuns.CheckRunsGetResponse>(requestInfo, global::GitHub.Repos.Item.Item.CheckSuites.Item.CheckRuns.CheckRunsGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists check runs for a check suite using its `id`.&gt; [!NOTE]&gt; The endpoints to manage checks only look for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array.OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint on a private repository.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.CheckSuites.Item.CheckRuns.CheckRunsRequestBuilder.CheckRunsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.CheckSuites.Item.CheckRuns.CheckRunsRequestBuilder.CheckRunsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.CheckSuites.Item.CheckRuns.CheckRunsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Repos.Item.Item.CheckSuites.Item.CheckRuns.CheckRunsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Repos.Item.Item.CheckSuites.Item.CheckRuns.CheckRunsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists check runs for a check suite using its `id`.&gt; [!NOTE]&gt; The endpoints to manage checks only look for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array.OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint on a private repository.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class CheckRunsRequestBuilderGetQueryParameters 
        {
            /// <summary>Returns check runs with the specified `name`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("check_name")]
            public string? CheckName { get; set; }
#nullable restore
#else
            [QueryParameter("check_name")]
            public string CheckName { get; set; }
#endif
            /// <summary>Filters check runs by their `completed_at` timestamp. `latest` returns the most recent check runs.</summary>
            [QueryParameter("filter")]
            public global::GitHub.Repos.Item.Item.CheckSuites.Item.CheckRuns.GetFilterQueryParameterType? Filter { get; set; }
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.10/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.10/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>Returns check runs with the specified `status`.</summary>
            [QueryParameter("status")]
            public global::GitHub.Repos.Item.Item.CheckSuites.Item.CheckRuns.GetStatusQueryParameterType? Status { get; set; }
        }
    }
}
