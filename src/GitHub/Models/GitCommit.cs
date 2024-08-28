// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    /// <summary>
    /// Low-level Git commit operations within a repository
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class GitCommit : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Identifying information for the git-user</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.GitCommit_author? Author { get; set; }
#nullable restore
#else
        public global::GitHub.Models.GitCommit_author Author { get; set; }
#endif
        /// <summary>Identifying information for the git-user</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.GitCommit_committer? Committer { get; set; }
#nullable restore
#else
        public global::GitHub.Models.GitCommit_committer Committer { get; set; }
#endif
        /// <summary>The html_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HtmlUrl { get; set; }
#nullable restore
#else
        public string HtmlUrl { get; set; }
#endif
        /// <summary>Message describing the purpose of the commit</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message { get; set; }
#nullable restore
#else
        public string Message { get; set; }
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
        public List<global::GitHub.Models.GitCommit_parents>? Parents { get; set; }
#nullable restore
#else
        public List<global::GitHub.Models.GitCommit_parents> Parents { get; set; }
#endif
        /// <summary>SHA for the commit</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sha { get; set; }
#nullable restore
#else
        public string Sha { get; set; }
#endif
        /// <summary>The tree property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.GitCommit_tree? Tree { get; set; }
#nullable restore
#else
        public global::GitHub.Models.GitCommit_tree Tree { get; set; }
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
        public global::GitHub.Models.GitCommit_verification? Verification { get; set; }
#nullable restore
#else
        public global::GitHub.Models.GitCommit_verification Verification { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.GitCommit"/> and sets the default values.
        /// </summary>
        public GitCommit()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.GitCommit"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.GitCommit CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.GitCommit();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "author", n => { Author = n.GetObjectValue<global::GitHub.Models.GitCommit_author>(global::GitHub.Models.GitCommit_author.CreateFromDiscriminatorValue); } },
                { "committer", n => { Committer = n.GetObjectValue<global::GitHub.Models.GitCommit_committer>(global::GitHub.Models.GitCommit_committer.CreateFromDiscriminatorValue); } },
                { "html_url", n => { HtmlUrl = n.GetStringValue(); } },
                { "message", n => { Message = n.GetStringValue(); } },
                { "node_id", n => { NodeId = n.GetStringValue(); } },
                { "parents", n => { Parents = n.GetCollectionOfObjectValues<global::GitHub.Models.GitCommit_parents>(global::GitHub.Models.GitCommit_parents.CreateFromDiscriminatorValue)?.AsList(); } },
                { "sha", n => { Sha = n.GetStringValue(); } },
                { "tree", n => { Tree = n.GetObjectValue<global::GitHub.Models.GitCommit_tree>(global::GitHub.Models.GitCommit_tree.CreateFromDiscriminatorValue); } },
                { "url", n => { Url = n.GetStringValue(); } },
                { "verification", n => { Verification = n.GetObjectValue<global::GitHub.Models.GitCommit_verification>(global::GitHub.Models.GitCommit_verification.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::GitHub.Models.GitCommit_author>("author", Author);
            writer.WriteObjectValue<global::GitHub.Models.GitCommit_committer>("committer", Committer);
            writer.WriteStringValue("html_url", HtmlUrl);
            writer.WriteStringValue("message", Message);
            writer.WriteStringValue("node_id", NodeId);
            writer.WriteCollectionOfObjectValues<global::GitHub.Models.GitCommit_parents>("parents", Parents);
            writer.WriteStringValue("sha", Sha);
            writer.WriteObjectValue<global::GitHub.Models.GitCommit_tree>("tree", Tree);
            writer.WriteStringValue("url", Url);
            writer.WriteObjectValue<global::GitHub.Models.GitCommit_verification>("verification", Verification);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
