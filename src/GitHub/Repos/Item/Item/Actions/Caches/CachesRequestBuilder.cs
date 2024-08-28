// <auto-generated/>
using GitHub.Models;
using GitHub.Repos.Item.Item.Actions.Caches.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Repos.Item.Item.Actions.Caches
{
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\actions\caches
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class CachesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the GitHub.repos.item.item.actions.caches.item collection</summary>
        /// <param name="position">The unique identifier of the GitHub Actions cache.</param>
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Actions.Caches.Item.WithCache_ItemRequestBuilder"/></returns>
        public global::GitHub.Repos.Item.Item.Actions.Caches.Item.WithCache_ItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("cache_id", position);
                return new global::GitHub.Repos.Item.Item.Actions.Caches.Item.WithCache_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Actions.Caches.CachesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CachesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/actions/caches{?direction*,key*,page*,per_page*,ref*,sort*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Actions.Caches.CachesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CachesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/actions/caches{?direction*,key*,page*,per_page*,ref*,sort*}", rawUrl)
        {
        }
        /// <summary>
        /// Deletes one or more GitHub Actions caches for a repository, using a complete cache key. By default, all caches that match the provided key are deleted, but you can optionally provide a Git ref to restrict deletions to caches that match both the provided key and the Git ref.OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.12/rest/actions/cache#delete-github-actions-caches-for-a-repository-using-a-cache-key" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.ActionsCacheList"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.ActionsCacheList?> DeleteAsync(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Actions.Caches.CachesRequestBuilder.CachesRequestBuilderDeleteQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.ActionsCacheList> DeleteAsync(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Actions.Caches.CachesRequestBuilder.CachesRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::GitHub.Models.ActionsCacheList>(requestInfo, global::GitHub.Models.ActionsCacheList.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists the GitHub Actions caches for a repository.OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.12/rest/actions/cache#list-github-actions-caches-for-a-repository" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.ActionsCacheList"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.ActionsCacheList?> GetAsync(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Actions.Caches.CachesRequestBuilder.CachesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.ActionsCacheList> GetAsync(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Actions.Caches.CachesRequestBuilder.CachesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::GitHub.Models.ActionsCacheList>(requestInfo, global::GitHub.Models.ActionsCacheList.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Deletes one or more GitHub Actions caches for a repository, using a complete cache key. By default, all caches that match the provided key are deleted, but you can optionally provide a Git ref to restrict deletions to caches that match both the provided key and the Git ref.OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Actions.Caches.CachesRequestBuilder.CachesRequestBuilderDeleteQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Actions.Caches.CachesRequestBuilder.CachesRequestBuilderDeleteQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/actions/caches?key={key}{&ref*}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Lists the GitHub Actions caches for a repository.OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Actions.Caches.CachesRequestBuilder.CachesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Actions.Caches.CachesRequestBuilder.CachesRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Actions.Caches.CachesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Repos.Item.Item.Actions.Caches.CachesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Repos.Item.Item.Actions.Caches.CachesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Deletes one or more GitHub Actions caches for a repository, using a complete cache key. By default, all caches that match the provided key are deleted, but you can optionally provide a Git ref to restrict deletions to caches that match both the provided key and the Git ref.OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class CachesRequestBuilderDeleteQueryParameters 
        {
            /// <summary>A key for identifying the cache.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("key")]
            public string? Key { get; set; }
#nullable restore
#else
            [QueryParameter("key")]
            public string Key { get; set; }
#endif
            /// <summary>The full Git reference for narrowing down the cache. The `ref` for a branch should be formatted as `refs/heads/&lt;branch name&gt;`. To reference a pull request use `refs/pull/&lt;number&gt;/merge`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("ref")]
            public string? Ref { get; set; }
#nullable restore
#else
            [QueryParameter("ref")]
            public string Ref { get; set; }
#endif
        }
        /// <summary>
        /// Lists the GitHub Actions caches for a repository.OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class CachesRequestBuilderGetQueryParameters 
        {
            /// <summary>The direction to sort the results by.</summary>
            [QueryParameter("direction")]
            public global::GitHub.Repos.Item.Item.Actions.Caches.GetDirectionQueryParameterType? Direction { get; set; }
            /// <summary>An explicit key or prefix for identifying the cache</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("key")]
            public string? Key { get; set; }
#nullable restore
#else
            [QueryParameter("key")]
            public string Key { get; set; }
#endif
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.12/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.12/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>The full Git reference for narrowing down the cache. The `ref` for a branch should be formatted as `refs/heads/&lt;branch name&gt;`. To reference a pull request use `refs/pull/&lt;number&gt;/merge`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("ref")]
            public string? Ref { get; set; }
#nullable restore
#else
            [QueryParameter("ref")]
            public string Ref { get; set; }
#endif
            /// <summary>The property to sort the results by. `created_at` means when the cache was created. `last_accessed_at` means when the cache was last accessed. `size_in_bytes` is the size of the cache in bytes.</summary>
            [QueryParameter("sort")]
            public global::GitHub.Repos.Item.Item.Actions.Caches.GetSortQueryParameterType? Sort { get; set; }
        }
    }
}
