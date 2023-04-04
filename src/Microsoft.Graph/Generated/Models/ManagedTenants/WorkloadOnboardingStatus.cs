using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public enum WorkloadOnboardingStatus {
        [EnumMember(Value = "notOnboarded")]
        NotOnboarded,
        [EnumMember(Value = "onboarded")]
        Onboarded,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
