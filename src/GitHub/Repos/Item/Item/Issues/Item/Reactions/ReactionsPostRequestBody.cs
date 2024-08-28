// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Repos.Item.Item.Issues.Item.Reactions
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class ReactionsPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The [reaction type](https://docs.github.com/enterprise-server@3.12/rest/reactions/reactions#about-reactions) to add to the issue.</summary>
        public global::GitHub.Repos.Item.Item.Issues.Item.Reactions.ReactionsPostRequestBody_content? Content { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Issues.Item.Reactions.ReactionsPostRequestBody"/> and sets the default values.
        /// </summary>
        public ReactionsPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Issues.Item.Reactions.ReactionsPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Repos.Item.Item.Issues.Item.Reactions.ReactionsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Repos.Item.Item.Issues.Item.Reactions.ReactionsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "content", n => { Content = n.GetEnumValue<global::GitHub.Repos.Item.Item.Issues.Item.Reactions.ReactionsPostRequestBody_content>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::GitHub.Repos.Item.Item.Issues.Item.Reactions.ReactionsPostRequestBody_content>("content", Content);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
