// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Repos.Item.Item.Generate {
    #pragma warning disable CS1591
    public class GeneratePostRequestBody : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A short description of the new repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Set to `true` to include the directory structure and files from all branches in the template repository, and not just the default branch. Default: `false`.</summary>
        public bool? IncludeAllBranches { get; set; }
        /// <summary>The name of the new repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The organization or person who will own the new repository. To create a new repository in an organization, the authenticated user must be a member of the specified organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Owner { get; set; }
#nullable restore
#else
        public string Owner { get; set; }
#endif
        /// <summary>Either `true` to create a new private repository or `false` to create a new public one.</summary>
        public bool? Private { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="GeneratePostRequestBody"/> and sets the default values.
        /// </summary>
        public GeneratePostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="GeneratePostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static GeneratePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GeneratePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"description", n => { Description = n.GetStringValue(); } },
                {"include_all_branches", n => { IncludeAllBranches = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"owner", n => { Owner = n.GetStringValue(); } },
                {"private", n => { Private = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteBoolValue("include_all_branches", IncludeAllBranches);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("owner", Owner);
            writer.WriteBoolValue("private", Private);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
