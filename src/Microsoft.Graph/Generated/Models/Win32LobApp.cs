using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Win32LobApp : MobileLobApp, IParsable {
        /// <summary>When TRUE, indicates that uninstall is supported from the company portal for the Windows app (Win32) with an Available assignment. When FALSE, indicates that uninstall is not supported for the Windows app (Win32) with an Available assignment. Default value is FALSE.</summary>
        public bool? AllowAvailableUninstall {
            get { return BackingStore?.Get<bool?>("allowAvailableUninstall"); }
            set { BackingStore?.Set("allowAvailableUninstall", value); }
        }
        /// <summary>Contains properties for Windows architecture.</summary>
        public WindowsArchitecture? ApplicableArchitectures {
            get { return BackingStore?.Get<WindowsArchitecture?>("applicableArchitectures"); }
            set { BackingStore?.Set("applicableArchitectures", value); }
        }
        /// <summary>The detection rules to detect Win32 Line of Business (LoB) app.</summary>
        public List<Win32LobAppDetection> DetectionRules {
            get { return BackingStore?.Get<List<Win32LobAppDetection>>("detectionRules"); }
            set { BackingStore?.Set("detectionRules", value); }
        }
        /// <summary>The version displayed in the UX for this app.</summary>
        public string DisplayVersion {
            get { return BackingStore?.Get<string>("displayVersion"); }
            set { BackingStore?.Set("displayVersion", value); }
        }
        /// <summary>The command line to install this app</summary>
        public string InstallCommandLine {
            get { return BackingStore?.Get<string>("installCommandLine"); }
            set { BackingStore?.Set("installCommandLine", value); }
        }
        /// <summary>The install experience for this app.</summary>
        public Win32LobAppInstallExperience InstallExperience {
            get { return BackingStore?.Get<Win32LobAppInstallExperience>("installExperience"); }
            set { BackingStore?.Set("installExperience", value); }
        }
        /// <summary>The value for the minimum CPU speed which is required to install this app.</summary>
        public int? MinimumCpuSpeedInMHz {
            get { return BackingStore?.Get<int?>("minimumCpuSpeedInMHz"); }
            set { BackingStore?.Set("minimumCpuSpeedInMHz", value); }
        }
        /// <summary>The value for the minimum free disk space which is required to install this app.</summary>
        public int? MinimumFreeDiskSpaceInMB {
            get { return BackingStore?.Get<int?>("minimumFreeDiskSpaceInMB"); }
            set { BackingStore?.Set("minimumFreeDiskSpaceInMB", value); }
        }
        /// <summary>The value for the minimum physical memory which is required to install this app.</summary>
        public int? MinimumMemoryInMB {
            get { return BackingStore?.Get<int?>("minimumMemoryInMB"); }
            set { BackingStore?.Set("minimumMemoryInMB", value); }
        }
        /// <summary>The value for the minimum number of processors which is required to install this app.</summary>
        public int? MinimumNumberOfProcessors {
            get { return BackingStore?.Get<int?>("minimumNumberOfProcessors"); }
            set { BackingStore?.Set("minimumNumberOfProcessors", value); }
        }
        /// <summary>The value for the minimum applicable operating system.</summary>
        public WindowsMinimumOperatingSystem MinimumSupportedOperatingSystem {
            get { return BackingStore?.Get<WindowsMinimumOperatingSystem>("minimumSupportedOperatingSystem"); }
            set { BackingStore?.Set("minimumSupportedOperatingSystem", value); }
        }
        /// <summary>The value for the minimum supported windows release.</summary>
        public string MinimumSupportedWindowsRelease {
            get { return BackingStore?.Get<string>("minimumSupportedWindowsRelease"); }
            set { BackingStore?.Set("minimumSupportedWindowsRelease", value); }
        }
        /// <summary>The MSI details if this Win32 app is an MSI app.</summary>
        public Win32LobAppMsiInformation MsiInformation {
            get { return BackingStore?.Get<Win32LobAppMsiInformation>("msiInformation"); }
            set { BackingStore?.Set("msiInformation", value); }
        }
        /// <summary>The requirement rules to detect Win32 Line of Business (LoB) app.</summary>
        public List<Win32LobAppRequirement> RequirementRules {
            get { return BackingStore?.Get<List<Win32LobAppRequirement>>("requirementRules"); }
            set { BackingStore?.Set("requirementRules", value); }
        }
        /// <summary>The return codes for post installation behavior.</summary>
        public List<Win32LobAppReturnCode> ReturnCodes {
            get { return BackingStore?.Get<List<Win32LobAppReturnCode>>("returnCodes"); }
            set { BackingStore?.Set("returnCodes", value); }
        }
        /// <summary>The detection and requirement rules for this app.</summary>
        public List<Win32LobAppRule> Rules {
            get { return BackingStore?.Get<List<Win32LobAppRule>>("rules"); }
            set { BackingStore?.Set("rules", value); }
        }
        /// <summary>The relative path of the setup file in the encrypted Win32LobApp package.</summary>
        public string SetupFilePath {
            get { return BackingStore?.Get<string>("setupFilePath"); }
            set { BackingStore?.Set("setupFilePath", value); }
        }
        /// <summary>The command line to uninstall this app</summary>
        public string UninstallCommandLine {
            get { return BackingStore?.Get<string>("uninstallCommandLine"); }
            set { BackingStore?.Set("uninstallCommandLine", value); }
        }
        /// <summary>
        /// Instantiates a new Win32LobApp and sets the default values.
        /// </summary>
        public Win32LobApp() : base() {
            OdataType = "#microsoft.graph.win32LobApp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Win32LobApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Win32LobApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowAvailableUninstall", n => { AllowAvailableUninstall = n.GetBoolValue(); } },
                {"applicableArchitectures", n => { ApplicableArchitectures = n.GetEnumValue<WindowsArchitecture>(); } },
                {"detectionRules", n => { DetectionRules = n.GetCollectionOfObjectValues<Win32LobAppDetection>(Win32LobAppDetection.CreateFromDiscriminatorValue).ToList(); } },
                {"displayVersion", n => { DisplayVersion = n.GetStringValue(); } },
                {"installCommandLine", n => { InstallCommandLine = n.GetStringValue(); } },
                {"installExperience", n => { InstallExperience = n.GetObjectValue<Win32LobAppInstallExperience>(Win32LobAppInstallExperience.CreateFromDiscriminatorValue); } },
                {"minimumCpuSpeedInMHz", n => { MinimumCpuSpeedInMHz = n.GetIntValue(); } },
                {"minimumFreeDiskSpaceInMB", n => { MinimumFreeDiskSpaceInMB = n.GetIntValue(); } },
                {"minimumMemoryInMB", n => { MinimumMemoryInMB = n.GetIntValue(); } },
                {"minimumNumberOfProcessors", n => { MinimumNumberOfProcessors = n.GetIntValue(); } },
                {"minimumSupportedOperatingSystem", n => { MinimumSupportedOperatingSystem = n.GetObjectValue<WindowsMinimumOperatingSystem>(WindowsMinimumOperatingSystem.CreateFromDiscriminatorValue); } },
                {"minimumSupportedWindowsRelease", n => { MinimumSupportedWindowsRelease = n.GetStringValue(); } },
                {"msiInformation", n => { MsiInformation = n.GetObjectValue<Win32LobAppMsiInformation>(Win32LobAppMsiInformation.CreateFromDiscriminatorValue); } },
                {"requirementRules", n => { RequirementRules = n.GetCollectionOfObjectValues<Win32LobAppRequirement>(Win32LobAppRequirement.CreateFromDiscriminatorValue).ToList(); } },
                {"returnCodes", n => { ReturnCodes = n.GetCollectionOfObjectValues<Win32LobAppReturnCode>(Win32LobAppReturnCode.CreateFromDiscriminatorValue).ToList(); } },
                {"rules", n => { Rules = n.GetCollectionOfObjectValues<Win32LobAppRule>(Win32LobAppRule.CreateFromDiscriminatorValue).ToList(); } },
                {"setupFilePath", n => { SetupFilePath = n.GetStringValue(); } },
                {"uninstallCommandLine", n => { UninstallCommandLine = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowAvailableUninstall", AllowAvailableUninstall);
            writer.WriteEnumValue<WindowsArchitecture>("applicableArchitectures", ApplicableArchitectures);
            writer.WriteCollectionOfObjectValues<Win32LobAppDetection>("detectionRules", DetectionRules);
            writer.WriteStringValue("displayVersion", DisplayVersion);
            writer.WriteStringValue("installCommandLine", InstallCommandLine);
            writer.WriteObjectValue<Win32LobAppInstallExperience>("installExperience", InstallExperience);
            writer.WriteIntValue("minimumCpuSpeedInMHz", MinimumCpuSpeedInMHz);
            writer.WriteIntValue("minimumFreeDiskSpaceInMB", MinimumFreeDiskSpaceInMB);
            writer.WriteIntValue("minimumMemoryInMB", MinimumMemoryInMB);
            writer.WriteIntValue("minimumNumberOfProcessors", MinimumNumberOfProcessors);
            writer.WriteObjectValue<WindowsMinimumOperatingSystem>("minimumSupportedOperatingSystem", MinimumSupportedOperatingSystem);
            writer.WriteStringValue("minimumSupportedWindowsRelease", MinimumSupportedWindowsRelease);
            writer.WriteObjectValue<Win32LobAppMsiInformation>("msiInformation", MsiInformation);
            writer.WriteCollectionOfObjectValues<Win32LobAppRequirement>("requirementRules", RequirementRules);
            writer.WriteCollectionOfObjectValues<Win32LobAppReturnCode>("returnCodes", ReturnCodes);
            writer.WriteCollectionOfObjectValues<Win32LobAppRule>("rules", Rules);
            writer.WriteStringValue("setupFilePath", SetupFilePath);
            writer.WriteStringValue("uninstallCommandLine", UninstallCommandLine);
        }
    }
}
