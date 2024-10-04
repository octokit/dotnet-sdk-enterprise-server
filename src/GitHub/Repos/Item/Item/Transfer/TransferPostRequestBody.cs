// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Repos.Item.Item.Transfer
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class TransferPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The new name to be given to the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NewName { get; set; }
#nullable restore
#else
        public string NewName { get; set; }
#endif
        /// <summary>The username or organization name the repository will be transferred to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NewOwner { get; set; }
#nullable restore
#else
        public string NewOwner { get; set; }
#endif
        /// <summary>ID of the team or teams to add to the repository. Teams can only be added to organization-owned repositories.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? TeamIds { get; set; }
#nullable restore
#else
        public List<int?> TeamIds { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Transfer.TransferPostRequestBody"/> and sets the default values.
        /// </summary>
        public TransferPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Transfer.TransferPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Repos.Item.Item.Transfer.TransferPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Repos.Item.Item.Transfer.TransferPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "new_name", n => { NewName = n.GetStringValue(); } },
                { "new_owner", n => { NewOwner = n.GetStringValue(); } },
                { "team_ids", n => { TeamIds = n.GetCollectionOfPrimitiveValues<int?>()?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("new_name", NewName);
            writer.WriteStringValue("new_owner", NewOwner);
            writer.WriteCollectionOfPrimitiveValues<int?>("team_ids", TeamIds);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
