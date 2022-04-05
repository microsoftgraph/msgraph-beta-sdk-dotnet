using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MacOSSoftwareUpdateStateSummary : Entity, IParsable {
        /// <summary>Human readable name of the software update</summary>
        public string DisplayName { get; set; }
        /// <summary>Last date time the report for this device and product key was updated.</summary>
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
        /// <summary>Product key of the software update.</summary>
        public string ProductKey { get; set; }
        /// <summary>State of the software update. Possible values are: success, downloading, downloaded, installing, idle, available, scheduled, downloadFailed, downloadInsufficientSpace, downloadInsufficientPower, downloadInsufficientNetwork, installInsufficientSpace, installInsufficientPower, installFailed, commandFailed.</summary>
        public MacOSSoftwareUpdateState? State { get; set; }
        /// <summary>Software update category. Possible values are: critical, configurationDataFile, firmware, other.</summary>
        public MacOSSoftwareUpdateCategory? UpdateCategory { get; set; }
        /// <summary>Version of the software update</summary>
        public string UpdateVersion { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MacOSSoftwareUpdateStateSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSSoftwareUpdateStateSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"displayName", (o,n) => { (o as MacOSSoftwareUpdateStateSummary).DisplayName = n.GetStringValue(); } },
                {"lastUpdatedDateTime", (o,n) => { (o as MacOSSoftwareUpdateStateSummary).LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"productKey", (o,n) => { (o as MacOSSoftwareUpdateStateSummary).ProductKey = n.GetStringValue(); } },
                {"state", (o,n) => { (o as MacOSSoftwareUpdateStateSummary).State = n.GetEnumValue<MacOSSoftwareUpdateState>(); } },
                {"updateCategory", (o,n) => { (o as MacOSSoftwareUpdateStateSummary).UpdateCategory = n.GetEnumValue<MacOSSoftwareUpdateCategory>(); } },
                {"updateVersion", (o,n) => { (o as MacOSSoftwareUpdateStateSummary).UpdateVersion = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteStringValue("productKey", ProductKey);
            writer.WriteEnumValue<MacOSSoftwareUpdateState>("state", State);
            writer.WriteEnumValue<MacOSSoftwareUpdateCategory>("updateCategory", UpdateCategory);
            writer.WriteStringValue("updateVersion", UpdateVersion);
        }
    }
}
