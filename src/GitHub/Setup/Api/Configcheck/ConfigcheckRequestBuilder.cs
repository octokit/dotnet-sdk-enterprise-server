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
namespace GitHub.Setup.Api.Configcheck
{
    /// <summary>
    /// Builds and executes requests for operations under \setup\api\configcheck
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class ConfigcheckRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Setup.Api.Configcheck.ConfigcheckRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ConfigcheckRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/setup/api/configcheck", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Setup.Api.Configcheck.ConfigcheckRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ConfigcheckRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/setup/api/configcheck", rawUrl)
        {
        }
        /// <summary>
        /// This endpoint allows you to check the status of the most recent configuration process:Note that you may need to wait several seconds after you start a process before you can check its status.The different statuses are:| Status        | Description                       || ------------- | --------------------------------- || `PENDING`     | The job has not started yet       || `CONFIGURING` | The job is running                || `DONE`        | The job has finished correctly    || `FAILED`      | The job has finished unexpectedly |
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.11/rest/enterprise-admin/management-console#get-the-configuration-status" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.ConfigurationStatus"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.ConfigurationStatus?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.ConfigurationStatus> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::GitHub.Models.ConfigurationStatus>(requestInfo, global::GitHub.Models.ConfigurationStatus.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// This endpoint allows you to check the status of the most recent configuration process:Note that you may need to wait several seconds after you start a process before you can check its status.The different statuses are:| Status        | Description                       || ------------- | --------------------------------- || `PENDING`     | The job has not started yet       || `CONFIGURING` | The job is running                || `DONE`        | The job has finished correctly    || `FAILED`      | The job has finished unexpectedly |
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
        /// <returns>A <see cref="global::GitHub.Setup.Api.Configcheck.ConfigcheckRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Setup.Api.Configcheck.ConfigcheckRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Setup.Api.Configcheck.ConfigcheckRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
