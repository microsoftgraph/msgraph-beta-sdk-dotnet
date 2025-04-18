// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public enum BrowserSharedCookieStatus
    #pragma warning restore CS1591
    {
        /// <summary>A sharedcookie that has been published</summary>
        [EnumMember(Value = "published")]
        Published,
        /// <summary>A sharedcookie that has been added pending publish</summary>
        [EnumMember(Value = "pendingAdd")]
        PendingAdd,
        /// <summary>A sharedcookie that has been edited pending publish</summary>
        [EnumMember(Value = "pendingEdit")]
        PendingEdit,
        /// <summary>A sharedcookie that has been deleted pending publish</summary>
        [EnumMember(Value = "pendingDelete")]
        PendingDelete,
        /// <summary>Placeholder for evolvable enum, but this enum is never returned to the caller, so it shouldn&apos;t be necessary.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
