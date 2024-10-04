// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Models;
using GitHub.Repos.Item.Item.CheckRuns.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Repos.Item.Item.CheckRuns
{
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\check-runs
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class CheckRunsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the GitHub.repos.item.item.checkRuns.item collection</summary>
        /// <param name="position">The unique identifier of the check run.</param>
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.CheckRuns.Item.WithCheck_run_ItemRequestBuilder"/></returns>
        public global::GitHub.Repos.Item.Item.CheckRuns.Item.WithCheck_run_ItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("check_run_id", position);
                return new global::GitHub.Repos.Item.Item.CheckRuns.Item.WithCheck_run_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.CheckRuns.CheckRunsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CheckRunsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/check-runs", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.CheckRuns.CheckRunsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CheckRunsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/check-runs", rawUrl)
        {
        }
        /// <summary>
        /// Creates a new check run for a specific commit in a repository.To create a check run, you must use a GitHub App. OAuth apps and authenticated users are not able to create a check suite.In a check suite, GitHub limits the number of check runs with the same name to 1000. Once these check runs exceed 1000, GitHub will start to automatically delete older check runs.&gt; [!NOTE]&gt; The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.14/rest/checks/runs#create-a-check-run" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.CheckRun"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.CheckRun?> PostAsync(global::GitHub.Repos.Item.Item.CheckRuns.CheckRunsRequestBuilder.CheckRunsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.CheckRun> PostAsync(global::GitHub.Repos.Item.Item.CheckRuns.CheckRunsRequestBuilder.CheckRunsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::GitHub.Models.CheckRun>(requestInfo, global::GitHub.Models.CheckRun.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a new check run for a specific commit in a repository.To create a check run, you must use a GitHub App. OAuth apps and authenticated users are not able to create a check suite.In a check suite, GitHub limits the number of check runs with the same name to 1000. Once these check runs exceed 1000, GitHub will start to automatically delete older check runs.&gt; [!NOTE]&gt; The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::GitHub.Repos.Item.Item.CheckRuns.CheckRunsRequestBuilder.CheckRunsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::GitHub.Repos.Item.Item.CheckRuns.CheckRunsRequestBuilder.CheckRunsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.CheckRuns.CheckRunsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Repos.Item.Item.CheckRuns.CheckRunsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Repos.Item.Item.CheckRuns.CheckRunsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::GitHub.Repos.Item.Item.CheckRuns.CheckRunsPostRequestBodyMember1"/>, <see cref="global::GitHub.Repos.Item.Item.CheckRuns.CheckRunsPostRequestBodyMember2"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class CheckRunsPostRequestBody : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::GitHub.Repos.Item.Item.CheckRuns.CheckRunsPostRequestBodyMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::GitHub.Repos.Item.Item.CheckRuns.CheckRunsPostRequestBodyMember1? CheckRunsPostRequestBodyCheckRunsPostRequestBodyMember1 { get; set; }
#nullable restore
#else
            public global::GitHub.Repos.Item.Item.CheckRuns.CheckRunsPostRequestBodyMember1 CheckRunsPostRequestBodyCheckRunsPostRequestBodyMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::GitHub.Repos.Item.Item.CheckRuns.CheckRunsPostRequestBodyMember2"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::GitHub.Repos.Item.Item.CheckRuns.CheckRunsPostRequestBodyMember2? CheckRunsPostRequestBodyCheckRunsPostRequestBodyMember2 { get; set; }
#nullable restore
#else
            public global::GitHub.Repos.Item.Item.CheckRuns.CheckRunsPostRequestBodyMember2 CheckRunsPostRequestBodyCheckRunsPostRequestBodyMember2 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::GitHub.Repos.Item.Item.CheckRuns.CheckRunsPostRequestBodyMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::GitHub.Repos.Item.Item.CheckRuns.CheckRunsPostRequestBodyMember1? CheckRunsPostRequestBodyMember1 { get; set; }
