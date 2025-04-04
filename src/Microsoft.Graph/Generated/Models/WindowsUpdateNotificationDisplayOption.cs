// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Windows Update Notification Display Options</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum WindowsUpdateNotificationDisplayOption
    {
        /// <summary>Not configured</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Use the default Windows Update notifications.</summary>
        [EnumMember(Value = "defaultNotifications")]
        DefaultNotifications,
        /// <summary>Turn off all notifications, excluding restart warnings.</summary>
        [EnumMember(Value = "restartWarningsOnly")]
        RestartWarningsOnly,
        /// <summary>Turn off all notifications, including restart warnings.</summary>
        [EnumMember(Value = "disableAllNotifications")]
        DisableAllNotifications,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
