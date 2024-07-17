// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Models {
    /// <summary>**Required when the state is dismissed.** The reason for dismissing or closing the alert.</summary>
    public enum CodeScanningAlertDismissedReason
    {
        [EnumMember(Value = "false positive")]
        #pragma warning disable CS1591
        FalsePositive,
        #pragma warning restore CS1591
        [EnumMember(Value = "won't fix")]
        #pragma warning disable CS1591
        WonTFix,
        #pragma warning restore CS1591
        [EnumMember(Value = "used in tests")]
        #pragma warning disable CS1591
        UsedInTests,
        #pragma warning restore CS1591
    }
}
