namespace Microsoft.Graph.Beta.Models {
    /// <summary>The enrollment mode for an enrollment profile.</summary>
    public enum AndroidDeviceOwnerEnrollmentMode {
        CorporateOwnedDedicatedDevice,
        CorporateOwnedFullyManaged,
        CorporateOwnedWorkProfile,
        /// <summary>Corporate owned, userless Android Open Source Project (AOSP) device, without Google Mobile Services.</summary>
        CorporateOwnedAOSPUserlessDevice,
        /// <summary>Corporate owned, user-associated Android Open Source Project (AOSP) device, without Google Mobile Services.</summary>
        CorporateOwnedAOSPUserAssociatedDevice,
    }
}
