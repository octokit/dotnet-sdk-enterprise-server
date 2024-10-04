// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Repos.Item.Item
{
    /// <summary>
    /// Specify which security and analysis features to enable or disable for the repository.To use this parameter, you must have admin permissions for the repository or be an owner or security manager for the organization that owns the repository. For more information, see &quot;[Managing security managers in your organization](https://docs.github.com/enterprise-server@3.11/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).&quot;For example, to enable GitHub Advanced Security, use this data in the body of the `PATCH` request:`{ &quot;security_and_analysis&quot;: {&quot;advanced_security&quot;: { &quot;status&quot;: &quot;enabled&quot; } } }`.You can check which security and analysis features are currently enabled by using a `GET /repos/{owner}/{repo}` request.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class RepoPatchRequestBody_security_and_analysis : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Use the `status` property to enable or disable GitHub Advanced Security for this repository. For more information, see &quot;[About GitHub Advanced Security](/github/getting-started-with-github/learning-about-github/about-github-advanced-security).&quot;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Repos.Item.Item.RepoPatchRequestBody_security_and_analysis_advanced_security? AdvancedSecurity { get; set; }
#nullable restore
#else
        public global::GitHub.Repos.Item.Item.RepoPatchRequestBody_security_and_analysis_advanced_security AdvancedSecurity { get; set; }
#endif
        /// <summary>Use the `status` property to enable or disable secret scanning for this repository. For more information, see &quot;[About secret scanning](/code-security/secret-security/about-secret-scanning).&quot;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Repos.Item.Item.RepoPatchRequestBody_security_and_analysis_secret_scanning? SecretScanning { get; set; }
#nullable restore
#else
        public global::GitHub.Repos.Item.Item.RepoPatchRequestBody_security_and_analysis_secret_scanning SecretScanning { get; set; }
#endif
        /// <summary>Use the `status` property to enable or disable secret scanning push protection for this repository. For more information, see &quot;[Protecting pushes with secret scanning](/code-security/secret-scanning/protecting-pushes-with-secret-scanning).&quot;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Repos.Item.Item.RepoPatchRequestBody_security_and_analysis_secret_scanning_push_protection? SecretScanningPushProtection { get; set; }
#nullable restore
#else
        public global::GitHub.Repos.Item.Item.RepoPatchRequestBody_security_and_analysis_secret_scanning_push_protection SecretScanningPushProtection { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Repos.Item.Item.RepoPatchRequestBody_security_and_analysis"/> and sets the default values.
        /// </summary>
        public RepoPatchRequestBody_security_and_analysis()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.RepoPatchRequestBody_security_and_analysis"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Repos.Item.Item.RepoPatchRequestBody_security_and_analysis CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Repos.Item.Item.RepoPatchRequestBody_security_and_analysis();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "advanced_security", n => { AdvancedSecurity = n.GetObjectValue<global::GitHub.Repos.Item.Item.RepoPatchRequestBody_security_and_analysis_advanced_security>(global::GitHub.Repos.Item.Item.RepoPatchRequestBody_security_and_analysis_advanced_security.CreateFromDiscriminatorValue); } },
                { "secret_scanning", n => { SecretScanning = n.GetObjectValue<global::GitHub.Repos.Item.Item.RepoPatchRequestBody_security_and_analysis_secret_scanning>(global::GitHub.Repos.Item.Item.RepoPatchRequestBody_security_and_analysis_secret_scanning.CreateFromDiscriminatorValue); } },
                { "secret_scanning_push_protection", n => { SecretScanningPushProtection = n.GetObjectValue<global::GitHub.Repos.Item.Item.RepoPatchRequestBody_security_and_analysis_secret_scanning_push_protection>(global::GitHub.Repos.Item.Item.RepoPatchRequestBody_security_and_analysis_secret_scanning_push_protection.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::GitHub.Repos.Item.Item.RepoPatchRequestBody_security_and_analysis_advanced_security>("advanced_security", AdvancedSecurity);
            writer.WriteObjectValue<global::GitHub.Repos.Item.Item.RepoPatchRequestBody_security_and_analysis_secret_scanning>("secret_scanning", SecretScanning);
            writer.WriteObjectValue<global::GitHub.Repos.Item.Item.RepoPatchRequestBody_security_and_analysis_secret_scanning_push_protection>("secret_scanning_push_protection", SecretScanningPushProtection);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
