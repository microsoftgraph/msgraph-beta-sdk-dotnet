using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedTenants {
    public class ManagementAction : Entity, IParsable {
        /// <summary>The category for the management action. Possible values are: custom, devices, identity, unknownFutureValue. Optional. Read-only.</summary>
        public ManagementCategory? Category { get; set; }
        /// <summary>The description for the management action. Optional. Read-only.</summary>
        public string Description { get; set; }
        /// <summary>The display name for the management action. Optional. Read-only.</summary>
        public string DisplayName { get; set; }
        /// <summary>The reference for the management template used to generate the management action. Required. Read-only.</summary>
        public string ReferenceTemplateId { get; set; }
        /// <summary>The referenceTemplateVersion property</summary>
        public int? ReferenceTemplateVersion { get; set; }
        /// <summary>The collection of workload actions associated with the management action. Required. Read-only.</summary>
        public List<WorkloadAction> WorkloadActions { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"category", (o,n) => { (o as ManagementAction).Category = n.GetEnumValue<ManagementCategory>(); } },
                {"description", (o,n) => { (o as ManagementAction).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as ManagementAction).DisplayName = n.GetStringValue(); } },
                {"referenceTemplateId", (o,n) => { (o as ManagementAction).ReferenceTemplateId = n.GetStringValue(); } },
                {"referenceTemplateVersion", (o,n) => { (o as ManagementAction).ReferenceTemplateVersion = n.GetIntValue(); } },
                {"workloadActions", (o,n) => { (o as ManagementAction).WorkloadActions = n.GetCollectionOfObjectValues<WorkloadAction>(WorkloadAction.CreateFromDiscriminatorValue).ToList(); } },
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
