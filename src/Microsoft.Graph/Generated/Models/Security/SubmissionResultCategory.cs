namespace Microsoft.Graph.Beta.Models.Security {
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
