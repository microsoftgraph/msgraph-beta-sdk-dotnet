using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkTag : Entity, IParsable {
        /// <summary>Tag description as it will appear to the user in Microsoft Teams.</summary>
        public string Description { get; set; }
        /// <summary>Tag name as it will appear to the user in Microsoft Teams.</summary>
        public string DisplayName { get; set; }
        /// <summary>The number of users assigned to the tag.</summary>
        public int? MemberCount { get; set; }
        /// <summary>Users assigned to the tag.</summary>
        public List<TeamworkTagMember> Members { get; set; }
        /// <summary>The type of tag. Default is standard.</summary>
        public TeamworkTagType? TagType { get; set; }
        /// <summary>ID of the team in which the tag is defined.</summary>
        public string TeamId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TeamworkTag CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkTag();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"description", (o,n) => { (o as TeamworkTag).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as TeamworkTag).DisplayName = n.GetStringValue(); } },
                {"memberCount", (o,n) => { (o as TeamworkTag).MemberCount = n.GetIntValue(); } },
                {"members", (o,n) => { (o as TeamworkTag).Members = n.GetCollectionOfObjectValues<TeamworkTagMember>(TeamworkTagMember.CreateFromDiscriminatorValue).ToList(); } },
                {"tagType", (o,n) => { (o as TeamworkTag).TagType = n.GetEnumValue<TeamworkTagType>(); } },
                {"teamId", (o,n) => { (o as TeamworkTag).TeamId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteIntValue("memberCount", MemberCount);
            writer.WriteCollectionOfObjectValues<TeamworkTagMember>("members", Members);
            writer.WriteEnumValue<TeamworkTagType>("tagType", TagType);
            writer.WriteStringValue("teamId", TeamId);
        }
    }
}
