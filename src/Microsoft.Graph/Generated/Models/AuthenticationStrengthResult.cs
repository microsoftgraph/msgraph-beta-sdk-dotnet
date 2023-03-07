namespace Microsoft.Graph.Beta.Models {
    public enum AuthenticationStrengthResult {
        NotSet,
        SkippedForProofUp,
        Satisfied,
        SingleChallengeRequired,
        MultipleChallengesRequired,
        SingleRegistrationRequired,
        MultipleRegistrationsRequired,
        CannotSatisfyDueToCombinationConfiguration,
        CannotSatisfy,
        UnknownFutureValue,
    }
}
