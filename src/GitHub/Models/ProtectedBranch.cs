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
    /// Branch protections protect branches
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class ProtectedBranch : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The allow_deletions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.ProtectedBranch_allow_deletions? AllowDeletions { get; set; }
#nullable restore
#else
        public global::GitHub.Models.ProtectedBranch_allow_deletions AllowDeletions { get; set; }
#endif
        /// <summary>The allow_force_pushes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.ProtectedBranch_allow_force_pushes? AllowForcePushes { get; set; }
#nullable restore
#else
        public global::GitHub.Models.ProtectedBranch_allow_force_pushes AllowForcePushes { get; set; }
#endif
        /// <summary>Whether users can pull changes from upstream when the branch is locked. Set to `true` to allow fork syncing. Set to `false` to prevent fork syncing.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.ProtectedBranch_allow_fork_syncing? AllowForkSyncing { get; set; }
#nullable restore
#else
        public global::GitHub.Models.ProtectedBranch_allow_fork_syncing AllowForkSyncing { get; set; }
#endif
        /// <summary>The block_creations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.ProtectedBranch_block_creations? BlockCreations { get; set; }
#nullable restore
#else
        public global::GitHub.Models.ProtectedBranch_block_creations BlockCreations { get; set; }
#endif
        /// <summary>The enforce_admins property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.ProtectedBranch_enforce_admins? EnforceAdmins { get; set; }
#nullable restore
#else
        public global::GitHub.Models.ProtectedBranch_enforce_admins EnforceAdmins { get; set; }
#endif
        /// <summary>Whether to set the branch as read-only. If this is true, users will not be able to push to the branch.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.ProtectedBranch_lock_branch? LockBranch { get; set; }
#nullable restore
#else
        public global::GitHub.Models.ProtectedBranch_lock_branch LockBranch { get; set; }
#endif
        /// <summary>The required_conversation_resolution property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.ProtectedBranch_required_conversation_resolution? RequiredConversationResolution { get; set; }
#nullable restore
#else
        public global::GitHub.Models.ProtectedBranch_required_conversation_resolution RequiredConversationResolution { get; set; }
#endif
        /// <summary>The required_linear_history property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.ProtectedBranch_required_linear_history? RequiredLinearHistory { get; set; }
#nullable restore
#else
        public global::GitHub.Models.ProtectedBranch_required_linear_history RequiredLinearHistory { get; set; }
#endif
        /// <summary>The required_pull_request_reviews property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.ProtectedBranch_required_pull_request_reviews? RequiredPullRequestReviews { get; set; }
#nullable restore
#else
        public global::GitHub.Models.ProtectedBranch_required_pull_request_reviews RequiredPullRequestReviews { get; set; }
#endif
        /// <summary>The required_signatures property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.ProtectedBranch_required_signatures? RequiredSignatures { get; set; }
#nullable restore
#else
        public global::GitHub.Models.ProtectedBranch_required_signatures RequiredSignatures { get; set; }
#endif
        /// <summary>Status Check Policy</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.StatusCheckPolicy? RequiredStatusChecks { get; set; }
#nullable restore
#else
        public global::GitHub.Models.StatusCheckPolicy RequiredStatusChecks { get; set; }
#endif
        /// <summary>Branch Restriction Policy</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.BranchRestrictionPolicy? Restrictions { get; set; }
#nullable restore
#else
        public global::GitHub.Models.BranchRestrictionPolicy Restrictions { get; set; }
