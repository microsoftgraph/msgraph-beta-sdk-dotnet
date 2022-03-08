using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class DeviceManagementApplicabilityRuleOsEdition : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Name for object.</summary>
        public string Name { get; set; }
        /// <summary>Applicability rule OS edition type.</summary>
        public List<Windows10EditionType?> OsEditionTypes { get; set; }
        /// <summary>Applicability Rule type. Possible values are: include, exclude.</summary>
        public DeviceManagementApplicabilityRuleType? RuleType { get; set; }
        /// <summary>
        /// Instantiates a new deviceManagementApplicabilityRuleOsEdition and sets the default values.
        /// </summary>
        public DeviceManagementApplicabilityRuleOsEdition() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceManagementApplicabilityRuleOsEdition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementApplicabilityRuleOsEdition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"name", (o,n) => { (o as DeviceManagementApplicabilityRuleOsEdition).Name = n.GetStringValue(); } },
                {"osEditionTypes", (o,n) => { (o as DeviceManagementApplicabilityRuleOsEdition).OsEditionTypes = n.GetCollectionOfEnumValues<Windows10EditionType>().ToList(); } },
                {"ruleType", (o,n) => { (o as DeviceManagementApplicabilityRuleOsEdition).RuleType = n.GetEnumValue<DeviceManagementApplicabilityRuleType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfEnumValues<Windows10EditionType>("osEditionTypes", OsEditionTypes);
            writer.WriteEnumValue<DeviceManagementApplicabilityRuleType>("ruleType", RuleType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
