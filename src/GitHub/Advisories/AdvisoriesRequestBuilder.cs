// <auto-generated/>
using GitHub.Advisories.Item;
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Advisories
{
    /// <summary>
    /// Builds and executes requests for operations under \advisories
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class AdvisoriesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the GitHub.advisories.item collection</summary>
        /// <param name="position">The GHSA (GitHub Security Advisory) identifier of the advisory.</param>
        /// <returns>A <see cref="global::GitHub.Advisories.Item.WithGhsa_ItemRequestBuilder"/></returns>
        public global::GitHub.Advisories.Item.WithGhsa_ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("ghsa_id", position);
                return new global::GitHub.Advisories.Item.WithGhsa_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Advisories.AdvisoriesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AdvisoriesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/advisories{?affects*,after*,before*,cve_id*,cwes*,direction*,ecosystem*,epss_percentage*,epss_percentile*,ghsa_id*,is_withdrawn*,modified*,per_page*,published*,severity*,sort*,type*,updated*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Advisories.AdvisoriesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AdvisoriesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/advisories{?affects*,after*,before*,cve_id*,cwes*,direction*,ecosystem*,epss_percentage*,epss_percentile*,ghsa_id*,is_withdrawn*,modified*,per_page*,published*,severity*,sort*,type*,updated*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists all global security advisories that match the specified parameters. If no other parameters are defined, the request will return only GitHub-reviewed advisories that are not malware.By default, all responses will exclude advisories for malware, because malware are not standard vulnerabilities. To list advisories for malware, you must include the `type` parameter in your request, with the value `malware`. For more information about the different types of security advisories, see &quot;[About the GitHub Advisory database](https://docs.github.com/enterprise-server@3.14/code-security/security-advisories/global-security-advisories/about-the-github-advisory-database#about-types-of-security-advisories).&quot;
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.14/rest/security-advisories/global-advisories#list-global-security-advisories" />
        /// </summary>
        /// <returns>A List&lt;global::GitHub.Models.GlobalAdvisory&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.ValidationErrorSimple">When receiving a 422 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 429 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::GitHub.Models.GlobalAdvisory>?> GetAsync(Action<RequestConfiguration<global::GitHub.Advisories.AdvisoriesRequestBuilder.AdvisoriesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::GitHub.Models.GlobalAdvisory>> GetAsync(Action<RequestConfiguration<global::GitHub.Advisories.AdvisoriesRequestBuilder.AdvisoriesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "422", global::GitHub.Models.ValidationErrorSimple.CreateFromDiscriminatorValue },
                { "429", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::GitHub.Models.GlobalAdvisory>(requestInfo, global::GitHub.Models.GlobalAdvisory.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Lists all global security advisories that match the specified parameters. If no other parameters are defined, the request will return only GitHub-reviewed advisories that are not malware.By default, all responses will exclude advisories for malware, because malware are not standard vulnerabilities. To list advisories for malware, you must include the `type` parameter in your request, with the value `malware`. For more information about the different types of security advisories, see &quot;[About the GitHub Advisory database](https://docs.github.com/enterprise-server@3.14/code-security/security-advisories/global-security-advisories/about-the-github-advisory-database#about-types-of-security-advisories).&quot;
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Advisories.AdvisoriesRequestBuilder.AdvisoriesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Advisories.AdvisoriesRequestBuilder.AdvisoriesRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Advisories.AdvisoriesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Advisories.AdvisoriesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Advisories.AdvisoriesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists all global security advisories that match the specified parameters. If no other parameters are defined, the request will return only GitHub-reviewed advisories that are not malware.By default, all responses will exclude advisories for malware, because malware are not standard vulnerabilities. To list advisories for malware, you must include the `type` parameter in your request, with the value `malware`. For more information about the different types of security advisories, see &quot;[About the GitHub Advisory database](https://docs.github.com/enterprise-server@3.14/code-security/security-advisories/global-security-advisories/about-the-github-advisory-database#about-types-of-security-advisories).&quot;
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class AdvisoriesRequestBuilderGetQueryParameters 
        {
            /// <summary>If specified, only return advisories that affect any of `package` or `package@version`. A maximum of 1000 packages can be specified.If the query parameter causes the URL to exceed the maximum URL length supported by your client, you must specify fewer packages.Example: `affects=package1,package2@1.0.0,package3@^2.0.0` or `affects[]=package1&amp;affects[]=package2@1.0.0`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("affects")]
            public string? Affects { get; set; }
#nullable restore
#else
            [QueryParameter("affects")]
            public string Affects { get; set; }
#endif
            /// <summary>A cursor, as given in the [Link header](https://docs.github.com/enterprise-server@3.14/rest/guides/using-pagination-in-the-rest-api#using-link-headers). If specified, the query only searches for results after this cursor. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.14/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("after")]
            public string? After { get; set; }
#nullable restore
#else
            [QueryParameter("after")]
            public string After { get; set; }
#endif
            /// <summary>A cursor, as given in the [Link header](https://docs.github.com/enterprise-server@3.14/rest/guides/using-pagination-in-the-rest-api#using-link-headers). If specified, the query only searches for results before this cursor. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.14/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("before")]
            public string? Before { get; set; }
#nullable restore
#else
            [QueryParameter("before")]
            public string Before { get; set; }
#endif
            /// <summary>If specified, only advisories with this CVE (Common Vulnerabilities and Exposures) identifier will be returned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("cve_id")]
            public string? CveId { get; set; }
#nullable restore
#else
            [QueryParameter("cve_id")]
            public string CveId { get; set; }
#endif
            /// <summary>If specified, only advisories with these Common Weakness Enumerations (CWEs) will be returned.Example: `cwes=79,284,22` or `cwes[]=79&amp;cwes[]=284&amp;cwes[]=22`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("cwes")]
            public string? Cwes { get; set; }
#nullable restore
#else
            [QueryParameter("cwes")]
            public string Cwes { get; set; }
#endif
            /// <summary>The direction to sort the results by.</summary>
            [QueryParameter("direction")]
            public global::GitHub.Advisories.GetDirectionQueryParameterType? Direction { get; set; }
            /// <summary>If specified, only advisories for these ecosystems will be returned.</summary>
            [QueryParameter("ecosystem")]
            public global::GitHub.Models.SecurityAdvisoryEcosystems? Ecosystem { get; set; }
            /// <summary>If specified, only return advisories that have an EPSS percentage score that matches the provided value.The EPSS percentage represents the likelihood of a CVE being exploited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("epss_percentage")]
            public string? EpssPercentage { get; set; }
#nullable restore
#else
            [QueryParameter("epss_percentage")]
            public string EpssPercentage { get; set; }
#endif
            /// <summary>If specified, only return advisories that have an EPSS percentile score that matches the provided value.The EPSS percentile represents the relative rank of the CVE&apos;s likelihood of being exploited compared to other CVEs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("epss_percentile")]
            public string? EpssPercentile { get; set; }
#nullable restore
#else
            [QueryParameter("epss_percentile")]
            public string EpssPercentile { get; set; }
#endif
            /// <summary>If specified, only advisories with this GHSA (GitHub Security Advisory) identifier will be returned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("ghsa_id")]
            public string? GhsaId { get; set; }
#nullable restore
#else
            [QueryParameter("ghsa_id")]
            public string GhsaId { get; set; }
#endif
            /// <summary>Whether to only return advisories that have been withdrawn.</summary>
            [QueryParameter("is_withdrawn")]
            public bool? IsWithdrawn { get; set; }
            /// <summary>If specified, only show advisories that were updated or published on a date or date range.For more information on the syntax of the date range, see &quot;[Understanding the search syntax](https://docs.github.com/enterprise-server@3.14/search-github/getting-started-with-searching-on-github/understanding-the-search-syntax#query-for-dates).&quot;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("modified")]
            public string? Modified { get; set; }
#nullable restore
#else
            [QueryParameter("modified")]
            public string Modified { get; set; }
#endif
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.14/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>If specified, only return advisories that were published on a date or date range.For more information on the syntax of the date range, see &quot;[Understanding the search syntax](https://docs.github.com/enterprise-server@3.14/search-github/getting-started-with-searching-on-github/understanding-the-search-syntax#query-for-dates).&quot;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("published")]
            public string? Published { get; set; }
#nullable restore
#else
            [QueryParameter("published")]
            public string Published { get; set; }
#endif
            /// <summary>If specified, only advisories with these severities will be returned.</summary>
            [QueryParameter("severity")]
            public global::GitHub.Advisories.GetSeverityQueryParameterType? Severity { get; set; }
            /// <summary>The property to sort the results by.</summary>
            [QueryParameter("sort")]
            public global::GitHub.Advisories.GetSortQueryParameterType? Sort { get; set; }
            /// <summary>If specified, only advisories of this type will be returned. By default, a request with no other parameters defined will only return reviewed advisories that are not malware.</summary>
            [QueryParameter("type")]
            public global::GitHub.Advisories.GetTypeQueryParameterType? Type { get; set; }
            /// <summary>If specified, only return advisories that were updated on a date or date range.For more information on the syntax of the date range, see &quot;[Understanding the search syntax](https://docs.github.com/enterprise-server@3.14/search-github/getting-started-with-searching-on-github/understanding-the-search-syntax#query-for-dates).&quot;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("updated")]
            public string? Updated { get; set; }
#nullable restore
#else
            [QueryParameter("updated")]
            public string Updated { get; set; }
#endif
        }
    }
}
