namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
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
