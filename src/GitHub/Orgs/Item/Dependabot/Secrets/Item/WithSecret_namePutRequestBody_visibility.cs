// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Orgs.Item.Dependabot.Secrets.Item
{
    /// <summary>Which type of organization repositories have access to the organization secret. `selected` means only the repositories specified by `selected_repository_ids` can access the secret.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public enum WithSecret_namePutRequestBody_visibility
    {
        [EnumMember(Value = "all")]
        #pragma warning disable CS1591
        All,
        #pragma warning restore CS1591
        [EnumMember(Value = "private")]
        #pragma warning disable CS1591
        Private,
        #pragma warning restore CS1591
        [EnumMember(Value = "selected")]
        #pragma warning disable CS1591
        Selected,
        #pragma warning restore CS1591
    }
}