#nullable restore
#else
            public global::GitHub.Repos.Item.Item.CheckRuns.CheckRunsPostRequestBodyMember1 CheckRunsPostRequestBodyMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::GitHub.Repos.Item.Item.CheckRuns.CheckRunsPostRequestBodyMember2"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::GitHub.Repos.Item.Item.CheckRuns.CheckRunsPostRequestBodyMember2? CheckRunsPostRequestBodyMember2 { get; set; }
#nullable restore
#else
            public global::GitHub.Repos.Item.Item.CheckRuns.CheckRunsPostRequestBodyMember2 CheckRunsPostRequestBodyMember2 { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::GitHub.Repos.Item.Item.CheckRuns.CheckRunsRequestBuilder.CheckRunsPostRequestBody"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::GitHub.Repos.Item.Item.CheckRuns.CheckRunsRequestBuilder.CheckRunsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("status")?.GetStringValue();
                var result = new global::GitHub.Repos.Item.Item.CheckRuns.CheckRunsRequestBuilder.CheckRunsPostRequestBody();
                if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.CheckRunsPostRequestBodyCheckRunsPostRequestBodyMember1 = new global::GitHub.Repos.Item.Item.CheckRuns.CheckRunsPostRequestBodyMember1();
                }
                else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.CheckRunsPostRequestBodyCheckRunsPostRequestBodyMember2 = new global::GitHub.Repos.Item.Item.CheckRuns.CheckRunsPostRequestBodyMember2();
                }
                else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.CheckRunsPostRequestBodyMember1 = new global::GitHub.Repos.Item.Item.CheckRuns.CheckRunsPostRequestBodyMember1();
                }
                else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.CheckRunsPostRequestBodyMember2 = new global::GitHub.Repos.Item.Item.CheckRuns.CheckRunsPostRequestBodyMember2();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(CheckRunsPostRequestBodyCheckRunsPostRequestBodyMember1 != null)
                {
                    return CheckRunsPostRequestBodyCheckRunsPostRequestBodyMember1.GetFieldDeserializers();
                }
                else if(CheckRunsPostRequestBodyCheckRunsPostRequestBodyMember2 != null)
                {
                    return CheckRunsPostRequestBodyCheckRunsPostRequestBodyMember2.GetFieldDeserializers();
                }
                else if(CheckRunsPostRequestBodyMember1 != null)
                {
                    return CheckRunsPostRequestBodyMember1.GetFieldDeserializers();
                }
                else if(CheckRunsPostRequestBodyMember2 != null)
                {
                    return CheckRunsPostRequestBodyMember2.GetFieldDeserializers();
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
                if(CheckRunsPostRequestBodyCheckRunsPostRequestBodyMember1 != null)
                {
                    writer.WriteObjectValue<global::GitHub.Repos.Item.Item.CheckRuns.CheckRunsPostRequestBodyMember1>(null, CheckRunsPostRequestBodyCheckRunsPostRequestBodyMember1);
                }
                else if(CheckRunsPostRequestBodyCheckRunsPostRequestBodyMember2 != null)
                {
                    writer.WriteObjectValue<global::GitHub.Repos.Item.Item.CheckRuns.CheckRunsPostRequestBodyMember2>(null, CheckRunsPostRequestBodyCheckRunsPostRequestBodyMember2);
                }
                else if(CheckRunsPostRequestBodyMember1 != null)
                {
                    writer.WriteObjectValue<global::GitHub.Repos.Item.Item.CheckRuns.CheckRunsPostRequestBodyMember1>(null, CheckRunsPostRequestBodyMember1);
                }
                else if(CheckRunsPostRequestBodyMember2 != null)
                {
                    writer.WriteObjectValue<global::GitHub.Repos.Item.Item.CheckRuns.CheckRunsPostRequestBodyMember2>(null, CheckRunsPostRequestBodyMember2);
                }
            }
        }
    }
}
#pragma warning restore CS0618
