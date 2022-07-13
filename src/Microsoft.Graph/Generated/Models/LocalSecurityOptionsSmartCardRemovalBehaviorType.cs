namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public enum LocalSecurityOptionsSmartCardRemovalBehaviorType {
        /// <summary>No Action</summary>
        NoAction,
        /// <summary>Lock Workstation</summary>
        LockWorkstation,
        /// <summary>Force Logoff</summary>
        ForceLogoff,
        /// <summary>Disconnect if a remote Remote Desktop Services session</summary>
        DisconnectRemoteDesktopSession,
    }
}
