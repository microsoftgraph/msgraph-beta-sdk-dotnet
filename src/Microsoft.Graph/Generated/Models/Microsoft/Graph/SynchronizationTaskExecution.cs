using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class SynchronizationTaskExecution : IAdditionalDataHolder, IParsable {
        /// <summary>Identifier of the job run.</summary>
        public string ActivityIdentifier { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Count of processed entries that were assigned for this application.</summary>
        public long? CountEntitled { get; set; }
        /// <summary>Count of processed entries that were assigned for provisioning.</summary>
        public long? CountEntitledForProvisioning { get; set; }
        /// <summary>Count of entries that were escrowed (errors).</summary>
        public long? CountEscrowed { get; set; }
        /// <summary>Count of entries that were escrowed, including system-generated escrows.</summary>
        public long? CountEscrowedRaw { get; set; }
        /// <summary>Count of exported entries.</summary>
        public long? CountExported { get; set; }
        /// <summary>Count of entries that were expected to be exported.</summary>
        public long? CountExports { get; set; }
        /// <summary>Count of imported entries.</summary>
        public long? CountImported { get; set; }
        /// <summary>Count of imported delta-changes.</summary>
        public long? CountImportedDeltas { get; set; }
        /// <summary>Count of imported delta-changes pertaining to reference changes.</summary>
        public long? CountImportedReferenceDeltas { get; set; }
        /// <summary>If an error was encountered, contains a synchronizationError object with details.</summary>
        public SynchronizationError Error { get; set; }
        /// <summary>Code summarizing the result of this run. Possible values are: Succeeded, Failed, EntryLevelErrors.</summary>
        public SynchronizationTaskExecutionResult? State { get; set; }
        /// <summary>Time when this job run began. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? TimeBegan { get; set; }
        /// <summary>Time when this job run ended. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? TimeEnded { get; set; }
        /// <summary>
        /// Instantiates a new synchronizationTaskExecution and sets the default values.
        /// </summary>
        public SynchronizationTaskExecution() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SynchronizationTaskExecution CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SynchronizationTaskExecution();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"activityIdentifier", (o,n) => { (o as SynchronizationTaskExecution).ActivityIdentifier = n.GetStringValue(); } },
                {"countEntitled", (o,n) => { (o as SynchronizationTaskExecution).CountEntitled = n.GetLongValue(); } },
                {"countEntitledForProvisioning", (o,n) => { (o as SynchronizationTaskExecution).CountEntitledForProvisioning = n.GetLongValue(); } },
                {"countEscrowed", (o,n) => { (o as SynchronizationTaskExecution).CountEscrowed = n.GetLongValue(); } },
                {"countEscrowedRaw", (o,n) => { (o as SynchronizationTaskExecution).CountEscrowedRaw = n.GetLongValue(); } },
                {"countExported", (o,n) => { (o as SynchronizationTaskExecution).CountExported = n.GetLongValue(); } },
                {"countExports", (o,n) => { (o as SynchronizationTaskExecution).CountExports = n.GetLongValue(); } },
                {"countImported", (o,n) => { (o as SynchronizationTaskExecution).CountImported = n.GetLongValue(); } },
                {"countImportedDeltas", (o,n) => { (o as SynchronizationTaskExecution).CountImportedDeltas = n.GetLongValue(); } },
                {"countImportedReferenceDeltas", (o,n) => { (o as SynchronizationTaskExecution).CountImportedReferenceDeltas = n.GetLongValue(); } },
                {"error", (o,n) => { (o as SynchronizationTaskExecution).Error = n.GetObjectValue<SynchronizationError>(SynchronizationError.CreateFromDiscriminatorValue); } },
                {"state", (o,n) => { (o as SynchronizationTaskExecution).State = n.GetEnumValue<SynchronizationTaskExecutionResult>(); } },
                {"timeBegan", (o,n) => { (o as SynchronizationTaskExecution).TimeBegan = n.GetDateTimeOffsetValue(); } },
                {"timeEnded", (o,n) => { (o as SynchronizationTaskExecution).TimeEnded = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("activityIdentifier", ActivityIdentifier);
            writer.WriteLongValue("countEntitled", CountEntitled);
            writer.WriteLongValue("countEntitledForProvisioning", CountEntitledForProvisioning);
            writer.WriteLongValue("countEscrowed", CountEscrowed);
            writer.WriteLongValue("countEscrowedRaw", CountEscrowedRaw);
            writer.WriteLongValue("countExported", CountExported);
            writer.WriteLongValue("countExports", CountExports);
            writer.WriteLongValue("countImported", CountImported);
            writer.WriteLongValue("countImportedDeltas", CountImportedDeltas);
            writer.WriteLongValue("countImportedReferenceDeltas", CountImportedReferenceDeltas);
            writer.WriteObjectValue<SynchronizationError>("error", Error);
            writer.WriteEnumValue<SynchronizationTaskExecutionResult>("state", State);
            writer.WriteDateTimeOffsetValue("timeBegan", TimeBegan);
            writer.WriteDateTimeOffsetValue("timeEnded", TimeEnded);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
