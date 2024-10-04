// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Repos.Item.Item.Pulls.Item.Merge
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class MergePutRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Extra detail to append to automatic commit message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommitMessage { get; set; }
#nullable restore
#else
        public string CommitMessage { get; set; }
#endif
        /// <summary>Title for the automatic commit message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommitTitle { get; set; }
#nullable restore
#else
        public string CommitTitle { get; set; }
#endif
        /// <summary>The merge method to use.</summary>
        public global::GitHub.Repos.Item.Item.Pulls.Item.Merge.MergePutRequestBody_merge_method? MergeMethod { get; set; }
        /// <summary>SHA that pull request head must match to allow merge.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sha { get; set; }
#nullable restore
#else
        public string Sha { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Pulls.Item.Merge.MergePutRequestBody"/> and sets the default values.
        /// </summary>
        public MergePutRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Pulls.Item.Merge.MergePutRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Repos.Item.Item.Pulls.Item.Merge.MergePutRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Repos.Item.Item.Pulls.Item.Merge.MergePutRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "commit_message", n => { CommitMessage = n.GetStringValue(); } },
                { "commit_title", n => { CommitTitle = n.GetStringValue(); } },
                { "merge_method", n => { MergeMethod = n.GetEnumValue<global::GitHub.Repos.Item.Item.Pulls.Item.Merge.MergePutRequestBody_merge_method>(); } },
                { "sha", n => { Sha = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("commit_message", CommitMessage);
            writer.WriteStringValue("commit_title", CommitTitle);
            writer.WriteEnumValue<global::GitHub.Repos.Item.Item.Pulls.Item.Merge.MergePutRequestBody_merge_method>("merge_method", MergeMethod);
            writer.WriteStringValue("sha", Sha);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
