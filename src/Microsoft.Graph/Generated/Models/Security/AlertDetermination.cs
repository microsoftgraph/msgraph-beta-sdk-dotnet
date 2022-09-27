namespace Microsoft.Graph.Beta.Models.Security {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public enum AlertDetermination {
        Unknown,
        Apt,
        Malware,
        SecurityPersonnel,
        SecurityTesting,
        UnwantedSoftware,
        Other,
        MultiStagedAttack,
        CompromisedAccount,
        Phishing,
        MaliciousUserActivity,
        NotMalicious,
        NotEnoughDataToValidate,
        ConfirmedActivity,
        LineOfBusinessApplication,
        UnknownFutureValue,
    }
}
