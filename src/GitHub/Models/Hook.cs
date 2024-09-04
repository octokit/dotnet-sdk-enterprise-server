// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    /// <summary>
    /// Webhooks for repositories.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class Hook : IAdditionalDataHolder, IParsable
    {
        /// <summary>Determines whether the hook is actually triggered on pushes.</summary>
        public bool? Active { get; set; }
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
        /// <summary>The created_at property</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The deliveries_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeliveriesUrl { get; set; }
#nullable restore
#else
        public string DeliveriesUrl { get; set; }
#endif
        /// <summary>Determines what events the hook is triggered for. Default: [&apos;push&apos;].</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Events { get; set; }
#nullable restore
#else
        public List<string> Events { get; set; }
#endif
        /// <summary>Unique identifier of the webhook.</summary>
        public int? Id { get; set; }
        /// <summary>The last_response property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.HookResponse? LastResponse { get; set; }
#nullable restore
#else
        public global::GitHub.Models.HookResponse LastResponse { get; set; }
#endif
        /// <summary>The name of a valid service, use &apos;web&apos; for a webhook.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The ping_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PingUrl { get; set; }
#nullable restore
#else
        public string PingUrl { get; set; }
#endif
        /// <summary>The test_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TestUrl { get; set; }
#nullable restore
#else
        public string TestUrl { get; set; }
#endif
        /// <summary>The type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>The updated_at property</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>The url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.Hook"/> and sets the default values.
        /// </summary>
        public Hook()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.Hook"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.Hook CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.Hook();
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
                { "config", n => { Config = n.GetObjectValue<global::GitHub.Models.WebhookConfig>(global::GitHub.Models.WebhookConfig.CreateFromDiscriminatorValue); } },
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "deliveries_url", n => { DeliveriesUrl = n.GetStringValue(); } },
                { "events", n => { Events = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "id", n => { Id = n.GetIntValue(); } },
                { "last_response", n => { LastResponse = n.GetObjectValue<global::GitHub.Models.HookResponse>(global::GitHub.Models.HookResponse.CreateFromDiscriminatorValue); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "ping_url", n => { PingUrl = n.GetStringValue(); } },
                { "test_url", n => { TestUrl = n.GetStringValue(); } },
                { "type", n => { Type = n.GetStringValue(); } },
                { "updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                { "url", n => { Url = n.GetStringValue(); } },
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
            writer.WriteObjectValue<global::GitHub.Models.WebhookConfig>("config", Config);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteStringValue("deliveries_url", DeliveriesUrl);
            writer.WriteCollectionOfPrimitiveValues<string>("events", Events);
            writer.WriteIntValue("id", Id);
            writer.WriteObjectValue<global::GitHub.Models.HookResponse>("last_response", LastResponse);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("ping_url", PingUrl);
            writer.WriteStringValue("test_url", TestUrl);
            writer.WriteStringValue("type", Type);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
