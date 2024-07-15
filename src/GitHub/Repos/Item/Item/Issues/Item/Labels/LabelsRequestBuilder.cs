// <auto-generated/>
using GitHub.Models;
using GitHub.Repos.Item.Item.Issues.Item.Labels.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Repos.Item.Item.Issues.Item.Labels {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\issues\{issue_number}\labels
    /// </summary>
    public class LabelsRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Gets an item from the GitHub.repos.item.item.issues.item.labels.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="WithNameItemRequestBuilder"/></returns>
        public WithNameItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("name", position);
                return new WithNameItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="LabelsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LabelsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/issues/{issue_number}/labels{?page*,per_page*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="LabelsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LabelsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/issues/{issue_number}/labels{?page*,per_page*}", rawUrl)
        {
        }
        /// <summary>
        /// Removes all labels from an issue.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.10/rest/issues/labels#remove-all-labels-from-an-issue" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
        /// <exception cref="BasicError">When receiving a 410 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"410", BasicError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists all labels for an issue.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.10/rest/issues/labels#list-labels-for-an-issue" />
        /// </summary>
        /// <returns>A List&lt;Label&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
        /// <exception cref="BasicError">When receiving a 410 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<Label>?> GetAsync(Action<RequestConfiguration<LabelsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<Label>> GetAsync(Action<RequestConfiguration<LabelsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"410", BasicError.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<Label>(requestInfo, Label.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Adds labels to an issue. If you provide an empty array of labels, all labels are removed from the issue. 
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.10/rest/issues/labels#add-labels-to-an-issue" />
        /// </summary>
        /// <returns>A List&lt;Label&gt;</returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
        /// <exception cref="BasicError">When receiving a 410 status code</exception>
        /// <exception cref="ValidationError">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<Label>?> PostAsync(LabelsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<Label>> PostAsync(LabelsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"410", BasicError.CreateFromDiscriminatorValue},
                {"422", ValidationError.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<Label>(requestInfo, Label.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Removes any previous labels and sets the new labels for an issue.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.10/rest/issues/labels#set-labels-for-an-issue" />
        /// </summary>
        /// <returns>A List&lt;Label&gt;</returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
        /// <exception cref="BasicError">When receiving a 410 status code</exception>
        /// <exception cref="ValidationError">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<Label>?> PutAsync(LabelsPutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<Label>> PutAsync(LabelsPutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"410", BasicError.CreateFromDiscriminatorValue},
                {"422", ValidationError.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<Label>(requestInfo, Label.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Removes all labels from an issue.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Lists all labels for an issue.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<LabelsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<LabelsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Adds labels to an issue. If you provide an empty array of labels, all labels are removed from the issue. 
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(LabelsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(LabelsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// Removes any previous labels and sets the new labels for an issue.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(LabelsPutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(LabelsPutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="LabelsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public LabelsRequestBuilder WithUrl(string rawUrl)
        {
            return new LabelsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="LabelsPostRequestBodyMember1"/>, <see cref="LabelsPostRequestBodyMember2"/>, <see cref="string"/>, List&lt;LabelsPostRequestBodyMember3&gt;
        /// </summary>
        public class LabelsPostRequestBody : IComposedTypeWrapper, IParsable 
        {
            /// <summary>Composed type representation for type <see cref="GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPostRequestBodyMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPostRequestBodyMember1? LabelsPostRequestBodyLabelsPostRequestBodyMember1 { get; set; }
#nullable restore
#else
            public GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPostRequestBodyMember1 LabelsPostRequestBodyLabelsPostRequestBodyMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPostRequestBodyMember2"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPostRequestBodyMember2? LabelsPostRequestBodyLabelsPostRequestBodyMember2 { get; set; }
#nullable restore
#else
            public GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPostRequestBodyMember2 LabelsPostRequestBodyLabelsPostRequestBodyMember2 { get; set; }
#endif
            /// <summary>Composed type representation for type List&lt;GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPostRequestBodyMember3&gt;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public List<GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPostRequestBodyMember3>? LabelsPostRequestBodyLabelsPostRequestBodyMember3 { get; set; }
#nullable restore
#else
            public List<GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPostRequestBodyMember3> LabelsPostRequestBodyLabelsPostRequestBodyMember3 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPostRequestBodyMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPostRequestBodyMember1? LabelsPostRequestBodyMember1 { get; set; }
#nullable restore
#else
            public GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPostRequestBodyMember1 LabelsPostRequestBodyMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPostRequestBodyMember2"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPostRequestBodyMember2? LabelsPostRequestBodyMember2 { get; set; }
#nullable restore
#else
            public GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPostRequestBodyMember2 LabelsPostRequestBodyMember2 { get; set; }
#endif
            /// <summary>Composed type representation for type List&lt;GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPostRequestBodyMember3&gt;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public List<GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPostRequestBodyMember3>? LabelsPostRequestBodyMember3 { get; set; }
#nullable restore
#else
            public List<GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPostRequestBodyMember3> LabelsPostRequestBodyMember3 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="string"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? LabelsPostRequestBodyString { get; set; }
#nullable restore
#else
            public string LabelsPostRequestBodyString { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="string"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? String { get; set; }
#nullable restore
#else
            public string String { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="LabelsPostRequestBody"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static LabelsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new LabelsPostRequestBody();
                if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.LabelsPostRequestBodyLabelsPostRequestBodyMember1 = new GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPostRequestBodyMember1();
                }
                else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.LabelsPostRequestBodyLabelsPostRequestBodyMember2 = new GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPostRequestBodyMember2();
                }
                else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.LabelsPostRequestBodyMember1 = new GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPostRequestBodyMember1();
                }
                else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.LabelsPostRequestBodyMember2 = new GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPostRequestBodyMember2();
                }
                else if(parseNode.GetStringValue() is string labelsPostRequestBodyStringValue)
                {
                    result.LabelsPostRequestBodyString = labelsPostRequestBodyStringValue;
                }
                else if(parseNode.GetStringValue() is string stringValue)
                {
                    result.String = stringValue;
                }
                else if(parseNode.GetCollectionOfObjectValues<GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPostRequestBodyMember3>(GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPostRequestBodyMember3.CreateFromDiscriminatorValue)?.ToList() is List<GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPostRequestBodyMember3> labelsPostRequestBodyLabelsPostRequestBodyMember3Value)
                {
                    result.LabelsPostRequestBodyLabelsPostRequestBodyMember3 = labelsPostRequestBodyLabelsPostRequestBodyMember3Value;
                }
                else if(parseNode.GetCollectionOfObjectValues<GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPostRequestBodyMember3>(GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPostRequestBodyMember3.CreateFromDiscriminatorValue)?.ToList() is List<GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPostRequestBodyMember3> labelsPostRequestBodyMember3Value)
                {
                    result.LabelsPostRequestBodyMember3 = labelsPostRequestBodyMember3Value;
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(LabelsPostRequestBodyLabelsPostRequestBodyMember1 != null)
                {
                    return LabelsPostRequestBodyLabelsPostRequestBodyMember1.GetFieldDeserializers();
                }
                else if(LabelsPostRequestBodyLabelsPostRequestBodyMember2 != null)
                {
                    return LabelsPostRequestBodyLabelsPostRequestBodyMember2.GetFieldDeserializers();
                }
                else if(LabelsPostRequestBodyMember1 != null)
                {
                    return LabelsPostRequestBodyMember1.GetFieldDeserializers();
                }
                else if(LabelsPostRequestBodyMember2 != null)
                {
                    return LabelsPostRequestBodyMember2.GetFieldDeserializers();
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
                if(LabelsPostRequestBodyLabelsPostRequestBodyMember1 != null)
                {
                    writer.WriteObjectValue<GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPostRequestBodyMember1>(null, LabelsPostRequestBodyLabelsPostRequestBodyMember1);
                }
                else if(LabelsPostRequestBodyLabelsPostRequestBodyMember2 != null)
                {
                    writer.WriteObjectValue<GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPostRequestBodyMember2>(null, LabelsPostRequestBodyLabelsPostRequestBodyMember2);
                }
                else if(LabelsPostRequestBodyMember1 != null)
                {
                    writer.WriteObjectValue<GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPostRequestBodyMember1>(null, LabelsPostRequestBodyMember1);
                }
                else if(LabelsPostRequestBodyMember2 != null)
                {
                    writer.WriteObjectValue<GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPostRequestBodyMember2>(null, LabelsPostRequestBodyMember2);
                }
                else if(LabelsPostRequestBodyString != null)
                {
                    writer.WriteStringValue(null, LabelsPostRequestBodyString);
                }
                else if(String != null)
                {
                    writer.WriteStringValue(null, String);
                }
                else if(LabelsPostRequestBodyLabelsPostRequestBodyMember3 != null)
                {
                    writer.WriteCollectionOfObjectValues<GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPostRequestBodyMember3>(null, LabelsPostRequestBodyLabelsPostRequestBodyMember3);
                }
                else if(LabelsPostRequestBodyMember3 != null)
                {
                    writer.WriteCollectionOfObjectValues<GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPostRequestBodyMember3>(null, LabelsPostRequestBodyMember3);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="LabelsPutRequestBodyMember1"/>, <see cref="LabelsPutRequestBodyMember2"/>, <see cref="string"/>, List&lt;LabelsPutRequestBodyMember3&gt;
        /// </summary>
        public class LabelsPutRequestBody : IComposedTypeWrapper, IParsable 
        {
            /// <summary>Composed type representation for type <see cref="GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPutRequestBodyMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPutRequestBodyMember1? LabelsPutRequestBodyLabelsPutRequestBodyMember1 { get; set; }
#nullable restore
#else
            public GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPutRequestBodyMember1 LabelsPutRequestBodyLabelsPutRequestBodyMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPutRequestBodyMember2"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPutRequestBodyMember2? LabelsPutRequestBodyLabelsPutRequestBodyMember2 { get; set; }
#nullable restore
#else
            public GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPutRequestBodyMember2 LabelsPutRequestBodyLabelsPutRequestBodyMember2 { get; set; }
#endif
            /// <summary>Composed type representation for type List&lt;GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPutRequestBodyMember3&gt;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public List<GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPutRequestBodyMember3>? LabelsPutRequestBodyLabelsPutRequestBodyMember3 { get; set; }
#nullable restore
#else
            public List<GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPutRequestBodyMember3> LabelsPutRequestBodyLabelsPutRequestBodyMember3 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPutRequestBodyMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPutRequestBodyMember1? LabelsPutRequestBodyMember1 { get; set; }
#nullable restore
#else
            public GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPutRequestBodyMember1 LabelsPutRequestBodyMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPutRequestBodyMember2"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPutRequestBodyMember2? LabelsPutRequestBodyMember2 { get; set; }
#nullable restore
#else
            public GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPutRequestBodyMember2 LabelsPutRequestBodyMember2 { get; set; }
#endif
            /// <summary>Composed type representation for type List&lt;GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPutRequestBodyMember3&gt;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public List<GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPutRequestBodyMember3>? LabelsPutRequestBodyMember3 { get; set; }
#nullable restore
#else
            public List<GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPutRequestBodyMember3> LabelsPutRequestBodyMember3 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="string"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? LabelsPutRequestBodyString { get; set; }
#nullable restore
#else
            public string LabelsPutRequestBodyString { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="string"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? String { get; set; }
#nullable restore
#else
            public string String { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="LabelsPutRequestBody"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static LabelsPutRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new LabelsPutRequestBody();
                if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.LabelsPutRequestBodyLabelsPutRequestBodyMember1 = new GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPutRequestBodyMember1();
                }
                else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.LabelsPutRequestBodyLabelsPutRequestBodyMember2 = new GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPutRequestBodyMember2();
                }
                else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.LabelsPutRequestBodyMember1 = new GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPutRequestBodyMember1();
                }
                else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.LabelsPutRequestBodyMember2 = new GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPutRequestBodyMember2();
                }
                else if(parseNode.GetStringValue() is string labelsPutRequestBodyStringValue)
                {
                    result.LabelsPutRequestBodyString = labelsPutRequestBodyStringValue;
                }
                else if(parseNode.GetStringValue() is string stringValue)
                {
                    result.String = stringValue;
                }
                else if(parseNode.GetCollectionOfObjectValues<GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPutRequestBodyMember3>(GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPutRequestBodyMember3.CreateFromDiscriminatorValue)?.ToList() is List<GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPutRequestBodyMember3> labelsPutRequestBodyLabelsPutRequestBodyMember3Value)
                {
                    result.LabelsPutRequestBodyLabelsPutRequestBodyMember3 = labelsPutRequestBodyLabelsPutRequestBodyMember3Value;
                }
                else if(parseNode.GetCollectionOfObjectValues<GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPutRequestBodyMember3>(GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPutRequestBodyMember3.CreateFromDiscriminatorValue)?.ToList() is List<GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPutRequestBodyMember3> labelsPutRequestBodyMember3Value)
                {
                    result.LabelsPutRequestBodyMember3 = labelsPutRequestBodyMember3Value;
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(LabelsPutRequestBodyLabelsPutRequestBodyMember1 != null)
                {
                    return LabelsPutRequestBodyLabelsPutRequestBodyMember1.GetFieldDeserializers();
                }
                else if(LabelsPutRequestBodyLabelsPutRequestBodyMember2 != null)
                {
                    return LabelsPutRequestBodyLabelsPutRequestBodyMember2.GetFieldDeserializers();
                }
                else if(LabelsPutRequestBodyMember1 != null)
                {
                    return LabelsPutRequestBodyMember1.GetFieldDeserializers();
                }
                else if(LabelsPutRequestBodyMember2 != null)
                {
                    return LabelsPutRequestBodyMember2.GetFieldDeserializers();
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
                if(LabelsPutRequestBodyLabelsPutRequestBodyMember1 != null)
                {
                    writer.WriteObjectValue<GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPutRequestBodyMember1>(null, LabelsPutRequestBodyLabelsPutRequestBodyMember1);
                }
                else if(LabelsPutRequestBodyLabelsPutRequestBodyMember2 != null)
                {
                    writer.WriteObjectValue<GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPutRequestBodyMember2>(null, LabelsPutRequestBodyLabelsPutRequestBodyMember2);
                }
                else if(LabelsPutRequestBodyMember1 != null)
                {
                    writer.WriteObjectValue<GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPutRequestBodyMember1>(null, LabelsPutRequestBodyMember1);
                }
                else if(LabelsPutRequestBodyMember2 != null)
                {
                    writer.WriteObjectValue<GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPutRequestBodyMember2>(null, LabelsPutRequestBodyMember2);
                }
                else if(LabelsPutRequestBodyString != null)
                {
                    writer.WriteStringValue(null, LabelsPutRequestBodyString);
                }
                else if(String != null)
                {
                    writer.WriteStringValue(null, String);
                }
                else if(LabelsPutRequestBodyLabelsPutRequestBodyMember3 != null)
                {
                    writer.WriteCollectionOfObjectValues<GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPutRequestBodyMember3>(null, LabelsPutRequestBodyLabelsPutRequestBodyMember3);
                }
                else if(LabelsPutRequestBodyMember3 != null)
                {
                    writer.WriteCollectionOfObjectValues<GitHub.Repos.Item.Item.Issues.Item.Labels.LabelsPutRequestBodyMember3>(null, LabelsPutRequestBodyMember3);
                }
            }
        }
        /// <summary>
        /// Lists all labels for an issue.
        /// </summary>
        public class LabelsRequestBuilderGetQueryParameters 
        {
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.10/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.10/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
        }
    }
}
