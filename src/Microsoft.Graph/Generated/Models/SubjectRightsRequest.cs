using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the security singleton.</summary>
    public class SubjectRightsRequest : Entity, IParsable {
        /// <summary>Identity that the request is assigned to.</summary>
        public Identity AssignedTo {
            get { return BackingStore?.Get<Identity>(nameof(AssignedTo)); }
            set { BackingStore?.Set(nameof(AssignedTo), value); }
        }
        /// <summary>The date and time when the request was closed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? ClosedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ClosedDateTime)); }
            set { BackingStore?.Set(nameof(ClosedDateTime), value); }
        }
        /// <summary>KQL based content query that should be used for search. This property is defined only for APIs accessed using the /security query path and not the /privacy query path.</summary>
        public string ContentQuery {
            get { return BackingStore?.Get<string>(nameof(ContentQuery)); }
            set { BackingStore?.Set(nameof(ContentQuery), value); }
        }
        /// <summary>Identity information for the entity that created the request.</summary>
        public IdentitySet CreatedBy {
            get { return BackingStore?.Get<IdentitySet>(nameof(CreatedBy)); }
            set { BackingStore?.Set(nameof(CreatedBy), value); }
        }
        /// <summary>The date and time when the request was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>Information about the data subject.</summary>
        public Microsoft.Graph.Beta.Models.DataSubject DataSubject {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DataSubject>(nameof(DataSubject)); }
            set { BackingStore?.Set(nameof(DataSubject), value); }
        }
        /// <summary>The type of the data subject. Possible values are: customer, currentEmployee, formerEmployee, prospectiveEmployee, student, teacher, faculty, other, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.DataSubjectType? DataSubjectType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DataSubjectType?>(nameof(DataSubjectType)); }
            set { BackingStore?.Set(nameof(DataSubjectType), value); }
        }
        /// <summary>Description for the request.</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>The name of the request.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The external ID for the request that is immutable after creation and is used for tracking the request for the external system. This property is defined only for APIs accessed using the /security query path and not the /privacy query path.</summary>
        public string ExternalId {
            get { return BackingStore?.Get<string>(nameof(ExternalId)); }
            set { BackingStore?.Set(nameof(ExternalId), value); }
        }
        /// <summary>Collection of history change events.</summary>
        public List<SubjectRightsRequestHistory> History {
            get { return BackingStore?.Get<List<SubjectRightsRequestHistory>>(nameof(History)); }
            set { BackingStore?.Set(nameof(History), value); }
        }
        /// <summary>Include all versions of the documents. By default, the current copies of the documents will be returned. If SharePoint sites have versioning enabled, including all versions will include the historical copies of the documents. This property is defined only for APIs accessed using the /security query path and not the /privacy query path.</summary>
        public bool? IncludeAllVersions {
            get { return BackingStore?.Get<bool?>(nameof(IncludeAllVersions)); }
            set { BackingStore?.Set(nameof(IncludeAllVersions), value); }
        }
        /// <summary>Include content authored by the data subject. This property is defined only for APIs accessed using the /security query path and not the /privacy query path.</summary>
        public bool? IncludeAuthoredContent {
            get { return BackingStore?.Get<bool?>(nameof(IncludeAuthoredContent)); }
            set { BackingStore?.Set(nameof(IncludeAuthoredContent), value); }
        }
        /// <summary>Insight about the request.</summary>
        public SubjectRightsRequestDetail Insight {
            get { return BackingStore?.Get<SubjectRightsRequestDetail>(nameof(Insight)); }
            set { BackingStore?.Set(nameof(Insight), value); }
        }
        /// <summary>The date and time when the request is internally due. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? InternalDueDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(InternalDueDateTime)); }
            set { BackingStore?.Set(nameof(InternalDueDateTime), value); }
        }
        /// <summary>Identity information for the entity that last modified the request.</summary>
        public IdentitySet LastModifiedBy {
            get { return BackingStore?.Get<IdentitySet>(nameof(LastModifiedBy)); }
            set { BackingStore?.Set(nameof(LastModifiedBy), value); }
        }
        /// <summary>The date and time when the request was last modified. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>The mailboxlocations property</summary>
        public SubjectRightsRequestMailboxLocation Mailboxlocations {
            get { return BackingStore?.Get<SubjectRightsRequestMailboxLocation>(nameof(Mailboxlocations)); }
            set { BackingStore?.Set(nameof(Mailboxlocations), value); }
        }
        /// <summary>List of notes associated with the request.</summary>
        public List<AuthoredNote> Notes {
            get { return BackingStore?.Get<List<AuthoredNote>>(nameof(Notes)); }
            set { BackingStore?.Set(nameof(Notes), value); }
        }
        /// <summary>Pause the request after estimate has finished. By default, the data estimate will run and then pause, allowing you to preview results and then select the option to retrieve data in the UI. You can set this property to false if you want it to perform the estimate and then automatically begin with the retrieval of the content. This property is defined only for APIs accessed using the /security query path and not the /privacy query path.</summary>
        public bool? PauseAfterEstimate {
            get { return BackingStore?.Get<bool?>(nameof(PauseAfterEstimate)); }
            set { BackingStore?.Set(nameof(PauseAfterEstimate), value); }
        }
        /// <summary>List of regulations that this request will fulfill.</summary>
        public List<string> Regulations {
            get { return BackingStore?.Get<List<string>>(nameof(Regulations)); }
            set { BackingStore?.Set(nameof(Regulations), value); }
        }
        /// <summary>The sitelocations property</summary>
        public SubjectRightsRequestSiteLocation Sitelocations {
            get { return BackingStore?.Get<SubjectRightsRequestSiteLocation>(nameof(Sitelocations)); }
            set { BackingStore?.Set(nameof(Sitelocations), value); }
        }
        /// <summary>Information about the different stages for the request.</summary>
        public List<SubjectRightsRequestStageDetail> Stages {
            get { return BackingStore?.Get<List<SubjectRightsRequestStageDetail>>(nameof(Stages)); }
            set { BackingStore?.Set(nameof(Stages), value); }
        }
        /// <summary>The status of the request. Possible values are: active, closed, unknownFutureValue.</summary>
        public SubjectRightsRequestStatus? Status {
            get { return BackingStore?.Get<SubjectRightsRequestStatus?>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
        /// <summary>Information about the Microsoft Teams team that was created for the request.</summary>
        public Microsoft.Graph.Beta.Models.Team Team {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Team>(nameof(Team)); }
            set { BackingStore?.Set(nameof(Team), value); }
        }
        /// <summary>The type of the request. Possible values are: export, delete, access, tagForAction, unknownFutureValue.</summary>
        public SubjectRightsRequestType? Type {
            get { return BackingStore?.Get<SubjectRightsRequestType?>(nameof(Type)); }
            set { BackingStore?.Set(nameof(Type), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SubjectRightsRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SubjectRightsRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignedTo", n => { AssignedTo = n.GetObjectValue<Identity>(Identity.CreateFromDiscriminatorValue); } },
                {"closedDateTime", n => { ClosedDateTime = n.GetDateTimeOffsetValue(); } },
                {"contentQuery", n => { ContentQuery = n.GetStringValue(); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"dataSubject", n => { DataSubject = n.GetObjectValue<Microsoft.Graph.Beta.Models.DataSubject>(Microsoft.Graph.Beta.Models.DataSubject.CreateFromDiscriminatorValue); } },
                {"dataSubjectType", n => { DataSubjectType = n.GetEnumValue<DataSubjectType>(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"externalId", n => { ExternalId = n.GetStringValue(); } },
                {"history", n => { History = n.GetCollectionOfObjectValues<SubjectRightsRequestHistory>(SubjectRightsRequestHistory.CreateFromDiscriminatorValue).ToList(); } },
                {"includeAllVersions", n => { IncludeAllVersions = n.GetBoolValue(); } },
                {"includeAuthoredContent", n => { IncludeAuthoredContent = n.GetBoolValue(); } },
                {"insight", n => { Insight = n.GetObjectValue<SubjectRightsRequestDetail>(SubjectRightsRequestDetail.CreateFromDiscriminatorValue); } },
                {"internalDueDateTime", n => { InternalDueDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"mailboxlocations", n => { Mailboxlocations = n.GetObjectValue<SubjectRightsRequestMailboxLocation>(SubjectRightsRequestMailboxLocation.CreateFromDiscriminatorValue); } },
                {"notes", n => { Notes = n.GetCollectionOfObjectValues<AuthoredNote>(AuthoredNote.CreateFromDiscriminatorValue).ToList(); } },
                {"pauseAfterEstimate", n => { PauseAfterEstimate = n.GetBoolValue(); } },
                {"regulations", n => { Regulations = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"sitelocations", n => { Sitelocations = n.GetObjectValue<SubjectRightsRequestSiteLocation>(SubjectRightsRequestSiteLocation.CreateFromDiscriminatorValue); } },
                {"stages", n => { Stages = n.GetCollectionOfObjectValues<SubjectRightsRequestStageDetail>(SubjectRightsRequestStageDetail.CreateFromDiscriminatorValue).ToList(); } },
                {"status", n => { Status = n.GetEnumValue<SubjectRightsRequestStatus>(); } },
                {"team", n => { Team = n.GetObjectValue<Microsoft.Graph.Beta.Models.Team>(Microsoft.Graph.Beta.Models.Team.CreateFromDiscriminatorValue); } },
                {"type", n => { Type = n.GetEnumValue<SubjectRightsRequestType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Identity>("assignedTo", AssignedTo);
            writer.WriteDateTimeOffsetValue("closedDateTime", ClosedDateTime);
            writer.WriteStringValue("contentQuery", ContentQuery);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DataSubject>("dataSubject", DataSubject);
            writer.WriteEnumValue<DataSubjectType>("dataSubjectType", DataSubjectType);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteCollectionOfObjectValues<SubjectRightsRequestHistory>("history", History);
            writer.WriteBoolValue("includeAllVersions", IncludeAllVersions);
            writer.WriteBoolValue("includeAuthoredContent", IncludeAuthoredContent);
            writer.WriteObjectValue<SubjectRightsRequestDetail>("insight", Insight);
            writer.WriteDateTimeOffsetValue("internalDueDateTime", InternalDueDateTime);
            writer.WriteObjectValue<IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteObjectValue<SubjectRightsRequestMailboxLocation>("mailboxlocations", Mailboxlocations);
            writer.WriteCollectionOfObjectValues<AuthoredNote>("notes", Notes);
            writer.WriteBoolValue("pauseAfterEstimate", PauseAfterEstimate);
            writer.WriteCollectionOfPrimitiveValues<string>("regulations", Regulations);
            writer.WriteObjectValue<SubjectRightsRequestSiteLocation>("sitelocations", Sitelocations);
            writer.WriteCollectionOfObjectValues<SubjectRightsRequestStageDetail>("stages", Stages);
            writer.WriteEnumValue<SubjectRightsRequestStatus>("status", Status);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Team>("team", Team);
            writer.WriteEnumValue<SubjectRightsRequestType>("type", Type);
        }
    }
}
