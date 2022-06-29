using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class EducationSynchronizationCustomization : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Indicates whether the display name of the resource can be overwritten by the sync.</summary>
        public bool? AllowDisplayNameUpdate {
            get { return BackingStore?.Get<bool?>(nameof(AllowDisplayNameUpdate)); }
            set { BackingStore?.Set(nameof(AllowDisplayNameUpdate), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Indicates whether synchronization of the parent entity is deferred to a later date.</summary>
        public bool? IsSyncDeferred {
            get { return BackingStore?.Get<bool?>(nameof(IsSyncDeferred)); }
            set { BackingStore?.Set(nameof(IsSyncDeferred), value); }
        }
        /// <summary>The collection of property names to sync. If set to null, all properties will be synchronized. Does not apply to Student Enrollments or Teacher Rosters</summary>
        public List<string> OptionalPropertiesToSync {
            get { return BackingStore?.Get<List<string>>(nameof(OptionalPropertiesToSync)); }
            set { BackingStore?.Set(nameof(OptionalPropertiesToSync), value); }
        }
        /// <summary>The date that the synchronization should start. This value should be set to a future date. If set to null, the resource will be synchronized when the profile setup completes. Only applies to Student Enrollments</summary>
        public DateTimeOffset? SynchronizationStartDate {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(SynchronizationStartDate)); }
            set { BackingStore?.Set(nameof(SynchronizationStartDate), value); }
        }
        /// <summary>
        /// Instantiates a new educationSynchronizationCustomization and sets the default values.
        /// </summary>
        public EducationSynchronizationCustomization() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static EducationSynchronizationCustomization CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationSynchronizationCustomization();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowDisplayNameUpdate", n => { AllowDisplayNameUpdate = n.GetBoolValue(); } },
                {"isSyncDeferred", n => { IsSyncDeferred = n.GetBoolValue(); } },
                {"optionalPropertiesToSync", n => { OptionalPropertiesToSync = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"synchronizationStartDate", n => { SynchronizationStartDate = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowDisplayNameUpdate", AllowDisplayNameUpdate);
            writer.WriteBoolValue("isSyncDeferred", IsSyncDeferred);
            writer.WriteCollectionOfPrimitiveValues<string>("optionalPropertiesToSync", OptionalPropertiesToSync);
            writer.WriteDateTimeOffsetValue("synchronizationStartDate", SynchronizationStartDate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
