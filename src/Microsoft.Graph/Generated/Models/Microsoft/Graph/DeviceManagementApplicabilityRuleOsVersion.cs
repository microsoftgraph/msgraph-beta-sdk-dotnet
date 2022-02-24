using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DeviceManagementApplicabilityRuleOsVersion : IParsable {
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
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"maxOSVersion", (o,n) => { (o as DeviceManagementApplicabilityRuleOsVersion).MaxOSVersion = n.GetStringValue(); } },
                {"minOSVersion", (o,n) => { (o as DeviceManagementApplicabilityRuleOsVersion).MinOSVersion = n.GetStringValue(); } },
                {"name", (o,n) => { (o as DeviceManagementApplicabilityRuleOsVersion).Name = n.GetStringValue(); } },
                {"ruleType", (o,n) => { (o as DeviceManagementApplicabilityRuleOsVersion).RuleType = n.GetEnumValue<DeviceManagementApplicabilityRuleType>(); } },
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
