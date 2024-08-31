// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Orgs.Item.Hooks
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class HooksPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Determines if notifications are sent when the webhook is triggered. Set to `true` to send notifications.</summary>
        public bool? Active { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Key/value pairs to provide settings for this webhook.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Orgs.Item.Hooks.HooksPostRequestBody_config? Config { get; set; }
#nullable restore
#else
        public global::GitHub.Orgs.Item.Hooks.HooksPostRequestBody_config Config { get; set; }
#endif
        /// <summary>Determines what [events](https://docs.github.com/enterprise-server@3.13/webhooks/event-payloads) the hook is triggered for. Set to `[&quot;*&quot;]` to receive all possible events.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Events { get; set; }
#nullable restore
#else
        public List<string> Events { get; set; }
#endif
        /// <summary>Must be passed as &quot;web&quot;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.Hooks.HooksPostRequestBody"/> and sets the default values.
        /// </summary>
        public HooksPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Orgs.Item.Hooks.HooksPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Orgs.Item.Hooks.HooksPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Orgs.Item.Hooks.HooksPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "active", n => { Active = n.GetBoolValue(); } },
                { "config", n => { Config = n.GetObjectValue<global::GitHub.Orgs.Item.Hooks.HooksPostRequestBody_config>(global::GitHub.Orgs.Item.Hooks.HooksPostRequestBody_config.CreateFromDiscriminatorValue); } },
                { "events", n => { Events = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "name", n => { Name = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("active", Active);
            writer.WriteObjectValue<global::GitHub.Orgs.Item.Hooks.HooksPostRequestBody_config>("config", Config);
            writer.WriteCollectionOfPrimitiveValues<string>("events", Events);
            writer.WriteStringValue("name", Name);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
