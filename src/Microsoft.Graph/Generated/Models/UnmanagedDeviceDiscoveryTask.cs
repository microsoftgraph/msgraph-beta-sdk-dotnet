using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// This task derived type represents a list of unmanaged devices discovered in the network.
    /// </summary>
    public class UnmanagedDeviceDiscoveryTask : DeviceAppManagementTask, IParsable {
        /// <summary>Unmanaged devices discovered in the network.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UnmanagedDevice>? UnmanagedDevices {
            get { return BackingStore?.Get<List<UnmanagedDevice>?>("unmanagedDevices"); }
            set { BackingStore?.Set("unmanagedDevices", value); }
        }
#nullable restore
#else
        public List<UnmanagedDevice> UnmanagedDevices {
            get { return BackingStore?.Get<List<UnmanagedDevice>>("unmanagedDevices"); }
            set { BackingStore?.Set("unmanagedDevices", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new unmanagedDeviceDiscoveryTask and sets the default values.
        /// </summary>
        public UnmanagedDeviceDiscoveryTask() : base() {
            OdataType = "#microsoft.graph.unmanagedDeviceDiscoveryTask";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<UnmanagedDevice>("unmanagedDevices", UnmanagedDevices);
        }
    }
}
