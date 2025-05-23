// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public enum RiskDetail
    #pragma warning restore CS1591
    {
        [EnumMember(Value = "none")]
        #pragma warning disable CS1591
        None,
        #pragma warning restore CS1591
        [EnumMember(Value = "adminGeneratedTemporaryPassword")]
        #pragma warning disable CS1591
        AdminGeneratedTemporaryPassword,
        #pragma warning restore CS1591
        [EnumMember(Value = "userPerformedSecuredPasswordChange")]
        #pragma warning disable CS1591
        UserPerformedSecuredPasswordChange,
        #pragma warning restore CS1591
        [EnumMember(Value = "userPerformedSecuredPasswordReset")]
        #pragma warning disable CS1591
        UserPerformedSecuredPasswordReset,
        #pragma warning restore CS1591
        [EnumMember(Value = "adminConfirmedSigninSafe")]
        #pragma warning disable CS1591
        AdminConfirmedSigninSafe,
        #pragma warning restore CS1591
        [EnumMember(Value = "aiConfirmedSigninSafe")]
        #pragma warning disable CS1591
        AiConfirmedSigninSafe,
        #pragma warning restore CS1591
        [EnumMember(Value = "userPassedMFADrivenByRiskBasedPolicy")]
        #pragma warning disable CS1591
        UserPassedMFADrivenByRiskBasedPolicy,
        #pragma warning restore CS1591
        [EnumMember(Value = "adminDismissedAllRiskForUser")]
        #pragma warning disable CS1591
        AdminDismissedAllRiskForUser,
        #pragma warning restore CS1591
        [EnumMember(Value = "adminConfirmedSigninCompromised")]
        #pragma warning disable CS1591
        AdminConfirmedSigninCompromised,
        #pragma warning restore CS1591
        [EnumMember(Value = "hidden")]
        #pragma warning disable CS1591
        Hidden,
        #pragma warning restore CS1591
        [EnumMember(Value = "adminConfirmedUserCompromised")]
        #pragma warning disable CS1591
        AdminConfirmedUserCompromised,
        #pragma warning restore CS1591
        [EnumMember(Value = "unknownFutureValue")]
        #pragma warning disable CS1591
        UnknownFutureValue,
        #pragma warning restore CS1591
        [EnumMember(Value = "adminConfirmedServicePrincipalCompromised")]
        #pragma warning disable CS1591
        AdminConfirmedServicePrincipalCompromised,
        #pragma warning restore CS1591
        [EnumMember(Value = "adminDismissedAllRiskForServicePrincipal")]
        #pragma warning disable CS1591
        AdminDismissedAllRiskForServicePrincipal,
        #pragma warning restore CS1591
        [EnumMember(Value = "m365DAdminDismissedDetection")]
        #pragma warning disable CS1591
        M365DAdminDismissedDetection,
        #pragma warning restore CS1591
        [EnumMember(Value = "userChangedPasswordOnPremises")]
        #pragma warning disable CS1591
        UserChangedPasswordOnPremises,
        #pragma warning restore CS1591
        [EnumMember(Value = "adminDismissedRiskForSignIn")]
        #pragma warning disable CS1591
        AdminDismissedRiskForSignIn,
        #pragma warning restore CS1591
        [EnumMember(Value = "adminConfirmedAccountSafe")]
        #pragma warning disable CS1591
        AdminConfirmedAccountSafe,
        #pragma warning restore CS1591
    }
}
