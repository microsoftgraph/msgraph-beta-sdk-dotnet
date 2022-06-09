using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsMicrosoftEdgeApp : MobileApp, IParsable {
        /// <summary>The channel to install on target devices. Possible values are: dev, beta, stable.</summary>
        public MicrosoftEdgeChannel? Channel {
            get { return BackingStore?.Get<MicrosoftEdgeChannel?>(nameof(Channel)); }
            set { BackingStore?.Set(nameof(Channel), value); }
        }
        /// <summary>The language locale to use when the Edge app displays text to the user.</summary>
        public string DisplayLanguageLocale {
            get { return BackingStore?.Get<string>(nameof(DisplayLanguageLocale)); }
            set { BackingStore?.Set(nameof(DisplayLanguageLocale), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsMicrosoftEdgeApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsMicrosoftEdgeApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"channel", n => { Channel = n.GetEnumValue<MicrosoftEdgeChannel>(); } },
                {"displayLanguageLocale", n => { DisplayLanguageLocale = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<MicrosoftEdgeChannel>("channel", Channel);
            writer.WriteStringValue("displayLanguageLocale", DisplayLanguageLocale);
        }
    }
}
