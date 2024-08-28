// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Models
{
    /// <summary>The enforcement level of the ruleset. `evaluate` allows admins to test rules before enforcing them. Admins can view insights on the Rule Insights page.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public enum RepositoryRuleEnforcement
    {
        [EnumMember(Value = "disabled")]
        #pragma warning disable CS1591
        Disabled,
        #pragma warning restore CS1591
        [EnumMember(Value = "active")]
        #pragma warning disable CS1591
        Active,
        #pragma warning restore CS1591
        [EnumMember(Value = "evaluate")]
        #pragma warning disable CS1591
        Evaluate,
        #pragma warning restore CS1591
    }
}
