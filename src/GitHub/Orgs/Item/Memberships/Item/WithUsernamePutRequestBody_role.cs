// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Orgs.Item.Memberships.Item
{
    /// <summary>The role to give the user in the organization. Can be one of:   * `admin` - The user will become an owner of the organization.   * `member` - The user will become a non-owner member of the organization.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public enum WithUsernamePutRequestBody_role
    {
        [EnumMember(Value = "admin")]
        #pragma warning disable CS1591
        Admin,
        #pragma warning restore CS1591
        [EnumMember(Value = "member")]
        #pragma warning disable CS1591
        Member,
        #pragma warning restore CS1591
    }
}
