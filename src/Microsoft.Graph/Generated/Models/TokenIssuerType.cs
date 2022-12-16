namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum TokenIssuerType {
        AzureAD,
        ADFederationServices,
        UnknownFutureValue,
        AzureADBackupAuth,
        ADFederationServicesMFAAdapter,
        NPSExtension,
    }
}
