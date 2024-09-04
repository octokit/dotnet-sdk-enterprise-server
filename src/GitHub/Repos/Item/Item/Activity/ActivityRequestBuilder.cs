// <auto-generated/>
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Repos.Item.Item.Activity
{
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\activity
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class ActivityRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Activity.ActivityRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ActivityRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/activity{?activity_type*,actor*,after*,before*,direction*,per_page*,ref*,time_period*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Activity.ActivityRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ActivityRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/activity{?activity_type*,actor*,after*,before*,direction*,per_page*,ref*,time_period*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists a detailed history of changes to a repository, such as pushes, merges, force pushes, and branch changes, and associates these changes with commits and users.For more information about viewing repository activity,see &quot;[Viewing activity and data for your repository](https://docs.github.com/enterprise-server@3.14/repositories/viewing-activity-and-data-for-your-repository).&quot;
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.14/rest/repos/repos#list-repository-activities" />
        /// </summary>
        /// <returns>A List&lt;global::GitHub.Models.Activity&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.ValidationErrorSimple">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::GitHub.Models.Activity>?> GetAsync(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Activity.ActivityRequestBuilder.ActivityRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::GitHub.Models.Activity>> GetAsync(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Activity.ActivityRequestBuilder.ActivityRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "422", global::GitHub.Models.ValidationErrorSimple.CreateFromDiscriminatorValue },
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::GitHub.Models.Activity>(requestInfo, global::GitHub.Models.Activity.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// Lists a detailed history of changes to a repository, such as pushes, merges, force pushes, and branch changes, and associates these changes with commits and users.For more information about viewing repository activity,see &quot;[Viewing activity and data for your repository](https://docs.github.com/enterprise-server@3.14/repositories/viewing-activity-and-data-for-your-repository).&quot;
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Activity.ActivityRequestBuilder.ActivityRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Activity.ActivityRequestBuilder.ActivityRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Activity.ActivityRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Repos.Item.Item.Activity.ActivityRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Repos.Item.Item.Activity.ActivityRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists a detailed history of changes to a repository, such as pushes, merges, force pushes, and branch changes, and associates these changes with commits and users.For more information about viewing repository activity,see &quot;[Viewing activity and data for your repository](https://docs.github.com/enterprise-server@3.14/repositories/viewing-activity-and-data-for-your-repository).&quot;
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
        public partial class ActivityRequestBuilderGetQueryParameters 
        {
            /// <summary>The activity type to filter by.For example, you can choose to filter by &quot;force_push&quot;, to see all force pushes to the repository.</summary>
            [QueryParameter("activity_type")]
            public global::GitHub.Repos.Item.Item.Activity.GetActivity_typeQueryParameterType? ActivityType { get; set; }
            /// <summary>The GitHub username to use to filter by the actor who performed the activity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("actor")]
            public string? Actor { get; set; }
#nullable restore
#else
            [QueryParameter("actor")]
            public string Actor { get; set; }
#endif
            /// <summary>A cursor, as given in the [Link header](https://docs.github.com/enterprise-server@3.14/rest/guides/using-pagination-in-the-rest-api#using-link-headers). If specified, the query only searches for results after this cursor. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.14/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("after")]
            public string? After { get; set; }
#nullable restore
#else
            [QueryParameter("after")]
            public string After { get; set; }
#endif
            /// <summary>A cursor, as given in the [Link header](https://docs.github.com/enterprise-server@3.14/rest/guides/using-pagination-in-the-rest-api#using-link-headers). If specified, the query only searches for results before this cursor. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.14/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("before")]
            public string? Before { get; set; }
#nullable restore
#else
            [QueryParameter("before")]
            public string Before { get; set; }
#endif
            /// <summary>The direction to sort the results by.</summary>
            [QueryParameter("direction")]
            public global::GitHub.Repos.Item.Item.Activity.GetDirectionQueryParameterType? Direction { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/enterprise-server@3.14/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>The Git reference for the activities you want to list.The `ref` for a branch can be formatted either as `refs/heads/BRANCH_NAME` or `BRANCH_NAME`, where `BRANCH_NAME` is the name of your branch.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("ref")]
            public string? Ref { get; set; }
#nullable restore
#else
            [QueryParameter("ref")]
            public string Ref { get; set; }
#endif
            /// <summary>The time period to filter by.For example, `day` will filter for activity that occurred in the past 24 hours, and `week` will filter for activity that occurred in the past 7 days (168 hours).</summary>
            [QueryParameter("time_period")]
            public global::GitHub.Repos.Item.Item.Activity.GetTime_periodQueryParameterType? TimePeriod { get; set; }
        }
    }
}
