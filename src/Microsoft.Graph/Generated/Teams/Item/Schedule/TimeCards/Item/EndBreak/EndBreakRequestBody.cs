using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Teams.Item.Schedule.TimeCards.Item.EndBreak {
    /// <summary>Provides operations to call the endBreak method.</summary>
    public class EndBreakRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The atApprovedLocation property</summary>
        public bool? AtApprovedLocation { get; set; }
        /// <summary>The notes property</summary>
        public ItemBody Notes { get; set; }
        /// <summary>
        /// Instantiates a new endBreakRequestBody and sets the default values.
        /// </summary>
        public EndBreakRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static EndBreakRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EndBreakRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"atApprovedLocation", (o,n) => { (o as EndBreakRequestBody).AtApprovedLocation = n.GetBoolValue(); } },
                {"notes", (o,n) => { (o as EndBreakRequestBody).Notes = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("atApprovedLocation", AtApprovedLocation);
            writer.WriteObjectValue<ItemBody>("notes", Notes);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
