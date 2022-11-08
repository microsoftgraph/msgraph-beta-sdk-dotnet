using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class RiskUserActivity : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The possible values are none, adminGeneratedTemporaryPassword, userPerformedSecuredPasswordChange, userPerformedSecuredPasswordReset, adminConfirmedSigninSafe, aiConfirmedSigninSafe, userPassedMFADrivenByRiskBasedPolicy, adminDismissedAllRiskForUser, adminConfirmedSigninCompromised, hidden, adminConfirmedUserCompromised, unknownFutureValue.</summary>
        public RiskDetail? Detail {
            get { return BackingStore?.Get<RiskDetail?>("detail"); }
            set { BackingStore?.Set("detail", value); }
        }
        /// <summary>The eventTypes property</summary>
        public List<RiskEventType?> EventTypes {
            get { return BackingStore?.Get<List<RiskEventType?>>("eventTypes"); }
            set { BackingStore?.Set("eventTypes", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The riskEventTypes property</summary>
        public List<string> RiskEventTypes {
            get { return BackingStore?.Get<List<string>>("riskEventTypes"); }
            set { BackingStore?.Set("riskEventTypes", value); }
        }
        /// <summary>
        /// Instantiates a new riskUserActivity and sets the default values.
        /// </summary>
        public RiskUserActivity() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.riskUserActivity";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RiskUserActivity CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RiskUserActivity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"detail", n => { Detail = n.GetEnumValue<RiskDetail>(); } },
                {"eventTypes", n => { EventTypes = n.GetCollectionOfEnumValues<RiskEventType>()?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"riskEventTypes", n => { RiskEventTypes = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<RiskDetail>("detail", Detail);
            writer.WriteCollectionOfEnumValues<RiskEventType>("eventTypes", EventTypes);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfPrimitiveValues<string>("riskEventTypes", RiskEventTypes);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
