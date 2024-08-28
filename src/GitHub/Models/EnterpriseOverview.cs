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
    public partial class EnterpriseOverview : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The comments property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.EnterpriseCommentOverview? Comments { get; set; }
#nullable restore
#else
        public global::GitHub.Models.EnterpriseCommentOverview Comments { get; set; }
#endif
        /// <summary>The gists property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.EnterpriseGistOverview? Gists { get; set; }
#nullable restore
#else
        public global::GitHub.Models.EnterpriseGistOverview Gists { get; set; }
#endif
        /// <summary>The hooks property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.EnterpriseHookOverview? Hooks { get; set; }
#nullable restore
#else
        public global::GitHub.Models.EnterpriseHookOverview Hooks { get; set; }
#endif
        /// <summary>The issues property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.EnterpriseIssueOverview? Issues { get; set; }
#nullable restore
#else
        public global::GitHub.Models.EnterpriseIssueOverview Issues { get; set; }
#endif
        /// <summary>The milestones property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.EnterpriseMilestoneOverview? Milestones { get; set; }
#nullable restore
#else
        public global::GitHub.Models.EnterpriseMilestoneOverview Milestones { get; set; }
#endif
        /// <summary>The orgs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.EnterpriseOrganizationOverview? Orgs { get; set; }
#nullable restore
#else
        public global::GitHub.Models.EnterpriseOrganizationOverview Orgs { get; set; }
#endif
        /// <summary>The pages property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.EnterprisePageOverview? Pages { get; set; }
#nullable restore
#else
        public global::GitHub.Models.EnterprisePageOverview Pages { get; set; }
#endif
        /// <summary>The pulls property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.EnterprisePullRequestOverview? Pulls { get; set; }
#nullable restore
#else
        public global::GitHub.Models.EnterprisePullRequestOverview Pulls { get; set; }
#endif
        /// <summary>The repos property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.EnterpriseRepositoryOverview? Repos { get; set; }
#nullable restore
#else
        public global::GitHub.Models.EnterpriseRepositoryOverview Repos { get; set; }
#endif
        /// <summary>The users property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.EnterpriseUserOverview? Users { get; set; }
#nullable restore
#else
        public global::GitHub.Models.EnterpriseUserOverview Users { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.EnterpriseOverview"/> and sets the default values.
        /// </summary>
        public EnterpriseOverview()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.EnterpriseOverview"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.EnterpriseOverview CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.EnterpriseOverview();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "comments", n => { Comments = n.GetObjectValue<global::GitHub.Models.EnterpriseCommentOverview>(global::GitHub.Models.EnterpriseCommentOverview.CreateFromDiscriminatorValue); } },
                { "gists", n => { Gists = n.GetObjectValue<global::GitHub.Models.EnterpriseGistOverview>(global::GitHub.Models.EnterpriseGistOverview.CreateFromDiscriminatorValue); } },
                { "hooks", n => { Hooks = n.GetObjectValue<global::GitHub.Models.EnterpriseHookOverview>(global::GitHub.Models.EnterpriseHookOverview.CreateFromDiscriminatorValue); } },
                { "issues", n => { Issues = n.GetObjectValue<global::GitHub.Models.EnterpriseIssueOverview>(global::GitHub.Models.EnterpriseIssueOverview.CreateFromDiscriminatorValue); } },
                { "milestones", n => { Milestones = n.GetObjectValue<global::GitHub.Models.EnterpriseMilestoneOverview>(global::GitHub.Models.EnterpriseMilestoneOverview.CreateFromDiscriminatorValue); } },
                { "orgs", n => { Orgs = n.GetObjectValue<global::GitHub.Models.EnterpriseOrganizationOverview>(global::GitHub.Models.EnterpriseOrganizationOverview.CreateFromDiscriminatorValue); } },
                { "pages", n => { Pages = n.GetObjectValue<global::GitHub.Models.EnterprisePageOverview>(global::GitHub.Models.EnterprisePageOverview.CreateFromDiscriminatorValue); } },
                { "pulls", n => { Pulls = n.GetObjectValue<global::GitHub.Models.EnterprisePullRequestOverview>(global::GitHub.Models.EnterprisePullRequestOverview.CreateFromDiscriminatorValue); } },
                { "repos", n => { Repos = n.GetObjectValue<global::GitHub.Models.EnterpriseRepositoryOverview>(global::GitHub.Models.EnterpriseRepositoryOverview.CreateFromDiscriminatorValue); } },
                { "users", n => { Users = n.GetObjectValue<global::GitHub.Models.EnterpriseUserOverview>(global::GitHub.Models.EnterpriseUserOverview.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::GitHub.Models.EnterpriseCommentOverview>("comments", Comments);
            writer.WriteObjectValue<global::GitHub.Models.EnterpriseGistOverview>("gists", Gists);
            writer.WriteObjectValue<global::GitHub.Models.EnterpriseHookOverview>("hooks", Hooks);
            writer.WriteObjectValue<global::GitHub.Models.EnterpriseIssueOverview>("issues", Issues);
            writer.WriteObjectValue<global::GitHub.Models.EnterpriseMilestoneOverview>("milestones", Milestones);
            writer.WriteObjectValue<global::GitHub.Models.EnterpriseOrganizationOverview>("orgs", Orgs);
            writer.WriteObjectValue<global::GitHub.Models.EnterprisePageOverview>("pages", Pages);
            writer.WriteObjectValue<global::GitHub.Models.EnterprisePullRequestOverview>("pulls", Pulls);
            writer.WriteObjectValue<global::GitHub.Models.EnterpriseRepositoryOverview>("repos", Repos);
            writer.WriteObjectValue<global::GitHub.Models.EnterpriseUserOverview>("users", Users);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
