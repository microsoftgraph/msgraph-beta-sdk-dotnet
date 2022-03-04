using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Me.ManagedDevices.Item.TriggerConfigurationManagerAction {
    public class TriggerConfigurationManagerActionRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Parameter for action triggerConfigurationManagerAction</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ConfigurationManagerAction ConfigurationManagerAction { get; set; }
        /// <summary>
        /// Instantiates a new triggerConfigurationManagerActionRequestBody and sets the default values.
        /// </summary>
        public TriggerConfigurationManagerActionRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TriggerConfigurationManagerActionRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TriggerConfigurationManagerActionRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"configurationManagerAction", (o,n) => { (o as TriggerConfigurationManagerActionRequestBody).ConfigurationManagerAction = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ConfigurationManagerAction>(MicrosoftGraphSdk.Models.Microsoft.Graph.ConfigurationManagerAction.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ConfigurationManagerAction>("configurationManagerAction", ConfigurationManagerAction);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
