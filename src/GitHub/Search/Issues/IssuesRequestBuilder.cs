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
namespace GitHub.Search.Issues
{
    /// <summary>
    /// Builds and executes requests for operations under \search\issues
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class IssuesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Search.Issues.IssuesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IssuesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/search/issues?q={q}{&order*,page*,per_page*,sort*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Search.Issues.IssuesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IssuesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/search/issues?q={q}{&order*,page*,per_page*,sort*}", rawUrl)
        {
        }
        /// <summary>
        /// Find issues by state and keyword. This method returns up to 100 results [per page](https://docs.github.com/enterprise-server@3.14/rest/guides/using-pagination-in-the-rest-api).When searching for issues, you can get text match metadata for the issue **title**, issue **body**, and issue **comment body** fields when you pass the `text-match` media type. For more details about how to receive highlightedsearch results, see [Text match metadata](https://docs.github.com/enterprise-server@3.14/rest/search/search#text-match-metadata).For example, if you want to find the oldest unresolved Python bugs on Windows. Your query might look something like this.`q=windows+label:bug+language:python+state:open&amp;sort=created&amp;order=asc`This query searches for the keyword `windows`, within any open issue that is labeled as `bug`. The search runs across repositories whose primary language is Python. The results are sorted by creation date in ascending order, which means the oldest issues appear first in the search results.&gt; [!NOTE]&gt; For requests made by GitHub Apps with a user access token, you can&apos;t retrieve a combination of issues and pull requests in a single query. Requests that don&apos;t include the `is:issue` or `is:pull-request` qualifier will receive an HTTP `422 Unprocessable Entity` response. To get results for both issues and pull requests, you must send separate queries for issues and pull requests. For more information about the `is` qualifier, see &quot;[Searching only issues or pull requests](https://docs.github.com/enterprise-server@3.14/github/searching-for-information-on-github/searching-issues-and-pull-requests#search-only-issues-or-pull-requests).&quot;
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.14/rest/search/search#search-issues-and-pull-requests" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Search.Issues.IssuesGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 403 status code</exception>
        /// <exception cref="global::GitHub.Models.ValidationError">When receiving a 422 status code</exception>
        /// <exception cref="global::GitHub.Models.Issues503Error">When receiving a 503 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Search.Issues.IssuesGetResponse?> GetAsync(Action<RequestConfiguration<global::GitHub.Search.Issues.IssuesRequestBuilder.IssuesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Search.Issues.IssuesGetResponse> GetAsync(Action<RequestConfiguration<global::GitHub.Search.Issues.IssuesRequestBuilder.IssuesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "403", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "422", global::GitHub.Models.ValidationError.CreateFromDiscriminatorValue },
                { "503", global::GitHub.Models.Issues503Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Search.Issues.IssuesGetResponse>(requestInfo, global::GitHub.Search.Issues.IssuesGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Find issues by state and keyword. This method returns up to 100 results [per page](https://docs.github.com/enterprise-server@3.14/rest/guides/using-pagination-in-the-rest-api).When searching for issues, you can get text match metadata for the issue **title**, issue **body**, and issue **comment body** fields when you pass the `text-match` media type. For more details about how to receive highlightedsearch results, see [Text match metadata](https://docs.github.com/enterprise-server@3.14/rest/search/search#text-match-metadata).For example, if you want to find the oldest unresolved Python bugs on Windows. Your query might look something like this.`q=windows+label:bug+language:python+state:open&amp;sort=created&amp;order=asc`This query searches for the keyword `windows`, within any open issue that is labeled as `bug`. The search runs across repositories whose primary language is Python. The results are sorted by creation date in ascending order, which means the oldest issues appear first in the search results.&gt; [!NOTE]&gt; For requests made by GitHub Apps with a user access token, you can&apos;t retrieve a combination of issues and pull requests in a single query. Requests that don&apos;t include the `is:issue` or `is:pull-request` qualifier will receive an HTTP `422 Unprocessable Entity` response. To get results for both issues and pull requests, you must send separate queries for issues and pull requests. For more information about the `is` qualifier, see &quot;[Searching only issues or pull requests](https://docs.github.com/enterprise-server@3.14/github/searching-for-information-on-github/searching-issues-and-pull-requests#search-only-issues-or-pull-requests).&quot;
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Search.Issues.IssuesRequestBuilder.IssuesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Search.Issues.IssuesRequestBuilder.IssuesRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Search.Issues.IssuesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Search.Issues.IssuesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Search.Issues.IssuesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Find issues by state and keyword. This method returns up to 100 results [per page](https://docs.github.com/enterprise-server@3.14/rest/guides/using-pagination-in-the-rest-api).When searching for issues, you can get text match metadata for the issue **title**, issue **body**, and issue **comment body** fields when you pass the `text-match` media type. For more details about how to receive highlightedsearch results, see [Text match metadata](https://docs.github.com/enterprise-server@3.14/rest/search/search#text-match-metadata).For example, if you want to find the oldest unresolved Python bugs on Windows. Your query might look something like this.`q=windows+label:bug+language:python+state:open&amp;sort=created&amp;order=asc`This query searches for the keyword `windows`, within any open issue that is labeled as `bug`. The search runs across repositories whose primary language is Python. The results are sorted by creation date in ascending order, which means the oldest issues appear first in the search results.&gt; [!NOTE]&gt; For requests made by GitHub Apps with a user access token, you can&apos;t retrieve a combination of issues and pull requests in a single query. Requests that don&apos;t include the `is:issue` or `is:pull-request` qualifier will receive an HTTP `422 Unprocessable Entity` response. To get results for both issues and pull requests, you must send separate queries for issues and pull requests. For more information about the `is` qualifier, see &quot;[Searching only issues or pull requests](https://docs.github.com/enterprise-server@3.14/github/searching-for-information-on-github/searching-issues-and-pull-requests#search-only-issues-or-pull-requests).&quot;
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class IssuesRequestBuilderGetQueryParameters 
        {
            /// <summary>Determines whether the first search result returned is the highest number of matches (`desc`) or lowest number of matches (`asc`). This parameter is ignored unless you provide `sort`.</summary>
            [QueryParameter("order")]
            public global::GitHub.Search.Issues.GetOrderQueryParameterType? Order { get; set; }
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.14/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.14/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>The query contains one or more search keywords and qualifiers. Qualifiers allow you to limit your search to specific areas of GitHub Enterprise Server. The REST API supports the same qualifiers as the web interface for GitHub Enterprise Server. To learn more about the format of the query, see [Constructing a search query](https://docs.github.com/enterprise-server@3.14/rest/search/search#constructing-a-search-query). See &quot;[Searching issues and pull requests](https://docs.github.com/enterprise-server@3.14/search-github/searching-on-github/searching-issues-and-pull-requests)&quot; for a detailed list of qualifiers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("q")]
            public string? Q { get; set; }
#nullable restore
#else
            [QueryParameter("q")]
            public string Q { get; set; }
#endif
            /// <summary>Sorts the results of your query by the number of `comments`, `reactions`, `reactions-+1`, `reactions--1`, `reactions-smile`, `reactions-thinking_face`, `reactions-heart`, `reactions-tada`, or `interactions`. You can also sort results by how recently the items were `created` or `updated`, Default: [best match](https://docs.github.com/enterprise-server@3.14/rest/search/search#ranking-search-results)</summary>
            [QueryParameter("sort")]
            public global::GitHub.Search.Issues.GetSortQueryParameterType? Sort { get; set; }
        }
    }
}
#pragma warning restore CS0618
