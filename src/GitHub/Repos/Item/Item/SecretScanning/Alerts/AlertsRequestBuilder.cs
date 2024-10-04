// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Models;
using GitHub.Repos.Item.Item.SecretScanning.Alerts.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Repos.Item.Item.SecretScanning.Alerts
{
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\secret-scanning\alerts
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class AlertsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the GitHub.repos.item.item.secretScanning.alerts.item collection</summary>
        /// <param name="position">The number that identifies an alert. You can find this at the end of the URL for a code scanning alert within GitHub, and in the `number` field in the response from the `GET /repos/{owner}/{repo}/code-scanning/alerts` operation.</param>
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.SecretScanning.Alerts.Item.WithAlert_numberItemRequestBuilder"/></returns>
        public global::GitHub.Repos.Item.Item.SecretScanning.Alerts.Item.WithAlert_numberItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("alert_number", position);
                return new global::GitHub.Repos.Item.Item.SecretScanning.Alerts.Item.WithAlert_numberItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.SecretScanning.Alerts.AlertsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AlertsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/secret-scanning/alerts{?after*,before*,direction*,page*,per_page*,resolution*,secret_type*,sort*,state*,validity*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.SecretScanning.Alerts.AlertsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AlertsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/secret-scanning/alerts{?after*,before*,direction*,page*,per_page*,resolution*,secret_type*,sort*,state*,validity*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists secret scanning alerts for an eligible repository, from newest to oldest.The authenticated user must be an administrator for the repository or for the organization that owns the repository to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `repo` or `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.12/rest/secret-scanning/secret-scanning#list-secret-scanning-alerts-for-a-repository" />
        /// </summary>
        /// <returns>A List&lt;global::GitHub.Models.SecretScanningAlert&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.Alerts503Error">When receiving a 503 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::GitHub.Models.SecretScanningAlert>?> GetAsync(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.SecretScanning.Alerts.AlertsRequestBuilder.AlertsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::GitHub.Models.SecretScanningAlert>> GetAsync(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.SecretScanning.Alerts.AlertsRequestBuilder.AlertsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "503", global::GitHub.Models.Alerts503Error.CreateFromDiscriminatorValue },
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::GitHub.Models.SecretScanningAlert>(requestInfo, global::GitHub.Models.SecretScanningAlert.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Lists secret scanning alerts for an eligible repository, from newest to oldest.The authenticated user must be an administrator for the repository or for the organization that owns the repository to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `repo` or `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.SecretScanning.Alerts.AlertsRequestBuilder.AlertsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.SecretScanning.Alerts.AlertsRequestBuilder.AlertsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.SecretScanning.Alerts.AlertsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Repos.Item.Item.SecretScanning.Alerts.AlertsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Repos.Item.Item.SecretScanning.Alerts.AlertsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists secret scanning alerts for an eligible repository, from newest to oldest.The authenticated user must be an administrator for the repository or for the organization that owns the repository to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `repo` or `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class AlertsRequestBuilderGetQueryParameters 
        {
            /// <summary>A cursor, as given in the [Link header](https://docs.github.com/enterprise-server@3.12/rest/guides/using-pagination-in-the-rest-api#using-link-headers). If specified, the query only searches for events after this cursor.  To receive an initial cursor on your first request, include an empty &quot;after&quot; query string.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("after")]
            public string? After { get; set; }
#nullable restore
#else
            [QueryParameter("after")]
            public string After { get; set; }
#endif
            /// <summary>A cursor, as given in the [Link header](https://docs.github.com/enterprise-server@3.12/rest/guides/using-pagination-in-the-rest-api#using-link-headers). If specified, the query only searches for events before this cursor. To receive an initial cursor on your first request, include an empty &quot;before&quot; query string.</summary>
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
            public global::GitHub.Repos.Item.Item.SecretScanning.Alerts.GetDirectionQueryParameterType? Direction { get; set; }
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.12/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.12/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>A comma-separated list of resolutions. Only secret scanning alerts with one of these resolutions are listed. Valid resolutions are `false_positive`, `wont_fix`, `revoked`, `pattern_edited`, `pattern_deleted` or `used_in_tests`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("resolution")]
            public string? Resolution { get; set; }
#nullable restore
#else
            [QueryParameter("resolution")]
            public string Resolution { get; set; }
#endif
            /// <summary>A comma-separated list of secret types to return. By default all secret types are returned.See &quot;[Supported secret scanning patterns](https://docs.github.com/enterprise-server@3.12/code-security/secret-scanning/introduction/supported-secret-scanning-patterns#supported-secrets)&quot;for a complete list of secret types.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("secret_type")]
            public string? SecretType { get; set; }
#nullable restore
#else
            [QueryParameter("secret_type")]
            public string SecretType { get; set; }
#endif
            /// <summary>The property to sort the results by. `created` means when the alert was created. `updated` means when the alert was updated or resolved.</summary>
            [QueryParameter("sort")]
            public global::GitHub.Repos.Item.Item.SecretScanning.Alerts.GetSortQueryParameterType? Sort { get; set; }
            /// <summary>Set to `open` or `resolved` to only list secret scanning alerts in a specific state.</summary>
            [QueryParameter("state")]
            public global::GitHub.Repos.Item.Item.SecretScanning.Alerts.GetStateQueryParameterType? State { get; set; }
            /// <summary>A comma-separated list of validities that, when present, will return alerts that match the validities in this list. Valid options are `active`, `inactive`, and `unknown`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("validity")]
            public string? Validity { get; set; }
#nullable restore
#else
            [QueryParameter("validity")]
            public string Validity { get; set; }
#endif
        }
    }
}
#pragma warning restore CS0618
