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
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The assignmentMethod property</summary>
        public Microsoft.Graph.Beta.Models.Security.AssignmentMethod? AssignmentMethod {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.AssignmentMethod?>("assignmentMethod"); }
            set { BackingStore?.Set("assignmentMethod", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The downgradeJustification property</summary>
        public Microsoft.Graph.Beta.Models.Security.DowngradeJustification DowngradeJustification {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.DowngradeJustification>("downgradeJustification"); }
            set { BackingStore?.Set("downgradeJustification", value); }
        }
        /// <summary>The extendedProperties property</summary>
        public List<KeyValuePair> ExtendedProperties {
            get { return BackingStore?.Get<List<KeyValuePair>>("extendedProperties"); }
            set { BackingStore?.Set("extendedProperties", value); }
        }
        /// <summary>The labelId property</summary>
        public string LabelId {
            get { return BackingStore?.Get<string>("labelId"); }
            set { BackingStore?.Set("labelId", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>
        /// Instantiates a new labelingOptions and sets the default values.
        /// </summary>
        public LabelingOptions() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.security.labelingOptions";
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
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
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
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
