using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class TeamworkTeamsClientConfiguration : IParsable {
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
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"accountConfiguration", (o,n) => { (o as TeamworkTeamsClientConfiguration).AccountConfiguration = n.GetObjectValue<TeamworkAccountConfiguration>(); } },
                {"featuresConfiguration", (o,n) => { (o as TeamworkTeamsClientConfiguration).FeaturesConfiguration = n.GetObjectValue<TeamworkFeaturesConfiguration>(); } },
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
