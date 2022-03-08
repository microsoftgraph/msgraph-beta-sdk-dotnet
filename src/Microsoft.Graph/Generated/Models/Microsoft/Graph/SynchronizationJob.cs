using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the collection of application entities.</summary>
    public class SynchronizationJob : Entity, IParsable {
        /// <summary>Schedule used to run the job. Read-only.</summary>
        public SynchronizationSchedule Schedule { get; set; }
        /// <summary>The synchronization schema configured for the job.</summary>
        public SynchronizationSchema Schema { get; set; }
        /// <summary>Status of the job, which includes when the job was last run, current job state, and errors.</summary>
        public SynchronizationStatus Status { get; set; }
        /// <summary>Settings associated with the job. Some settings are inherited from the template.</summary>
        public List<KeyValuePair> SynchronizationJobSettings { get; set; }
        /// <summary>Identifier of the synchronization template this job is based on.</summary>
        public string TemplateId { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"schedule", (o,n) => { (o as SynchronizationJob).Schedule = n.GetObjectValue<SynchronizationSchedule>(SynchronizationSchedule.CreateFromDiscriminatorValue); } },
                {"schema", (o,n) => { (o as SynchronizationJob).Schema = n.GetObjectValue<SynchronizationSchema>(SynchronizationSchema.CreateFromDiscriminatorValue); } },
                {"status", (o,n) => { (o as SynchronizationJob).Status = n.GetObjectValue<SynchronizationStatus>(SynchronizationStatus.CreateFromDiscriminatorValue); } },
                {"synchronizationJobSettings", (o,n) => { (o as SynchronizationJob).SynchronizationJobSettings = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue).ToList(); } },
                {"templateId", (o,n) => { (o as SynchronizationJob).TemplateId = n.GetStringValue(); } },
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
