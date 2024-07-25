// <auto-generated/>
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
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Repos.Item.Item {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}
    /// </summary>
    public class RepoItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The actions property</summary>
        public ActionsRequestBuilder Actions
        {
            get => new ActionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The activity property</summary>
        public ActivityRequestBuilder Activity
        {
            get => new ActivityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The assignees property</summary>
        public AssigneesRequestBuilder Assignees
        {
            get => new AssigneesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The autolinks property</summary>
        public AutolinksRequestBuilder Autolinks
        {
            get => new AutolinksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The automatedSecurityFixes property</summary>
        public AutomatedSecurityFixesRequestBuilder AutomatedSecurityFixes
        {
            get => new AutomatedSecurityFixesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The branches property</summary>
        public BranchesRequestBuilder Branches
        {
            get => new BranchesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The checkRuns property</summary>
        public CheckRunsRequestBuilder CheckRuns
        {
            get => new CheckRunsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The checkSuites property</summary>
        public CheckSuitesRequestBuilder CheckSuites
        {
            get => new CheckSuitesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The codeowners property</summary>
        public CodeownersRequestBuilder Codeowners
        {
            get => new CodeownersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The codeScanning property</summary>
        public CodeScanningRequestBuilder CodeScanning
        {
            get => new CodeScanningRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The collaborators property</summary>
        public CollaboratorsRequestBuilder Collaborators
        {
            get => new CollaboratorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The comments property</summary>
        public CommentsRequestBuilder Comments
        {
            get => new CommentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The commits property</summary>
        public CommitsRequestBuilder Commits
        {
            get => new CommitsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The compare property</summary>
        public CompareRequestBuilder Compare
        {
            get => new CompareRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The contents property</summary>
        public ContentsRequestBuilder Contents
        {
            get => new ContentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The contributors property</summary>
        public ContributorsRequestBuilder Contributors
        {
            get => new ContributorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The dependabot property</summary>
        public DependabotRequestBuilder Dependabot
        {
            get => new DependabotRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The dependencyGraph property</summary>
        public DependencyGraphRequestBuilder DependencyGraph
        {
            get => new DependencyGraphRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deployments property</summary>
        public DeploymentsRequestBuilder Deployments
        {
            get => new DeploymentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The dispatches property</summary>
        public DispatchesRequestBuilder Dispatches
        {
            get => new DispatchesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The environments property</summary>
        public EnvironmentsRequestBuilder Environments
        {
            get => new EnvironmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The events property</summary>
        public EventsRequestBuilder Events
        {
            get => new EventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The forks property</summary>
        public ForksRequestBuilder Forks
        {
            get => new ForksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The generate property</summary>
        public GenerateRequestBuilder Generate
        {
            get => new GenerateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The git property</summary>
        public GitRequestBuilder Git
        {
            get => new GitRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The hooks property</summary>
        public HooksRequestBuilder Hooks
        {
            get => new HooksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The installation property</summary>
        public InstallationRequestBuilder Installation
        {
            get => new InstallationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The invitations property</summary>
        public InvitationsRequestBuilder Invitations
        {
            get => new InvitationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The issues property</summary>
        public IssuesRequestBuilder Issues
        {
            get => new IssuesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The keys property</summary>
        public KeysRequestBuilder Keys
        {
            get => new KeysRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The labels property</summary>
        public LabelsRequestBuilder Labels
        {
            get => new LabelsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The languages property</summary>
        public LanguagesRequestBuilder Languages
        {
            get => new LanguagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The lfs property</summary>
        public LfsRequestBuilder Lfs
        {
            get => new LfsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The license property</summary>
        public LicenseRequestBuilder License
        {
            get => new LicenseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The merges property</summary>
        public MergesRequestBuilder Merges
        {
            get => new MergesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The mergeUpstream property</summary>
        public MergeUpstreamRequestBuilder MergeUpstream
        {
            get => new MergeUpstreamRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The milestones property</summary>
        public MilestonesRequestBuilder Milestones
        {
            get => new MilestonesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The notifications property</summary>
        public NotificationsRequestBuilder Notifications
        {
            get => new NotificationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The pages property</summary>
        public PagesRequestBuilder Pages
        {
            get => new PagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The preReceiveHooks property</summary>
        public PreReceiveHooksRequestBuilder PreReceiveHooks
        {
            get => new PreReceiveHooksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The projects property</summary>
        public ProjectsRequestBuilder Projects
        {
            get => new ProjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The pulls property</summary>
        public PullsRequestBuilder Pulls
        {
            get => new PullsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The readme property</summary>
        public ReadmeRequestBuilder Readme
        {
            get => new ReadmeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The releases property</summary>
        public ReleasesRequestBuilder Releases
        {
            get => new ReleasesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The replicas property</summary>
        public ReplicasRequestBuilder Replicas
        {
            get => new ReplicasRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The rules property</summary>
        public RulesRequestBuilder Rules
        {
            get => new RulesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The rulesets property</summary>
        public RulesetsRequestBuilder Rulesets
        {
            get => new RulesetsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The secretScanning property</summary>
        public SecretScanningRequestBuilder SecretScanning
        {
            get => new SecretScanningRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The stargazers property</summary>
        public StargazersRequestBuilder Stargazers
        {
            get => new StargazersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The stats property</summary>
        public StatsRequestBuilder Stats
        {
            get => new StatsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The statuses property</summary>
        public StatusesRequestBuilder Statuses
        {
            get => new StatusesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The subscribers property</summary>
        public SubscribersRequestBuilder Subscribers
        {
            get => new SubscribersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The subscription property</summary>
        public SubscriptionRequestBuilder Subscription
        {
            get => new SubscriptionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The tags property</summary>
        public TagsRequestBuilder Tags
        {
            get => new TagsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The tarball property</summary>
        public TarballRequestBuilder Tarball
        {
            get => new TarballRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The teams property</summary>
        public TeamsRequestBuilder Teams
        {
            get => new TeamsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The topics property</summary>
        public TopicsRequestBuilder Topics
        {
            get => new TopicsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The transfer property</summary>
        public TransferRequestBuilder Transfer
        {
            get => new TransferRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The vulnerabilityAlerts property</summary>
        public VulnerabilityAlertsRequestBuilder VulnerabilityAlerts
        {
            get => new VulnerabilityAlertsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The zipball property</summary>
        public ZipballRequestBuilder Zipball
        {
            get => new ZipballRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="RepoItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RepoItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="RepoItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RepoItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}", rawUrl)
        {
        }
        /// <summary>
        /// Deleting a repository requires admin access.If an organization owner has configured the organization to prevent members from deleting organization-ownedrepositories, you will get a `403 Forbidden` response.OAuth app tokens and personal access tokens (classic) need the `delete_repo` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.12/rest/repos/repos#delete-a-repository" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Repo403Error">When receiving a 403 status code</exception>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
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
                {"403", Repo403Error.CreateFromDiscriminatorValue},
                {"404", BasicError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// The `parent` and `source` objects are present when the repository is a fork. `parent` is the repository this repository was forked from, `source` is the ultimate source for the network.&gt; [!NOTE]&gt; In order to see the `security_and_analysis` block for a repository you must have admin permissions for the repository or be an owner or security manager for the organization that owns the repository. For more information, see &quot;[Managing security managers in your organization](https://docs.github.com/enterprise-server@3.12/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).&quot;
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.12/rest/repos/repos#get-a-repository" />
        /// </summary>
        /// <returns>A <see cref="FullRepository"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="BasicError">When receiving a 403 status code</exception>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<FullRepository?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<FullRepository> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"403", BasicError.CreateFromDiscriminatorValue},
                {"404", BasicError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<FullRepository>(requestInfo, FullRepository.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// **Note**: To edit a repository&apos;s topics, use the [Replace all repository topics](https://docs.github.com/enterprise-server@3.12/rest/repos/repos#replace-all-repository-topics) endpoint.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.12/rest/repos/repos#update-a-repository" />
        /// </summary>
        /// <returns>A <see cref="FullRepository"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="BasicError">When receiving a 403 status code</exception>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
        /// <exception cref="ValidationError">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<FullRepository?> PatchAsync(RepoPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<FullRepository> PatchAsync(RepoPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"403", BasicError.CreateFromDiscriminatorValue},
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"422", ValidationError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<FullRepository>(requestInfo, FullRepository.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
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
        /// The `parent` and `source` objects are present when the repository is a fork. `parent` is the repository this repository was forked from, `source` is the ultimate source for the network.&gt; [!NOTE]&gt; In order to see the `security_and_analysis` block for a repository you must have admin permissions for the repository or be an owner or security manager for the organization that owns the repository. For more information, see &quot;[Managing security managers in your organization](https://docs.github.com/enterprise-server@3.12/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).&quot;
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
        /// **Note**: To edit a repository&apos;s topics, use the [Replace all repository topics](https://docs.github.com/enterprise-server@3.12/rest/repos/repos#replace-all-repository-topics) endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(RepoPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(RepoPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="RepoItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public RepoItemRequestBuilder WithUrl(string rawUrl)
        {
            return new RepoItemRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
