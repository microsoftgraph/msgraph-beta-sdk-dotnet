using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The set of Role Definitions and Role Assignments assigned to a user.</summary>
    public class DeviceAndAppManagementAssignedRoleDetails : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Role Assignment IDs for the specifc Role Assignments assigned to a user. This property is read-only.</summary>
        public List<string> RoleAssignmentIds {
            get { return BackingStore?.Get<List<string>>(nameof(RoleAssignmentIds)); }
            set { BackingStore?.Set(nameof(RoleAssignmentIds), value); }
        }
        /// <summary>Role Definition IDs for the specifc Role Definitions assigned to a user. This property is read-only.</summary>
        public List<string> RoleDefinitionIds {
            get { return BackingStore?.Get<List<string>>(nameof(RoleDefinitionIds)); }
            set { BackingStore?.Set(nameof(RoleDefinitionIds), value); }
        }
        /// <summary>
        /// Instantiates a new DeviceAndAppManagementAssignedRoleDetails and sets the default values.
        /// </summary>
        public DeviceAndAppManagementAssignedRoleDetails() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceAndAppManagementAssignedRoleDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceAndAppManagementAssignedRoleDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"roleAssignmentIds", n => { RoleAssignmentIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"roleDefinitionIds", n => { RoleDefinitionIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("roleAssignmentIds", RoleAssignmentIds);
            writer.WriteCollectionOfPrimitiveValues<string>("roleDefinitionIds", RoleDefinitionIds);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
