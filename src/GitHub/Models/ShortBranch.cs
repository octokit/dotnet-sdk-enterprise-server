// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    /// <summary>
    /// Short Branch
    /// </summary>
    public class ShortBranch : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The commit property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ShortBranch_commit? Commit { get; set; }
#nullable restore
#else
        public ShortBranch_commit Commit { get; set; }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The protected property</summary>
        public bool? Protected { get; set; }
        /// <summary>Branch Protection</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public BranchProtection? Protection { get; set; }
#nullable restore
#else
        public BranchProtection Protection { get; set; }
#endif
        /// <summary>The protection_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProtectionUrl { get; set; }
#nullable restore
#else
        public string ProtectionUrl { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ShortBranch"/> and sets the default values.
        /// </summary>
        public ShortBranch()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ShortBranch"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ShortBranch CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ShortBranch();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"commit", n => { Commit = n.GetObjectValue<ShortBranch_commit>(ShortBranch_commit.CreateFromDiscriminatorValue); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"protected", n => { Protected = n.GetBoolValue(); } },
                {"protection", n => { Protection = n.GetObjectValue<BranchProtection>(BranchProtection.CreateFromDiscriminatorValue); } },
                {"protection_url", n => { ProtectionUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ShortBranch_commit>("commit", Commit);
            writer.WriteStringValue("name", Name);
            writer.WriteBoolValue("protected", Protected);
            writer.WriteObjectValue<BranchProtection>("protection", Protection);
            writer.WriteStringValue("protection_url", ProtectionUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
