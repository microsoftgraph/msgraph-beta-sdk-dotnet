using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class ManagementAction : Entity, IParsable {
        /// <summary>The category for the management action. Possible values are: custom, devices, identity, unknownFutureValue. Optional. Read-only.</summary>
        public ManagementCategory? Category {
            get { return BackingStore?.Get<ManagementCategory?>(nameof(Category)); }
            set { BackingStore?.Set(nameof(Category), value); }
        }
        /// <summary>The description for the management action. Optional. Read-only.</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>The display name for the management action. Optional. Read-only.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The reference for the management template used to generate the management action. Required. Read-only.</summary>
        public string ReferenceTemplateId {
            get { return BackingStore?.Get<string>(nameof(ReferenceTemplateId)); }
            set { BackingStore?.Set(nameof(ReferenceTemplateId), value); }
        }
        /// <summary>The referenceTemplateVersion property</summary>
        public int? ReferenceTemplateVersion {
            get { return BackingStore?.Get<int?>(nameof(ReferenceTemplateVersion)); }
            set { BackingStore?.Set(nameof(ReferenceTemplateVersion), value); }
        }
        /// <summary>The collection of workload actions associated with the management action. Required. Read-only.</summary>
        public List<WorkloadAction> WorkloadActions {
            get { return BackingStore?.Get<List<WorkloadAction>>(nameof(WorkloadActions)); }
            set { BackingStore?.Set(nameof(WorkloadActions), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ManagementAction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagementAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"category", n => { Category = n.GetEnumValue<ManagementCategory>(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"referenceTemplateId", n => { ReferenceTemplateId = n.GetStringValue(); } },
                {"referenceTemplateVersion", n => { ReferenceTemplateVersion = n.GetIntValue(); } },
                {"workloadActions", n => { WorkloadActions = n.GetCollectionOfObjectValues<WorkloadAction>(WorkloadAction.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<ManagementCategory>("category", Category);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("referenceTemplateId", ReferenceTemplateId);
            writer.WriteIntValue("referenceTemplateVersion", ReferenceTemplateVersion);
            writer.WriteCollectionOfObjectValues<WorkloadAction>("workloadActions", WorkloadActions);
        }
    }
}
