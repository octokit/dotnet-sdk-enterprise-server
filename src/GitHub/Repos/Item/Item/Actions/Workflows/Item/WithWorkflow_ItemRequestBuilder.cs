// <auto-generated/>
using GitHub.Models;
using GitHub.Repos.Item.Item.Actions.Workflows.Item.Disable;
using GitHub.Repos.Item.Item.Actions.Workflows.Item.Dispatches;
using GitHub.Repos.Item.Item.Actions.Workflows.Item.Enable;
using GitHub.Repos.Item.Item.Actions.Workflows.Item.Runs;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Repos.Item.Item.Actions.Workflows.Item {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\actions\workflows\{workflow_id}
    /// </summary>
    public class WithWorkflow_ItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The disable property</summary>
        public DisableRequestBuilder Disable
        {
            get => new DisableRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The dispatches property</summary>
        public DispatchesRequestBuilder Dispatches
        {
            get => new DispatchesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The enable property</summary>
        public EnableRequestBuilder Enable
        {
            get => new EnableRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The runs property</summary>
        public RunsRequestBuilder Runs
        {
            get => new RunsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="WithWorkflow_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithWorkflow_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/actions/workflows/{workflow_id}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithWorkflow_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithWorkflow_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/actions/workflows/{workflow_id}", rawUrl)
        {
        }
        /// <summary>
        /// Gets a specific workflow. You can replace `workflow_id` with the workflowfile name. For example, you could use `main.yaml`.Anyone with read access to the repository can use this endpoint.OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.13/rest/actions/workflows#get-a-workflow" />
        /// </summary>
        /// <returns>A <see cref="GitHub.Models.Workflow"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<GitHub.Models.Workflow?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<GitHub.Models.Workflow> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<GitHub.Models.Workflow>(requestInfo, GitHub.Models.Workflow.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets a specific workflow. You can replace `workflow_id` with the workflowfile name. For example, you could use `main.yaml`.Anyone with read access to the repository can use this endpoint.OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="WithWorkflow_ItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public WithWorkflow_ItemRequestBuilder WithUrl(string rawUrl)
        {
            return new WithWorkflow_ItemRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
