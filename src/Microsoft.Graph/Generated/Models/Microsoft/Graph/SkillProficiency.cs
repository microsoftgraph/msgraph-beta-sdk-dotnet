using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class SkillProficiency : ItemFacet, IParsable {
        /// <summary>Contains categories a user has associated with the skill (for example, personal, professional, hobby).</summary>
        public List<string> Categories { get; set; }
        /// <summary>Contains experience scenario tags a user has associated with the interest. Allowed values in the collection are: askMeAbout, ableToMentor, wantsToLearn, wantsToImprove.</summary>
        public List<string> CollaborationTags { get; set; }
        /// <summary>Contains a friendly name for the skill.</summary>
        public string DisplayName { get; set; }
        /// <summary>Detail of the users proficiency with this skill. Possible values are: elementary, limitedWorking, generalProfessional, advancedProfessional, expert, unknownFutureValue.</summary>
        public SkillProficiencyLevel? Proficiency { get; set; }
        public string ThumbnailUrl { get; set; }
        /// <summary>Contains a link to an information source about the skill.</summary>
        public string WebUrl { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"categories", (o,n) => { (o as SkillProficiency).Categories = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"collaborationTags", (o,n) => { (o as SkillProficiency).CollaborationTags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"displayName", (o,n) => { (o as SkillProficiency).DisplayName = n.GetStringValue(); } },
                {"proficiency", (o,n) => { (o as SkillProficiency).Proficiency = n.GetEnumValue<SkillProficiencyLevel>(); } },
                {"thumbnailUrl", (o,n) => { (o as SkillProficiency).ThumbnailUrl = n.GetStringValue(); } },
                {"webUrl", (o,n) => { (o as SkillProficiency).WebUrl = n.GetStringValue(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("collaborationTags", CollaborationTags);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<SkillProficiencyLevel>("proficiency", Proficiency);
            writer.WriteStringValue("thumbnailUrl", ThumbnailUrl);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
