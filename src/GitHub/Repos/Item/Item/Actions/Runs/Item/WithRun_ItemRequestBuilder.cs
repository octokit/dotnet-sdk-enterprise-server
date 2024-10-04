// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Models;
using GitHub.Repos.Item.Item.Actions.Runs.Item.Approvals;
using GitHub.Repos.Item.Item.Actions.Runs.Item.Artifacts;
using GitHub.Repos.Item.Item.Actions.Runs.Item.Attempts;
using GitHub.Repos.Item.Item.Actions.Runs.Item.Cancel;
using GitHub.Repos.Item.Item.Actions.Runs.Item.Deployment_protection_rule;
using GitHub.Repos.Item.Item.Actions.Runs.Item.ForceCancel;
using GitHub.Repos.Item.Item.Actions.Runs.Item.Jobs;
using GitHub.Repos.Item.Item.Actions.Runs.Item.Logs;
using GitHub.Repos.Item.Item.Actions.Runs.Item.Pending_deployments;
using GitHub.Repos.Item.Item.Actions.Runs.Item.Rerun;
using GitHub.Repos.Item.Item.Actions.Runs.Item.RerunFailedJobs;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Repos.Item.Item.Actions.Runs.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\actions\runs\{run_id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class WithRun_ItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The approvals property</summary>
        public global::GitHub.Repos.Item.Item.Actions.Runs.Item.Approvals.ApprovalsRequestBuilder Approvals
        {
            get => new global::GitHub.Repos.Item.Item.Actions.Runs.Item.Approvals.ApprovalsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The artifacts property</summary>
        public global::GitHub.Repos.Item.Item.Actions.Runs.Item.Artifacts.ArtifactsRequestBuilder Artifacts
        {
            get => new global::GitHub.Repos.Item.Item.Actions.Runs.Item.Artifacts.ArtifactsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The attempts property</summary>
        public global::GitHub.Repos.Item.Item.Actions.Runs.Item.Attempts.AttemptsRequestBuilder Attempts
        {
            get => new global::GitHub.Repos.Item.Item.Actions.Runs.Item.Attempts.AttemptsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The cancel property</summary>
        public global::GitHub.Repos.Item.Item.Actions.Runs.Item.Cancel.CancelRequestBuilder Cancel
        {
            get => new global::GitHub.Repos.Item.Item.Actions.Runs.Item.Cancel.CancelRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deployment_protection_rule property</summary>
        public global::GitHub.Repos.Item.Item.Actions.Runs.Item.Deployment_protection_rule.Deployment_protection_ruleRequestBuilder Deployment_protection_rule
        {
            get => new global::GitHub.Repos.Item.Item.Actions.Runs.Item.Deployment_protection_rule.Deployment_protection_ruleRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The forceCancel property</summary>
        public global::GitHub.Repos.Item.Item.Actions.Runs.Item.ForceCancel.ForceCancelRequestBuilder ForceCancel
        {
            get => new global::GitHub.Repos.Item.Item.Actions.Runs.Item.ForceCancel.ForceCancelRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The jobs property</summary>
        public global::GitHub.Repos.Item.Item.Actions.Runs.Item.Jobs.JobsRequestBuilder Jobs
        {
            get => new global::GitHub.Repos.Item.Item.Actions.Runs.Item.Jobs.JobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The logs property</summary>
        public global::GitHub.Repos.Item.Item.Actions.Runs.Item.Logs.LogsRequestBuilder Logs
        {
            get => new global::GitHub.Repos.Item.Item.Actions.Runs.Item.Logs.LogsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The pending_deployments property</summary>
        public global::GitHub.Repos.Item.Item.Actions.Runs.Item.Pending_deployments.Pending_deploymentsRequestBuilder Pending_deployments
        {
            get => new global::GitHub.Repos.Item.Item.Actions.Runs.Item.Pending_deployments.Pending_deploymentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The rerun property</summary>
        public global::GitHub.Repos.Item.Item.Actions.Runs.Item.Rerun.RerunRequestBuilder Rerun
        {
            get => new global::GitHub.Repos.Item.Item.Actions.Runs.Item.Rerun.RerunRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The rerunFailedJobs property</summary>
        public global::GitHub.Repos.Item.Item.Actions.Runs.Item.RerunFailedJobs.RerunFailedJobsRequestBuilder RerunFailedJobs
        {
            get => new global::GitHub.Repos.Item.Item.Actions.Runs.Item.RerunFailedJobs.RerunFailedJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Actions.Runs.Item.WithRun_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithRun_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/actions/runs/{run_id}{?exclude_pull_requests*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Actions.Runs.Item.WithRun_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithRun_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/actions/runs/{run_id}{?exclude_pull_requests*}", rawUrl)
        {
        }
        /// <summary>
        /// Deletes a specific workflow run.Anyone with write access to the repository can use this endpoint.If the repository is private, OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.13/rest/actions/workflow-runs#delete-a-workflow-run" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets a specific workflow run.Anyone with read access to the repository can use this endpoint.OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.13/rest/actions/workflow-runs#get-a-workflow-run" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.WorkflowRun"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.WorkflowRun?> GetAsync(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Actions.Runs.Item.WithRun_ItemRequestBuilder.WithRun_ItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.WorkflowRun> GetAsync(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Actions.Runs.Item.WithRun_ItemRequestBuilder.WithRun_ItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::GitHub.Models.WorkflowRun>(requestInfo, global::GitHub.Models.WorkflowRun.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Deletes a specific workflow run.Anyone with write access to the repository can use this endpoint.If the repository is private, OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            return requestInfo;
        }
        /// <summary>
        /// Gets a specific workflow run.Anyone with read access to the repository can use this endpoint.OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Actions.Runs.Item.WithRun_ItemRequestBuilder.WithRun_ItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Actions.Runs.Item.WithRun_ItemRequestBuilder.WithRun_ItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Actions.Runs.Item.WithRun_ItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Repos.Item.Item.Actions.Runs.Item.WithRun_ItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Repos.Item.Item.Actions.Runs.Item.WithRun_ItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Gets a specific workflow run.Anyone with read access to the repository can use this endpoint.OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class WithRun_ItemRequestBuilderGetQueryParameters 
        {
            /// <summary>If `true` pull requests are omitted from the response (empty array).</summary>
            [QueryParameter("exclude_pull_requests")]
            public bool? ExcludePullRequests { get; set; }
        }
    }
}
#pragma warning restore CS0618
