namespace Microsoft.Graph.Beta.Models {
    /// <summary>Specifies the type of scope for a Role Assignment.</summary>
    public enum RoleAssignmentScopeType {
        /// <summary>Allow assignments to the specified ResourceScopes.</summary>
        ResourceScope,
        /// <summary>Allow assignments to all Intune devices.</summary>
        AllDevices,
        /// <summary>Allow assignments to all Intune licensed users.</summary>
        AllLicensedUsers,
        /// <summary>Allow assignments to all Intune devices and licensed users.</summary>
        AllDevicesAndLicensedUsers,
    }
}
