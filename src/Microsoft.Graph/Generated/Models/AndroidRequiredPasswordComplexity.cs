// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>The password complexity types that can be set on Android. One of: NONE, LOW, MEDIUM, HIGH. This is an API targeted to Android 11+.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum AndroidRequiredPasswordComplexity
    {
        /// <summary>Device default value, no password.</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>The required password complexity on the device is of type low as defined by the Android documentation.</summary>
        [EnumMember(Value = "low")]
        Low,
        /// <summary>The required password complexity on the device is of type medium as defined by the Android documentation.</summary>
        [EnumMember(Value = "medium")]
        Medium,
        /// <summary>The required password complexity on the device is of type high as defined by the Android documentation.</summary>
        [EnumMember(Value = "high")]
        High,
    }
}
