using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceAppManagement singleton.</summary>
    public class MobileApp : Entity, IParsable {
        /// <summary>The list of group assignments for this mobile app.</summary>
        public List<MobileAppAssignment> Assignments { get; set; }
        /// <summary>The list of categories for this app.</summary>
        public List<MobileAppCategory> Categories { get; set; }
        /// <summary>The date and time the app was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The total number of dependencies the child app has.</summary>
        public int? DependentAppCount { get; set; }
        /// <summary>The description of the app.</summary>
        public string Description { get; set; }
        /// <summary>The developer of the app.</summary>
        public string Developer { get; set; }
        /// <summary>The list of installation states for this mobile app.</summary>
        public List<MobileAppInstallStatus> DeviceStatuses { get; set; }
        /// <summary>The admin provided or imported title of the app.</summary>
        public string DisplayName { get; set; }
        /// <summary>The more information Url.</summary>
        public string InformationUrl { get; set; }
        /// <summary>Mobile App Install Summary.</summary>
        public MobileAppInstallSummary InstallSummary { get; set; }
        /// <summary>The value indicating whether the app is assigned to at least one group.</summary>
        public bool? IsAssigned { get; set; }
        /// <summary>The value indicating whether the app is marked as featured by the admin.</summary>
        public bool? IsFeatured { get; set; }
        /// <summary>The large icon, to be displayed in the app details and used for upload of the icon.</summary>
        public MimeContent LargeIcon { get; set; }
        /// <summary>The date and time the app was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Notes for the app.</summary>
        public string Notes { get; set; }
        /// <summary>The owner of the app.</summary>
        public string Owner { get; set; }
        /// <summary>The privacy statement Url.</summary>
        public string PrivacyInformationUrl { get; set; }
        /// <summary>The publisher of the app.</summary>
        public string Publisher { get; set; }
        /// <summary>The publishing state for the app. The app cannot be assigned unless the app is published. Possible values are: notPublished, processing, published.</summary>
        public MobileAppPublishingState? PublishingState { get; set; }
        /// <summary>List of relationships for this mobile app.</summary>
        public List<MobileAppRelationship> Relationships { get; set; }
        /// <summary>List of scope tag ids for this mobile app.</summary>
        public List<string> RoleScopeTagIds { get; set; }
        /// <summary>The total number of apps this app is directly or indirectly superseded by.</summary>
        public int? SupersededAppCount { get; set; }
        /// <summary>The total number of apps this app directly or indirectly supersedes.</summary>
        public int? SupersedingAppCount { get; set; }
        /// <summary>The upload state.</summary>
        public int? UploadState { get; set; }
        /// <summary>The list of installation states for this mobile app.</summary>
        public List<UserAppInstallStatus> UserStatuses { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MobileApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MobileApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignments", (o,n) => { (o as MobileApp).Assignments = n.GetCollectionOfObjectValues<MobileAppAssignment>(MobileAppAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"categories", (o,n) => { (o as MobileApp).Categories = n.GetCollectionOfObjectValues<MobileAppCategory>(MobileAppCategory.CreateFromDiscriminatorValue).ToList(); } },
                {"createdDateTime", (o,n) => { (o as MobileApp).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"dependentAppCount", (o,n) => { (o as MobileApp).DependentAppCount = n.GetIntValue(); } },
                {"description", (o,n) => { (o as MobileApp).Description = n.GetStringValue(); } },
                {"developer", (o,n) => { (o as MobileApp).Developer = n.GetStringValue(); } },
                {"deviceStatuses", (o,n) => { (o as MobileApp).DeviceStatuses = n.GetCollectionOfObjectValues<MobileAppInstallStatus>(MobileAppInstallStatus.CreateFromDiscriminatorValue).ToList(); } },
                {"displayName", (o,n) => { (o as MobileApp).DisplayName = n.GetStringValue(); } },
                {"informationUrl", (o,n) => { (o as MobileApp).InformationUrl = n.GetStringValue(); } },
                {"installSummary", (o,n) => { (o as MobileApp).InstallSummary = n.GetObjectValue<MobileAppInstallSummary>(MobileAppInstallSummary.CreateFromDiscriminatorValue); } },
                {"isAssigned", (o,n) => { (o as MobileApp).IsAssigned = n.GetBoolValue(); } },
                {"isFeatured", (o,n) => { (o as MobileApp).IsFeatured = n.GetBoolValue(); } },
                {"largeIcon", (o,n) => { (o as MobileApp).LargeIcon = n.GetObjectValue<MimeContent>(MimeContent.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", (o,n) => { (o as MobileApp).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"notes", (o,n) => { (o as MobileApp).Notes = n.GetStringValue(); } },
                {"owner", (o,n) => { (o as MobileApp).Owner = n.GetStringValue(); } },
                {"privacyInformationUrl", (o,n) => { (o as MobileApp).PrivacyInformationUrl = n.GetStringValue(); } },
                {"publisher", (o,n) => { (o as MobileApp).Publisher = n.GetStringValue(); } },
                {"publishingState", (o,n) => { (o as MobileApp).PublishingState = n.GetEnumValue<MobileAppPublishingState>(); } },
                {"relationships", (o,n) => { (o as MobileApp).Relationships = n.GetCollectionOfObjectValues<MobileAppRelationship>(MobileAppRelationship.CreateFromDiscriminatorValue).ToList(); } },
                {"roleScopeTagIds", (o,n) => { (o as MobileApp).RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"supersededAppCount", (o,n) => { (o as MobileApp).SupersededAppCount = n.GetIntValue(); } },
                {"supersedingAppCount", (o,n) => { (o as MobileApp).SupersedingAppCount = n.GetIntValue(); } },
                {"uploadState", (o,n) => { (o as MobileApp).UploadState = n.GetIntValue(); } },
                {"userStatuses", (o,n) => { (o as MobileApp).UserStatuses = n.GetCollectionOfObjectValues<UserAppInstallStatus>(UserAppInstallStatus.CreateFromDiscriminatorValue).ToList(); } },
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
