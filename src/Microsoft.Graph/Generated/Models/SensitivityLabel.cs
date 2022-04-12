using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SensitivityLabel : Entity, IParsable {
        /// <summary>The applicableTo property</summary>
        public SensitivityLabelTarget? ApplicableTo { get; set; }
        /// <summary>The applicationMode property</summary>
        public Microsoft.Graph.Beta.Models.ApplicationMode? ApplicationMode { get; set; }
        /// <summary>The assignedPolicies property</summary>
        public List<LabelPolicy> AssignedPolicies { get; set; }
        /// <summary>The autoLabeling property</summary>
        public Microsoft.Graph.Beta.Models.AutoLabeling AutoLabeling { get; set; }
        /// <summary>The description property</summary>
        public string Description { get; set; }
        /// <summary>The displayName property</summary>
        public string DisplayName { get; set; }
        /// <summary>The isDefault property</summary>
        public bool? IsDefault { get; set; }
        /// <summary>The isEndpointProtectionEnabled property</summary>
        public bool? IsEndpointProtectionEnabled { get; set; }
        /// <summary>The labelActions property</summary>
        public List<LabelActionBase> LabelActions { get; set; }
        /// <summary>The name property</summary>
        public string Name { get; set; }
        /// <summary>The priority property</summary>
        public int? Priority { get; set; }
        /// <summary>The sublabels property</summary>
        public List<SensitivityLabel> Sublabels { get; set; }
        /// <summary>The toolTip property</summary>
        public string ToolTip { get; set; }
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
