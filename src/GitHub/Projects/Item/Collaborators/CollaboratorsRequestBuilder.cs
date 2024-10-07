// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Models;
using GitHub.Projects.Item.Collaborators.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Projects.Item.Collaborators
{
    /// <summary>
    /// Builds and executes requests for operations under \projects\{project_id}\collaborators
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class CollaboratorsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the GitHub.projects.item.collaborators.item collection</summary>
        /// <param name="position">The handle for the GitHub user account.</param>
        /// <returns>A <see cref="global::GitHub.Projects.Item.Collaborators.Item.WithUsernameItemRequestBuilder"/></returns>
        public global::GitHub.Projects.Item.Collaborators.Item.WithUsernameItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("username", position);
                return new global::GitHub.Projects.Item.Collaborators.Item.WithUsernameItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Projects.Item.Collaborators.CollaboratorsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CollaboratorsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/projects/{project_id}/collaborators{?affiliation*,page*,per_page*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Projects.Item.Collaborators.CollaboratorsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CollaboratorsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/projects/{project_id}/collaborators{?affiliation*,page*,per_page*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists the collaborators for an organization project. For a project, the list of collaborators includes outside collaborators, organization members that are direct collaborators, organization members with access through team memberships, organization members with access through default organization permissions, and organization owners. You must be an organization owner or a project `admin` to list collaborators.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.12/rest/projects/collaborators#list-project-collaborators" />
        /// </summary>
        /// <returns>A List&lt;global::GitHub.Models.SimpleUser&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 401 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 403 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
        /// <exception cref="global::GitHub.Models.ValidationError">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::GitHub.Models.SimpleUser>?> GetAsync(Action<RequestConfiguration<global::GitHub.Projects.Item.Collaborators.CollaboratorsRequestBuilder.CollaboratorsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::GitHub.Models.SimpleUser>> GetAsync(Action<RequestConfiguration<global::GitHub.Projects.Item.Collaborators.CollaboratorsRequestBuilder.CollaboratorsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "403", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "422", global::GitHub.Models.ValidationError.CreateFromDiscriminatorValue },
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::GitHub.Models.SimpleUser>(requestInfo, global::GitHub.Models.SimpleUser.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Lists the collaborators for an organization project. For a project, the list of collaborators includes outside collaborators, organization members that are direct collaborators, organization members with access through team memberships, organization members with access through default organization permissions, and organization owners. You must be an organization owner or a project `admin` to list collaborators.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Projects.Item.Collaborators.CollaboratorsRequestBuilder.CollaboratorsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Projects.Item.Collaborators.CollaboratorsRequestBuilder.CollaboratorsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Projects.Item.Collaborators.CollaboratorsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Projects.Item.Collaborators.CollaboratorsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Projects.Item.Collaborators.CollaboratorsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists the collaborators for an organization project. For a project, the list of collaborators includes outside collaborators, organization members that are direct collaborators, organization members with access through team memberships, organization members with access through default organization permissions, and organization owners. You must be an organization owner or a project `admin` to list collaborators.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class CollaboratorsRequestBuilderGetQueryParameters 
        {
            /// <summary>Filters the collaborators by their affiliation. `outside` means outside collaborators of a project that are not a member of the project&apos;s organization. `direct` means collaborators with permissions to a project, regardless of organization membership status. `all` means all collaborators the authenticated user can see.</summary>
            [QueryParameter("affiliation")]
            public global::GitHub.Projects.Item.Collaborators.GetAffiliationQueryParameterType? Affiliation { get; set; }
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.12/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.12/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
        }
    }
}
#pragma warning restore CS0618
