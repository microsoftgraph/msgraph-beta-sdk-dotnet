using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class ProjectParticipation : ItemFacet, IParsable {
        /// <summary>Contains categories a user has associated with the project (for example, digital transformation, oil rig).</summary>
        public List<string> Categories { get; set; }
        /// <summary>Contains detailed information about the client the project was for.</summary>
        public CompanyDetail Client { get; set; }
        /// <summary>Contains experience scenario tags a user has associated with the interest. Allowed values in the collection are: askMeAbout, ableToMentor, wantsToLearn, wantsToImprove.</summary>
        public List<string> CollaborationTags { get; set; }
        /// <summary>Lists people that also worked on the project.</summary>
        public List<RelatedPerson> Colleagues { get; set; }
        /// <summary>Contains detail about the user's role on the project.</summary>
        public PositionDetail Detail { get; set; }
        /// <summary>Contains a friendly name for the project.</summary>
        public string DisplayName { get; set; }
        /// <summary>The Person or people who sponsored the project.</summary>
        public List<RelatedPerson> Sponsors { get; set; }
        public string ThumbnailUrl { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ProjectParticipation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProjectParticipation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"categories", (o,n) => { (o as ProjectParticipation).Categories = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"client", (o,n) => { (o as ProjectParticipation).Client = n.GetObjectValue<CompanyDetail>(CompanyDetail.CreateFromDiscriminatorValue); } },
                {"collaborationTags", (o,n) => { (o as ProjectParticipation).CollaborationTags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"colleagues", (o,n) => { (o as ProjectParticipation).Colleagues = n.GetCollectionOfObjectValues<RelatedPerson>(RelatedPerson.CreateFromDiscriminatorValue).ToList(); } },
                {"detail", (o,n) => { (o as ProjectParticipation).Detail = n.GetObjectValue<PositionDetail>(PositionDetail.CreateFromDiscriminatorValue); } },
                {"displayName", (o,n) => { (o as ProjectParticipation).DisplayName = n.GetStringValue(); } },
                {"sponsors", (o,n) => { (o as ProjectParticipation).Sponsors = n.GetCollectionOfObjectValues<RelatedPerson>(RelatedPerson.CreateFromDiscriminatorValue).ToList(); } },
                {"thumbnailUrl", (o,n) => { (o as ProjectParticipation).ThumbnailUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("categories", Categories);
            writer.WriteObjectValue<CompanyDetail>("client", Client);
            writer.WriteCollectionOfPrimitiveValues<string>("collaborationTags", CollaborationTags);
            writer.WriteCollectionOfObjectValues<RelatedPerson>("colleagues", Colleagues);
            writer.WriteObjectValue<PositionDetail>("detail", Detail);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<RelatedPerson>("sponsors", Sponsors);
            writer.WriteStringValue("thumbnailUrl", ThumbnailUrl);
        }
    }
}
