// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Organizations.Item.Custom_roles {
    /// <summary>
    /// Builds and executes requests for operations under \organizations\{organization_id}\custom_roles
    /// </summary>
    public class Custom_rolesRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="Custom_rolesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Custom_rolesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/organizations/{organization_id}/custom_roles", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Custom_rolesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Custom_rolesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/organizations/{organization_id}/custom_roles", rawUrl)
        {
        }
        /// <summary>
        /// **Note**: This operation is deprecated and will be removed in the future.Use the &quot;[List custom repository roles](https://docs.github.com/enterprise-server@3.11/rest/orgs/custom-roles#list-custom-repository-roles-in-an-organization)&quot; endpoint instead.List the custom repository roles available in this organization. For more information on custom repository roles, see &quot;[About custom repository roles](https://docs.github.com/enterprise-server@3.11/organizations/managing-peoples-access-to-your-organization-with-roles/about-custom-repository-roles).&quot;The authenticated user must be administrator of the organization or of a repository of the organization to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `admin:org` or `repo` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.11/rest/orgs/custom-roles#deprecated---list-custom-repository-roles-in-an-organization" />
        /// </summary>
        /// <returns>A <see cref="Custom_rolesGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Custom_rolesGetResponse?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Custom_rolesGetResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<Custom_rolesGetResponse>(requestInfo, Custom_rolesGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// **Note**: This operation is deprecated and will be removed in the future.Use the &quot;[List custom repository roles](https://docs.github.com/enterprise-server@3.11/rest/orgs/custom-roles#list-custom-repository-roles-in-an-organization)&quot; endpoint instead.List the custom repository roles available in this organization. For more information on custom repository roles, see &quot;[About custom repository roles](https://docs.github.com/enterprise-server@3.11/organizations/managing-peoples-access-to-your-organization-with-roles/about-custom-repository-roles).&quot;The authenticated user must be administrator of the organization or of a repository of the organization to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `admin:org` or `repo` scope to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("")]
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
        /// <returns>A <see cref="Custom_rolesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        [Obsolete("")]
        public Custom_rolesRequestBuilder WithUrl(string rawUrl)
        {
            return new Custom_rolesRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
