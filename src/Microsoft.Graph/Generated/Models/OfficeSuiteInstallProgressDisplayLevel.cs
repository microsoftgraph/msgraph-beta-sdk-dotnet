using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The Enum to specify the level of display for the Installation Progress Setup UI on the Device.</summary>
    public enum OfficeSuiteInstallProgressDisplayLevel {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "full")]
        Full,
    }
}
