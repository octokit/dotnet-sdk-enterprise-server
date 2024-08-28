// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Models
{
    /// <summary>A classification of the file. For example to identify it as generated.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public enum CodeScanningAlertClassification
    {
        [EnumMember(Value = "source")]
        #pragma warning disable CS1591
        Source,
        #pragma warning restore CS1591
        [EnumMember(Value = "generated")]
        #pragma warning disable CS1591
        Generated,
        #pragma warning restore CS1591
        [EnumMember(Value = "test")]
        #pragma warning disable CS1591
        Test,
        #pragma warning restore CS1591
        [EnumMember(Value = "library")]
        #pragma warning disable CS1591
        Library,
        #pragma warning restore CS1591
    }
}
