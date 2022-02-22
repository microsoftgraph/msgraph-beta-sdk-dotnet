using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph.ManagedTenants {
    public class AuditEvent : Entity, IParsable {
        public string Activity { get; set; }
        public DateTimeOffset? ActivityDateTime { get; set; }
        public string ActivityId { get; set; }
        public string Category { get; set; }
        public string HttpVerb { get; set; }
        public string InitiatedByAppId { get; set; }
        public string InitiatedByUpn { get; set; }
        public string InitiatedByUserId { get; set; }
        public string IpAddress { get; set; }
        public string RequestBody { get; set; }
        public string RequestUrl { get; set; }
        public string TenantIds { get; set; }
        public string TenantNames { get; set; }
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
