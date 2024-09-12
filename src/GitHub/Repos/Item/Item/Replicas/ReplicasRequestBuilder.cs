// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Repos.Item.Item.Replicas.Caches;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace GitHub.Repos.Item.Item.Replicas
{
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\replicas
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class ReplicasRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The caches property</summary>
        public global::GitHub.Repos.Item.Item.Replicas.Caches.CachesRequestBuilder Caches
        {
            get => new global::GitHub.Repos.Item.Item.Replicas.Caches.CachesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Replicas.ReplicasRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReplicasRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/replicas", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Replicas.ReplicasRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReplicasRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/replicas", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
