// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Repos.Item.Item.Hooks.Item.Config
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class ConfigPatchRequestBody : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The media type used to serialize the payloads. Supported values include `json` and `form`. The default is `form`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentType { get; set; }
#nullable restore
#else
        public string ContentType { get; set; }
#endif
        /// <summary>The insecure_ssl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.WebhookConfigInsecureSsl? InsecureSsl { get; set; }
#nullable restore
#else
        public global::GitHub.Models.WebhookConfigInsecureSsl InsecureSsl { get; set; }
#endif
        /// <summary>If provided, the `secret` will be used as the `key` to generate the HMAC hex digest value for [delivery signature headers](https://docs.github.com/enterprise-server@3.12/webhooks/event-payloads/#delivery-headers).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Secret { get; set; }
#nullable restore
#else
        public string Secret { get; set; }
#endif
        /// <summary>The URL to which the payloads will be delivered.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Hooks.Item.Config.ConfigPatchRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Repos.Item.Item.Hooks.Item.Config.ConfigPatchRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Repos.Item.Item.Hooks.Item.Config.ConfigPatchRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "content_type", n => { ContentType = n.GetStringValue(); } },
                { "insecure_ssl", n => { InsecureSsl = n.GetObjectValue<global::GitHub.Models.WebhookConfigInsecureSsl>(global::GitHub.Models.WebhookConfigInsecureSsl.CreateFromDiscriminatorValue); } },
                { "secret", n => { Secret = n.GetStringValue(); } },
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
            writer.WriteStringValue("content_type", ContentType);
            writer.WriteObjectValue<global::GitHub.Models.WebhookConfigInsecureSsl>("insecure_ssl", InsecureSsl);
            writer.WriteStringValue("secret", Secret);
            writer.WriteStringValue("url", Url);
        }
    }
}
#pragma warning restore CS0618
