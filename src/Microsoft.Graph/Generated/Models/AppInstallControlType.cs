// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>App Install control Setting</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum AppInstallControlType
    {
        /// <summary>Not configured</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Turn off app recommendations</summary>
        [EnumMember(Value = "anywhere")]
        Anywhere,
        /// <summary>Allow apps from Store only</summary>
        [EnumMember(Value = "storeOnly")]
        StoreOnly,
        /// <summary>Show me app recommendations</summary>
        [EnumMember(Value = "recommendations")]
        Recommendations,
        /// <summary>Warn me before installing apps from outside the Store</summary>
        [EnumMember(Value = "preferStore")]
        PreferStore,
    }
}
