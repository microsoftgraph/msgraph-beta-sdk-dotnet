using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ManagedDeviceRemoteAction {
        [EnumMember(Value = "retire")]
        Retire,
        [EnumMember(Value = "delete")]
        Delete,
        [EnumMember(Value = "fullScan")]
        FullScan,
        [EnumMember(Value = "quickScan")]
        QuickScan,
        [EnumMember(Value = "signatureUpdate")]
        SignatureUpdate,
        [EnumMember(Value = "wipe")]
        Wipe,
        [EnumMember(Value = "customTextNotification")]
        CustomTextNotification,
        [EnumMember(Value = "rebootNow")]
        RebootNow,
        [EnumMember(Value = "setDeviceName")]
        SetDeviceName,
        [EnumMember(Value = "syncDevice")]
        SyncDevice,
        /// <summary>Name of the deprovision action.</summary>
        [EnumMember(Value = "deprovision")]
        Deprovision,
        /// <summary>Name of the disable action.</summary>
        [EnumMember(Value = "disable")]
        Disable,
        /// <summary>Name of the reenable action.</summary>
        [EnumMember(Value = "reenable")]
        Reenable,
        /// <summary>Name of the moveDevicesToOU action.</summary>
        [EnumMember(Value = "moveDeviceToOrganizationalUnit")]
        MoveDeviceToOrganizationalUnit,
        /// <summary>Name of action to Activate eSIM on the device.</summary>
        [EnumMember(Value = "activateDeviceEsim")]
        ActivateDeviceEsim,
        /// <summary>Name of the collectDiagnostics action.</summary>
        [EnumMember(Value = "collectDiagnostics")]
        CollectDiagnostics,
        /// <summary>Name of action to initiate MDM key recovery</summary>
        [EnumMember(Value = "initiateMobileDeviceManagementKeyRecovery")]
        InitiateMobileDeviceManagementKeyRecovery,
        /// <summary>Name of action to initiate On Demand Proactive Remediation</summary>
        [EnumMember(Value = "initiateOnDemandProactiveRemediation")]
        InitiateOnDemandProactiveRemediation,
    }
}
