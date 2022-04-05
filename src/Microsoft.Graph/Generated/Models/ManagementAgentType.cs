namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the compliance singleton.</summary>
    public enum ManagementAgentType {
        Eas,
        Mdm,
        EasMdm,
        IntuneClient,
        EasIntuneClient,
        ConfigurationManagerClient,
        ConfigurationManagerClientMdm,
        ConfigurationManagerClientMdmEas,
        Unknown,
        Jamf,
        GoogleCloudDevicePolicyController,
        Microsoft365ManagedMdm,
        MsSense,
        IntuneAosp,
    }
}
