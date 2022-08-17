using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class OrganizationalMessageDetail : Entity, IParsable {
        /// <summary>The content that will be displayed to clients for the message. This includes the text portion of the message and the displayed logo</summary>
        public OrganizationalMessageContent Content {
            get { return BackingStore?.Get<OrganizationalMessageContent>("content"); }
            set { BackingStore?.Set("content", value); }
        }
        /// <summary>The date and time of when the message was created</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The date and time of when the message will stop being displayed to clients</summary>
        public DateTimeOffset? EndDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("endDateTime"); }
            set { BackingStore?.Set("endDateTime", value); }
        }
        /// <summary>The frequency at which a client will see the message. Possible values are: weeklyOnce, monthlyOnce, monthlyTwice.</summary>
        public OrganizationalMessageFrequency? Frequency {
            get { return BackingStore?.Get<OrganizationalMessageFrequency?>("frequency"); }
            set { BackingStore?.Set("frequency", value); }
        }
        /// <summary>The date and time of when the message was last modified</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Indicates the scenario for the message. Possible values are: onboarding, lifecycle.</summary>
        public OrganizationalMessageScenario? Scenario {
            get { return BackingStore?.Get<OrganizationalMessageScenario?>("scenario"); }
            set { BackingStore?.Set("scenario", value); }
        }
        /// <summary>The date and time of when the message will start being displayed to clients</summary>
        public DateTimeOffset? StartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>Indicates the deployment status of the message. Possible values are: scheduled, active, completed, cancelled.</summary>
        public OrganizationalMessageStatus? Status {
            get { return BackingStore?.Get<OrganizationalMessageStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>Indicates the area where content will be displayed to customers. Possible values are: actionCenter, getStarted, softLanding.</summary>
        public OrganizationalMessageSurface? Surface {
            get { return BackingStore?.Get<OrganizationalMessageSurface?>("surface"); }
            set { BackingStore?.Set("surface", value); }
        }
        /// <summary>The groups of devices that will receive the message. This also contains a list of excluded groups that will not receive the message regardless of the device being part of an included group</summary>
        public OrganizationalMessageTargeting Targeting {
            get { return BackingStore?.Get<OrganizationalMessageTargeting>("targeting"); }
            set { BackingStore?.Set("targeting", value); }
        }
        /// <summary>Indicates the theme for the experience. Possible values are: update, training, welcomeToWindows.</summary>
        public OrganizationalMessageTheme? Theme {
            get { return BackingStore?.Get<OrganizationalMessageTheme?>("theme"); }
            set { BackingStore?.Set("theme", value); }
        }
        /// <summary>The statistics containing how the message was interacted with by clients. This includes the number of impressions, clicks, and dismisses from targeted clients.</summary>
        public OrganizationalMessageInsights UserEngagementStatistics {
            get { return BackingStore?.Get<OrganizationalMessageInsights>("userEngagementStatistics"); }
            set { BackingStore?.Set("userEngagementStatistics", value); }
        }
        /// <summary>Indicates the corresponding variant for the experience</summary>
        public string Variant {
            get { return BackingStore?.Get<string>("variant"); }
            set { BackingStore?.Set("variant", value); }
        }
        /// <summary>
        /// Instantiates a new OrganizationalMessageDetail and sets the default values.
        /// </summary>
        public OrganizationalMessageDetail() : base() {
            OdataType = "#microsoft.graph.organizationalMessageDetail";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new OrganizationalMessageDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OrganizationalMessageDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"content", n => { Content = n.GetObjectValue<OrganizationalMessageContent>(OrganizationalMessageContent.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"frequency", n => { Frequency = n.GetEnumValue<OrganizationalMessageFrequency>(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"scenario", n => { Scenario = n.GetEnumValue<OrganizationalMessageScenario>(); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", n => { Status = n.GetEnumValue<OrganizationalMessageStatus>(); } },
                {"surface", n => { Surface = n.GetEnumValue<OrganizationalMessageSurface>(); } },
                {"targeting", n => { Targeting = n.GetObjectValue<OrganizationalMessageTargeting>(OrganizationalMessageTargeting.CreateFromDiscriminatorValue); } },
                {"theme", n => { Theme = n.GetEnumValue<OrganizationalMessageTheme>(); } },
                {"userEngagementStatistics", n => { UserEngagementStatistics = n.GetObjectValue<OrganizationalMessageInsights>(OrganizationalMessageInsights.CreateFromDiscriminatorValue); } },
                {"variant", n => { Variant = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<OrganizationalMessageContent>("content", Content);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteEnumValue<OrganizationalMessageFrequency>("frequency", Frequency);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteEnumValue<OrganizationalMessageScenario>("scenario", Scenario);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteEnumValue<OrganizationalMessageStatus>("status", Status);
            writer.WriteEnumValue<OrganizationalMessageSurface>("surface", Surface);
            writer.WriteObjectValue<OrganizationalMessageTargeting>("targeting", Targeting);
            writer.WriteEnumValue<OrganizationalMessageTheme>("theme", Theme);
            writer.WriteObjectValue<OrganizationalMessageInsights>("userEngagementStatistics", UserEngagementStatistics);
            writer.WriteStringValue("variant", Variant);
        }
    }
}
