using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class UserTrainingContentEventInfo : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Browser of the user from where the training event was generated.</summary>
        public string Browser { get; set; }
        /// <summary>Date and time of the training content playback by the user.</summary>
        public DateTimeOffset? ContentDateTime { get; set; }
        /// <summary>IP address of the user for the training event.</summary>
        public string IpAddress { get; set; }
        /// <summary>The operating system, platform, and device details of the user for the training event.</summary>
        public string OsPlatformDeviceDetails { get; set; }
        /// <summary>Potential improvement in security posture of the tenant after completion of the training by the user.</summary>
        public double? PotentialScoreImpact { get; set; }
        /// <summary>
        /// Instantiates a new userTrainingContentEventInfo and sets the default values.
        /// </summary>
        public UserTrainingContentEventInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"browser", (o,n) => { (o as UserTrainingContentEventInfo).Browser = n.GetStringValue(); } },
                {"contentDateTime", (o,n) => { (o as UserTrainingContentEventInfo).ContentDateTime = n.GetDateTimeOffsetValue(); } },
                {"ipAddress", (o,n) => { (o as UserTrainingContentEventInfo).IpAddress = n.GetStringValue(); } },
                {"osPlatformDeviceDetails", (o,n) => { (o as UserTrainingContentEventInfo).OsPlatformDeviceDetails = n.GetStringValue(); } },
                {"potentialScoreImpact", (o,n) => { (o as UserTrainingContentEventInfo).PotentialScoreImpact = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("browser", Browser);
            writer.WriteDateTimeOffsetValue("contentDateTime", ContentDateTime);
            writer.WriteStringValue("ipAddress", IpAddress);
            writer.WriteStringValue("osPlatformDeviceDetails", OsPlatformDeviceDetails);
            writer.WriteDoubleValue("potentialScoreImpact", PotentialScoreImpact);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
