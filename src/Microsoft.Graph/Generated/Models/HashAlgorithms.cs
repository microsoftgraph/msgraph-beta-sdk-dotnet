using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Hash Algorithm Options.</summary>
    public enum HashAlgorithms {
        /// <summary>SHA-1 Hash Algorithm.</summary>
        [EnumMember(Value = "sha1")]
        Sha1,
        /// <summary>SHA-2 Hash Algorithm.</summary>
        [EnumMember(Value = "sha2")]
        Sha2,
    }
}
