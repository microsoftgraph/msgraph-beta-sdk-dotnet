using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TargetedManagedAppProtection : ManagedAppProtection, IParsable {
        /// <summary>Indicates a collection of apps to target which can be one of several pre-defined lists of apps or a manually selected list of apps</summary>
        public TargetedManagedAppGroupType? AppGroupType {
            get { return BackingStore?.Get<TargetedManagedAppGroupType?>("appGroupType"); }
            set { BackingStore?.Set("appGroupType", value); }
        }
        /// <summary>Navigation property to list of inclusion and exclusion groups to which the policy is deployed.</summary>
        public List<TargetedManagedAppPolicyAssignment> Assignments {
            get { return BackingStore?.Get<List<TargetedManagedAppPolicyAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
        /// <summary>Indicates if the policy is deployed to any inclusion groups or not.</summary>
        public bool? IsAssigned {
            get { return BackingStore?.Get<bool?>("isAssigned"); }
            set { BackingStore?.Set("isAssigned", value); }
        }
        /// <summary>Management levels for apps</summary>
        public AppManagementLevel? TargetedAppManagementLevels {
            get { return BackingStore?.Get<AppManagementLevel?>("targetedAppManagementLevels"); }
            set { BackingStore?.Set("targetedAppManagementLevels", value); }
        }
        /// <summary>
        /// Instantiates a new TargetedManagedAppProtection and sets the default values.
        /// </summary>
        public TargetedManagedAppProtection() : base() {
            OdataType = "#microsoft.graph.targetedManagedAppProtection";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TargetedManagedAppProtection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.androidManagedAppProtection" => new AndroidManagedAppProtection(),
                "#microsoft.graph.iosManagedAppProtection" => new IosManagedAppProtection(),
                _ => new TargetedManagedAppProtection(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appGroupType", n => { AppGroupType = n.GetEnumValue<TargetedManagedAppGroupType>(); } },
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<TargetedManagedAppPolicyAssignment>(TargetedManagedAppPolicyAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"isAssigned", n => { IsAssigned = n.GetBoolValue(); } },
                {"targetedAppManagementLevels", n => { TargetedAppManagementLevels = n.GetEnumValue<AppManagementLevel>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<TargetedManagedAppGroupType>("appGroupType", AppGroupType);
            writer.WriteCollectionOfObjectValues<TargetedManagedAppPolicyAssignment>("assignments", Assignments);
            writer.WriteBoolValue("isAssigned", IsAssigned);
            writer.WriteEnumValue<AppManagementLevel>("targetedAppManagementLevels", TargetedAppManagementLevels);
        }
    }
}
