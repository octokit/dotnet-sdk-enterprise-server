// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Repos.Item.Item.Branches.Item.Protection
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class ProtectionPutRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Allows deletion of the protected branch by anyone with write access to the repository. Set to `false` to prevent deletion of the protected branch. Default: `false`. For more information, see &quot;[Enabling force pushes to a protected branch](https://docs.github.com/enterprise-server@3.14/github/administering-a-repository/enabling-force-pushes-to-a-protected-branch)&quot; in the GitHub Help documentation.</summary>
        public bool? AllowDeletions { get; set; }
        /// <summary>Permits force pushes to the protected branch by anyone with write access to the repository. Set to `true` to allow force pushes. Set to `false` or `null` to block force pushes. Default: `false`. For more information, see &quot;[Enabling force pushes to a protected branch](https://docs.github.com/enterprise-server@3.14/github/administering-a-repository/enabling-force-pushes-to-a-protected-branch)&quot; in the GitHub Help documentation.&quot;</summary>
        public bool? AllowForcePushes { get; set; }
        /// <summary>Whether users can pull changes from upstream when the branch is locked. Set to `true` to allow fork syncing. Set to `false` to prevent fork syncing. Default: `false`.</summary>
        public bool? AllowForkSyncing { get; set; }
        /// <summary>If set to `true`, the `restrictions` branch protection settings which limits who can push will also block pushes which create new branches, unless the push is initiated by a user, team, or app which has the ability to push. Set to `true` to restrict new branch creation. Default: `false`.</summary>
        public bool? BlockCreations { get; set; }
        /// <summary>Enforce all configured restrictions for administrators. Set to `true` to enforce required status checks for repository administrators. Set to `null` to disable.</summary>
        public bool? EnforceAdmins { get; set; }
        /// <summary>Whether to set the branch as read-only. If this is true, users will not be able to push to the branch. Default: `false`.</summary>
        public bool? LockBranch { get; set; }
        /// <summary>Requires all conversations on code to be resolved before a pull request can be merged into a branch that matches this rule. Set to `false` to disable. Default: `false`.</summary>
        public bool? RequiredConversationResolution { get; set; }
        /// <summary>Enforces a linear commit Git history, which prevents anyone from pushing merge commits to a branch. Set to `true` to enforce a linear commit history. Set to `false` to disable a linear commit Git history. Your repository must allow squash merging or rebase merging before you can enable a linear commit history. Default: `false`. For more information, see &quot;[Requiring a linear commit history](https://docs.github.com/enterprise-server@3.14/github/administering-a-repository/requiring-a-linear-commit-history)&quot; in the GitHub Help documentation.</summary>
        public bool? RequiredLinearHistory { get; set; }
        /// <summary>Require at least one approving review on a pull request, before merging. Set to `null` to disable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Repos.Item.Item.Branches.Item.Protection.ProtectionPutRequestBody_required_pull_request_reviews? RequiredPullRequestReviews { get; set; }
#nullable restore
#else
        public global::GitHub.Repos.Item.Item.Branches.Item.Protection.ProtectionPutRequestBody_required_pull_request_reviews RequiredPullRequestReviews { get; set; }
#endif
        /// <summary>Require status checks to pass before merging. Set to `null` to disable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Repos.Item.Item.Branches.Item.Protection.ProtectionPutRequestBody_required_status_checks? RequiredStatusChecks { get; set; }
#nullable restore
#else
        public global::GitHub.Repos.Item.Item.Branches.Item.Protection.ProtectionPutRequestBody_required_status_checks RequiredStatusChecks { get; set; }
#endif
        /// <summary>Restrict who can push to the protected branch. User, app, and team `restrictions` are only available for organization-owned repositories. Set to `null` to disable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Repos.Item.Item.Branches.Item.Protection.ProtectionPutRequestBody_restrictions? Restrictions { get; set; }
#nullable restore
#else
        public global::GitHub.Repos.Item.Item.Branches.Item.Protection.ProtectionPutRequestBody_restrictions Restrictions { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Branches.Item.Protection.ProtectionPutRequestBody"/> and sets the default values.
        /// </summary>
        public ProtectionPutRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Branches.Item.Protection.ProtectionPutRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Repos.Item.Item.Branches.Item.Protection.ProtectionPutRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Repos.Item.Item.Branches.Item.Protection.ProtectionPutRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "allow_deletions", n => { AllowDeletions = n.GetBoolValue(); } },
                { "allow_force_pushes", n => { AllowForcePushes = n.GetBoolValue(); } },
                { "allow_fork_syncing", n => { AllowForkSyncing = n.GetBoolValue(); } },
                { "block_creations", n => { BlockCreations = n.GetBoolValue(); } },
                { "enforce_admins", n => { EnforceAdmins = n.GetBoolValue(); } },
                { "lock_branch", n => { LockBranch = n.GetBoolValue(); } },
                { "required_conversation_resolution", n => { RequiredConversationResolution = n.GetBoolValue(); } },
                { "required_linear_history", n => { RequiredLinearHistory = n.GetBoolValue(); } },
                { "required_pull_request_reviews", n => { RequiredPullRequestReviews = n.GetObjectValue<global::GitHub.Repos.Item.Item.Branches.Item.Protection.ProtectionPutRequestBody_required_pull_request_reviews>(global::GitHub.Repos.Item.Item.Branches.Item.Protection.ProtectionPutRequestBody_required_pull_request_reviews.CreateFromDiscriminatorValue); } },
                { "required_status_checks", n => { RequiredStatusChecks = n.GetObjectValue<global::GitHub.Repos.Item.Item.Branches.Item.Protection.ProtectionPutRequestBody_required_status_checks>(global::GitHub.Repos.Item.Item.Branches.Item.Protection.ProtectionPutRequestBody_required_status_checks.CreateFromDiscriminatorValue); } },
                { "restrictions", n => { Restrictions = n.GetObjectValue<global::GitHub.Repos.Item.Item.Branches.Item.Protection.ProtectionPutRequestBody_restrictions>(global::GitHub.Repos.Item.Item.Branches.Item.Protection.ProtectionPutRequestBody_restrictions.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allow_deletions", AllowDeletions);
            writer.WriteBoolValue("allow_force_pushes", AllowForcePushes);
            writer.WriteBoolValue("allow_fork_syncing", AllowForkSyncing);
            writer.WriteBoolValue("block_creations", BlockCreations);
            writer.WriteBoolValue("enforce_admins", EnforceAdmins);
            writer.WriteBoolValue("lock_branch", LockBranch);
            writer.WriteBoolValue("required_conversation_resolution", RequiredConversationResolution);
            writer.WriteBoolValue("required_linear_history", RequiredLinearHistory);
            writer.WriteObjectValue<global::GitHub.Repos.Item.Item.Branches.Item.Protection.ProtectionPutRequestBody_required_pull_request_reviews>("required_pull_request_reviews", RequiredPullRequestReviews);
            writer.WriteObjectValue<global::GitHub.Repos.Item.Item.Branches.Item.Protection.ProtectionPutRequestBody_required_status_checks>("required_status_checks", RequiredStatusChecks);
            writer.WriteObjectValue<global::GitHub.Repos.Item.Item.Branches.Item.Protection.ProtectionPutRequestBody_restrictions>("restrictions", Restrictions);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
