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
namespace GitHub.Rate_limit
{
    /// <summary>
    /// Builds and executes requests for operations under \rate_limit
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class Rate_limitRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Rate_limit.Rate_limitRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Rate_limitRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rate_limit", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Rate_limit.Rate_limitRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Rate_limitRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rate_limit", rawUrl)
        {
        }
        /// <summary>
        /// &gt; [!NOTE]&gt; Accessing this endpoint does not count against your REST API rate limit.Some categories of endpoints have custom rate limits that are separate from the rate limit governing the other REST API endpoints. For this reason, the API response categorizes your rate limit. Under `resources`, you&apos;ll see objects relating to different categories:* The `core` object provides your rate limit status for all non-search-related resources in the REST API.* The `search` object provides your rate limit status for the REST API for searching (excluding code searches). For more information, see &quot;[Search](https://docs.github.com/enterprise-server@3.12/rest/search/search).&quot;* The `code_search` object provides your rate limit status for the REST API for searching code. For more information, see &quot;[Search code](https://docs.github.com/enterprise-server@3.12/rest/search/search#search-code).&quot;* The `graphql` object provides your rate limit status for the GraphQL API. For more information, see &quot;[Resource limitations](https://docs.github.com/enterprise-server@3.12/graphql/overview/resource-limitations#rate-limit).&quot;* The `integration_manifest` object provides your rate limit status for the `POST /app-manifests/{code}/conversions` operation. For more information, see &quot;[Creating a GitHub App from a manifest](https://docs.github.com/enterprise-server@3.12/apps/creating-github-apps/setting-up-a-github-app/creating-a-github-app-from-a-manifest#3-you-exchange-the-temporary-code-to-retrieve-the-app-configuration).&quot;* The `dependency_snapshots` object provides your rate limit status for submitting snapshots to the dependency graph. For more information, see &quot;[Dependency graph](https://docs.github.com/enterprise-server@3.12/rest/dependency-graph).&quot;* The `code_scanning_upload` object provides your rate limit status for uploading SARIF results to code scanning. For more information, see &quot;[Uploading a SARIF file to GitHub](https://docs.github.com/enterprise-server@3.12/code-security/code-scanning/integrating-with-code-scanning/uploading-a-sarif-file-to-github).&quot;* The `actions_runner_registration` object provides your rate limit status for registering self-hosted runners in GitHub Actions. For more information, see &quot;[Self-hosted runners](https://docs.github.com/enterprise-server@3.12/rest/actions/self-hosted-runners).&quot;* The `source_import` object is no longer in use for any API endpoints, and it will be removed in the next API version. For more information about API versions, see &quot;[API Versions](https://docs.github.com/enterprise-server@3.12/rest/about-the-rest-api/api-versions).&quot;&gt; [!NOTE]&gt; The `rate` object is deprecated. If you&apos;re writing new API client code or updating existing code, you should use the `core` object instead of the `rate` object. The `core` object contains the same information that is present in the `rate` object.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.12/rest/rate-limit/rate-limit#get-rate-limit-status-for-the-authenticated-user" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.RateLimitOverview"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.RateLimitOverview?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.RateLimitOverview> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Models.RateLimitOverview>(requestInfo, global::GitHub.Models.RateLimitOverview.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// &gt; [!NOTE]&gt; Accessing this endpoint does not count against your REST API rate limit.Some categories of endpoints have custom rate limits that are separate from the rate limit governing the other REST API endpoints. For this reason, the API response categorizes your rate limit. Under `resources`, you&apos;ll see objects relating to different categories:* The `core` object provides your rate limit status for all non-search-related resources in the REST API.* The `search` object provides your rate limit status for the REST API for searching (excluding code searches). For more information, see &quot;[Search](https://docs.github.com/enterprise-server@3.12/rest/search/search).&quot;* The `code_search` object provides your rate limit status for the REST API for searching code. For more information, see &quot;[Search code](https://docs.github.com/enterprise-server@3.12/rest/search/search#search-code).&quot;* The `graphql` object provides your rate limit status for the GraphQL API. For more information, see &quot;[Resource limitations](https://docs.github.com/enterprise-server@3.12/graphql/overview/resource-limitations#rate-limit).&quot;* The `integration_manifest` object provides your rate limit status for the `POST /app-manifests/{code}/conversions` operation. For more information, see &quot;[Creating a GitHub App from a manifest](https://docs.github.com/enterprise-server@3.12/apps/creating-github-apps/setting-up-a-github-app/creating-a-github-app-from-a-manifest#3-you-exchange-the-temporary-code-to-retrieve-the-app-configuration).&quot;* The `dependency_snapshots` object provides your rate limit status for submitting snapshots to the dependency graph. For more information, see &quot;[Dependency graph](https://docs.github.com/enterprise-server@3.12/rest/dependency-graph).&quot;* The `code_scanning_upload` object provides your rate limit status for uploading SARIF results to code scanning. For more information, see &quot;[Uploading a SARIF file to GitHub](https://docs.github.com/enterprise-server@3.12/code-security/code-scanning/integrating-with-code-scanning/uploading-a-sarif-file-to-github).&quot;* The `actions_runner_registration` object provides your rate limit status for registering self-hosted runners in GitHub Actions. For more information, see &quot;[Self-hosted runners](https://docs.github.com/enterprise-server@3.12/rest/actions/self-hosted-runners).&quot;* The `source_import` object is no longer in use for any API endpoints, and it will be removed in the next API version. For more information about API versions, see &quot;[API Versions](https://docs.github.com/enterprise-server@3.12/rest/about-the-rest-api/api-versions).&quot;&gt; [!NOTE]&gt; The `rate` object is deprecated. If you&apos;re writing new API client code or updating existing code, you should use the `core` object instead of the `rate` object. The `core` object contains the same information that is present in the `rate` object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Rate_limit.Rate_limitRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Rate_limit.Rate_limitRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Rate_limit.Rate_limitRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
