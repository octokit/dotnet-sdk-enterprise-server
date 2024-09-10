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
namespace GitHub.Teams.Item.Memberships.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \teams\{team_id}\memberships\{username}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class WithUsernameItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Teams.Item.Memberships.Item.WithUsernameItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithUsernameItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/teams/{team_id}/memberships/{username}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Teams.Item.Memberships.Item.WithUsernameItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithUsernameItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/teams/{team_id}/memberships/{username}", rawUrl)
        {
        }
        /// <summary>
        /// &gt; [!WARNING]&gt; **Deprecation notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Remove team membership for a user](https://docs.github.com/enterprise-server@3.11/rest/teams/members#remove-team-membership-for-a-user) endpoint.Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub&apos;s products](https://docs.github.com/enterprise-server@3.11/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.To remove a membership between a user and a team, the authenticated user must have &apos;admin&apos; permissions to the team or be an owner of the organization that the team is associated with. Removing team membership does not delete the user, it just removes their membership from the team.&gt; [!NOTE]&gt; When you have team synchronization set up for a team with your organization&apos;s identity provider (IdP), you will see an error if you attempt to use the API for making changes to the team&apos;s membership. If you have access to manage group membership in your IdP, you can manage GitHub Enterprise Server team membership through your identity provider, which automatically adds and removes team members in an organization. For more information, see &quot;[Synchronizing teams between your identity provider and GitHub Enterprise Server](https://docs.github.com/enterprise-server@3.11/articles/synchronizing-teams-between-your-identity-provider-and-github/).&quot;
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.11/rest/teams/members#remove-team-membership-for-a-user-legacy" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
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
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// &gt; [!WARNING]&gt; **Deprecation notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Get team membership for a user](https://docs.github.com/enterprise-server@3.11/rest/teams/members#get-team-membership-for-a-user) endpoint.Team members will include the members of child teams.To get a user&apos;s membership with a team, the team must be visible to the authenticated user.**Note:**The response contains the `state` of the membership and the member&apos;s `role`.The `role` for organization owners is set to `maintainer`. For more information about `maintainer` roles, see [Create a team](https://docs.github.com/enterprise-server@3.11/rest/teams/teams#create-a-team).
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.11/rest/teams/members#get-team-membership-for-a-user-legacy" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.TeamMembership"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.TeamMembership?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.TeamMembership> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Models.TeamMembership>(requestInfo, global::GitHub.Models.TeamMembership.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// &gt; [!WARNING]&gt; **Deprecation notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Add or update team membership for a user](https://docs.github.com/enterprise-server@3.11/rest/teams/members#add-or-update-team-membership-for-a-user) endpoint.Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub&apos;s products](https://docs.github.com/enterprise-server@3.11/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.If the user is already a member of the team&apos;s organization, this endpoint will add the user to the team. To add a membership between an organization member and a team, the authenticated user must be an organization owner or a team maintainer.&gt; [!NOTE]&gt; When you have team synchronization set up for a team with your organization&apos;s identity provider (IdP), you will see an error if you attempt to use the API for making changes to the team&apos;s membership. If you have access to manage group membership in your IdP, you can manage GitHub Enterprise Server team membership through your identity provider, which automatically adds and removes team members in an organization. For more information, see &quot;[Synchronizing teams between your identity provider and GitHub Enterprise Server](https://docs.github.com/enterprise-server@3.11/articles/synchronizing-teams-between-your-identity-provider-and-github/).&quot;If the user is unaffiliated with the team&apos;s organization, this endpoint will send an invitation to the user via email. This newly-created membership will be in the &quot;pending&quot; state until the user accepts the invitation, at which point the membership will transition to the &quot;active&quot; state and the user will be added as a member of the team. To add a membership between an unaffiliated user and a team, the authenticated user must be an organization owner.If the user is already a member of the team, this endpoint will update the role of the team member&apos;s role. To update the membership of a team member, the authenticated user must be an organization owner or a team maintainer.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.11/rest/teams/members#add-or-update-team-membership-for-a-user-legacy" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.TeamMembership"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.TeamMembership?> PutAsync(global::GitHub.Teams.Item.Memberships.Item.WithUsernamePutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.TeamMembership> PutAsync(global::GitHub.Teams.Item.Memberships.Item.WithUsernamePutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Models.TeamMembership>(requestInfo, global::GitHub.Models.TeamMembership.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// &gt; [!WARNING]&gt; **Deprecation notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Remove team membership for a user](https://docs.github.com/enterprise-server@3.11/rest/teams/members#remove-team-membership-for-a-user) endpoint.Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub&apos;s products](https://docs.github.com/enterprise-server@3.11/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.To remove a membership between a user and a team, the authenticated user must have &apos;admin&apos; permissions to the team or be an owner of the organization that the team is associated with. Removing team membership does not delete the user, it just removes their membership from the team.&gt; [!NOTE]&gt; When you have team synchronization set up for a team with your organization&apos;s identity provider (IdP), you will see an error if you attempt to use the API for making changes to the team&apos;s membership. If you have access to manage group membership in your IdP, you can manage GitHub Enterprise Server team membership through your identity provider, which automatically adds and removes team members in an organization. For more information, see &quot;[Synchronizing teams between your identity provider and GitHub Enterprise Server](https://docs.github.com/enterprise-server@3.11/articles/synchronizing-teams-between-your-identity-provider-and-github/).&quot;
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
            return requestInfo;
        }
        /// <summary>
        /// &gt; [!WARNING]&gt; **Deprecation notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Get team membership for a user](https://docs.github.com/enterprise-server@3.11/rest/teams/members#get-team-membership-for-a-user) endpoint.Team members will include the members of child teams.To get a user&apos;s membership with a team, the team must be visible to the authenticated user.**Note:**The response contains the `state` of the membership and the member&apos;s `role`.The `role` for organization owners is set to `maintainer`. For more information about `maintainer` roles, see [Create a team](https://docs.github.com/enterprise-server@3.11/rest/teams/teams#create-a-team).
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
        /// &gt; [!WARNING]&gt; **Deprecation notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Add or update team membership for a user](https://docs.github.com/enterprise-server@3.11/rest/teams/members#add-or-update-team-membership-for-a-user) endpoint.Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub&apos;s products](https://docs.github.com/enterprise-server@3.11/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.If the user is already a member of the team&apos;s organization, this endpoint will add the user to the team. To add a membership between an organization member and a team, the authenticated user must be an organization owner or a team maintainer.&gt; [!NOTE]&gt; When you have team synchronization set up for a team with your organization&apos;s identity provider (IdP), you will see an error if you attempt to use the API for making changes to the team&apos;s membership. If you have access to manage group membership in your IdP, you can manage GitHub Enterprise Server team membership through your identity provider, which automatically adds and removes team members in an organization. For more information, see &quot;[Synchronizing teams between your identity provider and GitHub Enterprise Server](https://docs.github.com/enterprise-server@3.11/articles/synchronizing-teams-between-your-identity-provider-and-github/).&quot;If the user is unaffiliated with the team&apos;s organization, this endpoint will send an invitation to the user via email. This newly-created membership will be in the &quot;pending&quot; state until the user accepts the invitation, at which point the membership will transition to the &quot;active&quot; state and the user will be added as a member of the team. To add a membership between an unaffiliated user and a team, the authenticated user must be an organization owner.If the user is already a member of the team, this endpoint will update the role of the team member&apos;s role. To update the membership of a team member, the authenticated user must be an organization owner or a team maintainer.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(global::GitHub.Teams.Item.Memberships.Item.WithUsernamePutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(global::GitHub.Teams.Item.Memberships.Item.WithUsernamePutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Teams.Item.Memberships.Item.WithUsernameItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        [Obsolete("")]
        public global::GitHub.Teams.Item.Memberships.Item.WithUsernameItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Teams.Item.Memberships.Item.WithUsernameItemRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
