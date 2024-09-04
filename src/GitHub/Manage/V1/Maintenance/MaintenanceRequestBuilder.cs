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
namespace GitHub.Manage.V1.Maintenance
{
    /// <summary>
    /// Builds and executes requests for operations under \manage\v1\maintenance
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class MaintenanceRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Manage.V1.Maintenance.MaintenanceRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MaintenanceRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/manage/v1/maintenance{?cluster_roles*,uuid*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Manage.V1.Maintenance.MaintenanceRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MaintenanceRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/manage/v1/maintenance{?cluster_roles*,uuid*}", rawUrl)
        {
        }
        /// <summary>
        /// Gets the status and details of maintenance mode on all available nodes. For more information, see &quot;[Enabling and scheduling maintenance mode](https://docs.github.com/enterprise-server@3.14/admin/configuration/configuring-your-enterprise/enabling-and-scheduling-maintenance-mode).&quot;
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.14/rest/enterprise-admin/manage-ghes#get-the-status-of-maintenance-mode" />
        /// </summary>
        /// <returns>A List&lt;global::GitHub.Models.GhesGetMaintenance&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::GitHub.Models.GhesGetMaintenance>?> GetAsync(Action<RequestConfiguration<global::GitHub.Manage.V1.Maintenance.MaintenanceRequestBuilder.MaintenanceRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::GitHub.Models.GhesGetMaintenance>> GetAsync(Action<RequestConfiguration<global::GitHub.Manage.V1.Maintenance.MaintenanceRequestBuilder.MaintenanceRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::GitHub.Models.GhesGetMaintenance>(requestInfo, global::GitHub.Models.GhesGetMaintenance.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Sets or schedules the maintenance mode. For more information, see &quot;[Enabling and scheduling maintenance mode](https://docs.github.com/enterprise-server@3.14/admin/configuration/configuring-your-enterprise/enabling-and-scheduling-maintenance-mode).&quot;
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.14/rest/enterprise-admin/manage-ghes#set-the-status-of-maintenance-mode" />
        /// </summary>
        /// <returns>A List&lt;global::GitHub.Models.GhesSetMaintenanceResponse&gt;</returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::GitHub.Models.GhesSetMaintenanceResponse>?> PostAsync(global::GitHub.Models.GhesSetMaintenanceRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::GitHub.Models.GhesSetMaintenanceResponse>> PostAsync(global::GitHub.Models.GhesSetMaintenanceRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::GitHub.Models.GhesSetMaintenanceResponse>(requestInfo, global::GitHub.Models.GhesSetMaintenanceResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Gets the status and details of maintenance mode on all available nodes. For more information, see &quot;[Enabling and scheduling maintenance mode](https://docs.github.com/enterprise-server@3.14/admin/configuration/configuring-your-enterprise/enabling-and-scheduling-maintenance-mode).&quot;
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Manage.V1.Maintenance.MaintenanceRequestBuilder.MaintenanceRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Manage.V1.Maintenance.MaintenanceRequestBuilder.MaintenanceRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Sets or schedules the maintenance mode. For more information, see &quot;[Enabling and scheduling maintenance mode](https://docs.github.com/enterprise-server@3.14/admin/configuration/configuring-your-enterprise/enabling-and-scheduling-maintenance-mode).&quot;
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::GitHub.Models.GhesSetMaintenanceRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::GitHub.Models.GhesSetMaintenanceRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Manage.V1.Maintenance.MaintenanceRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Manage.V1.Maintenance.MaintenanceRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Manage.V1.Maintenance.MaintenanceRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Gets the status and details of maintenance mode on all available nodes. For more information, see &quot;[Enabling and scheduling maintenance mode](https://docs.github.com/enterprise-server@3.14/admin/configuration/configuring-your-enterprise/enabling-and-scheduling-maintenance-mode).&quot;
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class MaintenanceRequestBuilderGetQueryParameters 
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
