// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Possible ways of adding a mobile device to management.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum DeviceEnrollmentType
    {
        /// <summary>Default value, enrollment type was not collected.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>User driven enrollment through BYOD channel.</summary>
        [EnumMember(Value = "userEnrollment")]
        UserEnrollment,
        /// <summary>User enrollment with a device enrollment manager account.</summary>
        [EnumMember(Value = "deviceEnrollmentManager")]
        DeviceEnrollmentManager,
        /// <summary>Apple bulk enrollment with user challenge. (DEP, Apple Configurator)</summary>
        [EnumMember(Value = "appleBulkWithUser")]
        AppleBulkWithUser,
        /// <summary>Apple bulk enrollment without user challenge. (DEP, Apple Configurator, Mobile Config)</summary>
        [EnumMember(Value = "appleBulkWithoutUser")]
        AppleBulkWithoutUser,
        /// <summary>Windows 10 Entra ID (Azure AD) Join.</summary>
        [EnumMember(Value = "windowsAzureADJoin")]
        WindowsAzureADJoin,
        /// <summary>Windows 10 Bulk enrollment through ICD with certificate.</summary>
        [EnumMember(Value = "windowsBulkUserless")]
        WindowsBulkUserless,
        /// <summary>Windows 10 automatic enrollment. (Add work account)</summary>
        [EnumMember(Value = "windowsAutoEnrollment")]
        WindowsAutoEnrollment,
        /// <summary>Windows 10 bulk Entra ID (Azure AD) Join.</summary>
        [EnumMember(Value = "windowsBulkAzureDomainJoin")]
        WindowsBulkAzureDomainJoin,
        /// <summary>Windows 10 Co-Management triggered by AutoPilot or Group Policy.</summary>
        [EnumMember(Value = "windowsCoManagement")]
        WindowsCoManagement,
        /// <summary>Windows 10 Entra ID (Azure AD) Join using Device Auth.</summary>
        [EnumMember(Value = "windowsAzureADJoinUsingDeviceAuth")]
        WindowsAzureADJoinUsingDeviceAuth,
        /// <summary>Indicates the device is enrolled via Apple User Enrollment with Company Portal. It results in an enrollment with a new partition for managed apps and data and which supports a limited set of management capabilities</summary>
        [EnumMember(Value = "appleUserEnrollment")]
        AppleUserEnrollment,
        /// <summary>Indicates the device is enrolled via Apple User Enrollment with Company Portal using a device enrollment manager user. It results in an enrollment with a new partition for managed apps and data and which supports a limited set of management capabilities</summary>
        [EnumMember(Value = "appleUserEnrollmentWithServiceAccount")]
        AppleUserEnrollmentWithServiceAccount,
        /// <summary>Entra ID (Azure AD) Join enrollment when an Azure VM is provisioned</summary>
        [EnumMember(Value = "azureAdJoinUsingAzureVmExtension")]
        AzureAdJoinUsingAzureVmExtension,
        /// <summary>Android Enterprise Dedicated Device</summary>
        [EnumMember(Value = "androidEnterpriseDedicatedDevice")]
        AndroidEnterpriseDedicatedDevice,
        /// <summary>Android Enterprise Fully Managed</summary>
        [EnumMember(Value = "androidEnterpriseFullyManaged")]
        AndroidEnterpriseFullyManaged,
        /// <summary>Android Enterprise Corporate Work Profile</summary>
        [EnumMember(Value = "androidEnterpriseCorporateWorkProfile")]
        AndroidEnterpriseCorporateWorkProfile,
        /// <summary>Indicates the device enrollment is for android device owned by/associated with user using Android Open Source Project (AOSP) on a non-Google mobile services.</summary>
        [EnumMember(Value = "androidAOSPUserOwnedDeviceEnrollment")]
        AndroidAOSPUserOwnedDeviceEnrollment,
        /// <summary>Indicates the device enrollment is for user less android device using Android Open Source Project (AOSP) on a non-Google mobile services.</summary>
        [EnumMember(Value = "androidAOSPUserlessDeviceEnrollment")]
        AndroidAOSPUserlessDeviceEnrollment,
        /// <summary>Indicates the device is enrolled via Apple Account Driven User Enrollment, a form of enrollment where the user enrolls via iOS Settings without using the iOS Company Portal. It results in an enrollment with a new partition for managed apps and data and which supports a limited set of management capabilities.</summary>
        [EnumMember(Value = "appleAccountDrivenUserEnrollment")]
        AppleAccountDrivenUserEnrollment,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
