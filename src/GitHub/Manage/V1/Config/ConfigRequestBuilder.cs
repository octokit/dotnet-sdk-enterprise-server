// <auto-generated/>
using GitHub.Manage.V1.Config.Nodes;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace GitHub.Manage.V1.Config {
    /// <summary>
    /// Builds and executes requests for operations under \manage\v1\config
    /// </summary>
    public class ConfigRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The nodes property</summary>
        public NodesRequestBuilder Nodes
        {
            get => new NodesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="ConfigRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ConfigRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/manage/v1/config", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="ConfigRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ConfigRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/manage/v1/config", rawUrl)
        {
        }
    }
}
