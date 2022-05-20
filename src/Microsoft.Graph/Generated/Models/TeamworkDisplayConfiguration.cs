using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkDisplayConfiguration : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The list of configured displays. Applicable only for Microsoft Teams Rooms devices.</summary>
        public List<TeamworkConfiguredPeripheral> ConfiguredDisplays {
            get { return BackingStore?.Get<List<TeamworkConfiguredPeripheral>>(nameof(ConfiguredDisplays)); }
            set { BackingStore?.Set(nameof(ConfiguredDisplays), value); }
        }
        /// <summary>Total number of connected displays, including the inbuilt display. Applicable only for Teams Rooms devices.</summary>
        public int? DisplayCount {
            get { return BackingStore?.Get<int?>(nameof(DisplayCount)); }
            set { BackingStore?.Set(nameof(DisplayCount), value); }
        }
        /// <summary>Configuration for the inbuilt display. Not applicable for Teams Rooms devices.</summary>
        public TeamworkDisplayScreenConfiguration InBuiltDisplayScreenConfiguration {
            get { return BackingStore?.Get<TeamworkDisplayScreenConfiguration>(nameof(InBuiltDisplayScreenConfiguration)); }
            set { BackingStore?.Set(nameof(InBuiltDisplayScreenConfiguration), value); }
        }
        /// <summary>True if content duplication is allowed. Applicable only for Teams Rooms devices.</summary>
        public bool? IsContentDuplicationAllowed {
            get { return BackingStore?.Get<bool?>(nameof(IsContentDuplicationAllowed)); }
            set { BackingStore?.Set(nameof(IsContentDuplicationAllowed), value); }
        }
        /// <summary>True if dual display mode is enabled. If isDualDisplayModeEnabled is true, then the content will be displayed on both front of room screens instead of just the one screen, when it is shared via the HDMI ingest module on the Microsoft Teams Rooms device. Applicable only for Teams Rooms devices.</summary>
        public bool? IsDualDisplayModeEnabled {
            get { return BackingStore?.Get<bool?>(nameof(IsDualDisplayModeEnabled)); }
            set { BackingStore?.Set(nameof(IsDualDisplayModeEnabled), value); }
        }
        /// <summary>
        /// Instantiates a new teamworkDisplayConfiguration and sets the default values.
        /// </summary>
        public TeamworkDisplayConfiguration() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
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
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"configuredDisplays", n => { ConfiguredDisplays = n.GetCollectionOfObjectValues<TeamworkConfiguredPeripheral>(TeamworkConfiguredPeripheral.CreateFromDiscriminatorValue).ToList(); } },
                {"displayCount", n => { DisplayCount = n.GetIntValue(); } },
                {"inBuiltDisplayScreenConfiguration", n => { InBuiltDisplayScreenConfiguration = n.GetObjectValue<TeamworkDisplayScreenConfiguration>(TeamworkDisplayScreenConfiguration.CreateFromDiscriminatorValue); } },
                {"isContentDuplicationAllowed", n => { IsContentDuplicationAllowed = n.GetBoolValue(); } },
                {"isDualDisplayModeEnabled", n => { IsDualDisplayModeEnabled = n.GetBoolValue(); } },
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
