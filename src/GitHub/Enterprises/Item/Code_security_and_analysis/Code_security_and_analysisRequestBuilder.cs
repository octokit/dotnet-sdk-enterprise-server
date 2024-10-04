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
namespace GitHub.Enterprises.Item.Code_security_and_analysis
{
    /// <summary>
    /// Builds and executes requests for operations under \enterprises\{enterprise}\code_security_and_analysis
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class Code_security_and_analysisRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Enterprises.Item.Code_security_and_analysis.Code_security_and_analysisRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Code_security_and_analysisRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/enterprises/{enterprise}/code_security_and_analysis", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Enterprises.Item.Code_security_and_analysis.Code_security_and_analysisRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Code_security_and_analysisRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/enterprises/{enterprise}/code_security_and_analysis", rawUrl)
        {
        }
        /// <summary>
        /// Gets code security and analysis settings for the specified enterprise.The authenticated user must be an administrator of the enterprise in order to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `admin:enterprise` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.11/rest/enterprise-admin/code-security-and-analysis#get-code-security-and-analysis-features-for-an-enterprise" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.EnterpriseSecurityAnalysisSettings"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.EnterpriseSecurityAnalysisSettings?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.EnterpriseSecurityAnalysisSettings> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Models.EnterpriseSecurityAnalysisSettings>(requestInfo, global::GitHub.Models.EnterpriseSecurityAnalysisSettings.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Updates the settings for advanced security, Dependabot alerts, secret scanning, and push protection for new repositories in an enterprise.The authenticated user must be an administrator of the enterprise to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `admin:enterprise` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.11/rest/enterprise-admin/code-security-and-analysis#update-code-security-and-analysis-features-for-an-enterprise" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PatchAsync(global::GitHub.Enterprises.Item.Code_security_and_analysis.Code_security_and_analysisPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task PatchAsync(global::GitHub.Enterprises.Item.Code_security_and_analysis.Code_security_and_analysisPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets code security and analysis settings for the specified enterprise.The authenticated user must be an administrator of the enterprise in order to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `admin:enterprise` scope to use this endpoint.
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
        /// Updates the settings for advanced security, Dependabot alerts, secret scanning, and push protection for new repositories in an enterprise.The authenticated user must be an administrator of the enterprise to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `admin:enterprise` scope to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::GitHub.Enterprises.Item.Code_security_and_analysis.Code_security_and_analysisPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::GitHub.Enterprises.Item.Code_security_and_analysis.Code_security_and_analysisPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Enterprises.Item.Code_security_and_analysis.Code_security_and_analysisRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Enterprises.Item.Code_security_and_analysis.Code_security_and_analysisRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Enterprises.Item.Code_security_and_analysis.Code_security_and_analysisRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
