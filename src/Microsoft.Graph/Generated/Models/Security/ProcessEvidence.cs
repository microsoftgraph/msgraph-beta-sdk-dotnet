using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class ProcessEvidence : AlertEvidence, IParsable {
        /// <summary>The detectionStatus property</summary>
        public Microsoft.Graph.Beta.Models.Security.DetectionStatus? DetectionStatus {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.DetectionStatus?>(nameof(DetectionStatus)); }
            set { BackingStore?.Set(nameof(DetectionStatus), value); }
        }
        /// <summary>The imageFile property</summary>
        public FileDetails ImageFile {
            get { return BackingStore?.Get<FileDetails>(nameof(ImageFile)); }
            set { BackingStore?.Set(nameof(ImageFile), value); }
        }
        /// <summary>The mdeDeviceId property</summary>
        public string MdeDeviceId {
            get { return BackingStore?.Get<string>(nameof(MdeDeviceId)); }
            set { BackingStore?.Set(nameof(MdeDeviceId), value); }
        }
        /// <summary>The parentProcessCreationDateTime property</summary>
        public DateTimeOffset? ParentProcessCreationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ParentProcessCreationDateTime)); }
            set { BackingStore?.Set(nameof(ParentProcessCreationDateTime), value); }
        }
        /// <summary>The parentProcessId property</summary>
        public long? ParentProcessId {
            get { return BackingStore?.Get<long?>(nameof(ParentProcessId)); }
            set { BackingStore?.Set(nameof(ParentProcessId), value); }
        }
        /// <summary>The parentProcessImageFile property</summary>
        public FileDetails ParentProcessImageFile {
            get { return BackingStore?.Get<FileDetails>(nameof(ParentProcessImageFile)); }
            set { BackingStore?.Set(nameof(ParentProcessImageFile), value); }
        }
        /// <summary>The processCommandLine property</summary>
        public string ProcessCommandLine {
            get { return BackingStore?.Get<string>(nameof(ProcessCommandLine)); }
            set { BackingStore?.Set(nameof(ProcessCommandLine), value); }
        }
        /// <summary>The processCreationDateTime property</summary>
        public DateTimeOffset? ProcessCreationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ProcessCreationDateTime)); }
            set { BackingStore?.Set(nameof(ProcessCreationDateTime), value); }
        }
        /// <summary>The processId property</summary>
        public long? ProcessId {
            get { return BackingStore?.Get<long?>(nameof(ProcessId)); }
            set { BackingStore?.Set(nameof(ProcessId), value); }
        }
        /// <summary>The userAccount property</summary>
        public Microsoft.Graph.Beta.Models.Security.UserAccount UserAccount {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.UserAccount>(nameof(UserAccount)); }
            set { BackingStore?.Set(nameof(UserAccount), value); }
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
