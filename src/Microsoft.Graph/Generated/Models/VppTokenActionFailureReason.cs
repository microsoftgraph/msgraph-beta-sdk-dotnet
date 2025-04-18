// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Possible types of reasons for an Apple Volume Purchase Program token action failure.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum VppTokenActionFailureReason
    {
        /// <summary>None.</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>There was an error on Apple&apos;s service.</summary>
        [EnumMember(Value = "appleFailure")]
        AppleFailure,
        /// <summary>There was an internal error.</summary>
        [EnumMember(Value = "internalError")]
        InternalError,
        /// <summary>There was an error because the Apple Volume Purchase Program token was expired.</summary>
        [EnumMember(Value = "expiredVppToken")]
        ExpiredVppToken,
        /// <summary>There was an error because the Apple Volume Purchase Program Push Notification certificate expired.</summary>
        [EnumMember(Value = "expiredApplePushNotificationCertificate")]
        ExpiredApplePushNotificationCertificate,
    }
}
