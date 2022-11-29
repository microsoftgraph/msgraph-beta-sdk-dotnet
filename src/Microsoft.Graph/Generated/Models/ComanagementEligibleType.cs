namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum ComanagementEligibleType {
        Comanaged,
        Eligible,
        EligibleButNotAzureAdJoined,
        NeedsOsUpdate,
        Ineligible,
        /// <summary>Devices scheduled for Co-Management enrollment</summary>
        ScheduledForEnrollment,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        UnknownFutureValue,
    }
}
