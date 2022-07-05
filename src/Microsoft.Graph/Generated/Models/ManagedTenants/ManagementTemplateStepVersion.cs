using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class ManagementTemplateStepVersion : Entity, IParsable {
        /// <summary>The acceptedFor property</summary>
        public ManagementTemplateStep AcceptedFor {
            get { return BackingStore?.Get<ManagementTemplateStep>(nameof(AcceptedFor)); }
            set { BackingStore?.Set(nameof(AcceptedFor), value); }
        }
        /// <summary>The contentMarkdown property</summary>
        public string ContentMarkdown {
            get { return BackingStore?.Get<string>(nameof(ContentMarkdown)); }
            set { BackingStore?.Set(nameof(ContentMarkdown), value); }
        }
        /// <summary>The createdByUserId property</summary>
        public string CreatedByUserId {
            get { return BackingStore?.Get<string>(nameof(CreatedByUserId)); }
            set { BackingStore?.Set(nameof(CreatedByUserId), value); }
        }
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>The deployments property</summary>
        public List<ManagementTemplateStepDeployment> Deployments {
            get { return BackingStore?.Get<List<ManagementTemplateStepDeployment>>(nameof(Deployments)); }
            set { BackingStore?.Set(nameof(Deployments), value); }
        }
        /// <summary>The lastActionByUserId property</summary>
        public string LastActionByUserId {
            get { return BackingStore?.Get<string>(nameof(LastActionByUserId)); }
            set { BackingStore?.Set(nameof(LastActionByUserId), value); }
        }
        /// <summary>The lastActionDateTime property</summary>
        public DateTimeOffset? LastActionDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastActionDateTime)); }
            set { BackingStore?.Set(nameof(LastActionDateTime), value); }
        }
        /// <summary>The name property</summary>
        public string Name {
            get { return BackingStore?.Get<string>(nameof(Name)); }
            set { BackingStore?.Set(nameof(Name), value); }
        }
        /// <summary>The templateStep property</summary>
        public ManagementTemplateStep TemplateStep {
            get { return BackingStore?.Get<ManagementTemplateStep>(nameof(TemplateStep)); }
            set { BackingStore?.Set(nameof(TemplateStep), value); }
        }
        /// <summary>The version property</summary>
        public int? Version {
            get { return BackingStore?.Get<int?>(nameof(Version)); }
            set { BackingStore?.Set(nameof(Version), value); }
        }
        /// <summary>The versionInformation property</summary>
        public string VersionInformation {
            get { return BackingStore?.Get<string>(nameof(VersionInformation)); }
            set { BackingStore?.Set(nameof(VersionInformation), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ManagementTemplateStepVersion CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagementTemplateStepVersion();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"acceptedFor", n => { AcceptedFor = n.GetObjectValue<ManagementTemplateStep>(ManagementTemplateStep.CreateFromDiscriminatorValue); } },
                {"contentMarkdown", n => { ContentMarkdown = n.GetStringValue(); } },
                {"createdByUserId", n => { CreatedByUserId = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deployments", n => { Deployments = n.GetCollectionOfObjectValues<ManagementTemplateStepDeployment>(ManagementTemplateStepDeployment.CreateFromDiscriminatorValue).ToList(); } },
                {"lastActionByUserId", n => { LastActionByUserId = n.GetStringValue(); } },
                {"lastActionDateTime", n => { LastActionDateTime = n.GetDateTimeOffsetValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"templateStep", n => { TemplateStep = n.GetObjectValue<ManagementTemplateStep>(ManagementTemplateStep.CreateFromDiscriminatorValue); } },
                {"version", n => { Version = n.GetIntValue(); } },
                {"versionInformation", n => { VersionInformation = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ManagementTemplateStep>("acceptedFor", AcceptedFor);
            writer.WriteStringValue("contentMarkdown", ContentMarkdown);
            writer.WriteStringValue("createdByUserId", CreatedByUserId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<ManagementTemplateStepDeployment>("deployments", Deployments);
            writer.WriteStringValue("lastActionByUserId", LastActionByUserId);
            writer.WriteDateTimeOffsetValue("lastActionDateTime", LastActionDateTime);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<ManagementTemplateStep>("templateStep", TemplateStep);
            writer.WriteIntValue("version", Version);
            writer.WriteStringValue("versionInformation", VersionInformation);
        }
    }
}
