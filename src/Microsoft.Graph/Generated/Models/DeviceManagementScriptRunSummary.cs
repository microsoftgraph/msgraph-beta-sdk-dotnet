using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementScriptRunSummary : Entity, IParsable {
        /// <summary>Error device count.</summary>
        public int? ErrorDeviceCount { get; set; }
        /// <summary>Error user count.</summary>
        public int? ErrorUserCount { get; set; }
        /// <summary>Success device count.</summary>
        public int? SuccessDeviceCount { get; set; }
        /// <summary>Success user count.</summary>
        public int? SuccessUserCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementScriptRunSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementScriptRunSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"errorDeviceCount", n => { ErrorDeviceCount = n.GetIntValue(); } },
                {"errorUserCount", n => { ErrorUserCount = n.GetIntValue(); } },
                {"successDeviceCount", n => { SuccessDeviceCount = n.GetIntValue(); } },
                {"successUserCount", n => { SuccessUserCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("errorDeviceCount", ErrorDeviceCount);
            writer.WriteIntValue("errorUserCount", ErrorUserCount);
            writer.WriteIntValue("successDeviceCount", SuccessDeviceCount);
            writer.WriteIntValue("successUserCount", SuccessUserCount);
        }
    }
}
