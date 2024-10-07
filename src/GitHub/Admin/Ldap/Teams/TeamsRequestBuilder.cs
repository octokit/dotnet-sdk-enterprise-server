// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Admin.Ldap.Teams.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace GitHub.Admin.Ldap.Teams
{
    /// <summary>
    /// Builds and executes requests for operations under \admin\ldap\teams
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class TeamsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the GitHub.admin.ldap.teams.item collection</summary>
        /// <param name="position">The unique identifier of the team.</param>
        /// <returns>A <see cref="global::GitHub.Admin.Ldap.Teams.Item.WithTeam_ItemRequestBuilder"/></returns>
        public global::GitHub.Admin.Ldap.Teams.Item.WithTeam_ItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("team_id", position);
                return new global::GitHub.Admin.Ldap.Teams.Item.WithTeam_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Admin.Ldap.Teams.TeamsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TeamsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/ldap/teams", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Admin.Ldap.Teams.TeamsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TeamsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/ldap/teams", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
