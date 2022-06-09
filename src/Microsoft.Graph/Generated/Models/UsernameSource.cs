namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public enum UsernameSource {
        /// <summary>User principal name.</summary>
        UserPrincipalName,
        /// <summary>Primary SMTP address.</summary>
        PrimarySmtpAddress,
        /// <summary>The user sam account name.</summary>
        SamAccountName,
    }
}
