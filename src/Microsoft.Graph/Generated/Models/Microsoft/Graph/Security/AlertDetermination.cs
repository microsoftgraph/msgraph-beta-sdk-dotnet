namespace MicrosoftGraph.Models.Microsoft.Graph.Security {
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
