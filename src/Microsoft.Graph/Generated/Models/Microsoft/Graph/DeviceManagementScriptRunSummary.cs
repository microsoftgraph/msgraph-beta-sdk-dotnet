using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
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
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"errorDeviceCount", (o,n) => { (o as DeviceManagementScriptRunSummary).ErrorDeviceCount = n.GetIntValue(); } },
                {"errorUserCount", (o,n) => { (o as DeviceManagementScriptRunSummary).ErrorUserCount = n.GetIntValue(); } },
                {"successDeviceCount", (o,n) => { (o as DeviceManagementScriptRunSummary).SuccessDeviceCount = n.GetIntValue(); } },
                {"successUserCount", (o,n) => { (o as DeviceManagementScriptRunSummary).SuccessUserCount = n.GetIntValue(); } },
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
