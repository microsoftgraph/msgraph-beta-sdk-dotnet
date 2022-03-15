using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class MobileAppSupportedDeviceType : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Maximum OS version</summary>
        public string MaximumOperatingSystemVersion { get; set; }
        /// <summary>Minimum OS version</summary>
        public string MinimumOperatingSystemVersion { get; set; }
        /// <summary>Device type. Possible values are: desktop, windowsRT, winMO6, nokia, windowsPhone, mac, winCE, winEmbedded, iPhone, iPad, iPod, android, iSocConsumer, unix, macMDM, holoLens, surfaceHub, androidForWork, androidEnterprise, windows10x, androidnGMS, chromeOS, linux, blackberry, palm, unknown, cloudPC.</summary>
        public DeviceType? Type { get; set; }
        /// <summary>
        /// Instantiates a new mobileAppSupportedDeviceType and sets the default values.
        /// </summary>
        public MobileAppSupportedDeviceType() {
            AdditionalData = new Dictionary<string, object>();
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
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"maximumOperatingSystemVersion", (o,n) => { (o as MobileAppSupportedDeviceType).MaximumOperatingSystemVersion = n.GetStringValue(); } },
                {"minimumOperatingSystemVersion", (o,n) => { (o as MobileAppSupportedDeviceType).MinimumOperatingSystemVersion = n.GetStringValue(); } },
                {"type", (o,n) => { (o as MobileAppSupportedDeviceType).Type = n.GetEnumValue<DeviceType>(); } },
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
            writer.WriteEnumValue<DeviceType>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
