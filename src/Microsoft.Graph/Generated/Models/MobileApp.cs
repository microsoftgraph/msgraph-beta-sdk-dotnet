using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>An abstract class containing the base properties for Intune mobile apps.</summary>
    public class MobileApp : Entity, IParsable {
        /// <summary>The list of group assignments for this mobile app.</summary>
        public List<MobileAppAssignment> Assignments {
            get { return BackingStore?.Get<List<MobileAppAssignment>>(nameof(Assignments)); }
            set { BackingStore?.Set(nameof(Assignments), value); }
        }
        /// <summary>The list of categories for this app.</summary>
        public List<MobileAppCategory> Categories {
            get { return BackingStore?.Get<List<MobileAppCategory>>(nameof(Categories)); }
            set { BackingStore?.Set(nameof(Categories), value); }
        }
        /// <summary>The date and time the app was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>The total number of dependencies the child app has.</summary>
        public int? DependentAppCount {
            get { return BackingStore?.Get<int?>(nameof(DependentAppCount)); }
            set { BackingStore?.Set(nameof(DependentAppCount), value); }
        }
        /// <summary>The description of the app.</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>The developer of the app.</summary>
        public string Developer {
            get { return BackingStore?.Get<string>(nameof(Developer)); }
            set { BackingStore?.Set(nameof(Developer), value); }
        }
        /// <summary>The list of installation states for this mobile app.</summary>
        public List<MobileAppInstallStatus> DeviceStatuses {
            get { return BackingStore?.Get<List<MobileAppInstallStatus>>(nameof(DeviceStatuses)); }
            set { BackingStore?.Set(nameof(DeviceStatuses), value); }
        }
        /// <summary>The admin provided or imported title of the app.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The more information Url.</summary>
        public string InformationUrl {
            get { return BackingStore?.Get<string>(nameof(InformationUrl)); }
            set { BackingStore?.Set(nameof(InformationUrl), value); }
        }
        /// <summary>Mobile App Install Summary.</summary>
        public MobileAppInstallSummary InstallSummary {
            get { return BackingStore?.Get<MobileAppInstallSummary>(nameof(InstallSummary)); }
            set { BackingStore?.Set(nameof(InstallSummary), value); }
        }
        /// <summary>The value indicating whether the app is assigned to at least one group.</summary>
        public bool? IsAssigned {
            get { return BackingStore?.Get<bool?>(nameof(IsAssigned)); }
            set { BackingStore?.Set(nameof(IsAssigned), value); }
        }
        /// <summary>The value indicating whether the app is marked as featured by the admin.</summary>
        public bool? IsFeatured {
            get { return BackingStore?.Get<bool?>(nameof(IsFeatured)); }
            set { BackingStore?.Set(nameof(IsFeatured), value); }
        }
        /// <summary>The large icon, to be displayed in the app details and used for upload of the icon.</summary>
        public MimeContent LargeIcon {
            get { return BackingStore?.Get<MimeContent>(nameof(LargeIcon)); }
            set { BackingStore?.Set(nameof(LargeIcon), value); }
        }
        /// <summary>The date and time the app was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>Notes for the app.</summary>
        public string Notes {
            get { return BackingStore?.Get<string>(nameof(Notes)); }
            set { BackingStore?.Set(nameof(Notes), value); }
        }
        /// <summary>The owner of the app.</summary>
        public string Owner {
            get { return BackingStore?.Get<string>(nameof(Owner)); }
            set { BackingStore?.Set(nameof(Owner), value); }
        }
        /// <summary>The privacy statement Url.</summary>
        public string PrivacyInformationUrl {
            get { return BackingStore?.Get<string>(nameof(PrivacyInformationUrl)); }
            set { BackingStore?.Set(nameof(PrivacyInformationUrl), value); }
        }
        /// <summary>The publisher of the app.</summary>
        public string Publisher {
            get { return BackingStore?.Get<string>(nameof(Publisher)); }
            set { BackingStore?.Set(nameof(Publisher), value); }
        }
        /// <summary>The publishing state for the app. The app cannot be assigned unless the app is published. Possible values are: notPublished, processing, published.</summary>
        public MobileAppPublishingState? PublishingState {
            get { return BackingStore?.Get<MobileAppPublishingState?>(nameof(PublishingState)); }
            set { BackingStore?.Set(nameof(PublishingState), value); }
        }
        /// <summary>List of relationships for this mobile app.</summary>
        public List<MobileAppRelationship> Relationships {
            get { return BackingStore?.Get<List<MobileAppRelationship>>(nameof(Relationships)); }
            set { BackingStore?.Set(nameof(Relationships), value); }
        }
        /// <summary>List of scope tag ids for this mobile app.</summary>
        public List<string> RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>>(nameof(RoleScopeTagIds)); }
            set { BackingStore?.Set(nameof(RoleScopeTagIds), value); }
        }
        /// <summary>The total number of apps this app is directly or indirectly superseded by.</summary>
        public int? SupersededAppCount {
            get { return BackingStore?.Get<int?>(nameof(SupersededAppCount)); }
            set { BackingStore?.Set(nameof(SupersededAppCount), value); }
        }
        /// <summary>The total number of apps this app directly or indirectly supersedes.</summary>
        public int? SupersedingAppCount {
            get { return BackingStore?.Get<int?>(nameof(SupersedingAppCount)); }
            set { BackingStore?.Set(nameof(SupersedingAppCount), value); }
        }
        /// <summary>The upload state.</summary>
        public int? UploadState {
            get { return BackingStore?.Get<int?>(nameof(UploadState)); }
            set { BackingStore?.Set(nameof(UploadState), value); }
        }
        /// <summary>The list of installation states for this mobile app.</summary>
        public List<UserAppInstallStatus> UserStatuses {
            get { return BackingStore?.Get<List<UserAppInstallStatus>>(nameof(UserStatuses)); }
            set { BackingStore?.Set(nameof(UserStatuses), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MobileApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.mobileApp" => new MobileApp(),
                _ => new MobileApp(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<MobileAppAssignment>(MobileAppAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"categories", n => { Categories = n.GetCollectionOfObjectValues<MobileAppCategory>(MobileAppCategory.CreateFromDiscriminatorValue).ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"dependentAppCount", n => { DependentAppCount = n.GetIntValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"developer", n => { Developer = n.GetStringValue(); } },
                {"deviceStatuses", n => { DeviceStatuses = n.GetCollectionOfObjectValues<MobileAppInstallStatus>(MobileAppInstallStatus.CreateFromDiscriminatorValue).ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"informationUrl", n => { InformationUrl = n.GetStringValue(); } },
                {"installSummary", n => { InstallSummary = n.GetObjectValue<MobileAppInstallSummary>(MobileAppInstallSummary.CreateFromDiscriminatorValue); } },
                {"isAssigned", n => { IsAssigned = n.GetBoolValue(); } },
                {"isFeatured", n => { IsFeatured = n.GetBoolValue(); } },
                {"largeIcon", n => { LargeIcon = n.GetObjectValue<MimeContent>(MimeContent.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"notes", n => { Notes = n.GetStringValue(); } },
                {"owner", n => { Owner = n.GetStringValue(); } },
                {"privacyInformationUrl", n => { PrivacyInformationUrl = n.GetStringValue(); } },
                {"publisher", n => { Publisher = n.GetStringValue(); } },
                {"publishingState", n => { PublishingState = n.GetEnumValue<MobileAppPublishingState>(); } },
                {"relationships", n => { Relationships = n.GetCollectionOfObjectValues<MobileAppRelationship>(MobileAppRelationship.CreateFromDiscriminatorValue).ToList(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"supersededAppCount", n => { SupersededAppCount = n.GetIntValue(); } },
                {"supersedingAppCount", n => { SupersedingAppCount = n.GetIntValue(); } },
                {"uploadState", n => { UploadState = n.GetIntValue(); } },
                {"userStatuses", n => { UserStatuses = n.GetCollectionOfObjectValues<UserAppInstallStatus>(UserAppInstallStatus.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<MobileAppAssignment>("assignments", Assignments);
            writer.WriteCollectionOfObjectValues<MobileAppCategory>("categories", Categories);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteIntValue("dependentAppCount", DependentAppCount);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("developer", Developer);
            writer.WriteCollectionOfObjectValues<MobileAppInstallStatus>("deviceStatuses", DeviceStatuses);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("informationUrl", InformationUrl);
            writer.WriteObjectValue<MobileAppInstallSummary>("installSummary", InstallSummary);
            writer.WriteBoolValue("isAssigned", IsAssigned);
            writer.WriteBoolValue("isFeatured", IsFeatured);
            writer.WriteObjectValue<MimeContent>("largeIcon", LargeIcon);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("notes", Notes);
            writer.WriteStringValue("owner", Owner);
            writer.WriteStringValue("privacyInformationUrl", PrivacyInformationUrl);
            writer.WriteStringValue("publisher", Publisher);
            writer.WriteEnumValue<MobileAppPublishingState>("publishingState", PublishingState);
            writer.WriteCollectionOfObjectValues<MobileAppRelationship>("relationships", Relationships);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteIntValue("supersededAppCount", SupersededAppCount);
            writer.WriteIntValue("supersedingAppCount", SupersedingAppCount);
            writer.WriteIntValue("uploadState", UploadState);
            writer.WriteCollectionOfObjectValues<UserAppInstallStatus>("userStatuses", UserStatuses);
        }
    }
}
