using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SynchronizationRule : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>true if the synchronization rule can be customized; false if this rule is read-only and should not be changed.</summary>
        public bool? Editable {
            get { return BackingStore?.Get<bool?>(nameof(Editable)); }
            set { BackingStore?.Set(nameof(Editable), value); }
        }
        /// <summary>Synchronization rule identifier. Must be one of the identifiers recognized by the synchronization engine. Supported rule identifiers can be found in the synchronization template returned by the API.</summary>
        public string Id {
            get { return BackingStore?.Get<string>(nameof(Id)); }
            set { BackingStore?.Set(nameof(Id), value); }
        }
        /// <summary>Additional extension properties. Unless instructed explicitly by the support team, metadata values should not be changed.</summary>
        public List<StringKeyStringValuePair> Metadata {
            get { return BackingStore?.Get<List<StringKeyStringValuePair>>(nameof(Metadata)); }
            set { BackingStore?.Set(nameof(Metadata), value); }
        }
        /// <summary>Human-readable name of the synchronization rule. Not nullable.</summary>
        public string Name {
            get { return BackingStore?.Get<string>(nameof(Name)); }
            set { BackingStore?.Set(nameof(Name), value); }
        }
        /// <summary>Collection of object mappings supported by the rule. Tells the synchronization engine which objects should be synchronized.</summary>
        public List<ObjectMapping> ObjectMappings {
            get { return BackingStore?.Get<List<ObjectMapping>>(nameof(ObjectMappings)); }
            set { BackingStore?.Set(nameof(ObjectMappings), value); }
        }
        /// <summary>Priority relative to other rules in the synchronizationSchema. Rules with the lowest priority number will be processed first.</summary>
        public int? Priority {
            get { return BackingStore?.Get<int?>(nameof(Priority)); }
            set { BackingStore?.Set(nameof(Priority), value); }
        }
        /// <summary>Name of the source directory. Must match one of the directory definitions in synchronizationSchema.</summary>
        public string SourceDirectoryName {
            get { return BackingStore?.Get<string>(nameof(SourceDirectoryName)); }
            set { BackingStore?.Set(nameof(SourceDirectoryName), value); }
        }
        /// <summary>Name of the target directory. Must match one of the directory definitions in synchronizationSchema.</summary>
        public string TargetDirectoryName {
            get { return BackingStore?.Get<string>(nameof(TargetDirectoryName)); }
            set { BackingStore?.Set(nameof(TargetDirectoryName), value); }
        }
        /// <summary>
        /// Instantiates a new synchronizationRule and sets the default values.
        /// </summary>
        public SynchronizationRule() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SynchronizationRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SynchronizationRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"editable", n => { Editable = n.GetBoolValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"metadata", n => { Metadata = n.GetCollectionOfObjectValues<StringKeyStringValuePair>(StringKeyStringValuePair.CreateFromDiscriminatorValue).ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"objectMappings", n => { ObjectMappings = n.GetCollectionOfObjectValues<ObjectMapping>(ObjectMapping.CreateFromDiscriminatorValue).ToList(); } },
                {"priority", n => { Priority = n.GetIntValue(); } },
                {"sourceDirectoryName", n => { SourceDirectoryName = n.GetStringValue(); } },
                {"targetDirectoryName", n => { TargetDirectoryName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("editable", Editable);
            writer.WriteStringValue("id", Id);
            writer.WriteCollectionOfObjectValues<StringKeyStringValuePair>("metadata", Metadata);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<ObjectMapping>("objectMappings", ObjectMappings);
            writer.WriteIntValue("priority", Priority);
            writer.WriteStringValue("sourceDirectoryName", SourceDirectoryName);
            writer.WriteStringValue("targetDirectoryName", TargetDirectoryName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
