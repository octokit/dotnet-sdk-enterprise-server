// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    /// <summary>
    /// Ldap Private User
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class LdapMappingUser : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The avatar_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AvatarUrl { get; set; }
#nullable restore
#else
        public string AvatarUrl { get; set; }
#endif
        /// <summary>The bio property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Bio { get; set; }
#nullable restore
#else
        public string Bio { get; set; }
#endif
        /// <summary>The blog property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Blog { get; set; }
#nullable restore
#else
        public string Blog { get; set; }
#endif
        /// <summary>The business_plus property</summary>
        public bool? BusinessPlus { get; set; }
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
        /// <summary>The followers_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FollowersUrl { get; set; }
#nullable restore
#else
        public string FollowersUrl { get; set; }
#endif
        /// <summary>The following property</summary>
        public int? Following { get; set; }
        /// <summary>The following_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FollowingUrl { get; set; }
#nullable restore
#else
        public string FollowingUrl { get; set; }
#endif
        /// <summary>The gists_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GistsUrl { get; set; }
#nullable restore
#else
        public string GistsUrl { get; set; }
#endif
        /// <summary>The gravatar_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GravatarId { get; set; }
#nullable restore
#else
        public string GravatarId { get; set; }
#endif
        /// <summary>The hireable property</summary>
        public bool? Hireable { get; set; }
        /// <summary>The html_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HtmlUrl { get; set; }
#nullable restore
#else
        public string HtmlUrl { get; set; }
#endif
        /// <summary>The id property</summary>
        public long? Id { get; set; }
        /// <summary>The ldap_dn property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LdapDn { get; set; }
#nullable restore
#else
        public string LdapDn { get; set; }
#endif
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
        /// <summary>The organizations_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrganizationsUrl { get; set; }
#nullable restore
#else
        public string OrganizationsUrl { get; set; }
#endif
        /// <summary>The owned_private_repos property</summary>
        public int? OwnedPrivateRepos { get; set; }
        /// <summary>The plan property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.LdapMappingUser_plan? Plan { get; set; }
#nullable restore
#else
        public global::GitHub.Models.LdapMappingUser_plan Plan { get; set; }
#endif
        /// <summary>The private_gists property</summary>
        public int? PrivateGists { get; set; }
        /// <summary>The public_gists property</summary>
        public int? PublicGists { get; set; }
        /// <summary>The public_repos property</summary>
        public int? PublicRepos { get; set; }
        /// <summary>The received_events_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReceivedEventsUrl { get; set; }
#nullable restore
#else
        public string ReceivedEventsUrl { get; set; }
#endif
        /// <summary>The repos_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReposUrl { get; set; }
#nullable restore
#else
        public string ReposUrl { get; set; }
#endif
        /// <summary>The site_admin property</summary>
        public bool? SiteAdmin { get; set; }
        /// <summary>The starred_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StarredUrl { get; set; }
#nullable restore
#else
        public string StarredUrl { get; set; }
#endif
        /// <summary>The subscriptions_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubscriptionsUrl { get; set; }
#nullable restore
#else
        public string SubscriptionsUrl { get; set; }
