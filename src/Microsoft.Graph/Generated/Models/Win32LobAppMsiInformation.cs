using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Contains MSI app properties for a Win32 App.</summary>
    public class Win32LobAppMsiInformation : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The MSI package type. Possible values are: perMachine, perUser, dualPurpose.</summary>
        public Win32LobAppMsiPackageType? PackageType {
            get { return BackingStore?.Get<Win32LobAppMsiPackageType?>(nameof(PackageType)); }
            set { BackingStore?.Set(nameof(PackageType), value); }
        }
        /// <summary>The MSI product code.</summary>
        public string ProductCode {
            get { return BackingStore?.Get<string>(nameof(ProductCode)); }
            set { BackingStore?.Set(nameof(ProductCode), value); }
        }
        /// <summary>The MSI product name.</summary>
        public string ProductName {
            get { return BackingStore?.Get<string>(nameof(ProductName)); }
            set { BackingStore?.Set(nameof(ProductName), value); }
        }
        /// <summary>The MSI product version.</summary>
        public string ProductVersion {
            get { return BackingStore?.Get<string>(nameof(ProductVersion)); }
            set { BackingStore?.Set(nameof(ProductVersion), value); }
        }
        /// <summary>The MSI publisher.</summary>
        public string Publisher {
            get { return BackingStore?.Get<string>(nameof(Publisher)); }
            set { BackingStore?.Set(nameof(Publisher), value); }
        }
        /// <summary>Whether the MSI app requires the machine to reboot to complete installation.</summary>
        public bool? RequiresReboot {
            get { return BackingStore?.Get<bool?>(nameof(RequiresReboot)); }
            set { BackingStore?.Set(nameof(RequiresReboot), value); }
        }
        /// <summary>The MSI upgrade code.</summary>
        public string UpgradeCode {
            get { return BackingStore?.Get<string>(nameof(UpgradeCode)); }
            set { BackingStore?.Set(nameof(UpgradeCode), value); }
        }
        /// <summary>
        /// Instantiates a new win32LobAppMsiInformation and sets the default values.
        /// </summary>
        public Win32LobAppMsiInformation() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Win32LobAppMsiInformation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Win32LobAppMsiInformation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"packageType", n => { PackageType = n.GetEnumValue<Win32LobAppMsiPackageType>(); } },
                {"productCode", n => { ProductCode = n.GetStringValue(); } },
                {"productName", n => { ProductName = n.GetStringValue(); } },
                {"productVersion", n => { ProductVersion = n.GetStringValue(); } },
                {"publisher", n => { Publisher = n.GetStringValue(); } },
                {"requiresReboot", n => { RequiresReboot = n.GetBoolValue(); } },
                {"upgradeCode", n => { UpgradeCode = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<Win32LobAppMsiPackageType>("packageType", PackageType);
            writer.WriteStringValue("productCode", ProductCode);
            writer.WriteStringValue("productName", ProductName);
            writer.WriteStringValue("productVersion", ProductVersion);
            writer.WriteStringValue("publisher", Publisher);
            writer.WriteBoolValue("requiresReboot", RequiresReboot);
            writer.WriteStringValue("upgradeCode", UpgradeCode);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
