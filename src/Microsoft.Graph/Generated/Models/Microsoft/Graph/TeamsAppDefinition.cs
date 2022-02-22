using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class TeamsAppDefinition : Entity, IParsable {
        /// <summary>A collection of scopes where the Teams app can be installed. Possible values are:team — Indicates that the Teams app can be installed within a team and is authorized to access that team's data. groupChat  — Indicates that the Teams app can be installed within a group chat and is authorized to access that group chat's data.  personal — Indicates that the Teams app can be installed in the personal scope of a user and is authorized to access that user's data.</summary>
        public TeamsAppInstallationScopes? AllowedInstallationScopes { get; set; }
        /// <summary>The WebApplicationInfo.Id from the Teams app manifest.</summary>
        public string AzureADAppId { get; set; }
        /// <summary>The details of the bot specified in the Teams app manifest.</summary>
        public TeamworkBot Bot { get; set; }
        /// <summary>The color version of the Teams app's icon.</summary>
        public TeamsAppIcon ColorIcon { get; set; }
        public IdentitySet CreatedBy { get; set; }
        /// <summary>Verbose description of the application.</summary>
        public string Description { get; set; }
        /// <summary>The name of the app provided by the app developer.</summary>
        public string DisplayName { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The outline version of the Teams app's icon.</summary>
        public TeamsAppIcon OutlineIcon { get; set; }
        /// <summary>The published status of a specific version of a Teams app. Possible values are:submitted — The specific version of the Teams app has been submitted and is under review. published  — The request to publish the specific version of the Teams app has been approved by the admin and the app is published.  rejected — The request to publish the specific version of the Teams app was rejected by the admin.</summary>
        public TeamsAppPublishingState? PublishingState { get; set; }
        public string Shortdescription { get; set; }
        /// <summary>The ID from the Teams app manifest.</summary>
        public string TeamsAppId { get; set; }
        /// <summary>The version number of the application.</summary>
        public string Version { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"allowedInstallationScopes", (o,n) => { (o as TeamsAppDefinition).AllowedInstallationScopes = n.GetEnumValue<TeamsAppInstallationScopes>(); } },
                {"azureADAppId", (o,n) => { (o as TeamsAppDefinition).AzureADAppId = n.GetStringValue(); } },
                {"bot", (o,n) => { (o as TeamsAppDefinition).Bot = n.GetObjectValue<TeamworkBot>(); } },
                {"colorIcon", (o,n) => { (o as TeamsAppDefinition).ColorIcon = n.GetObjectValue<TeamsAppIcon>(); } },
                {"createdBy", (o,n) => { (o as TeamsAppDefinition).CreatedBy = n.GetObjectValue<IdentitySet>(); } },
                {"description", (o,n) => { (o as TeamsAppDefinition).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as TeamsAppDefinition).DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as TeamsAppDefinition).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"outlineIcon", (o,n) => { (o as TeamsAppDefinition).OutlineIcon = n.GetObjectValue<TeamsAppIcon>(); } },
                {"publishingState", (o,n) => { (o as TeamsAppDefinition).PublishingState = n.GetEnumValue<TeamsAppPublishingState>(); } },
                {"shortdescription", (o,n) => { (o as TeamsAppDefinition).Shortdescription = n.GetStringValue(); } },
                {"teamsAppId", (o,n) => { (o as TeamsAppDefinition).TeamsAppId = n.GetStringValue(); } },
                {"version", (o,n) => { (o as TeamsAppDefinition).Version = n.GetStringValue(); } },
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
