// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Models;
using GitHub.Users.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Users
{
    /// <summary>
    /// Builds and executes requests for operations under \users
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class UsersRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the GitHub.users.item collection</summary>
        /// <param name="position">The handle for the GitHub user account.</param>
        /// <returns>A <see cref="global::GitHub.Users.Item.WithUsernameItemRequestBuilder"/></returns>
        public global::GitHub.Users.Item.WithUsernameItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("username", position);
                return new global::GitHub.Users.Item.WithUsernameItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Users.UsersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UsersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users{?per_page*,since*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Users.UsersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UsersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users{?per_page*,since*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists all users, in the order that they signed up on GitHub Enterprise Server. This list includes personal user accounts and organization accounts.Note: Pagination is powered exclusively by the `since` parameter. Use the [Link header](https://docs.github.com/enterprise-server@3.13/rest/guides/using-pagination-in-the-rest-api#using-link-headers) to get the URL for the next page of users.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.13/rest/users/users#list-users" />
        /// </summary>
        /// <returns>A List&lt;global::GitHub.Models.SimpleUser&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::GitHub.Models.SimpleUser>?> GetAsync(Action<RequestConfiguration<global::GitHub.Users.UsersRequestBuilder.UsersRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::GitHub.Models.SimpleUser>> GetAsync(Action<RequestConfiguration<global::GitHub.Users.UsersRequestBuilder.UsersRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::GitHub.Models.SimpleUser>(requestInfo, global::GitHub.Models.SimpleUser.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Lists all users, in the order that they signed up on GitHub Enterprise Server. This list includes personal user accounts and organization accounts.Note: Pagination is powered exclusively by the `since` parameter. Use the [Link header](https://docs.github.com/enterprise-server@3.13/rest/guides/using-pagination-in-the-rest-api#using-link-headers) to get the URL for the next page of users.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Users.UsersRequestBuilder.UsersRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Users.UsersRequestBuilder.UsersRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Users.UsersRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Users.UsersRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Users.UsersRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists all users, in the order that they signed up on GitHub Enterprise Server. This list includes personal user accounts and organization accounts.Note: Pagination is powered exclusively by the `since` parameter. Use the [Link header](https://docs.github.com/enterprise-server@3.13/rest/guides/using-pagination-in-the-rest-api#using-link-headers) to get the URL for the next page of users.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class UsersRequestBuilderGetQueryParameters 
        {
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.13/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>A user ID. Only return users with an ID greater than this ID.</summary>
            [QueryParameter("since")]
            public int? Since { get; set; }
        }
    }
}
#pragma warning restore CS0618
