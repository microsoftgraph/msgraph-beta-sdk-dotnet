using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>configuration Manager client enabled features</summary>
    public class ConfigurationManagerClientEnabledFeatures : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Whether compliance policy is managed by Intune</summary>
        public bool? CompliancePolicy {
            get { return BackingStore?.Get<bool?>(nameof(CompliancePolicy)); }
            set { BackingStore?.Set(nameof(CompliancePolicy), value); }
        }
        /// <summary>Whether device configuration is managed by Intune</summary>
        public bool? DeviceConfiguration {
            get { return BackingStore?.Get<bool?>(nameof(DeviceConfiguration)); }
            set { BackingStore?.Set(nameof(DeviceConfiguration), value); }
        }
        /// <summary>Whether Endpoint Protection is managed by Intune</summary>
        public bool? EndpointProtection {
            get { return BackingStore?.Get<bool?>(nameof(EndpointProtection)); }
            set { BackingStore?.Set(nameof(EndpointProtection), value); }
        }
        /// <summary>Whether inventory is managed by Intune</summary>
        public bool? Inventory {
            get { return BackingStore?.Get<bool?>(nameof(Inventory)); }
            set { BackingStore?.Set(nameof(Inventory), value); }
        }
        /// <summary>Whether modern application is managed by Intune</summary>
        public bool? ModernApps {
            get { return BackingStore?.Get<bool?>(nameof(ModernApps)); }
            set { BackingStore?.Set(nameof(ModernApps), value); }
        }
        /// <summary>Whether Office application is managed by Intune</summary>
        public bool? OfficeApps {
            get { return BackingStore?.Get<bool?>(nameof(OfficeApps)); }
            set { BackingStore?.Set(nameof(OfficeApps), value); }
        }
        /// <summary>Whether resource access is managed by Intune</summary>
        public bool? ResourceAccess {
            get { return BackingStore?.Get<bool?>(nameof(ResourceAccess)); }
            set { BackingStore?.Set(nameof(ResourceAccess), value); }
        }
        /// <summary>Whether Windows Update for Business is managed by Intune</summary>
        public bool? WindowsUpdateForBusiness {
            get { return BackingStore?.Get<bool?>(nameof(WindowsUpdateForBusiness)); }
            set { BackingStore?.Set(nameof(WindowsUpdateForBusiness), value); }
        }
        /// <summary>
        /// Instantiates a new configurationManagerClientEnabledFeatures and sets the default values.
        /// </summary>
        public ConfigurationManagerClientEnabledFeatures() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ConfigurationManagerClientEnabledFeatures CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConfigurationManagerClientEnabledFeatures();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"compliancePolicy", n => { CompliancePolicy = n.GetBoolValue(); } },
                {"deviceConfiguration", n => { DeviceConfiguration = n.GetBoolValue(); } },
                {"endpointProtection", n => { EndpointProtection = n.GetBoolValue(); } },
                {"inventory", n => { Inventory = n.GetBoolValue(); } },
                {"modernApps", n => { ModernApps = n.GetBoolValue(); } },
                {"officeApps", n => { OfficeApps = n.GetBoolValue(); } },
                {"resourceAccess", n => { ResourceAccess = n.GetBoolValue(); } },
                {"windowsUpdateForBusiness", n => { WindowsUpdateForBusiness = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("compliancePolicy", CompliancePolicy);
            writer.WriteBoolValue("deviceConfiguration", DeviceConfiguration);
            writer.WriteBoolValue("endpointProtection", EndpointProtection);
            writer.WriteBoolValue("inventory", Inventory);
            writer.WriteBoolValue("modernApps", ModernApps);
            writer.WriteBoolValue("officeApps", OfficeApps);
            writer.WriteBoolValue("resourceAccess", ResourceAccess);
            writer.WriteBoolValue("windowsUpdateForBusiness", WindowsUpdateForBusiness);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
