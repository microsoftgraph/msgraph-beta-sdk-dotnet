using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidManagedStoreAppAssignmentSettings : MobileAppAssignmentSettings, IParsable {
        /// <summary>The track IDs to enable for this app assignment.</summary>
        public List<string> AndroidManagedStoreAppTrackIds {
            get { return BackingStore?.Get<List<string>>(nameof(AndroidManagedStoreAppTrackIds)); }
            set { BackingStore?.Set(nameof(AndroidManagedStoreAppTrackIds), value); }
        }
        /// <summary>The prioritization of automatic updates for this app assignment. Possible values are: default, postponed, priority, unknownFutureValue.</summary>
        public AndroidManagedStoreAutoUpdateMode? AutoUpdateMode {
            get { return BackingStore?.Get<AndroidManagedStoreAutoUpdateMode?>(nameof(AutoUpdateMode)); }
            set { BackingStore?.Set(nameof(AutoUpdateMode), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AndroidManagedStoreAppAssignmentSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidManagedStoreAppAssignmentSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"androidManagedStoreAppTrackIds", n => { AndroidManagedStoreAppTrackIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"autoUpdateMode", n => { AutoUpdateMode = n.GetEnumValue<AndroidManagedStoreAutoUpdateMode>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("androidManagedStoreAppTrackIds", AndroidManagedStoreAppTrackIds);
            writer.WriteEnumValue<AndroidManagedStoreAutoUpdateMode>("autoUpdateMode", AutoUpdateMode);
        }
    }
}
