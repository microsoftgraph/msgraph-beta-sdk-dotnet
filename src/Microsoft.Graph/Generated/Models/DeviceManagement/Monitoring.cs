using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.DeviceManagement {
    public class Monitoring : Entity, IParsable {
        /// <summary>The collection of records of alert events.</summary>
        public List<AlertRecord> AlertRecords {
            get { return BackingStore?.Get<List<AlertRecord>>("alertRecords"); }
            set { BackingStore?.Set("alertRecords", value); }
        }
        /// <summary>The collection of alert rules.</summary>
        public List<AlertRule> AlertRules {
            get { return BackingStore?.Get<List<AlertRule>>("alertRules"); }
            set { BackingStore?.Set("alertRules", value); }
        }
        /// <summary>
        /// Instantiates a new monitoring and sets the default values.
        /// </summary>
        public Monitoring() : base() {
            OdataType = "#microsoft.graph.deviceManagement.monitoring";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Monitoring CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Monitoring();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"alertRecords", n => { AlertRecords = n.GetCollectionOfObjectValues<AlertRecord>(AlertRecord.CreateFromDiscriminatorValue)?.ToList(); } },
                {"alertRules", n => { AlertRules = n.GetCollectionOfObjectValues<AlertRule>(AlertRule.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AlertRecord>("alertRecords", AlertRecords);
            writer.WriteCollectionOfObjectValues<AlertRule>("alertRules", AlertRules);
        }
    }
}