#endif
        /// <summary>The suspended_at property</summary>
        public DateTimeOffset? SuspendedAt { get; set; }
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
        /// <summary>The two_factor_authentication property</summary>
        public bool? TwoFactorAuthentication { get; set; }
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
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.LdapMappingUser"/> and sets the default values.
        /// </summary>
        public LdapMappingUser()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.LdapMappingUser"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.LdapMappingUser CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.LdapMappingUser();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "avatar_url", n => { AvatarUrl = n.GetStringValue(); } },
                { "bio", n => { Bio = n.GetStringValue(); } },
                { "blog", n => { Blog = n.GetStringValue(); } },
                { "business_plus", n => { BusinessPlus = n.GetBoolValue(); } },
                { "collaborators", n => { Collaborators = n.GetIntValue(); } },
                { "company", n => { Company = n.GetStringValue(); } },
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "disk_usage", n => { DiskUsage = n.GetIntValue(); } },
                { "email", n => { Email = n.GetStringValue(); } },
                { "events_url", n => { EventsUrl = n.GetStringValue(); } },
                { "followers", n => { Followers = n.GetIntValue(); } },
                { "followers_url", n => { FollowersUrl = n.GetStringValue(); } },
                { "following", n => { Following = n.GetIntValue(); } },
                { "following_url", n => { FollowingUrl = n.GetStringValue(); } },
                { "gists_url", n => { GistsUrl = n.GetStringValue(); } },
                { "gravatar_id", n => { GravatarId = n.GetStringValue(); } },
                { "hireable", n => { Hireable = n.GetBoolValue(); } },
                { "html_url", n => { HtmlUrl = n.GetStringValue(); } },
                { "id", n => { Id = n.GetLongValue(); } },
                { "ldap_dn", n => { LdapDn = n.GetStringValue(); } },
                { "location", n => { Location = n.GetStringValue(); } },
                { "login", n => { Login = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "node_id", n => { NodeId = n.GetStringValue(); } },
                { "organizations_url", n => { OrganizationsUrl = n.GetStringValue(); } },
                { "owned_private_repos", n => { OwnedPrivateRepos = n.GetIntValue(); } },
                { "plan", n => { Plan = n.GetObjectValue<global::GitHub.Models.LdapMappingUser_plan>(global::GitHub.Models.LdapMappingUser_plan.CreateFromDiscriminatorValue); } },
                { "private_gists", n => { PrivateGists = n.GetIntValue(); } },
                { "public_gists", n => { PublicGists = n.GetIntValue(); } },
                { "public_repos", n => { PublicRepos = n.GetIntValue(); } },
                { "received_events_url", n => { ReceivedEventsUrl = n.GetStringValue(); } },
                { "repos_url", n => { ReposUrl = n.GetStringValue(); } },
                { "site_admin", n => { SiteAdmin = n.GetBoolValue(); } },
                { "starred_url", n => { StarredUrl = n.GetStringValue(); } },
                { "subscriptions_url", n => { SubscriptionsUrl = n.GetStringValue(); } },
                { "suspended_at", n => { SuspendedAt = n.GetDateTimeOffsetValue(); } },
                { "total_private_repos", n => { TotalPrivateRepos = n.GetIntValue(); } },
                { "twitter_username", n => { TwitterUsername = n.GetStringValue(); } },
                { "two_factor_authentication", n => { TwoFactorAuthentication = n.GetBoolValue(); } },
                { "type", n => { Type = n.GetStringValue(); } },
                { "updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                { "url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("avatar_url", AvatarUrl);
            writer.WriteStringValue("bio", Bio);
            writer.WriteStringValue("blog", Blog);
            writer.WriteBoolValue("business_plus", BusinessPlus);
            writer.WriteIntValue("collaborators", Collaborators);
            writer.WriteStringValue("company", Company);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteIntValue("disk_usage", DiskUsage);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("events_url", EventsUrl);
            writer.WriteIntValue("followers", Followers);
            writer.WriteStringValue("followers_url", FollowersUrl);
            writer.WriteIntValue("following", Following);
            writer.WriteStringValue("following_url", FollowingUrl);
            writer.WriteStringValue("gists_url", GistsUrl);
            writer.WriteStringValue("gravatar_id", GravatarId);
            writer.WriteBoolValue("hireable", Hireable);
            writer.WriteStringValue("html_url", HtmlUrl);
            writer.WriteLongValue("id", Id);
            writer.WriteStringValue("ldap_dn", LdapDn);
            writer.WriteStringValue("location", Location);
            writer.WriteStringValue("login", Login);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("node_id", NodeId);
            writer.WriteStringValue("organizations_url", OrganizationsUrl);
            writer.WriteIntValue("owned_private_repos", OwnedPrivateRepos);
            writer.WriteObjectValue<global::GitHub.Models.LdapMappingUser_plan>("plan", Plan);
            writer.WriteIntValue("private_gists", PrivateGists);
            writer.WriteIntValue("public_gists", PublicGists);
            writer.WriteIntValue("public_repos", PublicRepos);
            writer.WriteStringValue("received_events_url", ReceivedEventsUrl);
            writer.WriteStringValue("repos_url", ReposUrl);
            writer.WriteBoolValue("site_admin", SiteAdmin);
            writer.WriteStringValue("starred_url", StarredUrl);
            writer.WriteStringValue("subscriptions_url", SubscriptionsUrl);
            writer.WriteDateTimeOffsetValue("suspended_at", SuspendedAt);
            writer.WriteIntValue("total_private_repos", TotalPrivateRepos);
            writer.WriteStringValue("twitter_username", TwitterUsername);
            writer.WriteBoolValue("two_factor_authentication", TwoFactorAuthentication);
            writer.WriteStringValue("type", Type);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
