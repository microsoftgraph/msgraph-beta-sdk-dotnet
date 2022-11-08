using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class UnifiedRbacResourceNamespace : Entity, IParsable {
        /// <summary>Name of the resource namespace. Typically, the same name as the id property, such as microsoft.aad.b2c. Required. Supports $filter (eq, startsWith).</summary>
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
        /// <summary>Operations that an authorized principal are allowed to perform.</summary>
        public List<UnifiedRbacResourceAction> ResourceActions {
            get { return BackingStore?.Get<List<UnifiedRbacResourceAction>>("resourceActions"); }
            set { BackingStore?.Set("resourceActions", value); }
        }
        /// <summary>
        /// Instantiates a new unifiedRbacResourceNamespace and sets the default values.
        /// </summary>
        public UnifiedRbacResourceNamespace() : base() {
            OdataType = "#microsoft.graph.unifiedRbacResourceNamespace";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UnifiedRbacResourceNamespace CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedRbacResourceNamespace();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"name", n => { Name = n.GetStringValue(); } },
                {"resourceActions", n => { ResourceActions = n.GetCollectionOfObjectValues<UnifiedRbacResourceAction>(UnifiedRbacResourceAction.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<UnifiedRbacResourceAction>("resourceActions", ResourceActions);
        }
    }
}
