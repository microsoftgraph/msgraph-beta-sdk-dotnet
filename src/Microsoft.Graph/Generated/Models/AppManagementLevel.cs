using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Management levels for apps</summary>
    public enum AppManagementLevel {
        /// <summary>Unspecified</summary>
        [EnumMember(Value = "unspecified")]
        Unspecified,
        /// <summary>Unmanaged</summary>
        [EnumMember(Value = "unmanaged")]
        Unmanaged,
        /// <summary>MDM</summary>
        [EnumMember(Value = "mdm")]
        Mdm,
        /// <summary>Android Enterprise</summary>
        [EnumMember(Value = "androidEnterprise")]
        AndroidEnterprise,
        /// <summary>Android Enterprise dedicated devices with Azure AD Shared mode</summary>
        [EnumMember(Value = "androidEnterpriseDedicatedDevicesWithAzureAdSharedMode")]
        AndroidEnterpriseDedicatedDevicesWithAzureAdSharedMode,
        /// <summary>Android Open Source Project (AOSP) devices</summary>
        [EnumMember(Value = "androidOpenSourceProjectUserAssociated")]
        AndroidOpenSourceProjectUserAssociated,
        /// <summary>Android Open Source Project (AOSP) userless devices</summary>
        [EnumMember(Value = "androidOpenSourceProjectUserless")]
        AndroidOpenSourceProjectUserless,
        /// <summary>Place holder for evolvable enum</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
