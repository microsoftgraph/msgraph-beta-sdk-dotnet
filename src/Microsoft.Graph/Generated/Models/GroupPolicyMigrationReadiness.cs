namespace Microsoft.Graph.Beta.Models {
    /// <summary>Indicates if the Group Policy Object file is covered and ready for Intune migration.</summary>
    public enum GroupPolicyMigrationReadiness {
        /// <summary>No Intune coverage</summary>
        None,
        /// <summary>Partial Intune coverage</summary>
        Partial,
        /// <summary>Complete Intune coverage</summary>
        Complete,
        /// <summary>Error when analyzing coverage</summary>
        Error,
        /// <summary>No Group Policy settings in GPO</summary>
        NotApplicable,
    }
}
