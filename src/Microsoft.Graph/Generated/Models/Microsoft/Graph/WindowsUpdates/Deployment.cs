using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.WindowsUpdates {
    public class Deployment : Entity, IParsable {
        /// <summary>Specifies the audience to which content is deployed.</summary>
        public DeploymentAudience Audience { get; set; }
        /// <summary>Specifies what content to deploy. Cannot be changed. Returned by default.</summary>
        public DeployableContent Content { get; set; }
        /// <summary>The date and time the deployment was created. Returned by default. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The date and time the deployment was last modified. Returned by default. Read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Settings specified on the specific deployment governing how to deploy content. Returned by default.</summary>
        public DeploymentSettings Settings { get; set; }
        /// <summary>Execution status of the deployment. Returned by default.</summary>
        public DeploymentState State { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"audience", (o,n) => { (o as Deployment).Audience = n.GetObjectValue<DeploymentAudience>(); } },
                {"content", (o,n) => { (o as Deployment).Content = n.GetObjectValue<DeployableContent>(); } },
                {"createdDateTime", (o,n) => { (o as Deployment).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as Deployment).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"settings", (o,n) => { (o as Deployment).Settings = n.GetObjectValue<DeploymentSettings>(); } },
                {"state", (o,n) => { (o as Deployment).State = n.GetObjectValue<DeploymentState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<DeploymentAudience>("audience", Audience);
            writer.WriteObjectValue<DeployableContent>("content", Content);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteObjectValue<DeploymentSettings>("settings", Settings);
            writer.WriteObjectValue<DeploymentState>("state", State);
        }
    }
}
