using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class UserSecurityProfile : Entity, IParsable {
        public List<UserAccount> Accounts { get; set; }
        public string AzureSubscriptionId { get; set; }
        public string AzureTenantId { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
        public string DisplayName { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        public string RiskScore { get; set; }
        public List<string> Tags { get; set; }
        public string UserPrincipalName { get; set; }
        public SecurityVendorInformation VendorInformation { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accounts", (o,n) => { (o as UserSecurityProfile).Accounts = n.GetCollectionOfObjectValues<UserAccount>().ToList(); } },
                {"azureSubscriptionId", (o,n) => { (o as UserSecurityProfile).AzureSubscriptionId = n.GetStringValue(); } },
                {"azureTenantId", (o,n) => { (o as UserSecurityProfile).AzureTenantId = n.GetStringValue(); } },
                {"createdDateTime", (o,n) => { (o as UserSecurityProfile).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", (o,n) => { (o as UserSecurityProfile).DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as UserSecurityProfile).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"riskScore", (o,n) => { (o as UserSecurityProfile).RiskScore = n.GetStringValue(); } },
                {"tags", (o,n) => { (o as UserSecurityProfile).Tags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"userPrincipalName", (o,n) => { (o as UserSecurityProfile).UserPrincipalName = n.GetStringValue(); } },
                {"vendorInformation", (o,n) => { (o as UserSecurityProfile).VendorInformation = n.GetObjectValue<SecurityVendorInformation>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<UserAccount>("accounts", Accounts);
            writer.WriteStringValue("azureSubscriptionId", AzureSubscriptionId);
            writer.WriteStringValue("azureTenantId", AzureTenantId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("riskScore", RiskScore);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteObjectValue<SecurityVendorInformation>("vendorInformation", VendorInformation);
        }
    }
}
