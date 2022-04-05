using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SynchronizationStatus : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>High-level status code of the synchronization job. Possible values are: NotConfigured, NotRun, Active, Paused, Quarantine.</summary>
        public SynchronizationStatusCode? Code { get; set; }
        /// <summary>Number of consecutive times this job failed.</summary>
        public long? CountSuccessiveCompleteFailures { get; set; }
        /// <summary>true if the job&apos;s escrows (object-level errors) were pruned during initial synchronization. Escrows can be pruned if during the initial synchronization, you reach the threshold of errors that would normally put the job in quarantine. Instead of going into quarantine, the synchronization process clears the job&apos;s errors and continues until the initial synchronization is completed. When the initial synchronization is completed, the job will pause and wait for the customer to clean up the errors.</summary>
        public bool? EscrowsPruned { get; set; }
        /// <summary>Details of the last execution of the job.</summary>
        public SynchronizationTaskExecution LastExecution { get; set; }
        /// <summary>Details of the last execution of this job, which didn&apos;t have any errors.</summary>
        public SynchronizationTaskExecution LastSuccessfulExecution { get; set; }
        /// <summary>Details of the last execution of the job, which exported objects into the target directory.</summary>
        public SynchronizationTaskExecution LastSuccessfulExecutionWithExports { get; set; }
        /// <summary>Details of the progress of a job toward completion.</summary>
        public List<SynchronizationProgress> Progress { get; set; }
        /// <summary>If job is in quarantine, quarantine details.</summary>
        public SynchronizationQuarantine Quarantine { get; set; }
        /// <summary>The time when steady state (no more changes to the process) was first achieved. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? SteadyStateFirstAchievedTime { get; set; }
        /// <summary>The time when steady state (no more changes to the process) was last achieved. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? SteadyStateLastAchievedTime { get; set; }
        /// <summary>Count of synchronized objects, listed by object type.</summary>
        public List<StringKeyLongValuePair> SynchronizedEntryCountByType { get; set; }
        /// <summary>In the event of an error, the URL with the troubleshooting steps for the issue.</summary>
        public string TroubleshootingUrl { get; set; }
        /// <summary>
        /// Instantiates a new synchronizationStatus and sets the default values.
        /// </summary>
        public SynchronizationStatus() {
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
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"code", (o,n) => { (o as SynchronizationStatus).Code = n.GetEnumValue<SynchronizationStatusCode>(); } },
                {"countSuccessiveCompleteFailures", (o,n) => { (o as SynchronizationStatus).CountSuccessiveCompleteFailures = n.GetLongValue(); } },
                {"escrowsPruned", (o,n) => { (o as SynchronizationStatus).EscrowsPruned = n.GetBoolValue(); } },
                {"lastExecution", (o,n) => { (o as SynchronizationStatus).LastExecution = n.GetObjectValue<SynchronizationTaskExecution>(SynchronizationTaskExecution.CreateFromDiscriminatorValue); } },
                {"lastSuccessfulExecution", (o,n) => { (o as SynchronizationStatus).LastSuccessfulExecution = n.GetObjectValue<SynchronizationTaskExecution>(SynchronizationTaskExecution.CreateFromDiscriminatorValue); } },
                {"lastSuccessfulExecutionWithExports", (o,n) => { (o as SynchronizationStatus).LastSuccessfulExecutionWithExports = n.GetObjectValue<SynchronizationTaskExecution>(SynchronizationTaskExecution.CreateFromDiscriminatorValue); } },
                {"progress", (o,n) => { (o as SynchronizationStatus).Progress = n.GetCollectionOfObjectValues<SynchronizationProgress>(SynchronizationProgress.CreateFromDiscriminatorValue).ToList(); } },
                {"quarantine", (o,n) => { (o as SynchronizationStatus).Quarantine = n.GetObjectValue<SynchronizationQuarantine>(SynchronizationQuarantine.CreateFromDiscriminatorValue); } },
                {"steadyStateFirstAchievedTime", (o,n) => { (o as SynchronizationStatus).SteadyStateFirstAchievedTime = n.GetDateTimeOffsetValue(); } },
                {"steadyStateLastAchievedTime", (o,n) => { (o as SynchronizationStatus).SteadyStateLastAchievedTime = n.GetDateTimeOffsetValue(); } },
                {"synchronizedEntryCountByType", (o,n) => { (o as SynchronizationStatus).SynchronizedEntryCountByType = n.GetCollectionOfObjectValues<StringKeyLongValuePair>(StringKeyLongValuePair.CreateFromDiscriminatorValue).ToList(); } },
                {"troubleshootingUrl", (o,n) => { (o as SynchronizationStatus).TroubleshootingUrl = n.GetStringValue(); } },
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
