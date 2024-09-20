// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Enterprises.Item.Code_security_and_analysis
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class Code_security_and_analysisPatchRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Whether GitHub Advanced Security is automatically enabled for new repositories. For more information, see &quot;[About GitHub Advanced Security](https://docs.github.com/enterprise-server@3.13/get-started/learning-about-github/about-github-advanced-security).&quot;</summary>
        public bool? AdvancedSecurityEnabledForNewRepositories { get; set; }
        /// <summary>Whether GitHub Advanced Security is automatically enabled for new user namespace repositories. For more information, see &quot;[About GitHub Advanced Security](https://docs.github.com/enterprise-server@3.13/get-started/learning-about-github/about-github-advanced-security).&quot;</summary>
        public bool? AdvancedSecurityEnabledNewUserNamespaceRepos { get; set; }
        /// <summary>Whether Dependabot alerts are automatically enabled for new repositories. For more information, see &quot;[About Dependabot alerts](https://docs.github.com/enterprise-server@3.13/code-security/dependabot/dependabot-alerts/about-dependabot-alerts).&quot;</summary>
        public bool? DependabotAlertsEnabledForNewRepositories { get; set; }
        /// <summary>Whether secret scanning is automatically enabled for new repositories. For more information, see &quot;[About secret scanning](https://docs.github.com/enterprise-server@3.13/code-security/secret-scanning/about-secret-scanning).&quot;</summary>
        public bool? SecretScanningEnabledForNewRepositories { get; set; }
        /// <summary>The URL that will be displayed to contributors who are blocked from pushing a secret. For more information, see &quot;[Protecting pushes with secret scanning](https://docs.github.com/enterprise-server@3.13/code-security/secret-scanning/protecting-pushes-with-secret-scanning).&quot;To disable this functionality, set this field to `null`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SecretScanningPushProtectionCustomLink { get; set; }
#nullable restore
#else
        public string SecretScanningPushProtectionCustomLink { get; set; }
#endif
        /// <summary>Whether secret scanning push protection is automatically enabled for new repositories. For more information, see &quot;[Protecting pushes with secret scanning](https://docs.github.com/enterprise-server@3.13/code-security/secret-scanning/protecting-pushes-with-secret-scanning).&quot;</summary>
        public bool? SecretScanningPushProtectionEnabledForNewRepositories { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Enterprises.Item.Code_security_and_analysis.Code_security_and_analysisPatchRequestBody"/> and sets the default values.
        /// </summary>
        public Code_security_and_analysisPatchRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Enterprises.Item.Code_security_and_analysis.Code_security_and_analysisPatchRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Enterprises.Item.Code_security_and_analysis.Code_security_and_analysisPatchRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Enterprises.Item.Code_security_and_analysis.Code_security_and_analysisPatchRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "advanced_security_enabled_for_new_repositories", n => { AdvancedSecurityEnabledForNewRepositories = n.GetBoolValue(); } },
                { "advanced_security_enabled_new_user_namespace_repos", n => { AdvancedSecurityEnabledNewUserNamespaceRepos = n.GetBoolValue(); } },
                { "dependabot_alerts_enabled_for_new_repositories", n => { DependabotAlertsEnabledForNewRepositories = n.GetBoolValue(); } },
                { "secret_scanning_enabled_for_new_repositories", n => { SecretScanningEnabledForNewRepositories = n.GetBoolValue(); } },
                { "secret_scanning_push_protection_custom_link", n => { SecretScanningPushProtectionCustomLink = n.GetStringValue(); } },
                { "secret_scanning_push_protection_enabled_for_new_repositories", n => { SecretScanningPushProtectionEnabledForNewRepositories = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("advanced_security_enabled_for_new_repositories", AdvancedSecurityEnabledForNewRepositories);
            writer.WriteBoolValue("advanced_security_enabled_new_user_namespace_repos", AdvancedSecurityEnabledNewUserNamespaceRepos);
            writer.WriteBoolValue("dependabot_alerts_enabled_for_new_repositories", DependabotAlertsEnabledForNewRepositories);
            writer.WriteBoolValue("secret_scanning_enabled_for_new_repositories", SecretScanningEnabledForNewRepositories);
            writer.WriteStringValue("secret_scanning_push_protection_custom_link", SecretScanningPushProtectionCustomLink);
            writer.WriteBoolValue("secret_scanning_push_protection_enabled_for_new_repositories", SecretScanningPushProtectionEnabledForNewRepositories);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
