using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.DeviceManagement.GroupPolicyConfigurations.Item.UpdateDefinitionValues {
    public class UpdateDefinitionValuesRequestBody : IParsable {
        public List<GroupPolicyDefinitionValue> Added { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<string> DeletedIds { get; set; }
        public List<GroupPolicyDefinitionValue> Updated { get; set; }
        /// <summary>
        /// Instantiates a new updateDefinitionValuesRequestBody and sets the default values.
        /// </summary>
        public UpdateDefinitionValuesRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"added", (o,n) => { (o as UpdateDefinitionValuesRequestBody).Added = n.GetCollectionOfObjectValues<GroupPolicyDefinitionValue>().ToList(); } },
                {"deletedIds", (o,n) => { (o as UpdateDefinitionValuesRequestBody).DeletedIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"updated", (o,n) => { (o as UpdateDefinitionValuesRequestBody).Updated = n.GetCollectionOfObjectValues<GroupPolicyDefinitionValue>().ToList(); } },
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
