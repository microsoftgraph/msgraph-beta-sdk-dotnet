using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Exchange Active Sync services.</summary>
    public enum EasServices {
        [EnumMember(Value = "none")]
        None,
        /// <summary>Enables synchronization of calendars.</summary>
        [EnumMember(Value = "calendars")]
        Calendars,
        /// <summary>Enables synchronization of contacts.</summary>
        [EnumMember(Value = "contacts")]
        Contacts,
        /// <summary>Enables synchronization of email.</summary>
        [EnumMember(Value = "email")]
        Email,
        /// <summary>Enables synchronization of notes.</summary>
        [EnumMember(Value = "notes")]
        Notes,
        /// <summary>Enables synchronization of reminders.</summary>
        [EnumMember(Value = "reminders")]
        Reminders,
    }
}
