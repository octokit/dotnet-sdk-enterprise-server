// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class GhesConfigNodes_nodes : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The cluster_roles property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::GitHub.Models.GhesClusterRoles?>? ClusterRoles { get; set; }
#nullable restore
#else
        public List<global::GitHub.Models.GhesClusterRoles?> ClusterRoles { get; set; }
#endif
        /// <summary>The hostname property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Hostname { get; set; }
#nullable restore
#else
        public string Hostname { get; set; }
#endif
        /// <summary>The replica property</summary>
        public bool? Replica { get; set; }
        /// <summary>The uuid property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Uuid { get; set; }
#nullable restore
#else
        public string Uuid { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.GhesConfigNodes_nodes"/> and sets the default values.
        /// </summary>
        public GhesConfigNodes_nodes()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.GhesConfigNodes_nodes"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.GhesConfigNodes_nodes CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.GhesConfigNodes_nodes();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "cluster_roles", n => { ClusterRoles = n.GetCollectionOfEnumValues<global::GitHub.Models.GhesClusterRoles>()?.AsList(); } },
                { "hostname", n => { Hostname = n.GetStringValue(); } },
                { "replica", n => { Replica = n.GetBoolValue(); } },
                { "uuid", n => { Uuid = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfEnumValues<global::GitHub.Models.GhesClusterRoles>("cluster_roles", ClusterRoles);
            writer.WriteStringValue("hostname", Hostname);
            writer.WriteBoolValue("replica", Replica);
            writer.WriteStringValue("uuid", Uuid);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
