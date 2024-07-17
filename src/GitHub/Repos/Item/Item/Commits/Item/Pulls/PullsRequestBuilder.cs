// <auto-generated/>
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Repos.Item.Item.Commits.Item.Pulls {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\commits\{commit_sha-id}\pulls
    /// </summary>
    public class PullsRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="PullsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PullsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/commits/{commit_sha%2Did}/pulls{?page*,per_page*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="PullsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PullsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/commits/{commit_sha%2Did}/pulls{?page*,per_page*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists the merged pull request that introduced the commit to the repository. If the commit is not present in the default branch, will only return open pull requests associated with the commit.To list the open or merged pull requests associated with a branch, you can set the `commit_sha` parameter to the branch name.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.12/rest/commits/commits#list-pull-requests-associated-with-a-commit" />
        /// </summary>
        /// <returns>A List&lt;PullRequestSimple&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="BasicError">When receiving a 409 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<PullRequestSimple>?> GetAsync(Action<RequestConfiguration<PullsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<PullRequestSimple>> GetAsync(Action<RequestConfiguration<PullsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"409", BasicError.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<PullRequestSimple>(requestInfo, PullRequestSimple.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Lists the merged pull request that introduced the commit to the repository. If the commit is not present in the default branch, will only return open pull requests associated with the commit.To list the open or merged pull requests associated with a branch, you can set the `commit_sha` parameter to the branch name.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<PullsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<PullsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="PullsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public PullsRequestBuilder WithUrl(string rawUrl)
        {
            return new PullsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists the merged pull request that introduced the commit to the repository. If the commit is not present in the default branch, will only return open pull requests associated with the commit.To list the open or merged pull requests associated with a branch, you can set the `commit_sha` parameter to the branch name.
        /// </summary>
        public class PullsRequestBuilderGetQueryParameters 
        {
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.12/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.12/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
        }
    }
}
