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
    /// Commit
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class Commit : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The author property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.Commit.Commit_author? Author { get; set; }
#nullable restore
#else
        public global::GitHub.Models.Commit.Commit_author Author { get; set; }
#endif
        /// <summary>The comments_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommentsUrl { get; set; }
#nullable restore
#else
        public string CommentsUrl { get; set; }
#endif
        /// <summary>The commit property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.Commit_commit? CommitProp { get; set; }
#nullable restore
#else
        public global::GitHub.Models.Commit_commit CommitProp { get; set; }
#endif
        /// <summary>The committer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.Commit.Commit_committer? Committer { get; set; }
#nullable restore
#else
        public global::GitHub.Models.Commit.Commit_committer Committer { get; set; }
#endif
        /// <summary>The files property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::GitHub.Models.DiffEntry>? Files { get; set; }
#nullable restore
#else
        public List<global::GitHub.Models.DiffEntry> Files { get; set; }
#endif
        /// <summary>The html_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HtmlUrl { get; set; }
#nullable restore
#else
        public string HtmlUrl { get; set; }
#endif
        /// <summary>The node_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NodeId { get; set; }
#nullable restore
#else
        public string NodeId { get; set; }
#endif
        /// <summary>The parents property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::GitHub.Models.Commit_parents>? Parents { get; set; }
#nullable restore
#else
        public List<global::GitHub.Models.Commit_parents> Parents { get; set; }
#endif
        /// <summary>The sha property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sha { get; set; }
#nullable restore
#else
        public string Sha { get; set; }
#endif
        /// <summary>The stats property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.Commit_stats? Stats { get; set; }
#nullable restore
#else
        public global::GitHub.Models.Commit_stats Stats { get; set; }
#endif
        /// <summary>The url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.Commit"/> and sets the default values.
        /// </summary>
        public Commit()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.Commit"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.Commit CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.Commit();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "author", n => { Author = n.GetObjectValue<global::GitHub.Models.Commit.Commit_author>(global::GitHub.Models.Commit.Commit_author.CreateFromDiscriminatorValue); } },
                { "comments_url", n => { CommentsUrl = n.GetStringValue(); } },
                { "commit", n => { CommitProp = n.GetObjectValue<global::GitHub.Models.Commit_commit>(global::GitHub.Models.Commit_commit.CreateFromDiscriminatorValue); } },
                { "committer", n => { Committer = n.GetObjectValue<global::GitHub.Models.Commit.Commit_committer>(global::GitHub.Models.Commit.Commit_committer.CreateFromDiscriminatorValue); } },
                { "files", n => { Files = n.GetCollectionOfObjectValues<global::GitHub.Models.DiffEntry>(global::GitHub.Models.DiffEntry.CreateFromDiscriminatorValue)?.AsList(); } },
                { "html_url", n => { HtmlUrl = n.GetStringValue(); } },
                { "node_id", n => { NodeId = n.GetStringValue(); } },
                { "parents", n => { Parents = n.GetCollectionOfObjectValues<global::GitHub.Models.Commit_parents>(global::GitHub.Models.Commit_parents.CreateFromDiscriminatorValue)?.AsList(); } },
                { "sha", n => { Sha = n.GetStringValue(); } },
                { "stats", n => { Stats = n.GetObjectValue<global::GitHub.Models.Commit_stats>(global::GitHub.Models.Commit_stats.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::GitHub.Models.Commit.Commit_author>("author", Author);
            writer.WriteStringValue("comments_url", CommentsUrl);
            writer.WriteObjectValue<global::GitHub.Models.Commit_commit>("commit", CommitProp);
            writer.WriteObjectValue<global::GitHub.Models.Commit.Commit_committer>("committer", Committer);
            writer.WriteCollectionOfObjectValues<global::GitHub.Models.DiffEntry>("files", Files);
            writer.WriteStringValue("html_url", HtmlUrl);
            writer.WriteStringValue("node_id", NodeId);
            writer.WriteCollectionOfObjectValues<global::GitHub.Models.Commit_parents>("parents", Parents);
            writer.WriteStringValue("sha", Sha);
            writer.WriteObjectValue<global::GitHub.Models.Commit_stats>("stats", Stats);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::GitHub.Models.EmptyObject"/>, <see cref="global::GitHub.Models.SimpleUser"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class Commit_author : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::GitHub.Models.EmptyObject"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::GitHub.Models.EmptyObject? EmptyObject { get; set; }
#nullable restore
#else
            public global::GitHub.Models.EmptyObject EmptyObject { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::GitHub.Models.SimpleUser"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::GitHub.Models.SimpleUser? SimpleUser { get; set; }
#nullable restore
#else
            public global::GitHub.Models.SimpleUser SimpleUser { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::GitHub.Models.Commit.Commit_author"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::GitHub.Models.Commit.Commit_author CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::GitHub.Models.Commit.Commit_author();
                if("empty-object".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.EmptyObject = new global::GitHub.Models.EmptyObject();
                }
                else if("simple-user".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.SimpleUser = new global::GitHub.Models.SimpleUser();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(EmptyObject != null)
                {
                    return EmptyObject.GetFieldDeserializers();
                }
                else if(SimpleUser != null)
                {
                    return SimpleUser.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer)
            {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(EmptyObject != null)
                {
                    writer.WriteObjectValue<global::GitHub.Models.EmptyObject>(null, EmptyObject);
                }
                else if(SimpleUser != null)
                {
                    writer.WriteObjectValue<global::GitHub.Models.SimpleUser>(null, SimpleUser);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::GitHub.Models.EmptyObject"/>, <see cref="global::GitHub.Models.SimpleUser"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class Commit_committer : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::GitHub.Models.EmptyObject"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::GitHub.Models.EmptyObject? EmptyObject { get; set; }
#nullable restore
#else
            public global::GitHub.Models.EmptyObject EmptyObject { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::GitHub.Models.SimpleUser"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::GitHub.Models.SimpleUser? SimpleUser { get; set; }
#nullable restore
#else
            public global::GitHub.Models.SimpleUser SimpleUser { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::GitHub.Models.Commit.Commit_committer"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::GitHub.Models.Commit.Commit_committer CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::GitHub.Models.Commit.Commit_committer();
                if("empty-object".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.EmptyObject = new global::GitHub.Models.EmptyObject();
                }
                else if("simple-user".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.SimpleUser = new global::GitHub.Models.SimpleUser();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(EmptyObject != null)
                {
                    return EmptyObject.GetFieldDeserializers();
                }
                else if(SimpleUser != null)
                {
                    return SimpleUser.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer)
            {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(EmptyObject != null)
                {
                    writer.WriteObjectValue<global::GitHub.Models.EmptyObject>(null, EmptyObject);
                }
                else if(SimpleUser != null)
                {
                    writer.WriteObjectValue<global::GitHub.Models.SimpleUser>(null, SimpleUser);
                }
            }
        }
    }
}
#pragma warning restore CS0618
