using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Provides operations to manage the collection of accessReviewDecision entities.
    /// </summary>
    public class WindowsDefenderApplicationControlSupplementalPolicy : Entity, IParsable {
        /// <summary>The associated group assignments for this WindowsDefenderApplicationControl supplemental policy.</summary>
        public List<WindowsDefenderApplicationControlSupplementalPolicyAssignment> Assignments {
            get { return BackingStore?.Get<List<WindowsDefenderApplicationControlSupplementalPolicyAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
        /// <summary>The WindowsDefenderApplicationControl supplemental policy content in byte array format.</summary>
        public byte[] Content {
            get { return BackingStore?.Get<byte[]>("content"); }
            set { BackingStore?.Set("content", value); }
        }
        /// <summary>The WindowsDefenderApplicationControl supplemental policy content&apos;s file name.</summary>
        public string ContentFileName {
            get { return BackingStore?.Get<string>("contentFileName"); }
            set { BackingStore?.Set("contentFileName", value); }
        }
        /// <summary>The date and time when the WindowsDefenderApplicationControl supplemental policy was uploaded.</summary>
        public DateTimeOffset? CreationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("creationDateTime"); }
            set { BackingStore?.Set("creationDateTime", value); }
        }
        /// <summary>WindowsDefenderApplicationControl supplemental policy deployment summary.</summary>
        public WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary DeploySummary {
            get { return BackingStore?.Get<WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary>("deploySummary"); }
            set { BackingStore?.Set("deploySummary", value); }
        }
        /// <summary>The description of WindowsDefenderApplicationControl supplemental policy.</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>The list of device deployment states for this WindowsDefenderApplicationControl supplemental policy.</summary>
        public List<WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus> DeviceStatuses {
            get { return BackingStore?.Get<List<WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus>>("deviceStatuses"); }
            set { BackingStore?.Set("deviceStatuses", value); }
        }
        /// <summary>The display name of WindowsDefenderApplicationControl supplemental policy.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The date and time when the WindowsDefenderApplicationControl supplemental policy was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>List of Scope Tags for this WindowsDefenderApplicationControl supplemental policy entity.</summary>
        public List<string> RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
        /// <summary>The WindowsDefenderApplicationControl supplemental policy&apos;s version.</summary>
        public string Version {
            get { return BackingStore?.Get<string>("version"); }
            set { BackingStore?.Set("version", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsDefenderApplicationControlSupplementalPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsDefenderApplicationControlSupplementalPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<WindowsDefenderApplicationControlSupplementalPolicyAssignment>(WindowsDefenderApplicationControlSupplementalPolicyAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"content", n => { Content = n.GetByteArrayValue(); } },
                {"contentFileName", n => { ContentFileName = n.GetStringValue(); } },
                {"creationDateTime", n => { CreationDateTime = n.GetDateTimeOffsetValue(); } },
                {"deploySummary", n => { DeploySummary = n.GetObjectValue<WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary>(WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary.CreateFromDiscriminatorValue); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"deviceStatuses", n => { DeviceStatuses = n.GetCollectionOfObjectValues<WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus>(WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus.CreateFromDiscriminatorValue)?.ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"version", n => { Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<WindowsDefenderApplicationControlSupplementalPolicyAssignment>("assignments", Assignments);
            writer.WriteByteArrayValue("content", Content);
            writer.WriteStringValue("contentFileName", ContentFileName);
            writer.WriteDateTimeOffsetValue("creationDateTime", CreationDateTime);
            writer.WriteObjectValue<WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary>("deploySummary", DeploySummary);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus>("deviceStatuses", DeviceStatuses);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteStringValue("version", Version);
        }
    }
}
