using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class WindowsDefenderApplicationControlSupplementalPolicy : Entity, IParsable {
        /// <summary>The associated group assignments for this WindowsDefenderApplicationControl supplemental policy.</summary>
        public List<WindowsDefenderApplicationControlSupplementalPolicyAssignment> Assignments { get; set; }
        /// <summary>The WindowsDefenderApplicationControl supplemental policy content in byte array format.</summary>
        public byte[] Content { get; set; }
        /// <summary>The WindowsDefenderApplicationControl supplemental policy content&apos;s file name.</summary>
        public string ContentFileName { get; set; }
        /// <summary>The date and time when the WindowsDefenderApplicationControl supplemental policy was uploaded.</summary>
        public DateTimeOffset? CreationDateTime { get; set; }
        /// <summary>WindowsDefenderApplicationControl supplemental policy deployment summary.</summary>
        public WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary DeploySummary { get; set; }
        /// <summary>The description of WindowsDefenderApplicationControl supplemental policy.</summary>
        public string Description { get; set; }
        /// <summary>The list of device deployment states for this WindowsDefenderApplicationControl supplemental policy.</summary>
        public List<WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus> DeviceStatuses { get; set; }
        /// <summary>The display name of WindowsDefenderApplicationControl supplemental policy.</summary>
        public string DisplayName { get; set; }
        /// <summary>The date and time when the WindowsDefenderApplicationControl supplemental policy was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>List of Scope Tags for this WindowsDefenderApplicationControl supplemental policy entity.</summary>
        public List<string> RoleScopeTagIds { get; set; }
        /// <summary>The WindowsDefenderApplicationControl supplemental policy&apos;s version.</summary>
        public string Version { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsDefenderApplicationControlSupplementalPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsDefenderApplicationControlSupplementalPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignments", (o,n) => { (o as WindowsDefenderApplicationControlSupplementalPolicy).Assignments = n.GetCollectionOfObjectValues<WindowsDefenderApplicationControlSupplementalPolicyAssignment>(WindowsDefenderApplicationControlSupplementalPolicyAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"content", (o,n) => { (o as WindowsDefenderApplicationControlSupplementalPolicy).Content = n.GetByteArrayValue(); } },
                {"contentFileName", (o,n) => { (o as WindowsDefenderApplicationControlSupplementalPolicy).ContentFileName = n.GetStringValue(); } },
                {"creationDateTime", (o,n) => { (o as WindowsDefenderApplicationControlSupplementalPolicy).CreationDateTime = n.GetDateTimeOffsetValue(); } },
                {"deploySummary", (o,n) => { (o as WindowsDefenderApplicationControlSupplementalPolicy).DeploySummary = n.GetObjectValue<WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary>(WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary.CreateFromDiscriminatorValue); } },
                {"description", (o,n) => { (o as WindowsDefenderApplicationControlSupplementalPolicy).Description = n.GetStringValue(); } },
                {"deviceStatuses", (o,n) => { (o as WindowsDefenderApplicationControlSupplementalPolicy).DeviceStatuses = n.GetCollectionOfObjectValues<WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus>(WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus.CreateFromDiscriminatorValue).ToList(); } },
                {"displayName", (o,n) => { (o as WindowsDefenderApplicationControlSupplementalPolicy).DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as WindowsDefenderApplicationControlSupplementalPolicy).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"roleScopeTagIds", (o,n) => { (o as WindowsDefenderApplicationControlSupplementalPolicy).RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"version", (o,n) => { (o as WindowsDefenderApplicationControlSupplementalPolicy).Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
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
