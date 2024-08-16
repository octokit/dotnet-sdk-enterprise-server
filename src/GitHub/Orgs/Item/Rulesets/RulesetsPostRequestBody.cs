// <auto-generated/>
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Orgs.Item.Rulesets {
    #pragma warning disable CS1591
    public class RulesetsPostRequestBody : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The actors that can bypass the rules in this ruleset</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RepositoryRulesetBypassActor>? BypassActors { get; set; }
#nullable restore
#else
        public List<RepositoryRulesetBypassActor> BypassActors { get; set; }
#endif
        /// <summary>Conditions for an organization ruleset. The conditions object should contain both `repository_name` and `ref_name` properties or both `repository_id` and `ref_name` properties.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public OrgRulesetConditions? Conditions { get; set; }
#nullable restore
#else
        public OrgRulesetConditions Conditions { get; set; }
#endif
        /// <summary>The enforcement level of the ruleset. `evaluate` allows admins to test rules before enforcing them. Admins can view insights on the Rule Insights page.</summary>
        public RepositoryRuleEnforcement? Enforcement { get; set; }
        /// <summary>The name of the ruleset.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>An array of rules within the ruleset.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RepositoryRule>? Rules { get; set; }
#nullable restore
#else
        public List<RepositoryRule> Rules { get; set; }
#endif
        /// <summary>The target of the ruleset.</summary>
        public RulesetsPostRequestBody_target? Target { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="RulesetsPostRequestBody"/> and sets the default values.
        /// </summary>
        public RulesetsPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
            Target = RulesetsPostRequestBody_target.Branch;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="RulesetsPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RulesetsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RulesetsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"bypass_actors", n => { BypassActors = n.GetCollectionOfObjectValues<RepositoryRulesetBypassActor>(RepositoryRulesetBypassActor.CreateFromDiscriminatorValue)?.ToList(); } },
                {"conditions", n => { Conditions = n.GetObjectValue<OrgRulesetConditions>(OrgRulesetConditions.CreateFromDiscriminatorValue); } },
                {"enforcement", n => { Enforcement = n.GetEnumValue<RepositoryRuleEnforcement>(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"rules", n => { Rules = n.GetCollectionOfObjectValues<RepositoryRule>(RepositoryRule.CreateFromDiscriminatorValue)?.ToList(); } },
                {"target", n => { Target = n.GetEnumValue<RulesetsPostRequestBody_target>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<RepositoryRulesetBypassActor>("bypass_actors", BypassActors);
            writer.WriteObjectValue<OrgRulesetConditions>("conditions", Conditions);
            writer.WriteEnumValue<RepositoryRuleEnforcement>("enforcement", Enforcement);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<RepositoryRule>("rules", Rules);
            writer.WriteEnumValue<RulesetsPostRequestBody_target>("target", Target);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
