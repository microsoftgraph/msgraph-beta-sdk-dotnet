using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class TeamworkTag : Entity, IParsable {
        /// <summary>Tag description as it will appear to the user in Microsoft Teams.</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>Tag name as it will appear to the user in Microsoft Teams.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The number of users assigned to the tag.</summary>
        public int? MemberCount {
            get { return BackingStore?.Get<int?>("memberCount"); }
            set { BackingStore?.Set("memberCount", value); }
        }
        /// <summary>Users assigned to the tag.</summary>
        public List<TeamworkTagMember> Members {
            get { return BackingStore?.Get<List<TeamworkTagMember>>("members"); }
            set { BackingStore?.Set("members", value); }
        }
        /// <summary>The type of tag. Default is standard.</summary>
        public TeamworkTagType? TagType {
            get { return BackingStore?.Get<TeamworkTagType?>("tagType"); }
            set { BackingStore?.Set("tagType", value); }
        }
        /// <summary>ID of the team in which the tag is defined.</summary>
        public string TeamId {
            get { return BackingStore?.Get<string>("teamId"); }
            set { BackingStore?.Set("teamId", value); }
        }
        /// <summary>
        /// Instantiates a new teamworkTag and sets the default values.
        /// </summary>
        public TeamworkTag() : base() {
            OdataType = "#microsoft.graph.teamworkTag";
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"memberCount", n => { MemberCount = n.GetIntValue(); } },
                {"members", n => { Members = n.GetCollectionOfObjectValues<TeamworkTagMember>(TeamworkTagMember.CreateFromDiscriminatorValue)?.ToList(); } },
                {"tagType", n => { TagType = n.GetEnumValue<TeamworkTagType>(); } },
                {"teamId", n => { TeamId = n.GetStringValue(); } },
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
