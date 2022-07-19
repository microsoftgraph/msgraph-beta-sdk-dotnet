using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class ProcessEvidence : AlertEvidence, IParsable {
        /// <summary>The detectionStatus property</summary>
        public Microsoft.Graph.Beta.Models.Security.DetectionStatus? DetectionStatus {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.DetectionStatus?>("detectionStatus"); }
            set { BackingStore?.Set("detectionStatus", value); }
        }
        /// <summary>The imageFile property</summary>
        public FileDetails ImageFile {
            get { return BackingStore?.Get<FileDetails>("imageFile"); }
            set { BackingStore?.Set("imageFile", value); }
        }
        /// <summary>The mdeDeviceId property</summary>
        public string MdeDeviceId {
            get { return BackingStore?.Get<string>("mdeDeviceId"); }
            set { BackingStore?.Set("mdeDeviceId", value); }
        }
        /// <summary>The parentProcessCreationDateTime property</summary>
        public DateTimeOffset? ParentProcessCreationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("parentProcessCreationDateTime"); }
            set { BackingStore?.Set("parentProcessCreationDateTime", value); }
        }
        /// <summary>The parentProcessId property</summary>
        public long? ParentProcessId {
            get { return BackingStore?.Get<long?>("parentProcessId"); }
            set { BackingStore?.Set("parentProcessId", value); }
        }
        /// <summary>The parentProcessImageFile property</summary>
        public FileDetails ParentProcessImageFile {
            get { return BackingStore?.Get<FileDetails>("parentProcessImageFile"); }
            set { BackingStore?.Set("parentProcessImageFile", value); }
        }
        /// <summary>The processCommandLine property</summary>
        public string ProcessCommandLine {
            get { return BackingStore?.Get<string>("processCommandLine"); }
            set { BackingStore?.Set("processCommandLine", value); }
        }
        /// <summary>The processCreationDateTime property</summary>
        public DateTimeOffset? ProcessCreationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("processCreationDateTime"); }
            set { BackingStore?.Set("processCreationDateTime", value); }
        }
        /// <summary>The processId property</summary>
        public long? ProcessId {
            get { return BackingStore?.Get<long?>("processId"); }
            set { BackingStore?.Set("processId", value); }
        }
        /// <summary>The userAccount property</summary>
        public Microsoft.Graph.Beta.Models.Security.UserAccount UserAccount {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.UserAccount>("userAccount"); }
            set { BackingStore?.Set("userAccount", value); }
        }
        /// <summary>
        /// Instantiates a new ProcessEvidence and sets the default values.
        /// </summary>
        public ProcessEvidence() : base() {
            OdataType = "#microsoft.graph.security.processEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ProcessEvidence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProcessEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"detectionStatus", n => { DetectionStatus = n.GetEnumValue<DetectionStatus>(); } },
                {"imageFile", n => { ImageFile = n.GetObjectValue<FileDetails>(FileDetails.CreateFromDiscriminatorValue); } },
                {"mdeDeviceId", n => { MdeDeviceId = n.GetStringValue(); } },
                {"parentProcessCreationDateTime", n => { ParentProcessCreationDateTime = n.GetDateTimeOffsetValue(); } },
                {"parentProcessId", n => { ParentProcessId = n.GetLongValue(); } },
                {"parentProcessImageFile", n => { ParentProcessImageFile = n.GetObjectValue<FileDetails>(FileDetails.CreateFromDiscriminatorValue); } },
                {"processCommandLine", n => { ProcessCommandLine = n.GetStringValue(); } },
                {"processCreationDateTime", n => { ProcessCreationDateTime = n.GetDateTimeOffsetValue(); } },
                {"processId", n => { ProcessId = n.GetLongValue(); } },
                {"userAccount", n => { UserAccount = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.UserAccount>(Microsoft.Graph.Beta.Models.Security.UserAccount.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<DetectionStatus>("detectionStatus", DetectionStatus);
            writer.WriteObjectValue<FileDetails>("imageFile", ImageFile);
            writer.WriteStringValue("mdeDeviceId", MdeDeviceId);
            writer.WriteDateTimeOffsetValue("parentProcessCreationDateTime", ParentProcessCreationDateTime);
            writer.WriteLongValue("parentProcessId", ParentProcessId);
            writer.WriteObjectValue<FileDetails>("parentProcessImageFile", ParentProcessImageFile);
            writer.WriteStringValue("processCommandLine", ProcessCommandLine);
            writer.WriteDateTimeOffsetValue("processCreationDateTime", ProcessCreationDateTime);
            writer.WriteLongValue("processId", ProcessId);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.UserAccount>("userAccount", UserAccount);
        }
    }
}
