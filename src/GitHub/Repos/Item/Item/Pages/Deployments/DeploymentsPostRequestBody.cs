// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Repos.Item.Item.Pages.Deployments
{
    /// <summary>
    /// The object used to create GitHub Pages deployment
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class DeploymentsPostRequestBody : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The URL of an artifact that contains the .zip or .tar of static assets to deploy. The artifact belongs to the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ArtifactUrl { get; set; }
#nullable restore
#else
        public string ArtifactUrl { get; set; }
#endif
        /// <summary>The target environment for this GitHub Pages deployment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Environment { get; set; }
#nullable restore
#else
        public string Environment { get; set; }
#endif
        /// <summary>The OIDC token issued by GitHub Actions certifying the origin of the deployment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OidcToken { get; set; }
#nullable restore
#else
        public string OidcToken { get; set; }
#endif
        /// <summary>A unique string that represents the version of the build for this deployment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PagesBuildVersion { get; set; }
#nullable restore
#else
        public string PagesBuildVersion { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.Pages.Deployments.DeploymentsPostRequestBody"/> and sets the default values.
        /// </summary>
        public DeploymentsPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
            Environment = "github-pages";
            PagesBuildVersion = "GITHUB_SHA";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.Pages.Deployments.DeploymentsPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Repos.Item.Item.Pages.Deployments.DeploymentsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Repos.Item.Item.Pages.Deployments.DeploymentsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "artifact_url", n => { ArtifactUrl = n.GetStringValue(); } },
                { "environment", n => { Environment = n.GetStringValue(); } },
                { "oidc_token", n => { OidcToken = n.GetStringValue(); } },
                { "pages_build_version", n => { PagesBuildVersion = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("artifact_url", ArtifactUrl);
            writer.WriteStringValue("environment", Environment);
            writer.WriteStringValue("oidc_token", OidcToken);
            writer.WriteStringValue("pages_build_version", PagesBuildVersion);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
