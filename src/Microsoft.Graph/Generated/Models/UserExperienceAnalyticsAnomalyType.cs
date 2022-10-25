namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public enum UserExperienceAnalyticsAnomalyType {
        /// <summary>Indicates the detected anomaly is due to certain devices.</summary>
        Device,
        /// <summary>Indicates the detected anomaly is due to a specific application.</summary>
        Application,
        /// <summary>Indicates the detected anomaly is due to a specific stop error.</summary>
        StopError,
        /// <summary>Indicates the detected anomaly is due to a specific driver.</summary>
        Driver,
        /// <summary>Indicates the category of detected anomaly is undefined.</summary>
        Other,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        UnknownFutureValue,
    }
}
