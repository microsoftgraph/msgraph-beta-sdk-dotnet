using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Represents a user rights setting.
    /// </summary>
    public class DeviceManagementUserRightsSetting : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Representing a collection of local users or groups which will be set on device if the state of this setting is Allowed. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementUserRightsLocalUserOrGroup>? LocalUsersOrGroups {
            get { return BackingStore?.Get<List<DeviceManagementUserRightsLocalUserOrGroup>?>("localUsersOrGroups"); }
            set { BackingStore?.Set("localUsersOrGroups", value); }
        }
#nullable restore
#else
        public List<DeviceManagementUserRightsLocalUserOrGroup> LocalUsersOrGroups {
            get { return BackingStore?.Get<List<DeviceManagementUserRightsLocalUserOrGroup>>("localUsersOrGroups"); }
            set { BackingStore?.Set("localUsersOrGroups", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>State Management Setting.</summary>
        public StateManagementSetting? State {
            get { return BackingStore?.Get<StateManagementSetting?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>
        /// Instantiates a new deviceManagementUserRightsSetting and sets the default values.
        /// </summary>
        public DeviceManagementUserRightsSetting() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DeviceManagementUserRightsSetting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementUserRightsSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"localUsersOrGroups", n => { LocalUsersOrGroups = n.GetCollectionOfObjectValues<DeviceManagementUserRightsLocalUserOrGroup>(DeviceManagementUserRightsLocalUserOrGroup.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"state", n => { State = n.GetEnumValue<StateManagementSetting>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<DeviceManagementUserRightsLocalUserOrGroup>("localUsersOrGroups", LocalUsersOrGroups);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<StateManagementSetting>("state", State);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
