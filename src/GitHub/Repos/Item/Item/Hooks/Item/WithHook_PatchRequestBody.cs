// <auto-generated/>
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Repos.Item.Item.Hooks.Item
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class WithHook_PatchRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Determines if notifications are sent when the webhook is triggered. Set to `true` to send notifications.</summary>
        public bool? Active { get; set; }
        /// <summary>Determines a list of events to be added to the list of events that the Hook triggers for.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AddEvents { get; set; }
#nullable restore
#else
        public List<string> AddEvents { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Configuration object of the webhook</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.WebhookConfig? Config { get; set; }
#nullable restore
#else
        public global::GitHub.Models.WebhookConfig Config { get; set; }
#endif
        /// <summary>Determines what [events](https://docs.github.com/enterprise-server@3.13/webhooks/event-payloads) the hook is triggered for. This replaces the entire array of events.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Events { get; set; }
#nullable restore
#else
        public List<string> Events { get; set; }
#endif
        /// <summary>Determines a list of events to be removed from the list of events that the Hook triggers for.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RemoveEvents { get; set; }
#nullable restore
#else
        public List<string> RemoveEvents { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Hooks.Item.WithHook_PatchRequestBody"/> and sets the default values.
        /// </summary>
        public WithHook_PatchRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Hooks.Item.WithHook_PatchRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Repos.Item.Item.Hooks.Item.WithHook_PatchRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Repos.Item.Item.Hooks.Item.WithHook_PatchRequestBody();
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
                { "add_events", n => { AddEvents = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "config", n => { Config = n.GetObjectValue<global::GitHub.Models.WebhookConfig>(global::GitHub.Models.WebhookConfig.CreateFromDiscriminatorValue); } },
                { "events", n => { Events = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "remove_events", n => { RemoveEvents = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("add_events", AddEvents);
            writer.WriteObjectValue<global::GitHub.Models.WebhookConfig>("config", Config);
            writer.WriteCollectionOfPrimitiveValues<string>("events", Events);
            writer.WriteCollectionOfPrimitiveValues<string>("remove_events", RemoveEvents);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
