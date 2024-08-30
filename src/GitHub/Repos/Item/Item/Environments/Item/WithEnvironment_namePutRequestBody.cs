// <auto-generated/>
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Repos.Item.Item.Environments.Item
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class WithEnvironment_namePutRequestBody : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The type of deployment branch policy for this environment. To allow all branches to deploy, set to `null`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.DeploymentBranchPolicySettings? DeploymentBranchPolicy { get; set; }
#nullable restore
#else
        public global::GitHub.Models.DeploymentBranchPolicySettings DeploymentBranchPolicy { get; set; }
#endif
        /// <summary>The people or teams that may review jobs that reference the environment. You can list up to six users or teams as reviewers. The reviewers must have at least read access to the repository. Only one of the required reviewers needs to approve the job for it to proceed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::GitHub.Repos.Item.Item.Environments.Item.WithEnvironment_namePutRequestBody_reviewers>? Reviewers { get; set; }
#nullable restore
#else
        public List<global::GitHub.Repos.Item.Item.Environments.Item.WithEnvironment_namePutRequestBody_reviewers> Reviewers { get; set; }
#endif
        /// <summary>The amount of time to delay a job after the job is initially triggered. The time (in minutes) must be an integer between 0 and 43,200 (30 days).</summary>
        public int? WaitTimer { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Environments.Item.WithEnvironment_namePutRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Repos.Item.Item.Environments.Item.WithEnvironment_namePutRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Repos.Item.Item.Environments.Item.WithEnvironment_namePutRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "deployment_branch_policy", n => { DeploymentBranchPolicy = n.GetObjectValue<global::GitHub.Models.DeploymentBranchPolicySettings>(global::GitHub.Models.DeploymentBranchPolicySettings.CreateFromDiscriminatorValue); } },
                { "reviewers", n => { Reviewers = n.GetCollectionOfObjectValues<global::GitHub.Repos.Item.Item.Environments.Item.WithEnvironment_namePutRequestBody_reviewers>(global::GitHub.Repos.Item.Item.Environments.Item.WithEnvironment_namePutRequestBody_reviewers.CreateFromDiscriminatorValue)?.AsList(); } },
                { "wait_timer", n => { WaitTimer = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::GitHub.Models.DeploymentBranchPolicySettings>("deployment_branch_policy", DeploymentBranchPolicy);
            writer.WriteCollectionOfObjectValues<global::GitHub.Repos.Item.Item.Environments.Item.WithEnvironment_namePutRequestBody_reviewers>("reviewers", Reviewers);
            writer.WriteIntValue("wait_timer", WaitTimer);
        }
    }
}
