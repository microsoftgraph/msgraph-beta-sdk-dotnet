using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class TeamworkSoftwareUpdateStatus : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The available software version to update.</summary>
        public string AvailableVersion { get; set; }
        /// <summary>The current software version.</summary>
        public string CurrentVersion { get; set; }
        /// <summary>The update status of the software. The possible values are: unknown, latest, updateAvailable, unknownFutureValue.</summary>
        public TeamworkSoftwareFreshness? SoftwareFreshness { get; set; }
        /// <summary>
        /// Instantiates a new teamworkSoftwareUpdateStatus and sets the default values.
        /// </summary>
        public TeamworkSoftwareUpdateStatus() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"availableVersion", (o,n) => { (o as TeamworkSoftwareUpdateStatus).AvailableVersion = n.GetStringValue(); } },
                {"currentVersion", (o,n) => { (o as TeamworkSoftwareUpdateStatus).CurrentVersion = n.GetStringValue(); } },
                {"softwareFreshness", (o,n) => { (o as TeamworkSoftwareUpdateStatus).SoftwareFreshness = n.GetEnumValue<TeamworkSoftwareFreshness>(); } },
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
