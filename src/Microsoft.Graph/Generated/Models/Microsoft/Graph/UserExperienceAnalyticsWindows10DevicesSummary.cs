using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class UserExperienceAnalyticsWindows10DevicesSummary : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The count of Windows 10 devices that have unsupported OS versions.</summary>
        public int? UnsupportedOSversionDeviceCount { get; set; }
        /// <summary>
        /// Instantiates a new userExperienceAnalyticsWindows10DevicesSummary and sets the default values.
        /// </summary>
        public UserExperienceAnalyticsWindows10DevicesSummary() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"unsupportedOSversionDeviceCount", (o,n) => { (o as UserExperienceAnalyticsWindows10DevicesSummary).UnsupportedOSversionDeviceCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("unsupportedOSversionDeviceCount", UnsupportedOSversionDeviceCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
