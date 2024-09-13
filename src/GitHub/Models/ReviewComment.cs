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
    /// Legacy Review Comment
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class ReviewComment : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>How the author is associated with the repository.</summary>
        public global::GitHub.Models.AuthorAssociation? AuthorAssociation { get; set; }
        /// <summary>The body property</summary>
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
        /// <summary>The body_text property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BodyText { get; set; }
#nullable restore
#else
        public string BodyText { get; set; }
#endif
        /// <summary>The commit_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommitId { get; set; }
#nullable restore
#else
        public string CommitId { get; set; }
#endif
        /// <summary>The created_at property</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The diff_hunk property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DiffHunk { get; set; }
#nullable restore
#else
        public string DiffHunk { get; set; }
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
        public long? Id { get; set; }
        /// <summary>The in_reply_to_id property</summary>
        public int? InReplyToId { get; set; }
        /// <summary>The line of the blob to which the comment applies. The last line of the range for a multi-line comment</summary>
        public int? Line { get; set; }
        /// <summary>The _links property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.ReviewComment__links? Links { get; set; }
#nullable restore
#else
        public global::GitHub.Models.ReviewComment__links Links { get; set; }
#endif
        /// <summary>The node_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NodeId { get; set; }
#nullable restore
#else
        public string NodeId { get; set; }
#endif
        /// <summary>The original_commit_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OriginalCommitId { get; set; }
#nullable restore
#else
        public string OriginalCommitId { get; set; }
#endif
        /// <summary>The original line of the blob to which the comment applies. The last line of the range for a multi-line comment</summary>
        public int? OriginalLine { get; set; }
        /// <summary>The original_position property</summary>
        public int? OriginalPosition { get; set; }
        /// <summary>The original first line of the range for a multi-line comment.</summary>
        public int? OriginalStartLine { get; set; }
        /// <summary>The path property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Path { get; set; }
#nullable restore
#else
        public string Path { get; set; }
#endif
        /// <summary>The position property</summary>
        public int? Position { get; set; }
        /// <summary>The pull_request_review_id property</summary>
        public long? PullRequestReviewId { get; set; }
        /// <summary>The pull_request_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PullRequestUrl { get; set; }
#nullable restore
#else
        public string PullRequestUrl { get; set; }
#endif
        /// <summary>The reactions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.ReactionRollup? Reactions { get; set; }
#nullable restore
#else
        public global::GitHub.Models.ReactionRollup Reactions { get; set; }
#endif
        /// <summary>The side of the first line of the range for a multi-line comment.</summary>
        public global::GitHub.Models.ReviewComment_side? Side { get; set; }
        /// <summary>The first line of the range for a multi-line comment.</summary>
        public int? StartLine { get; set; }
        /// <summary>The side of the first line of the range for a multi-line comment.</summary>
        public global::GitHub.Models.ReviewComment_start_side? StartSide { get; set; }
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
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.NullableSimpleUser? User { get; set; }
#nullable restore
#else
        public global::GitHub.Models.NullableSimpleUser User { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.ReviewComment"/> and sets the default values.
        /// </summary>
        public ReviewComment()
        {
            AdditionalData = new Dictionary<string, object>();
            Side = global::GitHub.Models.ReviewComment_side.RIGHT;
            StartSide = global::GitHub.Models.ReviewComment_start_side.RIGHT;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.ReviewComment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.ReviewComment CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.ReviewComment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "author_association", n => { AuthorAssociation = n.GetEnumValue<global::GitHub.Models.AuthorAssociation>(); } },
                { "body", n => { Body = n.GetStringValue(); } },
                { "body_html", n => { BodyHtml = n.GetStringValue(); } },
                { "body_text", n => { BodyText = n.GetStringValue(); } },
                { "commit_id", n => { CommitId = n.GetStringValue(); } },
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "diff_hunk", n => { DiffHunk = n.GetStringValue(); } },
                { "html_url", n => { HtmlUrl = n.GetStringValue(); } },
                { "id", n => { Id = n.GetLongValue(); } },
                { "in_reply_to_id", n => { InReplyToId = n.GetIntValue(); } },
                { "line", n => { Line = n.GetIntValue(); } },
                { "_links", n => { Links = n.GetObjectValue<global::GitHub.Models.ReviewComment__links>(global::GitHub.Models.ReviewComment__links.CreateFromDiscriminatorValue); } },
                { "node_id", n => { NodeId = n.GetStringValue(); } },
                { "original_commit_id", n => { OriginalCommitId = n.GetStringValue(); } },
                { "original_line", n => { OriginalLine = n.GetIntValue(); } },
                { "original_position", n => { OriginalPosition = n.GetIntValue(); } },
                { "original_start_line", n => { OriginalStartLine = n.GetIntValue(); } },
                { "path", n => { Path = n.GetStringValue(); } },
                { "position", n => { Position = n.GetIntValue(); } },
                { "pull_request_review_id", n => { PullRequestReviewId = n.GetLongValue(); } },
                { "pull_request_url", n => { PullRequestUrl = n.GetStringValue(); } },
                { "reactions", n => { Reactions = n.GetObjectValue<global::GitHub.Models.ReactionRollup>(global::GitHub.Models.ReactionRollup.CreateFromDiscriminatorValue); } },
                { "side", n => { Side = n.GetEnumValue<global::GitHub.Models.ReviewComment_side>(); } },
                { "start_line", n => { StartLine = n.GetIntValue(); } },
                { "start_side", n => { StartSide = n.GetEnumValue<global::GitHub.Models.ReviewComment_start_side>(); } },
                { "updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                { "url", n => { Url = n.GetStringValue(); } },
                { "user", n => { User = n.GetObjectValue<global::GitHub.Models.NullableSimpleUser>(global::GitHub.Models.NullableSimpleUser.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::GitHub.Models.AuthorAssociation>("author_association", AuthorAssociation);
            writer.WriteStringValue("body", Body);
            writer.WriteStringValue("body_html", BodyHtml);
            writer.WriteStringValue("body_text", BodyText);
            writer.WriteStringValue("commit_id", CommitId);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteStringValue("diff_hunk", DiffHunk);
            writer.WriteStringValue("html_url", HtmlUrl);
            writer.WriteLongValue("id", Id);
            writer.WriteIntValue("in_reply_to_id", InReplyToId);
            writer.WriteIntValue("line", Line);
            writer.WriteObjectValue<global::GitHub.Models.ReviewComment__links>("_links", Links);
            writer.WriteStringValue("node_id", NodeId);
            writer.WriteStringValue("original_commit_id", OriginalCommitId);
            writer.WriteIntValue("original_line", OriginalLine);
            writer.WriteIntValue("original_position", OriginalPosition);
            writer.WriteIntValue("original_start_line", OriginalStartLine);
            writer.WriteStringValue("path", Path);
            writer.WriteIntValue("position", Position);
            writer.WriteLongValue("pull_request_review_id", PullRequestReviewId);
            writer.WriteStringValue("pull_request_url", PullRequestUrl);
            writer.WriteObjectValue<global::GitHub.Models.ReactionRollup>("reactions", Reactions);
            writer.WriteEnumValue<global::GitHub.Models.ReviewComment_side>("side", Side);
            writer.WriteIntValue("start_line", StartLine);
            writer.WriteEnumValue<global::GitHub.Models.ReviewComment_start_side>("start_side", StartSide);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteStringValue("url", Url);
            writer.WriteObjectValue<global::GitHub.Models.NullableSimpleUser>("user", User);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
