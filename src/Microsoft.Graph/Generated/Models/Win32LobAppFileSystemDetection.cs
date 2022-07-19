using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Win32LobAppFileSystemDetection : Win32LobAppDetection, IParsable {
        /// <summary>A value indicating whether this file or folder is for checking 32-bit app on 64-bit system</summary>
        public bool? Check32BitOn64System {
            get { return BackingStore?.Get<bool?>("check32BitOn64System"); }
            set { BackingStore?.Set("check32BitOn64System", value); }
        }
        /// <summary>Contains all supported file system detection type.</summary>
        public Win32LobAppFileSystemDetectionType? DetectionType {
            get { return BackingStore?.Get<Win32LobAppFileSystemDetectionType?>("detectionType"); }
            set { BackingStore?.Set("detectionType", value); }
        }
        /// <summary>The file or folder detection value</summary>
        public string DetectionValue {
            get { return BackingStore?.Get<string>("detectionValue"); }
            set { BackingStore?.Set("detectionValue", value); }
        }
        /// <summary>The file or folder name to detect Win32 Line of Business (LoB) app</summary>
        public string FileOrFolderName {
            get { return BackingStore?.Get<string>("fileOrFolderName"); }
            set { BackingStore?.Set("fileOrFolderName", value); }
        }
        /// <summary>Contains properties for detection operator.</summary>
        public Win32LobAppDetectionOperator? Operator {
            get { return BackingStore?.Get<Win32LobAppDetectionOperator?>("operator"); }
            set { BackingStore?.Set("operator", value); }
        }
        /// <summary>The file or folder path to detect Win32 Line of Business (LoB) app</summary>
        public string PathObject {
            get { return BackingStore?.Get<string>("path"); }
            set { BackingStore?.Set("path", value); }
        }
        /// <summary>
        /// Instantiates a new Win32LobAppFileSystemDetection and sets the default values.
        /// </summary>
        public Win32LobAppFileSystemDetection() : base() {
            OdataType = "#microsoft.graph.win32LobAppFileSystemDetection";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Win32LobAppFileSystemDetection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Win32LobAppFileSystemDetection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"check32BitOn64System", n => { Check32BitOn64System = n.GetBoolValue(); } },
                {"detectionType", n => { DetectionType = n.GetEnumValue<Win32LobAppFileSystemDetectionType>(); } },
                {"detectionValue", n => { DetectionValue = n.GetStringValue(); } },
                {"fileOrFolderName", n => { FileOrFolderName = n.GetStringValue(); } },
                {"operator", n => { Operator = n.GetEnumValue<Win32LobAppDetectionOperator>(); } },
                {"path", n => { PathObject = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("check32BitOn64System", Check32BitOn64System);
            writer.WriteEnumValue<Win32LobAppFileSystemDetectionType>("detectionType", DetectionType);
            writer.WriteStringValue("detectionValue", DetectionValue);
            writer.WriteStringValue("fileOrFolderName", FileOrFolderName);
            writer.WriteEnumValue<Win32LobAppDetectionOperator>("operator", Operator);
            writer.WriteStringValue("path", PathObject);
        }
    }
}
