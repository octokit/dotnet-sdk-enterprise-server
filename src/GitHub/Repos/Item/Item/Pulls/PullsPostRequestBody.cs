// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Repos.Item.Item.Pulls {
    #pragma warning disable CS1591
    public class PullsPostRequestBody : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The name of the branch you want the changes pulled into. This should be an existing branch on the current repository. You cannot submit a pull request to one repository that requests a merge to a base of another repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Base { get; set; }
#nullable restore
#else
        public string Base { get; set; }
#endif
        /// <summary>The contents of the pull request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Body { get; set; }
#nullable restore
#else
        public string Body { get; set; }
#endif
        /// <summary>Indicates whether the pull request is a draft. See &quot;[Draft Pull Requests](https://docs.github.com/enterprise-server@3.13/articles/about-pull-requests#draft-pull-requests)&quot; in the GitHub Help documentation to learn more.</summary>
        public bool? Draft { get; set; }
        /// <summary>The name of the branch where your changes are implemented. For cross-repository pull requests in the same network, namespace `head` with a user like this: `username:branch`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Head { get; set; }
#nullable restore
#else
        public string Head { get; set; }
#endif
        /// <summary>The name of the repository where the changes in the pull request were made. This field is required for cross-repository pull requests if both repositories are owned by the same organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HeadRepo { get; set; }
#nullable restore
#else
        public string HeadRepo { get; set; }
#endif
        /// <summary>An issue in the repository to convert to a pull request. The issue title, body, and comments will become the title, body, and comments on the new pull request. Required unless `title` is specified.</summary>
        public long? Issue { get; set; }
        /// <summary>Indicates whether [maintainers can modify](https://docs.github.com/enterprise-server@3.13/articles/allowing-changes-to-a-pull-request-branch-created-from-a-fork/) the pull request.</summary>
        public bool? MaintainerCanModify { get; set; }
        /// <summary>The title of the new pull request. Required unless `issue` is specified.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="PullsPostRequestBody"/> and sets the default values.
        /// </summary>
        public PullsPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PullsPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PullsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PullsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"base", n => { Base = n.GetStringValue(); } },
                {"body", n => { Body = n.GetStringValue(); } },
                {"draft", n => { Draft = n.GetBoolValue(); } },
                {"head", n => { Head = n.GetStringValue(); } },
                {"head_repo", n => { HeadRepo = n.GetStringValue(); } },
                {"issue", n => { Issue = n.GetLongValue(); } },
                {"maintainer_can_modify", n => { MaintainerCanModify = n.GetBoolValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("base", Base);
            writer.WriteStringValue("body", Body);
            writer.WriteBoolValue("draft", Draft);
            writer.WriteStringValue("head", Head);
            writer.WriteStringValue("head_repo", HeadRepo);
            writer.WriteLongValue("issue", Issue);
            writer.WriteBoolValue("maintainer_can_modify", MaintainerCanModify);
            writer.WriteStringValue("title", Title);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
