// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Admin.PreReceiveEnvironments.Item.Downloads.Latest;
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Admin.PreReceiveEnvironments.Item.Downloads
{
    /// <summary>
    /// Builds and executes requests for operations under \admin\pre-receive-environments\{pre_receive_environment_id}\downloads
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class DownloadsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The latest property</summary>
        public global::GitHub.Admin.PreReceiveEnvironments.Item.Downloads.Latest.LatestRequestBuilder Latest
        {
            get => new global::GitHub.Admin.PreReceiveEnvironments.Item.Downloads.Latest.LatestRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Admin.PreReceiveEnvironments.Item.Downloads.DownloadsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DownloadsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/pre-receive-environments/{pre_receive_environment_id}/downloads", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Admin.PreReceiveEnvironments.Item.Downloads.DownloadsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DownloadsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/pre-receive-environments/{pre_receive_environment_id}/downloads", rawUrl)
        {
        }
        /// <summary>
        /// Triggers a new download of the environment tarball from the environment&apos;s `image_url`. When the download is finished, the newly downloaded tarball will overwrite the existing environment.If a download cannot be triggered, you will receive a `422 Unprocessable Entity` response.The possible error messages are:* _Cannot modify or delete the default environment_* _Can not start a new download when a download is in progress_
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.12/rest/enterprise-admin/pre-receive-environments#start-a-pre-receive-environment-download" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.PreReceiveEnvironmentDownloadStatus"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Admin.PreReceiveEnvironments.Item.Downloads.PreReceiveEnvironmentDownloadStatus422Error">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.PreReceiveEnvironmentDownloadStatus?> PostAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.PreReceiveEnvironmentDownloadStatus> PostAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToPostRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "422", global::GitHub.Admin.PreReceiveEnvironments.Item.Downloads.PreReceiveEnvironmentDownloadStatus422Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Models.PreReceiveEnvironmentDownloadStatus>(requestInfo, global::GitHub.Models.PreReceiveEnvironmentDownloadStatus.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Triggers a new download of the environment tarball from the environment&apos;s `image_url`. When the download is finished, the newly downloaded tarball will overwrite the existing environment.If a download cannot be triggered, you will receive a `422 Unprocessable Entity` response.The possible error messages are:* _Cannot modify or delete the default environment_* _Can not start a new download when a download is in progress_
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Admin.PreReceiveEnvironments.Item.Downloads.DownloadsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Admin.PreReceiveEnvironments.Item.Downloads.DownloadsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Admin.PreReceiveEnvironments.Item.Downloads.DownloadsRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
