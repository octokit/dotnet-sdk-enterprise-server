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
    public partial class ProtectedBranch_required_pull_request_reviews_bypass_pull_request_allowances : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The apps property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::GitHub.Models.Integration>? Apps { get; set; }
#nullable restore
#else
        public List<global::GitHub.Models.Integration> Apps { get; set; }
#endif
        /// <summary>The teams property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::GitHub.Models.Team>? Teams { get; set; }
#nullable restore
#else
        public List<global::GitHub.Models.Team> Teams { get; set; }
#endif
        /// <summary>The users property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::GitHub.Models.SimpleUser>? Users { get; set; }
#nullable restore
#else
        public List<global::GitHub.Models.SimpleUser> Users { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.ProtectedBranch_required_pull_request_reviews_bypass_pull_request_allowances"/> and sets the default values.
        /// </summary>
        public ProtectedBranch_required_pull_request_reviews_bypass_pull_request_allowances()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.ProtectedBranch_required_pull_request_reviews_bypass_pull_request_allowances"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.ProtectedBranch_required_pull_request_reviews_bypass_pull_request_allowances CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.ProtectedBranch_required_pull_request_reviews_bypass_pull_request_allowances();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "apps", n => { Apps = n.GetCollectionOfObjectValues<global::GitHub.Models.Integration>(global::GitHub.Models.Integration.CreateFromDiscriminatorValue)?.AsList(); } },
                { "teams", n => { Teams = n.GetCollectionOfObjectValues<global::GitHub.Models.Team>(global::GitHub.Models.Team.CreateFromDiscriminatorValue)?.AsList(); } },
                { "users", n => { Users = n.GetCollectionOfObjectValues<global::GitHub.Models.SimpleUser>(global::GitHub.Models.SimpleUser.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::GitHub.Models.Integration>("apps", Apps);
            writer.WriteCollectionOfObjectValues<global::GitHub.Models.Team>("teams", Teams);
            writer.WriteCollectionOfObjectValues<global::GitHub.Models.SimpleUser>("users", Users);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
