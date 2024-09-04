// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Orgs.Item.Actions.RunnerGroups
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class RunnerGroupsPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Whether the runner group can be used by `public` repositories.</summary>
        public bool? AllowsPublicRepositories { get; set; }
        /// <summary>Name of the runner group.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>If `true`, the runner group will be restricted to running only the workflows specified in the `selected_workflows` array.</summary>
        public bool? RestrictedToWorkflows { get; set; }
        /// <summary>List of runner IDs to add to the runner group.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? Runners { get; set; }
#nullable restore
#else
        public List<int?> Runners { get; set; }
#endif
        /// <summary>List of repository IDs that can access the runner group.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? SelectedRepositoryIds { get; set; }
#nullable restore
#else
        public List<int?> SelectedRepositoryIds { get; set; }
#endif
        /// <summary>List of workflows the runner group should be allowed to run. This setting will be ignored unless `restricted_to_workflows` is set to `true`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SelectedWorkflows { get; set; }
#nullable restore
#else
        public List<string> SelectedWorkflows { get; set; }
#endif
        /// <summary>Visibility of a runner group. You can select all repositories, select individual repositories, or limit access to private repositories.</summary>
        public global::GitHub.Orgs.Item.Actions.RunnerGroups.RunnerGroupsPostRequestBody_visibility? Visibility { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.Actions.RunnerGroups.RunnerGroupsPostRequestBody"/> and sets the default values.
        /// </summary>
        public RunnerGroupsPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
            Visibility = global::GitHub.Orgs.Item.Actions.RunnerGroups.RunnerGroupsPostRequestBody_visibility.All;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Orgs.Item.Actions.RunnerGroups.RunnerGroupsPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Orgs.Item.Actions.RunnerGroups.RunnerGroupsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Orgs.Item.Actions.RunnerGroups.RunnerGroupsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "allows_public_repositories", n => { AllowsPublicRepositories = n.GetBoolValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "restricted_to_workflows", n => { RestrictedToWorkflows = n.GetBoolValue(); } },
                { "runners", n => { Runners = n.GetCollectionOfPrimitiveValues<int?>()?.AsList(); } },
                { "selected_repository_ids", n => { SelectedRepositoryIds = n.GetCollectionOfPrimitiveValues<int?>()?.AsList(); } },
                { "selected_workflows", n => { SelectedWorkflows = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "visibility", n => { Visibility = n.GetEnumValue<global::GitHub.Orgs.Item.Actions.RunnerGroups.RunnerGroupsPostRequestBody_visibility>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allows_public_repositories", AllowsPublicRepositories);
            writer.WriteStringValue("name", Name);
            writer.WriteBoolValue("restricted_to_workflows", RestrictedToWorkflows);
            writer.WriteCollectionOfPrimitiveValues<int?>("runners", Runners);
            writer.WriteCollectionOfPrimitiveValues<int?>("selected_repository_ids", SelectedRepositoryIds);
            writer.WriteCollectionOfPrimitiveValues<string>("selected_workflows", SelectedWorkflows);
            writer.WriteEnumValue<global::GitHub.Orgs.Item.Actions.RunnerGroups.RunnerGroupsPostRequestBody_visibility>("visibility", Visibility);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
