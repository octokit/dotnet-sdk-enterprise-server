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
    /// Repository invitations let you manage who you collaborate with.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class RepositoryInvitation : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The created_at property</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>Whether or not the invitation has expired</summary>
        public bool? Expired { get; set; }
        /// <summary>The html_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HtmlUrl { get; set; }
#nullable restore
#else
        public string HtmlUrl { get; set; }
#endif
        /// <summary>Unique identifier of the repository invitation.</summary>
        public long? Id { get; set; }
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.NullableSimpleUser? Invitee { get; set; }
#nullable restore
#else
        public global::GitHub.Models.NullableSimpleUser Invitee { get; set; }
#endif
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.NullableSimpleUser? Inviter { get; set; }
#nullable restore
#else
        public global::GitHub.Models.NullableSimpleUser Inviter { get; set; }
#endif
        /// <summary>The node_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NodeId { get; set; }
#nullable restore
#else
        public string NodeId { get; set; }
#endif
        /// <summary>The permission associated with the invitation.</summary>
        public global::GitHub.Models.RepositoryInvitation_permissions? Permissions { get; set; }
        /// <summary>Minimal Repository</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.MinimalRepository? Repository { get; set; }
#nullable restore
#else
        public global::GitHub.Models.MinimalRepository Repository { get; set; }
#endif
        /// <summary>URL for the repository invitation</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.RepositoryInvitation"/> and sets the default values.
        /// </summary>
        public RepositoryInvitation()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.RepositoryInvitation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.RepositoryInvitation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.RepositoryInvitation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "expired", n => { Expired = n.GetBoolValue(); } },
                { "html_url", n => { HtmlUrl = n.GetStringValue(); } },
                { "id", n => { Id = n.GetLongValue(); } },
                { "invitee", n => { Invitee = n.GetObjectValue<global::GitHub.Models.NullableSimpleUser>(global::GitHub.Models.NullableSimpleUser.CreateFromDiscriminatorValue); } },
                { "inviter", n => { Inviter = n.GetObjectValue<global::GitHub.Models.NullableSimpleUser>(global::GitHub.Models.NullableSimpleUser.CreateFromDiscriminatorValue); } },
                { "node_id", n => { NodeId = n.GetStringValue(); } },
                { "permissions", n => { Permissions = n.GetEnumValue<global::GitHub.Models.RepositoryInvitation_permissions>(); } },
                { "repository", n => { Repository = n.GetObjectValue<global::GitHub.Models.MinimalRepository>(global::GitHub.Models.MinimalRepository.CreateFromDiscriminatorValue); } },
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
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteBoolValue("expired", Expired);
            writer.WriteStringValue("html_url", HtmlUrl);
            writer.WriteLongValue("id", Id);
            writer.WriteObjectValue<global::GitHub.Models.NullableSimpleUser>("invitee", Invitee);
            writer.WriteObjectValue<global::GitHub.Models.NullableSimpleUser>("inviter", Inviter);
            writer.WriteStringValue("node_id", NodeId);
            writer.WriteEnumValue<global::GitHub.Models.RepositoryInvitation_permissions>("permissions", Permissions);
            writer.WriteObjectValue<global::GitHub.Models.MinimalRepository>("repository", Repository);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
