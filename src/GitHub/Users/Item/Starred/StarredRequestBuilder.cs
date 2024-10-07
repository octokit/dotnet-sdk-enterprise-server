// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Users.Item.Starred
{
    /// <summary>
    /// Builds and executes requests for operations under \users\{username}\starred
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class StarredRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Users.Item.Starred.StarredRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public StarredRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{username}/starred{?direction*,page*,per_page*,sort*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Users.Item.Starred.StarredRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public StarredRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{username}/starred{?direction*,page*,per_page*,sort*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists repositories a user has starred.This endpoint supports the following custom media types. For more information, see &quot;[Media types](https://docs.github.com/enterprise-server@3.14/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types).&quot;- **`application/vnd.github.star+json`**: Includes a timestamp of when the star was created.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.14/rest/activity/starring#list-repositories-starred-by-a-user" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Users.Item.Starred.StarredRequestBuilder.StarredGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Users.Item.Starred.StarredRequestBuilder.StarredGetResponse?> GetAsync(Action<RequestConfiguration<global::GitHub.Users.Item.Starred.StarredRequestBuilder.StarredRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Users.Item.Starred.StarredRequestBuilder.StarredGetResponse> GetAsync(Action<RequestConfiguration<global::GitHub.Users.Item.Starred.StarredRequestBuilder.StarredRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::GitHub.Users.Item.Starred.StarredRequestBuilder.StarredGetResponse>(requestInfo, global::GitHub.Users.Item.Starred.StarredRequestBuilder.StarredGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists repositories a user has starred.This endpoint supports the following custom media types. For more information, see &quot;[Media types](https://docs.github.com/enterprise-server@3.14/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types).&quot;- **`application/vnd.github.star+json`**: Includes a timestamp of when the star was created.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Users.Item.Starred.StarredRequestBuilder.StarredRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Users.Item.Starred.StarredRequestBuilder.StarredRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Users.Item.Starred.StarredRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Users.Item.Starred.StarredRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Users.Item.Starred.StarredRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Composed type wrapper for classes List&lt;global::GitHub.Users.Item.Starred.Repository&gt;, List&lt;global::GitHub.Users.Item.Starred.StarredRepository&gt;
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class StarredGetResponse : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type List&lt;global::GitHub.Users.Item.Starred.Repository&gt;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public List<global::GitHub.Users.Item.Starred.Repository>? Repository { get; set; }
#nullable restore
#else
            public List<global::GitHub.Users.Item.Starred.Repository> Repository { get; set; }
#endif
            /// <summary>Composed type representation for type List&lt;global::GitHub.Users.Item.Starred.StarredRepository&gt;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public List<global::GitHub.Users.Item.Starred.StarredRepository>? StarredRepository { get; set; }
#nullable restore
#else
            public List<global::GitHub.Users.Item.Starred.StarredRepository> StarredRepository { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::GitHub.Users.Item.Starred.StarredRequestBuilder.StarredGetResponse"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::GitHub.Users.Item.Starred.StarredRequestBuilder.StarredGetResponse CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::GitHub.Users.Item.Starred.StarredRequestBuilder.StarredGetResponse();
                if(parseNode.GetCollectionOfObjectValues<global::GitHub.Users.Item.Starred.Repository>(global::GitHub.Users.Item.Starred.Repository.CreateFromDiscriminatorValue)?.AsList() is List<global::GitHub.Users.Item.Starred.Repository> repositoryValue)
                {
                    result.Repository = repositoryValue;
                }
                else if(parseNode.GetCollectionOfObjectValues<global::GitHub.Users.Item.Starred.StarredRepository>(global::GitHub.Users.Item.Starred.StarredRepository.CreateFromDiscriminatorValue)?.AsList() is List<global::GitHub.Users.Item.Starred.StarredRepository> starredRepositoryValue)
                {
                    result.StarredRepository = starredRepositoryValue;
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer)
            {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(Repository != null)
                {
                    writer.WriteCollectionOfObjectValues<global::GitHub.Users.Item.Starred.Repository>(null, Repository);
                }
                else if(StarredRepository != null)
                {
                    writer.WriteCollectionOfObjectValues<global::GitHub.Users.Item.Starred.StarredRepository>(null, StarredRepository);
                }
            }
        }
        /// <summary>
        /// Lists repositories a user has starred.This endpoint supports the following custom media types. For more information, see &quot;[Media types](https://docs.github.com/enterprise-server@3.14/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types).&quot;- **`application/vnd.github.star+json`**: Includes a timestamp of when the star was created.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class StarredRequestBuilderGetQueryParameters 
        {
            /// <summary>The direction to sort the results by.</summary>
            [QueryParameter("direction")]
            public global::GitHub.Users.Item.Starred.GetDirectionQueryParameterType? Direction { get; set; }
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.14/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.14/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>The property to sort the results by. `created` means when the repository was starred. `updated` means when the repository was last pushed to.</summary>
            [QueryParameter("sort")]
            public global::GitHub.Users.Item.Starred.GetSortQueryParameterType? Sort { get; set; }
        }
    }
}
#pragma warning restore CS0618
