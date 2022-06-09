namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of application entities.</summary>
    public enum AppCredentialRestrictionType {
        PasswordAddition,
        PasswordLifetime,
        SymmetricKeyAddition,
        SymmetricKeyLifetime,
        CustomPasswordAddition,
        UnknownFutureValue,
    }
}
