using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to call the triggerConfigurationManagerAction method.</summary>
    public class ConfigurationManagerAction : IAdditionalDataHolder, IParsable {
        /// <summary>The action type to trigger on Configuration Manager client. Possible values are: refreshMachinePolicy, refreshUserPolicy, wakeUpClient, appEvaluation, quickScan, fullScan, windowsDefenderUpdateSignatures.</summary>
        public ConfigurationManagerActionType? Action { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>
        /// Instantiates a new configurationManagerAction and sets the default values.
        /// </summary>
        public ConfigurationManagerAction() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ConfigurationManagerAction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConfigurationManagerAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"action", (o,n) => { (o as ConfigurationManagerAction).Action = n.GetEnumValue<ConfigurationManagerActionType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<ConfigurationManagerActionType>("action", Action);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
