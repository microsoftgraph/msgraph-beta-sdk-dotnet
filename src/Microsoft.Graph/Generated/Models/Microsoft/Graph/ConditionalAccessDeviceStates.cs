using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class ConditionalAccessDeviceStates : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>States excluded from the scope of the policy. Possible values: Compliant, DomainJoined.</summary>
        public List<string> ExcludeStates { get; set; }
        /// <summary>States in the scope of the policy. All is the only allowed value.</summary>
        public List<string> IncludeStates { get; set; }
        /// <summary>
        /// Instantiates a new conditionalAccessDeviceStates and sets the default values.
        /// </summary>
        public ConditionalAccessDeviceStates() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ConditionalAccessDeviceStates CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConditionalAccessDeviceStates();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"excludeStates", (o,n) => { (o as ConditionalAccessDeviceStates).ExcludeStates = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"includeStates", (o,n) => { (o as ConditionalAccessDeviceStates).IncludeStates = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("excludeStates", ExcludeStates);
            writer.WriteCollectionOfPrimitiveValues<string>("includeStates", IncludeStates);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
