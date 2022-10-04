namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public enum UserExperienceAnalyticsAnomalyState {
        /// <summary>Indicates the state of anomaly is new.</summary>
        New,
        /// <summary>Indicates the state of anomaly is active.</summary>
        Active,
        /// <summary>Indicates the state of anomaly is disabled.</summary>
        Disabled,
        /// <summary>Indicates the state of anomaly is removed.</summary>
        Removed,
        /// <summary>Indicates the state of anomaly is undefined.</summary>
        Other,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        UnknownFutureValue,
    }
}
