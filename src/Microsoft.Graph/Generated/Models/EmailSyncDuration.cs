namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public enum EmailSyncDuration {
        /// <summary>User Defined, default value, no intent.</summary>
        UserDefined,
        /// <summary>Sync one day of email.</summary>
        OneDay,
        /// <summary>Sync three days of email.</summary>
        ThreeDays,
        /// <summary>Sync one week of email.</summary>
        OneWeek,
        /// <summary>Sync two weeks of email.</summary>
        TwoWeeks,
        /// <summary>Sync one month of email.</summary>
        OneMonth,
        /// <summary>Sync an unlimited duration of email.</summary>
        Unlimited,
    }
}
