using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph.ManagedTenants {
    public class ManagementIntentInfo : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The display name for the management intent. Optional. Read-only.</summary>
        public string ManagementIntentDisplayName { get; set; }
        /// <summary>The identifier for the management intent. Required. Read-only.</summary>
        public string ManagementIntentId { get; set; }
        /// <summary>The collection of management template information associated with the management intent. Optional. Read-only.</summary>
        public List<ManagementTemplateDetailedInfo> ManagementTemplates { get; set; }
        /// <summary>
        /// Instantiates a new managementIntentInfo and sets the default values.
        /// </summary>
        public ManagementIntentInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"managementIntentDisplayName", (o,n) => { (o as ManagementIntentInfo).ManagementIntentDisplayName = n.GetStringValue(); } },
                {"managementIntentId", (o,n) => { (o as ManagementIntentInfo).ManagementIntentId = n.GetStringValue(); } },
                {"managementTemplates", (o,n) => { (o as ManagementIntentInfo).ManagementTemplates = n.GetCollectionOfObjectValues<ManagementTemplateDetailedInfo>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("managementIntentDisplayName", ManagementIntentDisplayName);
            writer.WriteStringValue("managementIntentId", ManagementIntentId);
            writer.WriteCollectionOfObjectValues<ManagementTemplateDetailedInfo>("managementTemplates", ManagementTemplates);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
