using Microsoft.Graph.Beta.Models;
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
            get { return BackingStore?.Get<List<MobileAppAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
        /// <summary>The list of categories for this app.</summary>
        public List<MobileAppCategory> Categories {
            get { return BackingStore?.Get<List<MobileAppCategory>>("categories"); }
            set { BackingStore?.Set("categories", value); }
        }
        /// <summary>The date and time the app was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The total number of dependencies the child app has.</summary>
        public int? DependentAppCount {
            get { return BackingStore?.Get<int?>("dependentAppCount"); }
            set { BackingStore?.Set("dependentAppCount", value); }
        }
        /// <summary>The description of the app.</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>The developer of the app.</summary>
        public string Developer {
            get { return BackingStore?.Get<string>("developer"); }
            set { BackingStore?.Set("developer", value); }
        }
        /// <summary>The list of installation states for this mobile app.</summary>
        public List<MobileAppInstallStatus> DeviceStatuses {
            get { return BackingStore?.Get<List<MobileAppInstallStatus>>("deviceStatuses"); }
            set { BackingStore?.Set("deviceStatuses", value); }
        }
        /// <summary>The admin provided or imported title of the app.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The more information Url.</summary>
        public string InformationUrl {
            get { return BackingStore?.Get<string>("informationUrl"); }
            set { BackingStore?.Set("informationUrl", value); }
        }
        /// <summary>Mobile App Install Summary.</summary>
        public MobileAppInstallSummary InstallSummary {
            get { return BackingStore?.Get<MobileAppInstallSummary>("installSummary"); }
            set { BackingStore?.Set("installSummary", value); }
        }
        /// <summary>The value indicating whether the app is assigned to at least one group.</summary>
        public bool? IsAssigned {
            get { return BackingStore?.Get<bool?>("isAssigned"); }
            set { BackingStore?.Set("isAssigned", value); }
        }
        /// <summary>The value indicating whether the app is marked as featured by the admin.</summary>
        public bool? IsFeatured {
            get { return BackingStore?.Get<bool?>("isFeatured"); }
            set { BackingStore?.Set("isFeatured", value); }
        }
        /// <summary>The large icon, to be displayed in the app details and used for upload of the icon.</summary>
        public MimeContent LargeIcon {
            get { return BackingStore?.Get<MimeContent>("largeIcon"); }
            set { BackingStore?.Set("largeIcon", value); }
        }
        /// <summary>The date and time the app was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Notes for the app.</summary>
        public string Notes {
            get { return BackingStore?.Get<string>("notes"); }
            set { BackingStore?.Set("notes", value); }
        }
        /// <summary>The owner of the app.</summary>
        public string Owner {
            get { return BackingStore?.Get<string>("owner"); }
            set { BackingStore?.Set("owner", value); }
        }
        /// <summary>The privacy statement Url.</summary>
        public string PrivacyInformationUrl {
            get { return BackingStore?.Get<string>("privacyInformationUrl"); }
            set { BackingStore?.Set("privacyInformationUrl", value); }
        }
        /// <summary>The publisher of the app.</summary>
        public string Publisher {
            get { return BackingStore?.Get<string>("publisher"); }
            set { BackingStore?.Set("publisher", value); }
        }
        /// <summary>Indicates the publishing state of an app.</summary>
        public MobileAppPublishingState? PublishingState {
            get { return BackingStore?.Get<MobileAppPublishingState?>("publishingState"); }
            set { BackingStore?.Set("publishingState", value); }
        }
        /// <summary>List of relationships for this mobile app.</summary>
        public List<MobileAppRelationship> Relationships {
            get { return BackingStore?.Get<List<MobileAppRelationship>>("relationships"); }
            set { BackingStore?.Set("relationships", value); }
        }
        /// <summary>List of scope tag ids for this mobile app.</summary>
        public List<string> RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
        /// <summary>The total number of apps this app is directly or indirectly superseded by.</summary>
        public int? SupersededAppCount {
            get { return BackingStore?.Get<int?>("supersededAppCount"); }
            set { BackingStore?.Set("supersededAppCount", value); }
        }
        /// <summary>The total number of apps this app directly or indirectly supersedes.</summary>
        public int? SupersedingAppCount {
            get { return BackingStore?.Get<int?>("supersedingAppCount"); }
            set { BackingStore?.Set("supersedingAppCount", value); }
        }
        /// <summary>The upload state.</summary>
        public int? UploadState {
            get { return BackingStore?.Get<int?>("uploadState"); }
            set { BackingStore?.Set("uploadState", value); }
        }
        /// <summary>The list of installation states for this mobile app.</summary>
        public List<UserAppInstallStatus> UserStatuses {
            get { return BackingStore?.Get<List<UserAppInstallStatus>>("userStatuses"); }
            set { BackingStore?.Set("userStatuses", value); }
        }
        /// <summary>
        /// Instantiates a new mobileApp and sets the default values.
        /// </summary>
        public MobileApp() : base() {
            Type = "#microsoft.graph.mobileApp";
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
                "#microsoft.graph.androidForWorkApp" => new AndroidForWorkApp(),
                "#microsoft.graph.androidManagedStoreApp" => new AndroidManagedStoreApp(),
                "#microsoft.graph.androidStoreApp" => new AndroidStoreApp(),
                "#microsoft.graph.iosiPadOSWebClip" => new IosiPadOSWebClip(),
                "#microsoft.graph.iosStoreApp" => new IosStoreApp(),
                "#microsoft.graph.iosVppApp" => new IosVppApp(),
                "#microsoft.graph.macOSMdatpApp" => new MacOSMdatpApp(),
                "#microsoft.graph.macOSMicrosoftEdgeApp" => new MacOSMicrosoftEdgeApp(),
                "#microsoft.graph.macOSOfficeSuiteApp" => new MacOSOfficeSuiteApp(),
                "#microsoft.graph.macOsVppApp" => new MacOsVppApp(),
                "#microsoft.graph.managedApp" => new ManagedApp(),
                "#microsoft.graph.microsoftStoreForBusinessApp" => new MicrosoftStoreForBusinessApp(),
                "#microsoft.graph.mobileLobApp" => new MobileLobApp(),
                "#microsoft.graph.officeSuiteApp" => new OfficeSuiteApp(),
                "#microsoft.graph.webApp" => new WebApp(),
                "#microsoft.graph.windowsMicrosoftEdgeApp" => new WindowsMicrosoftEdgeApp(),
                "#microsoft.graph.windowsPhone81StoreApp" => new WindowsPhone81StoreApp(),
                "#microsoft.graph.windowsStoreApp" => new WindowsStoreApp(),
                "#microsoft.graph.windowsWebApp" => new WindowsWebApp(),
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
