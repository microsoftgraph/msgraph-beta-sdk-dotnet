// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>A list of possible assignment item action intent values on the application or configuration when executing this action on the managed device. For example, if the application or configuration is intended to be removed on the managed device, then the intent value is remove, and if the application or configuration already under removal through previous actions and is now intended to be restored on the managed device, then the intent value is restore</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum DeviceAssignmentItemIntent
    {
        /// <summary>Default. Indicates that the deployed application or configuration is intended to be removed on the managed device</summary>
        [EnumMember(Value = "remove")]
        Remove,
        /// <summary>Indicates that the application or configuration already under removal through previous actions and is now intended to be restored on the managed device</summary>
        [EnumMember(Value = "restore")]
        Restore,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
