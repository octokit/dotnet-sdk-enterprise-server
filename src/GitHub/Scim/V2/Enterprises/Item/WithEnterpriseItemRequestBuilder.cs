// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Scim.V2.Enterprises.Item.Groups;
using GitHub.Scim.V2.Enterprises.Item.Users;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace GitHub.Scim.V2.Enterprises.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \scim\v2\enterprises\{enterprise}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class WithEnterpriseItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The Groups property</summary>
        public global::GitHub.Scim.V2.Enterprises.Item.Groups.GroupsRequestBuilder Groups
        {
            get => new global::GitHub.Scim.V2.Enterprises.Item.Groups.GroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Users property</summary>
        public global::GitHub.Scim.V2.Enterprises.Item.Users.UsersRequestBuilder Users
        {
            get => new global::GitHub.Scim.V2.Enterprises.Item.Users.UsersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Scim.V2.Enterprises.Item.WithEnterpriseItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithEnterpriseItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/scim/v2/enterprises/{enterprise}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Scim.V2.Enterprises.Item.WithEnterpriseItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithEnterpriseItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/scim/v2/enterprises/{enterprise}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
