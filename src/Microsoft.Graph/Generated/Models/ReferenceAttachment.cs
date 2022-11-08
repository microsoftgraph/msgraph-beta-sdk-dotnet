using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ReferenceAttachment : Attachment, IParsable {
        /// <summary>Specifies whether the attachment is a link to a folder. Must set this to true if sourceUrl is a link to a folder. Optional.</summary>
        public bool? IsFolder {
            get { return BackingStore?.Get<bool?>("isFolder"); }
            set { BackingStore?.Set("isFolder", value); }
        }
        /// <summary>Specifies the permissions granted for the attachment by the type of provider in providerType. Possible values are: other, view, edit, anonymousView, anonymousEdit, organizationView, organizationEdit. Optional.</summary>
        public ReferenceAttachmentPermission? Permission {
            get { return BackingStore?.Get<ReferenceAttachmentPermission?>("permission"); }
            set { BackingStore?.Set("permission", value); }
        }
        /// <summary>Applies to only a reference attachment of an image - URL to get a preview image. Use thumbnailUrl and previewUrl only when sourceUrl identifies an image file. Optional.</summary>
        public string PreviewUrl {
            get { return BackingStore?.Get<string>("previewUrl"); }
            set { BackingStore?.Set("previewUrl", value); }
        }
        /// <summary>The type of provider that supports an attachment of this contentType. Possible values are: other, oneDriveBusiness, oneDriveConsumer, dropbox. Optional.</summary>
        public ReferenceAttachmentProvider? ProviderType {
            get { return BackingStore?.Get<ReferenceAttachmentProvider?>("providerType"); }
            set { BackingStore?.Set("providerType", value); }
        }
        /// <summary>URL to get the attachment content. If this is a URL to a folder, then for the folder to be displayed correctly in Outlook or Outlook on the web, set isFolder to true. Required.</summary>
        public string SourceUrl {
            get { return BackingStore?.Get<string>("sourceUrl"); }
            set { BackingStore?.Set("sourceUrl", value); }
        }
        /// <summary>Applies to only a reference attachment of an image - URL to get a thumbnail image. Use thumbnailUrl and previewUrl only when sourceUrl identifies an image file. Optional.</summary>
        public string ThumbnailUrl {
            get { return BackingStore?.Get<string>("thumbnailUrl"); }
            set { BackingStore?.Set("thumbnailUrl", value); }
        }
        /// <summary>
        /// Instantiates a new ReferenceAttachment and sets the default values.
        /// </summary>
        public ReferenceAttachment() : base() {
            OdataType = "#microsoft.graph.referenceAttachment";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ReferenceAttachment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ReferenceAttachment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"isFolder", n => { IsFolder = n.GetBoolValue(); } },
                {"permission", n => { Permission = n.GetEnumValue<ReferenceAttachmentPermission>(); } },
                {"previewUrl", n => { PreviewUrl = n.GetStringValue(); } },
                {"providerType", n => { ProviderType = n.GetEnumValue<ReferenceAttachmentProvider>(); } },
                {"sourceUrl", n => { SourceUrl = n.GetStringValue(); } },
                {"thumbnailUrl", n => { ThumbnailUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("isFolder", IsFolder);
            writer.WriteEnumValue<ReferenceAttachmentPermission>("permission", Permission);
            writer.WriteStringValue("previewUrl", PreviewUrl);
            writer.WriteEnumValue<ReferenceAttachmentProvider>("providerType", ProviderType);
            writer.WriteStringValue("sourceUrl", SourceUrl);
            writer.WriteStringValue("thumbnailUrl", ThumbnailUrl);
        }
    }
}
