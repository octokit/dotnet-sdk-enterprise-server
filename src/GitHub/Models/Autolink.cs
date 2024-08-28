// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    /// <summary>
    /// An autolink reference.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class Autolink : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The id property</summary>
        public int? Id { get; set; }
        /// <summary>Whether this autolink reference matches alphanumeric characters. If false, this autolink reference only matches numeric characters.</summary>
        public bool? IsAlphanumeric { get; set; }
        /// <summary>The prefix of a key that is linkified.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? KeyPrefix { get; set; }
#nullable restore
#else
        public string KeyPrefix { get; set; }
#endif
        /// <summary>A template for the target URL that is generated if a key was found.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UrlTemplate { get; set; }
#nullable restore
#else
        public string UrlTemplate { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.Autolink"/> and sets the default values.
        /// </summary>
        public Autolink()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.Autolink"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.Autolink CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.Autolink();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "id", n => { Id = n.GetIntValue(); } },
                { "is_alphanumeric", n => { IsAlphanumeric = n.GetBoolValue(); } },
                { "key_prefix", n => { KeyPrefix = n.GetStringValue(); } },
                { "url_template", n => { UrlTemplate = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("id", Id);
            writer.WriteBoolValue("is_alphanumeric", IsAlphanumeric);
            writer.WriteStringValue("key_prefix", KeyPrefix);
            writer.WriteStringValue("url_template", UrlTemplate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
