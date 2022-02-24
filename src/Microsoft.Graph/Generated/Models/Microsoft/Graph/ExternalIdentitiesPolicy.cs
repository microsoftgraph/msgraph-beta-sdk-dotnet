using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class ExternalIdentitiesPolicy : PolicyBase, IParsable {
        public bool? AllowDeletedIdentitiesDataRemoval { get; set; }
        public bool? AllowExternalIdentitiesToLeave { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"allowDeletedIdentitiesDataRemoval", (o,n) => { (o as ExternalIdentitiesPolicy).AllowDeletedIdentitiesDataRemoval = n.GetBoolValue(); } },
                {"allowExternalIdentitiesToLeave", (o,n) => { (o as ExternalIdentitiesPolicy).AllowExternalIdentitiesToLeave = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowDeletedIdentitiesDataRemoval", AllowDeletedIdentitiesDataRemoval);
            writer.WriteBoolValue("allowExternalIdentitiesToLeave", AllowExternalIdentitiesToLeave);
        }
    }
}
