using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the teamwork singleton.</summary>
    public class TeamworkDisplayConfiguration : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The list of configured displays. Applicable only for Microsoft Teams Rooms devices.</summary>
        public List<TeamworkConfiguredPeripheral> ConfiguredDisplays { get; set; }
        /// <summary>Total number of connected displays, including the inbuilt display. Applicable only for Teams Rooms devices.</summary>
        public int? DisplayCount { get; set; }
        /// <summary>Configuration for the inbuilt display. Not applicable for Teams Rooms devices.</summary>
        public TeamworkDisplayScreenConfiguration InBuiltDisplayScreenConfiguration { get; set; }
        /// <summary>True if content duplication is allowed. Applicable only for Teams Rooms devices.</summary>
        public bool? IsContentDuplicationAllowed { get; set; }
        /// <summary>True if dual display mode is enabled. If isDualDisplayModeEnabled is true, then the content will be displayed on both front of room screens instead of just the one screen, when it is shared via the HDMI ingest module on the Microsoft Teams Rooms device. Applicable only for Teams Rooms devices.</summary>
        public bool? IsDualDisplayModeEnabled { get; set; }
        /// <summary>
        /// Instantiates a new teamworkDisplayConfiguration and sets the default values.
        /// </summary>
        public TeamworkDisplayConfiguration() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TeamworkDisplayConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkDisplayConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"configuredDisplays", (o,n) => { (o as TeamworkDisplayConfiguration).ConfiguredDisplays = n.GetCollectionOfObjectValues<TeamworkConfiguredPeripheral>(TeamworkConfiguredPeripheral.CreateFromDiscriminatorValue).ToList(); } },
                {"displayCount", (o,n) => { (o as TeamworkDisplayConfiguration).DisplayCount = n.GetIntValue(); } },
                {"inBuiltDisplayScreenConfiguration", (o,n) => { (o as TeamworkDisplayConfiguration).InBuiltDisplayScreenConfiguration = n.GetObjectValue<TeamworkDisplayScreenConfiguration>(TeamworkDisplayScreenConfiguration.CreateFromDiscriminatorValue); } },
                {"isContentDuplicationAllowed", (o,n) => { (o as TeamworkDisplayConfiguration).IsContentDuplicationAllowed = n.GetBoolValue(); } },
                {"isDualDisplayModeEnabled", (o,n) => { (o as TeamworkDisplayConfiguration).IsDualDisplayModeEnabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<TeamworkConfiguredPeripheral>("configuredDisplays", ConfiguredDisplays);
            writer.WriteIntValue("displayCount", DisplayCount);
            writer.WriteObjectValue<TeamworkDisplayScreenConfiguration>("inBuiltDisplayScreenConfiguration", InBuiltDisplayScreenConfiguration);
            writer.WriteBoolValue("isContentDuplicationAllowed", IsContentDuplicationAllowed);
            writer.WriteBoolValue("isDualDisplayModeEnabled", IsDualDisplayModeEnabled);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
