using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class TeamworkLoginStatus : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Information about the Exchange connection.</summary>
        public TeamworkConnection ExchangeConnection { get; set; }
        /// <summary>Information about the Skype for Business connection.</summary>
        public TeamworkConnection SkypeConnection { get; set; }
        /// <summary>Information about the Teams connection.</summary>
        public TeamworkConnection TeamsConnection { get; set; }
        /// <summary>
        /// Instantiates a new teamworkLoginStatus and sets the default values.
        /// </summary>
        public TeamworkLoginStatus() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"exchangeConnection", (o,n) => { (o as TeamworkLoginStatus).ExchangeConnection = n.GetObjectValue<TeamworkConnection>(); } },
                {"skypeConnection", (o,n) => { (o as TeamworkLoginStatus).SkypeConnection = n.GetObjectValue<TeamworkConnection>(); } },
                {"teamsConnection", (o,n) => { (o as TeamworkLoginStatus).TeamsConnection = n.GetObjectValue<TeamworkConnection>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<TeamworkConnection>("exchangeConnection", ExchangeConnection);
            writer.WriteObjectValue<TeamworkConnection>("skypeConnection", SkypeConnection);
            writer.WriteObjectValue<TeamworkConnection>("teamsConnection", TeamsConnection);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
