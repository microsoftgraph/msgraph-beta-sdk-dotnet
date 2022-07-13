using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MobileAppDependency : MobileAppRelationship, IParsable {
        /// <summary>Indicates the dependency type associated with a relationship between two mobile apps.</summary>
        public MobileAppDependencyType? DependencyType {
            get { return BackingStore?.Get<MobileAppDependencyType?>("dependencyType"); }
            set { BackingStore?.Set("dependencyType", value); }
        }
        /// <summary>The total number of apps that directly or indirectly depend on the parent app.</summary>
        public int? DependentAppCount {
            get { return BackingStore?.Get<int?>("dependentAppCount"); }
            set { BackingStore?.Set("dependentAppCount", value); }
        }
        /// <summary>The total number of apps the child app directly or indirectly depends on.</summary>
        public int? DependsOnAppCount {
            get { return BackingStore?.Get<int?>("dependsOnAppCount"); }
            set { BackingStore?.Set("dependsOnAppCount", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MobileAppDependency CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MobileAppDependency();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"dependencyType", n => { DependencyType = n.GetEnumValue<MobileAppDependencyType>(); } },
                {"dependentAppCount", n => { DependentAppCount = n.GetIntValue(); } },
                {"dependsOnAppCount", n => { DependsOnAppCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<MobileAppDependencyType>("dependencyType", DependencyType);
            writer.WriteIntValue("dependentAppCount", DependentAppCount);
            writer.WriteIntValue("dependsOnAppCount", DependsOnAppCount);
        }
    }
}
