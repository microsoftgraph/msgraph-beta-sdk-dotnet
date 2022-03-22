using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class TimeCardEvent : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates whether the entry was recorded at the approved location.</summary>
        public bool? AtApprovedLocation { get; set; }
        /// <summary>The time the entry is recorded.</summary>
        public DateTimeOffset? DateTime { get; set; }
        /// <summary>Notes about the timeCardEvent.</summary>
        public ItemBody Notes { get; set; }
        /// <summary>
        /// Instantiates a new timeCardEvent and sets the default values.
        /// </summary>
        public TimeCardEvent() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TimeCardEvent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TimeCardEvent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"atApprovedLocation", (o,n) => { (o as TimeCardEvent).AtApprovedLocation = n.GetBoolValue(); } },
                {"dateTime", (o,n) => { (o as TimeCardEvent).DateTime = n.GetDateTimeOffsetValue(); } },
                {"notes", (o,n) => { (o as TimeCardEvent).Notes = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("atApprovedLocation", AtApprovedLocation);
            writer.WriteDateTimeOffsetValue("dateTime", DateTime);
            writer.WriteObjectValue<ItemBody>("notes", Notes);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
