// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Orgs.Item
{
    /// <summary>Specifies which types of repositories non-admin organization members can create. **Note:** This parameter is deprecated and will be removed in the future. Its return value ignores internal repositories. Using this parameter overrides values set in `members_can_create_repositories`. See the parameter deprecation notice in the operation description for details.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public enum WithOrgPatchRequestBody_members_allowed_repository_creation_type
    {
        [EnumMember(Value = "all")]
        #pragma warning disable CS1591
        All,
        #pragma warning restore CS1591
        [EnumMember(Value = "private")]
        #pragma warning disable CS1591
        Private,
        #pragma warning restore CS1591
        [EnumMember(Value = "none")]
        #pragma warning disable CS1591
        None,
        #pragma warning restore CS1591
    }
}
