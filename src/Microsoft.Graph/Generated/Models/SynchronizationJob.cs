using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public class SynchronizationJob : Entity, IParsable {
        /// <summary>Schedule used to run the job. Read-only.</summary>
        public SynchronizationSchedule Schedule {
            get { return BackingStore?.Get<SynchronizationSchedule>("schedule"); }
            set { BackingStore?.Set("schedule", value); }
        }
        /// <summary>The synchronization schema configured for the job.</summary>
        public SynchronizationSchema Schema {
            get { return BackingStore?.Get<SynchronizationSchema>("schema"); }
            set { BackingStore?.Set("schema", value); }
        }
        /// <summary>Status of the job, which includes when the job was last run, current job state, and errors.</summary>
        public SynchronizationStatus Status {
            get { return BackingStore?.Get<SynchronizationStatus>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>Settings associated with the job. Some settings are inherited from the template.</summary>
        public List<KeyValuePair> SynchronizationJobSettings {
            get { return BackingStore?.Get<List<KeyValuePair>>("synchronizationJobSettings"); }
            set { BackingStore?.Set("synchronizationJobSettings", value); }
        }
        /// <summary>Identifier of the synchronization template this job is based on.</summary>
        public string TemplateId {
            get { return BackingStore?.Get<string>("templateId"); }
            set { BackingStore?.Set("templateId", value); }
        }
        /// <summary>
        /// Instantiates a new synchronizationJob and sets the default values.
        /// </summary>
        public SynchronizationJob() : base() {
            OdataType = "#microsoft.graph.synchronizationJob";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SynchronizationJob CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SynchronizationJob();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"schedule", n => { Schedule = n.GetObjectValue<SynchronizationSchedule>(SynchronizationSchedule.CreateFromDiscriminatorValue); } },
                {"schema", n => { Schema = n.GetObjectValue<SynchronizationSchema>(SynchronizationSchema.CreateFromDiscriminatorValue); } },
                {"status", n => { Status = n.GetObjectValue<SynchronizationStatus>(SynchronizationStatus.CreateFromDiscriminatorValue); } },
                {"synchronizationJobSettings", n => { SynchronizationJobSettings = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"templateId", n => { TemplateId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<SynchronizationSchedule>("schedule", Schedule);
            writer.WriteObjectValue<SynchronizationSchema>("schema", Schema);
            writer.WriteObjectValue<SynchronizationStatus>("status", Status);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("synchronizationJobSettings", SynchronizationJobSettings);
            writer.WriteStringValue("templateId", TemplateId);
        }
    }
}
