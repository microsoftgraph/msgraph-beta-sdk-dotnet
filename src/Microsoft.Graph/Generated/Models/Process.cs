using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Process : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>User account identifier (user account context the process ran under) for example, AccountName, SID, and so on.</summary>
        public string AccountName {
            get { return BackingStore?.Get<string>(nameof(AccountName)); }
            set { BackingStore?.Set(nameof(AccountName), value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The full process invocation commandline including all parameters.</summary>
        public string CommandLine {
            get { return BackingStore?.Get<string>(nameof(CommandLine)); }
            set { BackingStore?.Set(nameof(CommandLine), value); }
        }
        /// <summary>Time at which the process was started. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>Complex type containing file hashes (cryptographic and location-sensitive).</summary>
        public Microsoft.Graph.Beta.Models.FileHash FileHash {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.FileHash>(nameof(FileHash)); }
            set { BackingStore?.Set(nameof(FileHash), value); }
        }
        /// <summary>The integrity level of the process. Possible values are: unknown, untrusted, low, medium, high, system.</summary>
        public ProcessIntegrityLevel? IntegrityLevel {
            get { return BackingStore?.Get<ProcessIntegrityLevel?>(nameof(IntegrityLevel)); }
            set { BackingStore?.Set(nameof(IntegrityLevel), value); }
        }
        /// <summary>True if the process is elevated.</summary>
        public bool? IsElevated {
            get { return BackingStore?.Get<bool?>(nameof(IsElevated)); }
            set { BackingStore?.Set(nameof(IsElevated), value); }
        }
        /// <summary>The name of the process&apos; Image file.</summary>
        public string Name {
            get { return BackingStore?.Get<string>(nameof(Name)); }
            set { BackingStore?.Set(nameof(Name), value); }
        }
        /// <summary>DateTime at which the parent process was started. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? ParentProcessCreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ParentProcessCreatedDateTime)); }
            set { BackingStore?.Set(nameof(ParentProcessCreatedDateTime), value); }
        }
        /// <summary>The Process ID (PID) of the parent process.</summary>
        public int? ParentProcessId {
            get { return BackingStore?.Get<int?>(nameof(ParentProcessId)); }
            set { BackingStore?.Set(nameof(ParentProcessId), value); }
        }
        /// <summary>The name of the image file of the parent process.</summary>
        public string ParentProcessName {
            get { return BackingStore?.Get<string>(nameof(ParentProcessName)); }
            set { BackingStore?.Set(nameof(ParentProcessName), value); }
        }
        /// <summary>Full path, including filename.</summary>
        public string PathObject {
            get { return BackingStore?.Get<string>(nameof(PathObject)); }
            set { BackingStore?.Set(nameof(PathObject), value); }
        }
        /// <summary>The Process ID (PID) of the process.</summary>
        public int? ProcessId {
            get { return BackingStore?.Get<int?>(nameof(ProcessId)); }
            set { BackingStore?.Set(nameof(ProcessId), value); }
        }
        /// <summary>
        /// Instantiates a new process and sets the default values.
        /// </summary>
        public Process() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Process CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Process();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"accountName", n => { AccountName = n.GetStringValue(); } },
                {"commandLine", n => { CommandLine = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"fileHash", n => { FileHash = n.GetObjectValue<Microsoft.Graph.Beta.Models.FileHash>(Microsoft.Graph.Beta.Models.FileHash.CreateFromDiscriminatorValue); } },
                {"integrityLevel", n => { IntegrityLevel = n.GetEnumValue<ProcessIntegrityLevel>(); } },
                {"isElevated", n => { IsElevated = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"parentProcessCreatedDateTime", n => { ParentProcessCreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"parentProcessId", n => { ParentProcessId = n.GetIntValue(); } },
                {"parentProcessName", n => { ParentProcessName = n.GetStringValue(); } },
                {"path", n => { PathObject = n.GetStringValue(); } },
                {"processId", n => { ProcessId = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("accountName", AccountName);
            writer.WriteStringValue("commandLine", CommandLine);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.FileHash>("fileHash", FileHash);
            writer.WriteEnumValue<ProcessIntegrityLevel>("integrityLevel", IntegrityLevel);
            writer.WriteBoolValue("isElevated", IsElevated);
            writer.WriteStringValue("name", Name);
            writer.WriteDateTimeOffsetValue("parentProcessCreatedDateTime", ParentProcessCreatedDateTime);
            writer.WriteIntValue("parentProcessId", ParentProcessId);
            writer.WriteStringValue("parentProcessName", ParentProcessName);
            writer.WriteStringValue("path", PathObject);
            writer.WriteIntValue("processId", ProcessId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
