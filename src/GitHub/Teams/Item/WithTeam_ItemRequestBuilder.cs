// <auto-generated/>
using GitHub.Models;
using GitHub.Teams.Item.Discussions;
using GitHub.Teams.Item.Members;
using GitHub.Teams.Item.Memberships;
using GitHub.Teams.Item.Projects;
using GitHub.Teams.Item.Repos;
using GitHub.Teams.Item.Teams;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Teams.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \teams\{team_id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class WithTeam_ItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The discussions property</summary>
        [Obsolete("")]
        public global::GitHub.Teams.Item.Discussions.DiscussionsRequestBuilder Discussions
        {
            get => new global::GitHub.Teams.Item.Discussions.DiscussionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The members property</summary>
        [Obsolete("")]
        public global::GitHub.Teams.Item.Members.MembersRequestBuilder Members
        {
            get => new global::GitHub.Teams.Item.Members.MembersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The memberships property</summary>
        [Obsolete("")]
        public global::GitHub.Teams.Item.Memberships.MembershipsRequestBuilder Memberships
        {
            get => new global::GitHub.Teams.Item.Memberships.MembershipsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The projects property</summary>
        [Obsolete("")]
        public global::GitHub.Teams.Item.Projects.ProjectsRequestBuilder Projects
        {
            get => new global::GitHub.Teams.Item.Projects.ProjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The repos property</summary>
        [Obsolete("")]
        public global::GitHub.Teams.Item.Repos.ReposRequestBuilder Repos
        {
            get => new global::GitHub.Teams.Item.Repos.ReposRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The teams property</summary>
        [Obsolete("")]
        public global::GitHub.Teams.Item.Teams.TeamsRequestBuilder Teams
        {
            get => new global::GitHub.Teams.Item.Teams.TeamsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Teams.Item.WithTeam_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTeam_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/teams/{team_id}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Teams.Item.WithTeam_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTeam_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/teams/{team_id}", rawUrl)
        {
        }
        /// <summary>
        /// &gt; [!WARNING]&gt; **Deprecation notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Delete a team](https://docs.github.com/enterprise-server@3.13/rest/teams/teams#delete-a-team) endpoint.To delete a team, the authenticated user must be an organization owner or team maintainer.If you are an organization owner, deleting a parent team will delete all of its child teams as well.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.13/rest/teams/teams#delete-a-team-legacy" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
        /// <exception cref="global::GitHub.Models.ValidationError">When receiving a 422 status code</exception>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "422", global::GitHub.Models.ValidationError.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// &gt; [!WARNING]&gt; **Deprecation notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the [Get a team by name](https://docs.github.com/enterprise-server@3.13/rest/teams/teams#get-a-team-by-name) endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.13/rest/teams/teams#get-a-team-legacy" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.TeamFull"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.TeamFull?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.TeamFull> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Models.TeamFull>(requestInfo, global::GitHub.Models.TeamFull.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// &gt; [!WARNING]&gt; **Deprecation notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Update a team](https://docs.github.com/enterprise-server@3.13/rest/teams/teams#update-a-team) endpoint.To edit a team, the authenticated user must either be an organization owner or a team maintainer.&gt; [!NOTE]&gt; With nested teams, the `privacy` for parent teams cannot be `secret`.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.13/rest/teams/teams#update-a-team-legacy" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.TeamFull"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 403 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
        /// <exception cref="global::GitHub.Models.ValidationError">When receiving a 422 status code</exception>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.TeamFull?> PatchAsync(global::GitHub.Teams.Item.WithTeam_PatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.TeamFull> PatchAsync(global::GitHub.Teams.Item.WithTeam_PatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "403", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "422", global::GitHub.Models.ValidationError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Models.TeamFull>(requestInfo, global::GitHub.Models.TeamFull.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// &gt; [!WARNING]&gt; **Deprecation notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Delete a team](https://docs.github.com/enterprise-server@3.13/rest/teams/teams#delete-a-team) endpoint.To delete a team, the authenticated user must be an organization owner or team maintainer.If you are an organization owner, deleting a parent team will delete all of its child teams as well.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// &gt; [!WARNING]&gt; **Deprecation notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the [Get a team by name](https://docs.github.com/enterprise-server@3.13/rest/teams/teams#get-a-team-by-name) endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// &gt; [!WARNING]&gt; **Deprecation notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Update a team](https://docs.github.com/enterprise-server@3.13/rest/teams/teams#update-a-team) endpoint.To edit a team, the authenticated user must either be an organization owner or a team maintainer.&gt; [!NOTE]&gt; With nested teams, the `privacy` for parent teams cannot be `secret`.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::GitHub.Teams.Item.WithTeam_PatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::GitHub.Teams.Item.WithTeam_PatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Teams.Item.WithTeam_ItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        [Obsolete("")]
        public global::GitHub.Teams.Item.WithTeam_ItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Teams.Item.WithTeam_ItemRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
