using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AppleUserInitiatedEnrollmentProfile : Entity, IParsable {
        /// <summary>The list of assignments for this profile.</summary>
        public List<AppleEnrollmentProfileAssignment> Assignments { get; set; }
        /// <summary>List of available enrollment type options</summary>
        public List<AppleOwnerTypeEnrollmentType> AvailableEnrollmentTypeOptions { get; set; }
        /// <summary>Profile creation time</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The default profile enrollment type. Possible values are: unknown, device, user.</summary>
        public AppleUserInitiatedEnrollmentType? DefaultEnrollmentType { get; set; }
        /// <summary>Description of the profile</summary>
        public string Description { get; set; }
        /// <summary>Name of the profile</summary>
        public string DisplayName { get; set; }
        /// <summary>Profile last modified time</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The platform of the Device. Possible values are: android, androidForWork, iOS, macOS, windowsPhone81, windows81AndLater, windows10AndLater, androidWorkProfile, unknown, androidAOSP.</summary>
        public DevicePlatformType? Platform { get; set; }
        /// <summary>Priority, 0 is highest</summary>
        public int? Priority { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AppleUserInitiatedEnrollmentProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AppleUserInitiatedEnrollmentProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignments", (o,n) => { (o as AppleUserInitiatedEnrollmentProfile).Assignments = n.GetCollectionOfObjectValues<AppleEnrollmentProfileAssignment>(AppleEnrollmentProfileAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"availableEnrollmentTypeOptions", (o,n) => { (o as AppleUserInitiatedEnrollmentProfile).AvailableEnrollmentTypeOptions = n.GetCollectionOfObjectValues<AppleOwnerTypeEnrollmentType>(AppleOwnerTypeEnrollmentType.CreateFromDiscriminatorValue).ToList(); } },
                {"createdDateTime", (o,n) => { (o as AppleUserInitiatedEnrollmentProfile).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"defaultEnrollmentType", (o,n) => { (o as AppleUserInitiatedEnrollmentProfile).DefaultEnrollmentType = n.GetEnumValue<AppleUserInitiatedEnrollmentType>(); } },
                {"description", (o,n) => { (o as AppleUserInitiatedEnrollmentProfile).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as AppleUserInitiatedEnrollmentProfile).DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as AppleUserInitiatedEnrollmentProfile).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"platform", (o,n) => { (o as AppleUserInitiatedEnrollmentProfile).Platform = n.GetEnumValue<DevicePlatformType>(); } },
                {"priority", (o,n) => { (o as AppleUserInitiatedEnrollmentProfile).Priority = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AppleEnrollmentProfileAssignment>("assignments", Assignments);
            writer.WriteCollectionOfObjectValues<AppleOwnerTypeEnrollmentType>("availableEnrollmentTypeOptions", AvailableEnrollmentTypeOptions);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteEnumValue<AppleUserInitiatedEnrollmentType>("defaultEnrollmentType", DefaultEnrollmentType);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteEnumValue<DevicePlatformType>("platform", Platform);
            writer.WriteIntValue("priority", Priority);
        }
    }
}
