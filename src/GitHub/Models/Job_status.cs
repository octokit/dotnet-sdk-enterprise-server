// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Models
{
    /// <summary>The phase of the lifecycle that the job is currently in.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public enum Job_status
    {
        [EnumMember(Value = "queued")]
        #pragma warning disable CS1591
        Queued,
        #pragma warning restore CS1591
        [EnumMember(Value = "in_progress")]
        #pragma warning disable CS1591
        In_progress,
        #pragma warning restore CS1591
        [EnumMember(Value = "completed")]
        #pragma warning disable CS1591
        Completed,
        #pragma warning restore CS1591
        [EnumMember(Value = "waiting")]
        #pragma warning disable CS1591
        Waiting,
        #pragma warning restore CS1591
        [EnumMember(Value = "requested")]
        #pragma warning disable CS1591
        Requested,
        #pragma warning restore CS1591
        [EnumMember(Value = "pending")]
        #pragma warning disable CS1591
        Pending,
        #pragma warning restore CS1591
    }
}
