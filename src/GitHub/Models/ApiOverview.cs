// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    /// <summary>
    /// Api Overview
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class ApiOverview : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The domains property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.ApiOverview_domains? Domains { get; set; }
#nullable restore
#else
        public global::GitHub.Models.ApiOverview_domains Domains { get; set; }
#endif
        /// <summary>The installed_version property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InstalledVersion { get; set; }
#nullable restore
#else
        public string InstalledVersion { get; set; }
#endif
        /// <summary>The packages property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Packages { get; set; }
#nullable restore
#else
        public List<string> Packages { get; set; }
#endif
        /// <summary>The verifiable_password_authentication property</summary>
        public bool? VerifiablePasswordAuthentication { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.ApiOverview"/> and sets the default values.
        /// </summary>
        public ApiOverview()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.ApiOverview"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.ApiOverview CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.ApiOverview();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "domains", n => { Domains = n.GetObjectValue<global::GitHub.Models.ApiOverview_domains>(global::GitHub.Models.ApiOverview_domains.CreateFromDiscriminatorValue); } },
                { "installed_version", n => { InstalledVersion = n.GetStringValue(); } },
                { "packages", n => { Packages = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "verifiable_password_authentication", n => { VerifiablePasswordAuthentication = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::GitHub.Models.ApiOverview_domains>("domains", Domains);
            writer.WriteStringValue("installed_version", InstalledVersion);
            writer.WriteCollectionOfPrimitiveValues<string>("packages", Packages);
            writer.WriteBoolValue("verifiable_password_authentication", VerifiablePasswordAuthentication);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
