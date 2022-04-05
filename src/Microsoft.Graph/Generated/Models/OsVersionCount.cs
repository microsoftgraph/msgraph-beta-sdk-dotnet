using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Count of devices with malware for each OS version</summary>
    public class OsVersionCount : IAdditionalDataHolder, IParsable {
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
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static OsVersionCount CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OsVersionCount();
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
