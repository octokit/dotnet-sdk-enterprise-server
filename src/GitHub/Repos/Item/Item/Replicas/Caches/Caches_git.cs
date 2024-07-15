// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Repos.Item.Item.Replicas.Caches {
    #pragma warning disable CS1591
    public class Caches_git : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The last_sync property</summary>
        public DateTimeOffset? LastSync { get; set; }
        /// <summary>The sync_status property</summary>
        public Caches_git_sync_status? SyncStatus { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="Caches_git"/> and sets the default values.
        /// </summary>
        public Caches_git()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Caches_git"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Caches_git CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Caches_git();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"last_sync", n => { LastSync = n.GetDateTimeOffsetValue(); } },
                {"sync_status", n => { SyncStatus = n.GetEnumValue<Caches_git_sync_status>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("last_sync", LastSync);
            writer.WriteEnumValue<Caches_git_sync_status>("sync_status", SyncStatus);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
