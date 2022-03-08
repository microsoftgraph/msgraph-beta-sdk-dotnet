using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to call the validateComplianceScript method.</summary>
    public class DeviceComplianceScriptValidationResult : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Errors in json for the script for rules.</summary>
        public List<DeviceComplianceScriptRuleError> RuleErrors { get; set; }
        /// <summary>Parsed rules from json.</summary>
        public List<DeviceComplianceScriptRule> Rules { get; set; }
        /// <summary>Errors in json for the script.</summary>
        public List<DeviceComplianceScriptError> ScriptErrors { get; set; }
        /// <summary>
        /// Instantiates a new deviceComplianceScriptValidationResult and sets the default values.
        /// </summary>
        public DeviceComplianceScriptValidationResult() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceComplianceScriptValidationResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceComplianceScriptValidationResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"ruleErrors", (o,n) => { (o as DeviceComplianceScriptValidationResult).RuleErrors = n.GetCollectionOfObjectValues<DeviceComplianceScriptRuleError>(DeviceComplianceScriptRuleError.CreateFromDiscriminatorValue).ToList(); } },
                {"rules", (o,n) => { (o as DeviceComplianceScriptValidationResult).Rules = n.GetCollectionOfObjectValues<DeviceComplianceScriptRule>(DeviceComplianceScriptRule.CreateFromDiscriminatorValue).ToList(); } },
                {"scriptErrors", (o,n) => { (o as DeviceComplianceScriptValidationResult).ScriptErrors = n.GetCollectionOfObjectValues<DeviceComplianceScriptError>(DeviceComplianceScriptError.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<DeviceComplianceScriptRuleError>("ruleErrors", RuleErrors);
            writer.WriteCollectionOfObjectValues<DeviceComplianceScriptRule>("rules", Rules);
            writer.WriteCollectionOfObjectValues<DeviceComplianceScriptError>("scriptErrors", ScriptErrors);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
