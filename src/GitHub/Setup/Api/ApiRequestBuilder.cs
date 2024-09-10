// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Setup.Api.Configcheck;
using GitHub.Setup.Api.Configure;
using GitHub.Setup.Api.Maintenance;
using GitHub.Setup.Api.Settings;
using GitHub.Setup.Api.Start;
using GitHub.Setup.Api.Upgrade;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace GitHub.Setup.Api
{
    /// <summary>
    /// Builds and executes requests for operations under \setup\api
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class ApiRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The configcheck property</summary>
        public global::GitHub.Setup.Api.Configcheck.ConfigcheckRequestBuilder Configcheck
        {
            get => new global::GitHub.Setup.Api.Configcheck.ConfigcheckRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The configure property</summary>
        public global::GitHub.Setup.Api.Configure.ConfigureRequestBuilder Configure
        {
            get => new global::GitHub.Setup.Api.Configure.ConfigureRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The maintenance property</summary>
        public global::GitHub.Setup.Api.Maintenance.MaintenanceRequestBuilder Maintenance
        {
            get => new global::GitHub.Setup.Api.Maintenance.MaintenanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The settings property</summary>
        public global::GitHub.Setup.Api.Settings.SettingsRequestBuilder Settings
        {
            get => new global::GitHub.Setup.Api.Settings.SettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The start property</summary>
        public global::GitHub.Setup.Api.Start.StartRequestBuilder Start
        {
            get => new global::GitHub.Setup.Api.Start.StartRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The upgrade property</summary>
        public global::GitHub.Setup.Api.Upgrade.UpgradeRequestBuilder Upgrade
        {
            get => new global::GitHub.Setup.Api.Upgrade.UpgradeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Setup.Api.ApiRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ApiRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/setup/api", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Setup.Api.ApiRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ApiRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/setup/api", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
