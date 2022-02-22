using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph.Search {
    public class IdentitySet : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public MicrosoftGraph.Models.Microsoft.Graph.Search.Identity Application { get; set; }
        public MicrosoftGraph.Models.Microsoft.Graph.Search.Identity Device { get; set; }
        public MicrosoftGraph.Models.Microsoft.Graph.Search.Identity User { get; set; }
        /// <summary>
        /// Instantiates a new identitySet and sets the default values.
        /// </summary>
        public IdentitySet() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"application", (o,n) => { (o as IdentitySet).Application = n.GetObjectValue<MicrosoftGraph.Models.Microsoft.Graph.Search.Identity>(); } },
                {"device", (o,n) => { (o as IdentitySet).Device = n.GetObjectValue<MicrosoftGraph.Models.Microsoft.Graph.Search.Identity>(); } },
                {"user", (o,n) => { (o as IdentitySet).User = n.GetObjectValue<MicrosoftGraph.Models.Microsoft.Graph.Search.Identity>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<MicrosoftGraph.Models.Microsoft.Graph.Search.Identity>("application", Application);
            writer.WriteObjectValue<MicrosoftGraph.Models.Microsoft.Graph.Search.Identity>("device", Device);
            writer.WriteObjectValue<MicrosoftGraph.Models.Microsoft.Graph.Search.Identity>("user", User);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
