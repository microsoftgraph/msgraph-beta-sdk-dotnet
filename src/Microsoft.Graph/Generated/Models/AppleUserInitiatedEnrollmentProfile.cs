using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The enrollmentProfile resource represents a collection of configurations which must be provided pre-enrollment to enable enrolling certain devices whose identities have been pre-staged. Pre-staged device identities are assigned to this type of profile to apply the profile&apos;s configurations at enrollment of the corresponding device.</summary>
    public class AppleUserInitiatedEnrollmentProfile : Entity, IParsable {
        /// <summary>The list of assignments for this profile.</summary>
        public List<AppleEnrollmentProfileAssignment> Assignments {
            get { return BackingStore?.Get<List<AppleEnrollmentProfileAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
        /// <summary>List of available enrollment type options</summary>
        public List<AppleOwnerTypeEnrollmentType> AvailableEnrollmentTypeOptions {
            get { return BackingStore?.Get<List<AppleOwnerTypeEnrollmentType>>("availableEnrollmentTypeOptions"); }
            set { BackingStore?.Set("availableEnrollmentTypeOptions", value); }
        }
        /// <summary>Profile creation time</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The defaultEnrollmentType property</summary>
        public AppleUserInitiatedEnrollmentType? DefaultEnrollmentType {
            get { return BackingStore?.Get<AppleUserInitiatedEnrollmentType?>("defaultEnrollmentType"); }
            set { BackingStore?.Set("defaultEnrollmentType", value); }
        }
        /// <summary>Description of the profile</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>Name of the profile</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>Profile last modified time</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Supported platform types.</summary>
        public DevicePlatformType? Platform {
            get { return BackingStore?.Get<DevicePlatformType?>("platform"); }
            set { BackingStore?.Set("platform", value); }
        }
        /// <summary>Priority, 0 is highest</summary>
        public int? Priority {
            get { return BackingStore?.Get<int?>("priority"); }
            set { BackingStore?.Set("priority", value); }
        }
        /// <summary>
        /// Instantiates a new appleUserInitiatedEnrollmentProfile and sets the default values.
        /// </summary>
        public AppleUserInitiatedEnrollmentProfile() : base() {
            OdataType = "#microsoft.graph.appleUserInitiatedEnrollmentProfile";
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<AppleEnrollmentProfileAssignment>(AppleEnrollmentProfileAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"availableEnrollmentTypeOptions", n => { AvailableEnrollmentTypeOptions = n.GetCollectionOfObjectValues<AppleOwnerTypeEnrollmentType>(AppleOwnerTypeEnrollmentType.CreateFromDiscriminatorValue)?.ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"defaultEnrollmentType", n => { DefaultEnrollmentType = n.GetEnumValue<AppleUserInitiatedEnrollmentType>(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"platform", n => { Platform = n.GetEnumValue<DevicePlatformType>(); } },
                {"priority", n => { Priority = n.GetIntValue(); } },
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
