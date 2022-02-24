using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class CloudPcAuditResource : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The resource entity display name.</summary>
        public string DisplayName { get; set; }
        /// <summary>A list of modified properties.</summary>
        public List<CloudPcAuditProperty> ModifiedProperties { get; set; }
        /// <summary>The ID of the audit resource.</summary>
        public string ResourceId { get; set; }
        /// <summary>The type of the audit resource.</summary>
        public string Type { get; set; }
        /// <summary>
        /// Instantiates a new cloudPcAuditResource and sets the default values.
        /// </summary>
        public CloudPcAuditResource() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"displayName", (o,n) => { (o as CloudPcAuditResource).DisplayName = n.GetStringValue(); } },
                {"modifiedProperties", (o,n) => { (o as CloudPcAuditResource).ModifiedProperties = n.GetCollectionOfObjectValues<CloudPcAuditProperty>().ToList(); } },
                {"resourceId", (o,n) => { (o as CloudPcAuditResource).ResourceId = n.GetStringValue(); } },
                {"type", (o,n) => { (o as CloudPcAuditResource).Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<CloudPcAuditProperty>("modifiedProperties", ModifiedProperties);
            writer.WriteStringValue("resourceId", ResourceId);
            writer.WriteStringValue("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
