using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.Wipe {
    /// <summary>Provides operations to call the wipe method.</summary>
    public class WipeRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The keepEnrollmentData property</summary>
        public bool? KeepEnrollmentData { get; set; }
        /// <summary>The keepUserData property</summary>
        public bool? KeepUserData { get; set; }
        /// <summary>The macOsUnlockCode property</summary>
        public string MacOsUnlockCode { get; set; }
        /// <summary>The persistEsimDataPlan property</summary>
        public bool? PersistEsimDataPlan { get; set; }
        /// <summary>The useProtectedWipe property</summary>
        public bool? UseProtectedWipe { get; set; }
        /// <summary>
        /// Instantiates a new wipeRequestBody and sets the default values.
        /// </summary>
        public WipeRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static WipeRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WipeRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"keepEnrollmentData", (o,n) => { (o as WipeRequestBody).KeepEnrollmentData = n.GetBoolValue(); } },
                {"keepUserData", (o,n) => { (o as WipeRequestBody).KeepUserData = n.GetBoolValue(); } },
                {"macOsUnlockCode", (o,n) => { (o as WipeRequestBody).MacOsUnlockCode = n.GetStringValue(); } },
                {"persistEsimDataPlan", (o,n) => { (o as WipeRequestBody).PersistEsimDataPlan = n.GetBoolValue(); } },
                {"useProtectedWipe", (o,n) => { (o as WipeRequestBody).UseProtectedWipe = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
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
