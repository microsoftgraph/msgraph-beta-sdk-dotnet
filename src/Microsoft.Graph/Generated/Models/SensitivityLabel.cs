using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class SensitivityLabel : Entity, IParsable {
        /// <summary>The applicableTo property</summary>
        public SensitivityLabelTarget? ApplicableTo {
            get { return BackingStore?.Get<SensitivityLabelTarget?>(nameof(ApplicableTo)); }
            set { BackingStore?.Set(nameof(ApplicableTo), value); }
        }
        /// <summary>The applicationMode property</summary>
        public Microsoft.Graph.Beta.Models.ApplicationMode? ApplicationMode {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ApplicationMode?>(nameof(ApplicationMode)); }
            set { BackingStore?.Set(nameof(ApplicationMode), value); }
        }
        /// <summary>The assignedPolicies property</summary>
        public List<LabelPolicy> AssignedPolicies {
            get { return BackingStore?.Get<List<LabelPolicy>>(nameof(AssignedPolicies)); }
            set { BackingStore?.Set(nameof(AssignedPolicies), value); }
        }
        /// <summary>The autoLabeling property</summary>
        public Microsoft.Graph.Beta.Models.AutoLabeling AutoLabeling {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AutoLabeling>(nameof(AutoLabeling)); }
            set { BackingStore?.Set(nameof(AutoLabeling), value); }
        }
        /// <summary>The description property</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>The displayName property</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The isDefault property</summary>
        public bool? IsDefault {
            get { return BackingStore?.Get<bool?>(nameof(IsDefault)); }
            set { BackingStore?.Set(nameof(IsDefault), value); }
        }
        /// <summary>The isEndpointProtectionEnabled property</summary>
        public bool? IsEndpointProtectionEnabled {
            get { return BackingStore?.Get<bool?>(nameof(IsEndpointProtectionEnabled)); }
            set { BackingStore?.Set(nameof(IsEndpointProtectionEnabled), value); }
        }
        /// <summary>The labelActions property</summary>
        public List<LabelActionBase> LabelActions {
            get { return BackingStore?.Get<List<LabelActionBase>>(nameof(LabelActions)); }
            set { BackingStore?.Set(nameof(LabelActions), value); }
        }
        /// <summary>The name property</summary>
        public string Name {
            get { return BackingStore?.Get<string>(nameof(Name)); }
            set { BackingStore?.Set(nameof(Name), value); }
        }
        /// <summary>The priority property</summary>
        public int? Priority {
            get { return BackingStore?.Get<int?>(nameof(Priority)); }
            set { BackingStore?.Set(nameof(Priority), value); }
        }
        /// <summary>The sublabels property</summary>
        public List<SensitivityLabel> Sublabels {
            get { return BackingStore?.Get<List<SensitivityLabel>>(nameof(Sublabels)); }
            set { BackingStore?.Set(nameof(Sublabels), value); }
        }
        /// <summary>The toolTip property</summary>
        public string ToolTip {
            get { return BackingStore?.Get<string>(nameof(ToolTip)); }
            set { BackingStore?.Set(nameof(ToolTip), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SensitivityLabel CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SensitivityLabel();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applicableTo", n => { ApplicableTo = n.GetEnumValue<SensitivityLabelTarget>(); } },
                {"applicationMode", n => { ApplicationMode = n.GetEnumValue<ApplicationMode>(); } },
                {"assignedPolicies", n => { AssignedPolicies = n.GetCollectionOfObjectValues<LabelPolicy>(LabelPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"autoLabeling", n => { AutoLabeling = n.GetObjectValue<Microsoft.Graph.Beta.Models.AutoLabeling>(Microsoft.Graph.Beta.Models.AutoLabeling.CreateFromDiscriminatorValue); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"isDefault", n => { IsDefault = n.GetBoolValue(); } },
                {"isEndpointProtectionEnabled", n => { IsEndpointProtectionEnabled = n.GetBoolValue(); } },
                {"labelActions", n => { LabelActions = n.GetCollectionOfObjectValues<LabelActionBase>(LabelActionBase.CreateFromDiscriminatorValue).ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"priority", n => { Priority = n.GetIntValue(); } },
                {"sublabels", n => { Sublabels = n.GetCollectionOfObjectValues<SensitivityLabel>(SensitivityLabel.CreateFromDiscriminatorValue).ToList(); } },
                {"toolTip", n => { ToolTip = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<SensitivityLabelTarget>("applicableTo", ApplicableTo);
            writer.WriteEnumValue<ApplicationMode>("applicationMode", ApplicationMode);
            writer.WriteCollectionOfObjectValues<LabelPolicy>("assignedPolicies", AssignedPolicies);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AutoLabeling>("autoLabeling", AutoLabeling);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isDefault", IsDefault);
            writer.WriteBoolValue("isEndpointProtectionEnabled", IsEndpointProtectionEnabled);
            writer.WriteCollectionOfObjectValues<LabelActionBase>("labelActions", LabelActions);
            writer.WriteStringValue("name", Name);
            writer.WriteIntValue("priority", Priority);
            writer.WriteCollectionOfObjectValues<SensitivityLabel>("sublabels", Sublabels);
            writer.WriteStringValue("toolTip", ToolTip);
        }
    }
}
