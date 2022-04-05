using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public class AuditEvent : Entity, IParsable {
        /// <summary>A string which uniquely represents the operation that occurred. Required. Read-only.</summary>
        public string Activity { get; set; }
        /// <summary>The time when the activity ocurred. Required. Read-only.</summary>
        public DateTimeOffset? ActivityDateTime { get; set; }
        /// <summary>The identifier of the activity request that made the audit event. Required. Read-only.</summary>
        public string ActivityId { get; set; }
        /// <summary>A category which represents a logical grouping of activities. Required. Read-only.</summary>
        public string Category { get; set; }
        /// <summary>The HTTP verb that was used when making the API request. Required. Read-only.</summary>
        public string HttpVerb { get; set; }
        /// <summary>The identifier of the app that was used to make the request. Required. Read-only.</summary>
        public string InitiatedByAppId { get; set; }
        /// <summary>The UPN of the user who initiated the activity. Required. Read-only.</summary>
        public string InitiatedByUpn { get; set; }
        /// <summary>The identifier of the user who initiated the activity. Required. Read-only.</summary>
        public string InitiatedByUserId { get; set; }
        /// <summary>The IP address of where the activity was initiated. This may be an IPv4 or IPv6 address. Required. Read-only.</summary>
        public string IpAddress { get; set; }
        /// <summary>The raw HTTP request body. Some sensitive information may be removed.</summary>
        public string RequestBody { get; set; }
        /// <summary>The raw HTTP request URL. Required. Read-only.</summary>
        public string RequestUrl { get; set; }
        /// <summary>The collection of Azure Active Directory tenant identifiers for the managed tenants that were impacted by this change. This is formatted as a list of comma-separated values. Required. Read-only.</summary>
        public string TenantIds { get; set; }
        /// <summary>The collection of tenant names that were impacted by this change. This is formatted as a list of comma-separated values. Required. Read-only.</summary>
        public string TenantNames { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AuditEvent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuditEvent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"activity", (o,n) => { (o as AuditEvent).Activity = n.GetStringValue(); } },
                {"activityDateTime", (o,n) => { (o as AuditEvent).ActivityDateTime = n.GetDateTimeOffsetValue(); } },
                {"activityId", (o,n) => { (o as AuditEvent).ActivityId = n.GetStringValue(); } },
                {"category", (o,n) => { (o as AuditEvent).Category = n.GetStringValue(); } },
                {"httpVerb", (o,n) => { (o as AuditEvent).HttpVerb = n.GetStringValue(); } },
                {"initiatedByAppId", (o,n) => { (o as AuditEvent).InitiatedByAppId = n.GetStringValue(); } },
                {"initiatedByUpn", (o,n) => { (o as AuditEvent).InitiatedByUpn = n.GetStringValue(); } },
                {"initiatedByUserId", (o,n) => { (o as AuditEvent).InitiatedByUserId = n.GetStringValue(); } },
                {"ipAddress", (o,n) => { (o as AuditEvent).IpAddress = n.GetStringValue(); } },
                {"requestBody", (o,n) => { (o as AuditEvent).RequestBody = n.GetStringValue(); } },
                {"requestUrl", (o,n) => { (o as AuditEvent).RequestUrl = n.GetStringValue(); } },
                {"tenantIds", (o,n) => { (o as AuditEvent).TenantIds = n.GetStringValue(); } },
                {"tenantNames", (o,n) => { (o as AuditEvent).TenantNames = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("activity", Activity);
            writer.WriteDateTimeOffsetValue("activityDateTime", ActivityDateTime);
            writer.WriteStringValue("activityId", ActivityId);
            writer.WriteStringValue("category", Category);
            writer.WriteStringValue("httpVerb", HttpVerb);
            writer.WriteStringValue("initiatedByAppId", InitiatedByAppId);
            writer.WriteStringValue("initiatedByUpn", InitiatedByUpn);
            writer.WriteStringValue("initiatedByUserId", InitiatedByUserId);
            writer.WriteStringValue("ipAddress", IpAddress);
            writer.WriteStringValue("requestBody", RequestBody);
            writer.WriteStringValue("requestUrl", RequestUrl);
            writer.WriteStringValue("tenantIds", TenantIds);
            writer.WriteStringValue("tenantNames", TenantNames);
        }
    }
}
