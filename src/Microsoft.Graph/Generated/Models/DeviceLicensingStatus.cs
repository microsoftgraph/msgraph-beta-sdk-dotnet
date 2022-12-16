namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum DeviceLicensingStatus {
        /// <summary>Default. Set to unknown when status cannot be determined.</summary>
        Unknown,
        /// <summary>This status is set when the license refresh is started.</summary>
        LicenseRefreshStarted,
        /// <summary>This status is set when the license refresh is pending.</summary>
        LicenseRefreshPending,
        /// <summary>This status is set when the device is not joined to Azure Active Directory.</summary>
        DeviceIsNotAzureActiveDirectoryJoined,
        /// <summary>This status is set when the Microsoft device identity is being verified.</summary>
        VerifyingMicrosoftDeviceIdentity,
        /// <summary>This status is set when the Microsoft device identity verification fails.</summary>
        DeviceIdentityVerificationFailed,
        /// <summary>This status is set when the Microsoft account identity is being verified.</summary>
        VerifyingMirosoftAccountIdentity,
        /// <summary>This status is set when the Microsoft account identity verification fails.</summary>
        MirosoftAccountVerificationFailed,
        /// <summary>This status is set when the device license is being acquired.</summary>
        AcquiringDeviceLicense,
        /// <summary>This status is set when the device license is being refreshed.</summary>
        RefreshingDeviceLicense,
        /// <summary>This status is set when the device license refresh succeeds.</summary>
        DeviceLicenseRefreshSucceed,
        /// <summary>This status is set when the device license refresh fails.</summary>
        DeviceLicenseRefreshFailed,
        /// <summary>This status is set when the device license is being removed.</summary>
        RemovingDeviceLicense,
        /// <summary>This status is set when the device license removing succeeds.</summary>
        DeviceLicenseRemoveSucceed,
        /// <summary>This status is set when the device license removing fails.</summary>
        DeviceLicenseRemoveFailed,
        /// <summary>This is put here as a place holder for future extension.</summary>
        UnknownFutureValue,
    }
}
