using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DeviceManagementConfigurationSettingOccurrence : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Maximum times setting can be set on device.</summary>
        public int? MaxDeviceOccurrence { get; set; }
        /// <summary>Minimum times setting can be set on device. A MinDeviceOccurrence of 0 means setting is optional</summary>
        public int? MinDeviceOccurrence { get; set; }
        /// <summary>
        /// Instantiates a new deviceManagementConfigurationSettingOccurrence and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationSettingOccurrence() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceManagementConfigurationSettingOccurrence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationSettingOccurrence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"maxDeviceOccurrence", (o,n) => { (o as DeviceManagementConfigurationSettingOccurrence).MaxDeviceOccurrence = n.GetIntValue(); } },
                {"minDeviceOccurrence", (o,n) => { (o as DeviceManagementConfigurationSettingOccurrence).MinDeviceOccurrence = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("maxDeviceOccurrence", MaxDeviceOccurrence);
            writer.WriteIntValue("minDeviceOccurrence", MinDeviceOccurrence);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
