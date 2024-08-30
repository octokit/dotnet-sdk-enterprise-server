// <auto-generated/>
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Enterprises.Item.Dependabot.Alerts
{
    /// <summary>
    /// Builds and executes requests for operations under \enterprises\{enterprise}\dependabot\alerts
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class AlertsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Enterprises.Item.Dependabot.Alerts.AlertsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AlertsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/enterprises/{enterprise}/dependabot/alerts{?after*,before*,direction*,ecosystem*,first*,last*,package*,per_page*,scope*,severity*,sort*,state*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Enterprises.Item.Dependabot.Alerts.AlertsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AlertsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/enterprises/{enterprise}/dependabot/alerts{?after*,before*,direction*,ecosystem*,first*,last*,package*,per_page*,scope*,severity*,sort*,state*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists Dependabot alerts for repositories that are owned by the specified enterprise.The authenticated user must be a member of the enterprise to use this endpoint.Alerts are only returned for organizations in the enterprise for which you are an organization owner or a security manager. For more information about security managers, see &quot;[Managing security managers in your organization](https://docs.github.com/enterprise-server@3.10/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).&quot;OAuth app tokens and personal access tokens (classic) need the `repo` or `security_events` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.10/rest/dependabot/alerts#list-dependabot-alerts-for-an-enterprise" />
        /// </summary>
        /// <returns>A List&lt;global::GitHub.Models.DependabotAlertWithRepository&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 403 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
        /// <exception cref="global::GitHub.Models.ValidationErrorSimple">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::GitHub.Models.DependabotAlertWithRepository>?> GetAsync(Action<RequestConfiguration<global::GitHub.Enterprises.Item.Dependabot.Alerts.AlertsRequestBuilder.AlertsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::GitHub.Models.DependabotAlertWithRepository>> GetAsync(Action<RequestConfiguration<global::GitHub.Enterprises.Item.Dependabot.Alerts.AlertsRequestBuilder.AlertsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "403", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "422", global::GitHub.Models.ValidationErrorSimple.CreateFromDiscriminatorValue },
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::GitHub.Models.DependabotAlertWithRepository>(requestInfo, global::GitHub.Models.DependabotAlertWithRepository.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Lists Dependabot alerts for repositories that are owned by the specified enterprise.The authenticated user must be a member of the enterprise to use this endpoint.Alerts are only returned for organizations in the enterprise for which you are an organization owner or a security manager. For more information about security managers, see &quot;[Managing security managers in your organization](https://docs.github.com/enterprise-server@3.10/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).&quot;OAuth app tokens and personal access tokens (classic) need the `repo` or `security_events` scope to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Enterprises.Item.Dependabot.Alerts.AlertsRequestBuilder.AlertsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Enterprises.Item.Dependabot.Alerts.AlertsRequestBuilder.AlertsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Enterprises.Item.Dependabot.Alerts.AlertsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Enterprises.Item.Dependabot.Alerts.AlertsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Enterprises.Item.Dependabot.Alerts.AlertsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists Dependabot alerts for repositories that are owned by the specified enterprise.The authenticated user must be a member of the enterprise to use this endpoint.Alerts are only returned for organizations in the enterprise for which you are an organization owner or a security manager. For more information about security managers, see &quot;[Managing security managers in your organization](https://docs.github.com/enterprise-server@3.10/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).&quot;OAuth app tokens and personal access tokens (classic) need the `repo` or `security_events` scope to use this endpoint.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class AlertsRequestBuilderGetQueryParameters 
        {
            /// <summary>A cursor, as given in the [Link header](https://docs.github.com/enterprise-server@3.10/rest/guides/using-pagination-in-the-rest-api#using-link-headers). If specified, the query only searches for results after this cursor. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.10/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("after")]
            public string? After { get; set; }
#nullable restore
#else
            [QueryParameter("after")]
            public string After { get; set; }
#endif
            /// <summary>A cursor, as given in the [Link header](https://docs.github.com/enterprise-server@3.10/rest/guides/using-pagination-in-the-rest-api#using-link-headers). If specified, the query only searches for results before this cursor. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.10/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("before")]
            public string? Before { get; set; }
#nullable restore
#else
            [QueryParameter("before")]
            public string Before { get; set; }
#endif
            /// <summary>The direction to sort the results by.</summary>
            [QueryParameter("direction")]
            public global::GitHub.Enterprises.Item.Dependabot.Alerts.GetDirectionQueryParameterType? Direction { get; set; }
            /// <summary>A comma-separated list of ecosystems. If specified, only alerts for these ecosystems will be returned.Can be: `composer`, `go`, `maven`, `npm`, `nuget`, `pip`, `pub`, `rubygems`, `rust`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("ecosystem")]
            public string? Ecosystem { get; set; }
#nullable restore
#else
            [QueryParameter("ecosystem")]
            public string Ecosystem { get; set; }
#endif
            /// <summary>**Deprecated**. The number of results per page (max 100), starting from the first matching result.This parameter must not be used in combination with `last`.Instead, use `per_page` in combination with `after` to fetch the first page of results.</summary>
            [QueryParameter("first")]
            public int? First { get; set; }
            /// <summary>**Deprecated**. The number of results per page (max 100), starting from the last matching result.This parameter must not be used in combination with `first`.Instead, use `per_page` in combination with `before` to fetch the last page of results.</summary>
            [QueryParameter("last")]
            public int? Last { get; set; }
            /// <summary>A comma-separated list of package names. If specified, only alerts for these packages will be returned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("package")]
            public string? Package { get; set; }
#nullable restore
#else
            [QueryParameter("package")]
            public string Package { get; set; }
#endif
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.10/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>The scope of the vulnerable dependency. If specified, only alerts with this scope will be returned.</summary>
            [QueryParameter("scope")]
            public global::GitHub.Enterprises.Item.Dependabot.Alerts.GetScopeQueryParameterType? Scope { get; set; }
            /// <summary>A comma-separated list of severities. If specified, only alerts with these severities will be returned.Can be: `low`, `medium`, `high`, `critical`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("severity")]
            public string? Severity { get; set; }
#nullable restore
#else
            [QueryParameter("severity")]
            public string Severity { get; set; }
#endif
            /// <summary>The property by which to sort the results.`created` means when the alert was created.`updated` means when the alert&apos;s state last changed.</summary>
            [QueryParameter("sort")]
            public global::GitHub.Enterprises.Item.Dependabot.Alerts.GetSortQueryParameterType? Sort { get; set; }
            /// <summary>A comma-separated list of states. If specified, only alerts with these states will be returned.Can be: `auto_dismissed`, `dismissed`, `fixed`, `open`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("state")]
            public string? State { get; set; }
#nullable restore
#else
            [QueryParameter("state")]
            public string State { get; set; }
#endif
        }
    }
}
