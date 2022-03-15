using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the collection of application entities.</summary>
    public class SynchronizationTaskExecution : IAdditionalDataHolder, IParsable {
        /// <summary>Identifier of the job run.</summary>
        public string ActivityIdentifier { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Count of processed entries that were assigned for this application.</summary>
        public int? CountEntitled { get; set; }
        /// <summary>Count of processed entries that were assigned for provisioning.</summary>
        public int? CountEntitledForProvisioning { get; set; }
        /// <summary>Count of entries that were escrowed (errors).</summary>
        public int? CountEscrowed { get; set; }
        /// <summary>Count of entries that were escrowed, including system-generated escrows.</summary>
        public int? CountEscrowedRaw { get; set; }
        /// <summary>Count of exported entries.</summary>
        public int? CountExported { get; set; }
        /// <summary>Count of entries that were expected to be exported.</summary>
        public int? CountExports { get; set; }
        /// <summary>Count of imported entries.</summary>
        public int? CountImported { get; set; }
        /// <summary>Count of imported delta-changes.</summary>
        public int? CountImportedDeltas { get; set; }
        /// <summary>Count of imported delta-changes pertaining to reference changes.</summary>
        public int? CountImportedReferenceDeltas { get; set; }
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
                {"countEntitled", (o,n) => { (o as SynchronizationTaskExecution).CountEntitled = n.GetIntValue(); } },
                {"countEntitledForProvisioning", (o,n) => { (o as SynchronizationTaskExecution).CountEntitledForProvisioning = n.GetIntValue(); } },
                {"countEscrowed", (o,n) => { (o as SynchronizationTaskExecution).CountEscrowed = n.GetIntValue(); } },
                {"countEscrowedRaw", (o,n) => { (o as SynchronizationTaskExecution).CountEscrowedRaw = n.GetIntValue(); } },
                {"countExported", (o,n) => { (o as SynchronizationTaskExecution).CountExported = n.GetIntValue(); } },
                {"countExports", (o,n) => { (o as SynchronizationTaskExecution).CountExports = n.GetIntValue(); } },
                {"countImported", (o,n) => { (o as SynchronizationTaskExecution).CountImported = n.GetIntValue(); } },
                {"countImportedDeltas", (o,n) => { (o as SynchronizationTaskExecution).CountImportedDeltas = n.GetIntValue(); } },
                {"countImportedReferenceDeltas", (o,n) => { (o as SynchronizationTaskExecution).CountImportedReferenceDeltas = n.GetIntValue(); } },
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
            writer.WriteIntValue("countEntitled", CountEntitled);
            writer.WriteIntValue("countEntitledForProvisioning", CountEntitledForProvisioning);
            writer.WriteIntValue("countEscrowed", CountEscrowed);
            writer.WriteIntValue("countEscrowedRaw", CountEscrowedRaw);
            writer.WriteIntValue("countExported", CountExported);
            writer.WriteIntValue("countExports", CountExports);
            writer.WriteIntValue("countImported", CountImported);
            writer.WriteIntValue("countImportedDeltas", CountImportedDeltas);
            writer.WriteIntValue("countImportedReferenceDeltas", CountImportedReferenceDeltas);
            writer.WriteObjectValue<SynchronizationError>("error", Error);
            writer.WriteEnumValue<SynchronizationTaskExecutionResult>("state", State);
            writer.WriteDateTimeOffsetValue("timeBegan", TimeBegan);
            writer.WriteDateTimeOffsetValue("timeEnded", TimeEnded);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
