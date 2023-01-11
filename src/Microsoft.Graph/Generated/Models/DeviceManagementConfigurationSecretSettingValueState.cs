namespace Microsoft.Graph.Beta.Models {
    /// <summary>type tracking the encryption state of a secret setting value</summary>
    public enum DeviceManagementConfigurationSecretSettingValueState {
        /// <summary>default invalid value</summary>
        Invalid,
        /// <summary>secret value is not encrypted</summary>
        NotEncrypted,
        /// <summary>a token for the encrypted value is returned by the service</summary>
        EncryptedValueToken,
    }
}
