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
namespace GitHub.Scim.V2.Enterprises.Item.Users.Item {
    /// <summary>
    /// Builds and executes requests for operations under \scim\v2\enterprises\{enterprise}\Users\{scim_user_id}
    /// </summary>
    public class WithScim_user_ItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="WithScim_user_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithScim_user_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/scim/v2/enterprises/{enterprise}/Users/{scim_user_id}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithScim_user_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithScim_user_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/scim/v2/enterprises/{enterprise}/Users/{scim_user_id}", rawUrl)
        {
        }
        /// <summary>
        /// &gt; [!NOTE]&gt; The SCIM API endpoints for enterprise accounts are currently in *private* beta and are subject to change.Permanently suspends a SCIM user from an enterprise, removes all data for the user, obfuscates the login, email, and display name of the user, removes all external-identity SCIM attributes, and deletes the emails, avatar, PATs, SSH keys, OAuth authorizations credentials, GPG keys, and SAML mappings for the user. You will not be able to undo this action.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.10/rest/enterprise-admin/scim#delete-a-scim-user-from-an-enterprise" />
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
        /// &gt; [!NOTE]&gt; The SCIM API endpoints for enterprise accounts are currently in *private* beta and are subject to change.Gets information about a SCIM user.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.10/rest/enterprise-admin/scim#get-scim-provisioning-information-for-an-enterprise-user" />
        /// </summary>
        /// <returns>A <see cref="ScimEnterpriseUserResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ScimError">When receiving a 400 status code</exception>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
        /// <exception cref="ScimError">When receiving a 429 status code</exception>
        /// <exception cref="ScimError">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ScimEnterpriseUserResponse?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<ScimEnterpriseUserResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
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
            return await RequestAdapter.SendAsync<ScimEnterpriseUserResponse>(requestInfo, ScimEnterpriseUserResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// &gt; [!NOTE]&gt; The SCIM API endpoints for enterprise accounts are currently in *private* beta and are subject to change.Update a provisioned user&apos;s individual attributes.To change a user&apos;s values, you must provide a specific `Operations` JSON format that contains at least one of the `add`, `remove`, or `replace` operations. For examples and more information on the SCIM operations format, see the [SCIM specification](https://tools.ietf.org/html/rfc7644#section-3.5.2).&gt; [!NOTE]&gt; Complicated SCIM `path` selectors that include filters are not supported. For example, a `path` selector defined as `&quot;path&quot;: &quot;emails[type eq \&quot;work\&quot;]&quot;` will not work.&gt; [!WARNING]&gt; Setting `active: false` will suspend a user and obfuscate the user handle and user email. Since the implementation is a generic SCIM implementation and does not differentiate yet between different IdP providers, for Okta, the user GDPR data will not be purged and the credentials will not be removed.&gt; ```&gt; {&gt;   &quot;Operations&quot;:[{&gt;     &quot;op&quot;:&quot;replace&quot;,&gt;     &quot;value&quot;:{&gt;       &quot;active&quot;:false&gt;     }&gt;   }]&gt; }&gt; ```
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.10/rest/enterprise-admin/scim#update-an-attribute-for-a-scim-enterprise-user" />
        /// </summary>
        /// <returns>A <see cref="ScimEnterpriseUserResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ScimError">When receiving a 400 status code</exception>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
        /// <exception cref="ScimError">When receiving a 429 status code</exception>
        /// <exception cref="ScimError">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ScimEnterpriseUserResponse?> PatchAsync(PatchSchema body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<ScimEnterpriseUserResponse> PatchAsync(PatchSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
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
            return await RequestAdapter.SendAsync<ScimEnterpriseUserResponse>(requestInfo, ScimEnterpriseUserResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// &gt; [!NOTE]&gt; The SCIM API endpoints for enterprise accounts are currently in *private* beta and are subject to change.Replaces an existing provisioned user&apos;s information.You must provide all the information required for the user as if you were provisioning them for the first time. Any existing user information that you don&apos;t provide will be removed. If you want to only update a specific attribute, use the [Update an attribute for a SCIM user](#update-an-attribute-for-a-scim-enterprise-user) endpoint instead.&gt; [!WARNING]&gt; Setting `active: false` will suspend a user and obfuscate the user handle and user email. Since the implementation is a generic SCIM implementation and does not differentiate yet between different IdP providers, for Okta, the user GDPR data will not be purged and the credentials will not be removed.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.10/rest/enterprise-admin/scim#set-scim-information-for-a-provisioned-enterprise-user" />
        /// </summary>
        /// <returns>A <see cref="ScimEnterpriseUserResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ScimError">When receiving a 400 status code</exception>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
        /// <exception cref="ScimError">When receiving a 429 status code</exception>
        /// <exception cref="ScimError">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ScimEnterpriseUserResponse?> PutAsync(GitHub.Models.User body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<ScimEnterpriseUserResponse> PutAsync(GitHub.Models.User body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
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
            return await RequestAdapter.SendAsync<ScimEnterpriseUserResponse>(requestInfo, ScimEnterpriseUserResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// &gt; [!NOTE]&gt; The SCIM API endpoints for enterprise accounts are currently in *private* beta and are subject to change.Permanently suspends a SCIM user from an enterprise, removes all data for the user, obfuscates the login, email, and display name of the user, removes all external-identity SCIM attributes, and deletes the emails, avatar, PATs, SSH keys, OAuth authorizations credentials, GPG keys, and SAML mappings for the user. You will not be able to undo this action.
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
        /// &gt; [!NOTE]&gt; The SCIM API endpoints for enterprise accounts are currently in *private* beta and are subject to change.Gets information about a SCIM user.
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
            requestInfo.Headers.TryAdd("Accept", "application/scim+json");
            return requestInfo;
        }
        /// <summary>
        /// &gt; [!NOTE]&gt; The SCIM API endpoints for enterprise accounts are currently in *private* beta and are subject to change.Update a provisioned user&apos;s individual attributes.To change a user&apos;s values, you must provide a specific `Operations` JSON format that contains at least one of the `add`, `remove`, or `replace` operations. For examples and more information on the SCIM operations format, see the [SCIM specification](https://tools.ietf.org/html/rfc7644#section-3.5.2).&gt; [!NOTE]&gt; Complicated SCIM `path` selectors that include filters are not supported. For example, a `path` selector defined as `&quot;path&quot;: &quot;emails[type eq \&quot;work\&quot;]&quot;` will not work.&gt; [!WARNING]&gt; Setting `active: false` will suspend a user and obfuscate the user handle and user email. Since the implementation is a generic SCIM implementation and does not differentiate yet between different IdP providers, for Okta, the user GDPR data will not be purged and the credentials will not be removed.&gt; ```&gt; {&gt;   &quot;Operations&quot;:[{&gt;     &quot;op&quot;:&quot;replace&quot;,&gt;     &quot;value&quot;:{&gt;       &quot;active&quot;:false&gt;     }&gt;   }]&gt; }&gt; ```
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
        /// &gt; [!NOTE]&gt; The SCIM API endpoints for enterprise accounts are currently in *private* beta and are subject to change.Replaces an existing provisioned user&apos;s information.You must provide all the information required for the user as if you were provisioning them for the first time. Any existing user information that you don&apos;t provide will be removed. If you want to only update a specific attribute, use the [Update an attribute for a SCIM user](#update-an-attribute-for-a-scim-enterprise-user) endpoint instead.&gt; [!WARNING]&gt; Setting `active: false` will suspend a user and obfuscate the user handle and user email. Since the implementation is a generic SCIM implementation and does not differentiate yet between different IdP providers, for Okta, the user GDPR data will not be purged and the credentials will not be removed.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(GitHub.Models.User body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(GitHub.Models.User body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="WithScim_user_ItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public WithScim_user_ItemRequestBuilder WithUrl(string rawUrl)
        {
            return new WithScim_user_ItemRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
