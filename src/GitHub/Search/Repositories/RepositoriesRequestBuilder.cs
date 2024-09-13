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
namespace GitHub.Search.Repositories
{
    /// <summary>
    /// Builds and executes requests for operations under \search\repositories
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class RepositoriesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Search.Repositories.RepositoriesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RepositoriesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/search/repositories?q={q}{&order*,page*,per_page*,sort*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Search.Repositories.RepositoriesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RepositoriesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/search/repositories?q={q}{&order*,page*,per_page*,sort*}", rawUrl)
        {
        }
        /// <summary>
        /// Find repositories via various criteria. This method returns up to 100 results [per page](https://docs.github.com/enterprise-server@3.14/rest/guides/using-pagination-in-the-rest-api).When searching for repositories, you can get text match metadata for the **name** and **description** fields when you pass the `text-match` media type. For more details about how to receive highlighted search results, see [Text match metadata](https://docs.github.com/enterprise-server@3.14/rest/search/search#text-match-metadata).For example, if you want to search for popular Tetris repositories written in assembly code, your query might look like this:`q=tetris+language:assembly&amp;sort=stars&amp;order=desc`This query searches for repositories with the word `tetris` in the name, the description, or the README. The results are limited to repositories where the primary language is assembly. The results are sorted by stars in descending order, so that the most popular repositories appear first in the search results.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.14/rest/search/search#search-repositories" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Search.Repositories.RepositoriesGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.ValidationError">When receiving a 422 status code</exception>
        /// <exception cref="global::GitHub.Models.Repositories503Error">When receiving a 503 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Search.Repositories.RepositoriesGetResponse?> GetAsync(Action<RequestConfiguration<global::GitHub.Search.Repositories.RepositoriesRequestBuilder.RepositoriesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Search.Repositories.RepositoriesGetResponse> GetAsync(Action<RequestConfiguration<global::GitHub.Search.Repositories.RepositoriesRequestBuilder.RepositoriesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "422", global::GitHub.Models.ValidationError.CreateFromDiscriminatorValue },
                { "503", global::GitHub.Models.Repositories503Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Search.Repositories.RepositoriesGetResponse>(requestInfo, global::GitHub.Search.Repositories.RepositoriesGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Find repositories via various criteria. This method returns up to 100 results [per page](https://docs.github.com/enterprise-server@3.14/rest/guides/using-pagination-in-the-rest-api).When searching for repositories, you can get text match metadata for the **name** and **description** fields when you pass the `text-match` media type. For more details about how to receive highlighted search results, see [Text match metadata](https://docs.github.com/enterprise-server@3.14/rest/search/search#text-match-metadata).For example, if you want to search for popular Tetris repositories written in assembly code, your query might look like this:`q=tetris+language:assembly&amp;sort=stars&amp;order=desc`This query searches for repositories with the word `tetris` in the name, the description, or the README. The results are limited to repositories where the primary language is assembly. The results are sorted by stars in descending order, so that the most popular repositories appear first in the search results.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Search.Repositories.RepositoriesRequestBuilder.RepositoriesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Search.Repositories.RepositoriesRequestBuilder.RepositoriesRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Search.Repositories.RepositoriesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Search.Repositories.RepositoriesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Search.Repositories.RepositoriesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Find repositories via various criteria. This method returns up to 100 results [per page](https://docs.github.com/enterprise-server@3.14/rest/guides/using-pagination-in-the-rest-api).When searching for repositories, you can get text match metadata for the **name** and **description** fields when you pass the `text-match` media type. For more details about how to receive highlighted search results, see [Text match metadata](https://docs.github.com/enterprise-server@3.14/rest/search/search#text-match-metadata).For example, if you want to search for popular Tetris repositories written in assembly code, your query might look like this:`q=tetris+language:assembly&amp;sort=stars&amp;order=desc`This query searches for repositories with the word `tetris` in the name, the description, or the README. The results are limited to repositories where the primary language is assembly. The results are sorted by stars in descending order, so that the most popular repositories appear first in the search results.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class RepositoriesRequestBuilderGetQueryParameters 
        {
            /// <summary>Determines whether the first search result returned is the highest number of matches (`desc`) or lowest number of matches (`asc`). This parameter is ignored unless you provide `sort`.</summary>
            [QueryParameter("order")]
            public global::GitHub.Search.Repositories.GetOrderQueryParameterType? Order { get; set; }
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.14/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.14/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>The query contains one or more search keywords and qualifiers. Qualifiers allow you to limit your search to specific areas of GitHub Enterprise Server. The REST API supports the same qualifiers as the web interface for GitHub Enterprise Server. To learn more about the format of the query, see [Constructing a search query](https://docs.github.com/enterprise-server@3.14/rest/search/search#constructing-a-search-query). See &quot;[Searching for repositories](https://docs.github.com/enterprise-server@3.14/articles/searching-for-repositories/)&quot; for a detailed list of qualifiers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("q")]
            public string? Q { get; set; }
#nullable restore
#else
            [QueryParameter("q")]
            public string Q { get; set; }
#endif
            /// <summary>Sorts the results of your query by number of `stars`, `forks`, or `help-wanted-issues` or how recently the items were `updated`. Default: [best match](https://docs.github.com/enterprise-server@3.14/rest/search/search#ranking-search-results)</summary>
            [QueryParameter("sort")]
            public global::GitHub.Search.Repositories.GetSortQueryParameterType? Sort { get; set; }
        }
    }
}
#pragma warning restore CS0618
