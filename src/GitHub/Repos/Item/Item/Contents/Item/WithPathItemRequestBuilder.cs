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
namespace GitHub.Repos.Item.Item.Contents.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\contents\{path}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class WithPathItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Contents.Item.WithPathItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithPathItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/contents/{path}{?ref*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Contents.Item.WithPathItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithPathItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/contents/{path}{?ref*}", rawUrl)
        {
        }
        /// <summary>
        /// Deletes a file in a repository.You can provide an additional `committer` parameter, which is an object containing information about the committer. Or, you can provide an `author` parameter, which is an object containing information about the author.The `author` section is optional and is filled in with the `committer` information if omitted. If the `committer` information is omitted, the authenticated user&apos;s information is used.You must provide values for both `name` and `email`, whether you choose to use `author` or `committer`. Otherwise, you&apos;ll receive a `422` status code.&gt; [!NOTE]&gt; If you use this endpoint and the &quot;[Create or update file contents](https://docs.github.com/enterprise-server@3.13/rest/repos/contents/#create-or-update-file-contents)&quot; endpoint in parallel, the concurrent requests will conflict and you will receive errors. You must use these endpoints serially instead.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.13/rest/repos/contents#delete-a-file" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.FileCommit"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 409 status code</exception>
        /// <exception cref="global::GitHub.Models.ValidationError">When receiving a 422 status code</exception>
        /// <exception cref="global::GitHub.Models.FileCommit503Error">When receiving a 503 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.FileCommit?> DeleteAsync(global::GitHub.Repos.Item.Item.Contents.Item.WithPathDeleteRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.FileCommit> DeleteAsync(global::GitHub.Repos.Item.Item.Contents.Item.WithPathDeleteRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToDeleteRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "409", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "422", global::GitHub.Models.ValidationError.CreateFromDiscriminatorValue },
                { "503", global::GitHub.Models.FileCommit503Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Models.FileCommit>(requestInfo, global::GitHub.Models.FileCommit.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets the contents of a file or directory in a repository. Specify the file path or directory with the `path` parameter. If you omit the `path` parameter, you will receive the contents of the repository&apos;s root directory.This endpoint supports the following custom media types. For more information, see &quot;[Media types](https://docs.github.com/enterprise-server@3.13/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types).&quot;- **`application/vnd.github.raw+json`**: Returns the raw file contents for files and symlinks.- **`application/vnd.github.html+json`**: Returns the file contents in HTML. Markup languages are rendered to HTML using GitHub&apos;s open-source [Markup library](https://github.com/github/markup).- **`application/vnd.github.object+json`**: Returns the contents in a consistent object format regardless of the content type. For example, instead of an array of objects for a directory, the response will be an object with an `entries` attribute containing the array of objects.If the content is a directory, the response will be an array of objects, one object for each item in the directory. When listing the contents of a directory, submodules have their &quot;type&quot; specified as &quot;file&quot;. Logically, the value _should_ be &quot;submodule&quot;. This behavior exists [for backwards compatibility purposes](https://git.io/v1YCW). In the next major version of the API, the type will be returned as &quot;submodule&quot;.If the content is a symlink and the symlink&apos;s target is a normal file in the repository, then the API responds with the content of the file. Otherwise, the API responds with an object describing the symlink itself.If the content is a submodule, the `submodule_git_url` field identifies the location of the submodule repository, and the `sha` identifies a specific commit within the submodule repository. Git uses the given URL when cloning the submodule repository, and checks out the submodule at that specific commit. If the submodule repository is not hosted on github.com, the Git URLs (`git_url` and `_links[&quot;git&quot;]`) and the github.com URLs (`html_url` and `_links[&quot;html&quot;]`) will have null values.**Notes**:- To get a repository&apos;s contents recursively, you can [recursively get the tree](https://docs.github.com/enterprise-server@3.13/rest/git/trees#get-a-tree).- This API has an upper limit of 1,000 files for a directory. If you need to retrievemore files, use the [Git Trees API](https://docs.github.com/enterprise-server@3.13/rest/git/trees#get-a-tree).- Download URLs expire and are meant to be used just once. To ensure the download URL does not expire, please use the contents API to obtain a fresh download URL for each download.- If the requested file&apos;s size is:  - 1 MB or smaller: All features of this endpoint are supported.  - Between 1-100 MB: Only the `raw` or `object` custom media types are supported. Both will work as normal, except that when using the `object` media type, the `content` field will be an emptystring and the `encoding` field will be `&quot;none&quot;`. To get the contents of these larger files, use the `raw` media type.  - Greater than 100 MB: This endpoint is not supported.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.13/rest/repos/contents#get-repository-content" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Contents.Item.WithPathItemRequestBuilder.WithPathGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 403 status code</exception>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Repos.Item.Item.Contents.Item.WithPathItemRequestBuilder.WithPathGetResponse?> GetAsync(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Contents.Item.WithPathItemRequestBuilder.WithPathItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Repos.Item.Item.Contents.Item.WithPathItemRequestBuilder.WithPathGetResponse> GetAsync(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Contents.Item.WithPathItemRequestBuilder.WithPathItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "403", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Repos.Item.Item.Contents.Item.WithPathItemRequestBuilder.WithPathGetResponse>(requestInfo, global::GitHub.Repos.Item.Item.Contents.Item.WithPathItemRequestBuilder.WithPathGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a new file or replaces an existing file in a repository.&gt; [!NOTE]&gt; If you use this endpoint and the &quot;[Delete a file](https://docs.github.com/enterprise-server@3.13/rest/repos/contents/#delete-a-file)&quot; endpoint in parallel, the concurrent requests will conflict and you will receive errors. You must use these endpoints serially instead.OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint. The `workflow` scope is also required in order to modify files in the `.github/workflows` directory.
        /// API method documentation <see href="https://docs.github.com/enterprise-server@3.13/rest/repos/contents#create-or-update-file-contents" />
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.FileCommit"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::GitHub.Models.BasicError">When receiving a 404 status code</exception>
        /// <exception cref="global::GitHub.Models.ValidationError">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::GitHub.Models.FileCommit?> PutAsync(global::GitHub.Repos.Item.Item.Contents.Item.WithPathPutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::GitHub.Models.FileCommit> PutAsync(global::GitHub.Repos.Item.Item.Contents.Item.WithPathPutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", global::GitHub.Models.BasicError.CreateFromDiscriminatorValue },
                { "422", global::GitHub.Models.ValidationError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::GitHub.Models.FileCommit>(requestInfo, global::GitHub.Models.FileCommit.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Deletes a file in a repository.You can provide an additional `committer` parameter, which is an object containing information about the committer. Or, you can provide an `author` parameter, which is an object containing information about the author.The `author` section is optional and is filled in with the `committer` information if omitted. If the `committer` information is omitted, the authenticated user&apos;s information is used.You must provide values for both `name` and `email`, whether you choose to use `author` or `committer`. Otherwise, you&apos;ll receive a `422` status code.&gt; [!NOTE]&gt; If you use this endpoint and the &quot;[Create or update file contents](https://docs.github.com/enterprise-server@3.13/rest/repos/contents/#create-or-update-file-contents)&quot; endpoint in parallel, the concurrent requests will conflict and you will receive errors. You must use these endpoints serially instead.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(global::GitHub.Repos.Item.Item.Contents.Item.WithPathDeleteRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(global::GitHub.Repos.Item.Item.Contents.Item.WithPathDeleteRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Gets the contents of a file or directory in a repository. Specify the file path or directory with the `path` parameter. If you omit the `path` parameter, you will receive the contents of the repository&apos;s root directory.This endpoint supports the following custom media types. For more information, see &quot;[Media types](https://docs.github.com/enterprise-server@3.13/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types).&quot;- **`application/vnd.github.raw+json`**: Returns the raw file contents for files and symlinks.- **`application/vnd.github.html+json`**: Returns the file contents in HTML. Markup languages are rendered to HTML using GitHub&apos;s open-source [Markup library](https://github.com/github/markup).- **`application/vnd.github.object+json`**: Returns the contents in a consistent object format regardless of the content type. For example, instead of an array of objects for a directory, the response will be an object with an `entries` attribute containing the array of objects.If the content is a directory, the response will be an array of objects, one object for each item in the directory. When listing the contents of a directory, submodules have their &quot;type&quot; specified as &quot;file&quot;. Logically, the value _should_ be &quot;submodule&quot;. This behavior exists [for backwards compatibility purposes](https://git.io/v1YCW). In the next major version of the API, the type will be returned as &quot;submodule&quot;.If the content is a symlink and the symlink&apos;s target is a normal file in the repository, then the API responds with the content of the file. Otherwise, the API responds with an object describing the symlink itself.If the content is a submodule, the `submodule_git_url` field identifies the location of the submodule repository, and the `sha` identifies a specific commit within the submodule repository. Git uses the given URL when cloning the submodule repository, and checks out the submodule at that specific commit. If the submodule repository is not hosted on github.com, the Git URLs (`git_url` and `_links[&quot;git&quot;]`) and the github.com URLs (`html_url` and `_links[&quot;html&quot;]`) will have null values.**Notes**:- To get a repository&apos;s contents recursively, you can [recursively get the tree](https://docs.github.com/enterprise-server@3.13/rest/git/trees#get-a-tree).- This API has an upper limit of 1,000 files for a directory. If you need to retrievemore files, use the [Git Trees API](https://docs.github.com/enterprise-server@3.13/rest/git/trees#get-a-tree).- Download URLs expire and are meant to be used just once. To ensure the download URL does not expire, please use the contents API to obtain a fresh download URL for each download.- If the requested file&apos;s size is:  - 1 MB or smaller: All features of this endpoint are supported.  - Between 1-100 MB: Only the `raw` or `object` custom media types are supported. Both will work as normal, except that when using the `object` media type, the `content` field will be an emptystring and the `encoding` field will be `&quot;none&quot;`. To get the contents of these larger files, use the `raw` media type.  - Greater than 100 MB: This endpoint is not supported.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Contents.Item.WithPathItemRequestBuilder.WithPathItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::GitHub.Repos.Item.Item.Contents.Item.WithPathItemRequestBuilder.WithPathItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Creates a new file or replaces an existing file in a repository.&gt; [!NOTE]&gt; If you use this endpoint and the &quot;[Delete a file](https://docs.github.com/enterprise-server@3.13/rest/repos/contents/#delete-a-file)&quot; endpoint in parallel, the concurrent requests will conflict and you will receive errors. You must use these endpoints serially instead.OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint. The `workflow` scope is also required in order to modify files in the `.github/workflows` directory.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(global::GitHub.Repos.Item.Item.Contents.Item.WithPathPutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(global::GitHub.Repos.Item.Item.Contents.Item.WithPathPutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Contents.Item.WithPathItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::GitHub.Repos.Item.Item.Contents.Item.WithPathItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::GitHub.Repos.Item.Item.Contents.Item.WithPathItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::GitHub.Models.ContentFile"/>, <see cref="global::GitHub.Models.ContentSubmodule"/>, <see cref="global::GitHub.Models.ContentSymlink"/>, List&lt;global::GitHub.Models.WithPathGetResponseMember1&gt;
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class WithPathGetResponse : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::GitHub.Models.ContentFile"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::GitHub.Models.ContentFile? ContentFile { get; set; }
#nullable restore
#else
            public global::GitHub.Models.ContentFile ContentFile { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::GitHub.Models.ContentSubmodule"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::GitHub.Models.ContentSubmodule? ContentSubmodule { get; set; }
#nullable restore
#else
            public global::GitHub.Models.ContentSubmodule ContentSubmodule { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::GitHub.Models.ContentSymlink"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::GitHub.Models.ContentSymlink? ContentSymlink { get; set; }
#nullable restore
#else
            public global::GitHub.Models.ContentSymlink ContentSymlink { get; set; }
#endif
            /// <summary>Composed type representation for type List&lt;global::GitHub.Models.WithPathGetResponseMember1&gt;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public List<global::GitHub.Models.WithPathGetResponseMember1>? WithPathGetResponseMember1 { get; set; }
#nullable restore
#else
            public List<global::GitHub.Models.WithPathGetResponseMember1> WithPathGetResponseMember1 { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Contents.Item.WithPathItemRequestBuilder.WithPathGetResponse"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::GitHub.Repos.Item.Item.Contents.Item.WithPathItemRequestBuilder.WithPathGetResponse CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::GitHub.Repos.Item.Item.Contents.Item.WithPathItemRequestBuilder.WithPathGetResponse();
                if("content-file".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.ContentFile = new global::GitHub.Models.ContentFile();
                }
                else if("content-submodule".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.ContentSubmodule = new global::GitHub.Models.ContentSubmodule();
                }
                else if("content-symlink".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.ContentSymlink = new global::GitHub.Models.ContentSymlink();
                }
                else if(parseNode.GetCollectionOfObjectValues<global::GitHub.Models.WithPathGetResponseMember1>(global::GitHub.Models.WithPathGetResponseMember1.CreateFromDiscriminatorValue)?.AsList() is List<global::GitHub.Models.WithPathGetResponseMember1> withPathGetResponseMember1Value)
                {
                    result.WithPathGetResponseMember1 = withPathGetResponseMember1Value;
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(ContentFile != null)
                {
                    return ContentFile.GetFieldDeserializers();
                }
                else if(ContentSubmodule != null)
                {
                    return ContentSubmodule.GetFieldDeserializers();
                }
                else if(ContentSymlink != null)
                {
                    return ContentSymlink.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer)
            {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(ContentFile != null)
                {
                    writer.WriteObjectValue<global::GitHub.Models.ContentFile>(null, ContentFile);
                }
                else if(ContentSubmodule != null)
                {
                    writer.WriteObjectValue<global::GitHub.Models.ContentSubmodule>(null, ContentSubmodule);
                }
                else if(ContentSymlink != null)
                {
                    writer.WriteObjectValue<global::GitHub.Models.ContentSymlink>(null, ContentSymlink);
                }
                else if(WithPathGetResponseMember1 != null)
                {
                    writer.WriteCollectionOfObjectValues<global::GitHub.Models.WithPathGetResponseMember1>(null, WithPathGetResponseMember1);
                }
            }
        }
        /// <summary>
        /// Gets the contents of a file or directory in a repository. Specify the file path or directory with the `path` parameter. If you omit the `path` parameter, you will receive the contents of the repository&apos;s root directory.This endpoint supports the following custom media types. For more information, see &quot;[Media types](https://docs.github.com/enterprise-server@3.13/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types).&quot;- **`application/vnd.github.raw+json`**: Returns the raw file contents for files and symlinks.- **`application/vnd.github.html+json`**: Returns the file contents in HTML. Markup languages are rendered to HTML using GitHub&apos;s open-source [Markup library](https://github.com/github/markup).- **`application/vnd.github.object+json`**: Returns the contents in a consistent object format regardless of the content type. For example, instead of an array of objects for a directory, the response will be an object with an `entries` attribute containing the array of objects.If the content is a directory, the response will be an array of objects, one object for each item in the directory. When listing the contents of a directory, submodules have their &quot;type&quot; specified as &quot;file&quot;. Logically, the value _should_ be &quot;submodule&quot;. This behavior exists [for backwards compatibility purposes](https://git.io/v1YCW). In the next major version of the API, the type will be returned as &quot;submodule&quot;.If the content is a symlink and the symlink&apos;s target is a normal file in the repository, then the API responds with the content of the file. Otherwise, the API responds with an object describing the symlink itself.If the content is a submodule, the `submodule_git_url` field identifies the location of the submodule repository, and the `sha` identifies a specific commit within the submodule repository. Git uses the given URL when cloning the submodule repository, and checks out the submodule at that specific commit. If the submodule repository is not hosted on github.com, the Git URLs (`git_url` and `_links[&quot;git&quot;]`) and the github.com URLs (`html_url` and `_links[&quot;html&quot;]`) will have null values.**Notes**:- To get a repository&apos;s contents recursively, you can [recursively get the tree](https://docs.github.com/enterprise-server@3.13/rest/git/trees#get-a-tree).- This API has an upper limit of 1,000 files for a directory. If you need to retrievemore files, use the [Git Trees API](https://docs.github.com/enterprise-server@3.13/rest/git/trees#get-a-tree).- Download URLs expire and are meant to be used just once. To ensure the download URL does not expire, please use the contents API to obtain a fresh download URL for each download.- If the requested file&apos;s size is:  - 1 MB or smaller: All features of this endpoint are supported.  - Between 1-100 MB: Only the `raw` or `object` custom media types are supported. Both will work as normal, except that when using the `object` media type, the `content` field will be an emptystring and the `encoding` field will be `&quot;none&quot;`. To get the contents of these larger files, use the `raw` media type.  - Greater than 100 MB: This endpoint is not supported.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class WithPathItemRequestBuilderGetQueryParameters 
        {
            /// <summary>The name of the commit/branch/tag. Default: the repository’s default branch.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("ref")]
            public string? Ref { get; set; }
#nullable restore
#else
            [QueryParameter("ref")]
            public string Ref { get; set; }
#endif
        }
    }
}
#pragma warning restore CS0618
