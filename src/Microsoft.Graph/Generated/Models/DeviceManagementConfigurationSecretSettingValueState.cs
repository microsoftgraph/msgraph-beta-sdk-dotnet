namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public enum DeviceManagementConfigurationSecretSettingValueState {
        /// <summary>default invalid value</summary>
        Invalid,
        /// <summary>secret value is not encrypted</summary>
        NotEncrypted,
        /// <summary>a token for the encrypted value is returned by the service</summary>
        EncryptedValueToken,
    }
}
