// <auto-generated/>
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
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Orgs.Item {
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}
    /// </summary>
    public class WithOrgItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The actions property</summary>
        public ActionsRequestBuilder Actions
        {
            get => new ActionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The announcement property</summary>
        public AnnouncementRequestBuilder Announcement
        {
            get => new AnnouncementRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The auditLog property</summary>
        public AuditLogRequestBuilder AuditLog
        {
            get => new AuditLogRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The codeScanning property</summary>
        public CodeScanningRequestBuilder CodeScanning
        {
            get => new CodeScanningRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The customRepositoryRoles property</summary>
        public CustomRepositoryRolesRequestBuilder CustomRepositoryRoles
        {
            get => new CustomRepositoryRolesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The dependabot property</summary>
        public DependabotRequestBuilder Dependabot
        {
            get => new DependabotRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The docker property</summary>
        public DockerRequestBuilder Docker
        {
            get => new DockerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The events property</summary>
        public EventsRequestBuilder Events
        {
            get => new EventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The externalGroup property</summary>
        public ExternalGroupRequestBuilder ExternalGroup
        {
            get => new ExternalGroupRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The externalGroups property</summary>
        public ExternalGroupsRequestBuilder ExternalGroups
        {
            get => new ExternalGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The hooks property</summary>
        public HooksRequestBuilder Hooks
        {
            get => new HooksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The installation property</summary>
        public InstallationRequestBuilder Installation
        {
            get => new InstallationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The installations property</summary>
        public InstallationsRequestBuilder Installations
        {
            get => new InstallationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The issues property</summary>
        public IssuesRequestBuilder Issues
        {
            get => new IssuesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The members property</summary>
        public MembersRequestBuilder Members
        {
            get => new MembersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The memberships property</summary>
        public MembershipsRequestBuilder Memberships
        {
            get => new MembershipsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The migrations property</summary>
        public MigrationsRequestBuilder Migrations
        {
            get => new MigrationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The outside_collaborators property</summary>
        public Outside_collaboratorsRequestBuilder Outside_collaborators
        {
            get => new Outside_collaboratorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The packages property</summary>
        public PackagesRequestBuilder Packages
        {
            get => new PackagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The personalAccessTokenRequests property</summary>
        public PersonalAccessTokenRequestsRequestBuilder PersonalAccessTokenRequests
        {
            get => new PersonalAccessTokenRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The personalAccessTokens property</summary>
        public PersonalAccessTokensRequestBuilder PersonalAccessTokens
        {
            get => new PersonalAccessTokensRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The preReceiveHooks property</summary>
        public PreReceiveHooksRequestBuilder PreReceiveHooks
        {
            get => new PreReceiveHooksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The projects property</summary>
        public ProjectsRequestBuilder Projects
        {
            get => new ProjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The public_members property</summary>
        public Public_membersRequestBuilder Public_members
        {
            get => new Public_membersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The repos property</summary>
        public ReposRequestBuilder Repos
        {
            get => new ReposRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The repositoryFineGrainedPermissions property</summary>
        public RepositoryFineGrainedPermissionsRequestBuilder RepositoryFineGrainedPermissions
        {
            get => new RepositoryFineGrainedPermissionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The rulesets property</summary>
        public RulesetsRequestBuilder Rulesets
        {
            get => new RulesetsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The secretScanning property</summary>
        public SecretScanningRequestBuilder SecretScanning
        {
            get => new SecretScanningRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The securityManagers property</summary>
        public SecurityManagersRequestBuilder SecurityManagers
        {
            get => new SecurityManagersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The settings property</summary>
        public SettingsRequestBuilder Settings
        {
            get => new SettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The teams property</summary>
        public TeamsRequestBuilder Teams
        {
            get => new TeamsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the GitHub.orgs.item.item collection</summary>
        /// <param name="position">The security feature to enable or disable.</param>
        /// <returns>A <see cref="WithSecurity_productItemRequestBuilder"/></returns>
        public WithSecurity_productItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("security_product", position);
                return new WithSecurity_productItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="WithOrgItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithOrgItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithOrgItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithOrgItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}", rawUrl)
        {
        }
        /// <summary>
        /// Deletes an organization and all its repositories.The organization login will be unavailable for 90 days after deletion.Please review the Terms of Service regarding account deletion before using this endpoint:https://docs.github.com/enterprise-server@3.11/site-policy/github-terms/github-terms-of-service
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.11/rest/orgs/orgs#delete-an-organization" />
        /// </summary>
        /// <returns>A <see cref="WithOrgDeleteResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="BasicError">When receiving a 403 status code</exception>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<WithOrgDeleteResponse?> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<WithOrgDeleteResponse> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"403", BasicError.CreateFromDiscriminatorValue},
                {"404", BasicError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<WithOrgDeleteResponse>(requestInfo, WithOrgDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets information about an organization.When the value of `two_factor_requirement_enabled` is `true`, the organization requires all members, billing managers, and outside collaborators to enable [two-factor authentication](https://docs.github.com/enterprise-server@3.11/articles/securing-your-account-with-two-factor-authentication-2fa/).To see the full details about an organization, the authenticated user must be an organization owner.OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to see the full details about an organization.To see information about an organization&apos;s GitHub Enterprise Server plan, GitHub Apps need the `Organization plan` permission.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.11/rest/orgs/orgs#get-an-organization" />
        /// </summary>
        /// <returns>A <see cref="OrganizationFull"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<OrganizationFull?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<OrganizationFull> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"404", BasicError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<OrganizationFull>(requestInfo, OrganizationFull.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// &gt; [!WARNING]&gt; **Parameter deprecation notice:** GitHub Enterprise Server will replace and discontinue `members_allowed_repository_creation_type` in favor of more granular permissions. The new input parameters are `members_can_create_public_repositories`, `members_can_create_private_repositories` for all organizations and `members_can_create_internal_repositories` for organizations associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+. For more information, see the [blog post](https://developer.github.com/changes/2019-12-03-internal-visibility-changes).Updates the organization&apos;s profile and member privileges.The authenticated user must be an organization owner to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `admin:org` or `repo` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.11/rest/orgs/orgs#update-an-organization" />
        /// </summary>
        /// <returns>A <see cref="OrganizationFull"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="BasicError">When receiving a 409 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<OrganizationFull?> PatchAsync(WithOrgPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<OrganizationFull> PatchAsync(WithOrgPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"409", BasicError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<OrganizationFull>(requestInfo, OrganizationFull.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Deletes an organization and all its repositories.The organization login will be unavailable for 90 days after deletion.Please review the Terms of Service regarding account deletion before using this endpoint:https://docs.github.com/enterprise-server@3.11/site-policy/github-terms/github-terms-of-service
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
        /// Gets information about an organization.When the value of `two_factor_requirement_enabled` is `true`, the organization requires all members, billing managers, and outside collaborators to enable [two-factor authentication](https://docs.github.com/enterprise-server@3.11/articles/securing-your-account-with-two-factor-authentication-2fa/).To see the full details about an organization, the authenticated user must be an organization owner.OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to see the full details about an organization.To see information about an organization&apos;s GitHub Enterprise Server plan, GitHub Apps need the `Organization plan` permission.
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
        public RequestInformation ToPatchRequestInformation(WithOrgPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(WithOrgPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="WithOrgItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public WithOrgItemRequestBuilder WithUrl(string rawUrl)
        {
            return new WithOrgItemRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
