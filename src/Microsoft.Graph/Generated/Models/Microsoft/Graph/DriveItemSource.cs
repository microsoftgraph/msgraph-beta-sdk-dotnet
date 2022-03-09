using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the compliance singleton.</summary>
    public class DriveItemSource : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Enumeration value that indicates the source application where the file was created.</summary>
        public DriveItemSourceApplication? Application { get; set; }
        /// <summary>The external identifier for the drive item from the source.</summary>
        public string ExternalId { get; set; }
        /// <summary>
        /// Instantiates a new driveItemSource and sets the default values.
        /// </summary>
        public DriveItemSource() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DriveItemSource CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DriveItemSource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"application", (o,n) => { (o as DriveItemSource).Application = n.GetEnumValue<DriveItemSourceApplication>(); } },
                {"externalId", (o,n) => { (o as DriveItemSource).ExternalId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<DriveItemSourceApplication>("application", Application);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
