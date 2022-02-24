using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class SynchronizationQuarantine : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Date and time when the quarantine was last evaluated and imposed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CurrentBegan { get; set; }
        /// <summary>Describes the error(s) that occurred when putting the synchronization job into quarantine.</summary>
        public SynchronizationError Error { get; set; }
        /// <summary>Date and time when the next attempt to re-evaluate the quarantine will be made. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? NextAttempt { get; set; }
        /// <summary>A code that signifies why the quarantine was imposed. Possible values are: EncounteredBaseEscrowThreshold, EncounteredTotalEscrowThreshold, EncounteredEscrowProportionThreshold, EncounteredQuarantineException, QuarantinedOnDemand, TooManyDeletes, Unknown.</summary>
        public QuarantineReason? Reason { get; set; }
        /// <summary>Date and time when the quarantine was first imposed in this series (a series starts when a quarantine is first imposed, and is reset as soon as the quarantine is lifted). The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? SeriesBegan { get; set; }
        /// <summary>Number of times in this series the quarantine was re-evaluated and left in effect (a series starts when quarantine is first imposed, and is reset as soon as quarantine is lifted).</summary>
        public long? SeriesCount { get; set; }
        /// <summary>
        /// Instantiates a new synchronizationQuarantine and sets the default values.
        /// </summary>
        public SynchronizationQuarantine() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"currentBegan", (o,n) => { (o as SynchronizationQuarantine).CurrentBegan = n.GetDateTimeOffsetValue(); } },
                {"error", (o,n) => { (o as SynchronizationQuarantine).Error = n.GetObjectValue<SynchronizationError>(); } },
                {"nextAttempt", (o,n) => { (o as SynchronizationQuarantine).NextAttempt = n.GetDateTimeOffsetValue(); } },
                {"reason", (o,n) => { (o as SynchronizationQuarantine).Reason = n.GetEnumValue<QuarantineReason>(); } },
                {"seriesBegan", (o,n) => { (o as SynchronizationQuarantine).SeriesBegan = n.GetDateTimeOffsetValue(); } },
                {"seriesCount", (o,n) => { (o as SynchronizationQuarantine).SeriesCount = n.GetLongValue(); } },
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
