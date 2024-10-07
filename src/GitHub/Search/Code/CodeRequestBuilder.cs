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
namespace GitHub.Search.Code
{
    /// <summary>
    /// Builds and executes requests for operations under \search\code
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class CodeRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Search.Code.CodeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CodeRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/search/code?q={q}{&order*,page*,per_page*,sort*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Search.Code.CodeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CodeRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/search/code?q={q}{&order*,page*,per_page*,sort*}", rawUrl)
        {
        }
        /// <summary>
        /// Searches for query terms inside of a file. This method returns up to 100 results [per page](https://docs.github.com/enterprise-server@3.13/rest/guides/using-pagination-in-the-rest-api).When searching for code, you can get text match metadata for the file **content** and file **path** fields when you pass the `text-match` media type. For more details about how to receive highlighted search results, see [Text match metadata](https://docs.github.com/enterprise-server@3.13/rest/search/search#text-match-metadata).For example, if you want to find the definition of the `addClass` function inside [jQuery](https://github.com/jquery/jquery) repository, your query would look something like this:`q=addClass+in:file+language:js+repo:jquery/jquery`This query searches for the keyword `addClass` within a file&apos;s contents. The query limits the search to files where the language is JavaScript in the `jquery/jquery` repository.Considerations for code search:Due to the complexity of searching code, there are a few restrictions on how searches are performed:*   Only the _default branch_ is considered. In most cases, this will be the `master` branch.*   Only files smaller than 384 KB are searchable.*   You must always include at least one search term when searching source code. For example, searching for [`language:go`](https://github.com/search?utf8=%E2%9C%93&amp;q=language%3Ago&amp;type=Code) is not valid, while [`amazinglanguage:go`](https://github.com/search?utf8=%E2%9C%93&amp;q=amazing+language%3Ago&amp;type=Code) is.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.13/rest/search/search#search-code" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Search.Code.CodeGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 403 status code</exception>
        /// <exception cref="global::GitHub.Models.ValidationError">When receiving a 422 status code</exception>
        /// <exception cref="global::GitHub.Models.Code503Error">When receiving a 503 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Search.Code.CodeGetResponse?> GetAsync(Action<RequestConfiguration<global::GitHub.Search.Code.CodeRequestBuilder.CodeRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Search.Code.CodeGetResponse> GetAsync(Action<RequestConfiguration<global::GitHub.Search.Code.CodeRequestBuilder.CodeRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "403", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "422", global::GitHub.Models.ValidationError.CreateFromDiscriminatorValue },
                { "503", global::GitHub.Models.Code503Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Search.Code.CodeGetResponse>(requestInfo, global::GitHub.Search.Code.CodeGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Searches for query terms inside of a file. This method returns up to 100 results [per page](https://docs.github.com/enterprise-server@3.13/rest/guides/using-pagination-in-the-rest-api).When searching for code, you can get text match metadata for the file **content** and file **path** fields when you pass the `text-match` media type. For more details about how to receive highlighted search results, see [Text match metadata](https://docs.github.com/enterprise-server@3.13/rest/search/search#text-match-metadata).For example, if you want to find the definition of the `addClass` function inside [jQuery](https://github.com/jquery/jquery) repository, your query would look something like this:`q=addClass+in:file+language:js+repo:jquery/jquery`This query searches for the keyword `addClass` within a file&apos;s contents. The query limits the search to files where the language is JavaScript in the `jquery/jquery` repository.Considerations for code search:Due to the complexity of searching code, there are a few restrictions on how searches are performed:*   Only the _default branch_ is considered. In most cases, this will be the `master` branch.*   Only files smaller than 384 KB are searchable.*   You must always include at least one search term when searching source code. For example, searching for [`language:go`](https://github.com/search?utf8=%E2%9C%93&amp;q=language%3Ago&amp;type=Code) is not valid, while [`amazinglanguage:go`](https://github.com/search?utf8=%E2%9C%93&amp;q=amazing+language%3Ago&amp;type=Code) is.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Search.Code.CodeRequestBuilder.CodeRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Search.Code.CodeRequestBuilder.CodeRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Search.Code.CodeRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Search.Code.CodeRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Search.Code.CodeRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Searches for query terms inside of a file. This method returns up to 100 results [per page](https://docs.github.com/enterprise-server@3.13/rest/guides/using-pagination-in-the-rest-api).When searching for code, you can get text match metadata for the file **content** and file **path** fields when you pass the `text-match` media type. For more details about how to receive highlighted search results, see [Text match metadata](https://docs.github.com/enterprise-server@3.13/rest/search/search#text-match-metadata).For example, if you want to find the definition of the `addClass` function inside [jQuery](https://github.com/jquery/jquery) repository, your query would look something like this:`q=addClass+in:file+language:js+repo:jquery/jquery`This query searches for the keyword `addClass` within a file&apos;s contents. The query limits the search to files where the language is JavaScript in the `jquery/jquery` repository.Considerations for code search:Due to the complexity of searching code, there are a few restrictions on how searches are performed:*   Only the _default branch_ is considered. In most cases, this will be the `master` branch.*   Only files smaller than 384 KB are searchable.*   You must always include at least one search term when searching source code. For example, searching for [`language:go`](https://github.com/search?utf8=%E2%9C%93&amp;q=language%3Ago&amp;type=Code) is not valid, while [`amazinglanguage:go`](https://github.com/search?utf8=%E2%9C%93&amp;q=amazing+language%3Ago&amp;type=Code) is.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class CodeRequestBuilderGetQueryParameters 
        {
            /// <summary>Determines whether the first search result returned is the highest number of matches (`desc`) or lowest number of matches (`asc`). This parameter is ignored unless you provide `sort`.</summary>
            [QueryParameter("order")]
            public global::GitHub.Search.Code.GetOrderQueryParameterType? Order { get; set; }
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.13/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.13/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>The query contains one or more search keywords and qualifiers. Qualifiers allow you to limit your search to specific areas of GitHub Enterprise Server. The REST API supports the same qualifiers as the web interface for GitHub Enterprise Server. To learn more about the format of the query, see [Constructing a search query](https://docs.github.com/enterprise-server@3.13/rest/search/search#constructing-a-search-query). See &quot;[Searching code](https://docs.github.com/enterprise-server@3.13/search-github/searching-on-github/searching-code)&quot; for a detailed list of qualifiers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("q")]
            public string? Q { get; set; }
#nullable restore
#else
            [QueryParameter("q")]
            public string Q { get; set; }
#endif
            /// <summary>Sorts the results of your query. Can only be `indexed`, which indicates how recently a file has been indexed by the GitHub Enterprise Server search infrastructure. Default: [best match](https://docs.github.com/enterprise-server@3.13/rest/search/search#ranking-search-results)</summary>
            [QueryParameter("sort")]
            public global::GitHub.Search.Code.GetSortQueryParameterType? Sort { get; set; }
        }
    }
}
#pragma warning restore CS0618
