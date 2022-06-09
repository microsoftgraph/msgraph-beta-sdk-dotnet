namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum DefenderSubmitSamplesConsentType {
        /// <summary>Send safe samples automatically</summary>
        SendSafeSamplesAutomatically,
        /// <summary>Always prompt</summary>
        AlwaysPrompt,
        /// <summary>Never send</summary>
        NeverSend,
        /// <summary>Send all samples automatically</summary>
        SendAllSamplesAutomatically,
    }
}
