using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Summary data for co managed devices</summary>
    public class ComanagedDevicesSummary : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Number of devices with CompliancePolicy swung-over. This property is read-only.</summary>
        public int? CompliancePolicyCount {
            get { return BackingStore?.Get<int?>("compliancePolicyCount"); }
            set { BackingStore?.Set("compliancePolicyCount", value); }
        }
        /// <summary>Number of devices with ConfigurationSettings swung-over. This property is read-only.</summary>
        public int? ConfigurationSettingsCount {
            get { return BackingStore?.Get<int?>("configurationSettingsCount"); }
            set { BackingStore?.Set("configurationSettingsCount", value); }
        }
        /// <summary>Number of devices with EndpointProtection swung-over. This property is read-only.</summary>
        public int? EndpointProtectionCount {
            get { return BackingStore?.Get<int?>("endpointProtectionCount"); }
            set { BackingStore?.Set("endpointProtectionCount", value); }
        }
        /// <summary>Number of devices with Inventory swung-over. This property is read-only.</summary>
        public int? InventoryCount {
            get { return BackingStore?.Get<int?>("inventoryCount"); }
            set { BackingStore?.Set("inventoryCount", value); }
        }
        /// <summary>Number of devices with ModernApps swung-over. This property is read-only.</summary>
        public int? ModernAppsCount {
            get { return BackingStore?.Get<int?>("modernAppsCount"); }
            set { BackingStore?.Set("modernAppsCount", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Number of devices with OfficeApps swung-over. This property is read-only.</summary>
        public int? OfficeAppsCount {
            get { return BackingStore?.Get<int?>("officeAppsCount"); }
            set { BackingStore?.Set("officeAppsCount", value); }
        }
        /// <summary>Number of devices with ResourceAccess swung-over. This property is read-only.</summary>
        public int? ResourceAccessCount {
            get { return BackingStore?.Get<int?>("resourceAccessCount"); }
            set { BackingStore?.Set("resourceAccessCount", value); }
        }
        /// <summary>Number of Co-Managed Devices. This property is read-only.</summary>
        public int? TotalComanagedCount {
            get { return BackingStore?.Get<int?>("totalComanagedCount"); }
            set { BackingStore?.Set("totalComanagedCount", value); }
        }
        /// <summary>Number of devices with WindowsUpdateForBusiness swung-over. This property is read-only.</summary>
        public int? WindowsUpdateForBusinessCount {
            get { return BackingStore?.Get<int?>("windowsUpdateForBusinessCount"); }
            set { BackingStore?.Set("windowsUpdateForBusinessCount", value); }
        }
        /// <summary>
        /// Instantiates a new comanagedDevicesSummary and sets the default values.
        /// </summary>
        public ComanagedDevicesSummary() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.comanagedDevicesSummary";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ComanagedDevicesSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ComanagedDevicesSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"compliancePolicyCount", n => { CompliancePolicyCount = n.GetIntValue(); } },
                {"configurationSettingsCount", n => { ConfigurationSettingsCount = n.GetIntValue(); } },
                {"endpointProtectionCount", n => { EndpointProtectionCount = n.GetIntValue(); } },
                {"inventoryCount", n => { InventoryCount = n.GetIntValue(); } },
                {"modernAppsCount", n => { ModernAppsCount = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"officeAppsCount", n => { OfficeAppsCount = n.GetIntValue(); } },
                {"resourceAccessCount", n => { ResourceAccessCount = n.GetIntValue(); } },
                {"totalComanagedCount", n => { TotalComanagedCount = n.GetIntValue(); } },
                {"windowsUpdateForBusinessCount", n => { WindowsUpdateForBusinessCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
