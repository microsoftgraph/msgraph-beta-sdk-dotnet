// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>The classes of apps that are allowed to click-to-open a phone number, for making phone calls or sending text messages.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum ManagedAppPhoneNumberRedirectLevel
    {
        /// <summary>Sharing is allowed to all apps.</summary>
        [EnumMember(Value = "allApps")]
        AllApps,
        /// <summary>Sharing is allowed to all managed apps.</summary>
        [EnumMember(Value = "managedApps")]
        ManagedApps,
        /// <summary>Sharing is allowed to a custom app.</summary>
        [EnumMember(Value = "customApp")]
        CustomApp,
        /// <summary>Sharing between apps is blocked.</summary>
        [EnumMember(Value = "blocked")]
        Blocked,
    }
}
