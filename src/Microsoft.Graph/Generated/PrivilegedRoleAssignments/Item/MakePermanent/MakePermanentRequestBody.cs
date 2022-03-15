using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.PrivilegedRoleAssignments.Item.MakePermanent {
    /// <summary>Provides operations to call the makePermanent method.</summary>
    public class MakePermanentRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Reason { get; set; }
        public string TicketNumber { get; set; }
        public string TicketSystem { get; set; }
        /// <summary>
        /// Instantiates a new makePermanentRequestBody and sets the default values.
        /// </summary>
        public MakePermanentRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MakePermanentRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MakePermanentRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"reason", (o,n) => { (o as MakePermanentRequestBody).Reason = n.GetStringValue(); } },
                {"ticketNumber", (o,n) => { (o as MakePermanentRequestBody).TicketNumber = n.GetStringValue(); } },
                {"ticketSystem", (o,n) => { (o as MakePermanentRequestBody).TicketSystem = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("reason", Reason);
            writer.WriteStringValue("ticketNumber", TicketNumber);
            writer.WriteStringValue("ticketSystem", TicketSystem);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
