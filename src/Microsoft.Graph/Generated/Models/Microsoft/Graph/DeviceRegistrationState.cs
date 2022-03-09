namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the compliance singleton.</summary>
    public enum DeviceRegistrationState {
        NotRegistered,
        Registered,
        Revoked,
        KeyConflict,
        ApprovalPending,
        CertificateReset,
        NotRegisteredPendingEnrollment,
        Unknown,
    }
}
