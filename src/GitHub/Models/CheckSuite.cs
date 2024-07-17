// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    /// <summary>
    /// A suite of checks performed on the code of a given code change
    /// </summary>
    public class CheckSuite : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The after property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? After { get; set; }
#nullable restore
#else
        public string After { get; set; }
#endif
        /// <summary>GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableIntegration? App { get; set; }
#nullable restore
#else
        public NullableIntegration App { get; set; }
#endif
        /// <summary>The before property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Before { get; set; }
#nullable restore
#else
        public string Before { get; set; }
#endif
        /// <summary>The check_runs_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CheckRunsUrl { get; set; }
#nullable restore
#else
        public string CheckRunsUrl { get; set; }
#endif
        /// <summary>The conclusion property</summary>
        public CheckSuite_conclusion? Conclusion { get; set; }
        /// <summary>The created_at property</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The head_branch property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HeadBranch { get; set; }
#nullable restore
#else
        public string HeadBranch { get; set; }
#endif
        /// <summary>A commit.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SimpleCommit? HeadCommit { get; set; }
#nullable restore
#else
        public SimpleCommit HeadCommit { get; set; }
#endif
        /// <summary>The SHA of the head commit that is being checked.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HeadSha { get; set; }
#nullable restore
#else
        public string HeadSha { get; set; }
#endif
        /// <summary>The id property</summary>
        public int? Id { get; set; }
        /// <summary>The latest_check_runs_count property</summary>
        public int? LatestCheckRunsCount { get; set; }
        /// <summary>The node_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NodeId { get; set; }
#nullable restore
#else
        public string NodeId { get; set; }
#endif
        /// <summary>The pull_requests property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PullRequestMinimal>? PullRequests { get; set; }
#nullable restore
#else
        public List<PullRequestMinimal> PullRequests { get; set; }
#endif
        /// <summary>Minimal Repository</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MinimalRepository? Repository { get; set; }
#nullable restore
#else
        public MinimalRepository Repository { get; set; }
#endif
        /// <summary>The rerequestable property</summary>
        public bool? Rerequestable { get; set; }
        /// <summary>The runs_rerequestable property</summary>
        public bool? RunsRerequestable { get; set; }
        /// <summary>The phase of the lifecycle that the check suite is currently in. Statuses of waiting, requested, and pending are reserved for GitHub Actions check suites.</summary>
        public CheckSuite_status? Status { get; set; }
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
        /// Instantiates a new <see cref="CheckSuite"/> and sets the default values.
        /// </summary>
        public CheckSuite()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CheckSuite"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CheckSuite CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CheckSuite();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"after", n => { After = n.GetStringValue(); } },
                {"app", n => { App = n.GetObjectValue<NullableIntegration>(NullableIntegration.CreateFromDiscriminatorValue); } },
                {"before", n => { Before = n.GetStringValue(); } },
                {"check_runs_url", n => { CheckRunsUrl = n.GetStringValue(); } },
                {"conclusion", n => { Conclusion = n.GetEnumValue<CheckSuite_conclusion>(); } },
                {"created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                {"head_branch", n => { HeadBranch = n.GetStringValue(); } },
                {"head_commit", n => { HeadCommit = n.GetObjectValue<SimpleCommit>(SimpleCommit.CreateFromDiscriminatorValue); } },
                {"head_sha", n => { HeadSha = n.GetStringValue(); } },
                {"id", n => { Id = n.GetIntValue(); } },
                {"latest_check_runs_count", n => { LatestCheckRunsCount = n.GetIntValue(); } },
                {"node_id", n => { NodeId = n.GetStringValue(); } },
                {"pull_requests", n => { PullRequests = n.GetCollectionOfObjectValues<PullRequestMinimal>(PullRequestMinimal.CreateFromDiscriminatorValue)?.ToList(); } },
                {"repository", n => { Repository = n.GetObjectValue<MinimalRepository>(MinimalRepository.CreateFromDiscriminatorValue); } },
                {"rerequestable", n => { Rerequestable = n.GetBoolValue(); } },
                {"runs_rerequestable", n => { RunsRerequestable = n.GetBoolValue(); } },
                {"status", n => { Status = n.GetEnumValue<CheckSuite_status>(); } },
                {"updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("after", After);
            writer.WriteObjectValue<NullableIntegration>("app", App);
            writer.WriteStringValue("before", Before);
            writer.WriteStringValue("check_runs_url", CheckRunsUrl);
            writer.WriteEnumValue<CheckSuite_conclusion>("conclusion", Conclusion);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteStringValue("head_branch", HeadBranch);
            writer.WriteObjectValue<SimpleCommit>("head_commit", HeadCommit);
            writer.WriteStringValue("head_sha", HeadSha);
            writer.WriteIntValue("id", Id);
            writer.WriteIntValue("latest_check_runs_count", LatestCheckRunsCount);
            writer.WriteStringValue("node_id", NodeId);
            writer.WriteCollectionOfObjectValues<PullRequestMinimal>("pull_requests", PullRequests);
            writer.WriteObjectValue<MinimalRepository>("repository", Repository);
            writer.WriteBoolValue("rerequestable", Rerequestable);
            writer.WriteBoolValue("runs_rerequestable", RunsRerequestable);
            writer.WriteEnumValue<CheckSuite_status>("status", Status);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
