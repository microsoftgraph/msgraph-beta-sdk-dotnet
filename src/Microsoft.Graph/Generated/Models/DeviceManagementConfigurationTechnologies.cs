namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum DeviceManagementConfigurationTechnologies {
        /// <summary>Setting cannot be deployed through any channel</summary>
        None,
        /// <summary>Setting can be deployed through the MDM channel</summary>
        Mdm,
        /// <summary>Setting can be deployed through the Windows10XManagement channel</summary>
        Windows10XManagement,
        /// <summary>Setting can be deployed through the ConfigManager channel</summary>
        ConfigManager,
        /// <summary>Setting can be deployed through the AppleRemoteManagement channel</summary>
        AppleRemoteManagement,
        /// <summary>Setting can be deployed through the SENSE agent channel</summary>
        MicrosoftSense,
        /// <summary>Setting can be deployed through the Exchange Online agent channel</summary>
        ExchangeOnline,
        /// <summary>Setting can be deployed through the Linux Mdm channel</summary>
        LinuxMdm,
        /// <summary>Setting can be deployed through device enrollment.</summary>
        Enrollment,
        /// <summary>Sentinel member for cases where the client cannot handle the new enum values.</summary>
        UnknownFutureValue,
    }
}
