// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Models;
using GitHub.Scim.V2.Enterprises.Item.Users.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Scim.V2.Enterprises.Item.Users
{
    /// <summary>
    /// Builds and executes requests for operations under \scim\v2\enterprises\{enterprise}\Users
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class UsersRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the GitHub.scim.v2.enterprises.item.Users.item collection</summary>
        /// <param name="position">The unique identifier of the SCIM user.</param>
        /// <returns>A <see cref="global::GitHub.Scim.V2.Enterprises.Item.Users.Item.WithScim_user_ItemRequestBuilder"/></returns>
        public global::GitHub.Scim.V2.Enterprises.Item.Users.Item.WithScim_user_ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("scim_user_id", position);
                return new global::GitHub.Scim.V2.Enterprises.Item.Users.Item.WithScim_user_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Scim.V2.Enterprises.Item.Users.UsersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UsersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/scim/v2/enterprises/{enterprise}/Users{?count*,filter*,startIndex*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Scim.V2.Enterprises.Item.Users.UsersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UsersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/scim/v2/enterprises/{enterprise}/Users{?count*,filter*,startIndex*}", rawUrl)
        {
        }
        /// <summary>
        /// &gt; [!NOTE]&gt; The SCIM API endpoints for enterprise accounts are currently in *private* beta and are subject to change.Lists provisioned SCIM enterprise members.When a user with a SCIM-provisioned external identity is removed from an enterprise through a `patch` with `active` flag set to `false`, the account&apos;s metadata is preserved to allow the user to re-join the enterprise in the future. However, the user&apos;s account will be suspended and the user will not be able to sign-in. In order to permanently suspend the users account with no ability to re-join the enterprise in the future, use the `delete` request. Users that were not permanently deleted will be visible in the returned results.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.13/rest/enterprise-admin/scim#list-scim-provisioned-identities-for-an-enterprise" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.ScimEnterpriseUserList"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.ScimError">When receiving a 400 status code</exception>
        /// <exception cref="global::GitHub.Models.ScimError">When receiving a 429 status code</exception>
        /// <exception cref="global::GitHub.Models.ScimError">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.ScimEnterpriseUserList?> GetAsync(Action<RequestConfiguration<global::GitHub.Scim.V2.Enterprises.Item.Users.UsersRequestBuilder.UsersRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.ScimEnterpriseUserList> GetAsync(Action<RequestConfiguration<global::GitHub.Scim.V2.Enterprises.Item.Users.UsersRequestBuilder.UsersRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::GitHub.Models.ScimError.CreateFromDiscriminatorValue },
                { "429", global::GitHub.Models.ScimError.CreateFromDiscriminatorValue },
                { "500", global::GitHub.Models.ScimError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Models.ScimEnterpriseUserList>(requestInfo, global::GitHub.Models.ScimEnterpriseUserList.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// &gt; [!NOTE]&gt; The SCIM API endpoints for enterprise accounts are currently in *private* beta and are subject to change.Creates an external identity for a new SCIM enterprise user.SCIM does not authenticate users, it only provisions them. The authentication of users is done by SAML. However, when SCIM is enabled, all users need to be provisioned through SCIM before a user can sign in through SAML. The matching of a user to a SCIM provisioned user is done when the SAML assertion is consumed. The user will be matched on SAML response `NameID` to SCIM `userName`.When converting existing enterprise to use SCIM, the user handle (`userName`) from the SCIM payload will be used to match the provisioned user to an already existing user in the enterprise. Since the new identity record is created for newly provisioned users the matching for those records is done using a user&apos;s handle. Currently the matching will be performed to all of the users no matter if they were SAML JIT provisioned or created as local users.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.13/rest/enterprise-admin/scim#provision-a-scim-enterprise-user" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.ScimEnterpriseUserResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.ScimError">When receiving a 400 status code</exception>
        /// <exception cref="global::GitHub.Models.ScimError">When receiving a 429 status code</exception>
        /// <exception cref="global::GitHub.Models.ScimError">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.ScimEnterpriseUserResponse?> PostAsync(global::GitHub.Models.User body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.ScimEnterpriseUserResponse> PostAsync(global::GitHub.Models.User body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::GitHub.Models.ScimError.CreateFromDiscriminatorValue },
                { "429", global::GitHub.Models.ScimError.CreateFromDiscriminatorValue },
                { "500", global::GitHub.Models.ScimError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Models.ScimEnterpriseUserResponse>(requestInfo, global::GitHub.Models.ScimEnterpriseUserResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// &gt; [!NOTE]&gt; The SCIM API endpoints for enterprise accounts are currently in *private* beta and are subject to change.Lists provisioned SCIM enterprise members.When a user with a SCIM-provisioned external identity is removed from an enterprise through a `patch` with `active` flag set to `false`, the account&apos;s metadata is preserved to allow the user to re-join the enterprise in the future. However, the user&apos;s account will be suspended and the user will not be able to sign-in. In order to permanently suspend the users account with no ability to re-join the enterprise in the future, use the `delete` request. Users that were not permanently deleted will be visible in the returned results.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Scim.V2.Enterprises.Item.Users.UsersRequestBuilder.UsersRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Scim.V2.Enterprises.Item.Users.UsersRequestBuilder.UsersRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/scim+json");
            return requestInfo;
        }
        /// <summary>
        /// &gt; [!NOTE]&gt; The SCIM API endpoints for enterprise accounts are currently in *private* beta and are subject to change.Creates an external identity for a new SCIM enterprise user.SCIM does not authenticate users, it only provisions them. The authentication of users is done by SAML. However, when SCIM is enabled, all users need to be provisioned through SCIM before a user can sign in through SAML. The matching of a user to a SCIM provisioned user is done when the SAML assertion is consumed. The user will be matched on SAML response `NameID` to SCIM `userName`.When converting existing enterprise to use SCIM, the user handle (`userName`) from the SCIM payload will be used to match the provisioned user to an already existing user in the enterprise. Since the new identity record is created for newly provisioned users the matching for those records is done using a user&apos;s handle. Currently the matching will be performed to all of the users no matter if they were SAML JIT provisioned or created as local users.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::GitHub.Models.User body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::GitHub.Models.User body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/scim+json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Scim.V2.Enterprises.Item.Users.UsersRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Scim.V2.Enterprises.Item.Users.UsersRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Scim.V2.Enterprises.Item.Users.UsersRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// &gt; [!NOTE]&gt; The SCIM API endpoints for enterprise accounts are currently in *private* beta and are subject to change.Lists provisioned SCIM enterprise members.When a user with a SCIM-provisioned external identity is removed from an enterprise through a `patch` with `active` flag set to `false`, the account&apos;s metadata is preserved to allow the user to re-join the enterprise in the future. However, the user&apos;s account will be suspended and the user will not be able to sign-in. In order to permanently suspend the users account with no ability to re-join the enterprise in the future, use the `delete` request. Users that were not permanently deleted will be visible in the returned results.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class UsersRequestBuilderGetQueryParameters 
        {
            /// <summary>Used for pagination: the number of results to return per page.</summary>
            [QueryParameter("count")]
            public int? Count { get; set; }
            /// <summary>If specified, only results that match the specified filter will be returned. Multiple filters are not supported. Possible filters are `userName`, `externalId`, `id`, and `displayName`. For example, `?filter=&quot;externalId eq &apos;9138790-10932-109120392-12321&apos;&quot;`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter")]
            public string? Filter { get; set; }
#nullable restore
#else
            [QueryParameter("filter")]
            public string Filter { get; set; }
#endif
            /// <summary>Used for pagination: the starting index of the first result to return when paginating through values.</summary>
            [QueryParameter("startIndex")]
            public int? StartIndex { get; set; }
        }
    }
}
#pragma warning restore CS0618
