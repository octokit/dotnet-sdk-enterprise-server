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
namespace GitHub.Repos.Item.Item.Git.Trees.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\git\trees\{tree_sha}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class WithTree_shaItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Git.Trees.Item.WithTree_shaItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTree_shaItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/git/trees/{tree_sha}{?recursive*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Git.Trees.Item.WithTree_shaItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTree_shaItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/git/trees/{tree_sha}{?recursive*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns a single tree using the SHA1 value or ref name for that tree.If `truncated` is `true` in the response then the number of items in the `tree` array exceeded our maximum limit. If you need to fetch more items, use the non-recursive method of fetching trees, and fetch one sub-tree at a time.&gt; [!NOTE]&gt; The limit for the `tree` array is 100,000 entries with a maximum size of 7 MB when using the `recursive` parameter.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.13/rest/git/trees#get-a-tree" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.GitTree"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 409 status code</exception>
        /// <exception cref="global::GitHub.Models.ValidationError">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.GitTree?> GetAsync(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Git.Trees.Item.WithTree_shaItemRequestBuilder.WithTree_shaItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.GitTree> GetAsync(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Git.Trees.Item.WithTree_shaItemRequestBuilder.WithTree_shaItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "409", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "422", global::GitHub.Models.ValidationError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Models.GitTree>(requestInfo, global::GitHub.Models.GitTree.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a single tree using the SHA1 value or ref name for that tree.If `truncated` is `true` in the response then the number of items in the `tree` array exceeded our maximum limit. If you need to fetch more items, use the non-recursive method of fetching trees, and fetch one sub-tree at a time.&gt; [!NOTE]&gt; The limit for the `tree` array is 100,000 entries with a maximum size of 7 MB when using the `recursive` parameter.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Git.Trees.Item.WithTree_shaItemRequestBuilder.WithTree_shaItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Git.Trees.Item.WithTree_shaItemRequestBuilder.WithTree_shaItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Git.Trees.Item.WithTree_shaItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Repos.Item.Item.Git.Trees.Item.WithTree_shaItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Repos.Item.Item.Git.Trees.Item.WithTree_shaItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns a single tree using the SHA1 value or ref name for that tree.If `truncated` is `true` in the response then the number of items in the `tree` array exceeded our maximum limit. If you need to fetch more items, use the non-recursive method of fetching trees, and fetch one sub-tree at a time.&gt; [!NOTE]&gt; The limit for the `tree` array is 100,000 entries with a maximum size of 7 MB when using the `recursive` parameter.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class WithTree_shaItemRequestBuilderGetQueryParameters 
        {
            /// <summary>Setting this parameter to any value returns the objects or subtrees referenced by the tree specified in `:tree_sha`. For example, setting `recursive` to any of the following will enable returning objects or subtrees: `0`, `1`, `&quot;true&quot;`, and `&quot;false&quot;`. Omit this parameter to prevent recursively returning objects or subtrees.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("recursive")]
            public string? Recursive { get; set; }
#nullable restore
#else
            [QueryParameter("recursive")]
            public string Recursive { get; set; }
#endif
        }
    }
}
