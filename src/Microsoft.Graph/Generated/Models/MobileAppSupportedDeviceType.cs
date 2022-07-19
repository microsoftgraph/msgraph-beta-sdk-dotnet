using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Device properties</summary>
    public class MobileAppSupportedDeviceType : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Maximum OS version</summary>
        public string MaximumOperatingSystemVersion {
            get { return BackingStore?.Get<string>("maximumOperatingSystemVersion"); }
            set { BackingStore?.Set("maximumOperatingSystemVersion", value); }
        }
        /// <summary>Minimum OS version</summary>
        public string MinimumOperatingSystemVersion {
            get { return BackingStore?.Get<string>("minimumOperatingSystemVersion"); }
            set { BackingStore?.Set("minimumOperatingSystemVersion", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Device type.</summary>
        public DeviceType? Type {
            get { return BackingStore?.Get<DeviceType?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
        /// <summary>
        /// Instantiates a new mobileAppSupportedDeviceType and sets the default values.
        /// </summary>
        public MobileAppSupportedDeviceType() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.mobileAppSupportedDeviceType";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MobileAppSupportedDeviceType CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MobileAppSupportedDeviceType();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"maximumOperatingSystemVersion", n => { MaximumOperatingSystemVersion = n.GetStringValue(); } },
                {"minimumOperatingSystemVersion", n => { MinimumOperatingSystemVersion = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"type", n => { Type = n.GetEnumValue<DeviceType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("maximumOperatingSystemVersion", MaximumOperatingSystemVersion);
            writer.WriteStringValue("minimumOperatingSystemVersion", MinimumOperatingSystemVersion);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<DeviceType>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
