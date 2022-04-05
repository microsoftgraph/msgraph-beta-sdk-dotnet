using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ItemActivityTimeSet : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The lastRecordedDateTime property</summary>
        public DateTimeOffset? LastRecordedDateTime { get; set; }
        /// <summary>When the activity was observed to take place.</summary>
        public DateTimeOffset? ObservedDateTime { get; set; }
        /// <summary>When the observation was recorded on the service.</summary>
        public DateTimeOffset? RecordedDateTime { get; set; }
        /// <summary>
        /// Instantiates a new itemActivityTimeSet and sets the default values.
        /// </summary>
        public ItemActivityTimeSet() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ItemActivityTimeSet CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ItemActivityTimeSet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"lastRecordedDateTime", (o,n) => { (o as ItemActivityTimeSet).LastRecordedDateTime = n.GetDateTimeOffsetValue(); } },
                {"observedDateTime", (o,n) => { (o as ItemActivityTimeSet).ObservedDateTime = n.GetDateTimeOffsetValue(); } },
                {"recordedDateTime", (o,n) => { (o as ItemActivityTimeSet).RecordedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("lastRecordedDateTime", LastRecordedDateTime);
            writer.WriteDateTimeOffsetValue("observedDateTime", ObservedDateTime);
            writer.WriteDateTimeOffsetValue("recordedDateTime", RecordedDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
