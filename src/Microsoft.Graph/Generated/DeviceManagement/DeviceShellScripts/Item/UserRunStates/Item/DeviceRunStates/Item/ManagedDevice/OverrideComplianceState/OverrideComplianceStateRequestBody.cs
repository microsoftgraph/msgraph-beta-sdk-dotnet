using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.DeviceManagement.DeviceShellScripts.Item.UserRunStates.Item.DeviceRunStates.Item.ManagedDevice.OverrideComplianceState {
    public class OverrideComplianceStateRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public AdministratorConfiguredDeviceComplianceState? ComplianceState { get; set; }
        public string RemediationUrl { get; set; }
        /// <summary>
        /// Instantiates a new overrideComplianceStateRequestBody and sets the default values.
        /// </summary>
        public OverrideComplianceStateRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"complianceState", (o,n) => { (o as OverrideComplianceStateRequestBody).ComplianceState = n.GetEnumValue<AdministratorConfiguredDeviceComplianceState>(); } },
                {"remediationUrl", (o,n) => { (o as OverrideComplianceStateRequestBody).RemediationUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AdministratorConfiguredDeviceComplianceState>("complianceState", ComplianceState);
            writer.WriteStringValue("remediationUrl", RemediationUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
