using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.GroupPolicyConfigurations.Item.UpdateDefinitionValues {
    /// <summary>Provides operations to call the updateDefinitionValues method.</summary>
    public class UpdateDefinitionValuesRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>The added property</summary>
        public List<GroupPolicyDefinitionValue> Added { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The deletedIds property</summary>
        public List<string> DeletedIds { get; set; }
        /// <summary>The updated property</summary>
        public List<GroupPolicyDefinitionValue> Updated { get; set; }
        /// <summary>
        /// Instantiates a new updateDefinitionValuesRequestBody and sets the default values.
        /// </summary>
        public UpdateDefinitionValuesRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UpdateDefinitionValuesRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UpdateDefinitionValuesRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"added", n => { Added = n.GetCollectionOfObjectValues<GroupPolicyDefinitionValue>(GroupPolicyDefinitionValue.CreateFromDiscriminatorValue).ToList(); } },
                {"deletedIds", n => { DeletedIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"updated", n => { Updated = n.GetCollectionOfObjectValues<GroupPolicyDefinitionValue>(GroupPolicyDefinitionValue.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<GroupPolicyDefinitionValue>("added", Added);
            writer.WriteCollectionOfPrimitiveValues<string>("deletedIds", DeletedIds);
            writer.WriteCollectionOfObjectValues<GroupPolicyDefinitionValue>("updated", Updated);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
