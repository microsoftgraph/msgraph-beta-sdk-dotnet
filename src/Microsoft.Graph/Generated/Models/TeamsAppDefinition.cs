using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class TeamsAppDefinition : Entity, IParsable {
        /// <summary>A collection of scopes where the Teams app can be installed. Possible values are:team — Indicates that the Teams app can be installed within a team and is authorized to access that team&apos;s data. groupChat  — Indicates that the Teams app can be installed within a group chat and is authorized to access that group chat&apos;s data.  personal — Indicates that the Teams app can be installed in the personal scope of a user and is authorized to access that user&apos;s data.</summary>
        public TeamsAppInstallationScopes? AllowedInstallationScopes {
            get { return BackingStore?.Get<TeamsAppInstallationScopes?>(nameof(AllowedInstallationScopes)); }
            set { BackingStore?.Set(nameof(AllowedInstallationScopes), value); }
        }
        /// <summary>The WebApplicationInfo.Id from the Teams app manifest.</summary>
        public string AzureADAppId {
            get { return BackingStore?.Get<string>(nameof(AzureADAppId)); }
            set { BackingStore?.Set(nameof(AzureADAppId), value); }
        }
        /// <summary>The details of the bot specified in the Teams app manifest.</summary>
        public TeamworkBot Bot {
            get { return BackingStore?.Get<TeamworkBot>(nameof(Bot)); }
            set { BackingStore?.Set(nameof(Bot), value); }
        }
        /// <summary>The color version of the Teams app&apos;s icon.</summary>
        public TeamsAppIcon ColorIcon {
            get { return BackingStore?.Get<TeamsAppIcon>(nameof(ColorIcon)); }
            set { BackingStore?.Set(nameof(ColorIcon), value); }
        }
        /// <summary>The createdBy property</summary>
        public IdentitySet CreatedBy {
            get { return BackingStore?.Get<IdentitySet>(nameof(CreatedBy)); }
            set { BackingStore?.Set(nameof(CreatedBy), value); }
        }
        /// <summary>Verbose description of the application.</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>The name of the app provided by the app developer.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>The outline version of the Teams app&apos;s icon.</summary>
        public TeamsAppIcon OutlineIcon {
            get { return BackingStore?.Get<TeamsAppIcon>(nameof(OutlineIcon)); }
            set { BackingStore?.Set(nameof(OutlineIcon), value); }
        }
        /// <summary>The published status of a specific version of a Teams app. Possible values are:submitted — The specific version of the Teams app has been submitted and is under review. published  — The request to publish the specific version of the Teams app has been approved by the admin and the app is published.  rejected — The request to publish the specific version of the Teams app was rejected by the admin.</summary>
        public TeamsAppPublishingState? PublishingState {
            get { return BackingStore?.Get<TeamsAppPublishingState?>(nameof(PublishingState)); }
            set { BackingStore?.Set(nameof(PublishingState), value); }
        }
        /// <summary>The shortdescription property</summary>
        public string Shortdescription {
            get { return BackingStore?.Get<string>(nameof(Shortdescription)); }
            set { BackingStore?.Set(nameof(Shortdescription), value); }
        }
        /// <summary>The ID from the Teams app manifest.</summary>
        public string TeamsAppId {
            get { return BackingStore?.Get<string>(nameof(TeamsAppId)); }
            set { BackingStore?.Set(nameof(TeamsAppId), value); }
        }
        /// <summary>The version number of the application.</summary>
        public string Version {
            get { return BackingStore?.Get<string>(nameof(Version)); }
            set { BackingStore?.Set(nameof(Version), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TeamsAppDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamsAppDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowedInstallationScopes", n => { AllowedInstallationScopes = n.GetEnumValue<TeamsAppInstallationScopes>(); } },
                {"azureADAppId", n => { AzureADAppId = n.GetStringValue(); } },
                {"bot", n => { Bot = n.GetObjectValue<TeamworkBot>(TeamworkBot.CreateFromDiscriminatorValue); } },
                {"colorIcon", n => { ColorIcon = n.GetObjectValue<TeamsAppIcon>(TeamsAppIcon.CreateFromDiscriminatorValue); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"outlineIcon", n => { OutlineIcon = n.GetObjectValue<TeamsAppIcon>(TeamsAppIcon.CreateFromDiscriminatorValue); } },
                {"publishingState", n => { PublishingState = n.GetEnumValue<TeamsAppPublishingState>(); } },
                {"shortdescription", n => { Shortdescription = n.GetStringValue(); } },
                {"teamsAppId", n => { TeamsAppId = n.GetStringValue(); } },
                {"version", n => { Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<TeamsAppInstallationScopes>("allowedInstallationScopes", AllowedInstallationScopes);
            writer.WriteStringValue("azureADAppId", AzureADAppId);
            writer.WriteObjectValue<TeamworkBot>("bot", Bot);
            writer.WriteObjectValue<TeamsAppIcon>("colorIcon", ColorIcon);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteObjectValue<TeamsAppIcon>("outlineIcon", OutlineIcon);
            writer.WriteEnumValue<TeamsAppPublishingState>("publishingState", PublishingState);
            writer.WriteStringValue("shortdescription", Shortdescription);
            writer.WriteStringValue("teamsAppId", TeamsAppId);
            writer.WriteStringValue("version", Version);
        }
    }
}
