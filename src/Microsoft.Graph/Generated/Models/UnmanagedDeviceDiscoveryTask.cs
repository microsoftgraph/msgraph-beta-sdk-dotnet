using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class UnmanagedDeviceDiscoveryTask : DeviceAppManagementTask, IParsable {
        /// <summary>Unmanaged devices discovered in the network.</summary>
        public List<UnmanagedDevice> UnmanagedDevices {
            get { return BackingStore?.Get<List<UnmanagedDevice>>("unmanagedDevices"); }
            set { BackingStore?.Set("unmanagedDevices", value); }
        }
        /// <summary>
        /// Instantiates a new UnmanagedDeviceDiscoveryTask and sets the default values.
        /// </summary>
        public UnmanagedDeviceDiscoveryTask() : base() {
            OdataType = "#microsoft.graph.unmanagedDeviceDiscoveryTask";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UnmanagedDeviceDiscoveryTask CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnmanagedDeviceDiscoveryTask();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"unmanagedDevices", n => { UnmanagedDevices = n.GetCollectionOfObjectValues<UnmanagedDevice>(UnmanagedDevice.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<UnmanagedDevice>("unmanagedDevices", UnmanagedDevices);
        }
    }
}
