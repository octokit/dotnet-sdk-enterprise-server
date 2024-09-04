// <auto-generated/>
using GitHub.Models;
using GitHub.Repos.Item.Item.Actions.Runs.Item.Attempts.Item.Jobs;
using GitHub.Repos.Item.Item.Actions.Runs.Item.Attempts.Item.Logs;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Repos.Item.Item.Actions.Runs.Item.Attempts.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\actions\runs\{run_id}\attempts\{attempt_number}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class WithAttempt_numberItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The jobs property</summary>
        public global::GitHub.Repos.Item.Item.Actions.Runs.Item.Attempts.Item.Jobs.JobsRequestBuilder Jobs
        {
            get => new global::GitHub.Repos.Item.Item.Actions.Runs.Item.Attempts.Item.Jobs.JobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The logs property</summary>
        public global::GitHub.Repos.Item.Item.Actions.Runs.Item.Attempts.Item.Logs.LogsRequestBuilder Logs
        {
            get => new global::GitHub.Repos.Item.Item.Actions.Runs.Item.Attempts.Item.Logs.LogsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Actions.Runs.Item.Attempts.Item.WithAttempt_numberItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithAttempt_numberItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/actions/runs/{run_id}/attempts/{attempt_number}{?exclude_pull_requests*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Actions.Runs.Item.Attempts.Item.WithAttempt_numberItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithAttempt_numberItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/actions/runs/{run_id}/attempts/{attempt_number}{?exclude_pull_requests*}", rawUrl)
        {
        }
        /// <summary>
        /// Gets a specific workflow run attempt.Anyone with read access to the repository can use this endpoint.OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.14/rest/actions/workflow-runs#get-a-workflow-run-attempt" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.WorkflowRun"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.WorkflowRun?> GetAsync(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Actions.Runs.Item.Attempts.Item.WithAttempt_numberItemRequestBuilder.WithAttempt_numberItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.WorkflowRun> GetAsync(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Actions.Runs.Item.Attempts.Item.WithAttempt_numberItemRequestBuilder.WithAttempt_numberItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::GitHub.Models.WorkflowRun>(requestInfo, global::GitHub.Models.WorkflowRun.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets a specific workflow run attempt.Anyone with read access to the repository can use this endpoint.OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Actions.Runs.Item.Attempts.Item.WithAttempt_numberItemRequestBuilder.WithAttempt_numberItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Actions.Runs.Item.Attempts.Item.WithAttempt_numberItemRequestBuilder.WithAttempt_numberItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Actions.Runs.Item.Attempts.Item.WithAttempt_numberItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Repos.Item.Item.Actions.Runs.Item.Attempts.Item.WithAttempt_numberItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Repos.Item.Item.Actions.Runs.Item.Attempts.Item.WithAttempt_numberItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Gets a specific workflow run attempt.Anyone with read access to the repository can use this endpoint.OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class WithAttempt_numberItemRequestBuilderGetQueryParameters 
        {
            /// <summary>If `true` pull requests are omitted from the response (empty array).</summary>
            [QueryParameter("exclude_pull_requests")]
            public bool? ExcludePullRequests { get; set; }
        }
    }
}
