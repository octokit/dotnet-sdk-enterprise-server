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
namespace GitHub.Authorizations.Clients.Item.Item {
    /// <summary>
    /// Builds and executes requests for operations under \authorizations\clients\{client_id}\{fingerprint}
    /// </summary>
    public class WithFingerprintItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="WithFingerprintItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithFingerprintItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/authorizations/clients/{client_id}/{fingerprint}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithFingerprintItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithFingerprintItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/authorizations/clients/{client_id}/{fingerprint}", rawUrl)
        {
        }
        /// <summary>
        /// &gt; [!WARNING]&gt; **Deprecation notice:** GitHub Enterprise Server will discontinue the [OAuth Authorizations API](https://docs.github.com/enterprise-server@3.11/rest/oauth-authorizations/oauth-authorizations/), which is used by integrations to create personal access tokens and OAuth tokens, and you must now create these tokens using our [web application flow](https://docs.github.com/enterprise-server@3.11/developers/apps/authorizing-oauth-apps#web-application-flow). The [OAuth Authorizations API](https://docs.github.com/enterprise-server@3.11/rest/oauth-authorizations/oauth-authorizations) will be removed on November 13, 2020. For more information, including scheduled brownouts, see the [blog post](https://developer.github.com/changes/2020-02-14-deprecating-oauth-auth-endpoint/).&gt; [!WARNING]&gt; Apps must use the [web application flow](https://docs.github.com/enterprise-server@3.11/apps/building-oauth-apps/authorizing-oauth-apps/#web-application-flow) to obtain OAuth tokens that work with GitHub Enterprise Server SAML organizations. OAuth tokens created using the Authorizations API will be unable to access GitHub Enterprise Server SAML organizations. For more information, see the [blog post](https://developer.github.com/changes/2019-11-05-deprecated-passwords-and-authorizations-api).This method will create a new authorization for the specified OAuth application, only if an authorization for that application and fingerprint do not already exist for the user. The URL includes the 20 character client ID for the OAuth app that is requesting the token. `fingerprint` is a unique string to distinguish an authorization from others created for the same client ID and user. It returns the user&apos;s existing authorization for the application if one is present. Otherwise, it creates and returns a new one.If you have two-factor authentication setup, Basic Authentication for this endpoint requires that you use a one-time password (OTP) and your username and password instead of tokens. For more information, see &quot;[Working with two-factor authentication](https://docs.github.com/enterprise-server@3.11/rest/overview/other-authentication-methods#working-with-two-factor-authentication).&quot;
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.11/rest/oauth-authorizations/oauth-authorizations#get-or-create-an-authorization-for-a-specific-app-and-fingerprint" />
        /// </summary>
        /// <returns>A <see cref="Authorization"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ValidationError">When receiving a 422 status code</exception>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Authorization?> PutAsync(WithFingerprintPutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Authorization> PutAsync(WithFingerprintPutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"422", ValidationError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Authorization>(requestInfo, Authorization.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// &gt; [!WARNING]&gt; **Deprecation notice:** GitHub Enterprise Server will discontinue the [OAuth Authorizations API](https://docs.github.com/enterprise-server@3.11/rest/oauth-authorizations/oauth-authorizations/), which is used by integrations to create personal access tokens and OAuth tokens, and you must now create these tokens using our [web application flow](https://docs.github.com/enterprise-server@3.11/developers/apps/authorizing-oauth-apps#web-application-flow). The [OAuth Authorizations API](https://docs.github.com/enterprise-server@3.11/rest/oauth-authorizations/oauth-authorizations) will be removed on November 13, 2020. For more information, including scheduled brownouts, see the [blog post](https://developer.github.com/changes/2020-02-14-deprecating-oauth-auth-endpoint/).&gt; [!WARNING]&gt; Apps must use the [web application flow](https://docs.github.com/enterprise-server@3.11/apps/building-oauth-apps/authorizing-oauth-apps/#web-application-flow) to obtain OAuth tokens that work with GitHub Enterprise Server SAML organizations. OAuth tokens created using the Authorizations API will be unable to access GitHub Enterprise Server SAML organizations. For more information, see the [blog post](https://developer.github.com/changes/2019-11-05-deprecated-passwords-and-authorizations-api).This method will create a new authorization for the specified OAuth application, only if an authorization for that application and fingerprint do not already exist for the user. The URL includes the 20 character client ID for the OAuth app that is requesting the token. `fingerprint` is a unique string to distinguish an authorization from others created for the same client ID and user. It returns the user&apos;s existing authorization for the application if one is present. Otherwise, it creates and returns a new one.If you have two-factor authentication setup, Basic Authentication for this endpoint requires that you use a one-time password (OTP) and your username and password instead of tokens. For more information, see &quot;[Working with two-factor authentication](https://docs.github.com/enterprise-server@3.11/rest/overview/other-authentication-methods#working-with-two-factor-authentication).&quot;
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(WithFingerprintPutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(WithFingerprintPutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="WithFingerprintItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        [Obsolete("")]
        public WithFingerprintItemRequestBuilder WithUrl(string rawUrl)
        {
            return new WithFingerprintItemRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
