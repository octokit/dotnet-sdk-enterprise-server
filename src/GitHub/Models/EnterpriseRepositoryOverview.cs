// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class EnterpriseRepositoryOverview : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The fork_repos property</summary>
        public int? ForkRepos { get; set; }
        /// <summary>The org_repos property</summary>
        public int? OrgRepos { get; set; }
        /// <summary>The root_repos property</summary>
        public int? RootRepos { get; set; }
        /// <summary>The total_pushes property</summary>
        public int? TotalPushes { get; set; }
        /// <summary>The total_repos property</summary>
        public int? TotalRepos { get; set; }
        /// <summary>The total_wikis property</summary>
        public int? TotalWikis { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.EnterpriseRepositoryOverview"/> and sets the default values.
        /// </summary>
        public EnterpriseRepositoryOverview()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.EnterpriseRepositoryOverview"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.EnterpriseRepositoryOverview CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.EnterpriseRepositoryOverview();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "fork_repos", n => { ForkRepos = n.GetIntValue(); } },
                { "org_repos", n => { OrgRepos = n.GetIntValue(); } },
                { "root_repos", n => { RootRepos = n.GetIntValue(); } },
                { "total_pushes", n => { TotalPushes = n.GetIntValue(); } },
                { "total_repos", n => { TotalRepos = n.GetIntValue(); } },
                { "total_wikis", n => { TotalWikis = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("fork_repos", ForkRepos);
            writer.WriteIntValue("org_repos", OrgRepos);
            writer.WriteIntValue("root_repos", RootRepos);
            writer.WriteIntValue("total_pushes", TotalPushes);
            writer.WriteIntValue("total_repos", TotalRepos);
            writer.WriteIntValue("total_wikis", TotalWikis);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
