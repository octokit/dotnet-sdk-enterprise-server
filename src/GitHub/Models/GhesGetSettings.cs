// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class GhesGetSettings : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The admin_password property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AdminPassword { get; set; }
#nullable restore
#else
        public string AdminPassword { get; set; }
#endif
        /// <summary>The assets property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Assets { get; set; }
#nullable restore
#else
        public string Assets { get; set; }
#endif
        /// <summary>The auth_mode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AuthMode { get; set; }
#nullable restore
#else
        public string AuthMode { get; set; }
#endif
        /// <summary>The avatar property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.GhesGetSettings_avatar? Avatar { get; set; }
#nullable restore
#else
        public global::GitHub.Models.GhesGetSettings_avatar Avatar { get; set; }
#endif
        /// <summary>The cas property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.GhesGetSettings_cas? Cas { get; set; }
#nullable restore
#else
        public global::GitHub.Models.GhesGetSettings_cas Cas { get; set; }
#endif
        /// <summary>The collectd property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.GhesGetSettings_collectd? Collectd { get; set; }
#nullable restore
#else
        public global::GitHub.Models.GhesGetSettings_collectd Collectd { get; set; }
#endif
        /// <summary>The configuration_id property</summary>
        public int? ConfigurationId { get; set; }
        /// <summary>The configuration_run_count property</summary>
        public int? ConfigurationRunCount { get; set; }
        /// <summary>The customer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.GhesGetSettings_customer? Customer { get; set; }
#nullable restore
#else
        public global::GitHub.Models.GhesGetSettings_customer Customer { get; set; }
#endif
        /// <summary>The expire_sessions property</summary>
        public bool? ExpireSessions { get; set; }
        /// <summary>The github_hostname property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GithubHostname { get; set; }
#nullable restore
#else
        public string GithubHostname { get; set; }
#endif
        /// <summary>The github_oauth property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.GhesGetSettings_github_oauth? GithubOauth { get; set; }
#nullable restore
#else
        public global::GitHub.Models.GhesGetSettings_github_oauth GithubOauth { get; set; }
#endif
        /// <summary>The github_ssl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.GhesGetSettings_github_ssl? GithubSsl { get; set; }
#nullable restore
#else
        public global::GitHub.Models.GhesGetSettings_github_ssl GithubSsl { get; set; }
#endif
        /// <summary>The http_proxy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HttpProxy { get; set; }
#nullable restore
#else
        public string HttpProxy { get; set; }
#endif
        /// <summary>The identicons_host property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdenticonsHost { get; set; }
#nullable restore
#else
        public string IdenticonsHost { get; set; }
#endif
        /// <summary>The ldap property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.GhesGetSettings_ldap? Ldap { get; set; }
#nullable restore
#else
        public global::GitHub.Models.GhesGetSettings_ldap Ldap { get; set; }
#endif
        /// <summary>The license property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.GhesGetSettings_license? License { get; set; }
#nullable restore
#else
        public global::GitHub.Models.GhesGetSettings_license License { get; set; }
#endif
        /// <summary>The load_balancer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LoadBalancer { get; set; }
#nullable restore
#else
        public string LoadBalancer { get; set; }
#endif
        /// <summary>The mapping property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.GhesGetSettings_mapping? Mapping { get; set; }
#nullable restore
#else
        public global::GitHub.Models.GhesGetSettings_mapping Mapping { get; set; }
#endif
        /// <summary>The ntp property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.GhesGetSettings_ntp? Ntp { get; set; }
#nullable restore
#else
        public global::GitHub.Models.GhesGetSettings_ntp Ntp { get; set; }
#endif
        /// <summary>The pages property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.GhesGetSettings_pages? Pages { get; set; }
#nullable restore
#else
        public global::GitHub.Models.GhesGetSettings_pages Pages { get; set; }
#endif
        /// <summary>The private_mode property</summary>
        public bool? PrivateMode { get; set; }
        /// <summary>The public_pages property</summary>
        public bool? PublicPages { get; set; }
        /// <summary>The saml property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.GhesGetSettings_saml? Saml { get; set; }
#nullable restore
#else
        public global::GitHub.Models.GhesGetSettings_saml Saml { get; set; }
