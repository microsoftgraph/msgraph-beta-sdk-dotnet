using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class CustomerPaymentJournal : Entity, IParsable {
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Account Account { get; set; }
        public string BalancingAccountId { get; set; }
        public string BalancingAccountNumber { get; set; }
        public string Code { get; set; }
        public List<CustomerPayment> CustomerPayments { get; set; }
        public string DisplayName { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CustomerPaymentJournal CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CustomerPaymentJournal();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"account", (o,n) => { (o as CustomerPaymentJournal).Account = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Account>(MicrosoftGraphSdk.Models.Microsoft.Graph.Account.CreateFromDiscriminatorValue); } },
                {"balancingAccountId", (o,n) => { (o as CustomerPaymentJournal).BalancingAccountId = n.GetStringValue(); } },
                {"balancingAccountNumber", (o,n) => { (o as CustomerPaymentJournal).BalancingAccountNumber = n.GetStringValue(); } },
                {"code", (o,n) => { (o as CustomerPaymentJournal).Code = n.GetStringValue(); } },
                {"customerPayments", (o,n) => { (o as CustomerPaymentJournal).CustomerPayments = n.GetCollectionOfObjectValues<CustomerPayment>(CustomerPayment.CreateFromDiscriminatorValue).ToList(); } },
                {"displayName", (o,n) => { (o as CustomerPaymentJournal).DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as CustomerPaymentJournal).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Account>("account", Account);
            writer.WriteStringValue("balancingAccountId", BalancingAccountId);
            writer.WriteStringValue("balancingAccountNumber", BalancingAccountNumber);
            writer.WriteStringValue("code", Code);
            writer.WriteCollectionOfObjectValues<CustomerPayment>("customerPayments", CustomerPayments);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
        }
    }
}
