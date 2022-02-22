using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class Teamwork : Entity, IParsable {
        /// <summary>The Teams devices provisioned for the tenant.</summary>
        public List<TeamworkDevice> Devices { get; set; }
        /// <summary>A workforce integration with shifts.</summary>
        public List<WorkforceIntegration> WorkforceIntegrations { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"devices", (o,n) => { (o as Teamwork).Devices = n.GetCollectionOfObjectValues<TeamworkDevice>().ToList(); } },
                {"workforceIntegrations", (o,n) => { (o as Teamwork).WorkforceIntegrations = n.GetCollectionOfObjectValues<WorkforceIntegration>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<TeamworkDevice>("devices", Devices);
            writer.WriteCollectionOfObjectValues<WorkforceIntegration>("workforceIntegrations", WorkforceIntegrations);
        }
    }
}
