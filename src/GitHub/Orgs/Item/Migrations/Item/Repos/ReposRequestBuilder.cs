// <auto-generated/>
using GitHub.Orgs.Item.Migrations.Item.Repos.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace GitHub.Orgs.Item.Migrations.Item.Repos
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\migrations\{migration_id}\repos
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class ReposRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the GitHub.orgs.item.migrations.item.repos.item collection</summary>
        /// <param name="position">repo_name parameter</param>
        /// <returns>A <see cref="global::GitHub.Orgs.Item.Migrations.Item.Repos.Item.WithRepo_nameItemRequestBuilder"/></returns>
        public global::GitHub.Orgs.Item.Migrations.Item.Repos.Item.WithRepo_nameItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("repo_name", position);
                return new global::GitHub.Orgs.Item.Migrations.Item.Repos.Item.WithRepo_nameItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.Migrations.Item.Repos.ReposRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReposRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/migrations/{migration_id}/repos", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Orgs.Item.Migrations.Item.Repos.ReposRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReposRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/migrations/{migration_id}/repos", rawUrl)
        {
        }
    }
}
