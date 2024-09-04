// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    /// <summary>
    /// Organization Full
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class OrganizationFull : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>**Deprecated.** Please use [code security configurations](https://docs.github.com/enterprise-server@3.14/rest/code-security/configurations) instead.Whether GitHub Advanced Security is enabled for new repositories and repositories transferred to this organization.This field is only visible to organization owners or members of a team with the security manager role.</summary>
        [Obsolete("")]
        public bool? AdvancedSecurityEnabledForNewRepositories { get; set; }
        /// <summary>The archived_at property</summary>
        public DateTimeOffset? ArchivedAt { get; set; }
        /// <summary>The avatar_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AvatarUrl { get; set; }
#nullable restore
#else
        public string AvatarUrl { get; set; }
#endif
        /// <summary>The billing_email property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BillingEmail { get; set; }
#nullable restore
#else
        public string BillingEmail { get; set; }
#endif
        /// <summary>The blog property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Blog { get; set; }
#nullable restore
#else
        public string Blog { get; set; }
#endif
        /// <summary>The collaborators property</summary>
        public int? Collaborators { get; set; }
        /// <summary>The company property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Company { get; set; }
#nullable restore
#else
        public string Company { get; set; }
#endif
        /// <summary>The created_at property</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The default_repository_permission property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultRepositoryPermission { get; set; }
#nullable restore
#else
        public string DefaultRepositoryPermission { get; set; }
#endif
        /// <summary>**Deprecated.** Please use [code security configurations](https://docs.github.com/enterprise-server@3.14/rest/code-security/configurations) instead.Whether Dependabot alerts are automatically enabled for new repositories and repositories transferred to this organization.This field is only visible to organization owners or members of a team with the security manager role.</summary>
        [Obsolete("")]
        public bool? DependabotAlertsEnabledForNewRepositories { get; set; }
        /// <summary>**Deprecated.** Please use [code security configurations](https://docs.github.com/enterprise-server@3.14/rest/code-security/configurations) instead.Whether Dependabot security updates are automatically enabled for new repositories and repositories transferred to this organization.This field is only visible to organization owners or members of a team with the security manager role.</summary>
        [Obsolete("")]
        public bool? DependabotSecurityUpdatesEnabledForNewRepositories { get; set; }
        /// <summary>**Deprecated.** Please use [code security configurations](https://docs.github.com/enterprise-server@3.14/rest/code-security/configurations) instead.Whether dependency graph is automatically enabled for new repositories and repositories transferred to this organization.This field is only visible to organization owners or members of a team with the security manager role.</summary>
        [Obsolete("")]
        public bool? DependencyGraphEnabledForNewRepositories { get; set; }
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The disk_usage property</summary>
        public int? DiskUsage { get; set; }
        /// <summary>The email property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>The events_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EventsUrl { get; set; }
#nullable restore
#else
        public string EventsUrl { get; set; }
#endif
        /// <summary>The followers property</summary>
        public int? Followers { get; set; }
        /// <summary>The following property</summary>
        public int? Following { get; set; }
        /// <summary>The has_organization_projects property</summary>
        public bool? HasOrganizationProjects { get; set; }
        /// <summary>The has_repository_projects property</summary>
        public bool? HasRepositoryProjects { get; set; }
        /// <summary>The hooks_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HooksUrl { get; set; }
#nullable restore
#else
        public string HooksUrl { get; set; }
#endif
        /// <summary>The html_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HtmlUrl { get; set; }
#nullable restore
#else
        public string HtmlUrl { get; set; }
#endif
        /// <summary>The id property</summary>
        public int? Id { get; set; }
        /// <summary>The issues_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IssuesUrl { get; set; }
#nullable restore
#else
        public string IssuesUrl { get; set; }
#endif
        /// <summary>The is_verified property</summary>
        public bool? IsVerified { get; set; }
        /// <summary>The location property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Location { get; set; }
#nullable restore
#else
        public string Location { get; set; }
#endif
        /// <summary>The login property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Login { get; set; }
#nullable restore
#else
        public string Login { get; set; }
#endif
        /// <summary>The members_allowed_repository_creation_type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MembersAllowedRepositoryCreationType { get; set; }
#nullable restore
#else
        public string MembersAllowedRepositoryCreationType { get; set; }
#endif
        /// <summary>The members_can_create_internal_repositories property</summary>
        public bool? MembersCanCreateInternalRepositories { get; set; }
        /// <summary>The members_can_create_pages property</summary>
        public bool? MembersCanCreatePages { get; set; }
        /// <summary>The members_can_create_private_pages property</summary>
        public bool? MembersCanCreatePrivatePages { get; set; }
        /// <summary>The members_can_create_private_repositories property</summary>
        public bool? MembersCanCreatePrivateRepositories { get; set; }
        /// <summary>The members_can_create_public_pages property</summary>
        public bool? MembersCanCreatePublicPages { get; set; }
        /// <summary>The members_can_create_public_repositories property</summary>
        public bool? MembersCanCreatePublicRepositories { get; set; }
        /// <summary>The members_can_create_repositories property</summary>
        public bool? MembersCanCreateRepositories { get; set; }
        /// <summary>The members_can_fork_private_repositories property</summary>
        public bool? MembersCanForkPrivateRepositories { get; set; }
        /// <summary>The members_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MembersUrl { get; set; }
#nullable restore
#else
        public string MembersUrl { get; set; }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The node_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NodeId { get; set; }
#nullable restore
#else
        public string NodeId { get; set; }
#endif
        /// <summary>The owned_private_repos property</summary>
        public int? OwnedPrivateRepos { get; set; }
        /// <summary>The plan property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.OrganizationFull_plan? Plan { get; set; }
#nullable restore
#else
        public global::GitHub.Models.OrganizationFull_plan Plan { get; set; }
#endif
        /// <summary>The private_gists property</summary>
        public int? PrivateGists { get; set; }
        /// <summary>The public_gists property</summary>
        public int? PublicGists { get; set; }
        /// <summary>The public_members_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PublicMembersUrl { get; set; }
#nullable restore
#else
        public string PublicMembersUrl { get; set; }
#endif
        /// <summary>The public_repos property</summary>
        public int? PublicRepos { get; set; }
        /// <summary>The repos_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReposUrl { get; set; }
#nullable restore
#else
        public string ReposUrl { get; set; }
#endif
        /// <summary>**Deprecated.** Please use [code security configurations](https://docs.github.com/enterprise-server@3.14/rest/code-security/configurations) instead.Whether secret scanning is automatically enabled for new repositories and repositories transferred to this organization.This field is only visible to organization owners or members of a team with the security manager role.</summary>
        [Obsolete("")]
        public bool? SecretScanningEnabledForNewRepositories { get; set; }
        /// <summary>An optional URL string to display to contributors who are blocked from pushing a secret.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SecretScanningPushProtectionCustomLink { get; set; }
#nullable restore
#else
        public string SecretScanningPushProtectionCustomLink { get; set; }
#endif
        /// <summary>Whether a custom link is shown to contributors who are blocked from pushing a secret by push protection.</summary>
        public bool? SecretScanningPushProtectionCustomLinkEnabled { get; set; }
        /// <summary>**Deprecated.** Please use [code security configurations](https://docs.github.com/enterprise-server@3.14/rest/code-security/configurations) instead.Whether secret scanning push protection is automatically enabled for new repositories and repositories transferred to this organization.This field is only visible to organization owners or members of a team with the security manager role.</summary>
        [Obsolete("")]
        public bool? SecretScanningPushProtectionEnabledForNewRepositories { get; set; }
        /// <summary>The total_private_repos property</summary>
        public int? TotalPrivateRepos { get; set; }
        /// <summary>The twitter_username property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TwitterUsername { get; set; }
#nullable restore
#else
        public string TwitterUsername { get; set; }
#endif
        /// <summary>The two_factor_requirement_enabled property</summary>
        public bool? TwoFactorRequirementEnabled { get; set; }
        /// <summary>The type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>The updated_at property</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>The url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>The web_commit_signoff_required property</summary>
        public bool? WebCommitSignoffRequired { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.OrganizationFull"/> and sets the default values.
        /// </summary>
        public OrganizationFull()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.OrganizationFull"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.OrganizationFull CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.OrganizationFull();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "advanced_security_enabled_for_new_repositories", n => { AdvancedSecurityEnabledForNewRepositories = n.GetBoolValue(); } },
                { "archived_at", n => { ArchivedAt = n.GetDateTimeOffsetValue(); } },
                { "avatar_url", n => { AvatarUrl = n.GetStringValue(); } },
                { "billing_email", n => { BillingEmail = n.GetStringValue(); } },
                { "blog", n => { Blog = n.GetStringValue(); } },
                { "collaborators", n => { Collaborators = n.GetIntValue(); } },
                { "company", n => { Company = n.GetStringValue(); } },
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "default_repository_permission", n => { DefaultRepositoryPermission = n.GetStringValue(); } },
                { "dependabot_alerts_enabled_for_new_repositories", n => { DependabotAlertsEnabledForNewRepositories = n.GetBoolValue(); } },
                { "dependabot_security_updates_enabled_for_new_repositories", n => { DependabotSecurityUpdatesEnabledForNewRepositories = n.GetBoolValue(); } },
                { "dependency_graph_enabled_for_new_repositories", n => { DependencyGraphEnabledForNewRepositories = n.GetBoolValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "disk_usage", n => { DiskUsage = n.GetIntValue(); } },
                { "email", n => { Email = n.GetStringValue(); } },
                { "events_url", n => { EventsUrl = n.GetStringValue(); } },
                { "followers", n => { Followers = n.GetIntValue(); } },
                { "following", n => { Following = n.GetIntValue(); } },
                { "has_organization_projects", n => { HasOrganizationProjects = n.GetBoolValue(); } },
                { "has_repository_projects", n => { HasRepositoryProjects = n.GetBoolValue(); } },
                { "hooks_url", n => { HooksUrl = n.GetStringValue(); } },
                { "html_url", n => { HtmlUrl = n.GetStringValue(); } },
                { "id", n => { Id = n.GetIntValue(); } },
                { "is_verified", n => { IsVerified = n.GetBoolValue(); } },
                { "issues_url", n => { IssuesUrl = n.GetStringValue(); } },
                { "location", n => { Location = n.GetStringValue(); } },
                { "login", n => { Login = n.GetStringValue(); } },
                { "members_allowed_repository_creation_type", n => { MembersAllowedRepositoryCreationType = n.GetStringValue(); } },
                { "members_can_create_internal_repositories", n => { MembersCanCreateInternalRepositories = n.GetBoolValue(); } },
                { "members_can_create_pages", n => { MembersCanCreatePages = n.GetBoolValue(); } },
                { "members_can_create_private_pages", n => { MembersCanCreatePrivatePages = n.GetBoolValue(); } },
                { "members_can_create_private_repositories", n => { MembersCanCreatePrivateRepositories = n.GetBoolValue(); } },
                { "members_can_create_public_pages", n => { MembersCanCreatePublicPages = n.GetBoolValue(); } },
                { "members_can_create_public_repositories", n => { MembersCanCreatePublicRepositories = n.GetBoolValue(); } },
                { "members_can_create_repositories", n => { MembersCanCreateRepositories = n.GetBoolValue(); } },
                { "members_can_fork_private_repositories", n => { MembersCanForkPrivateRepositories = n.GetBoolValue(); } },
                { "members_url", n => { MembersUrl = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "node_id", n => { NodeId = n.GetStringValue(); } },
                { "owned_private_repos", n => { OwnedPrivateRepos = n.GetIntValue(); } },
                { "plan", n => { Plan = n.GetObjectValue<global::GitHub.Models.OrganizationFull_plan>(global::GitHub.Models.OrganizationFull_plan.CreateFromDiscriminatorValue); } },
                { "private_gists", n => { PrivateGists = n.GetIntValue(); } },
                { "public_gists", n => { PublicGists = n.GetIntValue(); } },
                { "public_members_url", n => { PublicMembersUrl = n.GetStringValue(); } },
                { "public_repos", n => { PublicRepos = n.GetIntValue(); } },
                { "repos_url", n => { ReposUrl = n.GetStringValue(); } },
                { "secret_scanning_enabled_for_new_repositories", n => { SecretScanningEnabledForNewRepositories = n.GetBoolValue(); } },
                { "secret_scanning_push_protection_custom_link", n => { SecretScanningPushProtectionCustomLink = n.GetStringValue(); } },
                { "secret_scanning_push_protection_custom_link_enabled", n => { SecretScanningPushProtectionCustomLinkEnabled = n.GetBoolValue(); } },
                { "secret_scanning_push_protection_enabled_for_new_repositories", n => { SecretScanningPushProtectionEnabledForNewRepositories = n.GetBoolValue(); } },
                { "total_private_repos", n => { TotalPrivateRepos = n.GetIntValue(); } },
                { "twitter_username", n => { TwitterUsername = n.GetStringValue(); } },
                { "two_factor_requirement_enabled", n => { TwoFactorRequirementEnabled = n.GetBoolValue(); } },
                { "type", n => { Type = n.GetStringValue(); } },
                { "updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                { "url", n => { Url = n.GetStringValue(); } },
                { "web_commit_signoff_required", n => { WebCommitSignoffRequired = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("advanced_security_enabled_for_new_repositories", AdvancedSecurityEnabledForNewRepositories);
            writer.WriteDateTimeOffsetValue("archived_at", ArchivedAt);
            writer.WriteStringValue("avatar_url", AvatarUrl);
            writer.WriteStringValue("billing_email", BillingEmail);
            writer.WriteStringValue("blog", Blog);
            writer.WriteIntValue("collaborators", Collaborators);
            writer.WriteStringValue("company", Company);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteStringValue("default_repository_permission", DefaultRepositoryPermission);
            writer.WriteBoolValue("dependabot_alerts_enabled_for_new_repositories", DependabotAlertsEnabledForNewRepositories);
            writer.WriteBoolValue("dependabot_security_updates_enabled_for_new_repositories", DependabotSecurityUpdatesEnabledForNewRepositories);
            writer.WriteBoolValue("dependency_graph_enabled_for_new_repositories", DependencyGraphEnabledForNewRepositories);
            writer.WriteStringValue("description", Description);
            writer.WriteIntValue("disk_usage", DiskUsage);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("events_url", EventsUrl);
            writer.WriteIntValue("followers", Followers);
            writer.WriteIntValue("following", Following);
            writer.WriteBoolValue("has_organization_projects", HasOrganizationProjects);
            writer.WriteBoolValue("has_repository_projects", HasRepositoryProjects);
            writer.WriteStringValue("hooks_url", HooksUrl);
            writer.WriteStringValue("html_url", HtmlUrl);
            writer.WriteIntValue("id", Id);
            writer.WriteStringValue("issues_url", IssuesUrl);
            writer.WriteBoolValue("is_verified", IsVerified);
            writer.WriteStringValue("location", Location);
            writer.WriteStringValue("login", Login);
            writer.WriteStringValue("members_allowed_repository_creation_type", MembersAllowedRepositoryCreationType);
            writer.WriteBoolValue("members_can_create_internal_repositories", MembersCanCreateInternalRepositories);
            writer.WriteBoolValue("members_can_create_pages", MembersCanCreatePages);
            writer.WriteBoolValue("members_can_create_private_pages", MembersCanCreatePrivatePages);
            writer.WriteBoolValue("members_can_create_private_repositories", MembersCanCreatePrivateRepositories);
            writer.WriteBoolValue("members_can_create_public_pages", MembersCanCreatePublicPages);
            writer.WriteBoolValue("members_can_create_public_repositories", MembersCanCreatePublicRepositories);
            writer.WriteBoolValue("members_can_create_repositories", MembersCanCreateRepositories);
            writer.WriteBoolValue("members_can_fork_private_repositories", MembersCanForkPrivateRepositories);
            writer.WriteStringValue("members_url", MembersUrl);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("node_id", NodeId);
            writer.WriteIntValue("owned_private_repos", OwnedPrivateRepos);
            writer.WriteObjectValue<global::GitHub.Models.OrganizationFull_plan>("plan", Plan);
            writer.WriteIntValue("private_gists", PrivateGists);
            writer.WriteIntValue("public_gists", PublicGists);
            writer.WriteStringValue("public_members_url", PublicMembersUrl);
            writer.WriteIntValue("public_repos", PublicRepos);
            writer.WriteStringValue("repos_url", ReposUrl);
            writer.WriteBoolValue("secret_scanning_enabled_for_new_repositories", SecretScanningEnabledForNewRepositories);
            writer.WriteStringValue("secret_scanning_push_protection_custom_link", SecretScanningPushProtectionCustomLink);
            writer.WriteBoolValue("secret_scanning_push_protection_custom_link_enabled", SecretScanningPushProtectionCustomLinkEnabled);
            writer.WriteBoolValue("secret_scanning_push_protection_enabled_for_new_repositories", SecretScanningPushProtectionEnabledForNewRepositories);
            writer.WriteIntValue("total_private_repos", TotalPrivateRepos);
            writer.WriteStringValue("twitter_username", TwitterUsername);
            writer.WriteBoolValue("two_factor_requirement_enabled", TwoFactorRequirementEnabled);
            writer.WriteStringValue("type", Type);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteStringValue("url", Url);
            writer.WriteBoolValue("web_commit_signoff_required", WebCommitSignoffRequired);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
