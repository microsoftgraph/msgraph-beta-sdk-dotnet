using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Contains properties used to determine when to offer an app to devices and when to install the app on devices.
    /// </summary>
    public class WinGetAppInstallTimeSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The time at which the app should be installed.</summary>
        public DateTimeOffset? DeadlineDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("deadlineDateTime"); }
            set { BackingStore?.Set("deadlineDateTime", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Whether the local device time or UTC time should be used when determining the deadline times.</summary>
        public bool? UseLocalTime {
            get { return BackingStore?.Get<bool?>("useLocalTime"); }
            set { BackingStore?.Set("useLocalTime", value); }
        }
        /// <summary>
        /// Instantiates a new winGetAppInstallTimeSettings and sets the default values.
        /// </summary>
        public WinGetAppInstallTimeSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WinGetAppInstallTimeSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WinGetAppInstallTimeSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"deadlineDateTime", n => { DeadlineDateTime = n.GetDateTimeOffsetValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"useLocalTime", n => { UseLocalTime = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("deadlineDateTime", DeadlineDateTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("useLocalTime", UseLocalTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
