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
    /// Issue Search Result Item
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class IssueSearchResultItem : IAdditionalDataHolder, IParsable
    {
        /// <summary>The active_lock_reason property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActiveLockReason { get; set; }
#nullable restore
#else
        public string ActiveLockReason { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.NullableSimpleUser? Assignee { get; set; }
#nullable restore
#else
        public global::GitHub.Models.NullableSimpleUser Assignee { get; set; }
#endif
        /// <summary>The assignees property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::GitHub.Models.SimpleUser>? Assignees { get; set; }
#nullable restore
#else
        public List<global::GitHub.Models.SimpleUser> Assignees { get; set; }
#endif
        /// <summary>How the author is associated with the repository.</summary>
        public global::GitHub.Models.AuthorAssociation? AuthorAssociation { get; set; }
        /// <summary>The body property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Body { get; set; }
#nullable restore
#else
        public string Body { get; set; }
#endif
        /// <summary>The body_html property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BodyHtml { get; set; }
#nullable restore
#else
        public string BodyHtml { get; set; }
#endif
        /// <summary>The body_text property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BodyText { get; set; }
#nullable restore
#else
        public string BodyText { get; set; }
#endif
        /// <summary>The closed_at property</summary>
        public DateTimeOffset? ClosedAt { get; set; }
        /// <summary>The comments property</summary>
        public int? Comments { get; set; }
        /// <summary>The comments_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommentsUrl { get; set; }
#nullable restore
#else
        public string CommentsUrl { get; set; }
#endif
        /// <summary>The created_at property</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The draft property</summary>
        public bool? Draft { get; set; }
        /// <summary>The events_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EventsUrl { get; set; }
#nullable restore
#else
        public string EventsUrl { get; set; }
#endif
        /// <summary>The html_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HtmlUrl { get; set; }
#nullable restore
#else
        public string HtmlUrl { get; set; }
#endif
        /// <summary>The id property</summary>
        public long? Id { get; set; }
        /// <summary>The labels property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::GitHub.Models.IssueSearchResultItem_labels>? Labels { get; set; }
#nullable restore
#else
        public List<global::GitHub.Models.IssueSearchResultItem_labels> Labels { get; set; }
#endif
        /// <summary>The labels_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LabelsUrl { get; set; }
#nullable restore
#else
        public string LabelsUrl { get; set; }
#endif
        /// <summary>The locked property</summary>
        public bool? Locked { get; set; }
        /// <summary>A collection of related issues and pull requests.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.NullableMilestone? Milestone { get; set; }
#nullable restore
#else
        public global::GitHub.Models.NullableMilestone Milestone { get; set; }
#endif
        /// <summary>The node_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NodeId { get; set; }
#nullable restore
#else
        public string NodeId { get; set; }
#endif
        /// <summary>The number property</summary>
        public int? Number { get; set; }
        /// <summary>GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.NullableIntegration? PerformedViaGithubApp { get; set; }
#nullable restore
#else
        public global::GitHub.Models.NullableIntegration PerformedViaGithubApp { get; set; }
#endif
        /// <summary>The pull_request property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.IssueSearchResultItem_pull_request? PullRequest { get; set; }
#nullable restore
#else
        public global::GitHub.Models.IssueSearchResultItem_pull_request PullRequest { get; set; }
#endif
        /// <summary>The reactions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.ReactionRollup? Reactions { get; set; }
#nullable restore
#else
        public global::GitHub.Models.ReactionRollup Reactions { get; set; }
#endif
        /// <summary>A repository on GitHub.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.Repository? Repository { get; set; }
#nullable restore
#else
        public global::GitHub.Models.Repository Repository { get; set; }
#endif
        /// <summary>The repository_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RepositoryUrl { get; set; }
#nullable restore
#else
        public string RepositoryUrl { get; set; }
#endif
        /// <summary>The score property</summary>
        public double? Score { get; set; }
        /// <summary>The state property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? State { get; set; }
#nullable restore
#else
        public string State { get; set; }
#endif
        /// <summary>The state_reason property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StateReason { get; set; }
#nullable restore
#else
        public string StateReason { get; set; }
#endif
        /// <summary>The text_matches property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::GitHub.Models.Issues>? TextMatches { get; set; }
#nullable restore
#else
        public List<global::GitHub.Models.Issues> TextMatches { get; set; }
#endif
        /// <summary>The timeline_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TimelineUrl { get; set; }
#nullable restore
#else
        public string TimelineUrl { get; set; }
#endif
        /// <summary>The title property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>The updated_at property</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>The url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.NullableSimpleUser? User { get; set; }
#nullable restore
#else
        public global::GitHub.Models.NullableSimpleUser User { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.IssueSearchResultItem"/> and sets the default values.
        /// </summary>
        public IssueSearchResultItem()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.IssueSearchResultItem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.IssueSearchResultItem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.IssueSearchResultItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "active_lock_reason", n => { ActiveLockReason = n.GetStringValue(); } },
                { "assignee", n => { Assignee = n.GetObjectValue<global::GitHub.Models.NullableSimpleUser>(global::GitHub.Models.NullableSimpleUser.CreateFromDiscriminatorValue); } },
                { "assignees", n => { Assignees = n.GetCollectionOfObjectValues<global::GitHub.Models.SimpleUser>(global::GitHub.Models.SimpleUser.CreateFromDiscriminatorValue)?.AsList(); } },
                { "author_association", n => { AuthorAssociation = n.GetEnumValue<global::GitHub.Models.AuthorAssociation>(); } },
                { "body", n => { Body = n.GetStringValue(); } },
                { "body_html", n => { BodyHtml = n.GetStringValue(); } },
                { "body_text", n => { BodyText = n.GetStringValue(); } },
                { "closed_at", n => { ClosedAt = n.GetDateTimeOffsetValue(); } },
                { "comments", n => { Comments = n.GetIntValue(); } },
                { "comments_url", n => { CommentsUrl = n.GetStringValue(); } },
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "draft", n => { Draft = n.GetBoolValue(); } },
                { "events_url", n => { EventsUrl = n.GetStringValue(); } },
                { "html_url", n => { HtmlUrl = n.GetStringValue(); } },
                { "id", n => { Id = n.GetLongValue(); } },
                { "labels", n => { Labels = n.GetCollectionOfObjectValues<global::GitHub.Models.IssueSearchResultItem_labels>(global::GitHub.Models.IssueSearchResultItem_labels.CreateFromDiscriminatorValue)?.AsList(); } },
                { "labels_url", n => { LabelsUrl = n.GetStringValue(); } },
                { "locked", n => { Locked = n.GetBoolValue(); } },
                { "milestone", n => { Milestone = n.GetObjectValue<global::GitHub.Models.NullableMilestone>(global::GitHub.Models.NullableMilestone.CreateFromDiscriminatorValue); } },
                { "node_id", n => { NodeId = n.GetStringValue(); } },
                { "number", n => { Number = n.GetIntValue(); } },
                { "performed_via_github_app", n => { PerformedViaGithubApp = n.GetObjectValue<global::GitHub.Models.NullableIntegration>(global::GitHub.Models.NullableIntegration.CreateFromDiscriminatorValue); } },
                { "pull_request", n => { PullRequest = n.GetObjectValue<global::GitHub.Models.IssueSearchResultItem_pull_request>(global::GitHub.Models.IssueSearchResultItem_pull_request.CreateFromDiscriminatorValue); } },
                { "reactions", n => { Reactions = n.GetObjectValue<global::GitHub.Models.ReactionRollup>(global::GitHub.Models.ReactionRollup.CreateFromDiscriminatorValue); } },
                { "repository", n => { Repository = n.GetObjectValue<global::GitHub.Models.Repository>(global::GitHub.Models.Repository.CreateFromDiscriminatorValue); } },
                { "repository_url", n => { RepositoryUrl = n.GetStringValue(); } },
                { "score", n => { Score = n.GetDoubleValue(); } },
                { "state", n => { State = n.GetStringValue(); } },
                { "state_reason", n => { StateReason = n.GetStringValue(); } },
                { "text_matches", n => { TextMatches = n.GetCollectionOfObjectValues<global::GitHub.Models.Issues>(global::GitHub.Models.Issues.CreateFromDiscriminatorValue)?.AsList(); } },
                { "timeline_url", n => { TimelineUrl = n.GetStringValue(); } },
                { "title", n => { Title = n.GetStringValue(); } },
                { "updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                { "url", n => { Url = n.GetStringValue(); } },
                { "user", n => { User = n.GetObjectValue<global::GitHub.Models.NullableSimpleUser>(global::GitHub.Models.NullableSimpleUser.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("active_lock_reason", ActiveLockReason);
            writer.WriteObjectValue<global::GitHub.Models.NullableSimpleUser>("assignee", Assignee);
            writer.WriteCollectionOfObjectValues<global::GitHub.Models.SimpleUser>("assignees", Assignees);
            writer.WriteEnumValue<global::GitHub.Models.AuthorAssociation>("author_association", AuthorAssociation);
            writer.WriteStringValue("body", Body);
            writer.WriteStringValue("body_html", BodyHtml);
            writer.WriteStringValue("body_text", BodyText);
            writer.WriteDateTimeOffsetValue("closed_at", ClosedAt);
            writer.WriteIntValue("comments", Comments);
            writer.WriteStringValue("comments_url", CommentsUrl);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteBoolValue("draft", Draft);
            writer.WriteStringValue("events_url", EventsUrl);
            writer.WriteStringValue("html_url", HtmlUrl);
            writer.WriteLongValue("id", Id);
            writer.WriteCollectionOfObjectValues<global::GitHub.Models.IssueSearchResultItem_labels>("labels", Labels);
            writer.WriteStringValue("labels_url", LabelsUrl);
            writer.WriteBoolValue("locked", Locked);
            writer.WriteObjectValue<global::GitHub.Models.NullableMilestone>("milestone", Milestone);
            writer.WriteStringValue("node_id", NodeId);
            writer.WriteIntValue("number", Number);
            writer.WriteObjectValue<global::GitHub.Models.NullableIntegration>("performed_via_github_app", PerformedViaGithubApp);
            writer.WriteObjectValue<global::GitHub.Models.IssueSearchResultItem_pull_request>("pull_request", PullRequest);
            writer.WriteObjectValue<global::GitHub.Models.ReactionRollup>("reactions", Reactions);
            writer.WriteObjectValue<global::GitHub.Models.Repository>("repository", Repository);
            writer.WriteStringValue("repository_url", RepositoryUrl);
            writer.WriteDoubleValue("score", Score);
            writer.WriteStringValue("state", State);
            writer.WriteStringValue("state_reason", StateReason);
            writer.WriteCollectionOfObjectValues<global::GitHub.Models.Issues>("text_matches", TextMatches);
            writer.WriteStringValue("timeline_url", TimelineUrl);
            writer.WriteStringValue("title", Title);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteStringValue("url", Url);
            writer.WriteObjectValue<global::GitHub.Models.NullableSimpleUser>("user", User);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
