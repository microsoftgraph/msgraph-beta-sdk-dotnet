using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PlannerTeamsPublicationInfo : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The date and time when this task was last modified by the publication process. Read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The identifier of the publication. Read-only.</summary>
        public string PublicationId {
            get { return BackingStore?.Get<string>("publicationId"); }
            set { BackingStore?.Set("publicationId", value); }
        }
        /// <summary>The identifier of the plannerPlan this task was originally placed in. Read-only.</summary>
        public string PublishedToPlanId {
            get { return BackingStore?.Get<string>("publishedToPlanId"); }
            set { BackingStore?.Set("publishedToPlanId", value); }
        }
        /// <summary>The identifier of the team that initiated the publication process. Read-only.</summary>
        public string PublishingTeamId {
            get { return BackingStore?.Get<string>("publishingTeamId"); }
            set { BackingStore?.Set("publishingTeamId", value); }
        }
        /// <summary>The display name of the team that initiated the publication process. This display name is for reference only, and might not represent the most up-to-date name of the team. Read-only.</summary>
        public string PublishingTeamName {
            get { return BackingStore?.Get<string>("publishingTeamName"); }
            set { BackingStore?.Set("publishingTeamName", value); }
        }
        /// <summary>
        /// Instantiates a new plannerTeamsPublicationInfo and sets the default values.
        /// </summary>
        public PlannerTeamsPublicationInfo() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.plannerTeamsPublicationInfo";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static PlannerTeamsPublicationInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlannerTeamsPublicationInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"publicationId", n => { PublicationId = n.GetStringValue(); } },
                {"publishedToPlanId", n => { PublishedToPlanId = n.GetStringValue(); } },
                {"publishingTeamId", n => { PublishingTeamId = n.GetStringValue(); } },
                {"publishingTeamName", n => { PublishingTeamName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("publicationId", PublicationId);
            writer.WriteStringValue("publishedToPlanId", PublishedToPlanId);
            writer.WriteStringValue("publishingTeamId", PublishingTeamId);
            writer.WriteStringValue("publishingTeamName", PublishingTeamName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
