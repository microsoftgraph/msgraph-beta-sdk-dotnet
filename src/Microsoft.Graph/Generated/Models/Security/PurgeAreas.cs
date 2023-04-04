using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum PurgeAreas {
        [EnumMember(Value = "mailboxes")]
        Mailboxes,
        [EnumMember(Value = "teamsMessages")]
        TeamsMessages,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
