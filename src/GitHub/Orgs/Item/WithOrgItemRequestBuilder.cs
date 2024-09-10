// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Models;
using GitHub.Orgs.Item.Actions;
using GitHub.Orgs.Item.Announcement;
using GitHub.Orgs.Item.AuditLog;
using GitHub.Orgs.Item.CodeScanning;
using GitHub.Orgs.Item.CustomRepositoryRoles;
using GitHub.Orgs.Item.Dependabot;
using GitHub.Orgs.Item.Docker;
using GitHub.Orgs.Item.Events;
using GitHub.Orgs.Item.ExternalGroup;
using GitHub.Orgs.Item.ExternalGroups;
using GitHub.Orgs.Item.Hooks;
using GitHub.Orgs.Item.Installation;
using GitHub.Orgs.Item.Installations;
using GitHub.Orgs.Item.Issues;
using GitHub.Orgs.Item.Item;
using GitHub.Orgs.Item.Members;
using GitHub.Orgs.Item.Memberships;
using GitHub.Orgs.Item.Migrations;
using GitHub.Orgs.Item.Outside_collaborators;
using GitHub.Orgs.Item.Packages;
using GitHub.Orgs.Item.PersonalAccessTokenRequests;
using GitHub.Orgs.Item.PersonalAccessTokens;
using GitHub.Orgs.Item.PreReceiveHooks;
using GitHub.Orgs.Item.Projects;
using GitHub.Orgs.Item.Public_members;
using GitHub.Orgs.Item.Repos;
using GitHub.Orgs.Item.RepositoryFineGrainedPermissions;
using GitHub.Orgs.Item.Rulesets;
using GitHub.Orgs.Item.SecretScanning;
using GitHub.Orgs.Item.SecurityManagers;
using GitHub.Orgs.Item.Settings;
using GitHub.Orgs.Item.Teams;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Orgs.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class WithOrgItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The actions property</summary>
        public global::GitHub.Orgs.Item.Actions.ActionsRequestBuilder Actions
        {
            get => new global::GitHub.Orgs.Item.Actions.ActionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The announcement property</summary>
        public global::GitHub.Orgs.Item.Announcement.AnnouncementRequestBuilder Announcement
        {
            get => new global::GitHub.Orgs.Item.Announcement.AnnouncementRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The auditLog property</summary>
        public global::GitHub.Orgs.Item.AuditLog.AuditLogRequestBuilder AuditLog
        {
            get => new global::GitHub.Orgs.Item.AuditLog.AuditLogRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The codeScanning property</summary>
        public global::GitHub.Orgs.Item.CodeScanning.CodeScanningRequestBuilder CodeScanning
        {
            get => new global::GitHub.Orgs.Item.CodeScanning.CodeScanningRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The customRepositoryRoles property</summary>
        public global::GitHub.Orgs.Item.CustomRepositoryRoles.CustomRepositoryRolesRequestBuilder CustomRepositoryRoles
        {
            get => new global::GitHub.Orgs.Item.CustomRepositoryRoles.CustomRepositoryRolesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The dependabot property</summary>
        public global::GitHub.Orgs.Item.Dependabot.DependabotRequestBuilder Dependabot
        {
            get => new global::GitHub.Orgs.Item.Dependabot.DependabotRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The docker property</summary>
        public global::GitHub.Orgs.Item.Docker.DockerRequestBuilder Docker
        {
            get => new global::GitHub.Orgs.Item.Docker.DockerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The events property</summary>
        public global::GitHub.Orgs.Item.Events.EventsRequestBuilder Events
        {
            get => new global::GitHub.Orgs.Item.Events.EventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The externalGroup property</summary>
        public global::GitHub.Orgs.Item.ExternalGroup.ExternalGroupRequestBuilder ExternalGroup
        {
            get => new global::GitHub.Orgs.Item.ExternalGroup.ExternalGroupRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The externalGroups property</summary>
        public global::GitHub.Orgs.Item.ExternalGroups.ExternalGroupsRequestBuilder ExternalGroups
        {
            get => new global::GitHub.Orgs.Item.ExternalGroups.ExternalGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The hooks property</summary>
        public global::GitHub.Orgs.Item.Hooks.HooksRequestBuilder Hooks
        {
            get => new global::GitHub.Orgs.Item.Hooks.HooksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The installation property</summary>
        public global::GitHub.Orgs.Item.Installation.InstallationRequestBuilder Installation
        {
            get => new global::GitHub.Orgs.Item.Installation.InstallationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The installations property</summary>
        public global::GitHub.Orgs.Item.Installations.InstallationsRequestBuilder Installations
        {
            get => new global::GitHub.Orgs.Item.Installations.InstallationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The issues property</summary>
        public global::GitHub.Orgs.Item.Issues.IssuesRequestBuilder Issues
        {
            get => new global::GitHub.Orgs.Item.Issues.IssuesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The members property</summary>
        public global::GitHub.Orgs.Item.Members.MembersRequestBuilder Members
        {
            get => new global::GitHub.Orgs.Item.Members.MembersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The memberships property</summary>
        public global::GitHub.Orgs.Item.Memberships.MembershipsRequestBuilder Memberships
        {
            get => new global::GitHub.Orgs.Item.Memberships.MembershipsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The migrations property</summary>
        public global::GitHub.Orgs.Item.Migrations.MigrationsRequestBuilder Migrations
        {
            get => new global::GitHub.Orgs.Item.Migrations.MigrationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The outside_collaborators property</summary>
        public global::GitHub.Orgs.Item.Outside_collaborators.Outside_collaboratorsRequestBuilder Outside_collaborators
        {
            get => new global::GitHub.Orgs.Item.Outside_collaborators.Outside_collaboratorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The packages property</summary>
        public global::GitHub.Orgs.Item.Packages.PackagesRequestBuilder Packages
        {
            get => new global::GitHub.Orgs.Item.Packages.PackagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The personalAccessTokenRequests property</summary>
        public global::GitHub.Orgs.Item.PersonalAccessTokenRequests.PersonalAccessTokenRequestsRequestBuilder PersonalAccessTokenRequests
        {
            get => new global::GitHub.Orgs.Item.PersonalAccessTokenRequests.PersonalAccessTokenRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The personalAccessTokens property</summary>
        public global::GitHub.Orgs.Item.PersonalAccessTokens.PersonalAccessTokensRequestBuilder PersonalAccessTokens
        {
            get => new global::GitHub.Orgs.Item.PersonalAccessTokens.PersonalAccessTokensRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The preReceiveHooks property</summary>
        public global::GitHub.Orgs.Item.PreReceiveHooks.PreReceiveHooksRequestBuilder PreReceiveHooks
        {
            get => new global::GitHub.Orgs.Item.PreReceiveHooks.PreReceiveHooksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The projects property</summary>
        public global::GitHub.Orgs.Item.Projects.ProjectsRequestBuilder Projects
        {
            get => new global::GitHub.Orgs.Item.Projects.ProjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The public_members property</summary>
        public global::GitHub.Orgs.Item.Public_members.Public_membersRequestBuilder Public_members
        {
            get => new global::GitHub.Orgs.Item.Public_members.Public_membersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The repos property</summary>
        public global::GitHub.Orgs.Item.Repos.ReposRequestBuilder Repos
        {
            get => new global::GitHub.Orgs.Item.Repos.ReposRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The repositoryFineGrainedPermissions property</summary>
        public global::GitHub.Orgs.Item.RepositoryFineGrainedPermissions.RepositoryFineGrainedPermissionsRequestBuilder RepositoryFineGrainedPermissions
        {
            get => new global::GitHub.Orgs.Item.RepositoryFineGrainedPermissions.RepositoryFineGrainedPermissionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The rulesets property</summary>
        public global::GitHub.Orgs.Item.Rulesets.RulesetsRequestBuilder Rulesets
        {
            get => new global::GitHub.Orgs.Item.Rulesets.RulesetsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The secretScanning property</summary>
        public global::GitHub.Orgs.Item.SecretScanning.SecretScanningRequestBuilder SecretScanning
        {
            get => new global::GitHub.Orgs.Item.SecretScanning.SecretScanningRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The securityManagers property</summary>
        public global::GitHub.Orgs.Item.SecurityManagers.SecurityManagersRequestBuilder SecurityManagers
        {
            get => new global::GitHub.Orgs.Item.SecurityManagers.SecurityManagersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The settings property</summary>
        public global::GitHub.Orgs.Item.Settings.SettingsRequestBuilder Settings
        {
            get => new global::GitHub.Orgs.Item.Settings.SettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The teams property</summary>
        public global::GitHub.Orgs.Item.Teams.TeamsRequestBuilder Teams
        {
            get => new global::GitHub.Orgs.Item.Teams.TeamsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the GitHub.orgs.item.item collection</summary>
        /// <param name="position">The security feature to enable or disable.</param>
        /// <returns>A <see cref="global::GitHub.Orgs.Item.Item.WithSecurity_productItemRequestBuilder"/></returns>
        public global::GitHub.Orgs.Item.Item.WithSecurity_productItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("security_product", position);
                return new global::GitHub.Orgs.Item.Item.WithSecurity_productItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.WithOrgItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithOrgItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.WithOrgItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithOrgItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}", rawUrl)
        {
        }
        /// <summary>
        /// Deletes an organization and all its repositories.The organization login will be unavailable for 90 days after deletion.Please review the Terms of Service regarding account deletion before using this endpoint:https://docs.github.com/enterprise-server@3.12/site-policy/github-terms/github-terms-of-service
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.12/rest/orgs/orgs#delete-an-organization" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Orgs.Item.WithOrgDeleteResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 403 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Orgs.Item.WithOrgDeleteResponse?> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Orgs.Item.WithOrgDeleteResponse> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "403", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Orgs.Item.WithOrgDeleteResponse>(requestInfo, global::GitHub.Orgs.Item.WithOrgDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets information about an organization.When the value of `two_factor_requirement_enabled` is `true`, the organization requires all members, billing managers, and outside collaborators to enable [two-factor authentication](https://docs.github.com/enterprise-server@3.12/articles/securing-your-account-with-two-factor-authentication-2fa/).To see the full details about an organization, the authenticated user must be an organization owner.OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to see the full details about an organization.To see information about an organization&apos;s GitHub Enterprise Server plan, GitHub Apps need the `Organization plan` permission.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.12/rest/orgs/orgs#get-an-organization" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.OrganizationFull"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.OrganizationFull?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.OrganizationFull> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Models.OrganizationFull>(requestInfo, global::GitHub.Models.OrganizationFull.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// &gt; [!WARNING]&gt; **Parameter deprecation notice:** GitHub Enterprise Server will replace and discontinue `members_allowed_repository_creation_type` in favor of more granular permissions. The new input parameters are `members_can_create_public_repositories`, `members_can_create_private_repositories` for all organizations and `members_can_create_internal_repositories` for organizations associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+. For more information, see the [blog post](https://developer.github.com/changes/2019-12-03-internal-visibility-changes).Updates the organization&apos;s profile and member privileges.The authenticated user must be an organization owner to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `admin:org` or `repo` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.12/rest/orgs/orgs#update-an-organization" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.OrganizationFull"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 409 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.OrganizationFull?> PatchAsync(global::GitHub.Orgs.Item.WithOrgPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.OrganizationFull> PatchAsync(global::GitHub.Orgs.Item.WithOrgPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "409", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Models.OrganizationFull>(requestInfo, global::GitHub.Models.OrganizationFull.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Deletes an organization and all its repositories.The organization login will be unavailable for 90 days after deletion.Please review the Terms of Service regarding account deletion before using this endpoint:https://docs.github.com/enterprise-server@3.12/site-policy/github-terms/github-terms-of-service
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
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
        /// Gets information about an organization.When the value of `two_factor_requirement_enabled` is `true`, the organization requires all members, billing managers, and outside collaborators to enable [two-factor authentication](https://docs.github.com/enterprise-server@3.12/articles/securing-your-account-with-two-factor-authentication-2fa/).To see the full details about an organization, the authenticated user must be an organization owner.OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to see the full details about an organization.To see information about an organization&apos;s GitHub Enterprise Server plan, GitHub Apps need the `Organization plan` permission.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
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
        /// &gt; [!WARNING]&gt; **Parameter deprecation notice:** GitHub Enterprise Server will replace and discontinue `members_allowed_repository_creation_type` in favor of more granular permissions. The new input parameters are `members_can_create_public_repositories`, `members_can_create_private_repositories` for all organizations and `members_can_create_internal_repositories` for organizations associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+. For more information, see the [blog post](https://developer.github.com/changes/2019-12-03-internal-visibility-changes).Updates the organization&apos;s profile and member privileges.The authenticated user must be an organization owner to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `admin:org` or `repo` scope to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::GitHub.Orgs.Item.WithOrgPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::GitHub.Orgs.Item.WithOrgPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Orgs.Item.WithOrgItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Orgs.Item.WithOrgItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Orgs.Item.WithOrgItemRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
