namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public enum RegistryHive {
        Unknown,
        CurrentConfig,
        CurrentUser,
        LocalMachineSam,
        LocalMachineSecurity,
        LocalMachineSoftware,
        LocalMachineSystem,
        UsersDefault,
        UnknownFutureValue,
    }
}
