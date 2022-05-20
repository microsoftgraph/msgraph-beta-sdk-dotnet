using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SynchronizationTaskExecution : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Identifier of the job run.</summary>
        public string ActivityIdentifier {
            get { return BackingStore?.Get<string>(nameof(ActivityIdentifier)); }
            set { BackingStore?.Set(nameof(ActivityIdentifier), value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Count of processed entries that were assigned for this application.</summary>
        public long? CountEntitled {
            get { return BackingStore?.Get<long?>(nameof(CountEntitled)); }
            set { BackingStore?.Set(nameof(CountEntitled), value); }
        }
        /// <summary>Count of processed entries that were assigned for provisioning.</summary>
        public long? CountEntitledForProvisioning {
            get { return BackingStore?.Get<long?>(nameof(CountEntitledForProvisioning)); }
            set { BackingStore?.Set(nameof(CountEntitledForProvisioning), value); }
        }
        /// <summary>Count of entries that were escrowed (errors).</summary>
        public long? CountEscrowed {
            get { return BackingStore?.Get<long?>(nameof(CountEscrowed)); }
            set { BackingStore?.Set(nameof(CountEscrowed), value); }
        }
        /// <summary>Count of entries that were escrowed, including system-generated escrows.</summary>
        public long? CountEscrowedRaw {
            get { return BackingStore?.Get<long?>(nameof(CountEscrowedRaw)); }
            set { BackingStore?.Set(nameof(CountEscrowedRaw), value); }
        }
        /// <summary>Count of exported entries.</summary>
        public long? CountExported {
            get { return BackingStore?.Get<long?>(nameof(CountExported)); }
            set { BackingStore?.Set(nameof(CountExported), value); }
        }
        /// <summary>Count of entries that were expected to be exported.</summary>
        public long? CountExports {
            get { return BackingStore?.Get<long?>(nameof(CountExports)); }
            set { BackingStore?.Set(nameof(CountExports), value); }
        }
        /// <summary>Count of imported entries.</summary>
        public long? CountImported {
            get { return BackingStore?.Get<long?>(nameof(CountImported)); }
            set { BackingStore?.Set(nameof(CountImported), value); }
        }
        /// <summary>Count of imported delta-changes.</summary>
        public long? CountImportedDeltas {
            get { return BackingStore?.Get<long?>(nameof(CountImportedDeltas)); }
            set { BackingStore?.Set(nameof(CountImportedDeltas), value); }
        }
        /// <summary>Count of imported delta-changes pertaining to reference changes.</summary>
        public long? CountImportedReferenceDeltas {
            get { return BackingStore?.Get<long?>(nameof(CountImportedReferenceDeltas)); }
            set { BackingStore?.Set(nameof(CountImportedReferenceDeltas), value); }
        }
        /// <summary>If an error was encountered, contains a synchronizationError object with details.</summary>
        public SynchronizationError Error {
            get { return BackingStore?.Get<SynchronizationError>(nameof(Error)); }
            set { BackingStore?.Set(nameof(Error), value); }
        }
        /// <summary>Code summarizing the result of this run. Possible values are: Succeeded, Failed, EntryLevelErrors.</summary>
        public SynchronizationTaskExecutionResult? State {
            get { return BackingStore?.Get<SynchronizationTaskExecutionResult?>(nameof(State)); }
            set { BackingStore?.Set(nameof(State), value); }
        }
        /// <summary>Time when this job run began. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? TimeBegan {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(TimeBegan)); }
            set { BackingStore?.Set(nameof(TimeBegan), value); }
        }
        /// <summary>Time when this job run ended. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? TimeEnded {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(TimeEnded)); }
            set { BackingStore?.Set(nameof(TimeEnded), value); }
        }
        /// <summary>
        /// Instantiates a new synchronizationTaskExecution and sets the default values.
        /// </summary>
        public SynchronizationTaskExecution() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
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
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"activityIdentifier", n => { ActivityIdentifier = n.GetStringValue(); } },
                {"countEntitled", n => { CountEntitled = n.GetLongValue(); } },
                {"countEntitledForProvisioning", n => { CountEntitledForProvisioning = n.GetLongValue(); } },
                {"countEscrowed", n => { CountEscrowed = n.GetLongValue(); } },
                {"countEscrowedRaw", n => { CountEscrowedRaw = n.GetLongValue(); } },
                {"countExported", n => { CountExported = n.GetLongValue(); } },
                {"countExports", n => { CountExports = n.GetLongValue(); } },
                {"countImported", n => { CountImported = n.GetLongValue(); } },
                {"countImportedDeltas", n => { CountImportedDeltas = n.GetLongValue(); } },
                {"countImportedReferenceDeltas", n => { CountImportedReferenceDeltas = n.GetLongValue(); } },
                {"error", n => { Error = n.GetObjectValue<SynchronizationError>(SynchronizationError.CreateFromDiscriminatorValue); } },
                {"state", n => { State = n.GetEnumValue<SynchronizationTaskExecutionResult>(); } },
                {"timeBegan", n => { TimeBegan = n.GetDateTimeOffsetValue(); } },
                {"timeEnded", n => { TimeEnded = n.GetDateTimeOffsetValue(); } },
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
