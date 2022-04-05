using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.PrivilegedRoles.Item.SelfActivate {
    /// <summary>Provides operations to call the selfActivate method.</summary>
    public class SelfActivateRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The duration property</summary>
        public string Duration { get; set; }
        /// <summary>The reason property</summary>
        public string Reason { get; set; }
        /// <summary>The ticketNumber property</summary>
        public string TicketNumber { get; set; }
        /// <summary>The ticketSystem property</summary>
        public string TicketSystem { get; set; }
        /// <summary>
        /// Instantiates a new selfActivateRequestBody and sets the default values.
        /// </summary>
        public SelfActivateRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SelfActivateRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SelfActivateRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"duration", (o,n) => { (o as SelfActivateRequestBody).Duration = n.GetStringValue(); } },
                {"reason", (o,n) => { (o as SelfActivateRequestBody).Reason = n.GetStringValue(); } },
                {"ticketNumber", (o,n) => { (o as SelfActivateRequestBody).TicketNumber = n.GetStringValue(); } },
                {"ticketSystem", (o,n) => { (o as SelfActivateRequestBody).TicketSystem = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("duration", Duration);
            writer.WriteStringValue("reason", Reason);
            writer.WriteStringValue("ticketNumber", TicketNumber);
            writer.WriteStringValue("ticketSystem", TicketSystem);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
