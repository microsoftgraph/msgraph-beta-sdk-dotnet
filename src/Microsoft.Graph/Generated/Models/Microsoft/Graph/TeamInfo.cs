using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class TeamInfo : Entity, IParsable {
        public string DisplayName { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Team Team { get; set; }
        public string TenantId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TeamInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"displayName", (o,n) => { (o as TeamInfo).DisplayName = n.GetStringValue(); } },
                {"team", (o,n) => { (o as TeamInfo).Team = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Team>(MicrosoftGraphSdk.Models.Microsoft.Graph.Team.CreateFromDiscriminatorValue); } },
                {"tenantId", (o,n) => { (o as TeamInfo).TenantId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Team>("team", Team);
            writer.WriteStringValue("tenantId", TenantId);
        }
    }
}
