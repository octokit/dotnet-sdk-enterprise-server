// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Manage.V1.Config.Apply;
using GitHub.Manage.V1.Config.Init;
using GitHub.Manage.V1.Config.License;
using GitHub.Manage.V1.Config.Nodes;
using GitHub.Manage.V1.Config.Settings;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace GitHub.Manage.V1.Config
{
    /// <summary>
    /// Builds and executes requests for operations under \manage\v1\config
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class ConfigRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The apply property</summary>
        public global::GitHub.Manage.V1.Config.Apply.ApplyRequestBuilder Apply
        {
            get => new global::GitHub.Manage.V1.Config.Apply.ApplyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The init property</summary>
        public global::GitHub.Manage.V1.Config.Init.InitRequestBuilder Init
        {
            get => new global::GitHub.Manage.V1.Config.Init.InitRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The license property</summary>
        public global::GitHub.Manage.V1.Config.License.LicenseRequestBuilder License
        {
            get => new global::GitHub.Manage.V1.Config.License.LicenseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The nodes property</summary>
        public global::GitHub.Manage.V1.Config.Nodes.NodesRequestBuilder Nodes
        {
            get => new global::GitHub.Manage.V1.Config.Nodes.NodesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The settings property</summary>
        public global::GitHub.Manage.V1.Config.Settings.SettingsRequestBuilder Settings
        {
            get => new global::GitHub.Manage.V1.Config.Settings.SettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Manage.V1.Config.ConfigRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ConfigRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/manage/v1/config", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Manage.V1.Config.ConfigRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ConfigRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/manage/v1/config", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
