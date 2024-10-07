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
    public partial class ProtectedBranchPullRequestReview_dismissal_restrictions : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The list of apps with review dismissal access.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::GitHub.Models.Integration>? Apps { get; set; }
#nullable restore
#else
        public List<global::GitHub.Models.Integration> Apps { get; set; }
#endif
        /// <summary>The list of teams with review dismissal access.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::GitHub.Models.Team>? Teams { get; set; }
#nullable restore
#else
        public List<global::GitHub.Models.Team> Teams { get; set; }
#endif
        /// <summary>The teams_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TeamsUrl { get; set; }
#nullable restore
#else
        public string TeamsUrl { get; set; }
#endif
        /// <summary>The url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>The list of users with review dismissal access.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::GitHub.Models.SimpleUser>? Users { get; set; }
#nullable restore
#else
        public List<global::GitHub.Models.SimpleUser> Users { get; set; }
#endif
        /// <summary>The users_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UsersUrl { get; set; }
#nullable restore
#else
        public string UsersUrl { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.ProtectedBranchPullRequestReview_dismissal_restrictions"/> and sets the default values.
        /// </summary>
        public ProtectedBranchPullRequestReview_dismissal_restrictions()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.ProtectedBranchPullRequestReview_dismissal_restrictions"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.ProtectedBranchPullRequestReview_dismissal_restrictions CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.ProtectedBranchPullRequestReview_dismissal_restrictions();
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
                { "teams_url", n => { TeamsUrl = n.GetStringValue(); } },
                { "url", n => { Url = n.GetStringValue(); } },
                { "users", n => { Users = n.GetCollectionOfObjectValues<global::GitHub.Models.SimpleUser>(global::GitHub.Models.SimpleUser.CreateFromDiscriminatorValue)?.AsList(); } },
                { "users_url", n => { UsersUrl = n.GetStringValue(); } },
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
            writer.WriteStringValue("teams_url", TeamsUrl);
            writer.WriteStringValue("url", Url);
            writer.WriteCollectionOfObjectValues<global::GitHub.Models.SimpleUser>("users", Users);
            writer.WriteStringValue("users_url", UsersUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
