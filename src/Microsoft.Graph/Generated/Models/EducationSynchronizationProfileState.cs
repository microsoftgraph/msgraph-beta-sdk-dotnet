using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum EducationSynchronizationProfileState {
        [EnumMember(Value = "deleting")]
        Deleting,
        [EnumMember(Value = "deletionFailed")]
        DeletionFailed,
        [EnumMember(Value = "provisioningFailed")]
        ProvisioningFailed,
        [EnumMember(Value = "provisioned")]
        Provisioned,
        [EnumMember(Value = "provisioning")]
        Provisioning,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
