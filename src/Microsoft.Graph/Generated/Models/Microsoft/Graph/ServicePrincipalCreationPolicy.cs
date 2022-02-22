using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class ServicePrincipalCreationPolicy : PolicyBase, IParsable {
        public List<ServicePrincipalCreationConditionSet> Excludes { get; set; }
        public List<ServicePrincipalCreationConditionSet> Includes { get; set; }
        public bool? IsBuiltIn { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"excludes", (o,n) => { (o as ServicePrincipalCreationPolicy).Excludes = n.GetCollectionOfObjectValues<ServicePrincipalCreationConditionSet>().ToList(); } },
                {"includes", (o,n) => { (o as ServicePrincipalCreationPolicy).Includes = n.GetCollectionOfObjectValues<ServicePrincipalCreationConditionSet>().ToList(); } },
                {"isBuiltIn", (o,n) => { (o as ServicePrincipalCreationPolicy).IsBuiltIn = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ServicePrincipalCreationConditionSet>("excludes", Excludes);
            writer.WriteCollectionOfObjectValues<ServicePrincipalCreationConditionSet>("includes", Includes);
            writer.WriteBoolValue("isBuiltIn", IsBuiltIn);
        }
    }
}
