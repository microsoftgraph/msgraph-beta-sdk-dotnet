using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Networkaccess {
    public class DeviceUsageSummary : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The number of distinct device IDs in the time frame between endDateTime and discoveryPivotDateTime.</summary>
        public int? ActiveDeviceCount {
            get { return BackingStore?.Get<int?>("activeDeviceCount"); }
            set { BackingStore?.Set("activeDeviceCount", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The number of distinct device IDs havn&apos;t seen in the time frame between endDateTime and discoveryPivotDateTime but have seen in the time frame between discoveryPivotDateTime and startDateTime.</summary>
        public int? InactiveDeviceCount {
            get { return BackingStore?.Get<int?>("inactiveDeviceCount"); }
            set { BackingStore?.Set("inactiveDeviceCount", value); }
        }
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
        /// <summary>The number of distinct device IDs in the time frame between startDateTime and endDateTime.</summary>
        public int? TotalDeviceCount {
            get { return BackingStore?.Get<int?>("totalDeviceCount"); }
            set { BackingStore?.Set("totalDeviceCount", value); }
        }
        /// <summary>
        /// Instantiates a new deviceUsageSummary and sets the default values.
        /// </summary>
        public DeviceUsageSummary() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DeviceUsageSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceUsageSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"activeDeviceCount", n => { ActiveDeviceCount = n.GetIntValue(); } },
                {"inactiveDeviceCount", n => { InactiveDeviceCount = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"totalDeviceCount", n => { TotalDeviceCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("activeDeviceCount", ActiveDeviceCount);
            writer.WriteIntValue("inactiveDeviceCount", InactiveDeviceCount);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("totalDeviceCount", TotalDeviceCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
