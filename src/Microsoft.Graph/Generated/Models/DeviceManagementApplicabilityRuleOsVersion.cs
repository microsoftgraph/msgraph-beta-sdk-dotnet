using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementApplicabilityRuleOsVersion : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Max OS version for Applicability Rule.</summary>
        public string MaxOSVersion {
            get { return BackingStore?.Get<string>("maxOSVersion"); }
            set { BackingStore?.Set("maxOSVersion", value); }
        }
        /// <summary>Min OS version for Applicability Rule.</summary>
        public string MinOSVersion {
            get { return BackingStore?.Get<string>("minOSVersion"); }
            set { BackingStore?.Set("minOSVersion", value); }
        }
        /// <summary>Name for object.</summary>
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Supported Applicability rule types for Device Configuration</summary>
        public DeviceManagementApplicabilityRuleType? RuleType {
            get { return BackingStore?.Get<DeviceManagementApplicabilityRuleType?>("ruleType"); }
            set { BackingStore?.Set("ruleType", value); }
        }
        /// <summary>
        /// Instantiates a new deviceManagementApplicabilityRuleOsVersion and sets the default values.
        /// </summary>
        public DeviceManagementApplicabilityRuleOsVersion() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DeviceManagementApplicabilityRuleOsVersion CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementApplicabilityRuleOsVersion();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"maxOSVersion", n => { MaxOSVersion = n.GetStringValue(); } },
                {"minOSVersion", n => { MinOSVersion = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"ruleType", n => { RuleType = n.GetEnumValue<DeviceManagementApplicabilityRuleType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("maxOSVersion", MaxOSVersion);
            writer.WriteStringValue("minOSVersion", MinOSVersion);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<DeviceManagementApplicabilityRuleType>("ruleType", RuleType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
