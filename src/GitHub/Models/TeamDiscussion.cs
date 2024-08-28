// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    /// <summary>
    /// A team discussion is a persistent record of a free-form conversation within a team.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class TeamDiscussion : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.NullableSimpleUser? Author { get; set; }
#nullable restore
#else
        public global::GitHub.Models.NullableSimpleUser Author { get; set; }
#endif
        /// <summary>The main text of the discussion.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Body { get; set; }
#nullable restore
#else
        public string Body { get; set; }
#endif
        /// <summary>The body_html property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BodyHtml { get; set; }
#nullable restore
#else
        public string BodyHtml { get; set; }
#endif
        /// <summary>The current version of the body content. If provided, this update operation will be rejected if the given version does not match the latest version on the server.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BodyVersion { get; set; }
#nullable restore
#else
        public string BodyVersion { get; set; }
#endif
        /// <summary>The comments_count property</summary>
        public int? CommentsCount { get; set; }
        /// <summary>The comments_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommentsUrl { get; set; }
#nullable restore
#else
        public string CommentsUrl { get; set; }
#endif
        /// <summary>The created_at property</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The html_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HtmlUrl { get; set; }
#nullable restore
#else
        public string HtmlUrl { get; set; }
#endif
        /// <summary>The last_edited_at property</summary>
        public DateTimeOffset? LastEditedAt { get; set; }
        /// <summary>The node_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NodeId { get; set; }
#nullable restore
#else
        public string NodeId { get; set; }
#endif
        /// <summary>The unique sequence number of a team discussion.</summary>
        public int? Number { get; set; }
        /// <summary>Whether or not this discussion should be pinned for easy retrieval.</summary>
        public bool? Pinned { get; set; }
        /// <summary>Whether or not this discussion should be restricted to team members and organization owners.</summary>
        public bool? Private { get; set; }
        /// <summary>The reactions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.ReactionRollup? Reactions { get; set; }
#nullable restore
#else
        public global::GitHub.Models.ReactionRollup Reactions { get; set; }
#endif
        /// <summary>The team_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TeamUrl { get; set; }
#nullable restore
#else
        public string TeamUrl { get; set; }
#endif
        /// <summary>The title of the discussion.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
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
        /// Instantiates a new <see cref="global::GitHub.Models.TeamDiscussion"/> and sets the default values.
        /// </summary>
        public TeamDiscussion()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.TeamDiscussion"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.TeamDiscussion CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.TeamDiscussion();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "author", n => { Author = n.GetObjectValue<global::GitHub.Models.NullableSimpleUser>(global::GitHub.Models.NullableSimpleUser.CreateFromDiscriminatorValue); } },
                { "body", n => { Body = n.GetStringValue(); } },
                { "body_html", n => { BodyHtml = n.GetStringValue(); } },
                { "body_version", n => { BodyVersion = n.GetStringValue(); } },
                { "comments_count", n => { CommentsCount = n.GetIntValue(); } },
                { "comments_url", n => { CommentsUrl = n.GetStringValue(); } },
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "html_url", n => { HtmlUrl = n.GetStringValue(); } },
                { "last_edited_at", n => { LastEditedAt = n.GetDateTimeOffsetValue(); } },
                { "node_id", n => { NodeId = n.GetStringValue(); } },
                { "number", n => { Number = n.GetIntValue(); } },
                { "pinned", n => { Pinned = n.GetBoolValue(); } },
                { "private", n => { Private = n.GetBoolValue(); } },
                { "reactions", n => { Reactions = n.GetObjectValue<global::GitHub.Models.ReactionRollup>(global::GitHub.Models.ReactionRollup.CreateFromDiscriminatorValue); } },
                { "team_url", n => { TeamUrl = n.GetStringValue(); } },
                { "title", n => { Title = n.GetStringValue(); } },
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
            writer.WriteObjectValue<global::GitHub.Models.NullableSimpleUser>("author", Author);
            writer.WriteStringValue("body", Body);
            writer.WriteStringValue("body_html", BodyHtml);
            writer.WriteStringValue("body_version", BodyVersion);
            writer.WriteIntValue("comments_count", CommentsCount);
            writer.WriteStringValue("comments_url", CommentsUrl);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteStringValue("html_url", HtmlUrl);
            writer.WriteDateTimeOffsetValue("last_edited_at", LastEditedAt);
            writer.WriteStringValue("node_id", NodeId);
            writer.WriteIntValue("number", Number);
            writer.WriteBoolValue("pinned", Pinned);
            writer.WriteBoolValue("private", Private);
            writer.WriteObjectValue<global::GitHub.Models.ReactionRollup>("reactions", Reactions);
            writer.WriteStringValue("team_url", TeamUrl);
            writer.WriteStringValue("title", Title);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
