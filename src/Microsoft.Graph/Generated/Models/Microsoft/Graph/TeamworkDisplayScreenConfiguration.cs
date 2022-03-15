using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the teamwork singleton.</summary>
    public class TeamworkDisplayScreenConfiguration : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The brightness level on the device (0-100). Not applicable for Microsoft Teams Rooms devices.</summary>
        public int? BacklightBrightness { get; set; }
        /// <summary>Timeout for backlight (30-3600 secs). Not applicable for Teams Rooms devices.</summary>
        public TimeSpan? BacklightTimeout { get; set; }
        /// <summary>True if high contrast mode is enabled. Not applicable for Teams Rooms devices.</summary>
        public bool? IsHighContrastEnabled { get; set; }
        /// <summary>True if screensaver is enabled. Not applicable for Teams Rooms devices.</summary>
        public bool? IsScreensaverEnabled { get; set; }
        /// <summary>Screensaver timeout from 30 to 3600 secs. Not applicable for Teams Rooms devices.</summary>
        public TimeSpan? ScreensaverTimeout { get; set; }
        /// <summary>
        /// Instantiates a new teamworkDisplayScreenConfiguration and sets the default values.
        /// </summary>
        public TeamworkDisplayScreenConfiguration() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TeamworkDisplayScreenConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkDisplayScreenConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"backlightBrightness", (o,n) => { (o as TeamworkDisplayScreenConfiguration).BacklightBrightness = n.GetIntValue(); } },
                {"backlightTimeout", (o,n) => { (o as TeamworkDisplayScreenConfiguration).BacklightTimeout = n.GetTimeSpanValue(); } },
                {"isHighContrastEnabled", (o,n) => { (o as TeamworkDisplayScreenConfiguration).IsHighContrastEnabled = n.GetBoolValue(); } },
                {"isScreensaverEnabled", (o,n) => { (o as TeamworkDisplayScreenConfiguration).IsScreensaverEnabled = n.GetBoolValue(); } },
                {"screensaverTimeout", (o,n) => { (o as TeamworkDisplayScreenConfiguration).ScreensaverTimeout = n.GetTimeSpanValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("backlightBrightness", BacklightBrightness);
            writer.WriteTimeSpanValue("backlightTimeout", BacklightTimeout);
            writer.WriteBoolValue("isHighContrastEnabled", IsHighContrastEnabled);
            writer.WriteBoolValue("isScreensaverEnabled", IsScreensaverEnabled);
            writer.WriteTimeSpanValue("screensaverTimeout", ScreensaverTimeout);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
