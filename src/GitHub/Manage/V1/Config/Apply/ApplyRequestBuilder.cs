// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Manage.V1.Config.Apply.Events;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Manage.V1.Config.Apply
{
    /// <summary>
    /// Builds and executes requests for operations under \manage\v1\config\apply
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class ApplyRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The events property</summary>
        public global::GitHub.Manage.V1.Config.Apply.Events.EventsRequestBuilder Events
        {
            get => new global::GitHub.Manage.V1.Config.Apply.Events.EventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Manage.V1.Config.Apply.ApplyRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ApplyRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/manage/v1/config/apply{?run_id*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Manage.V1.Config.Apply.ApplyRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ApplyRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/manage/v1/config/apply{?run_id*}", rawUrl)
        {
        }
        /// <summary>
        /// Displays the current status of `ghe-config-apply` in the environment or the status of a historical run by ID.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.12/rest/enterprise-admin/manage-ghes#get-the-status-of-a-ghe-config-apply-run" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Manage.V1.Config.Apply.ApplyGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Manage.V1.Config.Apply.ApplyGetResponse?> GetAsync(Action<RequestConfiguration<global::GitHub.Manage.V1.Config.Apply.ApplyRequestBuilder.ApplyRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Manage.V1.Config.Apply.ApplyGetResponse> GetAsync(Action<RequestConfiguration<global::GitHub.Manage.V1.Config.Apply.ApplyRequestBuilder.ApplyRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::GitHub.Manage.V1.Config.Apply.ApplyGetResponse>(requestInfo, global::GitHub.Manage.V1.Config.Apply.ApplyGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Triggers a run of `ghe-config-apply` from the `ghes-manage` agent on your Nomad Delegate instance.You can provide a run ID or allow one to be generated randomly.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.12/rest/enterprise-admin/manage-ghes#trigger-a-ghe-config-apply-run" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Manage.V1.Config.Apply.ApplyPostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Manage.V1.Config.Apply.ApplyPostResponse?> PostAsync(global::GitHub.Manage.V1.Config.Apply.ApplyPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Manage.V1.Config.Apply.ApplyPostResponse> PostAsync(global::GitHub.Manage.V1.Config.Apply.ApplyPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::GitHub.Manage.V1.Config.Apply.ApplyPostResponse>(requestInfo, global::GitHub.Manage.V1.Config.Apply.ApplyPostResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Displays the current status of `ghe-config-apply` in the environment or the status of a historical run by ID.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Manage.V1.Config.Apply.ApplyRequestBuilder.ApplyRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Manage.V1.Config.Apply.ApplyRequestBuilder.ApplyRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Triggers a run of `ghe-config-apply` from the `ghes-manage` agent on your Nomad Delegate instance.You can provide a run ID or allow one to be generated randomly.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::GitHub.Manage.V1.Config.Apply.ApplyPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::GitHub.Manage.V1.Config.Apply.ApplyPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Manage.V1.Config.Apply.ApplyRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Manage.V1.Config.Apply.ApplyRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Manage.V1.Config.Apply.ApplyRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Displays the current status of `ghe-config-apply` in the environment or the status of a historical run by ID.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class ApplyRequestBuilderGetQueryParameters 
        {
            /// <summary>The unique run ID of the `ghe-config-apply` run.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("run_id")]
            public string? RunId { get; set; }
#nullable restore
#else
            [QueryParameter("run_id")]
            public string RunId { get; set; }
#endif
        }
    }
}
#pragma warning restore CS0618
