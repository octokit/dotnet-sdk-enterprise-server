// <auto-generated/>
using GitHub.Models;
using GitHub.Orgs.Item.CustomRepositoryRoles.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Orgs.Item.CustomRepositoryRoles {
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\custom-repository-roles
    /// </summary>
    public class CustomRepositoryRolesRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Gets an item from the GitHub.orgs.item.customRepositoryRoles.item collection</summary>
        /// <param name="position">The unique identifier of the role.</param>
        /// <returns>A <see cref="WithRole_ItemRequestBuilder"/></returns>
        public WithRole_ItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("role_id", position);
                return new WithRole_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="CustomRepositoryRolesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CustomRepositoryRolesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/custom-repository-roles", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="CustomRepositoryRolesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CustomRepositoryRolesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/custom-repository-roles", rawUrl)
        {
        }
        /// <summary>
        /// List the custom repository roles available in this organization. For more information on custom repository roles, see &quot;[About custom repository roles](https://docs.github.com/enterprise-server@3.10/organizations/managing-peoples-access-to-your-organization-with-roles/about-custom-repository-roles).&quot;The authenticated user must be an administrator of the organization or of a repository of the organization to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `admin:org` or `repo` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.10/rest/orgs/custom-roles#list-custom-repository-roles-in-an-organization" />
        /// </summary>
        /// <returns>A <see cref="CustomRepositoryRolesGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<CustomRepositoryRolesGetResponse?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<CustomRepositoryRolesGetResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<CustomRepositoryRolesGetResponse>(requestInfo, CustomRepositoryRolesGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a custom repository role that can be used by all repositories owned by the organization. For more information on custom repository roles, see &quot;[About custom repository roles](https://docs.github.com/enterprise-server@3.10/organizations/managing-peoples-access-to-your-organization-with-roles/about-custom-repository-roles).&quot;The authenticated user must be an administrator for the organization to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.10/rest/orgs/custom-roles#create-a-custom-repository-role" />
        /// </summary>
        /// <returns>A <see cref="OrganizationCustomRepositoryRole"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
        /// <exception cref="ValidationError">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<OrganizationCustomRepositoryRole?> PostAsync(OrganizationCustomRepositoryRoleCreateSchema body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<OrganizationCustomRepositoryRole> PostAsync(OrganizationCustomRepositoryRoleCreateSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"422", ValidationError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<OrganizationCustomRepositoryRole>(requestInfo, OrganizationCustomRepositoryRole.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List the custom repository roles available in this organization. For more information on custom repository roles, see &quot;[About custom repository roles](https://docs.github.com/enterprise-server@3.10/organizations/managing-peoples-access-to-your-organization-with-roles/about-custom-repository-roles).&quot;The authenticated user must be an administrator of the organization or of a repository of the organization to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `admin:org` or `repo` scope to use this endpoint.
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
        /// Creates a custom repository role that can be used by all repositories owned by the organization. For more information on custom repository roles, see &quot;[About custom repository roles](https://docs.github.com/enterprise-server@3.10/organizations/managing-peoples-access-to-your-organization-with-roles/about-custom-repository-roles).&quot;The authenticated user must be an administrator for the organization to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(OrganizationCustomRepositoryRoleCreateSchema body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(OrganizationCustomRepositoryRoleCreateSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="CustomRepositoryRolesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public CustomRepositoryRolesRequestBuilder WithUrl(string rawUrl)
        {
            return new CustomRepositoryRolesRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
