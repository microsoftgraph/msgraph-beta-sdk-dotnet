using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class TeamworkCameraConfiguration : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<TeamworkPeripheral> Cameras { get; set; }
        /// <summary>The configuration for the content camera.</summary>
        public TeamworkContentCameraConfiguration ContentCameraConfiguration { get; set; }
        public TeamworkPeripheral DefaultContentCamera { get; set; }
        /// <summary>
        /// Instantiates a new teamworkCameraConfiguration and sets the default values.
        /// </summary>
        public TeamworkCameraConfiguration() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"cameras", (o,n) => { (o as TeamworkCameraConfiguration).Cameras = n.GetCollectionOfObjectValues<TeamworkPeripheral>().ToList(); } },
                {"contentCameraConfiguration", (o,n) => { (o as TeamworkCameraConfiguration).ContentCameraConfiguration = n.GetObjectValue<TeamworkContentCameraConfiguration>(); } },
                {"defaultContentCamera", (o,n) => { (o as TeamworkCameraConfiguration).DefaultContentCamera = n.GetObjectValue<TeamworkPeripheral>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<TeamworkPeripheral>("cameras", Cameras);
            writer.WriteObjectValue<TeamworkContentCameraConfiguration>("contentCameraConfiguration", ContentCameraConfiguration);
            writer.WriteObjectValue<TeamworkPeripheral>("defaultContentCamera", DefaultContentCamera);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
