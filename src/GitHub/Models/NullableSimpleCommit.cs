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
    /// A commit.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class NullableSimpleCommit : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Information about the Git author</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.NullableSimpleCommit_author? Author { get; set; }
#nullable restore
#else
        public global::GitHub.Models.NullableSimpleCommit_author Author { get; set; }
#endif
        /// <summary>Information about the Git committer</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.NullableSimpleCommit_committer? Committer { get; set; }
#nullable restore
#else
        public global::GitHub.Models.NullableSimpleCommit_committer Committer { get; set; }
#endif
        /// <summary>SHA for the commit</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>Message describing the purpose of the commit</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message { get; set; }
#nullable restore
#else
        public string Message { get; set; }
#endif
        /// <summary>Timestamp of the commit</summary>
        public DateTimeOffset? Timestamp { get; set; }
        /// <summary>SHA for the commit&apos;s tree</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TreeId { get; set; }
#nullable restore
#else
        public string TreeId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.NullableSimpleCommit"/> and sets the default values.
        /// </summary>
        public NullableSimpleCommit()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.NullableSimpleCommit"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.NullableSimpleCommit CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.NullableSimpleCommit();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "author", n => { Author = n.GetObjectValue<global::GitHub.Models.NullableSimpleCommit_author>(global::GitHub.Models.NullableSimpleCommit_author.CreateFromDiscriminatorValue); } },
                { "committer", n => { Committer = n.GetObjectValue<global::GitHub.Models.NullableSimpleCommit_committer>(global::GitHub.Models.NullableSimpleCommit_committer.CreateFromDiscriminatorValue); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "message", n => { Message = n.GetStringValue(); } },
                { "timestamp", n => { Timestamp = n.GetDateTimeOffsetValue(); } },
                { "tree_id", n => { TreeId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::GitHub.Models.NullableSimpleCommit_author>("author", Author);
            writer.WriteObjectValue<global::GitHub.Models.NullableSimpleCommit_committer>("committer", Committer);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("message", Message);
            writer.WriteDateTimeOffsetValue("timestamp", Timestamp);
            writer.WriteStringValue("tree_id", TreeId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
