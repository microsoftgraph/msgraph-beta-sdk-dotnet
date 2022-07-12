using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceComplianceScriptValidationResult : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Errors in json for the script for rules.</summary>
        public List<DeviceComplianceScriptRuleError> RuleErrors {
            get { return BackingStore?.Get<List<DeviceComplianceScriptRuleError>>("ruleErrors"); }
            set { BackingStore?.Set("ruleErrors", value); }
        }
        /// <summary>Parsed rules from json.</summary>
        public List<DeviceComplianceScriptRule> Rules {
            get { return BackingStore?.Get<List<DeviceComplianceScriptRule>>("rules"); }
            set { BackingStore?.Set("rules", value); }
        }
        /// <summary>Errors in json for the script.</summary>
        public List<DeviceComplianceScriptError> ScriptErrors {
            get { return BackingStore?.Get<List<DeviceComplianceScriptError>>("scriptErrors"); }
            set { BackingStore?.Set("scriptErrors", value); }
        }
        /// <summary>
        /// Instantiates a new deviceComplianceScriptValidationResult and sets the default values.
        /// </summary>
        public DeviceComplianceScriptValidationResult() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
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
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"ruleErrors", n => { RuleErrors = n.GetCollectionOfObjectValues<DeviceComplianceScriptRuleError>(DeviceComplianceScriptRuleError.CreateFromDiscriminatorValue).ToList(); } },
                {"rules", n => { Rules = n.GetCollectionOfObjectValues<DeviceComplianceScriptRule>(DeviceComplianceScriptRule.CreateFromDiscriminatorValue).ToList(); } },
                {"scriptErrors", n => { ScriptErrors = n.GetCollectionOfObjectValues<DeviceComplianceScriptError>(DeviceComplianceScriptError.CreateFromDiscriminatorValue).ToList(); } },
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
