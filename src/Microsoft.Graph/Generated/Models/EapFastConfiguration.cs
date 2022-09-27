namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public enum EapFastConfiguration {
        /// <summary>Use EAP-FAST without Protected Access Credential (PAC).</summary>
        NoProtectedAccessCredential,
        /// <summary>Use Protected Access Credential (PAC).</summary>
        UseProtectedAccessCredential,
        /// <summary>Use Protected Access Credential (PAC) and Provision PAC.</summary>
        UseProtectedAccessCredentialAndProvision,
        /// <summary>Use Protected Access Credential (PAC), Provision PAC, and do so anonymously.</summary>
        UseProtectedAccessCredentialAndProvisionAnonymously,
    }
}
