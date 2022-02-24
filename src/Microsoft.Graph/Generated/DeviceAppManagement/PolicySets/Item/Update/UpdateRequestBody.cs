using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.DeviceAppManagement.PolicySets.Item.Update {
    public class UpdateRequestBody : IParsable {
        public List<PolicySetItem> AddedPolicySetItems { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<PolicySetAssignment> Assignments { get; set; }
        public List<string> DeletedPolicySetItems { get; set; }
        public List<PolicySetItem> UpdatedPolicySetItems { get; set; }
        /// <summary>
        /// Instantiates a new updateRequestBody and sets the default values.
        /// </summary>
        public UpdateRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"addedPolicySetItems", (o,n) => { (o as UpdateRequestBody).AddedPolicySetItems = n.GetCollectionOfObjectValues<PolicySetItem>().ToList(); } },
                {"assignments", (o,n) => { (o as UpdateRequestBody).Assignments = n.GetCollectionOfObjectValues<PolicySetAssignment>().ToList(); } },
                {"deletedPolicySetItems", (o,n) => { (o as UpdateRequestBody).DeletedPolicySetItems = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"updatedPolicySetItems", (o,n) => { (o as UpdateRequestBody).UpdatedPolicySetItems = n.GetCollectionOfObjectValues<PolicySetItem>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<PolicySetItem>("addedPolicySetItems", AddedPolicySetItems);
            writer.WriteCollectionOfObjectValues<PolicySetAssignment>("assignments", Assignments);
            writer.WriteCollectionOfPrimitiveValues<string>("deletedPolicySetItems", DeletedPolicySetItems);
            writer.WriteCollectionOfObjectValues<PolicySetItem>("updatedPolicySetItems", UpdatedPolicySetItems);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
