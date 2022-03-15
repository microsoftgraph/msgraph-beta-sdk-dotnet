using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the collection of organization entities.</summary>
    public class DirectorySizeQuota : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Total amount of the directory quota.</summary>
        public int? Total { get; set; }
        /// <summary>Used amount of the directory quota.</summary>
        public int? Used { get; set; }
        /// <summary>
        /// Instantiates a new directorySizeQuota and sets the default values.
        /// </summary>
        public DirectorySizeQuota() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DirectorySizeQuota CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DirectorySizeQuota();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"total", (o,n) => { (o as DirectorySizeQuota).Total = n.GetIntValue(); } },
                {"used", (o,n) => { (o as DirectorySizeQuota).Used = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("total", Total);
            writer.WriteIntValue("used", Used);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
