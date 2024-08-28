// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class EnterpriseSettings_enterprise_syslog : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The enabled property</summary>
        public bool? Enabled { get; set; }
        /// <summary>The protocol_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProtocolName { get; set; }
#nullable restore
#else
        public string ProtocolName { get; set; }
#endif
        /// <summary>The server property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Server { get; set; }
#nullable restore
#else
        public string Server { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.EnterpriseSettings_enterprise_syslog"/> and sets the default values.
        /// </summary>
        public EnterpriseSettings_enterprise_syslog()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.EnterpriseSettings_enterprise_syslog"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.EnterpriseSettings_enterprise_syslog CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.EnterpriseSettings_enterprise_syslog();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "enabled", n => { Enabled = n.GetBoolValue(); } },
                { "protocol_name", n => { ProtocolName = n.GetStringValue(); } },
                { "server", n => { Server = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteStringValue("protocol_name", ProtocolName);
            writer.WriteStringValue("server", Server);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
