using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class OnPremisesDirectorySynchronizationConfiguration : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Contains the accidental deletion prevention configuration for a tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public OnPremisesAccidentalDeletionPrevention? AccidentalDeletionPrevention {
            get { return BackingStore?.Get<OnPremisesAccidentalDeletionPrevention?>("accidentalDeletionPrevention"); }
            set { BackingStore?.Set("accidentalDeletionPrevention", value); }
        }
#else
        public OnPremisesAccidentalDeletionPrevention AccidentalDeletionPrevention {
            get { return BackingStore?.Get<OnPremisesAccidentalDeletionPrevention>("accidentalDeletionPrevention"); }
            set { BackingStore?.Set("accidentalDeletionPrevention", value); }
        }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Interval of time that the customer requested the sync client waits between sync cycles.</summary>
        public TimeSpan? CustomerRequestedSynchronizationInterval {
            get { return BackingStore?.Get<TimeSpan?>("customerRequestedSynchronizationInterval"); }
            set { BackingStore?.Set("customerRequestedSynchronizationInterval", value); }
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
        /// <summary>Interval of time the sync client should honor between sync cycles</summary>
        public TimeSpan? SynchronizationInterval {
            get { return BackingStore?.Get<TimeSpan?>("synchronizationInterval"); }
            set { BackingStore?.Set("synchronizationInterval", value); }
        }
        /// <summary>
        /// Instantiates a new onPremisesDirectorySynchronizationConfiguration and sets the default values.
        /// </summary>
        public OnPremisesDirectorySynchronizationConfiguration() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static OnPremisesDirectorySynchronizationConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnPremisesDirectorySynchronizationConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"accidentalDeletionPrevention", n => { AccidentalDeletionPrevention = n.GetObjectValue<OnPremisesAccidentalDeletionPrevention>(OnPremisesAccidentalDeletionPrevention.CreateFromDiscriminatorValue); } },
                {"customerRequestedSynchronizationInterval", n => { CustomerRequestedSynchronizationInterval = n.GetTimeSpanValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"synchronizationInterval", n => { SynchronizationInterval = n.GetTimeSpanValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<OnPremisesAccidentalDeletionPrevention>("accidentalDeletionPrevention", AccidentalDeletionPrevention);
            writer.WriteTimeSpanValue("customerRequestedSynchronizationInterval", CustomerRequestedSynchronizationInterval);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteTimeSpanValue("synchronizationInterval", SynchronizationInterval);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
