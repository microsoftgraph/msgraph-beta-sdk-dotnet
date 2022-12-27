namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum BaseAuthenticationMethod {
        Password,
        Voice,
        HardwareOath,
        SoftwareOath,
        Sms,
        Fido2,
        WindowsHelloForBusiness,
        MicrosoftAuthenticator,
        TemporaryAccessPass,
        Email,
        X509Certificate,
        Federation,
        UnknownFutureValue,
    }
}
