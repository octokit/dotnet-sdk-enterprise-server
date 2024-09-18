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
namespace GitHub.Admin.PreReceiveEnvironments.Item.Downloads.Latest
{
    /// <summary>
    /// Builds and executes requests for operations under \admin\pre-receive-environments\{pre_receive_environment_id}\downloads\latest
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class LatestRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Admin.PreReceiveEnvironments.Item.Downloads.Latest.LatestRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LatestRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/pre-receive-environments/{pre_receive_environment_id}/downloads/latest", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Admin.PreReceiveEnvironments.Item.Downloads.Latest.LatestRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LatestRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/pre-receive-environments/{pre_receive_environment_id}/downloads/latest", rawUrl)
        {
        }
        /// <summary>
        /// In addition to seeing the download status at the &quot;[Get a pre-receive environment](#get-a-pre-receive-environment)&quot; endpoint, there is also this separate endpoint for just the download status.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.11/rest/enterprise-admin/pre-receive-environments#get-the-download-status-for-a-pre-receive-environment" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.PreReceiveEnvironmentDownloadStatus"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.PreReceiveEnvironmentDownloadStatus?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.PreReceiveEnvironmentDownloadStatus> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::GitHub.Models.PreReceiveEnvironmentDownloadStatus>(requestInfo, global::GitHub.Models.PreReceiveEnvironmentDownloadStatus.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// In addition to seeing the download status at the &quot;[Get a pre-receive environment](#get-a-pre-receive-environment)&quot; endpoint, there is also this separate endpoint for just the download status.
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
        /// <returns>A <see cref="global::GitHub.Admin.PreReceiveEnvironments.Item.Downloads.Latest.LatestRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Admin.PreReceiveEnvironments.Item.Downloads.Latest.LatestRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Admin.PreReceiveEnvironments.Item.Downloads.Latest.LatestRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
