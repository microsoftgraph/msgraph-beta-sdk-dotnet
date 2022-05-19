using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceAppManagement.PolicySets.Item.Update {
    /// <summary>Provides operations to call the update method.</summary>
    public class UpdatePostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The addedPolicySetItems property</summary>
        public List<PolicySetItem> AddedPolicySetItems {
            get { return BackingStore?.Get<List<PolicySetItem>>(nameof(AddedPolicySetItems)); }
            set { BackingStore?.Set(nameof(AddedPolicySetItems), value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>The assignments property</summary>
        public List<PolicySetAssignment> Assignments {
            get { return BackingStore?.Get<List<PolicySetAssignment>>(nameof(Assignments)); }
            set { BackingStore?.Set(nameof(Assignments), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The deletedPolicySetItems property</summary>
        public List<string> DeletedPolicySetItems {
            get { return BackingStore?.Get<List<string>>(nameof(DeletedPolicySetItems)); }
            set { BackingStore?.Set(nameof(DeletedPolicySetItems), value); }
        }
        /// <summary>The updatedPolicySetItems property</summary>
        public List<PolicySetItem> UpdatedPolicySetItems {
            get { return BackingStore?.Get<List<PolicySetItem>>(nameof(UpdatedPolicySetItems)); }
            set { BackingStore?.Set(nameof(UpdatedPolicySetItems), value); }
        }
        /// <summary>
        /// Instantiates a new updatePostRequestBody and sets the default values.
        /// </summary>
        public UpdatePostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UpdatePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UpdatePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"addedPolicySetItems", n => { AddedPolicySetItems = n.GetCollectionOfObjectValues<PolicySetItem>(PolicySetItem.CreateFromDiscriminatorValue).ToList(); } },
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<PolicySetAssignment>(PolicySetAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"deletedPolicySetItems", n => { DeletedPolicySetItems = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"updatedPolicySetItems", n => { UpdatedPolicySetItems = n.GetCollectionOfObjectValues<PolicySetItem>(PolicySetItem.CreateFromDiscriminatorValue).ToList(); } },
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
