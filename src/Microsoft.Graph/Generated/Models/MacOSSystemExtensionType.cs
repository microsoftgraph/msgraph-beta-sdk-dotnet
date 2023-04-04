using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Flag enum representing the allowed macOS system extension types.</summary>
    public enum MacOSSystemExtensionType {
        /// <summary>Enables driver extensions.</summary>
        [EnumMember(Value = "driverExtensionsAllowed")]
        DriverExtensionsAllowed,
        /// <summary>Enables network extensions.</summary>
        [EnumMember(Value = "networkExtensionsAllowed")]
        NetworkExtensionsAllowed,
        /// <summary>Enables endpoint security extensions.</summary>
        [EnumMember(Value = "endpointSecurityExtensionsAllowed")]
        EndpointSecurityExtensionsAllowed,
    }
}
