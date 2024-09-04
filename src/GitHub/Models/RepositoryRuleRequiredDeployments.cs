// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    /// <summary>
    /// Choose which environments must be successfully deployed to before refs can be pushed into a ref that matches this rule.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class RepositoryRuleRequiredDeployments : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The parameters property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.RepositoryRuleRequiredDeployments_parameters? Parameters { get; set; }
#nullable restore
#else
        public global::GitHub.Models.RepositoryRuleRequiredDeployments_parameters Parameters { get; set; }
#endif
        /// <summary>The type property</summary>
        public global::GitHub.Models.RepositoryRuleRequiredDeployments_type? Type { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.RepositoryRuleRequiredDeployments"/> and sets the default values.
        /// </summary>
        public RepositoryRuleRequiredDeployments()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.RepositoryRuleRequiredDeployments"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.RepositoryRuleRequiredDeployments CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.RepositoryRuleRequiredDeployments();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "parameters", n => { Parameters = n.GetObjectValue<global::GitHub.Models.RepositoryRuleRequiredDeployments_parameters>(global::GitHub.Models.RepositoryRuleRequiredDeployments_parameters.CreateFromDiscriminatorValue); } },
                { "type", n => { Type = n.GetEnumValue<global::GitHub.Models.RepositoryRuleRequiredDeployments_type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::GitHub.Models.RepositoryRuleRequiredDeployments_parameters>("parameters", Parameters);
            writer.WriteEnumValue<global::GitHub.Models.RepositoryRuleRequiredDeployments_type>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
