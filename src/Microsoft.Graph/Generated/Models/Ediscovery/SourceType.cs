using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Ediscovery {
    public enum SourceType {
        [EnumMember(Value = "mailbox")]
        Mailbox,
        [EnumMember(Value = "site")]
        Site,
    }
}
