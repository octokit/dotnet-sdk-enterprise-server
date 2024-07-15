// <auto-generated/>
using GitHub.Models;
using GitHub.Orgs.Item.Rulesets.RuleSuites.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Orgs.Item.Rulesets.RuleSuites {
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\rulesets\rule-suites
    /// </summary>
    public class RuleSuitesRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Gets an item from the GitHub.orgs.item.rulesets.ruleSuites.item collection</summary>
        /// <param name="position">The unique identifier of the rule suite result.To get this ID, you can use [GET /repos/{owner}/{repo}/rulesets/rule-suites](https://docs.github.com/enterprise-server@3.12/rest/repos/rule-suites#list-repository-rule-suites)for repositories and [GET /orgs/{org}/rulesets/rule-suites](https://docs.github.com/enterprise-server@3.12/rest/orgs/rule-suites#list-organization-rule-suites)for organizations.</param>
        /// <returns>A <see cref="WithRule_suite_ItemRequestBuilder"/></returns>
        public WithRule_suite_ItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("rule_suite_id", position);
                return new WithRule_suite_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="RuleSuitesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RuleSuitesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/rulesets/rule-suites{?actor_name*,page*,per_page*,repository_name*,rule_suite_result*,time_period*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="RuleSuitesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RuleSuitesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/rulesets/rule-suites{?actor_name*,page*,per_page*,repository_name*,rule_suite_result*,time_period*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists suites of rule evaluations at the organization level.For more information, see &quot;[Managing rulesets for repositories in your organization](https://docs.github.com/enterprise-server@3.12/organizations/managing-organization-settings/managing-rulesets-for-repositories-in-your-organization#viewing-insights-for-rulesets).&quot;
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.12/rest/orgs/rule-suites#list-organization-rule-suites" />
        /// </summary>
        /// <returns>A List&lt;GitHub.Models.RuleSuites&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
        /// <exception cref="BasicError">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<GitHub.Models.RuleSuites>?> GetAsync(Action<RequestConfiguration<RuleSuitesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<GitHub.Models.RuleSuites>> GetAsync(Action<RequestConfiguration<RuleSuitesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"500", BasicError.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<GitHub.Models.RuleSuites>(requestInfo, GitHub.Models.RuleSuites.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Lists suites of rule evaluations at the organization level.For more information, see &quot;[Managing rulesets for repositories in your organization](https://docs.github.com/enterprise-server@3.12/organizations/managing-organization-settings/managing-rulesets-for-repositories-in-your-organization#viewing-insights-for-rulesets).&quot;
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<RuleSuitesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<RuleSuitesRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="RuleSuitesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public RuleSuitesRequestBuilder WithUrl(string rawUrl)
        {
            return new RuleSuitesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists suites of rule evaluations at the organization level.For more information, see &quot;[Managing rulesets for repositories in your organization](https://docs.github.com/enterprise-server@3.12/organizations/managing-organization-settings/managing-rulesets-for-repositories-in-your-organization#viewing-insights-for-rulesets).&quot;
        /// </summary>
        public class RuleSuitesRequestBuilderGetQueryParameters 
        {
            /// <summary>The handle for the GitHub user account to filter on. When specified, only rule evaluations triggered by this actor will be returned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("actor_name")]
            public string? ActorName { get; set; }
#nullable restore
#else
            [QueryParameter("actor_name")]
            public string ActorName { get; set; }
#endif
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.12/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.12/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>The name of the repository to filter on. When specified, only rule evaluations from this repository will be returned.</summary>
            [QueryParameter("repository_name")]
            public int? RepositoryName { get; set; }
            /// <summary>The rule results to filter on. When specified, only suites with this result will be returned.</summary>
            [QueryParameter("rule_suite_result")]
            public GetRule_suite_resultQueryParameterType? RuleSuiteResult { get; set; }
            /// <summary>The time period to filter by.For example, `day` will filter for rule suites that occurred in the past 24 hours, and `week` will filter for insights that occurred in the past 7 days (168 hours).</summary>
            [QueryParameter("time_period")]
            public GetTime_periodQueryParameterType? TimePeriod { get; set; }
        }
    }
}
