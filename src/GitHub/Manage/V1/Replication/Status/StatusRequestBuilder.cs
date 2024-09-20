// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Manage.V1.Replication.Status
{
    /// <summary>
    /// Builds and executes requests for operations under \manage\v1\replication\status
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class StatusRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Manage.V1.Replication.Status.StatusRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public StatusRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/manage/v1/replication/status{?cluster_roles*,uuid*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Manage.V1.Replication.Status.StatusRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public StatusRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/manage/v1/replication/status{?cluster_roles*,uuid*}", rawUrl)
        {
        }
        /// <summary>
        /// Gets the status of all services running on each replica node.This endpoint may take several seconds to reply.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.13/rest/enterprise-admin/manage-ghes#get-the-status-of-services-running-on-all-replica-nodes" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.GhesReplicationStatus"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.GhesReplicationStatus?> GetAsync(Action<RequestConfiguration<global::GitHub.Manage.V1.Replication.Status.StatusRequestBuilder.StatusRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.GhesReplicationStatus> GetAsync(Action<RequestConfiguration<global::GitHub.Manage.V1.Replication.Status.StatusRequestBuilder.StatusRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::GitHub.Models.GhesReplicationStatus>(requestInfo, global::GitHub.Models.GhesReplicationStatus.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets the status of all services running on each replica node.This endpoint may take several seconds to reply.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Manage.V1.Replication.Status.StatusRequestBuilder.StatusRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Manage.V1.Replication.Status.StatusRequestBuilder.StatusRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Manage.V1.Replication.Status.StatusRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Manage.V1.Replication.Status.StatusRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Manage.V1.Replication.Status.StatusRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Gets the status of all services running on each replica node.This endpoint may take several seconds to reply.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class StatusRequestBuilderGetQueryParameters 
        {
            /// <summary>The cluster roles from the cluster configuration file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("cluster_roles")]
            public string? ClusterRoles { get; set; }
#nullable restore
#else
            [QueryParameter("cluster_roles")]
            public string ClusterRoles { get; set; }
#endif
            /// <summary>The UUID which identifies a node.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("uuid")]
            public string? Uuid { get; set; }
#nullable restore
#else
            [QueryParameter("uuid")]
            public string Uuid { get; set; }
#endif
        }
    }
}
#pragma warning restore CS0618
