using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The Enum to specify the Office365 Updates Channel.</summary>
    public enum OfficeUpdateChannel {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "current")]
        Current,
        [EnumMember(Value = "deferred")]
        Deferred,
        [EnumMember(Value = "firstReleaseCurrent")]
        FirstReleaseCurrent,
        [EnumMember(Value = "firstReleaseDeferred")]
        FirstReleaseDeferred,
        [EnumMember(Value = "monthlyEnterprise")]
        MonthlyEnterprise,
    }
}
