// <auto-generated/>
using GitHub.Models;
using GitHub.Orgs.Item.PersonalAccessTokenRequests.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Orgs.Item.PersonalAccessTokenRequests {
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\personal-access-token-requests
    /// </summary>
    public class PersonalAccessTokenRequestsRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Gets an item from the GitHub.orgs.item.personalAccessTokenRequests.item collection</summary>
        /// <param name="position">Unique identifier of the request for access via fine-grained personal access token.</param>
        /// <returns>A <see cref="WithPat_request_ItemRequestBuilder"/></returns>
        public WithPat_request_ItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("pat_request_id", position);
                return new WithPat_request_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="PersonalAccessTokenRequestsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PersonalAccessTokenRequestsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/personal-access-token-requests{?direction*,last_used_after*,last_used_before*,owner*,page*,per_page*,permission*,repository*,sort*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="PersonalAccessTokenRequestsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PersonalAccessTokenRequestsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/personal-access-token-requests{?direction*,last_used_after*,last_used_before*,owner*,page*,per_page*,permission*,repository*,sort*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists requests from organization members to access organization resources with a fine-grained personal access token.Only GitHub Apps can use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.13/rest/orgs/personal-access-tokens#list-requests-to-access-organization-resources-with-fine-grained-personal-access-tokens" />
        /// </summary>
        /// <returns>A List&lt;OrganizationProgrammaticAccessGrantRequest&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="BasicError">When receiving a 403 status code</exception>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
        /// <exception cref="ValidationError">When receiving a 422 status code</exception>
        /// <exception cref="BasicError">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<OrganizationProgrammaticAccessGrantRequest>?> GetAsync(Action<RequestConfiguration<PersonalAccessTokenRequestsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<OrganizationProgrammaticAccessGrantRequest>> GetAsync(Action<RequestConfiguration<PersonalAccessTokenRequestsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"403", BasicError.CreateFromDiscriminatorValue},
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"422", ValidationError.CreateFromDiscriminatorValue},
                {"500", BasicError.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<OrganizationProgrammaticAccessGrantRequest>(requestInfo, OrganizationProgrammaticAccessGrantRequest.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Approves or denies multiple pending requests to access organization resources via a fine-grained personal access token.Only GitHub Apps can use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.13/rest/orgs/personal-access-tokens#review-requests-to-access-organization-resources-with-fine-grained-personal-access-tokens" />
        /// </summary>
        /// <returns>A <see cref="PersonalAccessTokenRequestsPostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="BasicError">When receiving a 403 status code</exception>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
        /// <exception cref="ValidationError">When receiving a 422 status code</exception>
        /// <exception cref="BasicError">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<PersonalAccessTokenRequestsPostResponse?> PostAsync(PersonalAccessTokenRequestsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<PersonalAccessTokenRequestsPostResponse> PostAsync(PersonalAccessTokenRequestsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"403", BasicError.CreateFromDiscriminatorValue},
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"422", ValidationError.CreateFromDiscriminatorValue},
                {"500", BasicError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<PersonalAccessTokenRequestsPostResponse>(requestInfo, PersonalAccessTokenRequestsPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists requests from organization members to access organization resources with a fine-grained personal access token.Only GitHub Apps can use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<PersonalAccessTokenRequestsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<PersonalAccessTokenRequestsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Approves or denies multiple pending requests to access organization resources via a fine-grained personal access token.Only GitHub Apps can use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(PersonalAccessTokenRequestsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(PersonalAccessTokenRequestsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="PersonalAccessTokenRequestsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public PersonalAccessTokenRequestsRequestBuilder WithUrl(string rawUrl)
        {
            return new PersonalAccessTokenRequestsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists requests from organization members to access organization resources with a fine-grained personal access token.Only GitHub Apps can use this endpoint.
        /// </summary>
        public class PersonalAccessTokenRequestsRequestBuilderGetQueryParameters 
        {
            /// <summary>The direction to sort the results by.</summary>
            [QueryParameter("direction")]
            public GetDirectionQueryParameterType? Direction { get; set; }
            /// <summary>Only show fine-grained personal access tokens used after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.</summary>
            [QueryParameter("last_used_after")]
            public DateTimeOffset? LastUsedAfter { get; set; }
            /// <summary>Only show fine-grained personal access tokens used before the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.</summary>
            [QueryParameter("last_used_before")]
            public DateTimeOffset? LastUsedBefore { get; set; }
            /// <summary>A list of owner usernames to use to filter the results.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("owner")]
            public string[]? Owner { get; set; }
#nullable restore
#else
            [QueryParameter("owner")]
            public string[] Owner { get; set; }
#endif
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.13/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The permission to use to filter the results.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("permission")]
            public string? Permission { get; set; }
#nullable restore
#else
            [QueryParameter("permission")]
            public string Permission { get; set; }
#endif
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.13/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>The name of the repository to use to filter the results.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("repository")]
            public string? Repository { get; set; }
#nullable restore
#else
            [QueryParameter("repository")]
            public string Repository { get; set; }
#endif
            /// <summary>The property by which to sort the results.</summary>
            [QueryParameter("sort")]
            public GetSortQueryParameterType? Sort { get; set; }
        }
    }
}
