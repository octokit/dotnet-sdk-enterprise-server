// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class RepositoryRuleCommitMessagePattern_parameters : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>How this rule will appear to users.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>If true, the rule will fail if the pattern matches.</summary>
        public bool? Negate { get; set; }
        /// <summary>The operator to use for matching.</summary>
        public global::GitHub.Models.RepositoryRuleCommitMessagePattern_parameters_operator? Operator { get; set; }
        /// <summary>The pattern to match with.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Pattern { get; set; }
#nullable restore
#else
        public string Pattern { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.RepositoryRuleCommitMessagePattern_parameters"/> and sets the default values.
        /// </summary>
        public RepositoryRuleCommitMessagePattern_parameters()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.RepositoryRuleCommitMessagePattern_parameters"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.RepositoryRuleCommitMessagePattern_parameters CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.RepositoryRuleCommitMessagePattern_parameters();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "name", n => { Name = n.GetStringValue(); } },
                { "negate", n => { Negate = n.GetBoolValue(); } },
                { "operator", n => { Operator = n.GetEnumValue<global::GitHub.Models.RepositoryRuleCommitMessagePattern_parameters_operator>(); } },
                { "pattern", n => { Pattern = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("name", Name);
            writer.WriteBoolValue("negate", Negate);
            writer.WriteEnumValue<global::GitHub.Models.RepositoryRuleCommitMessagePattern_parameters_operator>("operator", Operator);
            writer.WriteStringValue("pattern", Pattern);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
