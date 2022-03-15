using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the collection of approvalWorkflowProvider entities.</summary>
    public class GovernanceNotificationTemplate : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Culture { get; set; }
        public string Id { get; set; }
        public string Source { get; set; }
        public string Type { get; set; }
        public string Version { get; set; }
        /// <summary>
        /// Instantiates a new governanceNotificationTemplate and sets the default values.
        /// </summary>
        public GovernanceNotificationTemplate() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static GovernanceNotificationTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GovernanceNotificationTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"culture", (o,n) => { (o as GovernanceNotificationTemplate).Culture = n.GetStringValue(); } },
                {"id", (o,n) => { (o as GovernanceNotificationTemplate).Id = n.GetStringValue(); } },
                {"source", (o,n) => { (o as GovernanceNotificationTemplate).Source = n.GetStringValue(); } },
                {"type", (o,n) => { (o as GovernanceNotificationTemplate).Type = n.GetStringValue(); } },
                {"version", (o,n) => { (o as GovernanceNotificationTemplate).Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("culture", Culture);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("source", Source);
            writer.WriteStringValue("type", Type);
            writer.WriteStringValue("version", Version);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
