using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkSoftwareUpdateStatus : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>The available software version to update.</summary>
        public string AvailableVersion {
            get { return BackingStore?.Get<string>(nameof(AvailableVersion)); }
            set { BackingStore?.Set(nameof(AvailableVersion), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The current software version.</summary>
        public string CurrentVersion {
            get { return BackingStore?.Get<string>(nameof(CurrentVersion)); }
            set { BackingStore?.Set(nameof(CurrentVersion), value); }
        }
        /// <summary>The update status of the software. The possible values are: unknown, latest, updateAvailable, unknownFutureValue.</summary>
        public TeamworkSoftwareFreshness? SoftwareFreshness {
            get { return BackingStore?.Get<TeamworkSoftwareFreshness?>(nameof(SoftwareFreshness)); }
            set { BackingStore?.Set(nameof(SoftwareFreshness), value); }
        }
        /// <summary>
        /// Instantiates a new teamworkSoftwareUpdateStatus and sets the default values.
        /// </summary>
        public TeamworkSoftwareUpdateStatus() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TeamworkSoftwareUpdateStatus CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkSoftwareUpdateStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"availableVersion", n => { AvailableVersion = n.GetStringValue(); } },
                {"currentVersion", n => { CurrentVersion = n.GetStringValue(); } },
                {"softwareFreshness", n => { SoftwareFreshness = n.GetEnumValue<TeamworkSoftwareFreshness>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("availableVersion", AvailableVersion);
            writer.WriteStringValue("currentVersion", CurrentVersion);
            writer.WriteEnumValue<TeamworkSoftwareFreshness>("softwareFreshness", SoftwareFreshness);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
