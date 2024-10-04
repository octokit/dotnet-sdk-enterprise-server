// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Admin.Ldap.Users.Item.Mapping;
using GitHub.Admin.Ldap.Users.Item.Sync;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace GitHub.Admin.Ldap.Users.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \admin\ldap\users\{username}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class WithUsernameItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The mapping property</summary>
        public global::GitHub.Admin.Ldap.Users.Item.Mapping.MappingRequestBuilder Mapping
        {
            get => new global::GitHub.Admin.Ldap.Users.Item.Mapping.MappingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The sync property</summary>
        public global::GitHub.Admin.Ldap.Users.Item.Sync.SyncRequestBuilder Sync
        {
            get => new global::GitHub.Admin.Ldap.Users.Item.Sync.SyncRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Admin.Ldap.Users.Item.WithUsernameItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithUsernameItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/ldap/users/{username}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Admin.Ldap.Users.Item.WithUsernameItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithUsernameItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/ldap/users/{username}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
