// <auto-generated/>
using GitHub.Search.Code;
using GitHub.Search.Commits;
using GitHub.Search.Issues;
using GitHub.Search.Labels;
using GitHub.Search.Repositories;
using GitHub.Search.Topics;
using GitHub.Search.Users;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace GitHub.Search
{
    /// <summary>
    /// Builds and executes requests for operations under \search
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class SearchRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The code property</summary>
        public global::GitHub.Search.Code.CodeRequestBuilder Code
        {
            get => new global::GitHub.Search.Code.CodeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The commits property</summary>
        public global::GitHub.Search.Commits.CommitsRequestBuilder Commits
        {
            get => new global::GitHub.Search.Commits.CommitsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The issues property</summary>
        public global::GitHub.Search.Issues.IssuesRequestBuilder Issues
        {
            get => new global::GitHub.Search.Issues.IssuesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The labels property</summary>
        public global::GitHub.Search.Labels.LabelsRequestBuilder Labels
        {
            get => new global::GitHub.Search.Labels.LabelsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The repositories property</summary>
        public global::GitHub.Search.Repositories.RepositoriesRequestBuilder Repositories
        {
            get => new global::GitHub.Search.Repositories.RepositoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The topics property</summary>
        public global::GitHub.Search.Topics.TopicsRequestBuilder Topics
        {
            get => new global::GitHub.Search.Topics.TopicsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The users property</summary>
        public global::GitHub.Search.Users.UsersRequestBuilder Users
        {
            get => new global::GitHub.Search.Users.UsersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Search.SearchRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SearchRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/search", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Search.SearchRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SearchRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/search", rawUrl)
        {
        }
    }
}
