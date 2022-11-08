using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.GroupPolicyConfigurations.Item.UpdateDefinitionValues {
    /// <summary>Provides operations to call the updateDefinitionValues method.</summary>
    public class UpdateDefinitionValuesPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The added property</summary>
        public List<GroupPolicyDefinitionValue> Added {
            get { return BackingStore?.Get<List<GroupPolicyDefinitionValue>>("added"); }
            set { BackingStore?.Set("added", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The deletedIds property</summary>
        public List<string> DeletedIds {
            get { return BackingStore?.Get<List<string>>("deletedIds"); }
            set { BackingStore?.Set("deletedIds", value); }
        }
        /// <summary>The updated property</summary>
        public List<GroupPolicyDefinitionValue> Updated {
            get { return BackingStore?.Get<List<GroupPolicyDefinitionValue>>("updated"); }
            set { BackingStore?.Set("updated", value); }
        }
        /// <summary>
        /// Instantiates a new updateDefinitionValuesPostRequestBody and sets the default values.
        /// </summary>
        public UpdateDefinitionValuesPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UpdateDefinitionValuesPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UpdateDefinitionValuesPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"added", n => { Added = n.GetCollectionOfObjectValues<GroupPolicyDefinitionValue>(GroupPolicyDefinitionValue.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deletedIds", n => { DeletedIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"updated", n => { Updated = n.GetCollectionOfObjectValues<GroupPolicyDefinitionValue>(GroupPolicyDefinitionValue.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<GroupPolicyDefinitionValue>("added", Added);
            writer.WriteCollectionOfPrimitiveValues<string>("deletedIds", DeletedIds);
            writer.WriteCollectionOfObjectValues<GroupPolicyDefinitionValue>("updated", Updated);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