#endif
        /// <summary>The url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.ProtectedBranch"/> and sets the default values.
        /// </summary>
        public ProtectedBranch()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.ProtectedBranch"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.ProtectedBranch CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.ProtectedBranch();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "allow_deletions", n => { AllowDeletions = n.GetObjectValue<global::GitHub.Models.ProtectedBranch_allow_deletions>(global::GitHub.Models.ProtectedBranch_allow_deletions.CreateFromDiscriminatorValue); } },
                { "allow_force_pushes", n => { AllowForcePushes = n.GetObjectValue<global::GitHub.Models.ProtectedBranch_allow_force_pushes>(global::GitHub.Models.ProtectedBranch_allow_force_pushes.CreateFromDiscriminatorValue); } },
                { "allow_fork_syncing", n => { AllowForkSyncing = n.GetObjectValue<global::GitHub.Models.ProtectedBranch_allow_fork_syncing>(global::GitHub.Models.ProtectedBranch_allow_fork_syncing.CreateFromDiscriminatorValue); } },
                { "block_creations", n => { BlockCreations = n.GetObjectValue<global::GitHub.Models.ProtectedBranch_block_creations>(global::GitHub.Models.ProtectedBranch_block_creations.CreateFromDiscriminatorValue); } },
                { "enforce_admins", n => { EnforceAdmins = n.GetObjectValue<global::GitHub.Models.ProtectedBranch_enforce_admins>(global::GitHub.Models.ProtectedBranch_enforce_admins.CreateFromDiscriminatorValue); } },
                { "lock_branch", n => { LockBranch = n.GetObjectValue<global::GitHub.Models.ProtectedBranch_lock_branch>(global::GitHub.Models.ProtectedBranch_lock_branch.CreateFromDiscriminatorValue); } },
                { "required_conversation_resolution", n => { RequiredConversationResolution = n.GetObjectValue<global::GitHub.Models.ProtectedBranch_required_conversation_resolution>(global::GitHub.Models.ProtectedBranch_required_conversation_resolution.CreateFromDiscriminatorValue); } },
                { "required_linear_history", n => { RequiredLinearHistory = n.GetObjectValue<global::GitHub.Models.ProtectedBranch_required_linear_history>(global::GitHub.Models.ProtectedBranch_required_linear_history.CreateFromDiscriminatorValue); } },
                { "required_pull_request_reviews", n => { RequiredPullRequestReviews = n.GetObjectValue<global::GitHub.Models.ProtectedBranch_required_pull_request_reviews>(global::GitHub.Models.ProtectedBranch_required_pull_request_reviews.CreateFromDiscriminatorValue); } },
                { "required_signatures", n => { RequiredSignatures = n.GetObjectValue<global::GitHub.Models.ProtectedBranch_required_signatures>(global::GitHub.Models.ProtectedBranch_required_signatures.CreateFromDiscriminatorValue); } },
                { "required_status_checks", n => { RequiredStatusChecks = n.GetObjectValue<global::GitHub.Models.StatusCheckPolicy>(global::GitHub.Models.StatusCheckPolicy.CreateFromDiscriminatorValue); } },
                { "restrictions", n => { Restrictions = n.GetObjectValue<global::GitHub.Models.BranchRestrictionPolicy>(global::GitHub.Models.BranchRestrictionPolicy.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::GitHub.Models.ProtectedBranch_allow_deletions>("allow_deletions", AllowDeletions);
            writer.WriteObjectValue<global::GitHub.Models.ProtectedBranch_allow_force_pushes>("allow_force_pushes", AllowForcePushes);
            writer.WriteObjectValue<global::GitHub.Models.ProtectedBranch_allow_fork_syncing>("allow_fork_syncing", AllowForkSyncing);
            writer.WriteObjectValue<global::GitHub.Models.ProtectedBranch_block_creations>("block_creations", BlockCreations);
            writer.WriteObjectValue<global::GitHub.Models.ProtectedBranch_enforce_admins>("enforce_admins", EnforceAdmins);
            writer.WriteObjectValue<global::GitHub.Models.ProtectedBranch_lock_branch>("lock_branch", LockBranch);
            writer.WriteObjectValue<global::GitHub.Models.ProtectedBranch_required_conversation_resolution>("required_conversation_resolution", RequiredConversationResolution);
            writer.WriteObjectValue<global::GitHub.Models.ProtectedBranch_required_linear_history>("required_linear_history", RequiredLinearHistory);
            writer.WriteObjectValue<global::GitHub.Models.ProtectedBranch_required_pull_request_reviews>("required_pull_request_reviews", RequiredPullRequestReviews);
            writer.WriteObjectValue<global::GitHub.Models.ProtectedBranch_required_signatures>("required_signatures", RequiredSignatures);
            writer.WriteObjectValue<global::GitHub.Models.StatusCheckPolicy>("required_status_checks", RequiredStatusChecks);
            writer.WriteObjectValue<global::GitHub.Models.BranchRestrictionPolicy>("restrictions", Restrictions);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
