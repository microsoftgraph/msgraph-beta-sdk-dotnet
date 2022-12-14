namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the commsApplication singleton.</summary>
    public enum CallState {
        Incoming,
        Establishing,
        Ringing,
        Established,
        Hold,
        Transferring,
        TransferAccepted,
        Redirecting,
        Terminating,
        Terminated,
        UnknownFutureValue,
    }
}
