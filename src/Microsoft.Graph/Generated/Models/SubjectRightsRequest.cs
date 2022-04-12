using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SubjectRightsRequest : Entity, IParsable {
        /// <summary>Identity that the request is assigned to.</summary>
        public Identity AssignedTo { get; set; }
        /// <summary>The date and time when the request was closed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? ClosedDateTime { get; set; }
        /// <summary>The contentQuery property</summary>
        public string ContentQuery { get; set; }
        /// <summary>Identity information for the entity that created the request.</summary>
        public IdentitySet CreatedBy { get; set; }
        /// <summary>The date and time when the request was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Information about the data subject.</summary>
        public Microsoft.Graph.Beta.Models.DataSubject DataSubject { get; set; }
        /// <summary>The type of the data subject. Possible values are: customer, currentEmployee, formerEmployee, prospectiveEmployee, student, teacher, faculty, other, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.DataSubjectType? DataSubjectType { get; set; }
        /// <summary>Description for the request.</summary>
        public string Description { get; set; }
        /// <summary>The name of the request.</summary>
        public string DisplayName { get; set; }
        /// <summary>The externalId property</summary>
        public string ExternalId { get; set; }
        /// <summary>Collection of history change events.</summary>
        public List<SubjectRightsRequestHistory> History { get; set; }
        /// <summary>The includeAllVersions property</summary>
        public bool? IncludeAllVersions { get; set; }
        /// <summary>The includeAuthoredContent property</summary>
        public bool? IncludeAuthoredContent { get; set; }
        /// <summary>Insight about the request.</summary>
        public SubjectRightsRequestDetail Insight { get; set; }
        /// <summary>The date and time when the request is internally due. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? InternalDueDateTime { get; set; }
        /// <summary>Identity information for the entity that last modified the request.</summary>
        public IdentitySet LastModifiedBy { get; set; }
        /// <summary>The date and time when the request was last modified. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The mailboxlocations property</summary>
        public SubjectRightsRequestMailboxLocation Mailboxlocations { get; set; }
        /// <summary>List of notes associcated with the request.</summary>
        public List<AuthoredNote> Notes { get; set; }
        /// <summary>The pauseAfterEstimate property</summary>
        public bool? PauseAfterEstimate { get; set; }
        /// <summary>List of regulations that this request will fulfill.</summary>
        public List<string> Regulations { get; set; }
        /// <summary>The sitelocations property</summary>
        public SubjectRightsRequestSiteLocation Sitelocations { get; set; }
        /// <summary>Information about the different stages for the request.</summary>
        public List<SubjectRightsRequestStageDetail> Stages { get; set; }
        /// <summary>The status of the request.. Possible values are: active, closed, unknownFutureValue.</summary>
        public SubjectRightsRequestStatus? Status { get; set; }
        /// <summary>Information about the Microsoft Teams team that was created for the request.</summary>
        public Microsoft.Graph.Beta.Models.Team Team { get; set; }
        /// <summary>The type of the request. Possible values are: export, delete, access, tagForAction, unknownFutureValue.</summary>
        public SubjectRightsRequestType? Type { get; set; }
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
