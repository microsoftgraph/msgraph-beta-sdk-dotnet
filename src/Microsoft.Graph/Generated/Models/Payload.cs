using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Payload : Entity, IParsable {
        /// <summary>The brand property</summary>
        public PayloadBrand? Brand {
            get { return BackingStore?.Get<PayloadBrand?>("brand"); }
            set { BackingStore?.Set("brand", value); }
        }
        /// <summary>The complexity property</summary>
        public PayloadComplexity? Complexity {
            get { return BackingStore?.Get<PayloadComplexity?>("complexity"); }
            set { BackingStore?.Set("complexity", value); }
        }
        /// <summary>The createdBy property</summary>
        public EmailIdentity CreatedBy {
            get { return BackingStore?.Get<EmailIdentity>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The description property</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>The detail property</summary>
        public PayloadDetail Detail {
            get { return BackingStore?.Get<PayloadDetail>("detail"); }
            set { BackingStore?.Set("detail", value); }
        }
        /// <summary>The displayName property</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The industry property</summary>
        public PayloadIndustry? Industry {
            get { return BackingStore?.Get<PayloadIndustry?>("industry"); }
            set { BackingStore?.Set("industry", value); }
        }
        /// <summary>The isAutomated property</summary>
        public bool? IsAutomated {
            get { return BackingStore?.Get<bool?>("isAutomated"); }
            set { BackingStore?.Set("isAutomated", value); }
        }
        /// <summary>The isControversial property</summary>
        public bool? IsControversial {
            get { return BackingStore?.Get<bool?>("isControversial"); }
            set { BackingStore?.Set("isControversial", value); }
        }
        /// <summary>The isCurrentEvent property</summary>
        public bool? IsCurrentEvent {
            get { return BackingStore?.Get<bool?>("isCurrentEvent"); }
            set { BackingStore?.Set("isCurrentEvent", value); }
        }
        /// <summary>The language property</summary>
        public string Language {
            get { return BackingStore?.Get<string>("language"); }
            set { BackingStore?.Set("language", value); }
        }
        /// <summary>The lastModifiedBy property</summary>
        public EmailIdentity LastModifiedBy {
            get { return BackingStore?.Get<EmailIdentity>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The payloadTags property</summary>
        public List<string> PayloadTags {
            get { return BackingStore?.Get<List<string>>("payloadTags"); }
            set { BackingStore?.Set("payloadTags", value); }
        }
        /// <summary>The platform property</summary>
        public PayloadDeliveryPlatform? Platform {
            get { return BackingStore?.Get<PayloadDeliveryPlatform?>("platform"); }
            set { BackingStore?.Set("platform", value); }
        }
        /// <summary>The predictedCompromiseRate property</summary>
        public double? PredictedCompromiseRate {
            get { return BackingStore?.Get<double?>("predictedCompromiseRate"); }
            set { BackingStore?.Set("predictedCompromiseRate", value); }
        }
        /// <summary>The simulationAttackType property</summary>
        public Microsoft.Graph.Beta.Models.SimulationAttackType? SimulationAttackType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SimulationAttackType?>("simulationAttackType"); }
            set { BackingStore?.Set("simulationAttackType", value); }
        }
        /// <summary>The source property</summary>
        public SimulationContentSource? Source {
            get { return BackingStore?.Get<SimulationContentSource?>("source"); }
            set { BackingStore?.Set("source", value); }
        }
        /// <summary>The status property</summary>
        public SimulationContentStatus? Status {
            get { return BackingStore?.Get<SimulationContentStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The technique property</summary>
        public SimulationAttackTechnique? Technique {
            get { return BackingStore?.Get<SimulationAttackTechnique?>("technique"); }
            set { BackingStore?.Set("technique", value); }
        }
        /// <summary>The theme property</summary>
        public PayloadTheme? Theme {
            get { return BackingStore?.Get<PayloadTheme?>("theme"); }
            set { BackingStore?.Set("theme", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Payload CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Payload();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"brand", n => { Brand = n.GetEnumValue<PayloadBrand>(); } },
                {"complexity", n => { Complexity = n.GetEnumValue<PayloadComplexity>(); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<EmailIdentity>(EmailIdentity.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"detail", n => { Detail = n.GetObjectValue<PayloadDetail>(PayloadDetail.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"industry", n => { Industry = n.GetEnumValue<PayloadIndustry>(); } },
                {"isAutomated", n => { IsAutomated = n.GetBoolValue(); } },
                {"isControversial", n => { IsControversial = n.GetBoolValue(); } },
                {"isCurrentEvent", n => { IsCurrentEvent = n.GetBoolValue(); } },
                {"language", n => { Language = n.GetStringValue(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<EmailIdentity>(EmailIdentity.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"payloadTags", n => { PayloadTags = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"platform", n => { Platform = n.GetEnumValue<PayloadDeliveryPlatform>(); } },
                {"predictedCompromiseRate", n => { PredictedCompromiseRate = n.GetDoubleValue(); } },
                {"simulationAttackType", n => { SimulationAttackType = n.GetEnumValue<SimulationAttackType>(); } },
                {"source", n => { Source = n.GetEnumValue<SimulationContentSource>(); } },
                {"status", n => { Status = n.GetEnumValue<SimulationContentStatus>(); } },
                {"technique", n => { Technique = n.GetEnumValue<SimulationAttackTechnique>(); } },
                {"theme", n => { Theme = n.GetEnumValue<PayloadTheme>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<PayloadBrand>("brand", Brand);
            writer.WriteEnumValue<PayloadComplexity>("complexity", Complexity);
            writer.WriteObjectValue<EmailIdentity>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteObjectValue<PayloadDetail>("detail", Detail);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<PayloadIndustry>("industry", Industry);
            writer.WriteBoolValue("isAutomated", IsAutomated);
            writer.WriteBoolValue("isControversial", IsControversial);
            writer.WriteBoolValue("isCurrentEvent", IsCurrentEvent);
            writer.WriteStringValue("language", Language);
            writer.WriteObjectValue<EmailIdentity>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("payloadTags", PayloadTags);
            writer.WriteEnumValue<PayloadDeliveryPlatform>("platform", Platform);
            writer.WriteDoubleValue("predictedCompromiseRate", PredictedCompromiseRate);
            writer.WriteEnumValue<SimulationAttackType>("simulationAttackType", SimulationAttackType);
            writer.WriteEnumValue<SimulationContentSource>("source", Source);
            writer.WriteEnumValue<SimulationContentStatus>("status", Status);
            writer.WriteEnumValue<SimulationAttackTechnique>("technique", Technique);
            writer.WriteEnumValue<PayloadTheme>("theme", Theme);
        }
    }
}
