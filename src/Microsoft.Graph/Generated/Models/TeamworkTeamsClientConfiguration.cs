using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkTeamsClientConfiguration : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The configuration of the Microsoft Teams client user account for a device.</summary>
        public TeamworkAccountConfiguration AccountConfiguration {
            get { return BackingStore?.Get<TeamworkAccountConfiguration>("accountConfiguration"); }
            set { BackingStore?.Set("accountConfiguration", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The configuration of Microsoft Teams client features for a device.</summary>
        public TeamworkFeaturesConfiguration FeaturesConfiguration {
            get { return BackingStore?.Get<TeamworkFeaturesConfiguration>("featuresConfiguration"); }
            set { BackingStore?.Set("featuresConfiguration", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>
        /// Instantiates a new teamworkTeamsClientConfiguration and sets the default values.
        /// </summary>
        public TeamworkTeamsClientConfiguration() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TeamworkTeamsClientConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkTeamsClientConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"accountConfiguration", n => { AccountConfiguration = n.GetObjectValue<TeamworkAccountConfiguration>(TeamworkAccountConfiguration.CreateFromDiscriminatorValue); } },
                {"featuresConfiguration", n => { FeaturesConfiguration = n.GetObjectValue<TeamworkFeaturesConfiguration>(TeamworkFeaturesConfiguration.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<TeamworkAccountConfiguration>("accountConfiguration", AccountConfiguration);
            writer.WriteObjectValue<TeamworkFeaturesConfiguration>("featuresConfiguration", FeaturesConfiguration);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
