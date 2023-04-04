using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Models and Manufactures meatadata for managed devices in the account</summary>
    public enum WarrantyType {
        /// <summary>Unknown warranty type</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Manufacturer warranty</summary>
        [EnumMember(Value = "manufacturer")]
        Manufacturer,
        /// <summary>Contractual warranty</summary>
        [EnumMember(Value = "contractual")]
        Contractual,
        /// <summary>Unknown future value</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
