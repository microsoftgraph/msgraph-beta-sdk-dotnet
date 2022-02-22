using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class InstitutionData : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Short description of the institution the user studied at.</summary>
        public string Description { get; set; }
        /// <summary>Name of the institution the user studied at.</summary>
        public string DisplayName { get; set; }
        /// <summary>Address or location of the institute.</summary>
        public PhysicalAddress Location { get; set; }
        /// <summary>Link to the institution or department homepage.</summary>
        public string WebUrl { get; set; }
        /// <summary>
        /// Instantiates a new institutionData and sets the default values.
        /// </summary>
        public InstitutionData() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"description", (o,n) => { (o as InstitutionData).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as InstitutionData).DisplayName = n.GetStringValue(); } },
                {"location", (o,n) => { (o as InstitutionData).Location = n.GetObjectValue<PhysicalAddress>(); } },
                {"webUrl", (o,n) => { (o as InstitutionData).WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<PhysicalAddress>("location", Location);
            writer.WriteStringValue("webUrl", WebUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
