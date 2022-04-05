using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ServicePrincipalCreationPolicy : PolicyBase, IParsable {
        /// <summary>The excludes property</summary>
        public List<ServicePrincipalCreationConditionSet> Excludes { get; set; }
        /// <summary>The includes property</summary>
        public List<ServicePrincipalCreationConditionSet> Includes { get; set; }
        /// <summary>The isBuiltIn property</summary>
        public bool? IsBuiltIn { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ServicePrincipalCreationPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ServicePrincipalCreationPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"excludes", (o,n) => { (o as ServicePrincipalCreationPolicy).Excludes = n.GetCollectionOfObjectValues<ServicePrincipalCreationConditionSet>(ServicePrincipalCreationConditionSet.CreateFromDiscriminatorValue).ToList(); } },
                {"includes", (o,n) => { (o as ServicePrincipalCreationPolicy).Includes = n.GetCollectionOfObjectValues<ServicePrincipalCreationConditionSet>(ServicePrincipalCreationConditionSet.CreateFromDiscriminatorValue).ToList(); } },
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
