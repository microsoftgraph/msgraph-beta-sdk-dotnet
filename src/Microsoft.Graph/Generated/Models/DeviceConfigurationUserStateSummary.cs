using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
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
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceConfigurationUserStateSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceConfigurationUserStateSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"compliantUserCount", n => { CompliantUserCount = n.GetIntValue(); } },
                {"conflictUserCount", n => { ConflictUserCount = n.GetIntValue(); } },
                {"errorUserCount", n => { ErrorUserCount = n.GetIntValue(); } },
                {"nonCompliantUserCount", n => { NonCompliantUserCount = n.GetIntValue(); } },
                {"notApplicableUserCount", n => { NotApplicableUserCount = n.GetIntValue(); } },
                {"remediatedUserCount", n => { RemediatedUserCount = n.GetIntValue(); } },
                {"unknownUserCount", n => { UnknownUserCount = n.GetIntValue(); } },
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
