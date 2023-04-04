using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ObjectFlowTypes {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Add")]
        Add,
        [EnumMember(Value = "Update")]
        Update,
        [EnumMember(Value = "Delete")]
        Delete,
    }
}
