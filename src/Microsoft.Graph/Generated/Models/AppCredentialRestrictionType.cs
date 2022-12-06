namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to application.</summary>
    public enum AppCredentialRestrictionType {
        PasswordAddition,
        PasswordLifetime,
        SymmetricKeyAddition,
        SymmetricKeyLifetime,
        CustomPasswordAddition,
        UnknownFutureValue,
    }
}
