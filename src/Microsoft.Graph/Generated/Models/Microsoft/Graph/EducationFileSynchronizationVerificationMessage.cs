using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class EducationFileSynchronizationVerificationMessage : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Detailed information about the message type.</summary>
        public string Description { get; set; }
        public string FileName { get; set; }
        /// <summary>Type of the message. Possible values are: error, warning, information.</summary>
        public string Type { get; set; }
        /// <summary>
        /// Instantiates a new educationFileSynchronizationVerificationMessage and sets the default values.
        /// </summary>
        public EducationFileSynchronizationVerificationMessage() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static EducationFileSynchronizationVerificationMessage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationFileSynchronizationVerificationMessage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"description", (o,n) => { (o as EducationFileSynchronizationVerificationMessage).Description = n.GetStringValue(); } },
                {"fileName", (o,n) => { (o as EducationFileSynchronizationVerificationMessage).FileName = n.GetStringValue(); } },
                {"type", (o,n) => { (o as EducationFileSynchronizationVerificationMessage).Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("fileName", FileName);
            writer.WriteStringValue("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
