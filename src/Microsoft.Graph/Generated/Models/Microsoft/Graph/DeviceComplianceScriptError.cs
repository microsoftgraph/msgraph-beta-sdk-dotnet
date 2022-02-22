using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class DeviceComplianceScriptError : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Error code. Possible values are: none, jsonFileInvalid, jsonFileMissing, jsonFileTooLarge, rulesMissing, duplicateRules, tooManyRulesSpecified, operatorMissing, operatorNotSupported, datatypeMissing, datatypeNotSupported, operatorDataTypeCombinationNotSupported, moreInfoUriMissing, moreInfoUriInvalid, moreInfoUriTooLarge, descriptionMissing, descriptionInvalid, descriptionTooLarge, titleMissing, titleInvalid, titleTooLarge, operandMissing, operandInvalid, operandTooLarge, settingNameMissing, settingNameInvalid, settingNameTooLarge, englishLocaleMissing, duplicateLocales, unrecognizedLocale, unknown, remediationStringsMissing.</summary>
        public MicrosoftGraph.Models.Microsoft.Graph.Code? Code { get; set; }
        /// <summary>Error code. Possible values are: none, jsonFileInvalid, jsonFileMissing, jsonFileTooLarge, rulesMissing, duplicateRules, tooManyRulesSpecified, operatorMissing, operatorNotSupported, datatypeMissing, datatypeNotSupported, operatorDataTypeCombinationNotSupported, moreInfoUriMissing, moreInfoUriInvalid, moreInfoUriTooLarge, descriptionMissing, descriptionInvalid, descriptionTooLarge, titleMissing, titleInvalid, titleTooLarge, operandMissing, operandInvalid, operandTooLarge, settingNameMissing, settingNameInvalid, settingNameTooLarge, englishLocaleMissing, duplicateLocales, unrecognizedLocale, unknown, remediationStringsMissing.</summary>
        public DeviceComplianceScriptRulesValidationError? DeviceComplianceScriptRulesValidationError { get; set; }
        /// <summary>Error message.</summary>
        public string Message { get; set; }
        /// <summary>
        /// Instantiates a new deviceComplianceScriptError and sets the default values.
        /// </summary>
        public DeviceComplianceScriptError() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"code", (o,n) => { (o as DeviceComplianceScriptError).Code = n.GetEnumValue<Code>(); } },
                {"deviceComplianceScriptRulesValidationError", (o,n) => { (o as DeviceComplianceScriptError).DeviceComplianceScriptRulesValidationError = n.GetEnumValue<DeviceComplianceScriptRulesValidationError>(); } },
                {"message", (o,n) => { (o as DeviceComplianceScriptError).Message = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<Code>("code", Code);
            writer.WriteEnumValue<DeviceComplianceScriptRulesValidationError>("deviceComplianceScriptRulesValidationError", DeviceComplianceScriptRulesValidationError);
            writer.WriteStringValue("message", Message);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
