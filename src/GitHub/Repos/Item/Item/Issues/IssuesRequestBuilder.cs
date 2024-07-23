// <auto-generated/>
using GitHub.Models;
using GitHub.Repos.Item.Item.Issues.Comments;
using GitHub.Repos.Item.Item.Issues.Events;
using GitHub.Repos.Item.Item.Issues.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Repos.Item.Item.Issues {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\issues
    /// </summary>
    public class IssuesRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The comments property</summary>
        public CommentsRequestBuilder Comments
        {
            get => new CommentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The events property</summary>
        public EventsRequestBuilder Events
        {
            get => new EventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the GitHub.repos.item.item.issues.item collection</summary>
        /// <param name="position">The number that identifies the issue.</param>
        /// <returns>A <see cref="WithIssue_numberItemRequestBuilder"/></returns>
        public WithIssue_numberItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("issue_number", position);
                return new WithIssue_numberItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="IssuesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IssuesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/issues{?assignee*,creator*,direction*,labels*,mentioned*,milestone*,page*,per_page*,since*,sort*,state*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="IssuesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IssuesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/issues{?assignee*,creator*,direction*,labels*,mentioned*,milestone*,page*,per_page*,since*,sort*,state*}", rawUrl)
        {
        }
        /// <summary>
        /// List issues in a repository. Only open issues will be listed.&gt; [!NOTE]&gt; GitHub&apos;s REST API considers every pull request an issue, but not every issue is a pull request. For this reason, &quot;Issues&quot; endpoints may return both issues and pull requests in the response. You can identify pull requests by the `pull_request` key. Be aware that the `id` of a pull request returned from &quot;Issues&quot; endpoints will be an _issue id_. To find out the pull request id, use the &quot;[List pull requests](https://docs.github.com/enterprise-server@3.10/rest/pulls/pulls#list-pull-requests)&quot; endpoint.This endpoint supports the following custom media types. For more information, see &quot;[Media types](https://docs.github.com/enterprise-server@3.10/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types).&quot;- **`application/vnd.github.raw+json`**: Returns the raw markdown body. Response will include `body`. This is the default if you do not pass any specific media type.- **`application/vnd.github.text+json`**: Returns a text only representation of the markdown body. Response will include `body_text`.- **`application/vnd.github.html+json`**: Returns HTML rendered from the body&apos;s markdown. Response will include `body_html`.- **`application/vnd.github.full+json`**: Returns raw, text, and HTML representations. Response will include `body`, `body_text`, and `body_html`.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.10/rest/issues/issues#list-repository-issues" />
        /// </summary>
        /// <returns>A List&lt;Issue&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
        /// <exception cref="ValidationError">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<Issue>?> GetAsync(Action<RequestConfiguration<IssuesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<Issue>> GetAsync(Action<RequestConfiguration<IssuesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"422", ValidationError.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<Issue>(requestInfo, Issue.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Any user with pull access to a repository can create an issue. If [issues are disabled in the repository](https://docs.github.com/enterprise-server@3.10/articles/disabling-issues/), the API returns a `410 Gone` status.This endpoint triggers [notifications](https://docs.github.com/enterprise-server@3.10/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. For more information, see &quot;[Rate limits for the API](https://docs.github.com/enterprise-server@3.10/rest/using-the-rest-api/rate-limits-for-the-rest-api#about-secondary-rate-limits)&quot;and &quot;[Best practices for using the REST API](https://docs.github.com/enterprise-server@3.10/rest/guides/best-practices-for-using-the-rest-api).&quot;This endpoint supports the following custom media types. For more information, see &quot;[Media types](https://docs.github.com/enterprise-server@3.10/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types).&quot;- **`application/vnd.github.raw+json`**: Returns the raw markdown body. Response will include `body`. This is the default if you do not pass any specific media type.- **`application/vnd.github.text+json`**: Returns a text only representation of the markdown body. Response will include `body_text`.- **`application/vnd.github.html+json`**: Returns HTML rendered from the body&apos;s markdown. Response will include `body_html`.- **`application/vnd.github.full+json`**: Returns raw, text, and HTML representations. Response will include `body`, `body_text`, and `body_html`.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.10/rest/issues/issues#create-an-issue" />
        /// </summary>
        /// <returns>A <see cref="Issue"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="BasicError">When receiving a 400 status code</exception>
        /// <exception cref="BasicError">When receiving a 403 status code</exception>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
        /// <exception cref="BasicError">When receiving a 410 status code</exception>
        /// <exception cref="ValidationError">When receiving a 422 status code</exception>
        /// <exception cref="Issue503Error">When receiving a 503 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Issue?> PostAsync(IssuesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Issue> PostAsync(IssuesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"400", BasicError.CreateFromDiscriminatorValue},
                {"403", BasicError.CreateFromDiscriminatorValue},
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"410", BasicError.CreateFromDiscriminatorValue},
                {"422", ValidationError.CreateFromDiscriminatorValue},
                {"503", Issue503Error.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Issue>(requestInfo, Issue.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List issues in a repository. Only open issues will be listed.&gt; [!NOTE]&gt; GitHub&apos;s REST API considers every pull request an issue, but not every issue is a pull request. For this reason, &quot;Issues&quot; endpoints may return both issues and pull requests in the response. You can identify pull requests by the `pull_request` key. Be aware that the `id` of a pull request returned from &quot;Issues&quot; endpoints will be an _issue id_. To find out the pull request id, use the &quot;[List pull requests](https://docs.github.com/enterprise-server@3.10/rest/pulls/pulls#list-pull-requests)&quot; endpoint.This endpoint supports the following custom media types. For more information, see &quot;[Media types](https://docs.github.com/enterprise-server@3.10/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types).&quot;- **`application/vnd.github.raw+json`**: Returns the raw markdown body. Response will include `body`. This is the default if you do not pass any specific media type.- **`application/vnd.github.text+json`**: Returns a text only representation of the markdown body. Response will include `body_text`.- **`application/vnd.github.html+json`**: Returns HTML rendered from the body&apos;s markdown. Response will include `body_html`.- **`application/vnd.github.full+json`**: Returns raw, text, and HTML representations. Response will include `body`, `body_text`, and `body_html`.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<IssuesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<IssuesRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Any user with pull access to a repository can create an issue. If [issues are disabled in the repository](https://docs.github.com/enterprise-server@3.10/articles/disabling-issues/), the API returns a `410 Gone` status.This endpoint triggers [notifications](https://docs.github.com/enterprise-server@3.10/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. For more information, see &quot;[Rate limits for the API](https://docs.github.com/enterprise-server@3.10/rest/using-the-rest-api/rate-limits-for-the-rest-api#about-secondary-rate-limits)&quot;and &quot;[Best practices for using the REST API](https://docs.github.com/enterprise-server@3.10/rest/guides/best-practices-for-using-the-rest-api).&quot;This endpoint supports the following custom media types. For more information, see &quot;[Media types](https://docs.github.com/enterprise-server@3.10/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types).&quot;- **`application/vnd.github.raw+json`**: Returns the raw markdown body. Response will include `body`. This is the default if you do not pass any specific media type.- **`application/vnd.github.text+json`**: Returns a text only representation of the markdown body. Response will include `body_text`.- **`application/vnd.github.html+json`**: Returns HTML rendered from the body&apos;s markdown. Response will include `body_html`.- **`application/vnd.github.full+json`**: Returns raw, text, and HTML representations. Response will include `body`, `body_text`, and `body_html`.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(IssuesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(IssuesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="IssuesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public IssuesRequestBuilder WithUrl(string rawUrl)
        {
            return new IssuesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// List issues in a repository. Only open issues will be listed.&gt; [!NOTE]&gt; GitHub&apos;s REST API considers every pull request an issue, but not every issue is a pull request. For this reason, &quot;Issues&quot; endpoints may return both issues and pull requests in the response. You can identify pull requests by the `pull_request` key. Be aware that the `id` of a pull request returned from &quot;Issues&quot; endpoints will be an _issue id_. To find out the pull request id, use the &quot;[List pull requests](https://docs.github.com/enterprise-server@3.10/rest/pulls/pulls#list-pull-requests)&quot; endpoint.This endpoint supports the following custom media types. For more information, see &quot;[Media types](https://docs.github.com/enterprise-server@3.10/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types).&quot;- **`application/vnd.github.raw+json`**: Returns the raw markdown body. Response will include `body`. This is the default if you do not pass any specific media type.- **`application/vnd.github.text+json`**: Returns a text only representation of the markdown body. Response will include `body_text`.- **`application/vnd.github.html+json`**: Returns HTML rendered from the body&apos;s markdown. Response will include `body_html`.- **`application/vnd.github.full+json`**: Returns raw, text, and HTML representations. Response will include `body`, `body_text`, and `body_html`.
        /// </summary>
        public class IssuesRequestBuilderGetQueryParameters 
        {
            /// <summary>Can be the name of a user. Pass in `none` for issues with no assigned user, and `*` for issues assigned to any user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("assignee")]
            public string? Assignee { get; set; }
#nullable restore
#else
            [QueryParameter("assignee")]
            public string Assignee { get; set; }
#endif
            /// <summary>The user that created the issue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("creator")]
            public string? Creator { get; set; }
#nullable restore
#else
            [QueryParameter("creator")]
            public string Creator { get; set; }
#endif
            /// <summary>The direction to sort the results by.</summary>
            [QueryParameter("direction")]
            public GetDirectionQueryParameterType? Direction { get; set; }
            /// <summary>A list of comma separated label names. Example: `bug,ui,@high`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("labels")]
            public string? Labels { get; set; }
#nullable restore
#else
            [QueryParameter("labels")]
            public string Labels { get; set; }
#endif
            /// <summary>A user that&apos;s mentioned in the issue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("mentioned")]
            public string? Mentioned { get; set; }
#nullable restore
#else
            [QueryParameter("mentioned")]
            public string Mentioned { get; set; }
#endif
            /// <summary>If an `integer` is passed, it should refer to a milestone by its `number` field. If the string `*` is passed, issues with any milestone are accepted. If the string `none` is passed, issues without milestones are returned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("milestone")]
            public string? Milestone { get; set; }
#nullable restore
#else
            [QueryParameter("milestone")]
            public string Milestone { get; set; }
#endif
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.10/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.10/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>Only show results that were last updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.</summary>
            [QueryParameter("since")]
            public DateTimeOffset? Since { get; set; }
            /// <summary>What to sort results by.</summary>
            [QueryParameter("sort")]
            public GetSortQueryParameterType? Sort { get; set; }
            /// <summary>Indicates the state of the issues to return.</summary>
            [QueryParameter("state")]
            public GetStateQueryParameterType? State { get; set; }
        }
    }
}
