using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class TeamworkLoginStatus : IAdditionalDataHolder, IParsable {
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
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TeamworkLoginStatus CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkLoginStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"exchangeConnection", (o,n) => { (o as TeamworkLoginStatus).ExchangeConnection = n.GetObjectValue<TeamworkConnection>(TeamworkConnection.CreateFromDiscriminatorValue); } },
                {"skypeConnection", (o,n) => { (o as TeamworkLoginStatus).SkypeConnection = n.GetObjectValue<TeamworkConnection>(TeamworkConnection.CreateFromDiscriminatorValue); } },
                {"teamsConnection", (o,n) => { (o as TeamworkLoginStatus).TeamsConnection = n.GetObjectValue<TeamworkConnection>(TeamworkConnection.CreateFromDiscriminatorValue); } },
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
