// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    /// <summary>
    /// Feed
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class Feed : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The current_user_actor_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrentUserActorUrl { get; set; }
#nullable restore
#else
        public string CurrentUserActorUrl { get; set; }
#endif
        /// <summary>The current_user_organization_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrentUserOrganizationUrl { get; set; }
#nullable restore
#else
        public string CurrentUserOrganizationUrl { get; set; }
#endif
        /// <summary>The current_user_organization_urls property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? CurrentUserOrganizationUrls { get; set; }
#nullable restore
#else
        public List<string> CurrentUserOrganizationUrls { get; set; }
#endif
        /// <summary>The current_user_public_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrentUserPublicUrl { get; set; }
#nullable restore
#else
        public string CurrentUserPublicUrl { get; set; }
#endif
        /// <summary>The current_user_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrentUserUrl { get; set; }
#nullable restore
#else
        public string CurrentUserUrl { get; set; }
#endif
        /// <summary>The _links property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.Feed__links? Links { get; set; }
#nullable restore
#else
        public global::GitHub.Models.Feed__links Links { get; set; }
#endif
        /// <summary>A feed of discussions for a given repository and category.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RepositoryDiscussionsCategoryUrl { get; set; }
#nullable restore
#else
        public string RepositoryDiscussionsCategoryUrl { get; set; }
#endif
        /// <summary>A feed of discussions for a given repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RepositoryDiscussionsUrl { get; set; }
#nullable restore
#else
        public string RepositoryDiscussionsUrl { get; set; }
#endif
        /// <summary>The security_advisories_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SecurityAdvisoriesUrl { get; set; }
#nullable restore
#else
        public string SecurityAdvisoriesUrl { get; set; }
#endif
        /// <summary>The timeline_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TimelineUrl { get; set; }
#nullable restore
#else
        public string TimelineUrl { get; set; }
#endif
        /// <summary>The user_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserUrl { get; set; }
#nullable restore
#else
        public string UserUrl { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.Feed"/> and sets the default values.
        /// </summary>
        public Feed()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.Feed"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.Feed CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.Feed();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "current_user_actor_url", n => { CurrentUserActorUrl = n.GetStringValue(); } },
                { "current_user_organization_url", n => { CurrentUserOrganizationUrl = n.GetStringValue(); } },
                { "current_user_organization_urls", n => { CurrentUserOrganizationUrls = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "current_user_public_url", n => { CurrentUserPublicUrl = n.GetStringValue(); } },
                { "current_user_url", n => { CurrentUserUrl = n.GetStringValue(); } },
                { "_links", n => { Links = n.GetObjectValue<global::GitHub.Models.Feed__links>(global::GitHub.Models.Feed__links.CreateFromDiscriminatorValue); } },
                { "repository_discussions_category_url", n => { RepositoryDiscussionsCategoryUrl = n.GetStringValue(); } },
                { "repository_discussions_url", n => { RepositoryDiscussionsUrl = n.GetStringValue(); } },
                { "security_advisories_url", n => { SecurityAdvisoriesUrl = n.GetStringValue(); } },
                { "timeline_url", n => { TimelineUrl = n.GetStringValue(); } },
                { "user_url", n => { UserUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("current_user_actor_url", CurrentUserActorUrl);
            writer.WriteStringValue("current_user_organization_url", CurrentUserOrganizationUrl);
            writer.WriteCollectionOfPrimitiveValues<string>("current_user_organization_urls", CurrentUserOrganizationUrls);
            writer.WriteStringValue("current_user_public_url", CurrentUserPublicUrl);
            writer.WriteStringValue("current_user_url", CurrentUserUrl);
            writer.WriteObjectValue<global::GitHub.Models.Feed__links>("_links", Links);
            writer.WriteStringValue("repository_discussions_category_url", RepositoryDiscussionsCategoryUrl);
            writer.WriteStringValue("repository_discussions_url", RepositoryDiscussionsUrl);
            writer.WriteStringValue("security_advisories_url", SecurityAdvisoriesUrl);
            writer.WriteStringValue("timeline_url", TimelineUrl);
            writer.WriteStringValue("user_url", UserUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
