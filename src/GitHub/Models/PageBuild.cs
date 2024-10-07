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
    /// Page Build
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class PageBuild : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The commit property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Commit { get; set; }
#nullable restore
#else
        public string Commit { get; set; }
#endif
        /// <summary>The created_at property</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The duration property</summary>
        public int? Duration { get; set; }
        /// <summary>The error property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.PageBuild_error? Error { get; set; }
#nullable restore
#else
        public global::GitHub.Models.PageBuild_error Error { get; set; }
#endif
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.NullableSimpleUser? Pusher { get; set; }
#nullable restore
#else
        public global::GitHub.Models.NullableSimpleUser Pusher { get; set; }
#endif
        /// <summary>The status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status { get; set; }
#nullable restore
#else
        public string Status { get; set; }
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
        /// Instantiates a new <see cref="global::GitHub.Models.PageBuild"/> and sets the default values.
        /// </summary>
        public PageBuild()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.PageBuild"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.PageBuild CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.PageBuild();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "commit", n => { Commit = n.GetStringValue(); } },
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "duration", n => { Duration = n.GetIntValue(); } },
                { "error", n => { Error = n.GetObjectValue<global::GitHub.Models.PageBuild_error>(global::GitHub.Models.PageBuild_error.CreateFromDiscriminatorValue); } },
                { "pusher", n => { Pusher = n.GetObjectValue<global::GitHub.Models.NullableSimpleUser>(global::GitHub.Models.NullableSimpleUser.CreateFromDiscriminatorValue); } },
                { "status", n => { Status = n.GetStringValue(); } },
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
            writer.WriteStringValue("commit", Commit);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteIntValue("duration", Duration);
            writer.WriteObjectValue<global::GitHub.Models.PageBuild_error>("error", Error);
            writer.WriteObjectValue<global::GitHub.Models.NullableSimpleUser>("pusher", Pusher);
            writer.WriteStringValue("status", Status);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
