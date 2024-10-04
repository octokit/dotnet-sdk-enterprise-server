// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Repos.Item.Item.Git.Tags
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class TagsPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The tag message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message { get; set; }
#nullable restore
#else
        public string Message { get; set; }
#endif
        /// <summary>The SHA of the git object this is tagging.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Object { get; set; }
#nullable restore
#else
        public string Object { get; set; }
#endif
        /// <summary>The tag&apos;s name. This is typically a version (e.g., &quot;v0.0.1&quot;).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Tag { get; set; }
#nullable restore
#else
        public string Tag { get; set; }
#endif
        /// <summary>An object with information about the individual creating the tag.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Repos.Item.Item.Git.Tags.TagsPostRequestBody_tagger? Tagger { get; set; }
#nullable restore
#else
        public global::GitHub.Repos.Item.Item.Git.Tags.TagsPostRequestBody_tagger Tagger { get; set; }
#endif
        /// <summary>The type of the object we&apos;re tagging. Normally this is a `commit` but it can also be a `tree` or a `blob`.</summary>
        public global::GitHub.Repos.Item.Item.Git.Tags.TagsPostRequestBody_type? Type { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Git.Tags.TagsPostRequestBody"/> and sets the default values.
        /// </summary>
        public TagsPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Git.Tags.TagsPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Repos.Item.Item.Git.Tags.TagsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Repos.Item.Item.Git.Tags.TagsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "message", n => { Message = n.GetStringValue(); } },
                { "object", n => { Object = n.GetStringValue(); } },
                { "tag", n => { Tag = n.GetStringValue(); } },
                { "tagger", n => { Tagger = n.GetObjectValue<global::GitHub.Repos.Item.Item.Git.Tags.TagsPostRequestBody_tagger>(global::GitHub.Repos.Item.Item.Git.Tags.TagsPostRequestBody_tagger.CreateFromDiscriminatorValue); } },
                { "type", n => { Type = n.GetEnumValue<global::GitHub.Repos.Item.Item.Git.Tags.TagsPostRequestBody_type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("message", Message);
            writer.WriteStringValue("object", Object);
            writer.WriteStringValue("tag", Tag);
            writer.WriteObjectValue<global::GitHub.Repos.Item.Item.Git.Tags.TagsPostRequestBody_tagger>("tagger", Tagger);
            writer.WriteEnumValue<global::GitHub.Repos.Item.Item.Git.Tags.TagsPostRequestBody_type>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
