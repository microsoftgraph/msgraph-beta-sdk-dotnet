using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class AppCatalogs : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<MicrosoftGraph.Models.Microsoft.Graph.TeamsApp> TeamsApps { get; set; }
        /// <summary>
        /// Instantiates a new AppCatalogs and sets the default values.
        /// </summary>
        public AppCatalogs() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"teamsApps", (o,n) => { (o as AppCatalogs).TeamsApps = n.GetCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.TeamsApp>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.TeamsApp>("teamsApps", TeamsApps);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
