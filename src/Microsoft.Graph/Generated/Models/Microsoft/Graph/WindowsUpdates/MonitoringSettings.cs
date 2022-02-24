using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.WindowsUpdates {
    public class MonitoringSettings : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Specifies the rules through which monitoring signals can trigger actions on the deployment. Rules are combined using 'or'.</summary>
        public List<MonitoringRule> MonitoringRules { get; set; }
        /// <summary>
        /// Instantiates a new monitoringSettings and sets the default values.
        /// </summary>
        public MonitoringSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"monitoringRules", (o,n) => { (o as MonitoringSettings).MonitoringRules = n.GetCollectionOfObjectValues<MonitoringRule>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<MonitoringRule>("monitoringRules", MonitoringRules);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
