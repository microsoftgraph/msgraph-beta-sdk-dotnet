using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DlpWindowsDevicesNotification : DlpNotification, IParsable {
        /// <summary>The contentName property</summary>
        public string ContentName {
            get { return BackingStore?.Get<string>("contentName"); }
            set { BackingStore?.Set("contentName", value); }
        }
        /// <summary>The lastModfiedBy property</summary>
        public string LastModfiedBy {
            get { return BackingStore?.Get<string>("lastModfiedBy"); }
            set { BackingStore?.Set("lastModfiedBy", value); }
        }
        /// <summary>
        /// Instantiates a new DlpWindowsDevicesNotification and sets the default values.
        /// </summary>
        public DlpWindowsDevicesNotification() : base() {
            OdataType = "#microsoft.graph.dlpWindowsDevicesNotification";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DlpWindowsDevicesNotification CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DlpWindowsDevicesNotification();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"contentName", n => { ContentName = n.GetStringValue(); } },
                {"lastModfiedBy", n => { LastModfiedBy = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("contentName", ContentName);
            writer.WriteStringValue("lastModfiedBy", LastModfiedBy);
        }
    }
}
