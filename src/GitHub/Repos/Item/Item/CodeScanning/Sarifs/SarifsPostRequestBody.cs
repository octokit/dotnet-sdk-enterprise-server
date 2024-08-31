// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Repos.Item.Item.CodeScanning.Sarifs
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class SarifsPostRequestBody : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The base directory used in the analysis, as it appears in the SARIF file.This property is used to convert file paths from absolute to relative, so that alerts can be mapped to their correct location in the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CheckoutUri { get; set; }
#nullable restore
#else
        public string CheckoutUri { get; set; }
#endif
        /// <summary>The SHA of the commit to which the analysis you are uploading relates.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommitSha { get; set; }
#nullable restore
#else
        public string CommitSha { get; set; }
#endif
        /// <summary>The full Git reference, formatted as `refs/heads/&lt;branch name&gt;`,`refs/tags/&lt;tag&gt;`, `refs/pull/&lt;number&gt;/merge`, or `refs/pull/&lt;number&gt;/head`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Ref { get; set; }
#nullable restore
#else
        public string Ref { get; set; }
#endif
        /// <summary>A Base64 string representing the SARIF file to upload. You must first compress your SARIF file using [`gzip`](http://www.gnu.org/software/gzip/manual/gzip.html) and then translate the contents of the file into a Base64 encoding string. For more information, see &quot;[SARIF support for code scanning](https://docs.github.com/enterprise-server@3.13/code-security/secure-coding/sarif-support-for-code-scanning).&quot;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sarif { get; set; }
#nullable restore
#else
        public string Sarif { get; set; }
#endif
        /// <summary>The time that the analysis run began. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.</summary>
        public DateTimeOffset? StartedAt { get; set; }
        /// <summary>The name of the tool used to generate the code scanning analysis. If this parameter is not used, the tool name defaults to &quot;API&quot;. If the uploaded SARIF contains a tool GUID, this will be available for filtering using the `tool_guid` parameter of operations such as `GET /repos/{owner}/{repo}/code-scanning/alerts`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ToolName { get; set; }
#nullable restore
#else
        public string ToolName { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Repos.Item.Item.CodeScanning.Sarifs.SarifsPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Repos.Item.Item.CodeScanning.Sarifs.SarifsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Repos.Item.Item.CodeScanning.Sarifs.SarifsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "checkout_uri", n => { CheckoutUri = n.GetStringValue(); } },
                { "commit_sha", n => { CommitSha = n.GetStringValue(); } },
                { "ref", n => { Ref = n.GetStringValue(); } },
                { "sarif", n => { Sarif = n.GetStringValue(); } },
                { "started_at", n => { StartedAt = n.GetDateTimeOffsetValue(); } },
                { "tool_name", n => { ToolName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("checkout_uri", CheckoutUri);
            writer.WriteStringValue("commit_sha", CommitSha);
            writer.WriteStringValue("ref", Ref);
            writer.WriteStringValue("sarif", Sarif);
            writer.WriteDateTimeOffsetValue("started_at", StartedAt);
            writer.WriteStringValue("tool_name", ToolName);
        }
    }
}
