// <auto-generated/>
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Orgs.Item.Hooks.Item.Config {
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\hooks\{hook_id}\config
    /// </summary>
    public class ConfigRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="ConfigRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ConfigRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/hooks/{hook_id}/config", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="ConfigRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ConfigRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/hooks/{hook_id}/config", rawUrl)
        {
        }
        /// <summary>
        /// Returns the webhook configuration for an organization. To get more information about the webhook, including the `active` state and `events`, use &quot;[Get an organization webhook ](/rest/orgs/webhooks#get-an-organization-webhook).&quot;You must be an organization owner to use this endpoint.OAuth app tokens and personal access tokens (classic) need `admin:org_hook` scope. OAuth apps cannot list, view, or editwebhooks that they did not create and users cannot list, view, or edit webhooks that were created by OAuth apps.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.12/rest/orgs/webhooks#get-a-webhook-configuration-for-an-organization" />
        /// </summary>
        /// <returns>A <see cref="WebhookConfig"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<WebhookConfig?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<WebhookConfig> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<WebhookConfig>(requestInfo, WebhookConfig.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Updates the webhook configuration for an organization. To update more information about the webhook, including the `active` state and `events`, use &quot;[Update an organization webhook ](/rest/orgs/webhooks#update-an-organization-webhook).&quot;You must be an organization owner to use this endpoint.OAuth app tokens and personal access tokens (classic) need `admin:org_hook` scope. OAuth apps cannot list, view, or editwebhooks that they did not create and users cannot list, view, or edit webhooks that were created by OAuth apps.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.12/rest/orgs/webhooks#update-a-webhook-configuration-for-an-organization" />
        /// </summary>
        /// <returns>A <see cref="WebhookConfig"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<WebhookConfig?> PatchAsync(ConfigPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<WebhookConfig> PatchAsync(ConfigPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<WebhookConfig>(requestInfo, WebhookConfig.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns the webhook configuration for an organization. To get more information about the webhook, including the `active` state and `events`, use &quot;[Get an organization webhook ](/rest/orgs/webhooks#get-an-organization-webhook).&quot;You must be an organization owner to use this endpoint.OAuth app tokens and personal access tokens (classic) need `admin:org_hook` scope. OAuth apps cannot list, view, or editwebhooks that they did not create and users cannot list, view, or edit webhooks that were created by OAuth apps.
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
        /// Updates the webhook configuration for an organization. To update more information about the webhook, including the `active` state and `events`, use &quot;[Update an organization webhook ](/rest/orgs/webhooks#update-an-organization-webhook).&quot;You must be an organization owner to use this endpoint.OAuth app tokens and personal access tokens (classic) need `admin:org_hook` scope. OAuth apps cannot list, view, or editwebhooks that they did not create and users cannot list, view, or edit webhooks that were created by OAuth apps.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(ConfigPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(ConfigPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="ConfigRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ConfigRequestBuilder WithUrl(string rawUrl)
        {
            return new ConfigRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
