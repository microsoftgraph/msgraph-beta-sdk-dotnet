namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public enum UserExperienceAnalyticsAnomalySeverity {
        /// <summary>Indicates the anomaly is of high severity.</summary>
        High,
        /// <summary>Indicates the anomaly is of medium severity.</summary>
        Medium,
        /// <summary>Indicates the anomaly is of low severity.</summary>
        Low,
        /// <summary>Indicates the anomaly is of informational severity.</summary>
        Informational,
        /// <summary>Indicates the severity of anomaly is undefined.</summary>
        Other,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        UnknownFutureValue,
    }
}
