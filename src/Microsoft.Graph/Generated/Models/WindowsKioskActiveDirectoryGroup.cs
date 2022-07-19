using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsKioskActiveDirectoryGroup : WindowsKioskUser, IParsable {
        /// <summary>The name of the AD group that will be locked to this kiosk configuration</summary>
        public string GroupName {
            get { return BackingStore?.Get<string>("groupName"); }
            set { BackingStore?.Set("groupName", value); }
        }
        /// <summary>
        /// Instantiates a new WindowsKioskActiveDirectoryGroup and sets the default values.
        /// </summary>
        public WindowsKioskActiveDirectoryGroup() : base() {
            OdataType = "#microsoft.graph.windowsKioskActiveDirectoryGroup";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsKioskActiveDirectoryGroup CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsKioskActiveDirectoryGroup();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"groupName", n => { GroupName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("groupName", GroupName);
        }
    }
}
