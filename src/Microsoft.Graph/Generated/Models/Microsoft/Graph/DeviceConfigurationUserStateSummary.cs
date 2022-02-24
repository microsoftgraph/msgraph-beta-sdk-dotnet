using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DeviceConfigurationUserStateSummary : Entity, IParsable {
        /// <summary>Number of compliant users</summary>
        public int? CompliantUserCount { get; set; }
        /// <summary>Number of conflict users</summary>
        public int? ConflictUserCount { get; set; }
        /// <summary>Number of error users</summary>
        public int? ErrorUserCount { get; set; }
        /// <summary>Number of NonCompliant users</summary>
        public int? NonCompliantUserCount { get; set; }
        /// <summary>Number of not applicable users</summary>
        public int? NotApplicableUserCount { get; set; }
        /// <summary>Number of remediated users</summary>
        public int? RemediatedUserCount { get; set; }
        /// <summary>Number of unknown users</summary>
        public int? UnknownUserCount { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"compliantUserCount", (o,n) => { (o as DeviceConfigurationUserStateSummary).CompliantUserCount = n.GetIntValue(); } },
                {"conflictUserCount", (o,n) => { (o as DeviceConfigurationUserStateSummary).ConflictUserCount = n.GetIntValue(); } },
                {"errorUserCount", (o,n) => { (o as DeviceConfigurationUserStateSummary).ErrorUserCount = n.GetIntValue(); } },
                {"nonCompliantUserCount", (o,n) => { (o as DeviceConfigurationUserStateSummary).NonCompliantUserCount = n.GetIntValue(); } },
                {"notApplicableUserCount", (o,n) => { (o as DeviceConfigurationUserStateSummary).NotApplicableUserCount = n.GetIntValue(); } },
                {"remediatedUserCount", (o,n) => { (o as DeviceConfigurationUserStateSummary).RemediatedUserCount = n.GetIntValue(); } },
                {"unknownUserCount", (o,n) => { (o as DeviceConfigurationUserStateSummary).UnknownUserCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("compliantUserCount", CompliantUserCount);
            writer.WriteIntValue("conflictUserCount", ConflictUserCount);
            writer.WriteIntValue("errorUserCount", ErrorUserCount);
            writer.WriteIntValue("nonCompliantUserCount", NonCompliantUserCount);
            writer.WriteIntValue("notApplicableUserCount", NotApplicableUserCount);
            writer.WriteIntValue("remediatedUserCount", RemediatedUserCount);
            writer.WriteIntValue("unknownUserCount", UnknownUserCount);
        }
    }
}
