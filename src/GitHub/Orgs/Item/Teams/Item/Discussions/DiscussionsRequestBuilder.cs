// <auto-generated/>
using GitHub.Models;
using GitHub.Orgs.Item.Teams.Item.Discussions.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Orgs.Item.Teams.Item.Discussions
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\teams\{team_slug}\discussions
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class DiscussionsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the GitHub.orgs.item.teams.item.discussions.item collection</summary>
        /// <param name="position">The number that identifies the discussion.</param>
        /// <returns>A <see cref="global::GitHub.Orgs.Item.Teams.Item.Discussions.Item.WithDiscussion_numberItemRequestBuilder"/></returns>
        public global::GitHub.Orgs.Item.Teams.Item.Discussions.Item.WithDiscussion_numberItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("discussion_number", position);
                return new global::GitHub.Orgs.Item.Teams.Item.Discussions.Item.WithDiscussion_numberItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.Teams.Item.Discussions.DiscussionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DiscussionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/teams/{team_slug}/discussions{?direction*,page*,per_page*,pinned*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.Teams.Item.Discussions.DiscussionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DiscussionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/teams/{team_slug}/discussions{?direction*,page*,per_page*,pinned*}", rawUrl)
        {
        }
        /// <summary>
        /// List all discussions on a team&apos;s page.&gt; [!NOTE]&gt; You can also specify a team by `org_id` and `team_id` using the route `GET /organizations/{org_id}/team/{team_id}/discussions`.OAuth app tokens and personal access tokens (classic) need the `read:discussion` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.12/rest/teams/discussions#list-discussions" />
        /// </summary>
        /// <returns>A List&lt;global::GitHub.Models.TeamDiscussion&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::GitHub.Models.TeamDiscussion>?> GetAsync(Action<RequestConfiguration<global::GitHub.Orgs.Item.Teams.Item.Discussions.DiscussionsRequestBuilder.DiscussionsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::GitHub.Models.TeamDiscussion>> GetAsync(Action<RequestConfiguration<global::GitHub.Orgs.Item.Teams.Item.Discussions.DiscussionsRequestBuilder.DiscussionsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::GitHub.Models.TeamDiscussion>(requestInfo, global::GitHub.Models.TeamDiscussion.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Creates a new discussion post on a team&apos;s page.This endpoint triggers [notifications](https://docs.github.com/enterprise-server@3.12/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. For more information, see &quot;[Rate limits for the API](https://docs.github.com/enterprise-server@3.12/rest/using-the-rest-api/rate-limits-for-the-rest-api#about-secondary-rate-limits)&quot; and &quot;[Best practices for using the REST API](https://docs.github.com/enterprise-server@3.12/rest/guides/best-practices-for-using-the-rest-api).&quot;&gt; [!NOTE]&gt; You can also specify a team by `org_id` and `team_id` using the route `POST /organizations/{org_id}/team/{team_id}/discussions`.OAuth app tokens and personal access tokens (classic) need the `write:discussion` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.12/rest/teams/discussions#create-a-discussion" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.TeamDiscussion"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.TeamDiscussion?> PostAsync(global::GitHub.Orgs.Item.Teams.Item.Discussions.DiscussionsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.TeamDiscussion> PostAsync(global::GitHub.Orgs.Item.Teams.Item.Discussions.DiscussionsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::GitHub.Models.TeamDiscussion>(requestInfo, global::GitHub.Models.TeamDiscussion.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List all discussions on a team&apos;s page.&gt; [!NOTE]&gt; You can also specify a team by `org_id` and `team_id` using the route `GET /organizations/{org_id}/team/{team_id}/discussions`.OAuth app tokens and personal access tokens (classic) need the `read:discussion` scope to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Orgs.Item.Teams.Item.Discussions.DiscussionsRequestBuilder.DiscussionsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Orgs.Item.Teams.Item.Discussions.DiscussionsRequestBuilder.DiscussionsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Creates a new discussion post on a team&apos;s page.This endpoint triggers [notifications](https://docs.github.com/enterprise-server@3.12/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. For more information, see &quot;[Rate limits for the API](https://docs.github.com/enterprise-server@3.12/rest/using-the-rest-api/rate-limits-for-the-rest-api#about-secondary-rate-limits)&quot; and &quot;[Best practices for using the REST API](https://docs.github.com/enterprise-server@3.12/rest/guides/best-practices-for-using-the-rest-api).&quot;&gt; [!NOTE]&gt; You can also specify a team by `org_id` and `team_id` using the route `POST /organizations/{org_id}/team/{team_id}/discussions`.OAuth app tokens and personal access tokens (classic) need the `write:discussion` scope to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::GitHub.Orgs.Item.Teams.Item.Discussions.DiscussionsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::GitHub.Orgs.Item.Teams.Item.Discussions.DiscussionsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Orgs.Item.Teams.Item.Discussions.DiscussionsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Orgs.Item.Teams.Item.Discussions.DiscussionsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Orgs.Item.Teams.Item.Discussions.DiscussionsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// List all discussions on a team&apos;s page.&gt; [!NOTE]&gt; You can also specify a team by `org_id` and `team_id` using the route `GET /organizations/{org_id}/team/{team_id}/discussions`.OAuth app tokens and personal access tokens (classic) need the `read:discussion` scope to use this endpoint.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class DiscussionsRequestBuilderGetQueryParameters 
        {
            /// <summary>The direction to sort the results by.</summary>
            [QueryParameter("direction")]
            public global::GitHub.Orgs.Item.Teams.Item.Discussions.GetDirectionQueryParameterType? Direction { get; set; }
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.12/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.12/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>Pinned discussions only filter</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("pinned")]
            public string? Pinned { get; set; }
#nullable restore
#else
            [QueryParameter("pinned")]
            public string Pinned { get; set; }
#endif
        }
    }
}
