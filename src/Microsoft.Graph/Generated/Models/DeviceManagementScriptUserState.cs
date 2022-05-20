using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Contains properties for user run state of the device management script.</summary>
    public class DeviceManagementScriptUserState : Entity, IParsable {
        /// <summary>List of run states for this script across all devices of specific user.</summary>
        public List<DeviceManagementScriptDeviceState> DeviceRunStates {
            get { return BackingStore?.Get<List<DeviceManagementScriptDeviceState>>(nameof(DeviceRunStates)); }
            set { BackingStore?.Set(nameof(DeviceRunStates), value); }
        }
        /// <summary>Error device count for specific user.</summary>
        public int? ErrorDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(ErrorDeviceCount)); }
            set { BackingStore?.Set(nameof(ErrorDeviceCount), value); }
        }
        /// <summary>Success device count for specific user.</summary>
        public int? SuccessDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(SuccessDeviceCount)); }
            set { BackingStore?.Set(nameof(SuccessDeviceCount), value); }
        }
        /// <summary>User principle name of specific user.</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>(nameof(UserPrincipalName)); }
            set { BackingStore?.Set(nameof(UserPrincipalName), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementScriptUserState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementScriptUserState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deviceRunStates", n => { DeviceRunStates = n.GetCollectionOfObjectValues<DeviceManagementScriptDeviceState>(DeviceManagementScriptDeviceState.CreateFromDiscriminatorValue).ToList(); } },
                {"errorDeviceCount", n => { ErrorDeviceCount = n.GetIntValue(); } },
                {"successDeviceCount", n => { SuccessDeviceCount = n.GetIntValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DeviceManagementScriptDeviceState>("deviceRunStates", DeviceRunStates);
            writer.WriteIntValue("errorDeviceCount", ErrorDeviceCount);
            writer.WriteIntValue("successDeviceCount", SuccessDeviceCount);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
