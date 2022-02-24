using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.DeviceManagement.DeviceManagementScripts.Item.DeviceRunStates.Item.ManagedDevice.TriggerConfigurationManagerAction {
    public class TriggerConfigurationManagerActionRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Parameter for action triggerConfigurationManagerAction</summary>
        public ConfigurationManagerAction ConfigurationManagerAction { get; set; }
        /// <summary>
        /// Instantiates a new triggerConfigurationManagerActionRequestBody and sets the default values.
        /// </summary>
        public TriggerConfigurationManagerActionRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"configurationManagerAction", (o,n) => { (o as TriggerConfigurationManagerActionRequestBody).ConfigurationManagerAction = n.GetObjectValue<ConfigurationManagerAction>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ConfigurationManagerAction>("configurationManagerAction", ConfigurationManagerAction);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
