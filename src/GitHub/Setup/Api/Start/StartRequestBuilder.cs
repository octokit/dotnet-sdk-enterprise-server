// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Setup.Api.Start
{
    /// <summary>
    /// Builds and executes requests for operations under \setup\api\start
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class StartRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Setup.Api.Start.StartRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public StartRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/setup/api/start", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Setup.Api.Start.StartRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public StartRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/setup/api/start", rawUrl)
        {
        }
        /// <summary>
        /// When you boot a GitHub instance for the first time, you can use the following endpoint to upload a license.Note that you need to `POST` to [`/setup/api/configure`](https://docs.github.com/enterprise-server@3.14/rest/enterprise-admin/management-console#start-a-configuration-process) to start the actual configuration process.When using this endpoint, your GitHub instance must have a password set. This can be accomplished two ways:1.  If you&apos;re working directly with the API before accessing the web interface, you must pass in the password parameter to set your password.2.  If you set up your instance via the web interface before accessing the API, your calls to this endpoint do not need the password parameter.&gt; [!NOTE]&gt; The request body for this operation must be submitted as `multipart/form-data` data. You can can reference the license file by prefixing the filename with the `@` symbol using `curl`. For more information, see the [`curl` documentation](https://curl.se/docs/manpage.html#-F).
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.14/rest/enterprise-admin/management-console#create-a-github-license" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PostAsync(global::GitHub.Setup.Api.Start.StartPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task PostAsync(global::GitHub.Setup.Api.Start.StartPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// When you boot a GitHub instance for the first time, you can use the following endpoint to upload a license.Note that you need to `POST` to [`/setup/api/configure`](https://docs.github.com/enterprise-server@3.14/rest/enterprise-admin/management-console#start-a-configuration-process) to start the actual configuration process.When using this endpoint, your GitHub instance must have a password set. This can be accomplished two ways:1.  If you&apos;re working directly with the API before accessing the web interface, you must pass in the password parameter to set your password.2.  If you set up your instance via the web interface before accessing the API, your calls to this endpoint do not need the password parameter.&gt; [!NOTE]&gt; The request body for this operation must be submitted as `multipart/form-data` data. You can can reference the license file by prefixing the filename with the `@` symbol using `curl`. For more information, see the [`curl` documentation](https://curl.se/docs/manpage.html#-F).
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::GitHub.Setup.Api.Start.StartPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::GitHub.Setup.Api.Start.StartPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.SetContentFromParsable(RequestAdapter, "multipart/form-data", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Setup.Api.Start.StartRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Setup.Api.Start.StartRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Setup.Api.Start.StartRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
