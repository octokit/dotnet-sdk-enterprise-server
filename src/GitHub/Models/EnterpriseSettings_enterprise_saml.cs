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
    public partial class EnterpriseSettings_enterprise_saml : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The certificate property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Certificate { get; set; }
#nullable restore
#else
        public string Certificate { get; set; }
#endif
        /// <summary>The certificate_path property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertificatePath { get; set; }
#nullable restore
#else
        public string CertificatePath { get; set; }
#endif
        /// <summary>The disable_admin_demote property</summary>
        public bool? DisableAdminDemote { get; set; }
        /// <summary>The idp_initiated_sso property</summary>
        public bool? IdpInitiatedSso { get; set; }
        /// <summary>The issuer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Issuer { get; set; }
#nullable restore
#else
        public string Issuer { get; set; }
#endif
        /// <summary>The sso_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SsoUrl { get; set; }
#nullable restore
#else
        public string SsoUrl { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.EnterpriseSettings_enterprise_saml"/> and sets the default values.
        /// </summary>
        public EnterpriseSettings_enterprise_saml()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.EnterpriseSettings_enterprise_saml"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.EnterpriseSettings_enterprise_saml CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.EnterpriseSettings_enterprise_saml();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "certificate", n => { Certificate = n.GetStringValue(); } },
                { "certificate_path", n => { CertificatePath = n.GetStringValue(); } },
                { "disable_admin_demote", n => { DisableAdminDemote = n.GetBoolValue(); } },
                { "idp_initiated_sso", n => { IdpInitiatedSso = n.GetBoolValue(); } },
                { "issuer", n => { Issuer = n.GetStringValue(); } },
                { "sso_url", n => { SsoUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("certificate", Certificate);
            writer.WriteStringValue("certificate_path", CertificatePath);
            writer.WriteBoolValue("disable_admin_demote", DisableAdminDemote);
            writer.WriteBoolValue("idp_initiated_sso", IdpInitiatedSso);
            writer.WriteStringValue("issuer", Issuer);
            writer.WriteStringValue("sso_url", SsoUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
