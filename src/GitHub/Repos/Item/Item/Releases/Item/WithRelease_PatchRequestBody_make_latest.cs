// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Repos.Item.Item.Releases.Item
{
    /// <summary>Specifies whether this release should be set as the latest release for the repository. Drafts and prereleases cannot be set as latest. Defaults to `true` for newly published releases. `legacy` specifies that the latest release should be determined based on the release creation date and higher semantic version.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public enum WithRelease_PatchRequestBody_make_latest
    {
        [EnumMember(Value = "true")]
        #pragma warning disable CS1591
        True,
        #pragma warning restore CS1591
        [EnumMember(Value = "false")]
        #pragma warning disable CS1591
        False,
        #pragma warning restore CS1591
        [EnumMember(Value = "legacy")]
        #pragma warning disable CS1591
        Legacy,
        #pragma warning restore CS1591
    }
}
