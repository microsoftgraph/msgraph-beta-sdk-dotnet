using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class OfficeSuiteApp : MobileApp, IParsable {
        /// <summary>The value to accept the EULA automatically on the enduser&apos;s device.</summary>
        public bool? AutoAcceptEula {
            get { return BackingStore?.Get<bool?>("autoAcceptEula"); }
            set { BackingStore?.Set("autoAcceptEula", value); }
        }
        /// <summary>The property to represent the apps which are excluded from the selected Office365 Product Id.</summary>
        public Microsoft.Graph.Beta.Models.ExcludedApps ExcludedApps {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ExcludedApps>("excludedApps"); }
            set { BackingStore?.Set("excludedApps", value); }
        }
        /// <summary>The Enum to specify the level of display for the Installation Progress Setup UI on the Device.</summary>
        public OfficeSuiteInstallProgressDisplayLevel? InstallProgressDisplayLevel {
            get { return BackingStore?.Get<OfficeSuiteInstallProgressDisplayLevel?>("installProgressDisplayLevel"); }
            set { BackingStore?.Set("installProgressDisplayLevel", value); }
        }
        /// <summary>The property to represent the locales which are installed when the apps from Office365 is installed. It uses standard RFC 6033. Ref: https://technet.microsoft.com/library/cc179219(v=office.16).aspx</summary>
        public List<string> LocalesToInstall {
            get { return BackingStore?.Get<List<string>>("localesToInstall"); }
            set { BackingStore?.Set("localesToInstall", value); }
        }
        /// <summary>The property to represent the XML configuration file that can be specified for Office ProPlus Apps. Takes precedence over all other properties. When present, the XML configuration file will be used to create the app.</summary>
        public byte[] OfficeConfigurationXml {
            get { return BackingStore?.Get<byte[]>("officeConfigurationXml"); }
            set { BackingStore?.Set("officeConfigurationXml", value); }
        }
        /// <summary>Contains properties for Windows architecture.</summary>
        public WindowsArchitecture? OfficePlatformArchitecture {
            get { return BackingStore?.Get<WindowsArchitecture?>("officePlatformArchitecture"); }
            set { BackingStore?.Set("officePlatformArchitecture", value); }
        }
        /// <summary>The Product Ids that represent the Office365 Suite SKU.</summary>
        public List<string> ProductIds {
            get { return BackingStore?.Get<List<string>>("productIds"); }
            set { BackingStore?.Set("productIds", value); }
        }
        /// <summary>The property to determine whether to uninstall existing Office MSI if an Office365 app suite is deployed to the device or not.</summary>
        public bool? ShouldUninstallOlderVersionsOfOffice {
            get { return BackingStore?.Get<bool?>("shouldUninstallOlderVersionsOfOffice"); }
            set { BackingStore?.Set("shouldUninstallOlderVersionsOfOffice", value); }
        }
        /// <summary>The property to represent the specific target version for the Office365 app suite that should be remained deployed on the devices.</summary>
        public string TargetVersion {
            get { return BackingStore?.Get<string>("targetVersion"); }
            set { BackingStore?.Set("targetVersion", value); }
        }
        /// <summary>The Enum to specify the Office365 Updates Channel.</summary>
        public OfficeUpdateChannel? UpdateChannel {
            get { return BackingStore?.Get<OfficeUpdateChannel?>("updateChannel"); }
            set { BackingStore?.Set("updateChannel", value); }
        }
        /// <summary>The property to represent the update version in which the specific target version is available for the Office365 app suite.</summary>
        public string UpdateVersion {
            get { return BackingStore?.Get<string>("updateVersion"); }
            set { BackingStore?.Set("updateVersion", value); }
        }
        /// <summary>The property to represent that whether the shared computer activation is used not for Office365 app suite.</summary>
        public bool? UseSharedComputerActivation {
            get { return BackingStore?.Get<bool?>("useSharedComputerActivation"); }
            set { BackingStore?.Set("useSharedComputerActivation", value); }
        }
        /// <summary>
        /// Instantiates a new OfficeSuiteApp and sets the default values.
        /// </summary>
        public OfficeSuiteApp() : base() {
            OdataType = "#microsoft.graph.officeSuiteApp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new OfficeSuiteApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OfficeSuiteApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"autoAcceptEula", n => { AutoAcceptEula = n.GetBoolValue(); } },
                {"excludedApps", n => { ExcludedApps = n.GetObjectValue<Microsoft.Graph.Beta.Models.ExcludedApps>(Microsoft.Graph.Beta.Models.ExcludedApps.CreateFromDiscriminatorValue); } },
                {"installProgressDisplayLevel", n => { InstallProgressDisplayLevel = n.GetEnumValue<OfficeSuiteInstallProgressDisplayLevel>(); } },
                {"localesToInstall", n => { LocalesToInstall = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"officeConfigurationXml", n => { OfficeConfigurationXml = n.GetByteArrayValue(); } },
                {"officePlatformArchitecture", n => { OfficePlatformArchitecture = n.GetEnumValue<WindowsArchitecture>(); } },
                {"productIds", n => { ProductIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"shouldUninstallOlderVersionsOfOffice", n => { ShouldUninstallOlderVersionsOfOffice = n.GetBoolValue(); } },
                {"targetVersion", n => { TargetVersion = n.GetStringValue(); } },
                {"updateChannel", n => { UpdateChannel = n.GetEnumValue<OfficeUpdateChannel>(); } },
                {"updateVersion", n => { UpdateVersion = n.GetStringValue(); } },
                {"useSharedComputerActivation", n => { UseSharedComputerActivation = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("autoAcceptEula", AutoAcceptEula);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ExcludedApps>("excludedApps", ExcludedApps);
            writer.WriteEnumValue<OfficeSuiteInstallProgressDisplayLevel>("installProgressDisplayLevel", InstallProgressDisplayLevel);
            writer.WriteCollectionOfPrimitiveValues<string>("localesToInstall", LocalesToInstall);
            writer.WriteByteArrayValue("officeConfigurationXml", OfficeConfigurationXml);
            writer.WriteEnumValue<WindowsArchitecture>("officePlatformArchitecture", OfficePlatformArchitecture);
            writer.WriteCollectionOfPrimitiveValues<string>("productIds", ProductIds);
            writer.WriteBoolValue("shouldUninstallOlderVersionsOfOffice", ShouldUninstallOlderVersionsOfOffice);
            writer.WriteStringValue("targetVersion", TargetVersion);
            writer.WriteEnumValue<OfficeUpdateChannel>("updateChannel", UpdateChannel);
            writer.WriteStringValue("updateVersion", UpdateVersion);
            writer.WriteBoolValue("useSharedComputerActivation", UseSharedComputerActivation);
        }
    }
}
