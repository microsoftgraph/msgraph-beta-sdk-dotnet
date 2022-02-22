namespace MicrosoftGraph.Models.Microsoft.Graph {
    public enum MobileAppIntent {
        Available,
        NotAvailable,
        RequiredInstall,
        RequiredUninstall,
        RequiredAndAvailableInstall,
        AvailableInstallWithoutEnrollment,
        Exclude,
    }
}
