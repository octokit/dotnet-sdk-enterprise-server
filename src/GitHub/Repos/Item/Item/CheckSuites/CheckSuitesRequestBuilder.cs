// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Models;
using GitHub.Repos.Item.Item.CheckSuites.Item;
using GitHub.Repos.Item.Item.CheckSuites.Preferences;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Repos.Item.Item.CheckSuites
{
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\check-suites
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class CheckSuitesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The preferences property</summary>
        public global::GitHub.Repos.Item.Item.CheckSuites.Preferences.PreferencesRequestBuilder Preferences
        {
            get => new global::GitHub.Repos.Item.Item.CheckSuites.Preferences.PreferencesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the GitHub.repos.item.item.checkSuites.item collection</summary>
        /// <param name="position">The unique identifier of the check suite.</param>
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.CheckSuites.Item.WithCheck_suite_ItemRequestBuilder"/></returns>
        public global::GitHub.Repos.Item.Item.CheckSuites.Item.WithCheck_suite_ItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("check_suite_id", position);
                return new global::GitHub.Repos.Item.Item.CheckSuites.Item.WithCheck_suite_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.CheckSuites.CheckSuitesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CheckSuitesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/check-suites", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.CheckSuites.CheckSuitesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CheckSuitesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/check-suites", rawUrl)
        {
        }
        /// <summary>
        /// Creates a check suite manually. By default, check suites are automatically created when you create a [check run](https://docs.github.com/enterprise-server@3.13/rest/checks/runs). You only need to use this endpoint for manually creating check suites when you&apos;ve disabled automatic creation using &quot;[Update repository preferences for check suites](https://docs.github.com/enterprise-server@3.13/rest/checks/suites#update-repository-preferences-for-check-suites)&quot;.&gt; [!NOTE]&gt; The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array and a `null` value for `head_branch`.OAuth apps and personal access tokens (classic) cannot use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.13/rest/checks/suites#create-a-check-suite" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.CheckSuite"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.CheckSuite?> PostAsync(global::GitHub.Repos.Item.Item.CheckSuites.CheckSuitesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.CheckSuite> PostAsync(global::GitHub.Repos.Item.Item.CheckSuites.CheckSuitesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::GitHub.Models.CheckSuite>(requestInfo, global::GitHub.Models.CheckSuite.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a check suite manually. By default, check suites are automatically created when you create a [check run](https://docs.github.com/enterprise-server@3.13/rest/checks/runs). You only need to use this endpoint for manually creating check suites when you&apos;ve disabled automatic creation using &quot;[Update repository preferences for check suites](https://docs.github.com/enterprise-server@3.13/rest/checks/suites#update-repository-preferences-for-check-suites)&quot;.&gt; [!NOTE]&gt; The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array and a `null` value for `head_branch`.OAuth apps and personal access tokens (classic) cannot use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::GitHub.Repos.Item.Item.CheckSuites.CheckSuitesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::GitHub.Repos.Item.Item.CheckSuites.CheckSuitesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.CheckSuites.CheckSuitesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Repos.Item.Item.CheckSuites.CheckSuitesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Repos.Item.Item.CheckSuites.CheckSuitesRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
