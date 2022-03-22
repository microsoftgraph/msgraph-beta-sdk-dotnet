using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class SynchronizationJobRestartCriteria : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Comma-separated combination of the following values: Full, QuarantineState, Watermark, Escrows, ConnectorDataStore. Use Full if you want all of the options.</summary>
        public SynchronizationJobRestartScope? ResetScope { get; set; }
        /// <summary>
        /// Instantiates a new synchronizationJobRestartCriteria and sets the default values.
        /// </summary>
        public SynchronizationJobRestartCriteria() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SynchronizationJobRestartCriteria CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SynchronizationJobRestartCriteria();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"resetScope", (o,n) => { (o as SynchronizationJobRestartCriteria).ResetScope = n.GetEnumValue<SynchronizationJobRestartScope>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<SynchronizationJobRestartScope>("resetScope", ResetScope);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
