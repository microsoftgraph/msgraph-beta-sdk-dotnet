using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class PlannerTeamsPublicationInfo : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The date and time when this task was last modified by the publication process. Read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The identifier of the publication. Read-only.</summary>
        public string PublicationId { get; set; }
        /// <summary>The identifier of the plannerPlan this task was originally placed in. Read-only.</summary>
        public string PublishedToPlanId { get; set; }
        /// <summary>The identifier of the team that initiated the publication process. Read-only.</summary>
        public string PublishingTeamId { get; set; }
        /// <summary>The display name of the team that initiated the publication process. This display name is for reference only, and might not represent the most up-to-date name of the team. Read-only.</summary>
        public string PublishingTeamName { get; set; }
        /// <summary>
        /// Instantiates a new plannerTeamsPublicationInfo and sets the default values.
        /// </summary>
        public PlannerTeamsPublicationInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"lastModifiedDateTime", (o,n) => { (o as PlannerTeamsPublicationInfo).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"publicationId", (o,n) => { (o as PlannerTeamsPublicationInfo).PublicationId = n.GetStringValue(); } },
                {"publishedToPlanId", (o,n) => { (o as PlannerTeamsPublicationInfo).PublishedToPlanId = n.GetStringValue(); } },
                {"publishingTeamId", (o,n) => { (o as PlannerTeamsPublicationInfo).PublishingTeamId = n.GetStringValue(); } },
                {"publishingTeamName", (o,n) => { (o as PlannerTeamsPublicationInfo).PublishingTeamName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("publicationId", PublicationId);
            writer.WriteStringValue("publishedToPlanId", PublishedToPlanId);
            writer.WriteStringValue("publishingTeamId", PublishingTeamId);
            writer.WriteStringValue("publishingTeamName", PublishingTeamName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
