// <auto-generated/>
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Enterprises.Item.Actions.Permissions.Organizations {
    #pragma warning disable CS1591
    public class OrganizationsGetResponse : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The organizations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OrganizationSimple>? Organizations { get; set; }
#nullable restore
#else
        public List<OrganizationSimple> Organizations { get; set; }
#endif
        /// <summary>The total_count property</summary>
        public double? TotalCount { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="OrganizationsGetResponse"/> and sets the default values.
        /// </summary>
        public OrganizationsGetResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="OrganizationsGetResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static OrganizationsGetResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OrganizationsGetResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"organizations", n => { Organizations = n.GetCollectionOfObjectValues<OrganizationSimple>(OrganizationSimple.CreateFromDiscriminatorValue)?.ToList(); } },
                {"total_count", n => { TotalCount = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<OrganizationSimple>("organizations", Organizations);
            writer.WriteDoubleValue("total_count", TotalCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
