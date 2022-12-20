namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum DefaultMfaMethodType {
        None,
        MobilePhone,
        AlternateMobilePhone,
        OfficePhone,
        MicrosoftAuthenticatorPush,
        SoftwareOneTimePasscode,
        UnknownFutureValue,
    }
}
