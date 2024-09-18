// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Teams.Item.Repos.Item.Item
{
    /// <summary>The permission to grant the team on this repository. If no permission is specified, the team&apos;s `permission` attribute will be used to determine what permission to grant the team on this repository.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public enum WithRepoPutRequestBody_permission
    {
        [EnumMember(Value = "pull")]
        #pragma warning disable CS1591
        Pull,
        #pragma warning restore CS1591
        [EnumMember(Value = "push")]
        #pragma warning disable CS1591
        Push,
        #pragma warning restore CS1591
        [EnumMember(Value = "admin")]
        #pragma warning disable CS1591
        Admin,
        #pragma warning restore CS1591
    }
}
