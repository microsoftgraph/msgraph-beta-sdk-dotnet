namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public enum AuthenticationMethodModes {
        Password,
        Voice,
        HardwareOath,
        SoftwareOath,
        Sms,
        Fido2,
        WindowsHelloForBusiness,
        MicrosoftAuthenticatorPush,
        DeviceBasedPush,
        TemporaryAccessPassOneTime,
        TemporaryAccessPassMultiUse,
        Email,
        X509CertificateSingleFactor,
        X509CertificateMultiFactor,
        FederatedSingleFactor,
        FederatedMultiFactor,
        UnknownFutureValue,
    }
}
