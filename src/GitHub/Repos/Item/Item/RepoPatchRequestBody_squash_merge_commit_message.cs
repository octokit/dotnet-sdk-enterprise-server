// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Repos.Item.Item
{
    /// <summary>The default value for a squash merge commit message:- `PR_BODY` - default to the pull request&apos;s body.- `COMMIT_MESSAGES` - default to the branch&apos;s commit messages.- `BLANK` - default to a blank commit message.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public enum RepoPatchRequestBody_squash_merge_commit_message
    {
        [EnumMember(Value = "PR_BODY")]
        #pragma warning disable CS1591
        PR_BODY,
        #pragma warning restore CS1591
        [EnumMember(Value = "COMMIT_MESSAGES")]
        #pragma warning disable CS1591
        COMMIT_MESSAGES,
        #pragma warning restore CS1591
        [EnumMember(Value = "BLANK")]
        #pragma warning disable CS1591
        BLANK,
        #pragma warning restore CS1591
    }
}
