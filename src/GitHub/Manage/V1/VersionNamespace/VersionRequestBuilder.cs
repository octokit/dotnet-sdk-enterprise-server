// <auto-generated/>
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Manage.V1.VersionNamespace {
    /// <summary>
    /// Builds and executes requests for operations under \manage\v1\version
    /// </summary>
    public class VersionRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="VersionRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public VersionRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/manage/v1/version{?cluster_roles*,uuid*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="VersionRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public VersionRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/manage/v1/version{?cluster_roles*,uuid*}", rawUrl)
        {
        }
        /// <summary>
        /// Gets the GitHub Enterprise Server release versions that are currently installed on all available nodes. For more information, see &quot;[GitHub Enterprise Server releases](https://docs.github.com/enterprise-server@3.13/admin/all-releases).&quot;
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.13/rest/enterprise-admin/manage-ghes#get-all-ghes-release-versions-for-all-nodes" />
        /// </summary>
        /// <returns>A List&lt;GhesVersion&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<GhesVersion>?> GetAsync(Action<RequestConfiguration<VersionRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<GhesVersion>> GetAsync(Action<RequestConfiguration<VersionRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<GhesVersion>(requestInfo, GhesVersion.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Gets the GitHub Enterprise Server release versions that are currently installed on all available nodes. For more information, see &quot;[GitHub Enterprise Server releases](https://docs.github.com/enterprise-server@3.13/admin/all-releases).&quot;
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<VersionRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<VersionRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="VersionRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public VersionRequestBuilder WithUrl(string rawUrl)
        {
            return new VersionRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Gets the GitHub Enterprise Server release versions that are currently installed on all available nodes. For more information, see &quot;[GitHub Enterprise Server releases](https://docs.github.com/enterprise-server@3.13/admin/all-releases).&quot;
        /// </summary>
        public class VersionRequestBuilderGetQueryParameters 
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
