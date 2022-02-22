using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
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
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"categories", (o,n) => { (o as ProjectParticipation).Categories = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"client", (o,n) => { (o as ProjectParticipation).Client = n.GetObjectValue<CompanyDetail>(); } },
                {"collaborationTags", (o,n) => { (o as ProjectParticipation).CollaborationTags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"colleagues", (o,n) => { (o as ProjectParticipation).Colleagues = n.GetCollectionOfObjectValues<RelatedPerson>().ToList(); } },
                {"detail", (o,n) => { (o as ProjectParticipation).Detail = n.GetObjectValue<PositionDetail>(); } },
                {"displayName", (o,n) => { (o as ProjectParticipation).DisplayName = n.GetStringValue(); } },
                {"sponsors", (o,n) => { (o as ProjectParticipation).Sponsors = n.GetCollectionOfObjectValues<RelatedPerson>().ToList(); } },
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
