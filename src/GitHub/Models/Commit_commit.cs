// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class Commit_commit : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Metaproperties for Git author/committer information.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.NullableGitUser? Author { get; set; }
#nullable restore
#else
        public global::GitHub.Models.NullableGitUser Author { get; set; }
#endif
        /// <summary>The comment_count property</summary>
        public int? CommentCount { get; set; }
        /// <summary>Metaproperties for Git author/committer information.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.NullableGitUser? Committer { get; set; }
#nullable restore
#else
        public global::GitHub.Models.NullableGitUser Committer { get; set; }
#endif
        /// <summary>The message property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message { get; set; }
#nullable restore
#else
        public string Message { get; set; }
#endif
        /// <summary>The tree property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.Commit_commit_tree? Tree { get; set; }
#nullable restore
#else
        public global::GitHub.Models.Commit_commit_tree Tree { get; set; }
#endif
        /// <summary>The url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>The verification property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.Verification? Verification { get; set; }
#nullable restore
#else
        public global::GitHub.Models.Verification Verification { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.Commit_commit"/> and sets the default values.
        /// </summary>
        public Commit_commit()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.Commit_commit"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.Commit_commit CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.Commit_commit();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "author", n => { Author = n.GetObjectValue<global::GitHub.Models.NullableGitUser>(global::GitHub.Models.NullableGitUser.CreateFromDiscriminatorValue); } },
                { "comment_count", n => { CommentCount = n.GetIntValue(); } },
                { "committer", n => { Committer = n.GetObjectValue<global::GitHub.Models.NullableGitUser>(global::GitHub.Models.NullableGitUser.CreateFromDiscriminatorValue); } },
                { "message", n => { Message = n.GetStringValue(); } },
                { "tree", n => { Tree = n.GetObjectValue<global::GitHub.Models.Commit_commit_tree>(global::GitHub.Models.Commit_commit_tree.CreateFromDiscriminatorValue); } },
                { "url", n => { Url = n.GetStringValue(); } },
                { "verification", n => { Verification = n.GetObjectValue<global::GitHub.Models.Verification>(global::GitHub.Models.Verification.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::GitHub.Models.NullableGitUser>("author", Author);
            writer.WriteIntValue("comment_count", CommentCount);
            writer.WriteObjectValue<global::GitHub.Models.NullableGitUser>("committer", Committer);
            writer.WriteStringValue("message", Message);
            writer.WriteObjectValue<global::GitHub.Models.Commit_commit_tree>("tree", Tree);
            writer.WriteStringValue("url", Url);
            writer.WriteObjectValue<global::GitHub.Models.Verification>("verification", Verification);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
