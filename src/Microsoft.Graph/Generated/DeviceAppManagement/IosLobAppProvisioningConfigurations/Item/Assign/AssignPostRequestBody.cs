using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceAppManagement.IosLobAppProvisioningConfigurations.Item.Assign {
    public class AssignPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The appProvisioningConfigurationGroupAssignments property</summary>
        public List<MobileAppProvisioningConfigGroupAssignment> AppProvisioningConfigurationGroupAssignments {
            get { return BackingStore?.Get<List<MobileAppProvisioningConfigGroupAssignment>>("appProvisioningConfigurationGroupAssignments"); }
            set { BackingStore?.Set("appProvisioningConfigurationGroupAssignments", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The iOSLobAppProvisioningConfigAssignments property</summary>
        public List<IosLobAppProvisioningConfigurationAssignment> IOSLobAppProvisioningConfigAssignments {
            get { return BackingStore?.Get<List<IosLobAppProvisioningConfigurationAssignment>>("iOSLobAppProvisioningConfigAssignments"); }
            set { BackingStore?.Set("iOSLobAppProvisioningConfigAssignments", value); }
        }
        /// <summary>
        /// Instantiates a new assignPostRequestBody and sets the default values.
        /// </summary>
        public AssignPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AssignPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AssignPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"appProvisioningConfigurationGroupAssignments", n => { AppProvisioningConfigurationGroupAssignments = n.GetCollectionOfObjectValues<MobileAppProvisioningConfigGroupAssignment>(MobileAppProvisioningConfigGroupAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"iOSLobAppProvisioningConfigAssignments", n => { IOSLobAppProvisioningConfigAssignments = n.GetCollectionOfObjectValues<IosLobAppProvisioningConfigurationAssignment>(IosLobAppProvisioningConfigurationAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<MobileAppProvisioningConfigGroupAssignment>("appProvisioningConfigurationGroupAssignments", AppProvisioningConfigurationGroupAssignments);
            writer.WriteCollectionOfObjectValues<IosLobAppProvisioningConfigurationAssignment>("iOSLobAppProvisioningConfigAssignments", IOSLobAppProvisioningConfigAssignments);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
