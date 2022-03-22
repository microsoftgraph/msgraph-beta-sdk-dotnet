using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class WebAccount : ItemFacet, IParsable {
        /// <summary>Contains the description the user has provided for the account on the service being referenced.</summary>
        public string Description { get; set; }
        public ServiceInformation Service { get; set; }
        /// <summary>Contains a status message from the cloud service if provided or synchronized.</summary>
        public string StatusMessage { get; set; }
        public string ThumbnailUrl { get; set; }
        /// <summary>The user name  displayed for the webaccount.</summary>
        public string UserId { get; set; }
        /// <summary>Contains a link to the user's profile on the cloud service if one exists.</summary>
        public string WebUrl { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"description", (o,n) => { (o as WebAccount).Description = n.GetStringValue(); } },
                {"service", (o,n) => { (o as WebAccount).Service = n.GetObjectValue<ServiceInformation>(ServiceInformation.CreateFromDiscriminatorValue); } },
                {"statusMessage", (o,n) => { (o as WebAccount).StatusMessage = n.GetStringValue(); } },
                {"thumbnailUrl", (o,n) => { (o as WebAccount).ThumbnailUrl = n.GetStringValue(); } },
                {"userId", (o,n) => { (o as WebAccount).UserId = n.GetStringValue(); } },
                {"webUrl", (o,n) => { (o as WebAccount).WebUrl = n.GetStringValue(); } },
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
