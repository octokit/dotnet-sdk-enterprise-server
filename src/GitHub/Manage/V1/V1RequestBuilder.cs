// <auto-generated/>
using GitHub.Manage.V1.Cluster;
using GitHub.Manage.V1.Config;
using GitHub.Manage.V1.Maintenance;
using GitHub.Manage.V1.Replication;
using GitHub.Manage.V1.VersionNamespace;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace GitHub.Manage.V1
{
    /// <summary>
    /// Builds and executes requests for operations under \manage\v1
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class V1RequestBuilder : BaseRequestBuilder
    {
        /// <summary>The cluster property</summary>
        public global::GitHub.Manage.V1.Cluster.ClusterRequestBuilder Cluster
        {
            get => new global::GitHub.Manage.V1.Cluster.ClusterRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The config property</summary>
        public global::GitHub.Manage.V1.Config.ConfigRequestBuilder Config
        {
            get => new global::GitHub.Manage.V1.Config.ConfigRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The maintenance property</summary>
        public global::GitHub.Manage.V1.Maintenance.MaintenanceRequestBuilder Maintenance
        {
            get => new global::GitHub.Manage.V1.Maintenance.MaintenanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The replication property</summary>
        public global::GitHub.Manage.V1.Replication.ReplicationRequestBuilder Replication
        {
            get => new global::GitHub.Manage.V1.Replication.ReplicationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The version property</summary>
        public global::GitHub.Manage.V1.VersionNamespace.VersionRequestBuilder Version
        {
            get => new global::GitHub.Manage.V1.VersionNamespace.VersionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Manage.V1.V1RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public V1RequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/manage/v1", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Manage.V1.V1RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public V1RequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/manage/v1", rawUrl)
        {
        }
    }
}
