using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class ManagementIntent : Entity, IParsable {
        /// <summary>The display name for the management intent. Optional. Read-only.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>A flag indicating whether the management intent is global. Required. Read-only.</summary>
        public bool? IsGlobal {
            get { return BackingStore?.Get<bool?>("isGlobal"); }
            set { BackingStore?.Set("isGlobal", value); }
        }
        /// <summary>The collection of management templates associated with the management intent. Optional. Read-only.</summary>
        public List<ManagementTemplateDetailedInfo> ManagementTemplates {
            get { return BackingStore?.Get<List<ManagementTemplateDetailedInfo>>("managementTemplates"); }
            set { BackingStore?.Set("managementTemplates", value); }
        }
        /// <summary>
        /// Instantiates a new managementIntent and sets the default values.
        /// </summary>
        public ManagementIntent() : base() {
            OdataType = "#microsoft.graph.managedTenants.managementIntent";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ManagementIntent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagementIntent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"isGlobal", n => { IsGlobal = n.GetBoolValue(); } },
                {"managementTemplates", n => { ManagementTemplates = n.GetCollectionOfObjectValues<ManagementTemplateDetailedInfo>(ManagementTemplateDetailedInfo.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isGlobal", IsGlobal);
            writer.WriteCollectionOfObjectValues<ManagementTemplateDetailedInfo>("managementTemplates", ManagementTemplates);
        }
    }
}