#endif
        /// <summary>The signup_enabled property</summary>
        public bool? SignupEnabled { get; set; }
        /// <summary>The smtp property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.GhesGetSettings_smtp? Smtp { get; set; }
#nullable restore
#else
        public global::GitHub.Models.GhesGetSettings_smtp Smtp { get; set; }
#endif
        /// <summary>The snmp property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.GhesGetSettings_snmp? Snmp { get; set; }
#nullable restore
#else
        public global::GitHub.Models.GhesGetSettings_snmp Snmp { get; set; }
#endif
        /// <summary>The subdomain_isolation property</summary>
        public bool? SubdomainIsolation { get; set; }
        /// <summary>The syslog property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::GitHub.Models.GhesGetSettings_syslog? Syslog { get; set; }
#nullable restore
#else
        public global::GitHub.Models.GhesGetSettings_syslog Syslog { get; set; }
#endif
        /// <summary>The timezone property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Timezone { get; set; }
#nullable restore
#else
        public string Timezone { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.GhesGetSettings"/> and sets the default values.
        /// </summary>
        public GhesGetSettings()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.GhesGetSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.GhesGetSettings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.GhesGetSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "admin_password", n => { AdminPassword = n.GetStringValue(); } },
                { "assets", n => { Assets = n.GetStringValue(); } },
                { "auth_mode", n => { AuthMode = n.GetStringValue(); } },
                { "avatar", n => { Avatar = n.GetObjectValue<global::GitHub.Models.GhesGetSettings_avatar>(global::GitHub.Models.GhesGetSettings_avatar.CreateFromDiscriminatorValue); } },
                { "cas", n => { Cas = n.GetObjectValue<global::GitHub.Models.GhesGetSettings_cas>(global::GitHub.Models.GhesGetSettings_cas.CreateFromDiscriminatorValue); } },
                { "collectd", n => { Collectd = n.GetObjectValue<global::GitHub.Models.GhesGetSettings_collectd>(global::GitHub.Models.GhesGetSettings_collectd.CreateFromDiscriminatorValue); } },
                { "configuration_id", n => { ConfigurationId = n.GetIntValue(); } },
                { "configuration_run_count", n => { ConfigurationRunCount = n.GetIntValue(); } },
                { "customer", n => { Customer = n.GetObjectValue<global::GitHub.Models.GhesGetSettings_customer>(global::GitHub.Models.GhesGetSettings_customer.CreateFromDiscriminatorValue); } },
                { "expire_sessions", n => { ExpireSessions = n.GetBoolValue(); } },
                { "github_hostname", n => { GithubHostname = n.GetStringValue(); } },
                { "github_oauth", n => { GithubOauth = n.GetObjectValue<global::GitHub.Models.GhesGetSettings_github_oauth>(global::GitHub.Models.GhesGetSettings_github_oauth.CreateFromDiscriminatorValue); } },
                { "github_ssl", n => { GithubSsl = n.GetObjectValue<global::GitHub.Models.GhesGetSettings_github_ssl>(global::GitHub.Models.GhesGetSettings_github_ssl.CreateFromDiscriminatorValue); } },
                { "http_proxy", n => { HttpProxy = n.GetStringValue(); } },
                { "identicons_host", n => { IdenticonsHost = n.GetStringValue(); } },
                { "ldap", n => { Ldap = n.GetObjectValue<global::GitHub.Models.GhesGetSettings_ldap>(global::GitHub.Models.GhesGetSettings_ldap.CreateFromDiscriminatorValue); } },
                { "license", n => { License = n.GetObjectValue<global::GitHub.Models.GhesGetSettings_license>(global::GitHub.Models.GhesGetSettings_license.CreateFromDiscriminatorValue); } },
                { "load_balancer", n => { LoadBalancer = n.GetStringValue(); } },
                { "mapping", n => { Mapping = n.GetObjectValue<global::GitHub.Models.GhesGetSettings_mapping>(global::GitHub.Models.GhesGetSettings_mapping.CreateFromDiscriminatorValue); } },
                { "ntp", n => { Ntp = n.GetObjectValue<global::GitHub.Models.GhesGetSettings_ntp>(global::GitHub.Models.GhesGetSettings_ntp.CreateFromDiscriminatorValue); } },
                { "pages", n => { Pages = n.GetObjectValue<global::GitHub.Models.GhesGetSettings_pages>(global::GitHub.Models.GhesGetSettings_pages.CreateFromDiscriminatorValue); } },
                { "private_mode", n => { PrivateMode = n.GetBoolValue(); } },
                { "public_pages", n => { PublicPages = n.GetBoolValue(); } },
                { "saml", n => { Saml = n.GetObjectValue<global::GitHub.Models.GhesGetSettings_saml>(global::GitHub.Models.GhesGetSettings_saml.CreateFromDiscriminatorValue); } },
                { "signup_enabled", n => { SignupEnabled = n.GetBoolValue(); } },
                { "smtp", n => { Smtp = n.GetObjectValue<global::GitHub.Models.GhesGetSettings_smtp>(global::GitHub.Models.GhesGetSettings_smtp.CreateFromDiscriminatorValue); } },
                { "snmp", n => { Snmp = n.GetObjectValue<global::GitHub.Models.GhesGetSettings_snmp>(global::GitHub.Models.GhesGetSettings_snmp.CreateFromDiscriminatorValue); } },
                { "subdomain_isolation", n => { SubdomainIsolation = n.GetBoolValue(); } },
                { "syslog", n => { Syslog = n.GetObjectValue<global::GitHub.Models.GhesGetSettings_syslog>(global::GitHub.Models.GhesGetSettings_syslog.CreateFromDiscriminatorValue); } },
                { "timezone", n => { Timezone = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("admin_password", AdminPassword);
            writer.WriteStringValue("assets", Assets);
            writer.WriteStringValue("auth_mode", AuthMode);
            writer.WriteObjectValue<global::GitHub.Models.GhesGetSettings_avatar>("avatar", Avatar);
            writer.WriteObjectValue<global::GitHub.Models.GhesGetSettings_cas>("cas", Cas);
            writer.WriteObjectValue<global::GitHub.Models.GhesGetSettings_collectd>("collectd", Collectd);
            writer.WriteIntValue("configuration_id", ConfigurationId);
            writer.WriteIntValue("configuration_run_count", ConfigurationRunCount);
            writer.WriteObjectValue<global::GitHub.Models.GhesGetSettings_customer>("customer", Customer);
            writer.WriteBoolValue("expire_sessions", ExpireSessions);
            writer.WriteStringValue("github_hostname", GithubHostname);
            writer.WriteObjectValue<global::GitHub.Models.GhesGetSettings_github_oauth>("github_oauth", GithubOauth);
            writer.WriteObjectValue<global::GitHub.Models.GhesGetSettings_github_ssl>("github_ssl", GithubSsl);
            writer.WriteStringValue("http_proxy", HttpProxy);
            writer.WriteStringValue("identicons_host", IdenticonsHost);
            writer.WriteObjectValue<global::GitHub.Models.GhesGetSettings_ldap>("ldap", Ldap);
            writer.WriteObjectValue<global::GitHub.Models.GhesGetSettings_license>("license", License);
            writer.WriteStringValue("load_balancer", LoadBalancer);
            writer.WriteObjectValue<global::GitHub.Models.GhesGetSettings_mapping>("mapping", Mapping);
            writer.WriteObjectValue<global::GitHub.Models.GhesGetSettings_ntp>("ntp", Ntp);
            writer.WriteObjectValue<global::GitHub.Models.GhesGetSettings_pages>("pages", Pages);
            writer.WriteBoolValue("private_mode", PrivateMode);
            writer.WriteBoolValue("public_pages", PublicPages);
            writer.WriteObjectValue<global::GitHub.Models.GhesGetSettings_saml>("saml", Saml);
            writer.WriteBoolValue("signup_enabled", SignupEnabled);
            writer.WriteObjectValue<global::GitHub.Models.GhesGetSettings_smtp>("smtp", Smtp);
            writer.WriteObjectValue<global::GitHub.Models.GhesGetSettings_snmp>("snmp", Snmp);
            writer.WriteBoolValue("subdomain_isolation", SubdomainIsolation);
            writer.WriteObjectValue<global::GitHub.Models.GhesGetSettings_syslog>("syslog", Syslog);
            writer.WriteStringValue("timezone", Timezone);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
