using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class OsVersionCount : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Count of devices with malware for the OS version</summary>
        public int? DeviceCount { get; set; }
        /// <summary>The Timestamp of the last update for the device count in UTC</summary>
        public DateTimeOffset? LastUpdateDateTime { get; set; }
        /// <summary>OS version</summary>
        public string OsVersion { get; set; }
        /// <summary>
        /// Instantiates a new osVersionCount and sets the default values.
        /// </summary>
        public OsVersionCount() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"deviceCount", (o,n) => { (o as OsVersionCount).DeviceCount = n.GetIntValue(); } },
                {"lastUpdateDateTime", (o,n) => { (o as OsVersionCount).LastUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                {"osVersion", (o,n) => { (o as OsVersionCount).OsVersion = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("deviceCount", DeviceCount);
            writer.WriteDateTimeOffsetValue("lastUpdateDateTime", LastUpdateDateTime);
            writer.WriteStringValue("osVersion", OsVersion);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
