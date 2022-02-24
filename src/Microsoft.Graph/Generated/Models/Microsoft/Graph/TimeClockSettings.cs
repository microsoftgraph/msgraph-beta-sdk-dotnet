using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class TimeClockSettings : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The aprroved location of the timeClock.</summary>
        public GeoCoordinates ApprovedLocation { get; set; }
        /// <summary>
        /// Instantiates a new timeClockSettings and sets the default values.
        /// </summary>
        public TimeClockSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"approvedLocation", (o,n) => { (o as TimeClockSettings).ApprovedLocation = n.GetObjectValue<GeoCoordinates>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<GeoCoordinates>("approvedLocation", ApprovedLocation);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
