using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class RolePermission : IParsable {
        /// <summary>Allowed Actions - Deprecated</summary>
        public List<string> Actions { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Resource Actions each containing a set of allowed and not allowed permissions.</summary>
        public List<ResourceAction> ResourceActions { get; set; }
        /// <summary>
        /// Instantiates a new rolePermission and sets the default values.
        /// </summary>
        public RolePermission() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"actions", (o,n) => { (o as RolePermission).Actions = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"resourceActions", (o,n) => { (o as RolePermission).ResourceActions = n.GetCollectionOfObjectValues<ResourceAction>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("actions", Actions);
            writer.WriteCollectionOfObjectValues<ResourceAction>("resourceActions", ResourceActions);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
