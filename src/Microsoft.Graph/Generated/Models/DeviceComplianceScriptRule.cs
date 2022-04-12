using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceComplianceScriptRule : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Data type specified in the rule. Possible values are: none, boolean, int64, double, string, dateTime, version, base64, xml, booleanArray, int64Array, doubleArray, stringArray, dateTimeArray, versionArray.</summary>
        public Microsoft.Graph.Beta.Models.DataType? DataType { get; set; }
        /// <summary>Data type specified in the rule. Possible values are: none, boolean, int64, double, string, dateTime, version, base64, xml, booleanArray, int64Array, doubleArray, stringArray, dateTimeArray, versionArray.</summary>
        public Microsoft.Graph.Beta.Models.DeviceComplianceScriptRuleDataType? DeviceComplianceScriptRuleDataType { get; set; }
        /// <summary>Operator specified in the rule. Possible values are: none, and, or, isEquals, notEquals, greaterThan, lessThan, between, notBetween, greaterEquals, lessEquals, dayTimeBetween, beginsWith, notBeginsWith, endsWith, notEndsWith, contains, notContains, allOf, oneOf, noneOf, setEquals, orderedSetEquals, subsetOf, excludesAll.</summary>
        public Microsoft.Graph.Beta.Models.DeviceComplianceScriptRulOperator? DeviceComplianceScriptRulOperator { get; set; }
        /// <summary>Operand specified in the rule.</summary>
        public string Operand { get; set; }
        /// <summary>Operator specified in the rule. Possible values are: none, and, or, isEquals, notEquals, greaterThan, lessThan, between, notBetween, greaterEquals, lessEquals, dayTimeBetween, beginsWith, notBeginsWith, endsWith, notEndsWith, contains, notContains, allOf, oneOf, noneOf, setEquals, orderedSetEquals, subsetOf, excludesAll.</summary>
        public Microsoft.Graph.Beta.Models.Operator? Operator { get; set; }
        /// <summary>Setting name specified in the rule.</summary>
        public string SettingName { get; set; }
        /// <summary>
        /// Instantiates a new deviceComplianceScriptRule and sets the default values.
        /// </summary>
        public DeviceComplianceScriptRule() {
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
