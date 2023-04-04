using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ImportedDeviceIdentityType {
        /// <summary>Unknown value of importedDeviceIdentityType.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Device Identity is of type imei.</summary>
        [EnumMember(Value = "imei")]
        Imei,
        /// <summary>Device Identity is of type serial number.</summary>
        [EnumMember(Value = "serialNumber")]
        SerialNumber,
    }
}
