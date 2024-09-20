// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Repos.Item.Item.Collaborators.Item.Permission
{
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\collaborators\{username}\permission
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class PermissionRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Collaborators.Item.Permission.PermissionRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PermissionRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/collaborators/{username}/permission", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Collaborators.Item.Permission.PermissionRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PermissionRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/collaborators/{username}/permission", rawUrl)
        {
        }
        /// <summary>
        /// Checks the repository permission of a collaborator. The possible repositorypermissions are `admin`, `write`, `read`, and `none`.*Note*: The `permission` attribute provides the legacy base roles of `admin`, `write`, `read`, and `none`, where the`maintain` role is mapped to `write` and the `triage` role is mapped to `read`. To determine the role assigned to thecollaborator, see the `role_name` attribute, which will provide the full role name, including custom roles. The`permissions` hash can also be used to determine which base level of access the collaborator has to the repository.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.13/rest/collaborators/collaborators#get-repository-permissions-for-a-user" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.RepositoryCollaboratorPermission"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.RepositoryCollaboratorPermission?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.RepositoryCollaboratorPermission> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Models.RepositoryCollaboratorPermission>(requestInfo, global::GitHub.Models.RepositoryCollaboratorPermission.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Checks the repository permission of a collaborator. The possible repositorypermissions are `admin`, `write`, `read`, and `none`.*Note*: The `permission` attribute provides the legacy base roles of `admin`, `write`, `read`, and `none`, where the`maintain` role is mapped to `write` and the `triage` role is mapped to `read`. To determine the role assigned to thecollaborator, see the `role_name` attribute, which will provide the full role name, including custom roles. The`permissions` hash can also be used to determine which base level of access the collaborator has to the repository.
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
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Collaborators.Item.Permission.PermissionRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Repos.Item.Item.Collaborators.Item.Permission.PermissionRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Repos.Item.Item.Collaborators.Item.Permission.PermissionRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
