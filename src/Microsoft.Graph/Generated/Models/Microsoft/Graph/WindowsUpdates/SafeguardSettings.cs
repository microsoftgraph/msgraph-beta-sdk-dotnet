using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph.WindowsUpdates {
    public class SafeguardSettings : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>List of safeguards to ignore per device.</summary>
        public List<SafeguardProfile> DisabledSafeguardProfiles { get; set; }
        /// <summary>
        /// Instantiates a new safeguardSettings and sets the default values.
        /// </summary>
        public SafeguardSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"disabledSafeguardProfiles", (o,n) => { (o as SafeguardSettings).DisabledSafeguardProfiles = n.GetCollectionOfObjectValues<SafeguardProfile>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<SafeguardProfile>("disabledSafeguardProfiles", DisabledSafeguardProfiles);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
