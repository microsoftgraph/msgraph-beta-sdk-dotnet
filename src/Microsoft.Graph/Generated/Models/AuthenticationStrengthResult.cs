using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum AuthenticationStrengthResult {
        [EnumMember(Value = "notSet")]
        NotSet,
        [EnumMember(Value = "skippedForProofUp")]
        SkippedForProofUp,
        [EnumMember(Value = "satisfied")]
        Satisfied,
        [EnumMember(Value = "singleChallengeRequired")]
        SingleChallengeRequired,
        [EnumMember(Value = "multipleChallengesRequired")]
        MultipleChallengesRequired,
        [EnumMember(Value = "singleRegistrationRequired")]
        SingleRegistrationRequired,
        [EnumMember(Value = "multipleRegistrationsRequired")]
        MultipleRegistrationsRequired,
        [EnumMember(Value = "cannotSatisfyDueToCombinationConfiguration")]
        CannotSatisfyDueToCombinationConfiguration,
        [EnumMember(Value = "cannotSatisfy")]
        CannotSatisfy,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
