using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SynchronizationQuarantine : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Date and time when the quarantine was last evaluated and imposed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CurrentBegan {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CurrentBegan)); }
            set { BackingStore?.Set(nameof(CurrentBegan), value); }
        }
        /// <summary>Describes the error(s) that occurred when putting the synchronization job into quarantine.</summary>
        public SynchronizationError Error {
            get { return BackingStore?.Get<SynchronizationError>(nameof(Error)); }
            set { BackingStore?.Set(nameof(Error), value); }
        }
        /// <summary>Date and time when the next attempt to re-evaluate the quarantine will be made. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? NextAttempt {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(NextAttempt)); }
            set { BackingStore?.Set(nameof(NextAttempt), value); }
        }
        /// <summary>A code that signifies why the quarantine was imposed. Possible values are: EncounteredBaseEscrowThreshold, EncounteredTotalEscrowThreshold, EncounteredEscrowProportionThreshold, EncounteredQuarantineException, QuarantinedOnDemand, TooManyDeletes, Unknown.</summary>
        public QuarantineReason? Reason {
            get { return BackingStore?.Get<QuarantineReason?>(nameof(Reason)); }
            set { BackingStore?.Set(nameof(Reason), value); }
        }
        /// <summary>Date and time when the quarantine was first imposed in this series (a series starts when a quarantine is first imposed, and is reset as soon as the quarantine is lifted). The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? SeriesBegan {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(SeriesBegan)); }
            set { BackingStore?.Set(nameof(SeriesBegan), value); }
        }
        /// <summary>Number of times in this series the quarantine was re-evaluated and left in effect (a series starts when quarantine is first imposed, and is reset as soon as quarantine is lifted).</summary>
        public long? SeriesCount {
            get { return BackingStore?.Get<long?>(nameof(SeriesCount)); }
            set { BackingStore?.Set(nameof(SeriesCount), value); }
        }
        /// <summary>
        /// Instantiates a new synchronizationQuarantine and sets the default values.
        /// </summary>
        public SynchronizationQuarantine() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SynchronizationQuarantine CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SynchronizationQuarantine();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"currentBegan", n => { CurrentBegan = n.GetDateTimeOffsetValue(); } },
                {"error", n => { Error = n.GetObjectValue<SynchronizationError>(SynchronizationError.CreateFromDiscriminatorValue); } },
                {"nextAttempt", n => { NextAttempt = n.GetDateTimeOffsetValue(); } },
                {"reason", n => { Reason = n.GetEnumValue<QuarantineReason>(); } },
                {"seriesBegan", n => { SeriesBegan = n.GetDateTimeOffsetValue(); } },
                {"seriesCount", n => { SeriesCount = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("currentBegan", CurrentBegan);
            writer.WriteObjectValue<SynchronizationError>("error", Error);
            writer.WriteDateTimeOffsetValue("nextAttempt", NextAttempt);
            writer.WriteEnumValue<QuarantineReason>("reason", Reason);
            writer.WriteDateTimeOffsetValue("seriesBegan", SeriesBegan);
            writer.WriteLongValue("seriesCount", SeriesCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
