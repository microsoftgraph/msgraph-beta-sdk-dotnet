using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ManagedDeviceRemoteAction {
        /// <summary>Name of the retire action.</summary>
        [EnumMember(Value = "retire")]
        Retire,
        /// <summary>Name of the delete action.</summary>
        [EnumMember(Value = "delete")]
        Delete,
        /// <summary>Name of the full Scan action.</summary>
        [EnumMember(Value = "fullScan")]
        FullScan,
        /// <summary>Name of the Quick Scan action.</summary>
        [EnumMember(Value = "quickScan")]
        QuickScan,
        /// <summary>Signature Update action</summary>
        [EnumMember(Value = "signatureUpdate")]
        SignatureUpdate,
        /// <summary>Name of the wipe action.</summary>
        [EnumMember(Value = "wipe")]
        Wipe,
        /// <summary>Name of the Custom Text Notification action.</summary>
        [EnumMember(Value = "customTextNotification")]
        CustomTextNotification,
        /// <summary>Name of the reboot now action.</summary>
        [EnumMember(Value = "rebootNow")]
        RebootNow,
        /// <summary>Set Device Name action.</summary>
        [EnumMember(Value = "setDeviceName")]
        SetDeviceName,
        /// <summary>Sync Device action.</summary>
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
        /// <summary>Evolvable enum member</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
