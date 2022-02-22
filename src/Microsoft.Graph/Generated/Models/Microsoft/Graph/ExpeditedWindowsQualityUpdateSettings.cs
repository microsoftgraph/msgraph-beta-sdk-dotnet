using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class ExpeditedWindowsQualityUpdateSettings : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The number of days after installation that forced reboot will happen.</summary>
        public int? DaysUntilForcedReboot { get; set; }
        /// <summary>The release date to identify a quality update.</summary>
        public string QualityUpdateRelease { get; set; }
        /// <summary>
        /// Instantiates a new expeditedWindowsQualityUpdateSettings and sets the default values.
        /// </summary>
        public ExpeditedWindowsQualityUpdateSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"daysUntilForcedReboot", (o,n) => { (o as ExpeditedWindowsQualityUpdateSettings).DaysUntilForcedReboot = n.GetIntValue(); } },
                {"qualityUpdateRelease", (o,n) => { (o as ExpeditedWindowsQualityUpdateSettings).QualityUpdateRelease = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("daysUntilForcedReboot", DaysUntilForcedReboot);
            writer.WriteStringValue("qualityUpdateRelease", QualityUpdateRelease);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
