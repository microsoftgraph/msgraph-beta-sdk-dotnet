// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Management agent type.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum ManagementAgentType
    {
        /// <summary>The device is managed by Exchange server.</summary>
        [EnumMember(Value = "eas")]
        Eas,
        /// <summary>The device is managed by Intune MDM.</summary>
        [EnumMember(Value = "mdm")]
        Mdm,
        /// <summary>The device is managed by both Exchange server and Intune MDM.</summary>
        [EnumMember(Value = "easMdm")]
        EasMdm,
        /// <summary>Intune client managed.</summary>
        [EnumMember(Value = "intuneClient")]
        IntuneClient,
        /// <summary>The device is EAS and Intune client dual managed.</summary>
        [EnumMember(Value = "easIntuneClient")]
        EasIntuneClient,
        /// <summary>The device is managed by Configuration Manager.</summary>
        [EnumMember(Value = "configurationManagerClient")]
        ConfigurationManagerClient,
        /// <summary>The device is managed by Configuration Manager and MDM.</summary>
        [EnumMember(Value = "configurationManagerClientMdm")]
        ConfigurationManagerClientMdm,
        /// <summary>The device is managed by Configuration Manager, MDM and Eas.</summary>
        [EnumMember(Value = "configurationManagerClientMdmEas")]
        ConfigurationManagerClientMdmEas,
        /// <summary>Unknown management agent type.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>The device attributes are fetched from Jamf.</summary>
        [EnumMember(Value = "jamf")]
        Jamf,
        /// <summary>The device is managed by Google&apos;s CloudDPC.</summary>
        [EnumMember(Value = "googleCloudDevicePolicyController")]
        GoogleCloudDevicePolicyController,
        /// <summary>This device is managed by Microsoft 365 through Intune.</summary>
        [EnumMember(Value = "microsoft365ManagedMdm")]
        Microsoft365ManagedMdm,
        [EnumMember(Value = "msSense")]
        #pragma warning disable CS1591
        MsSense,
        #pragma warning restore CS1591
        /// <summary>This device is managed by Intune&apos;s MDM for AOSP (Android Open Source Project) devices</summary>
        [EnumMember(Value = "intuneAosp")]
        IntuneAosp,
        /// <summary>Indicates the management agent to manage the device is Google.</summary>
        [EnumMember(Value = "google")]
        Google,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
