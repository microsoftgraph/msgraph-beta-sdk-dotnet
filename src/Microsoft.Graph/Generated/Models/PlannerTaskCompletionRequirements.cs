using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum PlannerTaskCompletionRequirements {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "checklistCompletion")]
        ChecklistCompletion,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
