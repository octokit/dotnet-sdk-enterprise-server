// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Repos.Item.Item.Environments.Item.Deployment_protection_rules.Apps {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\environments\{environment_name}\deployment_protection_rules\apps
    /// </summary>
    public class AppsRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="AppsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AppsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/environments/{environment_name}/deployment_protection_rules/apps{?page*,per_page*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="AppsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AppsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/environments/{environment_name}/deployment_protection_rules/apps{?page*,per_page*}", rawUrl)
        {
        }
        /// <summary>
        /// Gets all custom deployment protection rule integrations that are available for an environment. Anyone with read access to the repository can use this endpoint.For more information about environments, see &quot;[Using environments for deployment](https://docs.github.com/enterprise-server@3.13/actions/deployment/targeting-different-environments/using-environments-for-deployment).&quot;For more information about the app that is providing this custom deployment rule, see &quot;[GET an app](https://docs.github.com/enterprise-server@3.13/rest/apps/apps#get-an-app)&quot;.OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.13/rest/deployments/protection-rules#list-custom-deployment-rule-integrations-available-for-an-environment" />
        /// </summary>
        /// <returns>A <see cref="AppsGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<AppsGetResponse?> GetAsync(Action<RequestConfiguration<AppsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<AppsGetResponse> GetAsync(Action<RequestConfiguration<AppsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<AppsGetResponse>(requestInfo, AppsGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets all custom deployment protection rule integrations that are available for an environment. Anyone with read access to the repository can use this endpoint.For more information about environments, see &quot;[Using environments for deployment](https://docs.github.com/enterprise-server@3.13/actions/deployment/targeting-different-environments/using-environments-for-deployment).&quot;For more information about the app that is providing this custom deployment rule, see &quot;[GET an app](https://docs.github.com/enterprise-server@3.13/rest/apps/apps#get-an-app)&quot;.OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<AppsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<AppsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="AppsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public AppsRequestBuilder WithUrl(string rawUrl)
        {
            return new AppsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Gets all custom deployment protection rule integrations that are available for an environment. Anyone with read access to the repository can use this endpoint.For more information about environments, see &quot;[Using environments for deployment](https://docs.github.com/enterprise-server@3.13/actions/deployment/targeting-different-environments/using-environments-for-deployment).&quot;For more information about the app that is providing this custom deployment rule, see &quot;[GET an app](https://docs.github.com/enterprise-server@3.13/rest/apps/apps#get-an-app)&quot;.OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.
        /// </summary>
        public class AppsRequestBuilderGetQueryParameters 
        {
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.13/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.13/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
        }
    }
}
