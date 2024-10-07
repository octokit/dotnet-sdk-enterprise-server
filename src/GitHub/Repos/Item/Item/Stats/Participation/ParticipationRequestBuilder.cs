// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Repos.Item.Item.Stats.Participation
{
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\stats\participation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class ParticipationRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Stats.Participation.ParticipationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ParticipationRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/stats/participation", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Stats.Participation.ParticipationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ParticipationRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/stats/participation", rawUrl)
        {
        }
        /// <summary>
        /// Returns the total commit counts for the `owner` and total commit counts in `all`. `all` is everyone combined, including the `owner` in the last 52 weeks. If you&apos;d like to get the commit counts for non-owners, you can subtract `owner` from `all`.The array order is oldest week (index 0) to most recent week.The most recent week is seven days ago at UTC midnight to today at UTC midnight.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.14/rest/metrics/statistics#get-the-weekly-commit-count" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.ParticipationStats"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.ParticipationStats?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.ParticipationStats> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Models.ParticipationStats>(requestInfo, global::GitHub.Models.ParticipationStats.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns the total commit counts for the `owner` and total commit counts in `all`. `all` is everyone combined, including the `owner` in the last 52 weeks. If you&apos;d like to get the commit counts for non-owners, you can subtract `owner` from `all`.The array order is oldest week (index 0) to most recent week.The most recent week is seven days ago at UTC midnight to today at UTC midnight.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Stats.Participation.ParticipationRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Repos.Item.Item.Stats.Participation.ParticipationRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Repos.Item.Item.Stats.Participation.ParticipationRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
