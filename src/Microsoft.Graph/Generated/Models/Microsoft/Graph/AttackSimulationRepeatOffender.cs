using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class AttackSimulationRepeatOffender : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>User in an attack simulation and training campaign.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.AttackSimulationUser AttackSimulationUser { get; set; }
        /// <summary>Number of repeat offences of the user in attack simulation and training campaigns.</summary>
        public int? RepeatOffenceCount { get; set; }
        /// <summary>
        /// Instantiates a new attackSimulationRepeatOffender and sets the default values.
        /// </summary>
        public AttackSimulationRepeatOffender() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AttackSimulationRepeatOffender CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AttackSimulationRepeatOffender();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"attackSimulationUser", (o,n) => { (o as AttackSimulationRepeatOffender).AttackSimulationUser = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.AttackSimulationUser>(MicrosoftGraphSdk.Models.Microsoft.Graph.AttackSimulationUser.CreateFromDiscriminatorValue); } },
                {"repeatOffenceCount", (o,n) => { (o as AttackSimulationRepeatOffender).RepeatOffenceCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.AttackSimulationUser>("attackSimulationUser", AttackSimulationUser);
            writer.WriteIntValue("repeatOffenceCount", RepeatOffenceCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
