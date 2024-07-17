// <auto-generated/>
using GitHub.Gitignore.Templates;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace GitHub.Gitignore {
    /// <summary>
    /// Builds and executes requests for operations under \gitignore
    /// </summary>
    public class GitignoreRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The templates property</summary>
        public TemplatesRequestBuilder Templates
        {
            get => new TemplatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="GitignoreRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GitignoreRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/gitignore", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="GitignoreRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GitignoreRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/gitignore", rawUrl)
        {
        }
    }
}
