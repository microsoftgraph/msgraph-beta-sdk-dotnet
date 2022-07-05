using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to application.</summary>
    public class SynchronizationJob : Entity, IParsable {
        /// <summary>Schedule used to run the job. Read-only.</summary>
        public SynchronizationSchedule Schedule {
            get { return BackingStore?.Get<SynchronizationSchedule>(nameof(Schedule)); }
            set { BackingStore?.Set(nameof(Schedule), value); }
        }
        /// <summary>The synchronization schema configured for the job.</summary>
        public SynchronizationSchema Schema {
            get { return BackingStore?.Get<SynchronizationSchema>(nameof(Schema)); }
            set { BackingStore?.Set(nameof(Schema), value); }
        }
        /// <summary>Status of the job, which includes when the job was last run, current job state, and errors.</summary>
        public SynchronizationStatus Status {
            get { return BackingStore?.Get<SynchronizationStatus>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
        /// <summary>Settings associated with the job. Some settings are inherited from the template.</summary>
        public List<KeyValuePair> SynchronizationJobSettings {
            get { return BackingStore?.Get<List<KeyValuePair>>(nameof(SynchronizationJobSettings)); }
            set { BackingStore?.Set(nameof(SynchronizationJobSettings), value); }
        }
        /// <summary>Identifier of the synchronization template this job is based on.</summary>
        public string TemplateId {
            get { return BackingStore?.Get<string>(nameof(TemplateId)); }
            set { BackingStore?.Set(nameof(TemplateId), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
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
                {"synchronizationJobSettings", n => { SynchronizationJobSettings = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue).ToList(); } },
                {"templateId", n => { TemplateId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
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
