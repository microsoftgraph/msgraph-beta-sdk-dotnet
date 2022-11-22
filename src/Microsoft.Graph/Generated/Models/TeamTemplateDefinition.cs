using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeamTemplateDefinition : Entity, IParsable {
        /// <summary>The audience property</summary>
        public TeamTemplateAudience? Audience {
            get { return BackingStore?.Get<TeamTemplateAudience?>("audience"); }
            set { BackingStore?.Set("audience", value); }
        }
        /// <summary>The categories property</summary>
        public List<string> Categories {
            get { return BackingStore?.Get<List<string>>("categories"); }
            set { BackingStore?.Set("categories", value); }
        }
        /// <summary>The description property</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>The displayName property</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The iconUrl property</summary>
        public string IconUrl {
            get { return BackingStore?.Get<string>("iconUrl"); }
            set { BackingStore?.Set("iconUrl", value); }
        }
        /// <summary>The languageTag property</summary>
        public string LanguageTag {
            get { return BackingStore?.Get<string>("languageTag"); }
            set { BackingStore?.Set("languageTag", value); }
        }
        /// <summary>The lastModifiedBy property</summary>
        public IdentitySet LastModifiedBy {
            get { return BackingStore?.Get<IdentitySet>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The parentTemplateId property</summary>
        public string ParentTemplateId {
            get { return BackingStore?.Get<string>("parentTemplateId"); }
            set { BackingStore?.Set("parentTemplateId", value); }
        }
        /// <summary>The publisherName property</summary>
        public string PublisherName {
            get { return BackingStore?.Get<string>("publisherName"); }
            set { BackingStore?.Set("publisherName", value); }
        }
        /// <summary>The shortDescription property</summary>
        public string ShortDescription {
            get { return BackingStore?.Get<string>("shortDescription"); }
            set { BackingStore?.Set("shortDescription", value); }
        }
        /// <summary>The teamDefinition property</summary>
        public Team TeamDefinition {
            get { return BackingStore?.Get<Team>("teamDefinition"); }
            set { BackingStore?.Set("teamDefinition", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TeamTemplateDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamTemplateDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"audience", n => { Audience = n.GetEnumValue<TeamTemplateAudience>(); } },
                {"categories", n => { Categories = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"iconUrl", n => { IconUrl = n.GetStringValue(); } },
                {"languageTag", n => { LanguageTag = n.GetStringValue(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"parentTemplateId", n => { ParentTemplateId = n.GetStringValue(); } },
                {"publisherName", n => { PublisherName = n.GetStringValue(); } },
                {"shortDescription", n => { ShortDescription = n.GetStringValue(); } },
                {"teamDefinition", n => { TeamDefinition = n.GetObjectValue<Team>(Team.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<TeamTemplateAudience>("audience", Audience);
            writer.WriteCollectionOfPrimitiveValues<string>("categories", Categories);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("iconUrl", IconUrl);
            writer.WriteStringValue("languageTag", LanguageTag);
            writer.WriteObjectValue<IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("parentTemplateId", ParentTemplateId);
            writer.WriteStringValue("publisherName", PublisherName);
            writer.WriteStringValue("shortDescription", ShortDescription);
            writer.WriteObjectValue<Team>("teamDefinition", TeamDefinition);
        }
    }
}
