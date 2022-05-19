using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Contains properties for a single installer file that is associated with a given mobileAppContent version.</summary>
    public class MobileAppContentFile : Entity, IParsable {
        /// <summary>The Azure Storage URI.</summary>
        public string AzureStorageUri {
            get { return BackingStore?.Get<string>(nameof(AzureStorageUri)); }
            set { BackingStore?.Set(nameof(AzureStorageUri), value); }
        }
        /// <summary>The time the Azure storage Uri expires.</summary>
        public DateTimeOffset? AzureStorageUriExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(AzureStorageUriExpirationDateTime)); }
            set { BackingStore?.Set(nameof(AzureStorageUriExpirationDateTime), value); }
        }
        /// <summary>The time the file was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>A value indicating whether the file is committed.</summary>
        public bool? IsCommitted {
            get { return BackingStore?.Get<bool?>(nameof(IsCommitted)); }
            set { BackingStore?.Set(nameof(IsCommitted), value); }
        }
        /// <summary>Whether the content file is a dependency for the main content file.</summary>
        public bool? IsDependency {
            get { return BackingStore?.Get<bool?>(nameof(IsDependency)); }
            set { BackingStore?.Set(nameof(IsDependency), value); }
        }
        /// <summary>A value indicating whether the file is a framework file.</summary>
        public bool? IsFrameworkFile {
            get { return BackingStore?.Get<bool?>(nameof(IsFrameworkFile)); }
            set { BackingStore?.Set(nameof(IsFrameworkFile), value); }
        }
        /// <summary>The manifest information.</summary>
        public byte[] Manifest {
            get { return BackingStore?.Get<byte[]>(nameof(Manifest)); }
            set { BackingStore?.Set(nameof(Manifest), value); }
        }
        /// <summary>the file name.</summary>
        public string Name {
            get { return BackingStore?.Get<string>(nameof(Name)); }
            set { BackingStore?.Set(nameof(Name), value); }
        }
        /// <summary>The size of the file prior to encryption.</summary>
        public long? Size {
            get { return BackingStore?.Get<long?>(nameof(Size)); }
            set { BackingStore?.Set(nameof(Size), value); }
        }
        /// <summary>The size of the file after encryption.</summary>
        public long? SizeEncrypted {
            get { return BackingStore?.Get<long?>(nameof(SizeEncrypted)); }
            set { BackingStore?.Set(nameof(SizeEncrypted), value); }
        }
        /// <summary>The state of the current upload request. Possible values are: success, transientError, error, unknown, azureStorageUriRequestSuccess, azureStorageUriRequestPending, azureStorageUriRequestFailed, azureStorageUriRequestTimedOut, azureStorageUriRenewalSuccess, azureStorageUriRenewalPending, azureStorageUriRenewalFailed, azureStorageUriRenewalTimedOut, commitFileSuccess, commitFilePending, commitFileFailed, commitFileTimedOut.</summary>
        public MobileAppContentFileUploadState? UploadState {
            get { return BackingStore?.Get<MobileAppContentFileUploadState?>(nameof(UploadState)); }
            set { BackingStore?.Set(nameof(UploadState), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MobileAppContentFile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MobileAppContentFile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"azureStorageUri", n => { AzureStorageUri = n.GetStringValue(); } },
                {"azureStorageUriExpirationDateTime", n => { AzureStorageUriExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"isCommitted", n => { IsCommitted = n.GetBoolValue(); } },
                {"isDependency", n => { IsDependency = n.GetBoolValue(); } },
                {"isFrameworkFile", n => { IsFrameworkFile = n.GetBoolValue(); } },
                {"manifest", n => { Manifest = n.GetByteArrayValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"size", n => { Size = n.GetLongValue(); } },
                {"sizeEncrypted", n => { SizeEncrypted = n.GetLongValue(); } },
                {"uploadState", n => { UploadState = n.GetEnumValue<MobileAppContentFileUploadState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("azureStorageUri", AzureStorageUri);
            writer.WriteDateTimeOffsetValue("azureStorageUriExpirationDateTime", AzureStorageUriExpirationDateTime);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteBoolValue("isCommitted", IsCommitted);
            writer.WriteBoolValue("isDependency", IsDependency);
            writer.WriteBoolValue("isFrameworkFile", IsFrameworkFile);
            writer.WriteByteArrayValue("manifest", Manifest);
            writer.WriteStringValue("name", Name);
            writer.WriteLongValue("size", Size);
            writer.WriteLongValue("sizeEncrypted", SizeEncrypted);
            writer.WriteEnumValue<MobileAppContentFileUploadState>("uploadState", UploadState);
        }
    }
}
