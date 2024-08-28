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
namespace GitHub.Orgs.Item.AuditLog
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\audit-log
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class AuditLogRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.AuditLog.AuditLogRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AuditLogRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/audit-log{?after*,before*,include*,order*,page*,per_page*,phrase*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.AuditLog.AuditLogRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AuditLogRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/audit-log{?after*,before*,include*,order*,page*,per_page*,phrase*}", rawUrl)
        {
        }
        /// <summary>
        /// Gets the audit log for an organization. For more information, see &quot;[Reviewing the audit log for your organization](https://docs.github.com/enterprise-server@3.12/github/setting-up-and-managing-organizations-and-teams/reviewing-the-audit-log-for-your-organization).&quot;By default, the response includes up to 30 events from the past three months. Use the `phrase` parameter to filter results and retrieve older events. For example, use the `phrase` parameter with the `created` qualifier to filter events based on when the events occurred. For more information, see &quot;[Reviewing the audit log for your organization](https://docs.github.com/enterprise-server@3.12/organizations/keeping-your-organization-secure/managing-security-settings-for-your-organization/reviewing-the-audit-log-for-your-organization#searching-the-audit-log).&quot;Use pagination to retrieve fewer or more than 30 events. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.12/rest/guides/using-pagination-in-the-rest-api).&quot;The authenticated user must be an organization owner to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `read:audit_log` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.12/rest/orgs/orgs#get-the-audit-log-for-an-organization" />
        /// </summary>
        /// <returns>A List&lt;global::GitHub.Models.AuditLogEvent&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::GitHub.Models.AuditLogEvent>?> GetAsync(Action<RequestConfiguration<global::GitHub.Orgs.Item.AuditLog.AuditLogRequestBuilder.AuditLogRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::GitHub.Models.AuditLogEvent>> GetAsync(Action<RequestConfiguration<global::GitHub.Orgs.Item.AuditLog.AuditLogRequestBuilder.AuditLogRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::GitHub.Models.AuditLogEvent>(requestInfo, global::GitHub.Models.AuditLogEvent.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Gets the audit log for an organization. For more information, see &quot;[Reviewing the audit log for your organization](https://docs.github.com/enterprise-server@3.12/github/setting-up-and-managing-organizations-and-teams/reviewing-the-audit-log-for-your-organization).&quot;By default, the response includes up to 30 events from the past three months. Use the `phrase` parameter to filter results and retrieve older events. For example, use the `phrase` parameter with the `created` qualifier to filter events based on when the events occurred. For more information, see &quot;[Reviewing the audit log for your organization](https://docs.github.com/enterprise-server@3.12/organizations/keeping-your-organization-secure/managing-security-settings-for-your-organization/reviewing-the-audit-log-for-your-organization#searching-the-audit-log).&quot;Use pagination to retrieve fewer or more than 30 events. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.12/rest/guides/using-pagination-in-the-rest-api).&quot;The authenticated user must be an organization owner to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `read:audit_log` scope to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Orgs.Item.AuditLog.AuditLogRequestBuilder.AuditLogRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Orgs.Item.AuditLog.AuditLogRequestBuilder.AuditLogRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Orgs.Item.AuditLog.AuditLogRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Orgs.Item.AuditLog.AuditLogRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Orgs.Item.AuditLog.AuditLogRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Gets the audit log for an organization. For more information, see &quot;[Reviewing the audit log for your organization](https://docs.github.com/enterprise-server@3.12/github/setting-up-and-managing-organizations-and-teams/reviewing-the-audit-log-for-your-organization).&quot;By default, the response includes up to 30 events from the past three months. Use the `phrase` parameter to filter results and retrieve older events. For example, use the `phrase` parameter with the `created` qualifier to filter events based on when the events occurred. For more information, see &quot;[Reviewing the audit log for your organization](https://docs.github.com/enterprise-server@3.12/organizations/keeping-your-organization-secure/managing-security-settings-for-your-organization/reviewing-the-audit-log-for-your-organization#searching-the-audit-log).&quot;Use pagination to retrieve fewer or more than 30 events. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.12/rest/guides/using-pagination-in-the-rest-api).&quot;The authenticated user must be an organization owner to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `read:audit_log` scope to use this endpoint.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class AuditLogRequestBuilderGetQueryParameters 
        {
            /// <summary>A cursor, as given in the [Link header](https://docs.github.com/enterprise-server@3.12/rest/guides/using-pagination-in-the-rest-api#using-link-headers). If specified, the query only searches for events after this cursor.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("after")]
            public string? After { get; set; }
#nullable restore
#else
            [QueryParameter("after")]
            public string After { get; set; }
#endif
            /// <summary>A cursor, as given in the [Link header](https://docs.github.com/enterprise-server@3.12/rest/guides/using-pagination-in-the-rest-api#using-link-headers). If specified, the query only searches for events before this cursor.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("before")]
            public string? Before { get; set; }
#nullable restore
#else
            [QueryParameter("before")]
            public string Before { get; set; }
#endif
            /// <summary>The event types to include:- `web` - returns web (non-Git) events.- `git` - returns Git events.- `all` - returns both web and Git events.The default is `web`.</summary>
            [QueryParameter("include")]
            public global::GitHub.Orgs.Item.AuditLog.GetIncludeQueryParameterType? Include { get; set; }
            /// <summary>The order of audit log events. To list newest events first, specify `desc`. To list oldest events first, specify `asc`.The default is `desc`.</summary>
            [QueryParameter("order")]
            public global::GitHub.Orgs.Item.AuditLog.GetOrderQueryParameterType? Order { get; set; }
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.12/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.12/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>A search phrase. For more information, see [Searching the audit log](https://docs.github.com/enterprise-server@3.12/github/setting-up-and-managing-organizations-and-teams/reviewing-the-audit-log-for-your-organization#searching-the-audit-log).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("phrase")]
            public string? Phrase { get; set; }
#nullable restore
#else
            [QueryParameter("phrase")]
            public string Phrase { get; set; }
#endif
        }
    }
}
