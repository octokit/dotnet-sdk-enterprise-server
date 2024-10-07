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
    /// A collection of related issues and pull requests.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class Milestone : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The closed_at property</summary>
        public DateTimeOffset? ClosedAt { get; set; }
        /// <summary>The closed_issues property</summary>
        public int? ClosedIssues { get; set; }
        /// <summary>The created_at property</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.NullableSimpleUser? Creator { get; set; }
#nullable restore
#else
        public global::GitHub.Models.NullableSimpleUser Creator { get; set; }
#endif
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The due_on property</summary>
        public DateTimeOffset? DueOn { get; set; }
        /// <summary>The html_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HtmlUrl { get; set; }
#nullable restore
#else
        public string HtmlUrl { get; set; }
#endif
        /// <summary>The id property</summary>
        public int? Id { get; set; }
        /// <summary>The labels_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LabelsUrl { get; set; }
#nullable restore
#else
        public string LabelsUrl { get; set; }
#endif
        /// <summary>The node_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NodeId { get; set; }
#nullable restore
#else
        public string NodeId { get; set; }
#endif
        /// <summary>The number of the milestone.</summary>
        public int? Number { get; set; }
        /// <summary>The open_issues property</summary>
        public int? OpenIssues { get; set; }
        /// <summary>The state of the milestone.</summary>
        public global::GitHub.Models.Milestone_state? State { get; set; }
        /// <summary>The title of the milestone.</summary>
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
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.Milestone"/> and sets the default values.
        /// </summary>
        public Milestone()
        {
            AdditionalData = new Dictionary<string, object>();
            State = global::GitHub.Models.Milestone_state.Open;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.Milestone"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.Milestone CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.Milestone();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "closed_at", n => { ClosedAt = n.GetDateTimeOffsetValue(); } },
                { "closed_issues", n => { ClosedIssues = n.GetIntValue(); } },
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "creator", n => { Creator = n.GetObjectValue<global::GitHub.Models.NullableSimpleUser>(global::GitHub.Models.NullableSimpleUser.CreateFromDiscriminatorValue); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "due_on", n => { DueOn = n.GetDateTimeOffsetValue(); } },
                { "html_url", n => { HtmlUrl = n.GetStringValue(); } },
                { "id", n => { Id = n.GetIntValue(); } },
                { "labels_url", n => { LabelsUrl = n.GetStringValue(); } },
                { "node_id", n => { NodeId = n.GetStringValue(); } },
                { "number", n => { Number = n.GetIntValue(); } },
                { "open_issues", n => { OpenIssues = n.GetIntValue(); } },
                { "state", n => { State = n.GetEnumValue<global::GitHub.Models.Milestone_state>(); } },
                { "title", n => { Title = n.GetStringValue(); } },
                { "updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                { "url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("closed_at", ClosedAt);
            writer.WriteIntValue("closed_issues", ClosedIssues);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteObjectValue<global::GitHub.Models.NullableSimpleUser>("creator", Creator);
            writer.WriteStringValue("description", Description);
            writer.WriteDateTimeOffsetValue("due_on", DueOn);
            writer.WriteStringValue("html_url", HtmlUrl);
            writer.WriteIntValue("id", Id);
            writer.WriteStringValue("labels_url", LabelsUrl);
            writer.WriteStringValue("node_id", NodeId);
            writer.WriteIntValue("number", Number);
            writer.WriteIntValue("open_issues", OpenIssues);
            writer.WriteEnumValue<global::GitHub.Models.Milestone_state>("state", State);
            writer.WriteStringValue("title", Title);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
