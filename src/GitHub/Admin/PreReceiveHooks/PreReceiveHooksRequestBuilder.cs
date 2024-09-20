// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Admin.PreReceiveHooks.Item;
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Admin.PreReceiveHooks
{
    /// <summary>
    /// Builds and executes requests for operations under \admin\pre-receive-hooks
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class PreReceiveHooksRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the GitHub.admin.preReceiveHooks.item collection</summary>
        /// <param name="position">The unique identifier of the pre-receive hook.</param>
        /// <returns>A <see cref="global::GitHub.Admin.PreReceiveHooks.Item.WithPre_receive_hook_ItemRequestBuilder"/></returns>
        public global::GitHub.Admin.PreReceiveHooks.Item.WithPre_receive_hook_ItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("pre_receive_hook_id", position);
                return new global::GitHub.Admin.PreReceiveHooks.Item.WithPre_receive_hook_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Admin.PreReceiveHooks.PreReceiveHooksRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PreReceiveHooksRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/pre-receive-hooks{?direction*,page*,per_page*,sort*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Admin.PreReceiveHooks.PreReceiveHooksRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PreReceiveHooksRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/pre-receive-hooks{?direction*,page*,per_page*,sort*}", rawUrl)
        {
        }
        /// <summary>
        /// List pre-receive hooks
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.13/rest/enterprise-admin/pre-receive-hooks#list-pre-receive-hooks" />
        /// </summary>
        /// <returns>A List&lt;global::GitHub.Models.PreReceiveHook&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::GitHub.Models.PreReceiveHook>?> GetAsync(Action<RequestConfiguration<global::GitHub.Admin.PreReceiveHooks.PreReceiveHooksRequestBuilder.PreReceiveHooksRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::GitHub.Models.PreReceiveHook>> GetAsync(Action<RequestConfiguration<global::GitHub.Admin.PreReceiveHooks.PreReceiveHooksRequestBuilder.PreReceiveHooksRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::GitHub.Models.PreReceiveHook>(requestInfo, global::GitHub.Models.PreReceiveHook.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Create a pre-receive hook
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.13/rest/enterprise-admin/pre-receive-hooks#create-a-pre-receive-hook" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.PreReceiveHook"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.PreReceiveHook?> PostAsync(global::GitHub.Admin.PreReceiveHooks.PreReceiveHooksPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.PreReceiveHook> PostAsync(global::GitHub.Admin.PreReceiveHooks.PreReceiveHooksPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::GitHub.Models.PreReceiveHook>(requestInfo, global::GitHub.Models.PreReceiveHook.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Admin.PreReceiveHooks.PreReceiveHooksRequestBuilder.PreReceiveHooksRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Admin.PreReceiveHooks.PreReceiveHooksRequestBuilder.PreReceiveHooksRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::GitHub.Admin.PreReceiveHooks.PreReceiveHooksPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::GitHub.Admin.PreReceiveHooks.PreReceiveHooksPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Admin.PreReceiveHooks.PreReceiveHooksRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Admin.PreReceiveHooks.PreReceiveHooksRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Admin.PreReceiveHooks.PreReceiveHooksRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// List pre-receive hooks
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class PreReceiveHooksRequestBuilderGetQueryParameters 
        {
            /// <summary>The direction to sort the results by.</summary>
            [QueryParameter("direction")]
            public global::GitHub.Admin.PreReceiveHooks.GetDirectionQueryParameterType? Direction { get; set; }
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.13/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.13/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>The property to sort the results by.</summary>
            [QueryParameter("sort")]
            public global::GitHub.Admin.PreReceiveHooks.GetSortQueryParameterType? Sort { get; set; }
        }
    }
}
#pragma warning restore CS0618
