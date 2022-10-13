namespace Microsoft.Graph.Beta.Models.Security {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public enum SubmissionResultCategory {
        NotJunk,
        Spam,
        Phishing,
        Malware,
        AllowedByPolicy,
        BlockedByPolicy,
        Spoof,
        Unknown,
        NoResultAvailable,
        UnknownFutureValue,
    }
}
