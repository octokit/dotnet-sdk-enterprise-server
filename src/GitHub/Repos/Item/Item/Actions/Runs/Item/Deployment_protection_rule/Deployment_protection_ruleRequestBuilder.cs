// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Repos.Item.Item.Actions.Runs.Item.Deployment_protection_rule
{
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\actions\runs\{run_id}\deployment_protection_rule
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class Deployment_protection_ruleRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Actions.Runs.Item.Deployment_protection_rule.Deployment_protection_ruleRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Deployment_protection_ruleRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/actions/runs/{run_id}/deployment_protection_rule", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Actions.Runs.Item.Deployment_protection_rule.Deployment_protection_ruleRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Deployment_protection_ruleRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/actions/runs/{run_id}/deployment_protection_rule", rawUrl)
        {
        }
        /// <summary>
        /// Approve or reject custom deployment protection rules provided by a GitHub App for a workflow run. For more information, see &quot;[Using environments for deployment](https://docs.github.com/enterprise-server@3.12/actions/deployment/targeting-different-environments/using-environments-for-deployment).&quot;&gt; [!NOTE]&gt; GitHub Apps can only review their own custom deployment protection rules. To approve or reject pending deployments that are waiting for review from a specific person or team, see [`POST /repos/{owner}/{repo}/actions/runs/{run_id}/pending_deployments`](/rest/actions/workflow-runs#review-pending-deployments-for-a-workflow-run).OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.12/rest/actions/workflow-runs#review-custom-deployment-protection-rules-for-a-workflow-run" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PostAsync(global::GitHub.Repos.Item.Item.Actions.Runs.Item.Deployment_protection_rule.Deployment_protection_ruleRequestBuilder.Deployment_protection_rulePostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task PostAsync(global::GitHub.Repos.Item.Item.Actions.Runs.Item.Deployment_protection_rule.Deployment_protection_ruleRequestBuilder.Deployment_protection_rulePostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Approve or reject custom deployment protection rules provided by a GitHub App for a workflow run. For more information, see &quot;[Using environments for deployment](https://docs.github.com/enterprise-server@3.12/actions/deployment/targeting-different-environments/using-environments-for-deployment).&quot;&gt; [!NOTE]&gt; GitHub Apps can only review their own custom deployment protection rules. To approve or reject pending deployments that are waiting for review from a specific person or team, see [`POST /repos/{owner}/{repo}/actions/runs/{run_id}/pending_deployments`](/rest/actions/workflow-runs#review-pending-deployments-for-a-workflow-run).OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::GitHub.Repos.Item.Item.Actions.Runs.Item.Deployment_protection_rule.Deployment_protection_ruleRequestBuilder.Deployment_protection_rulePostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::GitHub.Repos.Item.Item.Actions.Runs.Item.Deployment_protection_rule.Deployment_protection_ruleRequestBuilder.Deployment_protection_rulePostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Actions.Runs.Item.Deployment_protection_rule.Deployment_protection_ruleRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Repos.Item.Item.Actions.Runs.Item.Deployment_protection_rule.Deployment_protection_ruleRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Repos.Item.Item.Actions.Runs.Item.Deployment_protection_rule.Deployment_protection_ruleRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::GitHub.Models.ReviewCustomGatesCommentRequired"/>, <see cref="global::GitHub.Models.ReviewCustomGatesStateRequired"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class Deployment_protection_rulePostRequestBody : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::GitHub.Models.ReviewCustomGatesCommentRequired"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::GitHub.Models.ReviewCustomGatesCommentRequired? DeploymentProtectionRulePostRequestBodyReviewCustomGatesCommentRequired { get; set; }
#nullable restore
#else
            public global::GitHub.Models.ReviewCustomGatesCommentRequired DeploymentProtectionRulePostRequestBodyReviewCustomGatesCommentRequired { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::GitHub.Models.ReviewCustomGatesStateRequired"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::GitHub.Models.ReviewCustomGatesStateRequired? DeploymentProtectionRulePostRequestBodyReviewCustomGatesStateRequired { get; set; }
#nullable restore
#else
            public global::GitHub.Models.ReviewCustomGatesStateRequired DeploymentProtectionRulePostRequestBodyReviewCustomGatesStateRequired { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::GitHub.Models.ReviewCustomGatesCommentRequired"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::GitHub.Models.ReviewCustomGatesCommentRequired? ReviewCustomGatesCommentRequired { get; set; }
#nullable restore
#else
            public global::GitHub.Models.ReviewCustomGatesCommentRequired ReviewCustomGatesCommentRequired { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::GitHub.Models.ReviewCustomGatesStateRequired"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::GitHub.Models.ReviewCustomGatesStateRequired? ReviewCustomGatesStateRequired { get; set; }
#nullable restore
#else
            public global::GitHub.Models.ReviewCustomGatesStateRequired ReviewCustomGatesStateRequired { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Actions.Runs.Item.Deployment_protection_rule.Deployment_protection_ruleRequestBuilder.Deployment_protection_rulePostRequestBody"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::GitHub.Repos.Item.Item.Actions.Runs.Item.Deployment_protection_rule.Deployment_protection_ruleRequestBuilder.Deployment_protection_rulePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::GitHub.Repos.Item.Item.Actions.Runs.Item.Deployment_protection_rule.Deployment_protection_ruleRequestBuilder.Deployment_protection_rulePostRequestBody();
                result.DeploymentProtectionRulePostRequestBodyReviewCustomGatesCommentRequired = new global::GitHub.Models.ReviewCustomGatesCommentRequired();
                result.DeploymentProtectionRulePostRequestBodyReviewCustomGatesStateRequired = new global::GitHub.Models.ReviewCustomGatesStateRequired();
                result.ReviewCustomGatesCommentRequired = new global::GitHub.Models.ReviewCustomGatesCommentRequired();
                result.ReviewCustomGatesStateRequired = new global::GitHub.Models.ReviewCustomGatesStateRequired();
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(DeploymentProtectionRulePostRequestBodyReviewCustomGatesCommentRequired != null || DeploymentProtectionRulePostRequestBodyReviewCustomGatesStateRequired != null || ReviewCustomGatesCommentRequired != null || ReviewCustomGatesStateRequired != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(DeploymentProtectionRulePostRequestBodyReviewCustomGatesCommentRequired, DeploymentProtectionRulePostRequestBodyReviewCustomGatesStateRequired, ReviewCustomGatesCommentRequired, ReviewCustomGatesStateRequired);
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer)
            {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                writer.WriteObjectValue<global::GitHub.Models.ReviewCustomGatesCommentRequired>(null, DeploymentProtectionRulePostRequestBodyReviewCustomGatesCommentRequired, DeploymentProtectionRulePostRequestBodyReviewCustomGatesStateRequired, ReviewCustomGatesCommentRequired, ReviewCustomGatesStateRequired);
            }
        }
    }
}
#pragma warning restore CS0618
