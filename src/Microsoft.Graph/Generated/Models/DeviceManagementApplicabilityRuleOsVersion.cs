using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementApplicabilityRuleOsVersion : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Max OS version for Applicability Rule.</summary>
        public string MaxOSVersion { get; set; }
        /// <summary>Min OS version for Applicability Rule.</summary>
        public string MinOSVersion { get; set; }
        /// <summary>Name for object.</summary>
        public string Name { get; set; }
        /// <summary>Applicability Rule type. Possible values are: include, exclude.</summary>
        public DeviceManagementApplicabilityRuleType? RuleType { get; set; }
        /// <summary>
        /// Instantiates a new deviceManagementApplicabilityRuleOsVersion and sets the default values.
        /// </summary>
        public DeviceManagementApplicabilityRuleOsVersion() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
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
                {"ruleType", n => { RuleType = n.GetEnumValue<DeviceManagementApplicabilityRuleType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("maxOSVersion", MaxOSVersion);
            writer.WriteStringValue("minOSVersion", MinOSVersion);
            writer.WriteStringValue("name", Name);
            writer.WriteEnumValue<DeviceManagementApplicabilityRuleType>("ruleType", RuleType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
