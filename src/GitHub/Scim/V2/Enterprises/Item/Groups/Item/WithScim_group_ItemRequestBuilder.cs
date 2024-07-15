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
namespace GitHub.Scim.V2.Enterprises.Item.Groups.Item {
    /// <summary>
    /// Builds and executes requests for operations under \scim\v2\enterprises\{enterprise}\Groups\{scim_group_id}
    /// </summary>
    public class WithScim_group_ItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="WithScim_group_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithScim_group_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/scim/v2/enterprises/{enterprise}/Groups/{scim_group_id}{?excludedAttributes*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithScim_group_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithScim_group_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/scim/v2/enterprises/{enterprise}/Groups/{scim_group_id}{?excludedAttributes*}", rawUrl)
        {
        }
        /// <summary>
        /// **Note:** The SCIM API endpoints for enterprise accounts are currently in *private* beta and are subject to change. Deletes a SCIM group from an enterprise.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.11/rest/enterprise-admin/scim#delete-a-scim-group-from-an-enterprise" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ScimError">When receiving a 400 status code</exception>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
        /// <exception cref="ScimError">When receiving a 429 status code</exception>
        /// <exception cref="ScimError">When receiving a 500 status code</exception>
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
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"400", ScimError.CreateFromDiscriminatorValue},
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"429", ScimError.CreateFromDiscriminatorValue},
                {"500", ScimError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// **Note:** The SCIM API endpoints for enterprise accounts are currently in *private* beta and are subject to change.Gets information about a SCIM group.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.11/rest/enterprise-admin/scim#get-scim-provisioning-information-for-an-enterprise-group" />
        /// </summary>
        /// <returns>A <see cref="ScimEnterpriseGroupResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ScimError">When receiving a 400 status code</exception>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
        /// <exception cref="ScimError">When receiving a 429 status code</exception>
        /// <exception cref="ScimError">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ScimEnterpriseGroupResponse?> GetAsync(Action<RequestConfiguration<WithScim_group_ItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<ScimEnterpriseGroupResponse> GetAsync(Action<RequestConfiguration<WithScim_group_ItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"400", ScimError.CreateFromDiscriminatorValue},
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"429", ScimError.CreateFromDiscriminatorValue},
                {"500", ScimError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ScimEnterpriseGroupResponse>(requestInfo, ScimEnterpriseGroupResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// **Note:** The SCIM API endpoints for enterprise accounts are currently in *private* beta and are subject to change.Update a provisioned group’s individual attributes.To change a group’s values, you must provide a specific Operations JSON format that contains at least one of the add, remove, or replace operations. For examples and more information on the SCIM operations format, see the [SCIM specification](https://tools.ietf.org/html/rfc7644#section-3.5.2).  Update can also be used to add group memberships.Group memberships can be sent one at a time or in batches for faster performance. **Note**: The memberships are referenced through a local user `id`, and the user will need to be created before they are referenced here.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.11/rest/enterprise-admin/scim#update-an-attribute-for-a-scim-enterprise-group" />
        /// </summary>
        /// <returns>A <see cref="ScimEnterpriseGroupResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ScimError">When receiving a 400 status code</exception>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
        /// <exception cref="ScimError">When receiving a 429 status code</exception>
        /// <exception cref="ScimError">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ScimEnterpriseGroupResponse?> PatchAsync(PatchSchema body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<ScimEnterpriseGroupResponse> PatchAsync(PatchSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"400", ScimError.CreateFromDiscriminatorValue},
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"429", ScimError.CreateFromDiscriminatorValue},
                {"500", ScimError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ScimEnterpriseGroupResponse>(requestInfo, ScimEnterpriseGroupResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// **Note:** The SCIM API endpoints for enterprise accounts are currently in *private* beta and are subject to change.Replaces an existing provisioned group’s information.You must provide all the information required for the group as if you were provisioning it for the first time. Any existing group information that you don&apos;t provide will be removed, including group membership. If you want to only update a specific attribute, use the [Update an attribute for a SCIM enterprise group](#update-an-attribute-for-a-scim-enterprise-group) endpoint instead.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.11/rest/enterprise-admin/scim#set-scim-information-for-a-provisioned-enterprise-group" />
        /// </summary>
        /// <returns>A <see cref="ScimEnterpriseGroupResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ScimError">When receiving a 400 status code</exception>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
        /// <exception cref="ScimError">When receiving a 429 status code</exception>
        /// <exception cref="ScimError">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ScimEnterpriseGroupResponse?> PutAsync(Group body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<ScimEnterpriseGroupResponse> PutAsync(Group body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"400", ScimError.CreateFromDiscriminatorValue},
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"429", ScimError.CreateFromDiscriminatorValue},
                {"500", ScimError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ScimEnterpriseGroupResponse>(requestInfo, ScimEnterpriseGroupResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// **Note:** The SCIM API endpoints for enterprise accounts are currently in *private* beta and are subject to change. Deletes a SCIM group from an enterprise.
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
            requestInfo.Headers.TryAdd("Accept", "application/json, application/scim+json");
            return requestInfo;
        }
        /// <summary>
        /// **Note:** The SCIM API endpoints for enterprise accounts are currently in *private* beta and are subject to change.Gets information about a SCIM group.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<WithScim_group_ItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<WithScim_group_ItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/scim+json");
            return requestInfo;
        }
        /// <summary>
        /// **Note:** The SCIM API endpoints for enterprise accounts are currently in *private* beta and are subject to change.Update a provisioned group’s individual attributes.To change a group’s values, you must provide a specific Operations JSON format that contains at least one of the add, remove, or replace operations. For examples and more information on the SCIM operations format, see the [SCIM specification](https://tools.ietf.org/html/rfc7644#section-3.5.2).  Update can also be used to add group memberships.Group memberships can be sent one at a time or in batches for faster performance. **Note**: The memberships are referenced through a local user `id`, and the user will need to be created before they are referenced here.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(PatchSchema body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(PatchSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/scim+json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// **Note:** The SCIM API endpoints for enterprise accounts are currently in *private* beta and are subject to change.Replaces an existing provisioned group’s information.You must provide all the information required for the group as if you were provisioning it for the first time. Any existing group information that you don&apos;t provide will be removed, including group membership. If you want to only update a specific attribute, use the [Update an attribute for a SCIM enterprise group](#update-an-attribute-for-a-scim-enterprise-group) endpoint instead.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(Group body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(Group body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/scim+json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="WithScim_group_ItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public WithScim_group_ItemRequestBuilder WithUrl(string rawUrl)
        {
            return new WithScim_group_ItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// **Note:** The SCIM API endpoints for enterprise accounts are currently in *private* beta and are subject to change.Gets information about a SCIM group.
        /// </summary>
        public class WithScim_group_ItemRequestBuilderGetQueryParameters 
        {
            /// <summary>Excludes the specified attribute from being returned in the results. Using this parameter can speed up response time.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("excludedAttributes")]
            public string? ExcludedAttributes { get; set; }
#nullable restore
#else
            [QueryParameter("excludedAttributes")]
            public string ExcludedAttributes { get; set; }
#endif
        }
    }
}
