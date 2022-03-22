using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class GovernanceNotificationPolicy : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<string> EnabledTemplateTypes { get; set; }
        public List<GovernanceNotificationTemplate> NotificationTemplates { get; set; }
        /// <summary>
        /// Instantiates a new governanceNotificationPolicy and sets the default values.
        /// </summary>
        public GovernanceNotificationPolicy() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static GovernanceNotificationPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GovernanceNotificationPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"enabledTemplateTypes", (o,n) => { (o as GovernanceNotificationPolicy).EnabledTemplateTypes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"notificationTemplates", (o,n) => { (o as GovernanceNotificationPolicy).NotificationTemplates = n.GetCollectionOfObjectValues<GovernanceNotificationTemplate>(GovernanceNotificationTemplate.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("enabledTemplateTypes", EnabledTemplateTypes);
            writer.WriteCollectionOfObjectValues<GovernanceNotificationTemplate>("notificationTemplates", NotificationTemplates);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
