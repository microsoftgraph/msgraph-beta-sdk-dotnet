// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Device Exchange Access State Reason.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum DeviceManagementExchangeAccessStateReason
    {
        /// <summary>No access state reason discovered from Exchange</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Unknown access state reason</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Access state determined by Exchange Global rule</summary>
        [EnumMember(Value = "exchangeGlobalRule")]
        ExchangeGlobalRule,
        /// <summary>Access state determined by Exchange Individual rule</summary>
        [EnumMember(Value = "exchangeIndividualRule")]
        ExchangeIndividualRule,
        /// <summary>Access state determined by Exchange Device rule</summary>
        [EnumMember(Value = "exchangeDeviceRule")]
        ExchangeDeviceRule,
        /// <summary>Access state due to Exchange upgrade</summary>
        [EnumMember(Value = "exchangeUpgrade")]
        ExchangeUpgrade,
        /// <summary>Access state determined by Exchange Mailbox Policy</summary>
        [EnumMember(Value = "exchangeMailboxPolicy")]
        ExchangeMailboxPolicy,
        /// <summary>Access state determined by Exchange</summary>
        [EnumMember(Value = "other")]
        Other,
        /// <summary>Access state granted by compliance challenge</summary>
        [EnumMember(Value = "compliant")]
        Compliant,
        /// <summary>Access state revoked by compliance challenge</summary>
        [EnumMember(Value = "notCompliant")]
        NotCompliant,
        /// <summary>Access state revoked by management challenge</summary>
        [EnumMember(Value = "notEnrolled")]
        NotEnrolled,
        /// <summary>Access state due to unknown location</summary>
        [EnumMember(Value = "unknownLocation")]
        UnknownLocation,
        /// <summary>Access state due to MFA challenge</summary>
        [EnumMember(Value = "mfaRequired")]
        MfaRequired,
        /// <summary>Access State revoked by AAD Access Policy</summary>
        [EnumMember(Value = "azureADBlockDueToAccessPolicy")]
        AzureADBlockDueToAccessPolicy,
        /// <summary>Access State revoked by compromised password</summary>
        [EnumMember(Value = "compromisedPassword")]
        CompromisedPassword,
        /// <summary>Access state revoked by managed application challenge</summary>
        [EnumMember(Value = "deviceNotKnownWithManagedApp")]
        DeviceNotKnownWithManagedApp,
    }
}
