using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SynchronizationSchedule : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Date and time when this job will expire. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? Expiration {
            get { return BackingStore?.Get<DateTimeOffset?>("expiration"); }
            set { BackingStore?.Set("expiration", value); }
        }
        /// <summary>The interval between synchronization iterations.</summary>
        public TimeSpan? Interval {
            get { return BackingStore?.Get<TimeSpan?>("interval"); }
            set { BackingStore?.Set("interval", value); }
        }
        /// <summary>The state property</summary>
        public SynchronizationScheduleState? State {
            get { return BackingStore?.Get<SynchronizationScheduleState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>
        /// Instantiates a new synchronizationSchedule and sets the default values.
        /// </summary>
        public SynchronizationSchedule() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
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
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"expiration", n => { Expiration = n.GetDateTimeOffsetValue(); } },
                {"interval", n => { Interval = n.GetTimeSpanValue(); } },
                {"state", n => { State = n.GetEnumValue<SynchronizationScheduleState>(); } },
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
