using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class EditionUpgradeConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Edition Upgrade License File Content.</summary>
        public string License {
            get { return BackingStore?.Get<string>(nameof(License)); }
            set { BackingStore?.Set(nameof(License), value); }
        }
        /// <summary>Edition Upgrade License Type. Possible values are: productKey, licenseFile, notConfigured.</summary>
        public EditionUpgradeLicenseType? LicenseType {
            get { return BackingStore?.Get<EditionUpgradeLicenseType?>(nameof(LicenseType)); }
            set { BackingStore?.Set(nameof(LicenseType), value); }
        }
        /// <summary>Edition Upgrade Product Key.</summary>
        public string ProductKey {
            get { return BackingStore?.Get<string>(nameof(ProductKey)); }
            set { BackingStore?.Set(nameof(ProductKey), value); }
        }
        /// <summary>Edition Upgrade Target Edition. Possible values are: windows10Enterprise, windows10EnterpriseN, windows10Education, windows10EducationN, windows10MobileEnterprise, windows10HolographicEnterprise, windows10Professional, windows10ProfessionalN, windows10ProfessionalEducation, windows10ProfessionalEducationN, windows10ProfessionalWorkstation, windows10ProfessionalWorkstationN, notConfigured, windows10Home, windows10HomeChina, windows10HomeN, windows10HomeSingleLanguage, windows10Mobile, windows10IoTCore, windows10IoTCoreCommercial.</summary>
        public Windows10EditionType? TargetEdition {
            get { return BackingStore?.Get<Windows10EditionType?>(nameof(TargetEdition)); }
            set { BackingStore?.Set(nameof(TargetEdition), value); }
        }
        /// <summary>S mode configuration. Possible values are: noRestriction, block, unlock.</summary>
        public WindowsSModeConfiguration? WindowsSMode {
            get { return BackingStore?.Get<WindowsSModeConfiguration?>(nameof(WindowsSMode)); }
            set { BackingStore?.Set(nameof(WindowsSMode), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EditionUpgradeConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EditionUpgradeConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"license", n => { License = n.GetStringValue(); } },
                {"licenseType", n => { LicenseType = n.GetEnumValue<EditionUpgradeLicenseType>(); } },
                {"productKey", n => { ProductKey = n.GetStringValue(); } },
                {"targetEdition", n => { TargetEdition = n.GetEnumValue<Windows10EditionType>(); } },
                {"windowsSMode", n => { WindowsSMode = n.GetEnumValue<WindowsSModeConfiguration>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("license", License);
            writer.WriteEnumValue<EditionUpgradeLicenseType>("licenseType", LicenseType);
            writer.WriteStringValue("productKey", ProductKey);
            writer.WriteEnumValue<Windows10EditionType>("targetEdition", TargetEdition);
            writer.WriteEnumValue<WindowsSModeConfiguration>("windowsSMode", WindowsSMode);
        }
    }
}
