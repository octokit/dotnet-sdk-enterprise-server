// <auto-generated/>
using GitHub.Repos.Item.Item.Actions.Artifacts.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Repos.Item.Item.Actions.Artifacts
{
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\actions\artifacts
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class ArtifactsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the GitHub.repos.item.item.actions.artifacts.item collection</summary>
        /// <param name="position">The unique identifier of the artifact.</param>
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Actions.Artifacts.Item.WithArtifact_ItemRequestBuilder"/></returns>
        public global::GitHub.Repos.Item.Item.Actions.Artifacts.Item.WithArtifact_ItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("artifact_id", position);
                return new global::GitHub.Repos.Item.Item.Actions.Artifacts.Item.WithArtifact_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Actions.Artifacts.ArtifactsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ArtifactsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/actions/artifacts{?name*,page*,per_page*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Actions.Artifacts.ArtifactsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ArtifactsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/actions/artifacts{?name*,page*,per_page*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists all artifacts for a repository.Anyone with read access to the repository can use this endpoint.OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.12/rest/actions/artifacts#list-artifacts-for-a-repository" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Actions.Artifacts.ArtifactsGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Repos.Item.Item.Actions.Artifacts.ArtifactsGetResponse?> GetAsync(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Actions.Artifacts.ArtifactsRequestBuilder.ArtifactsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Repos.Item.Item.Actions.Artifacts.ArtifactsGetResponse> GetAsync(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Actions.Artifacts.ArtifactsRequestBuilder.ArtifactsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::GitHub.Repos.Item.Item.Actions.Artifacts.ArtifactsGetResponse>(requestInfo, global::GitHub.Repos.Item.Item.Actions.Artifacts.ArtifactsGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists all artifacts for a repository.Anyone with read access to the repository can use this endpoint.OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Actions.Artifacts.ArtifactsRequestBuilder.ArtifactsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Actions.Artifacts.ArtifactsRequestBuilder.ArtifactsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Actions.Artifacts.ArtifactsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Repos.Item.Item.Actions.Artifacts.ArtifactsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Repos.Item.Item.Actions.Artifacts.ArtifactsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists all artifacts for a repository.Anyone with read access to the repository can use this endpoint.OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class ArtifactsRequestBuilderGetQueryParameters 
        {
            /// <summary>The name field of an artifact. When specified, only artifacts with this name will be returned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("name")]
            public string? Name { get; set; }
#nullable restore
#else
            [QueryParameter("name")]
            public string Name { get; set; }
#endif
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.12/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.12/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
        }
    }
}
