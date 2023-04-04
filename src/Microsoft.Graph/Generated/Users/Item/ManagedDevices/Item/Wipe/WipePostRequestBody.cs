using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Users.Item.ManagedDevices.Item.Wipe {
    public class WipePostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The keepEnrollmentData property</summary>
        public bool? KeepEnrollmentData {
            get { return BackingStore?.Get<bool?>("keepEnrollmentData"); }
            set { BackingStore?.Set("keepEnrollmentData", value); }
        }
        /// <summary>The keepUserData property</summary>
        public bool? KeepUserData {
            get { return BackingStore?.Get<bool?>("keepUserData"); }
            set { BackingStore?.Set("keepUserData", value); }
        }
        /// <summary>The macOsUnlockCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MacOsUnlockCode {
            get { return BackingStore?.Get<string?>("macOsUnlockCode"); }
            set { BackingStore?.Set("macOsUnlockCode", value); }
        }
#nullable restore
#else
        public string MacOsUnlockCode {
            get { return BackingStore?.Get<string>("macOsUnlockCode"); }
            set { BackingStore?.Set("macOsUnlockCode", value); }
        }
#endif
        /// <summary>The persistEsimDataPlan property</summary>
        public bool? PersistEsimDataPlan {
            get { return BackingStore?.Get<bool?>("persistEsimDataPlan"); }
            set { BackingStore?.Set("persistEsimDataPlan", value); }
        }
        /// <summary>The useProtectedWipe property</summary>
        public bool? UseProtectedWipe {
            get { return BackingStore?.Get<bool?>("useProtectedWipe"); }
            set { BackingStore?.Set("useProtectedWipe", value); }
        }
        /// <summary>
        /// Instantiates a new wipePostRequestBody and sets the default values.
        /// </summary>
        public WipePostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WipePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WipePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"keepEnrollmentData", n => { KeepEnrollmentData = n.GetBoolValue(); } },
                {"keepUserData", n => { KeepUserData = n.GetBoolValue(); } },
                {"macOsUnlockCode", n => { MacOsUnlockCode = n.GetStringValue(); } },
                {"persistEsimDataPlan", n => { PersistEsimDataPlan = n.GetBoolValue(); } },
                {"useProtectedWipe", n => { UseProtectedWipe = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("keepEnrollmentData", KeepEnrollmentData);
            writer.WriteBoolValue("keepUserData", KeepUserData);
            writer.WriteStringValue("macOsUnlockCode", MacOsUnlockCode);
            writer.WriteBoolValue("persistEsimDataPlan", PersistEsimDataPlan);
            writer.WriteBoolValue("useProtectedWipe", UseProtectedWipe);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
