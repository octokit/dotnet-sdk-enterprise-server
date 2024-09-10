// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Admin.PreReceiveEnvironments.Item;
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Admin.PreReceiveEnvironments
{
    /// <summary>
    /// Builds and executes requests for operations under \admin\pre-receive-environments
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class PreReceiveEnvironmentsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the GitHub.admin.preReceiveEnvironments.item collection</summary>
        /// <param name="position">The unique identifier of the pre-receive environment.</param>
        /// <returns>A <see cref="global::GitHub.Admin.PreReceiveEnvironments.Item.WithPre_receive_environment_ItemRequestBuilder"/></returns>
        public global::GitHub.Admin.PreReceiveEnvironments.Item.WithPre_receive_environment_ItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("pre_receive_environment_id", position);
                return new global::GitHub.Admin.PreReceiveEnvironments.Item.WithPre_receive_environment_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Admin.PreReceiveEnvironments.PreReceiveEnvironmentsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PreReceiveEnvironmentsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/pre-receive-environments{?direction*,page*,per_page*,sort*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Admin.PreReceiveEnvironments.PreReceiveEnvironmentsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PreReceiveEnvironmentsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/pre-receive-environments{?direction*,page*,per_page*,sort*}", rawUrl)
        {
        }
        /// <summary>
        /// List pre-receive environments
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.13/rest/enterprise-admin/pre-receive-environments#list-pre-receive-environments" />
        /// </summary>
        /// <returns>A List&lt;global::GitHub.Models.PreReceiveEnvironment&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::GitHub.Models.PreReceiveEnvironment>?> GetAsync(Action<RequestConfiguration<global::GitHub.Admin.PreReceiveEnvironments.PreReceiveEnvironmentsRequestBuilder.PreReceiveEnvironmentsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::GitHub.Models.PreReceiveEnvironment>> GetAsync(Action<RequestConfiguration<global::GitHub.Admin.PreReceiveEnvironments.PreReceiveEnvironmentsRequestBuilder.PreReceiveEnvironmentsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::GitHub.Models.PreReceiveEnvironment>(requestInfo, global::GitHub.Models.PreReceiveEnvironment.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Create a pre-receive environment
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.13/rest/enterprise-admin/pre-receive-environments#create-a-pre-receive-environment" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.PreReceiveEnvironment"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.PreReceiveEnvironment?> PostAsync(global::GitHub.Admin.PreReceiveEnvironments.PreReceiveEnvironmentsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.PreReceiveEnvironment> PostAsync(global::GitHub.Admin.PreReceiveEnvironments.PreReceiveEnvironmentsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::GitHub.Models.PreReceiveEnvironment>(requestInfo, global::GitHub.Models.PreReceiveEnvironment.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Admin.PreReceiveEnvironments.PreReceiveEnvironmentsRequestBuilder.PreReceiveEnvironmentsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Admin.PreReceiveEnvironments.PreReceiveEnvironmentsRequestBuilder.PreReceiveEnvironmentsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        public RequestInformation ToPostRequestInformation(global::GitHub.Admin.PreReceiveEnvironments.PreReceiveEnvironmentsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::GitHub.Admin.PreReceiveEnvironments.PreReceiveEnvironmentsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Admin.PreReceiveEnvironments.PreReceiveEnvironmentsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Admin.PreReceiveEnvironments.PreReceiveEnvironmentsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Admin.PreReceiveEnvironments.PreReceiveEnvironmentsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// List pre-receive environments
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class PreReceiveEnvironmentsRequestBuilderGetQueryParameters 
        {
            /// <summary>The direction to sort the results by.</summary>
            [QueryParameter("direction")]
            public global::GitHub.Admin.PreReceiveEnvironments.GetDirectionQueryParameterType? Direction { get; set; }
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.13/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.13/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            [QueryParameter("sort")]
            public global::GitHub.Admin.PreReceiveEnvironments.GetSortQueryParameterType? Sort { get; set; }
        }
    }
}
#pragma warning restore CS0618
