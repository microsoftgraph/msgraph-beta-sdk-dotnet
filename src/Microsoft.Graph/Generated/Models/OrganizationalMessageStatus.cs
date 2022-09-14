namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public enum OrganizationalMessageStatus {
        /// <summary>Indicates that the message has been scheduled for a future date</summary>
        Scheduled,
        /// <summary>Indicates that the message is currently live and being presented to clients</summary>
        Active,
        /// <summary>Indicates that the message has been displayed to users already and is no longer active</summary>
        Completed,
        /// <summary>Indicates that the message has been cancelled and will not be shown</summary>
        Cancelled,
        /// <summary>UnknownFutureValue, Evolvable enumeration sentinel value. Do not use.</summary>
        UnknownFutureValue,
    }
}
