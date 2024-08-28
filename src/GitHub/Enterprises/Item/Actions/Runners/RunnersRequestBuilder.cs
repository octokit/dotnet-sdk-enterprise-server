// <auto-generated/>
using GitHub.Enterprises.Item.Actions.Runners.Downloads;
using GitHub.Enterprises.Item.Actions.Runners.GenerateJitconfig;
using GitHub.Enterprises.Item.Actions.Runners.Item;
using GitHub.Enterprises.Item.Actions.Runners.RegistrationToken;
using GitHub.Enterprises.Item.Actions.Runners.RemoveToken;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Enterprises.Item.Actions.Runners
{
    /// <summary>
    /// Builds and executes requests for operations under \enterprises\{enterprise}\actions\runners
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class RunnersRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The downloads property</summary>
        public global::GitHub.Enterprises.Item.Actions.Runners.Downloads.DownloadsRequestBuilder Downloads
        {
            get => new global::GitHub.Enterprises.Item.Actions.Runners.Downloads.DownloadsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The generateJitconfig property</summary>
        public global::GitHub.Enterprises.Item.Actions.Runners.GenerateJitconfig.GenerateJitconfigRequestBuilder GenerateJitconfig
        {
            get => new global::GitHub.Enterprises.Item.Actions.Runners.GenerateJitconfig.GenerateJitconfigRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The registrationToken property</summary>
        public global::GitHub.Enterprises.Item.Actions.Runners.RegistrationToken.RegistrationTokenRequestBuilder RegistrationToken
        {
            get => new global::GitHub.Enterprises.Item.Actions.Runners.RegistrationToken.RegistrationTokenRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The removeToken property</summary>
        public global::GitHub.Enterprises.Item.Actions.Runners.RemoveToken.RemoveTokenRequestBuilder RemoveToken
        {
            get => new global::GitHub.Enterprises.Item.Actions.Runners.RemoveToken.RemoveTokenRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the GitHub.enterprises.item.actions.runners.item collection</summary>
        /// <param name="position">Unique identifier of the self-hosted runner.</param>
        /// <returns>A <see cref="global::GitHub.Enterprises.Item.Actions.Runners.Item.WithRunner_ItemRequestBuilder"/></returns>
        public global::GitHub.Enterprises.Item.Actions.Runners.Item.WithRunner_ItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("runner_id", position);
                return new global::GitHub.Enterprises.Item.Actions.Runners.Item.WithRunner_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Enterprises.Item.Actions.Runners.RunnersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RunnersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/enterprises/{enterprise}/actions/runners{?name*,page*,per_page*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Enterprises.Item.Actions.Runners.RunnersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RunnersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/enterprises/{enterprise}/actions/runners{?name*,page*,per_page*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists all self-hosted runners configured for an enterprise.OAuth app tokens and personal access tokens (classic) need the `manage_runners:enterprise` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.12/rest/actions/self-hosted-runners#list-self-hosted-runners-for-an-enterprise" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Enterprises.Item.Actions.Runners.RunnersGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Enterprises.Item.Actions.Runners.RunnersGetResponse?> GetAsync(Action<RequestConfiguration<global::GitHub.Enterprises.Item.Actions.Runners.RunnersRequestBuilder.RunnersRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Enterprises.Item.Actions.Runners.RunnersGetResponse> GetAsync(Action<RequestConfiguration<global::GitHub.Enterprises.Item.Actions.Runners.RunnersRequestBuilder.RunnersRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::GitHub.Enterprises.Item.Actions.Runners.RunnersGetResponse>(requestInfo, global::GitHub.Enterprises.Item.Actions.Runners.RunnersGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists all self-hosted runners configured for an enterprise.OAuth app tokens and personal access tokens (classic) need the `manage_runners:enterprise` scope to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Enterprises.Item.Actions.Runners.RunnersRequestBuilder.RunnersRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Enterprises.Item.Actions.Runners.RunnersRequestBuilder.RunnersRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Enterprises.Item.Actions.Runners.RunnersRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Enterprises.Item.Actions.Runners.RunnersRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Enterprises.Item.Actions.Runners.RunnersRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists all self-hosted runners configured for an enterprise.OAuth app tokens and personal access tokens (classic) need the `manage_runners:enterprise` scope to use this endpoint.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class RunnersRequestBuilderGetQueryParameters 
        {
            /// <summary>The name of a self-hosted runner.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("name")]
            public string? Name { get; set; }
#nullable restore
#else
            [QueryParameter("name")]
            public string Name { get; set; }
#endif
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.12/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.12/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
        }
    }
}
