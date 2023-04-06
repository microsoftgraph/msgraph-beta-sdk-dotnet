using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum SetupStatus {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "notRegisteredYet")]
        NotRegisteredYet,
        [EnumMember(Value = "registeredSetupNotStarted")]
        RegisteredSetupNotStarted,
        [EnumMember(Value = "registeredSetupInProgress")]
        RegisteredSetupInProgress,
        [EnumMember(Value = "registrationAndSetupCompleted")]
        RegistrationAndSetupCompleted,
        [EnumMember(Value = "registrationFailed")]
        RegistrationFailed,
        [EnumMember(Value = "registrationTimedOut")]
        RegistrationTimedOut,
        [EnumMember(Value = "disabled")]
        Disabled,
    }
}
