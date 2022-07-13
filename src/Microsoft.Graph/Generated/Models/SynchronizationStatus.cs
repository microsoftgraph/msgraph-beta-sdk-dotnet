using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SynchronizationStatus : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The code property</summary>
        public SynchronizationStatusCode? Code {
            get { return BackingStore?.Get<SynchronizationStatusCode?>("code"); }
            set { BackingStore?.Set("code", value); }
        }
        /// <summary>Number of consecutive times this job failed.</summary>
        public long? CountSuccessiveCompleteFailures {
            get { return BackingStore?.Get<long?>("countSuccessiveCompleteFailures"); }
            set { BackingStore?.Set("countSuccessiveCompleteFailures", value); }
        }
        /// <summary>true if the job&apos;s escrows (object-level errors) were pruned during initial synchronization. Escrows can be pruned if during the initial synchronization, you reach the threshold of errors that would normally put the job in quarantine. Instead of going into quarantine, the synchronization process clears the job&apos;s errors and continues until the initial synchronization is completed. When the initial synchronization is completed, the job will pause and wait for the customer to clean up the errors.</summary>
        public bool? EscrowsPruned {
            get { return BackingStore?.Get<bool?>("escrowsPruned"); }
            set { BackingStore?.Set("escrowsPruned", value); }
        }
        /// <summary>Details of the last execution of the job.</summary>
        public SynchronizationTaskExecution LastExecution {
            get { return BackingStore?.Get<SynchronizationTaskExecution>("lastExecution"); }
            set { BackingStore?.Set("lastExecution", value); }
        }
        /// <summary>Details of the last execution of this job, which didn&apos;t have any errors.</summary>
        public SynchronizationTaskExecution LastSuccessfulExecution {
            get { return BackingStore?.Get<SynchronizationTaskExecution>("lastSuccessfulExecution"); }
            set { BackingStore?.Set("lastSuccessfulExecution", value); }
        }
        /// <summary>Details of the last execution of the job, which exported objects into the target directory.</summary>
        public SynchronizationTaskExecution LastSuccessfulExecutionWithExports {
            get { return BackingStore?.Get<SynchronizationTaskExecution>("lastSuccessfulExecutionWithExports"); }
            set { BackingStore?.Set("lastSuccessfulExecutionWithExports", value); }
        }
        /// <summary>Details of the progress of a job toward completion.</summary>
        public List<SynchronizationProgress> Progress {
            get { return BackingStore?.Get<List<SynchronizationProgress>>("progress"); }
            set { BackingStore?.Set("progress", value); }
        }
        /// <summary>If job is in quarantine, quarantine details.</summary>
        public SynchronizationQuarantine Quarantine {
            get { return BackingStore?.Get<SynchronizationQuarantine>("quarantine"); }
            set { BackingStore?.Set("quarantine", value); }
        }
        /// <summary>The time when steady state (no more changes to the process) was first achieved. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? SteadyStateFirstAchievedTime {
            get { return BackingStore?.Get<DateTimeOffset?>("steadyStateFirstAchievedTime"); }
            set { BackingStore?.Set("steadyStateFirstAchievedTime", value); }
        }
        /// <summary>The time when steady state (no more changes to the process) was last achieved. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? SteadyStateLastAchievedTime {
            get { return BackingStore?.Get<DateTimeOffset?>("steadyStateLastAchievedTime"); }
            set { BackingStore?.Set("steadyStateLastAchievedTime", value); }
        }
        /// <summary>Count of synchronized objects, listed by object type.</summary>
        public List<StringKeyLongValuePair> SynchronizedEntryCountByType {
            get { return BackingStore?.Get<List<StringKeyLongValuePair>>("synchronizedEntryCountByType"); }
            set { BackingStore?.Set("synchronizedEntryCountByType", value); }
        }
        /// <summary>In the event of an error, the URL with the troubleshooting steps for the issue.</summary>
        public string TroubleshootingUrl {
            get { return BackingStore?.Get<string>("troubleshootingUrl"); }
            set { BackingStore?.Set("troubleshootingUrl", value); }
        }
        /// <summary>
        /// Instantiates a new synchronizationStatus and sets the default values.
        /// </summary>
        public SynchronizationStatus() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SynchronizationStatus CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SynchronizationStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"code", n => { Code = n.GetEnumValue<SynchronizationStatusCode>(); } },
                {"countSuccessiveCompleteFailures", n => { CountSuccessiveCompleteFailures = n.GetLongValue(); } },
                {"escrowsPruned", n => { EscrowsPruned = n.GetBoolValue(); } },
                {"lastExecution", n => { LastExecution = n.GetObjectValue<SynchronizationTaskExecution>(SynchronizationTaskExecution.CreateFromDiscriminatorValue); } },
                {"lastSuccessfulExecution", n => { LastSuccessfulExecution = n.GetObjectValue<SynchronizationTaskExecution>(SynchronizationTaskExecution.CreateFromDiscriminatorValue); } },
                {"lastSuccessfulExecutionWithExports", n => { LastSuccessfulExecutionWithExports = n.GetObjectValue<SynchronizationTaskExecution>(SynchronizationTaskExecution.CreateFromDiscriminatorValue); } },
                {"progress", n => { Progress = n.GetCollectionOfObjectValues<SynchronizationProgress>(SynchronizationProgress.CreateFromDiscriminatorValue).ToList(); } },
                {"quarantine", n => { Quarantine = n.GetObjectValue<SynchronizationQuarantine>(SynchronizationQuarantine.CreateFromDiscriminatorValue); } },
                {"steadyStateFirstAchievedTime", n => { SteadyStateFirstAchievedTime = n.GetDateTimeOffsetValue(); } },
                {"steadyStateLastAchievedTime", n => { SteadyStateLastAchievedTime = n.GetDateTimeOffsetValue(); } },
                {"synchronizedEntryCountByType", n => { SynchronizedEntryCountByType = n.GetCollectionOfObjectValues<StringKeyLongValuePair>(StringKeyLongValuePair.CreateFromDiscriminatorValue).ToList(); } },
                {"troubleshootingUrl", n => { TroubleshootingUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<SynchronizationStatusCode>("code", Code);
            writer.WriteLongValue("countSuccessiveCompleteFailures", CountSuccessiveCompleteFailures);
            writer.WriteBoolValue("escrowsPruned", EscrowsPruned);
            writer.WriteObjectValue<SynchronizationTaskExecution>("lastExecution", LastExecution);
            writer.WriteObjectValue<SynchronizationTaskExecution>("lastSuccessfulExecution", LastSuccessfulExecution);
            writer.WriteObjectValue<SynchronizationTaskExecution>("lastSuccessfulExecutionWithExports", LastSuccessfulExecutionWithExports);
            writer.WriteCollectionOfObjectValues<SynchronizationProgress>("progress", Progress);
            writer.WriteObjectValue<SynchronizationQuarantine>("quarantine", Quarantine);
            writer.WriteDateTimeOffsetValue("steadyStateFirstAchievedTime", SteadyStateFirstAchievedTime);
            writer.WriteDateTimeOffsetValue("steadyStateLastAchievedTime", SteadyStateLastAchievedTime);
            writer.WriteCollectionOfObjectValues<StringKeyLongValuePair>("synchronizedEntryCountByType", SynchronizedEntryCountByType);
            writer.WriteStringValue("troubleshootingUrl", TroubleshootingUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
