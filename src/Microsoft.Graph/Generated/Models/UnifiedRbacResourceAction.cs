using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class UnifiedRbacResourceAction : Entity, IParsable {
        /// <summary>HTTP method for the action, such as DELETE, GET, PATCH, POST, PUT, or null. Supports $filter (eq) but not for null values.</summary>
        public string ActionVerb {
            get { return BackingStore?.Get<string>(nameof(ActionVerb)); }
            set { BackingStore?.Set(nameof(ActionVerb), value); }
        }
        /// <summary>Description for the action. Supports $filter (eq).</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>Name for the action within the resource namespace, such as microsoft.insights/programs/update. Can include slash character (/). Case insensitive. Required. Supports $filter (eq).</summary>
        public string Name {
            get { return BackingStore?.Get<string>(nameof(Name)); }
            set { BackingStore?.Set(nameof(Name), value); }
        }
        /// <summary>The resourceScope property</summary>
        public UnifiedRbacResourceScope ResourceScope {
            get { return BackingStore?.Get<UnifiedRbacResourceScope>(nameof(ResourceScope)); }
            set { BackingStore?.Set(nameof(ResourceScope), value); }
        }
        /// <summary>Not implemented.</summary>
        public string ResourceScopeId {
            get { return BackingStore?.Get<string>(nameof(ResourceScopeId)); }
            set { BackingStore?.Set(nameof(ResourceScopeId), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UnifiedRbacResourceAction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedRbacResourceAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"actionVerb", n => { ActionVerb = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"resourceScope", n => { ResourceScope = n.GetObjectValue<UnifiedRbacResourceScope>(UnifiedRbacResourceScope.CreateFromDiscriminatorValue); } },
                {"resourceScopeId", n => { ResourceScopeId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("actionVerb", ActionVerb);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<UnifiedRbacResourceScope>("resourceScope", ResourceScope);
            writer.WriteStringValue("resourceScopeId", ResourceScopeId);
        }
    }
}
