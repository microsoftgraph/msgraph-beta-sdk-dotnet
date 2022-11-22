using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkCameraConfiguration : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The cameras property</summary>
        public List<TeamworkPeripheral> Cameras {
            get { return BackingStore?.Get<List<TeamworkPeripheral>>("cameras"); }
            set { BackingStore?.Set("cameras", value); }
        }
        /// <summary>The configuration for the content camera.</summary>
        public TeamworkContentCameraConfiguration ContentCameraConfiguration {
            get { return BackingStore?.Get<TeamworkContentCameraConfiguration>("contentCameraConfiguration"); }
            set { BackingStore?.Set("contentCameraConfiguration", value); }
        }
        /// <summary>The defaultContentCamera property</summary>
        public TeamworkPeripheral DefaultContentCamera {
            get { return BackingStore?.Get<TeamworkPeripheral>("defaultContentCamera"); }
            set { BackingStore?.Set("defaultContentCamera", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>
        /// Instantiates a new teamworkCameraConfiguration and sets the default values.
        /// </summary>
        public TeamworkCameraConfiguration() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TeamworkCameraConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkCameraConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"cameras", n => { Cameras = n.GetCollectionOfObjectValues<TeamworkPeripheral>(TeamworkPeripheral.CreateFromDiscriminatorValue)?.ToList(); } },
                {"contentCameraConfiguration", n => { ContentCameraConfiguration = n.GetObjectValue<TeamworkContentCameraConfiguration>(TeamworkContentCameraConfiguration.CreateFromDiscriminatorValue); } },
                {"defaultContentCamera", n => { DefaultContentCamera = n.GetObjectValue<TeamworkPeripheral>(TeamworkPeripheral.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<TeamworkPeripheral>("cameras", Cameras);
            writer.WriteObjectValue<TeamworkContentCameraConfiguration>("contentCameraConfiguration", ContentCameraConfiguration);
            writer.WriteObjectValue<TeamworkPeripheral>("defaultContentCamera", DefaultContentCamera);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
