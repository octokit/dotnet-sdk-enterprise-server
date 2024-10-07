// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class PreReceiveHook : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The allow_downstream_configuration property</summary>
        public bool? AllowDownstreamConfiguration { get; set; }
        /// <summary>The enforcement property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Enforcement { get; set; }
#nullable restore
#else
        public string Enforcement { get; set; }
#endif
        /// <summary>The environment property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.PreReceiveHook_environment? Environment { get; set; }
#nullable restore
#else
        public global::GitHub.Models.PreReceiveHook_environment Environment { get; set; }
#endif
        /// <summary>The id property</summary>
        public int? Id { get; set; }
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The script property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Script { get; set; }
#nullable restore
#else
        public string Script { get; set; }
#endif
        /// <summary>The script_repository property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.PreReceiveHook_script_repository? ScriptRepository { get; set; }
#nullable restore
#else
        public global::GitHub.Models.PreReceiveHook_script_repository ScriptRepository { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.PreReceiveHook"/> and sets the default values.
        /// </summary>
        public PreReceiveHook()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.PreReceiveHook"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.PreReceiveHook CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.PreReceiveHook();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "allow_downstream_configuration", n => { AllowDownstreamConfiguration = n.GetBoolValue(); } },
                { "enforcement", n => { Enforcement = n.GetStringValue(); } },
                { "environment", n => { Environment = n.GetObjectValue<global::GitHub.Models.PreReceiveHook_environment>(global::GitHub.Models.PreReceiveHook_environment.CreateFromDiscriminatorValue); } },
                { "id", n => { Id = n.GetIntValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "script", n => { Script = n.GetStringValue(); } },
                { "script_repository", n => { ScriptRepository = n.GetObjectValue<global::GitHub.Models.PreReceiveHook_script_repository>(global::GitHub.Models.PreReceiveHook_script_repository.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::GitHub.Models.PreReceiveHook_environment>("environment", Environment);
            writer.WriteIntValue("id", Id);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("script", Script);
            writer.WriteObjectValue<global::GitHub.Models.PreReceiveHook_script_repository>("script_repository", ScriptRepository);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
