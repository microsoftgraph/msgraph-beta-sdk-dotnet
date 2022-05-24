using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to user.</summary>
    public class WebAccount : ItemFacet, IParsable {
        /// <summary>Contains the description the user has provided for the account on the service being referenced.</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>The service property</summary>
        public ServiceInformation Service {
            get { return BackingStore?.Get<ServiceInformation>(nameof(Service)); }
            set { BackingStore?.Set(nameof(Service), value); }
        }
        /// <summary>Contains a status message from the cloud service if provided or synchronized.</summary>
        public string StatusMessage {
            get { return BackingStore?.Get<string>(nameof(StatusMessage)); }
            set { BackingStore?.Set(nameof(StatusMessage), value); }
        }
        /// <summary>The thumbnailUrl property</summary>
        public string ThumbnailUrl {
            get { return BackingStore?.Get<string>(nameof(ThumbnailUrl)); }
            set { BackingStore?.Set(nameof(ThumbnailUrl), value); }
        }
        /// <summary>The user name  displayed for the webaccount.</summary>
        public string UserId {
            get { return BackingStore?.Get<string>(nameof(UserId)); }
            set { BackingStore?.Set(nameof(UserId), value); }
        }
        /// <summary>Contains a link to the user&apos;s profile on the cloud service if one exists.</summary>
        public string WebUrl {
            get { return BackingStore?.Get<string>(nameof(WebUrl)); }
            set { BackingStore?.Set(nameof(WebUrl), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WebAccount CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WebAccount();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"description", n => { Description = n.GetStringValue(); } },
                {"service", n => { Service = n.GetObjectValue<ServiceInformation>(ServiceInformation.CreateFromDiscriminatorValue); } },
                {"statusMessage", n => { StatusMessage = n.GetStringValue(); } },
                {"thumbnailUrl", n => { ThumbnailUrl = n.GetStringValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
                {"webUrl", n => { WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("description", Description);
            writer.WriteObjectValue<ServiceInformation>("service", Service);
            writer.WriteStringValue("statusMessage", StatusMessage);
            writer.WriteStringValue("thumbnailUrl", ThumbnailUrl);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
