// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Setup.Api.Start
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class StartPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The content of your _.ghl_ license file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? License { get; set; }
#nullable restore
#else
        public string License { get; set; }
#endif
        /// <summary>You **must** provide a password _only if_ you are uploading your license for the first time. If you previously set a password through the web interface, you don&apos;t need this parameter.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Password { get; set; }
#nullable restore
#else
        public string Password { get; set; }
#endif
        /// <summary>An optional JSON string containing the installation settings. For a list of the available settings, see the [Get settings endpoint](https://docs.github.com/enterprise-server@3.10/rest/enterprise-admin/management-console#get-settings).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Settings { get; set; }
#nullable restore
#else
        public string Settings { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Setup.Api.Start.StartPostRequestBody"/> and sets the default values.
        /// </summary>
        public StartPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Setup.Api.Start.StartPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Setup.Api.Start.StartPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Setup.Api.Start.StartPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "license", n => { License = n.GetStringValue(); } },
                { "password", n => { Password = n.GetStringValue(); } },
                { "settings", n => { Settings = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("license", License);
            writer.WriteStringValue("password", Password);
            writer.WriteStringValue("settings", Settings);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
