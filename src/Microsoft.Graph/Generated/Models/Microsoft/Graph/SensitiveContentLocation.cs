using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to call the classifyExactMatches method.</summary>
    public class SensitiveContentLocation : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public int? Confidence { get; set; }
        public List<SensitiveContentEvidence> Evidences { get; set; }
        public string IdMatch { get; set; }
        public int? Length { get; set; }
        public int? Offset { get; set; }
        /// <summary>
        /// Instantiates a new sensitiveContentLocation and sets the default values.
        /// </summary>
        public SensitiveContentLocation() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SensitiveContentLocation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SensitiveContentLocation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"confidence", (o,n) => { (o as SensitiveContentLocation).Confidence = n.GetIntValue(); } },
                {"evidences", (o,n) => { (o as SensitiveContentLocation).Evidences = n.GetCollectionOfObjectValues<SensitiveContentEvidence>(SensitiveContentEvidence.CreateFromDiscriminatorValue).ToList(); } },
                {"idMatch", (o,n) => { (o as SensitiveContentLocation).IdMatch = n.GetStringValue(); } },
                {"length", (o,n) => { (o as SensitiveContentLocation).Length = n.GetIntValue(); } },
                {"offset", (o,n) => { (o as SensitiveContentLocation).Offset = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("confidence", Confidence);
            writer.WriteCollectionOfObjectValues<SensitiveContentEvidence>("evidences", Evidences);
            writer.WriteStringValue("idMatch", IdMatch);
            writer.WriteIntValue("length", Length);
            writer.WriteIntValue("offset", Offset);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
