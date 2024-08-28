// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Repos.Item.Item.Pulls.Item.Reviews
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class ReviewsPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>**Required** when using `REQUEST_CHANGES` or `COMMENT` for the `event` parameter. The body text of the pull request review.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Body { get; set; }
#nullable restore
#else
        public string Body { get; set; }
#endif
        /// <summary>Use the following table to specify the location, destination, and contents of the draft review comment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::GitHub.Repos.Item.Item.Pulls.Item.Reviews.ReviewsPostRequestBody_comments>? Comments { get; set; }
#nullable restore
#else
        public List<global::GitHub.Repos.Item.Item.Pulls.Item.Reviews.ReviewsPostRequestBody_comments> Comments { get; set; }
#endif
        /// <summary>The SHA of the commit that needs a review. Not using the latest commit SHA may render your review comment outdated if a subsequent commit modifies the line you specify as the `position`. Defaults to the most recent commit in the pull request when you do not specify a value.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommitId { get; set; }
#nullable restore
#else
        public string CommitId { get; set; }
#endif
        /// <summary>The review action you want to perform. The review actions include: `APPROVE`, `REQUEST_CHANGES`, or `COMMENT`. By leaving this blank, you set the review action state to `PENDING`, which means you will need to [submit the pull request review](https://docs.github.com/enterprise-server@3.10/rest/pulls/reviews#submit-a-review-for-a-pull-request) when you are ready.</summary>
        public global::GitHub.Repos.Item.Item.Pulls.Item.Reviews.ReviewsPostRequestBody_event? Event { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Pulls.Item.Reviews.ReviewsPostRequestBody"/> and sets the default values.
        /// </summary>
        public ReviewsPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Pulls.Item.Reviews.ReviewsPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Repos.Item.Item.Pulls.Item.Reviews.ReviewsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Repos.Item.Item.Pulls.Item.Reviews.ReviewsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "body", n => { Body = n.GetStringValue(); } },
                { "comments", n => { Comments = n.GetCollectionOfObjectValues<global::GitHub.Repos.Item.Item.Pulls.Item.Reviews.ReviewsPostRequestBody_comments>(global::GitHub.Repos.Item.Item.Pulls.Item.Reviews.ReviewsPostRequestBody_comments.CreateFromDiscriminatorValue)?.AsList(); } },
                { "commit_id", n => { CommitId = n.GetStringValue(); } },
                { "event", n => { Event = n.GetEnumValue<global::GitHub.Repos.Item.Item.Pulls.Item.Reviews.ReviewsPostRequestBody_event>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("body", Body);
            writer.WriteCollectionOfObjectValues<global::GitHub.Repos.Item.Item.Pulls.Item.Reviews.ReviewsPostRequestBody_comments>("comments", Comments);
            writer.WriteStringValue("commit_id", CommitId);
            writer.WriteEnumValue<global::GitHub.Repos.Item.Item.Pulls.Item.Reviews.ReviewsPostRequestBody_event>("event", Event);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
