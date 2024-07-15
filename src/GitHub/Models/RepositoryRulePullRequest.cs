// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    /// <summary>
    /// Require all commits be made to a non-target branch and submitted via a pull request before they can be merged.
    /// </summary>
    public class RepositoryRulePullRequest : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The parameters property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RepositoryRulePullRequest_parameters? Parameters { get; set; }
#nullable restore
#else
        public RepositoryRulePullRequest_parameters Parameters { get; set; }
#endif
        /// <summary>The type property</summary>
        public RepositoryRulePullRequest_type? Type { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="RepositoryRulePullRequest"/> and sets the default values.
        /// </summary>
        public RepositoryRulePullRequest()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="RepositoryRulePullRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RepositoryRulePullRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RepositoryRulePullRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"parameters", n => { Parameters = n.GetObjectValue<RepositoryRulePullRequest_parameters>(RepositoryRulePullRequest_parameters.CreateFromDiscriminatorValue); } },
                {"type", n => { Type = n.GetEnumValue<RepositoryRulePullRequest_type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<RepositoryRulePullRequest_parameters>("parameters", Parameters);
            writer.WriteEnumValue<RepositoryRulePullRequest_type>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
