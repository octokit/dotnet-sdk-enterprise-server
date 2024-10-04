// <auto-generated/>
#pragma warning disable CS0618
using GitHub.Models;
using GitHub.Repos.Item.Item.Actions;
using GitHub.Repos.Item.Item.Activity;
using GitHub.Repos.Item.Item.Assignees;
using GitHub.Repos.Item.Item.Autolinks;
using GitHub.Repos.Item.Item.AutomatedSecurityFixes;
using GitHub.Repos.Item.Item.Branches;
using GitHub.Repos.Item.Item.CheckRuns;
using GitHub.Repos.Item.Item.CheckSuites;
using GitHub.Repos.Item.Item.CodeScanning;
using GitHub.Repos.Item.Item.Codeowners;
using GitHub.Repos.Item.Item.Collaborators;
using GitHub.Repos.Item.Item.Comments;
using GitHub.Repos.Item.Item.Commits;
using GitHub.Repos.Item.Item.Compare;
using GitHub.Repos.Item.Item.Contents;
using GitHub.Repos.Item.Item.Contributors;
using GitHub.Repos.Item.Item.Dependabot;
using GitHub.Repos.Item.Item.DependencyGraph;
using GitHub.Repos.Item.Item.Deployments;
using GitHub.Repos.Item.Item.Dispatches;
using GitHub.Repos.Item.Item.Environments;
using GitHub.Repos.Item.Item.Events;
using GitHub.Repos.Item.Item.Forks;
using GitHub.Repos.Item.Item.Generate;
using GitHub.Repos.Item.Item.Git;
using GitHub.Repos.Item.Item.Hooks;
using GitHub.Repos.Item.Item.Installation;
using GitHub.Repos.Item.Item.Invitations;
using GitHub.Repos.Item.Item.Issues;
using GitHub.Repos.Item.Item.Keys;
using GitHub.Repos.Item.Item.Labels;
using GitHub.Repos.Item.Item.Languages;
using GitHub.Repos.Item.Item.Lfs;
using GitHub.Repos.Item.Item.License;
using GitHub.Repos.Item.Item.MergeUpstream;
using GitHub.Repos.Item.Item.Merges;
using GitHub.Repos.Item.Item.Milestones;
using GitHub.Repos.Item.Item.Notifications;
using GitHub.Repos.Item.Item.Pages;
using GitHub.Repos.Item.Item.PreReceiveHooks;
using GitHub.Repos.Item.Item.Projects;
using GitHub.Repos.Item.Item.Pulls;
using GitHub.Repos.Item.Item.Readme;
using GitHub.Repos.Item.Item.Releases;
using GitHub.Repos.Item.Item.Replicas;
using GitHub.Repos.Item.Item.Rules;
using GitHub.Repos.Item.Item.Rulesets;
using GitHub.Repos.Item.Item.SecretScanning;
using GitHub.Repos.Item.Item.Stargazers;
using GitHub.Repos.Item.Item.Stats;
using GitHub.Repos.Item.Item.Statuses;
using GitHub.Repos.Item.Item.Subscribers;
using GitHub.Repos.Item.Item.Subscription;
using GitHub.Repos.Item.Item.Tags;
using GitHub.Repos.Item.Item.Tarball;
using GitHub.Repos.Item.Item.Teams;
using GitHub.Repos.Item.Item.Topics;
using GitHub.Repos.Item.Item.Transfer;
using GitHub.Repos.Item.Item.VulnerabilityAlerts;
using GitHub.Repos.Item.Item.Zipball;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Repos.Item.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class RepoItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The actions property</summary>
        public global::GitHub.Repos.Item.Item.Actions.ActionsRequestBuilder Actions
        {
            get => new global::GitHub.Repos.Item.Item.Actions.ActionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The activity property</summary>
        public global::GitHub.Repos.Item.Item.Activity.ActivityRequestBuilder Activity
        {
            get => new global::GitHub.Repos.Item.Item.Activity.ActivityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The assignees property</summary>
        public global::GitHub.Repos.Item.Item.Assignees.AssigneesRequestBuilder Assignees
        {
            get => new global::GitHub.Repos.Item.Item.Assignees.AssigneesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The autolinks property</summary>
        public global::GitHub.Repos.Item.Item.Autolinks.AutolinksRequestBuilder Autolinks
        {
            get => new global::GitHub.Repos.Item.Item.Autolinks.AutolinksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The automatedSecurityFixes property</summary>
        public global::GitHub.Repos.Item.Item.AutomatedSecurityFixes.AutomatedSecurityFixesRequestBuilder AutomatedSecurityFixes
        {
            get => new global::GitHub.Repos.Item.Item.AutomatedSecurityFixes.AutomatedSecurityFixesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The branches property</summary>
        public global::GitHub.Repos.Item.Item.Branches.BranchesRequestBuilder Branches
        {
            get => new global::GitHub.Repos.Item.Item.Branches.BranchesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The checkRuns property</summary>
        public global::GitHub.Repos.Item.Item.CheckRuns.CheckRunsRequestBuilder CheckRuns
        {
            get => new global::GitHub.Repos.Item.Item.CheckRuns.CheckRunsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The checkSuites property</summary>
        public global::GitHub.Repos.Item.Item.CheckSuites.CheckSuitesRequestBuilder CheckSuites
        {
            get => new global::GitHub.Repos.Item.Item.CheckSuites.CheckSuitesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The codeowners property</summary>
        public global::GitHub.Repos.Item.Item.Codeowners.CodeownersRequestBuilder Codeowners
        {
            get => new global::GitHub.Repos.Item.Item.Codeowners.CodeownersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The codeScanning property</summary>
        public global::GitHub.Repos.Item.Item.CodeScanning.CodeScanningRequestBuilder CodeScanning
        {
            get => new global::GitHub.Repos.Item.Item.CodeScanning.CodeScanningRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The collaborators property</summary>
        public global::GitHub.Repos.Item.Item.Collaborators.CollaboratorsRequestBuilder Collaborators
        {
            get => new global::GitHub.Repos.Item.Item.Collaborators.CollaboratorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The comments property</summary>
        public global::GitHub.Repos.Item.Item.Comments.CommentsRequestBuilder Comments
        {
            get => new global::GitHub.Repos.Item.Item.Comments.CommentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The commits property</summary>
        public global::GitHub.Repos.Item.Item.Commits.CommitsRequestBuilder Commits
        {
            get => new global::GitHub.Repos.Item.Item.Commits.CommitsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The compare property</summary>
        public global::GitHub.Repos.Item.Item.Compare.CompareRequestBuilder Compare
        {
            get => new global::GitHub.Repos.Item.Item.Compare.CompareRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The contents property</summary>
        public global::GitHub.Repos.Item.Item.Contents.ContentsRequestBuilder Contents
        {
            get => new global::GitHub.Repos.Item.Item.Contents.ContentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The contributors property</summary>
        public global::GitHub.Repos.Item.Item.Contributors.ContributorsRequestBuilder Contributors
        {
            get => new global::GitHub.Repos.Item.Item.Contributors.ContributorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The dependabot property</summary>
        public global::GitHub.Repos.Item.Item.Dependabot.DependabotRequestBuilder Dependabot
        {
            get => new global::GitHub.Repos.Item.Item.Dependabot.DependabotRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The dependencyGraph property</summary>
        public global::GitHub.Repos.Item.Item.DependencyGraph.DependencyGraphRequestBuilder DependencyGraph
        {
            get => new global::GitHub.Repos.Item.Item.DependencyGraph.DependencyGraphRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deployments property</summary>
        public global::GitHub.Repos.Item.Item.Deployments.DeploymentsRequestBuilder Deployments
        {
            get => new global::GitHub.Repos.Item.Item.Deployments.DeploymentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The dispatches property</summary>
        public global::GitHub.Repos.Item.Item.Dispatches.DispatchesRequestBuilder Dispatches
        {
            get => new global::GitHub.Repos.Item.Item.Dispatches.DispatchesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The environments property</summary>
        public global::GitHub.Repos.Item.Item.Environments.EnvironmentsRequestBuilder Environments
        {
            get => new global::GitHub.Repos.Item.Item.Environments.EnvironmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The events property</summary>
        public global::GitHub.Repos.Item.Item.Events.EventsRequestBuilder Events
        {
            get => new global::GitHub.Repos.Item.Item.Events.EventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The forks property</summary>
        public global::GitHub.Repos.Item.Item.Forks.ForksRequestBuilder Forks
        {
            get => new global::GitHub.Repos.Item.Item.Forks.ForksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The generate property</summary>
        public global::GitHub.Repos.Item.Item.Generate.GenerateRequestBuilder Generate
        {
            get => new global::GitHub.Repos.Item.Item.Generate.GenerateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The git property</summary>
        public global::GitHub.Repos.Item.Item.Git.GitRequestBuilder Git
        {
            get => new global::GitHub.Repos.Item.Item.Git.GitRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The hooks property</summary>
        public global::GitHub.Repos.Item.Item.Hooks.HooksRequestBuilder Hooks
        {
            get => new global::GitHub.Repos.Item.Item.Hooks.HooksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The installation property</summary>
        public global::GitHub.Repos.Item.Item.Installation.InstallationRequestBuilder Installation
        {
            get => new global::GitHub.Repos.Item.Item.Installation.InstallationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The invitations property</summary>
        public global::GitHub.Repos.Item.Item.Invitations.InvitationsRequestBuilder Invitations
        {
            get => new global::GitHub.Repos.Item.Item.Invitations.InvitationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The issues property</summary>
        public global::GitHub.Repos.Item.Item.Issues.IssuesRequestBuilder Issues
        {
            get => new global::GitHub.Repos.Item.Item.Issues.IssuesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The keys property</summary>
        public global::GitHub.Repos.Item.Item.Keys.KeysRequestBuilder Keys
        {
            get => new global::GitHub.Repos.Item.Item.Keys.KeysRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The labels property</summary>
        public global::GitHub.Repos.Item.Item.Labels.LabelsRequestBuilder Labels
        {
            get => new global::GitHub.Repos.Item.Item.Labels.LabelsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The languages property</summary>
        public global::GitHub.Repos.Item.Item.Languages.LanguagesRequestBuilder Languages
        {
            get => new global::GitHub.Repos.Item.Item.Languages.LanguagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The lfs property</summary>
        public global::GitHub.Repos.Item.Item.Lfs.LfsRequestBuilder Lfs
        {
            get => new global::GitHub.Repos.Item.Item.Lfs.LfsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The license property</summary>
        public global::GitHub.Repos.Item.Item.License.LicenseRequestBuilder License
        {
            get => new global::GitHub.Repos.Item.Item.License.LicenseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The merges property</summary>
        public global::GitHub.Repos.Item.Item.Merges.MergesRequestBuilder Merges
        {
            get => new global::GitHub.Repos.Item.Item.Merges.MergesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The mergeUpstream property</summary>
        public global::GitHub.Repos.Item.Item.MergeUpstream.MergeUpstreamRequestBuilder MergeUpstream
        {
            get => new global::GitHub.Repos.Item.Item.MergeUpstream.MergeUpstreamRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The milestones property</summary>
        public global::GitHub.Repos.Item.Item.Milestones.MilestonesRequestBuilder Milestones
        {
            get => new global::GitHub.Repos.Item.Item.Milestones.MilestonesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The notifications property</summary>
        public global::GitHub.Repos.Item.Item.Notifications.NotificationsRequestBuilder Notifications
        {
            get => new global::GitHub.Repos.Item.Item.Notifications.NotificationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The pages property</summary>
        public global::GitHub.Repos.Item.Item.Pages.PagesRequestBuilder Pages
        {
            get => new global::GitHub.Repos.Item.Item.Pages.PagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The preReceiveHooks property</summary>
        public global::GitHub.Repos.Item.Item.PreReceiveHooks.PreReceiveHooksRequestBuilder PreReceiveHooks
        {
            get => new global::GitHub.Repos.Item.Item.PreReceiveHooks.PreReceiveHooksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The projects property</summary>
        public global::GitHub.Repos.Item.Item.Projects.ProjectsRequestBuilder Projects
        {
            get => new global::GitHub.Repos.Item.Item.Projects.ProjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The pulls property</summary>
        public global::GitHub.Repos.Item.Item.Pulls.PullsRequestBuilder Pulls
        {
            get => new global::GitHub.Repos.Item.Item.Pulls.PullsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The readme property</summary>
        public global::GitHub.Repos.Item.Item.Readme.ReadmeRequestBuilder Readme
        {
            get => new global::GitHub.Repos.Item.Item.Readme.ReadmeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The releases property</summary>
        public global::GitHub.Repos.Item.Item.Releases.ReleasesRequestBuilder Releases
        {
            get => new global::GitHub.Repos.Item.Item.Releases.ReleasesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The replicas property</summary>
        public global::GitHub.Repos.Item.Item.Replicas.ReplicasRequestBuilder Replicas
        {
            get => new global::GitHub.Repos.Item.Item.Replicas.ReplicasRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The rules property</summary>
        public global::GitHub.Repos.Item.Item.Rules.RulesRequestBuilder Rules
        {
            get => new global::GitHub.Repos.Item.Item.Rules.RulesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The rulesets property</summary>
        public global::GitHub.Repos.Item.Item.Rulesets.RulesetsRequestBuilder Rulesets
        {
            get => new global::GitHub.Repos.Item.Item.Rulesets.RulesetsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The secretScanning property</summary>
        public global::GitHub.Repos.Item.Item.SecretScanning.SecretScanningRequestBuilder SecretScanning
        {
            get => new global::GitHub.Repos.Item.Item.SecretScanning.SecretScanningRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The stargazers property</summary>
        public global::GitHub.Repos.Item.Item.Stargazers.StargazersRequestBuilder Stargazers
        {
            get => new global::GitHub.Repos.Item.Item.Stargazers.StargazersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The stats property</summary>
        public global::GitHub.Repos.Item.Item.Stats.StatsRequestBuilder Stats
        {
            get => new global::GitHub.Repos.Item.Item.Stats.StatsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The statuses property</summary>
        public global::GitHub.Repos.Item.Item.Statuses.StatusesRequestBuilder Statuses
        {
            get => new global::GitHub.Repos.Item.Item.Statuses.StatusesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The subscribers property</summary>
        public global::GitHub.Repos.Item.Item.Subscribers.SubscribersRequestBuilder Subscribers
        {
            get => new global::GitHub.Repos.Item.Item.Subscribers.SubscribersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The subscription property</summary>
        public global::GitHub.Repos.Item.Item.Subscription.SubscriptionRequestBuilder Subscription
        {
            get => new global::GitHub.Repos.Item.Item.Subscription.SubscriptionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The tags property</summary>
        public global::GitHub.Repos.Item.Item.Tags.TagsRequestBuilder Tags
        {
            get => new global::GitHub.Repos.Item.Item.Tags.TagsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The tarball property</summary>
        public global::GitHub.Repos.Item.Item.Tarball.TarballRequestBuilder Tarball
        {
            get => new global::GitHub.Repos.Item.Item.Tarball.TarballRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The teams property</summary>
        public global::GitHub.Repos.Item.Item.Teams.TeamsRequestBuilder Teams
        {
            get => new global::GitHub.Repos.Item.Item.Teams.TeamsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The topics property</summary>
        public global::GitHub.Repos.Item.Item.Topics.TopicsRequestBuilder Topics
        {
            get => new global::GitHub.Repos.Item.Item.Topics.TopicsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The transfer property</summary>
        public global::GitHub.Repos.Item.Item.Transfer.TransferRequestBuilder Transfer
        {
            get => new global::GitHub.Repos.Item.Item.Transfer.TransferRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The vulnerabilityAlerts property</summary>
        public global::GitHub.Repos.Item.Item.VulnerabilityAlerts.VulnerabilityAlertsRequestBuilder VulnerabilityAlerts
        {
            get => new global::GitHub.Repos.Item.Item.VulnerabilityAlerts.VulnerabilityAlertsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The zipball property</summary>
        public global::GitHub.Repos.Item.Item.Zipball.ZipballRequestBuilder Zipball
        {
            get => new global::GitHub.Repos.Item.Item.Zipball.ZipballRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.RepoItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RepoItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.RepoItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RepoItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}", rawUrl)
        {
        }
        /// <summary>
        /// Deleting a repository requires admin access.If an organization owner has configured the organization to prevent members from deleting organization-ownedrepositories, you will get a `403 Forbidden` response.OAuth app tokens and personal access tokens (classic) need the `delete_repo` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.11/rest/repos/repos#delete-a-repository" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Repos.Item.Item.Repo403Error">When receiving a 403 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "403", global::GitHub.Repos.Item.Item.Repo403Error.CreateFromDiscriminatorValue },
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// The `parent` and `source` objects are present when the repository is a fork. `parent` is the repository this repository was forked from, `source` is the ultimate source for the network.&gt; [!NOTE]&gt; In order to see the `security_and_analysis` block for a repository you must have admin permissions for the repository or be an owner or security manager for the organization that owns the repository. For more information, see &quot;[Managing security managers in your organization](https://docs.github.com/enterprise-server@3.11/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).&quot;
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.11/rest/repos/repos#get-a-repository" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.FullRepository"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 403 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.FullRepository?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.FullRepository> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "403", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Models.FullRepository>(requestInfo, global::GitHub.Models.FullRepository.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// **Note**: To edit a repository&apos;s topics, use the [Replace all repository topics](https://docs.github.com/enterprise-server@3.11/rest/repos/repos#replace-all-repository-topics) endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.11/rest/repos/repos#update-a-repository" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.FullRepository"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 403 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
        /// <exception cref="global::GitHub.Models.ValidationError">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.FullRepository?> PatchAsync(global::GitHub.Repos.Item.Item.RepoPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.FullRepository> PatchAsync(global::GitHub.Repos.Item.Item.RepoPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "403", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "422", global::GitHub.Models.ValidationError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Models.FullRepository>(requestInfo, global::GitHub.Models.FullRepository.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Deleting a repository requires admin access.If an organization owner has configured the organization to prevent members from deleting organization-ownedrepositories, you will get a `403 Forbidden` response.OAuth app tokens and personal access tokens (classic) need the `delete_repo` scope to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// The `parent` and `source` objects are present when the repository is a fork. `parent` is the repository this repository was forked from, `source` is the ultimate source for the network.&gt; [!NOTE]&gt; In order to see the `security_and_analysis` block for a repository you must have admin permissions for the repository or be an owner or security manager for the organization that owns the repository. For more information, see &quot;[Managing security managers in your organization](https://docs.github.com/enterprise-server@3.11/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).&quot;
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
        /// **Note**: To edit a repository&apos;s topics, use the [Replace all repository topics](https://docs.github.com/enterprise-server@3.11/rest/repos/repos#replace-all-repository-topics) endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::GitHub.Repos.Item.Item.RepoPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::GitHub.Repos.Item.Item.RepoPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.RepoItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Repos.Item.Item.RepoItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Repos.Item.Item.RepoItemRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
