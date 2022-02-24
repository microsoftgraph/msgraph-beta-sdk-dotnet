using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class Program : Entity, IParsable {
        /// <summary>Controls associated with the program.</summary>
        public List<ProgramControl> Controls { get; set; }
        /// <summary>The description of the program.</summary>
        public string Description { get; set; }
        /// <summary>The name of the program.  Required on create.</summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"controls", (o,n) => { (o as Program).Controls = n.GetCollectionOfObjectValues<ProgramControl>().ToList(); } },
                {"description", (o,n) => { (o as Program).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as Program).DisplayName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ProgramControl>("controls", Controls);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
        }
    }
}
