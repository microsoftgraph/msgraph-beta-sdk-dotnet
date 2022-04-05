using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Summary data for co managed devices</summary>
    public class ComanagedDevicesSummary : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Number of devices with CompliancePolicy swung-over. This property is read-only.</summary>
        public int? CompliancePolicyCount { get; set; }
        /// <summary>Number of devices with ConfigurationSettings swung-over. This property is read-only.</summary>
        public int? ConfigurationSettingsCount { get; set; }
        /// <summary>Number of devices with EndpointProtection swung-over. This property is read-only.</summary>
        public int? EndpointProtectionCount { get; set; }
        /// <summary>Number of devices with Inventory swung-over. This property is read-only.</summary>
        public int? InventoryCount { get; set; }
        /// <summary>Number of devices with ModernApps swung-over. This property is read-only.</summary>
        public int? ModernAppsCount { get; set; }
        /// <summary>Number of devices with OfficeApps swung-over. This property is read-only.</summary>
        public int? OfficeAppsCount { get; set; }
        /// <summary>Number of devices with ResourceAccess swung-over. This property is read-only.</summary>
        public int? ResourceAccessCount { get; set; }
        /// <summary>Number of Co-Managed Devices. This property is read-only.</summary>
        public int? TotalComanagedCount { get; set; }
        /// <summary>Number of devices with WindowsUpdateForBusiness swung-over. This property is read-only.</summary>
        public int? WindowsUpdateForBusinessCount { get; set; }
        /// <summary>
        /// Instantiates a new comanagedDevicesSummary and sets the default values.
        /// </summary>
        public ComanagedDevicesSummary() {
            AdditionalData = new Dictionary<string, object>();
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
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"compliancePolicyCount", (o,n) => { (o as ComanagedDevicesSummary).CompliancePolicyCount = n.GetIntValue(); } },
                {"configurationSettingsCount", (o,n) => { (o as ComanagedDevicesSummary).ConfigurationSettingsCount = n.GetIntValue(); } },
                {"endpointProtectionCount", (o,n) => { (o as ComanagedDevicesSummary).EndpointProtectionCount = n.GetIntValue(); } },
                {"inventoryCount", (o,n) => { (o as ComanagedDevicesSummary).InventoryCount = n.GetIntValue(); } },
                {"modernAppsCount", (o,n) => { (o as ComanagedDevicesSummary).ModernAppsCount = n.GetIntValue(); } },
                {"officeAppsCount", (o,n) => { (o as ComanagedDevicesSummary).OfficeAppsCount = n.GetIntValue(); } },
                {"resourceAccessCount", (o,n) => { (o as ComanagedDevicesSummary).ResourceAccessCount = n.GetIntValue(); } },
                {"totalComanagedCount", (o,n) => { (o as ComanagedDevicesSummary).TotalComanagedCount = n.GetIntValue(); } },
                {"windowsUpdateForBusinessCount", (o,n) => { (o as ComanagedDevicesSummary).WindowsUpdateForBusinessCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("compliancePolicyCount", CompliancePolicyCount);
            writer.WriteIntValue("configurationSettingsCount", ConfigurationSettingsCount);
            writer.WriteIntValue("endpointProtectionCount", EndpointProtectionCount);
            writer.WriteIntValue("inventoryCount", InventoryCount);
            writer.WriteIntValue("modernAppsCount", ModernAppsCount);
            writer.WriteIntValue("officeAppsCount", OfficeAppsCount);
            writer.WriteIntValue("resourceAccessCount", ResourceAccessCount);
            writer.WriteIntValue("totalComanagedCount", TotalComanagedCount);
            writer.WriteIntValue("windowsUpdateForBusinessCount", WindowsUpdateForBusinessCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
