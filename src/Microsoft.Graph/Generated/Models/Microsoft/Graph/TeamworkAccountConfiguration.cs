using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class TeamworkAccountConfiguration : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The account used to sync the calendar.</summary>
        public TeamworkOnPremisesCalendarSyncConfiguration OnPremisesCalendarSyncConfiguration { get; set; }
        /// <summary>The supported client for Teams Rooms devices. The possible values are: unknown, skypeDefaultAndTeams, teamsDefaultAndSkype, skypeOnly, teamsOnly, unknownFutureValue.</summary>
        public TeamworkSupportedClient? SupportedClient { get; set; }
        /// <summary>
        /// Instantiates a new teamworkAccountConfiguration and sets the default values.
        /// </summary>
        public TeamworkAccountConfiguration() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"onPremisesCalendarSyncConfiguration", (o,n) => { (o as TeamworkAccountConfiguration).OnPremisesCalendarSyncConfiguration = n.GetObjectValue<TeamworkOnPremisesCalendarSyncConfiguration>(); } },
                {"supportedClient", (o,n) => { (o as TeamworkAccountConfiguration).SupportedClient = n.GetEnumValue<TeamworkSupportedClient>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<TeamworkOnPremisesCalendarSyncConfiguration>("onPremisesCalendarSyncConfiguration", OnPremisesCalendarSyncConfiguration);
            writer.WriteEnumValue<TeamworkSupportedClient>("supportedClient", SupportedClient);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
