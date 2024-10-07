// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Orgs.Item.Actions.Permissions.Repositories.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\actions\permissions\repositories\{repository_id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class WithRepository_ItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.Actions.Permissions.Repositories.Item.WithRepository_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithRepository_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/actions/permissions/repositories/{repository_id}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.Actions.Permissions.Repositories.Item.WithRepository_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithRepository_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/actions/permissions/repositories/{repository_id}", rawUrl)
        {
        }
        /// <summary>
        /// Removes a repository from the list of selected repositories that are enabled for GitHub Actions in an organization. To use this endpoint, the organization permission policy for `enabled_repositories` must be configured to `selected`. For more information, see &quot;[Set GitHub Actions permissions for an organization](#set-github-actions-permissions-for-an-organization).&quot;OAuth tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.13/rest/actions/permissions#disable-a-selected-repository-for-github-actions-in-an-organization" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Adds a repository to the list of selected repositories that are enabled for GitHub Actions in an organization. To use this endpoint, the organization permission policy for `enabled_repositories` must be must be configured to `selected`. For more information, see &quot;[Set GitHub Actions permissions for an organization](#set-github-actions-permissions-for-an-organization).&quot;OAuth tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.13/rest/actions/permissions#enable-a-selected-repository-for-github-actions-in-an-organization" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PutAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task PutAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToPutRequestInformation(requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Removes a repository from the list of selected repositories that are enabled for GitHub Actions in an organization. To use this endpoint, the organization permission policy for `enabled_repositories` must be configured to `selected`. For more information, see &quot;[Set GitHub Actions permissions for an organization](#set-github-actions-permissions-for-an-organization).&quot;OAuth tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            return requestInfo;
        }
        /// <summary>
        /// Adds a repository to the list of selected repositories that are enabled for GitHub Actions in an organization. To use this endpoint, the organization permission policy for `enabled_repositories` must be must be configured to `selected`. For more information, see &quot;[Set GitHub Actions permissions for an organization](#set-github-actions-permissions-for-an-organization).&quot;OAuth tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Orgs.Item.Actions.Permissions.Repositories.Item.WithRepository_ItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Orgs.Item.Actions.Permissions.Repositories.Item.WithRepository_ItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Orgs.Item.Actions.Permissions.Repositories.Item.WithRepository_ItemRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
