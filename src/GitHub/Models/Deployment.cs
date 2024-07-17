// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    /// <summary>
    /// A request for a specific ref(branch,sha,tag) to be deployed
    /// </summary>
    public class Deployment : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The created_at property</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableSimpleUser? Creator { get; set; }
#nullable restore
#else
        public NullableSimpleUser Creator { get; set; }
#endif
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Name for the target deployment environment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Environment { get; set; }
#nullable restore
#else
        public string Environment { get; set; }
#endif
        /// <summary>Unique identifier of the deployment</summary>
        public long? Id { get; set; }
        /// <summary>The node_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NodeId { get; set; }
#nullable restore
#else
        public string NodeId { get; set; }
#endif
        /// <summary>The original_environment property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OriginalEnvironment { get; set; }
#nullable restore
#else
        public string OriginalEnvironment { get; set; }
#endif
        /// <summary>The payload property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Payload { get; set; }
#nullable restore
#else
        public string Payload { get; set; }
#endif
        /// <summary>GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableIntegration? PerformedViaGithubApp { get; set; }
#nullable restore
#else
        public NullableIntegration PerformedViaGithubApp { get; set; }
#endif
        /// <summary>Specifies if the given environment is one that end-users directly interact with. Default: false.</summary>
        public bool? ProductionEnvironment { get; set; }
        /// <summary>The ref to deploy. This can be a branch, tag, or sha.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Ref { get; set; }
#nullable restore
#else
        public string Ref { get; set; }
#endif
        /// <summary>The repository_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RepositoryUrl { get; set; }
#nullable restore
#else
        public string RepositoryUrl { get; set; }
#endif
        /// <summary>The sha property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sha { get; set; }
#nullable restore
#else
        public string Sha { get; set; }
#endif
        /// <summary>The statuses_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StatusesUrl { get; set; }
#nullable restore
#else
        public string StatusesUrl { get; set; }
#endif
        /// <summary>Parameter to specify a task to execute</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Task { get; set; }
#nullable restore
#else
        public string Task { get; set; }
#endif
        /// <summary>Specifies if the given environment is will no longer exist at some point in the future. Default: false.</summary>
        public bool? TransientEnvironment { get; set; }
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
        /// Instantiates a new <see cref="Deployment"/> and sets the default values.
        /// </summary>
        public Deployment()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Deployment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Deployment CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Deployment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                {"creator", n => { Creator = n.GetObjectValue<NullableSimpleUser>(NullableSimpleUser.CreateFromDiscriminatorValue); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"environment", n => { Environment = n.GetStringValue(); } },
                {"id", n => { Id = n.GetLongValue(); } },
                {"node_id", n => { NodeId = n.GetStringValue(); } },
                {"original_environment", n => { OriginalEnvironment = n.GetStringValue(); } },
                {"payload", n => { Payload = n.GetStringValue(); } },
                {"performed_via_github_app", n => { PerformedViaGithubApp = n.GetObjectValue<NullableIntegration>(NullableIntegration.CreateFromDiscriminatorValue); } },
                {"production_environment", n => { ProductionEnvironment = n.GetBoolValue(); } },
                {"ref", n => { Ref = n.GetStringValue(); } },
                {"repository_url", n => { RepositoryUrl = n.GetStringValue(); } },
                {"sha", n => { Sha = n.GetStringValue(); } },
                {"statuses_url", n => { StatusesUrl = n.GetStringValue(); } },
                {"task", n => { Task = n.GetStringValue(); } },
                {"transient_environment", n => { TransientEnvironment = n.GetBoolValue(); } },
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
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteObjectValue<NullableSimpleUser>("creator", Creator);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("environment", Environment);
            writer.WriteLongValue("id", Id);
            writer.WriteStringValue("node_id", NodeId);
            writer.WriteStringValue("original_environment", OriginalEnvironment);
            writer.WriteStringValue("payload", Payload);
            writer.WriteObjectValue<NullableIntegration>("performed_via_github_app", PerformedViaGithubApp);
            writer.WriteBoolValue("production_environment", ProductionEnvironment);
            writer.WriteStringValue("ref", Ref);
            writer.WriteStringValue("repository_url", RepositoryUrl);
            writer.WriteStringValue("sha", Sha);
            writer.WriteStringValue("statuses_url", StatusesUrl);
            writer.WriteStringValue("task", Task);
            writer.WriteBoolValue("transient_environment", TransientEnvironment);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
