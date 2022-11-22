using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Base type for assignment targets.</summary>
    public class DeviceAndAppManagementAssignmentTarget : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The Id of the filter for the target assignment.</summary>
        public string DeviceAndAppManagementAssignmentFilterId {
            get { return BackingStore?.Get<string>("deviceAndAppManagementAssignmentFilterId"); }
            set { BackingStore?.Set("deviceAndAppManagementAssignmentFilterId", value); }
        }
        /// <summary>Represents type of the assignment filter.</summary>
        public Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentFilterType? DeviceAndAppManagementAssignmentFilterType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentFilterType?>("deviceAndAppManagementAssignmentFilterType"); }
            set { BackingStore?.Set("deviceAndAppManagementAssignmentFilterType", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>
        /// Instantiates a new deviceAndAppManagementAssignmentTarget and sets the default values.
        /// </summary>
        public DeviceAndAppManagementAssignmentTarget() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DeviceAndAppManagementAssignmentTarget CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.allDevicesAssignmentTarget" => new AllDevicesAssignmentTarget(),
                "#microsoft.graph.allLicensedUsersAssignmentTarget" => new AllLicensedUsersAssignmentTarget(),
                "#microsoft.graph.configurationManagerCollectionAssignmentTarget" => new ConfigurationManagerCollectionAssignmentTarget(),
                "#microsoft.graph.exclusionGroupAssignmentTarget" => new ExclusionGroupAssignmentTarget(),
                "#microsoft.graph.groupAssignmentTarget" => new GroupAssignmentTarget(),
                _ => new DeviceAndAppManagementAssignmentTarget(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"deviceAndAppManagementAssignmentFilterId", n => { DeviceAndAppManagementAssignmentFilterId = n.GetStringValue(); } },
                {"deviceAndAppManagementAssignmentFilterType", n => { DeviceAndAppManagementAssignmentFilterType = n.GetEnumValue<DeviceAndAppManagementAssignmentFilterType>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("deviceAndAppManagementAssignmentFilterId", DeviceAndAppManagementAssignmentFilterId);
            writer.WriteEnumValue<DeviceAndAppManagementAssignmentFilterType>("deviceAndAppManagementAssignmentFilterType", DeviceAndAppManagementAssignmentFilterType);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
