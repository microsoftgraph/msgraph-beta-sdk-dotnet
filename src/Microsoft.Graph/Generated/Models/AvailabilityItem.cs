using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AvailabilityItem : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The endDateTime property</summary>
        public DateTimeTimeZone EndDateTime { get; set; }
        /// <summary>The serviceId property</summary>
        public string ServiceId { get; set; }
        /// <summary>The startDateTime property</summary>
        public DateTimeTimeZone StartDateTime { get; set; }
        /// <summary>The status property</summary>
        public BookingsAvailabilityStatus? Status { get; set; }
        /// <summary>
        /// Instantiates a new availabilityItem and sets the default values.
        /// </summary>
        public AvailabilityItem() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AvailabilityItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AvailabilityItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"endDateTime", (o,n) => { (o as AvailabilityItem).EndDateTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"serviceId", (o,n) => { (o as AvailabilityItem).ServiceId = n.GetStringValue(); } },
                {"startDateTime", (o,n) => { (o as AvailabilityItem).StartDateTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"status", (o,n) => { (o as AvailabilityItem).Status = n.GetEnumValue<BookingsAvailabilityStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<DateTimeTimeZone>("endDateTime", EndDateTime);
            writer.WriteStringValue("serviceId", ServiceId);
            writer.WriteObjectValue<DateTimeTimeZone>("startDateTime", StartDateTime);
            writer.WriteEnumValue<BookingsAvailabilityStatus>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
