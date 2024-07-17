// <auto-generated/>
using GitHub.Manage.V1.Config.Apply;
using GitHub.Manage.V1.Config.Init;
using GitHub.Manage.V1.Config.License;
using GitHub.Manage.V1.Config.Nodes;
using GitHub.Manage.V1.Config.Settings;
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
        /// <summary>The apply property</summary>
        public ApplyRequestBuilder Apply
        {
            get => new ApplyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The init property</summary>
        public InitRequestBuilder Init
        {
            get => new InitRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The license property</summary>
        public LicenseRequestBuilder License
        {
            get => new LicenseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The nodes property</summary>
        public NodesRequestBuilder Nodes
        {
            get => new NodesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The settings property</summary>
        public SettingsRequestBuilder Settings
        {
            get => new SettingsRequestBuilder(PathParameters, RequestAdapter);
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
