// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Models;
using GitHub.Repos.Item.Item.Collaborators.Item.Permission;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Repos.Item.Item.Collaborators.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\collaborators\{username}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class WithUsernameItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The permission property</summary>
        public global::GitHub.Repos.Item.Item.Collaborators.Item.Permission.PermissionRequestBuilder Permission
        {
            get => new global::GitHub.Repos.Item.Item.Collaborators.Item.Permission.PermissionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Collaborators.Item.WithUsernameItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithUsernameItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/collaborators/{username}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Collaborators.Item.WithUsernameItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithUsernameItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/collaborators/{username}", rawUrl)
        {
        }
        /// <summary>
        /// Removes a collaborator from a repository.To use this endpoint, the authenticated user must either be an administrator of the repository or target themselves for removal.This endpoint also:- Cancels any outstanding invitations- Unasigns the user from any issues- Removes access to organization projects if the user is not an organization member and is not a collaborator on any other organization repositories.- Unstars the repository- Updates access permissions to packagesRemoving a user as a collaborator has the following effects on forks: - If the user had access to a fork through their membership to this repository, the user will also be removed from the fork. - If the user had their own fork of the repository, the fork will be deleted. - If the user still has read access to the repository, open pull requests by this user from a fork will be denied.&gt; [!NOTE]&gt; A user can still have access to the repository through organization permissions like base repository permissions.Although the API responds immediately, the additional permission updates might take some extra time to complete in the background.For more information on fork permissions, see &quot;[About permissions and visibility of forks](https://docs.github.com/enterprise-server@3.14/pull-requests/collaborating-with-pull-requests/working-with-forks/about-permissions-and-visibility-of-forks)&quot;.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.14/rest/collaborators/collaborators#remove-a-repository-collaborator" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 403 status code</exception>
        /// <exception cref="global::GitHub.Models.ValidationError">When receiving a 422 status code</exception>
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
                { "403", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "422", global::GitHub.Models.ValidationError.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// For organization-owned repositories, the list of collaborators includes outside collaborators, organization members that are direct collaborators, organization members with access through team memberships, organization members with access through default organization permissions, and organization owners.Team members will include the members of child teams.The authenticated user must have push access to the repository to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `read:org` and `repo` scopes to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.14/rest/collaborators/collaborators#check-if-a-user-is-a-repository-collaborator" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// This endpoint triggers [notifications](https://docs.github.com/enterprise-server@3.14/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. For more information, see &quot;[Rate limits for the API](https://docs.github.com/enterprise-server@3.14/rest/using-the-rest-api/rate-limits-for-the-rest-api#about-secondary-rate-limits)&quot; and &quot;[Best practices for using the REST API](https://docs.github.com/enterprise-server@3.14/rest/guides/best-practices-for-using-the-rest-api).&quot;Adding an outside collaborator may be restricted by enterprise administrators. For more information, see &quot;[Enforcing repository management policies in your enterprise](https://docs.github.com/enterprise-server@3.14/admin/policies/enforcing-policies-for-your-enterprise/enforcing-repository-management-policies-in-your-enterprise#enforcing-a-policy-for-inviting-outside-collaborators-to-repositories).&quot;For more information on permission levels, see &quot;[Repository permission levels for an organization](https://docs.github.com/enterprise-server@3.14/github/setting-up-and-managing-organizations-and-teams/repository-permission-levels-for-an-organization#permission-levels-for-repositories-owned-by-an-organization)&quot;. There are restrictions on which permissions can be granted to organization members when an organization base role is in place. In this case, the permission being given must be equal to or higher than the org base permission. Otherwise, the request will fail with:```Cannot assign {member} permission of {role name}```Note that, if you choose not to pass any parameters, you&apos;ll need to set `Content-Length` to zero when calling out to this endpoint. For more information, see &quot;[HTTP method](https://docs.github.com/enterprise-server@3.14/rest/guides/getting-started-with-the-rest-api#http-method).&quot;**Updating an existing collaborator&apos;s permission level**The endpoint can also be used to change the permissions of an existing collaborator without first removing and re-adding the collaborator. To change the permissions, use the same endpoint and pass a different `permission` parameter. The response will be a `204`, with no other indication that the permission level changed.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.14/rest/collaborators/collaborators#add-a-repository-collaborator" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 403 status code</exception>
        /// <exception cref="global::GitHub.Models.ValidationError">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PutAsync(global::GitHub.Repos.Item.Item.Collaborators.Item.WithUsernamePutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task PutAsync(global::GitHub.Repos.Item.Item.Collaborators.Item.WithUsernamePutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "403", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "422", global::GitHub.Models.ValidationError.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Removes a collaborator from a repository.To use this endpoint, the authenticated user must either be an administrator of the repository or target themselves for removal.This endpoint also:- Cancels any outstanding invitations- Unasigns the user from any issues- Removes access to organization projects if the user is not an organization member and is not a collaborator on any other organization repositories.- Unstars the repository- Updates access permissions to packagesRemoving a user as a collaborator has the following effects on forks: - If the user had access to a fork through their membership to this repository, the user will also be removed from the fork. - If the user had their own fork of the repository, the fork will be deleted. - If the user still has read access to the repository, open pull requests by this user from a fork will be denied.&gt; [!NOTE]&gt; A user can still have access to the repository through organization permissions like base repository permissions.Although the API responds immediately, the additional permission updates might take some extra time to complete in the background.For more information on fork permissions, see &quot;[About permissions and visibility of forks](https://docs.github.com/enterprise-server@3.14/pull-requests/collaborating-with-pull-requests/working-with-forks/about-permissions-and-visibility-of-forks)&quot;.
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
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// For organization-owned repositories, the list of collaborators includes outside collaborators, organization members that are direct collaborators, organization members with access through team memberships, organization members with access through default organization permissions, and organization owners.Team members will include the members of child teams.The authenticated user must have push access to the repository to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `read:org` and `repo` scopes to use this endpoint.
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
            return requestInfo;
        }
        /// <summary>
        /// This endpoint triggers [notifications](https://docs.github.com/enterprise-server@3.14/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. For more information, see &quot;[Rate limits for the API](https://docs.github.com/enterprise-server@3.14/rest/using-the-rest-api/rate-limits-for-the-rest-api#about-secondary-rate-limits)&quot; and &quot;[Best practices for using the REST API](https://docs.github.com/enterprise-server@3.14/rest/guides/best-practices-for-using-the-rest-api).&quot;Adding an outside collaborator may be restricted by enterprise administrators. For more information, see &quot;[Enforcing repository management policies in your enterprise](https://docs.github.com/enterprise-server@3.14/admin/policies/enforcing-policies-for-your-enterprise/enforcing-repository-management-policies-in-your-enterprise#enforcing-a-policy-for-inviting-outside-collaborators-to-repositories).&quot;For more information on permission levels, see &quot;[Repository permission levels for an organization](https://docs.github.com/enterprise-server@3.14/github/setting-up-and-managing-organizations-and-teams/repository-permission-levels-for-an-organization#permission-levels-for-repositories-owned-by-an-organization)&quot;. There are restrictions on which permissions can be granted to organization members when an organization base role is in place. In this case, the permission being given must be equal to or higher than the org base permission. Otherwise, the request will fail with:```Cannot assign {member} permission of {role name}```Note that, if you choose not to pass any parameters, you&apos;ll need to set `Content-Length` to zero when calling out to this endpoint. For more information, see &quot;[HTTP method](https://docs.github.com/enterprise-server@3.14/rest/guides/getting-started-with-the-rest-api#http-method).&quot;**Updating an existing collaborator&apos;s permission level**The endpoint can also be used to change the permissions of an existing collaborator without first removing and re-adding the collaborator. To change the permissions, use the same endpoint and pass a different `permission` parameter. The response will be a `204`, with no other indication that the permission level changed.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(global::GitHub.Repos.Item.Item.Collaborators.Item.WithUsernamePutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(global::GitHub.Repos.Item.Item.Collaborators.Item.WithUsernamePutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Collaborators.Item.WithUsernameItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Repos.Item.Item.Collaborators.Item.WithUsernameItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Repos.Item.Item.Collaborators.Item.WithUsernameItemRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
