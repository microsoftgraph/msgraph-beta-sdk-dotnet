using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Key Usage Options.</summary>
    public enum KeyUsages {
        /// <summary>Key Encipherment Usage.</summary>
        [EnumMember(Value = "keyEncipherment")]
        KeyEncipherment,
        /// <summary>Digital Signature Usage.</summary>
        [EnumMember(Value = "digitalSignature")]
        DigitalSignature,
    }
}
