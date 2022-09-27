using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Describes the resourceOperation resource (entity) of the Microsoft Graph API (REST), which supports Intune workflows related to role-based access control (RBAC).</summary>
    public class ResourceOperation : Entity, IParsable {
        /// <summary>Type of action this operation is going to perform. The actionName should be concise and limited to as few words as possible.</summary>
        public string ActionName {
            get { return BackingStore?.Get<string>("actionName"); }
            set { BackingStore?.Set("actionName", value); }
        }
        /// <summary>Description of the resource operation. The description is used in mouse-over text for the operation when shown in the Azure Portal.</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>Determines whether the Permission is validated for Scopes defined per Role Assignment. This property is read-only.</summary>
        public bool? EnabledForScopeValidation {
            get { return BackingStore?.Get<bool?>("enabledForScopeValidation"); }
            set { BackingStore?.Set("enabledForScopeValidation", value); }
        }
        /// <summary>Resource category to which this Operation belongs. This property is read-only.</summary>
        public string Resource {
            get { return BackingStore?.Get<string>("resource"); }
            set { BackingStore?.Set("resource", value); }
        }
        /// <summary>Name of the Resource this operation is performed on.</summary>
        public string ResourceName {
            get { return BackingStore?.Get<string>("resourceName"); }
            set { BackingStore?.Set("resourceName", value); }
        }
        /// <summary>
        /// Instantiates a new resourceOperation and sets the default values.
        /// </summary>
        public ResourceOperation() : base() {
            OdataType = "#microsoft.graph.resourceOperation";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ResourceOperation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ResourceOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"actionName", n => { ActionName = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"enabledForScopeValidation", n => { EnabledForScopeValidation = n.GetBoolValue(); } },
                {"resource", n => { Resource = n.GetStringValue(); } },
                {"resourceName", n => { ResourceName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("actionName", ActionName);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("resourceName", ResourceName);
        }
    }
}
