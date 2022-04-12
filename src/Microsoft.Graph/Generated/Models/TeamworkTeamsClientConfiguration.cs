using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkTeamsClientConfiguration : IAdditionalDataHolder, IParsable {
        /// <summary>The configuration of the Microsoft Teams client user account for a device.</summary>
        public TeamworkAccountConfiguration AccountConfiguration { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The configuration of Microsoft Teams client features for a device.</summary>
        public TeamworkFeaturesConfiguration FeaturesConfiguration { get; set; }
        /// <summary>
        /// Instantiates a new teamworkTeamsClientConfiguration and sets the default values.
        /// </summary>
        public TeamworkTeamsClientConfiguration() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
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
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<TeamworkAccountConfiguration>("accountConfiguration", AccountConfiguration);
            writer.WriteObjectValue<TeamworkFeaturesConfiguration>("featuresConfiguration", FeaturesConfiguration);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
