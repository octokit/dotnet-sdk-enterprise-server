// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    /// <summary>
    /// Scim Error
    /// </summary>
    public class ScimError : ApiException, IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The detail property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Detail { get; set; }
#nullable restore
#else
        public string Detail { get; set; }
#endif
        /// <summary>The documentation_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DocumentationUrl { get; set; }
#nullable restore
#else
        public string DocumentationUrl { get; set; }
#endif
        /// <summary>The message property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MessageEscaped { get; set; }
#nullable restore
#else
        public string MessageEscaped { get; set; }
#endif
        /// <summary>The schemas property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Schemas { get; set; }
#nullable restore
#else
        public List<string> Schemas { get; set; }
#endif
        /// <summary>The scimType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ScimType { get; set; }
#nullable restore
#else
        public string ScimType { get; set; }
#endif
        /// <summary>The status property</summary>
        public int? Status { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="ScimError"/> and sets the default values.
        /// </summary>
        public ScimError()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ScimError"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ScimError CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ScimError();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"detail", n => { Detail = n.GetStringValue(); } },
                {"documentation_url", n => { DocumentationUrl = n.GetStringValue(); } },
                {"message", n => { MessageEscaped = n.GetStringValue(); } },
                {"schemas", n => { Schemas = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"scimType", n => { ScimType = n.GetStringValue(); } },
                {"status", n => { Status = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("detail", Detail);
            writer.WriteStringValue("documentation_url", DocumentationUrl);
            writer.WriteStringValue("message", MessageEscaped);
            writer.WriteCollectionOfPrimitiveValues<string>("schemas", Schemas);
            writer.WriteStringValue("scimType", ScimType);
            writer.WriteIntValue("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
