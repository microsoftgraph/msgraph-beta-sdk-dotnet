using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedTenants {
    public class TemplateAction : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.LicenseDetails Licenses { get; set; }
        public string Service { get; set; }
        public List<Setting> Settings { get; set; }
        public string TemplateActionId { get; set; }
        /// <summary>
        /// Instantiates a new templateAction and sets the default values.
        /// </summary>
        public TemplateAction() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"description", (o,n) => { (o as TemplateAction).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as TemplateAction).DisplayName = n.GetStringValue(); } },
                {"licenses", (o,n) => { (o as TemplateAction).Licenses = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.LicenseDetails>(); } },
                {"service", (o,n) => { (o as TemplateAction).Service = n.GetStringValue(); } },
                {"settings", (o,n) => { (o as TemplateAction).Settings = n.GetCollectionOfObjectValues<Setting>().ToList(); } },
                {"templateActionId", (o,n) => { (o as TemplateAction).TemplateActionId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.LicenseDetails>("licenses", Licenses);
            writer.WriteStringValue("service", Service);
            writer.WriteCollectionOfObjectValues<Setting>("settings", Settings);
            writer.WriteStringValue("templateActionId", TemplateActionId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
