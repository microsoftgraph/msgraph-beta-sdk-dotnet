using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.CallRecords {
    public enum MediaStreamDirection {
        [EnumMember(Value = "callerToCallee")]
        CallerToCallee,
        [EnumMember(Value = "calleeToCaller")]
        CalleeToCaller,
    }
}
