using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class LabelingOptions : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>The assignmentMethod property</summary>
        public Microsoft.Graph.Beta.Models.Security.AssignmentMethod? AssignmentMethod {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.AssignmentMethod?>(nameof(AssignmentMethod)); }
            set { BackingStore?.Set(nameof(AssignmentMethod), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The downgradeJustification property</summary>
        public Microsoft.Graph.Beta.Models.Security.DowngradeJustification DowngradeJustification {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.DowngradeJustification>(nameof(DowngradeJustification)); }
            set { BackingStore?.Set(nameof(DowngradeJustification), value); }
        }
        /// <summary>The extendedProperties property</summary>
        public List<KeyValuePair> ExtendedProperties {
            get { return BackingStore?.Get<List<KeyValuePair>>(nameof(ExtendedProperties)); }
            set { BackingStore?.Set(nameof(ExtendedProperties), value); }
        }
        /// <summary>The labelId property</summary>
        public string LabelId {
            get { return BackingStore?.Get<string>(nameof(LabelId)); }
            set { BackingStore?.Set(nameof(LabelId), value); }
        }
        /// <summary>
        /// Instantiates a new labelingOptions and sets the default values.
        /// </summary>
        public LabelingOptions() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static LabelingOptions CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LabelingOptions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"assignmentMethod", n => { AssignmentMethod = n.GetEnumValue<AssignmentMethod>(); } },
                {"downgradeJustification", n => { DowngradeJustification = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.DowngradeJustification>(Microsoft.Graph.Beta.Models.Security.DowngradeJustification.CreateFromDiscriminatorValue); } },
                {"extendedProperties", n => { ExtendedProperties = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue).ToList(); } },
                {"labelId", n => { LabelId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AssignmentMethod>("assignmentMethod", AssignmentMethod);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.DowngradeJustification>("downgradeJustification", DowngradeJustification);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("extendedProperties", ExtendedProperties);
            writer.WriteStringValue("labelId", LabelId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
