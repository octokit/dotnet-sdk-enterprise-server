// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    /// <summary>
    /// Branch With Protection
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class BranchWithProtection : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Commit</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.Commit? Commit { get; set; }
#nullable restore
#else
        public global::GitHub.Models.Commit Commit { get; set; }
#endif
        /// <summary>The _links property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.BranchWithProtection__links? Links { get; set; }
#nullable restore
#else
        public global::GitHub.Models.BranchWithProtection__links Links { get; set; }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The pattern property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Pattern { get; set; }
#nullable restore
#else
        public string Pattern { get; set; }
#endif
        /// <summary>The protected property</summary>
        public bool? Protected { get; set; }
        /// <summary>Branch Protection</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.BranchProtection? Protection { get; set; }
#nullable restore
#else
        public global::GitHub.Models.BranchProtection Protection { get; set; }
#endif
        /// <summary>The protection_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProtectionUrl { get; set; }
#nullable restore
#else
        public string ProtectionUrl { get; set; }
#endif
        /// <summary>The required_approving_review_count property</summary>
        public int? RequiredApprovingReviewCount { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.BranchWithProtection"/> and sets the default values.
        /// </summary>
        public BranchWithProtection()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.BranchWithProtection"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.BranchWithProtection CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.BranchWithProtection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "commit", n => { Commit = n.GetObjectValue<global::GitHub.Models.Commit>(global::GitHub.Models.Commit.CreateFromDiscriminatorValue); } },
                { "_links", n => { Links = n.GetObjectValue<global::GitHub.Models.BranchWithProtection__links>(global::GitHub.Models.BranchWithProtection__links.CreateFromDiscriminatorValue); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "pattern", n => { Pattern = n.GetStringValue(); } },
                { "protected", n => { Protected = n.GetBoolValue(); } },
                { "protection", n => { Protection = n.GetObjectValue<global::GitHub.Models.BranchProtection>(global::GitHub.Models.BranchProtection.CreateFromDiscriminatorValue); } },
                { "protection_url", n => { ProtectionUrl = n.GetStringValue(); } },
                { "required_approving_review_count", n => { RequiredApprovingReviewCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::GitHub.Models.Commit>("commit", Commit);
            writer.WriteObjectValue<global::GitHub.Models.BranchWithProtection__links>("_links", Links);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("pattern", Pattern);
            writer.WriteBoolValue("protected", Protected);
            writer.WriteObjectValue<global::GitHub.Models.BranchProtection>("protection", Protection);
            writer.WriteStringValue("protection_url", ProtectionUrl);
            writer.WriteIntValue("required_approving_review_count", RequiredApprovingReviewCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
