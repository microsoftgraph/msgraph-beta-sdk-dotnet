using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Flag enum to determine whether to delay software updates for macOS.</summary>
    public enum MacOSSoftwareUpdateDelayPolicy {
        /// <summary>Software update delays will not be enforced.</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Force delays for OS software updates.</summary>
        [EnumMember(Value = "delayOSUpdateVisibility")]
        DelayOSUpdateVisibility,
        /// <summary>Force delays for app software updates.</summary>
        [EnumMember(Value = "delayAppUpdateVisibility")]
        DelayAppUpdateVisibility,
        /// <summary>Sentinel member for cases where the client cannot handle the new enum values.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        /// <summary>Force delays for major OS software updates.</summary>
        [EnumMember(Value = "delayMajorOsUpdateVisibility")]
        DelayMajorOsUpdateVisibility,
    }
}
