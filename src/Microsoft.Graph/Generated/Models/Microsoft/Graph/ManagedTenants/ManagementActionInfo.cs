using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedTenants {
    public class ManagementActionInfo : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The identifier for the management action. Required. Read-only.</summary>
        public string ManagementActionId { get; set; }
        /// <summary>The identifier for the management template. Required. Read-only.</summary>
        public string ManagementTemplateId { get; set; }
        public int? ManagementTemplateVersion { get; set; }
        /// <summary>
        /// Instantiates a new managementActionInfo and sets the default values.
        /// </summary>
        public ManagementActionInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"managementActionId", (o,n) => { (o as ManagementActionInfo).ManagementActionId = n.GetStringValue(); } },
                {"managementTemplateId", (o,n) => { (o as ManagementActionInfo).ManagementTemplateId = n.GetStringValue(); } },
                {"managementTemplateVersion", (o,n) => { (o as ManagementActionInfo).ManagementTemplateVersion = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("managementActionId", ManagementActionId);
            writer.WriteStringValue("managementTemplateId", ManagementTemplateId);
            writer.WriteIntValue("managementTemplateVersion", ManagementTemplateVersion);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
