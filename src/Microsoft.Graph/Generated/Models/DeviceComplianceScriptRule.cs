using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceComplianceScriptRule : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Data type specified in the rule. Possible values are: none, boolean, int64, double, string, dateTime, version, base64, xml, booleanArray, int64Array, doubleArray, stringArray, dateTimeArray, versionArray.</summary>
        public Microsoft.Graph.Beta.Models.DataType? DataType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DataType?>(nameof(DataType)); }
            set { BackingStore?.Set(nameof(DataType), value); }
        }
        /// <summary>Data type specified in the rule. Possible values are: none, boolean, int64, double, string, dateTime, version, base64, xml, booleanArray, int64Array, doubleArray, stringArray, dateTimeArray, versionArray.</summary>
        public Microsoft.Graph.Beta.Models.DeviceComplianceScriptRuleDataType? DeviceComplianceScriptRuleDataType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceComplianceScriptRuleDataType?>(nameof(DeviceComplianceScriptRuleDataType)); }
            set { BackingStore?.Set(nameof(DeviceComplianceScriptRuleDataType), value); }
        }
        /// <summary>Operator specified in the rule. Possible values are: none, and, or, isEquals, notEquals, greaterThan, lessThan, between, notBetween, greaterEquals, lessEquals, dayTimeBetween, beginsWith, notBeginsWith, endsWith, notEndsWith, contains, notContains, allOf, oneOf, noneOf, setEquals, orderedSetEquals, subsetOf, excludesAll.</summary>
        public Microsoft.Graph.Beta.Models.DeviceComplianceScriptRulOperator? DeviceComplianceScriptRulOperator {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceComplianceScriptRulOperator?>(nameof(DeviceComplianceScriptRulOperator)); }
            set { BackingStore?.Set(nameof(DeviceComplianceScriptRulOperator), value); }
        }
        /// <summary>Operand specified in the rule.</summary>
        public string Operand {
            get { return BackingStore?.Get<string>(nameof(Operand)); }
            set { BackingStore?.Set(nameof(Operand), value); }
        }
        /// <summary>Operator specified in the rule. Possible values are: none, and, or, isEquals, notEquals, greaterThan, lessThan, between, notBetween, greaterEquals, lessEquals, dayTimeBetween, beginsWith, notBeginsWith, endsWith, notEndsWith, contains, notContains, allOf, oneOf, noneOf, setEquals, orderedSetEquals, subsetOf, excludesAll.</summary>
        public Microsoft.Graph.Beta.Models.Operator? Operator {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Operator?>(nameof(Operator)); }
            set { BackingStore?.Set(nameof(Operator), value); }
        }
        /// <summary>Setting name specified in the rule.</summary>
        public string SettingName {
            get { return BackingStore?.Get<string>(nameof(SettingName)); }
            set { BackingStore?.Set(nameof(SettingName), value); }
        }
        /// <summary>
        /// Instantiates a new deviceComplianceScriptRule and sets the default values.
        /// </summary>
        public DeviceComplianceScriptRule() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceComplianceScriptRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceComplianceScriptRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"dataType", n => { DataType = n.GetEnumValue<DataType>(); } },
                {"deviceComplianceScriptRuleDataType", n => { DeviceComplianceScriptRuleDataType = n.GetEnumValue<DeviceComplianceScriptRuleDataType>(); } },
                {"deviceComplianceScriptRulOperator", n => { DeviceComplianceScriptRulOperator = n.GetEnumValue<DeviceComplianceScriptRulOperator>(); } },
                {"operand", n => { Operand = n.GetStringValue(); } },
                {"operator", n => { Operator = n.GetEnumValue<Operator>(); } },
                {"settingName", n => { SettingName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<DataType>("dataType", DataType);
            writer.WriteEnumValue<DeviceComplianceScriptRuleDataType>("deviceComplianceScriptRuleDataType", DeviceComplianceScriptRuleDataType);
            writer.WriteEnumValue<DeviceComplianceScriptRulOperator>("deviceComplianceScriptRulOperator", DeviceComplianceScriptRulOperator);
            writer.WriteStringValue("operand", Operand);
            writer.WriteEnumValue<Operator>("operator", Operator);
            writer.WriteStringValue("settingName", SettingName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
