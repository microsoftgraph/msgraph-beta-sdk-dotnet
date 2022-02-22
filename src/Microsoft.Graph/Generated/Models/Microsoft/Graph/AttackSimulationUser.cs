using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class AttackSimulationUser : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Display name of the user.</summary>
        public string DisplayName { get; set; }
        /// <summary>Email address of the user.</summary>
        public string Email { get; set; }
        /// <summary>This is the id property value of the user resource that represents the user in the Azure AD tenant.</summary>
        public string UserId { get; set; }
        /// <summary>
        /// Instantiates a new attackSimulationUser and sets the default values.
        /// </summary>
        public AttackSimulationUser() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"displayName", (o,n) => { (o as AttackSimulationUser).DisplayName = n.GetStringValue(); } },
                {"email", (o,n) => { (o as AttackSimulationUser).Email = n.GetStringValue(); } },
                {"userId", (o,n) => { (o as AttackSimulationUser).UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("userId", UserId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
