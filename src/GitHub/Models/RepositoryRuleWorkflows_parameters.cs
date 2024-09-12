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
    public partial class RepositoryRuleWorkflows_parameters : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Allow repositories and branches to be created if a check would otherwise prohibit it.</summary>
        public bool? DoNotEnforceOnCreate { get; set; }
        /// <summary>Workflows that must pass for this rule to pass.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::GitHub.Models.RepositoryRuleParamsWorkflowFileReference>? Workflows { get; set; }
#nullable restore
#else
        public List<global::GitHub.Models.RepositoryRuleParamsWorkflowFileReference> Workflows { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.RepositoryRuleWorkflows_parameters"/> and sets the default values.
        /// </summary>
        public RepositoryRuleWorkflows_parameters()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.RepositoryRuleWorkflows_parameters"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.RepositoryRuleWorkflows_parameters CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.RepositoryRuleWorkflows_parameters();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "do_not_enforce_on_create", n => { DoNotEnforceOnCreate = n.GetBoolValue(); } },
                { "workflows", n => { Workflows = n.GetCollectionOfObjectValues<global::GitHub.Models.RepositoryRuleParamsWorkflowFileReference>(global::GitHub.Models.RepositoryRuleParamsWorkflowFileReference.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("do_not_enforce_on_create", DoNotEnforceOnCreate);
            writer.WriteCollectionOfObjectValues<global::GitHub.Models.RepositoryRuleParamsWorkflowFileReference>("workflows", Workflows);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
