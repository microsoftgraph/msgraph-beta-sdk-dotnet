using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.Ediscovery {
    /// <summary>Provides operations to manage the compliance singleton.</summary>
    public class OcrSettings : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates whether or not OCR is enabled for the case.</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>Maximum image size that will be processed in KB).</summary>
        public int? MaxImageSize { get; set; }
        /// <summary>The timeout duration for the OCR engine. A longer timeout may increase success of OCR, but may add to the total processing time.</summary>
        public TimeSpan? Timeout { get; set; }
        /// <summary>
        /// Instantiates a new ocrSettings and sets the default values.
        /// </summary>
        public OcrSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static OcrSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OcrSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"isEnabled", (o,n) => { (o as OcrSettings).IsEnabled = n.GetBoolValue(); } },
                {"maxImageSize", (o,n) => { (o as OcrSettings).MaxImageSize = n.GetIntValue(); } },
                {"timeout", (o,n) => { (o as OcrSettings).Timeout = n.GetTimeSpanValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteIntValue("maxImageSize", MaxImageSize);
            writer.WriteTimeSpanValue("timeout", Timeout);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
