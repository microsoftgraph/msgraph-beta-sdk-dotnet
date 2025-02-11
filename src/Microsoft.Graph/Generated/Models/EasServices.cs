// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Exchange Active Sync services.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    [Flags]
    public enum EasServices
    {
        [EnumMember(Value = "none")]
        #pragma warning disable CS1591
        None = 1,
        #pragma warning restore CS1591
        /// <summary>Enables synchronization of calendars.</summary>
        [EnumMember(Value = "calendars")]
        Calendars = 2,
        /// <summary>Enables synchronization of contacts.</summary>
        [EnumMember(Value = "contacts")]
        Contacts = 4,
        /// <summary>Enables synchronization of email.</summary>
        [EnumMember(Value = "email")]
        Email = 8,
        /// <summary>Enables synchronization of notes.</summary>
        [EnumMember(Value = "notes")]
        Notes = 16,
        /// <summary>Enables synchronization of reminders.</summary>
        [EnumMember(Value = "reminders")]
        Reminders = 32,
    }
}
