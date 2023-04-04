using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Device health monitoring scope</summary>
    public enum WindowsHealthMonitoringScope {
        /// <summary>Undefined</summary>
        [EnumMember(Value = "undefined")]
        Undefined,
        /// <summary>Basic events for windows device health monitoring</summary>
        [EnumMember(Value = "healthMonitoring")]
        HealthMonitoring,
        /// <summary>Boot performance events</summary>
        [EnumMember(Value = "bootPerformance")]
        BootPerformance,
        /// <summary>Windows updates events</summary>
        [EnumMember(Value = "windowsUpdates")]
        WindowsUpdates,
        /// <summary>PrivilegeManagement</summary>
        [EnumMember(Value = "privilegeManagement")]
        PrivilegeManagement,
    }
}
