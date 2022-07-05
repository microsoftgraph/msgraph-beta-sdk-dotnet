using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class DeviceConfigurationUserStateSummary : Entity, IParsable {
        /// <summary>Number of compliant users</summary>
        public int? CompliantUserCount {
            get { return BackingStore?.Get<int?>(nameof(CompliantUserCount)); }
            set { BackingStore?.Set(nameof(CompliantUserCount), value); }
        }
        /// <summary>Number of conflict users</summary>
        public int? ConflictUserCount {
            get { return BackingStore?.Get<int?>(nameof(ConflictUserCount)); }
            set { BackingStore?.Set(nameof(ConflictUserCount), value); }
        }
        /// <summary>Number of error users</summary>
        public int? ErrorUserCount {
            get { return BackingStore?.Get<int?>(nameof(ErrorUserCount)); }
            set { BackingStore?.Set(nameof(ErrorUserCount), value); }
        }
        /// <summary>Number of NonCompliant users</summary>
        public int? NonCompliantUserCount {
            get { return BackingStore?.Get<int?>(nameof(NonCompliantUserCount)); }
            set { BackingStore?.Set(nameof(NonCompliantUserCount), value); }
        }
        /// <summary>Number of not applicable users</summary>
        public int? NotApplicableUserCount {
            get { return BackingStore?.Get<int?>(nameof(NotApplicableUserCount)); }
            set { BackingStore?.Set(nameof(NotApplicableUserCount), value); }
        }
        /// <summary>Number of remediated users</summary>
        public int? RemediatedUserCount {
            get { return BackingStore?.Get<int?>(nameof(RemediatedUserCount)); }
            set { BackingStore?.Set(nameof(RemediatedUserCount), value); }
        }
        /// <summary>Number of unknown users</summary>
        public int? UnknownUserCount {
            get { return BackingStore?.Get<int?>(nameof(UnknownUserCount)); }
            set { BackingStore?.Set(nameof(UnknownUserCount), value); }
        }
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
