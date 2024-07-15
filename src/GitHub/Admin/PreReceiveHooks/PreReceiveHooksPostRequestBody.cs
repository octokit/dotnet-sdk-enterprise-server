// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Admin.PreReceiveHooks {
    #pragma warning disable CS1591
    public class PreReceiveHooksPostRequestBody : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Whether enforcement can be overridden at the org or repo level. default: `false`</summary>
        public bool? AllowDownstreamConfiguration { get; set; }
        /// <summary>The state of enforcement for this hook. default: `disabled`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Enforcement { get; set; }
#nullable restore
#else
        public string Enforcement { get; set; }
#endif
        /// <summary>The pre-receive environment where the script is executed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PreReceiveHooksPostRequestBody_environment? Environment { get; set; }
#nullable restore
#else
        public PreReceiveHooksPostRequestBody_environment Environment { get; set; }
#endif
        /// <summary>The name of the hook.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The script that the hook runs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Script { get; set; }
#nullable restore
#else
        public string Script { get; set; }
#endif
        /// <summary>The GitHub repository where the script is kept.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PreReceiveHooksPostRequestBody_script_repository? ScriptRepository { get; set; }
#nullable restore
#else
        public PreReceiveHooksPostRequestBody_script_repository ScriptRepository { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="PreReceiveHooksPostRequestBody"/> and sets the default values.
        /// </summary>
        public PreReceiveHooksPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PreReceiveHooksPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PreReceiveHooksPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PreReceiveHooksPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"allow_downstream_configuration", n => { AllowDownstreamConfiguration = n.GetBoolValue(); } },
                {"enforcement", n => { Enforcement = n.GetStringValue(); } },
                {"environment", n => { Environment = n.GetObjectValue<PreReceiveHooksPostRequestBody_environment>(PreReceiveHooksPostRequestBody_environment.CreateFromDiscriminatorValue); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"script", n => { Script = n.GetStringValue(); } },
                {"script_repository", n => { ScriptRepository = n.GetObjectValue<PreReceiveHooksPostRequestBody_script_repository>(PreReceiveHooksPostRequestBody_script_repository.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allow_downstream_configuration", AllowDownstreamConfiguration);
            writer.WriteStringValue("enforcement", Enforcement);
            writer.WriteObjectValue<PreReceiveHooksPostRequestBody_environment>("environment", Environment);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("script", Script);
            writer.WriteObjectValue<PreReceiveHooksPostRequestBody_script_repository>("script_repository", ScriptRepository);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
