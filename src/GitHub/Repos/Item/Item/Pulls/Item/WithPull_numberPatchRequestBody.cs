// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Repos.Item.Item.Pulls.Item
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class WithPull_numberPatchRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The name of the branch you want your changes pulled into. This should be an existing branch on the current repository. You cannot update the base branch on a pull request to point to another repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Base { get; set; }
#nullable restore
#else
        public string Base { get; set; }
#endif
        /// <summary>The contents of the pull request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Body { get; set; }
#nullable restore
#else
        public string Body { get; set; }
#endif
        /// <summary>Indicates whether [maintainers can modify](https://docs.github.com/enterprise-server@3.11/articles/allowing-changes-to-a-pull-request-branch-created-from-a-fork/) the pull request.</summary>
        public bool? MaintainerCanModify { get; set; }
        /// <summary>State of this Pull Request. Either `open` or `closed`.</summary>
        public global::GitHub.Repos.Item.Item.Pulls.Item.WithPull_numberPatchRequestBody_state? State { get; set; }
        /// <summary>The title of the pull request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Pulls.Item.WithPull_numberPatchRequestBody"/> and sets the default values.
        /// </summary>
        public WithPull_numberPatchRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Pulls.Item.WithPull_numberPatchRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Repos.Item.Item.Pulls.Item.WithPull_numberPatchRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Repos.Item.Item.Pulls.Item.WithPull_numberPatchRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "base", n => { Base = n.GetStringValue(); } },
                { "body", n => { Body = n.GetStringValue(); } },
                { "maintainer_can_modify", n => { MaintainerCanModify = n.GetBoolValue(); } },
                { "state", n => { State = n.GetEnumValue<global::GitHub.Repos.Item.Item.Pulls.Item.WithPull_numberPatchRequestBody_state>(); } },
                { "title", n => { Title = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("base", Base);
            writer.WriteStringValue("body", Body);
            writer.WriteBoolValue("maintainer_can_modify", MaintainerCanModify);
            writer.WriteEnumValue<global::GitHub.Repos.Item.Item.Pulls.Item.WithPull_numberPatchRequestBody_state>("state", State);
            writer.WriteStringValue("title", Title);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
