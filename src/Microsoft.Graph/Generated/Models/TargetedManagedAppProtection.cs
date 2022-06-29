using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TargetedManagedAppProtection : ManagedAppProtection, IParsable {
        /// <summary>Public Apps selection: group or individual. Possible values are: selectedPublicApps, allCoreMicrosoftApps, allMicrosoftApps, allApps.</summary>
        public TargetedManagedAppGroupType? AppGroupType {
            get { return BackingStore?.Get<TargetedManagedAppGroupType?>(nameof(AppGroupType)); }
            set { BackingStore?.Set(nameof(AppGroupType), value); }
        }
        /// <summary>Navigation property to list of inclusion and exclusion groups to which the policy is deployed.</summary>
        public List<TargetedManagedAppPolicyAssignment> Assignments {
            get { return BackingStore?.Get<List<TargetedManagedAppPolicyAssignment>>(nameof(Assignments)); }
            set { BackingStore?.Set(nameof(Assignments), value); }
        }
        /// <summary>Indicates if the policy is deployed to any inclusion groups or not.</summary>
        public bool? IsAssigned {
            get { return BackingStore?.Get<bool?>(nameof(IsAssigned)); }
            set { BackingStore?.Set(nameof(IsAssigned), value); }
        }
        /// <summary>The intended app management levels for this policy. Possible values are: unspecified, unmanaged, mdm, androidEnterprise.</summary>
        public AppManagementLevel? TargetedAppManagementLevels {
            get { return BackingStore?.Get<AppManagementLevel?>(nameof(TargetedAppManagementLevels)); }
            set { BackingStore?.Set(nameof(TargetedAppManagementLevels), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TargetedManagedAppProtection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
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
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<TargetedManagedAppPolicyAssignment>(TargetedManagedAppPolicyAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"isAssigned", n => { IsAssigned = n.GetBoolValue(); } },
                {"targetedAppManagementLevels", n => { TargetedAppManagementLevels = n.GetEnumValue<AppManagementLevel>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
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
