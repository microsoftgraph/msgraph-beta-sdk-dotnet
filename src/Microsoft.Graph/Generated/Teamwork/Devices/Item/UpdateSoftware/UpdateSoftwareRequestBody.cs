using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Teamwork.Devices.Item.UpdateSoftware {
    /// <summary>Provides operations to call the updateSoftware method.</summary>
    public class UpdateSoftwareRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The softwareType property</summary>
        public TeamworkSoftwareType? SoftwareType { get; set; }
        /// <summary>The softwareVersion property</summary>
        public string SoftwareVersion { get; set; }
        /// <summary>
        /// Instantiates a new updateSoftwareRequestBody and sets the default values.
        /// </summary>
        public UpdateSoftwareRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UpdateSoftwareRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UpdateSoftwareRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"softwareType", n => { SoftwareType = n.GetEnumValue<TeamworkSoftwareType>(); } },
                {"softwareVersion", n => { SoftwareVersion = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<TeamworkSoftwareType>("softwareType", SoftwareType);
            writer.WriteStringValue("softwareVersion", SoftwareVersion);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
