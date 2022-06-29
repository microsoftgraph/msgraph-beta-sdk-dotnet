using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Contains properties describing restart coordination following an app installation.</summary>
    public class Win32LobAppRestartSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The number of minutes before the restart time to display the countdown dialog for pending restarts.</summary>
        public int? CountdownDisplayBeforeRestartInMinutes {
            get { return BackingStore?.Get<int?>(nameof(CountdownDisplayBeforeRestartInMinutes)); }
            set { BackingStore?.Set(nameof(CountdownDisplayBeforeRestartInMinutes), value); }
        }
        /// <summary>The number of minutes to wait before restarting the device after an app installation.</summary>
        public int? GracePeriodInMinutes {
            get { return BackingStore?.Get<int?>(nameof(GracePeriodInMinutes)); }
            set { BackingStore?.Set(nameof(GracePeriodInMinutes), value); }
        }
        /// <summary>The number of minutes to snooze the restart notification dialog when the snooze button is selected.</summary>
        public int? RestartNotificationSnoozeDurationInMinutes {
            get { return BackingStore?.Get<int?>(nameof(RestartNotificationSnoozeDurationInMinutes)); }
            set { BackingStore?.Set(nameof(RestartNotificationSnoozeDurationInMinutes), value); }
        }
        /// <summary>
        /// Instantiates a new win32LobAppRestartSettings and sets the default values.
        /// </summary>
        public Win32LobAppRestartSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Win32LobAppRestartSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Win32LobAppRestartSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"countdownDisplayBeforeRestartInMinutes", n => { CountdownDisplayBeforeRestartInMinutes = n.GetIntValue(); } },
                {"gracePeriodInMinutes", n => { GracePeriodInMinutes = n.GetIntValue(); } },
                {"restartNotificationSnoozeDurationInMinutes", n => { RestartNotificationSnoozeDurationInMinutes = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("countdownDisplayBeforeRestartInMinutes", CountdownDisplayBeforeRestartInMinutes);
            writer.WriteIntValue("gracePeriodInMinutes", GracePeriodInMinutes);
            writer.WriteIntValue("restartNotificationSnoozeDurationInMinutes", RestartNotificationSnoozeDurationInMinutes);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
