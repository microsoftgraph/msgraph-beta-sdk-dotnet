using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidManagedStoreAppAssignmentSettings : MobileAppAssignmentSettings, IParsable {
        /// <summary>The track IDs to enable for this app assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AndroidManagedStoreAppTrackIds {
            get { return BackingStore?.Get<List<string>?>("androidManagedStoreAppTrackIds"); }
            set { BackingStore?.Set("androidManagedStoreAppTrackIds", value); }
        }
#nullable restore
#else
        public List<string> AndroidManagedStoreAppTrackIds {
            get { return BackingStore?.Get<List<string>>("androidManagedStoreAppTrackIds"); }
            set { BackingStore?.Set("androidManagedStoreAppTrackIds", value); }
        }
#endif
        /// <summary>Prioritization for automatic updates of Android Managed Store apps set on assignment.</summary>
        public AndroidManagedStoreAutoUpdateMode? AutoUpdateMode {
            get { return BackingStore?.Get<AndroidManagedStoreAutoUpdateMode?>("autoUpdateMode"); }
            set { BackingStore?.Set("autoUpdateMode", value); }
        }
        /// <summary>
        /// Instantiates a new AndroidManagedStoreAppAssignmentSettings and sets the default values.
        /// </summary>
        public AndroidManagedStoreAppAssignmentSettings() : base() {
            OdataType = "#microsoft.graph.androidManagedStoreAppAssignmentSettings";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AndroidManagedStoreAppAssignmentSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidManagedStoreAppAssignmentSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"androidManagedStoreAppTrackIds", n => { AndroidManagedStoreAppTrackIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"autoUpdateMode", n => { AutoUpdateMode = n.GetEnumValue<AndroidManagedStoreAutoUpdateMode>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("androidManagedStoreAppTrackIds", AndroidManagedStoreAppTrackIds);
            writer.WriteEnumValue<AndroidManagedStoreAutoUpdateMode>("autoUpdateMode", AutoUpdateMode);
        }
    }
}
