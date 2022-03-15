using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the collection of application entities.</summary>
    public class SynchronizationSchedule : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Date and time when this job will expire. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? Expiration { get; set; }
        /// <summary>The interval between synchronization iterations.</summary>
        public TimeSpan? Interval { get; set; }
        /// <summary>Possible values are: Active, Disabled.</summary>
        public SynchronizationScheduleState? State { get; set; }
        /// <summary>
        /// Instantiates a new synchronizationSchedule and sets the default values.
        /// </summary>
        public SynchronizationSchedule() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SynchronizationSchedule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SynchronizationSchedule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"expiration", (o,n) => { (o as SynchronizationSchedule).Expiration = n.GetDateTimeOffsetValue(); } },
                {"interval", (o,n) => { (o as SynchronizationSchedule).Interval = n.GetTimeSpanValue(); } },
                {"state", (o,n) => { (o as SynchronizationSchedule).State = n.GetEnumValue<SynchronizationScheduleState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("expiration", Expiration);
            writer.WriteTimeSpanValue("interval", Interval);
            writer.WriteEnumValue<SynchronizationScheduleState>("state", State);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
