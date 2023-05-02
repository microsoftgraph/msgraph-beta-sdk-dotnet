using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Describes which technology this setting can be deployed with</summary>
    public enum DeviceManagementConfigurationTechnologies {
        /// <summary>Default. Setting cannot be deployed through any channel.</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Setting can be deployed through the MDM channel.</summary>
        [EnumMember(Value = "mdm")]
        Mdm,
        /// <summary>Setting can be deployed through the Windows10XManagement channel</summary>
        [EnumMember(Value = "windows10XManagement")]
        Windows10XManagement,
        /// <summary>Setting can be deployed through the ConfigManager channel.</summary>
        [EnumMember(Value = "configManager")]
        ConfigManager,
        /// <summary>Setting can be deployed through the AppleRemoteManagement channel.</summary>
        [EnumMember(Value = "appleRemoteManagement")]
        AppleRemoteManagement,
        /// <summary>Setting can be deployed through the SENSE agent channel.</summary>
        [EnumMember(Value = "microsoftSense")]
        MicrosoftSense,
        /// <summary>Setting can be deployed through the Exchange Online agent channel.</summary>
        [EnumMember(Value = "exchangeOnline")]
        ExchangeOnline,
        /// <summary>Setting can be deployed through the Linux Mdm channel.</summary>
        [EnumMember(Value = "linuxMdm")]
        LinuxMdm,
        /// <summary>Setting can be deployed through device enrollment.</summary>
        [EnumMember(Value = "enrollment")]
        Enrollment,
        /// <summary>Setting can be deployed using the Endpoint privilege management channel</summary>
        [EnumMember(Value = "endpointPrivilegeManagement")]
        EndpointPrivilegeManagement,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
