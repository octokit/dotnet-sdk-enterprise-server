// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Repos.Item.Item.Pulls.Item.Comments
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class CommentsPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The text of the review comment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Body { get; set; }
#nullable restore
#else
        public string Body { get; set; }
#endif
        /// <summary>The SHA of the commit needing a comment. Not using the latest commit SHA may render your comment outdated if a subsequent commit modifies the line you specify as the `position`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommitId { get; set; }
#nullable restore
#else
        public string CommitId { get; set; }
#endif
        /// <summary>The ID of the review comment to reply to. To find the ID of a review comment with [&quot;List review comments on a pull request&quot;](#list-review-comments-on-a-pull-request). When specified, all parameters other than `body` in the request body are ignored.</summary>
        public int? InReplyTo { get; set; }
        /// <summary>**Required unless using `subject_type:file`**. The line of the blob in the pull request diff that the comment applies to. For a multi-line comment, the last line of the range that your comment applies to.</summary>
        public int? Line { get; set; }
        /// <summary>The relative path to the file that necessitates a comment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Path { get; set; }
#nullable restore
#else
        public string Path { get; set; }
#endif
        /// <summary>**This parameter is deprecated. Use `line` instead**. The position in the diff where you want to add a review comment. Note this value is not the same as the line number in the file. The position value equals the number of lines down from the first &quot;@@&quot; hunk header in the file you want to add a comment. The line just below the &quot;@@&quot; line is position 1, the next line is position 2, and so on. The position in the diff continues to increase through lines of whitespace and additional hunks until the beginning of a new file.</summary>
        [Obsolete("")]
        public int? Position { get; set; }
        /// <summary>In a split diff view, the side of the diff that the pull request&apos;s changes appear on. Can be `LEFT` or `RIGHT`. Use `LEFT` for deletions that appear in red. Use `RIGHT` for additions that appear in green or unchanged lines that appear in white and are shown for context. For a multi-line comment, side represents whether the last line of the comment range is a deletion or addition. For more information, see &quot;[Diff view options](https://docs.github.com/enterprise-server@3.13/articles/about-comparing-branches-in-pull-requests#diff-view-options)&quot; in the GitHub Help documentation.</summary>
        public global::GitHub.Repos.Item.Item.Pulls.Item.Comments.CommentsPostRequestBody_side? Side { get; set; }
        /// <summary>**Required when using multi-line comments unless using `in_reply_to`**. The `start_line` is the first line in the pull request diff that your multi-line comment applies to. To learn more about multi-line comments, see &quot;[Commenting on a pull request](https://docs.github.com/enterprise-server@3.13/articles/commenting-on-a-pull-request#adding-line-comments-to-a-pull-request)&quot; in the GitHub Help documentation.</summary>
        public int? StartLine { get; set; }
        /// <summary>**Required when using multi-line comments unless using `in_reply_to`**. The `start_side` is the starting side of the diff that the comment applies to. Can be `LEFT` or `RIGHT`. To learn more about multi-line comments, see &quot;[Commenting on a pull request](https://docs.github.com/enterprise-server@3.13/articles/commenting-on-a-pull-request#adding-line-comments-to-a-pull-request)&quot; in the GitHub Help documentation. See `side` in this table for additional context.</summary>
        public global::GitHub.Repos.Item.Item.Pulls.Item.Comments.CommentsPostRequestBody_start_side? StartSide { get; set; }
        /// <summary>The level at which the comment is targeted.</summary>
        public global::GitHub.Repos.Item.Item.Pulls.Item.Comments.CommentsPostRequestBody_subject_type? SubjectType { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Pulls.Item.Comments.CommentsPostRequestBody"/> and sets the default values.
        /// </summary>
        public CommentsPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Pulls.Item.Comments.CommentsPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Repos.Item.Item.Pulls.Item.Comments.CommentsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Repos.Item.Item.Pulls.Item.Comments.CommentsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "body", n => { Body = n.GetStringValue(); } },
                { "commit_id", n => { CommitId = n.GetStringValue(); } },
                { "in_reply_to", n => { InReplyTo = n.GetIntValue(); } },
                { "line", n => { Line = n.GetIntValue(); } },
                { "path", n => { Path = n.GetStringValue(); } },
                { "position", n => { Position = n.GetIntValue(); } },
                { "side", n => { Side = n.GetEnumValue<global::GitHub.Repos.Item.Item.Pulls.Item.Comments.CommentsPostRequestBody_side>(); } },
                { "start_line", n => { StartLine = n.GetIntValue(); } },
                { "start_side", n => { StartSide = n.GetEnumValue<global::GitHub.Repos.Item.Item.Pulls.Item.Comments.CommentsPostRequestBody_start_side>(); } },
                { "subject_type", n => { SubjectType = n.GetEnumValue<global::GitHub.Repos.Item.Item.Pulls.Item.Comments.CommentsPostRequestBody_subject_type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("body", Body);
            writer.WriteStringValue("commit_id", CommitId);
            writer.WriteIntValue("in_reply_to", InReplyTo);
            writer.WriteIntValue("line", Line);
            writer.WriteStringValue("path", Path);
            writer.WriteIntValue("position", Position);
            writer.WriteEnumValue<global::GitHub.Repos.Item.Item.Pulls.Item.Comments.CommentsPostRequestBody_side>("side", Side);
            writer.WriteIntValue("start_line", StartLine);
            writer.WriteEnumValue<global::GitHub.Repos.Item.Item.Pulls.Item.Comments.CommentsPostRequestBody_start_side>("start_side", StartSide);
            writer.WriteEnumValue<global::GitHub.Repos.Item.Item.Pulls.Item.Comments.CommentsPostRequestBody_subject_type>("subject_type", SubjectType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
