// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Enterprises.Item.Actions.RunnerGroups.Item.Organizations
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class OrganizationsPutRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>List of organization IDs that can access the runner group.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? SelectedOrganizationIds { get; set; }
#nullable restore
#else
        public List<int?> SelectedOrganizationIds { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Enterprises.Item.Actions.RunnerGroups.Item.Organizations.OrganizationsPutRequestBody"/> and sets the default values.
        /// </summary>
        public OrganizationsPutRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Enterprises.Item.Actions.RunnerGroups.Item.Organizations.OrganizationsPutRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Enterprises.Item.Actions.RunnerGroups.Item.Organizations.OrganizationsPutRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Enterprises.Item.Actions.RunnerGroups.Item.Organizations.OrganizationsPutRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "selected_organization_ids", n => { SelectedOrganizationIds = n.GetCollectionOfPrimitiveValues<int?>()?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<int?>("selected_organization_ids", SelectedOrganizationIds);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
