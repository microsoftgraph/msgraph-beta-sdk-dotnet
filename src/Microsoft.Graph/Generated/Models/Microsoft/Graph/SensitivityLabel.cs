using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class SensitivityLabel : Entity, IParsable {
        public SensitivityLabelTarget? ApplicableTo { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ApplicationMode? ApplicationMode { get; set; }
        public List<LabelPolicy> AssignedPolicies { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.AutoLabeling AutoLabeling { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public bool? IsDefault { get; set; }
        public bool? IsEndpointProtectionEnabled { get; set; }
        public List<LabelActionBase> LabelActions { get; set; }
        public string Name { get; set; }
        public int? Priority { get; set; }
        public List<SensitivityLabel> Sublabels { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"applicableTo", (o,n) => { (o as SensitivityLabel).ApplicableTo = n.GetEnumValue<SensitivityLabelTarget>(); } },
                {"applicationMode", (o,n) => { (o as SensitivityLabel).ApplicationMode = n.GetEnumValue<ApplicationMode>(); } },
                {"assignedPolicies", (o,n) => { (o as SensitivityLabel).AssignedPolicies = n.GetCollectionOfObjectValues<LabelPolicy>(LabelPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"autoLabeling", (o,n) => { (o as SensitivityLabel).AutoLabeling = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.AutoLabeling>(MicrosoftGraphSdk.Models.Microsoft.Graph.AutoLabeling.CreateFromDiscriminatorValue); } },
                {"description", (o,n) => { (o as SensitivityLabel).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as SensitivityLabel).DisplayName = n.GetStringValue(); } },
                {"isDefault", (o,n) => { (o as SensitivityLabel).IsDefault = n.GetBoolValue(); } },
                {"isEndpointProtectionEnabled", (o,n) => { (o as SensitivityLabel).IsEndpointProtectionEnabled = n.GetBoolValue(); } },
                {"labelActions", (o,n) => { (o as SensitivityLabel).LabelActions = n.GetCollectionOfObjectValues<LabelActionBase>(LabelActionBase.CreateFromDiscriminatorValue).ToList(); } },
                {"name", (o,n) => { (o as SensitivityLabel).Name = n.GetStringValue(); } },
                {"priority", (o,n) => { (o as SensitivityLabel).Priority = n.GetIntValue(); } },
                {"sublabels", (o,n) => { (o as SensitivityLabel).Sublabels = n.GetCollectionOfObjectValues<SensitivityLabel>(SensitivityLabel.CreateFromDiscriminatorValue).ToList(); } },
                {"toolTip", (o,n) => { (o as SensitivityLabel).ToolTip = n.GetStringValue(); } },
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
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.AutoLabeling>("autoLabeling", AutoLabeling);
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
