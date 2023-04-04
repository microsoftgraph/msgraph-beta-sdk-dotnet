using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum WorkforceIntegrationEncryptionProtocol {
        [EnumMember(Value = "sharedSecret")]
        SharedSecret,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
