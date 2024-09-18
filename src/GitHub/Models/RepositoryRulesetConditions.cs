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
    /// Parameters for a repository ruleset ref name condition
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class RepositoryRulesetConditions : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ref_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.RepositoryRulesetConditions_ref_name? RefName { get; set; }
#nullable restore
#else
        public global::GitHub.Models.RepositoryRulesetConditions_ref_name RefName { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.RepositoryRulesetConditions"/> and sets the default values.
        /// </summary>
        public RepositoryRulesetConditions()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.RepositoryRulesetConditions"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.RepositoryRulesetConditions CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.RepositoryRulesetConditions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "ref_name", n => { RefName = n.GetObjectValue<global::GitHub.Models.RepositoryRulesetConditions_ref_name>(global::GitHub.Models.RepositoryRulesetConditions_ref_name.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::GitHub.Models.RepositoryRulesetConditions_ref_name>("ref_name", RefName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
