// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Repos.Item.Item.Actions.Oidc.Customization.Sub;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace GitHub.Repos.Item.Item.Actions.Oidc.Customization
{
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\actions\oidc\customization
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class CustomizationRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The sub property</summary>
        public global::GitHub.Repos.Item.Item.Actions.Oidc.Customization.Sub.SubRequestBuilder Sub
        {
            get => new global::GitHub.Repos.Item.Item.Actions.Oidc.Customization.Sub.SubRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Actions.Oidc.Customization.CustomizationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CustomizationRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/actions/oidc/customization", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Actions.Oidc.Customization.CustomizationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CustomizationRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/actions/oidc/customization", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
