// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    /// <summary>
    /// The hierarchy between files in a Git repository.
    /// </summary>
    public class GitTree : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The sha property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sha { get; set; }
#nullable restore
#else
        public string Sha { get; set; }
#endif
        /// <summary>Objects specifying a tree structure</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<GitTree_tree>? Tree { get; set; }
#nullable restore
#else
        public List<GitTree_tree> Tree { get; set; }
#endif
        /// <summary>The truncated property</summary>
        public bool? Truncated { get; set; }
        /// <summary>The url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="GitTree"/> and sets the default values.
        /// </summary>
        public GitTree()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="GitTree"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static GitTree CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GitTree();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"sha", n => { Sha = n.GetStringValue(); } },
                {"tree", n => { Tree = n.GetCollectionOfObjectValues<GitTree_tree>(GitTree_tree.CreateFromDiscriminatorValue)?.ToList(); } },
                {"truncated", n => { Truncated = n.GetBoolValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("sha", Sha);
            writer.WriteCollectionOfObjectValues<GitTree_tree>("tree", Tree);
            writer.WriteBoolValue("truncated", Truncated);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
