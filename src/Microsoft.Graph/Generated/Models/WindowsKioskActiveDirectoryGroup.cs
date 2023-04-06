using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsKioskActiveDirectoryGroup : WindowsKioskUser, IParsable {
        /// <summary>The name of the AD group that will be locked to this kiosk configuration</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GroupName {
            get { return BackingStore?.Get<string?>("groupName"); }
            set { BackingStore?.Set("groupName", value); }
        }
#nullable restore
#else
        public string GroupName {
            get { return BackingStore?.Get<string>("groupName"); }
            set { BackingStore?.Set("groupName", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new WindowsKioskActiveDirectoryGroup and sets the default values.
        /// </summary>
        public WindowsKioskActiveDirectoryGroup() : base() {
            OdataType = "#microsoft.graph.windowsKioskActiveDirectoryGroup";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("groupName", GroupName);
        }
    }
}
