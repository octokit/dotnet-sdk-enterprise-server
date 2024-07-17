// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    #pragma warning disable CS1591
    public class EnterpriseSettings_enterprise_github_ssl : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The cert property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Cert { get; set; }
#nullable restore
#else
        public string Cert { get; set; }
#endif
        /// <summary>The enabled property</summary>
        public bool? Enabled { get; set; }
        /// <summary>The key property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Key { get; set; }
#nullable restore
#else
        public string Key { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="EnterpriseSettings_enterprise_github_ssl"/> and sets the default values.
        /// </summary>
        public EnterpriseSettings_enterprise_github_ssl()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="EnterpriseSettings_enterprise_github_ssl"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static EnterpriseSettings_enterprise_github_ssl CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EnterpriseSettings_enterprise_github_ssl();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"cert", n => { Cert = n.GetStringValue(); } },
                {"enabled", n => { Enabled = n.GetBoolValue(); } },
                {"key", n => { Key = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("cert", Cert);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteStringValue("key", Key);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
