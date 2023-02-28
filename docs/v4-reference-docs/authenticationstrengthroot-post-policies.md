---
title: "Create authenticationStrengthPolicy"
description: "Create a new custom authenticationStrengthPolicy object."
author: "mmcla"
ms.localizationpriority: medium
ms.prod: "identity-and-sign-in"
doc_type: apiPageType
---

# Create authenticationStrengthPolicy
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new custom [authenticationStrengthPolicy](../resources/authenticationstrengthpolicy.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|Policy.ReadWrite.ConditionalAccess, Policy.ReadWrite.AuthenticationMethod|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Policy.ReadWrite.ConditionalAccess, Policy.ReadWrite.AuthenticationMethod|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /policies/authenticationStrengthPolicies
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [authenticationStrengthPolicy](../resources/authenticationstrengthpolicy.md) object.

You can specify the following properties when creating an **authenticationStrengthPolicy**.

|Property|Type|Description|
|:---|:---|:---|
|displayName|String|The display name of the policy to be created. Required.|
|description|String|The description of the policy to be created. Optional.|
|allowedCombinations|authenticationMethodModes collection|The authentication method combinations allowed by this authentication strength policy. The possible values of this flagged enum are: `password`, `voice`, `hardwareOath`, `softwareOath`, `sms`, `fido2`, `windowsHelloForBusiness`, `microsoftAuthenticatorPush`, `deviceBasedPush`, `temporaryAccessPassOneTime`, `temporaryAccessPassMultiUse`, `email`, `x509CertificateSingleFactor`, `x509CertificateMultiFactor`, `federatedSingleFactor`, `federatedMultiFactor`, `unknownFutureValue`. For the list of allowed combinations, call the [List authenticationMethodModes](../api/authenticationstrengthroot-list-authenticationmethodmodes.md) API. Required.|

## Response

If successful, this method returns a `201 Created` response code and an [authenticationStrengthPolicy](../resources/authenticationstrengthpolicy.md) object in the response body.

## Examples

### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_authenticationstrengthpolicy_from_"
}
-->
``` http
POST https://graph.microsoft.com/beta/policies/authenticationStrengthPolicies
Content-Type: application/json
Content-length: 239

{
  "@odata.type" : "#microsoft.graph.authenticationStrengthPolicy",
  "displayName": "Contoso authentication level",
  "description": "The only authentication level allowed to access our secret apps",
  "allowedCombinations": [
      "password, hardwareOath",
      "password, sms"
  ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var authenticationStrengthPolicy = new AuthenticationStrengthPolicy
{
	DisplayName = "Contoso authentication level",
	Description = "The only authentication level allowed to access our secret apps",
	AllowedCombinations = new List<AuthenticationMethodModes>()
	{
		AuthenticationMethodModes.Password | AuthenticationMethodModes.HardwareOath,
		AuthenticationMethodModes.Password | AuthenticationMethodModes.Sms
	}
};

await graphClient.Policies.AuthenticationStrengthPolicies
	.Request()
	.AddAsync(authenticationStrengthPolicy);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
The following is an example of the response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.authenticationStrengthPolicy"
}
-->
``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
  "@odata.type" : "authenticationStrengthPolicy",
  "id": "dd055c42-4218-4281-8631-f090e171f5cd",
  "createdDateTime": "2022-09-30T10:59:01Z",
  "modifiedDateTime": "2022-09-30T10:59:01Z",
  "displayName": "Contoso authentication level",
  "description": "The only authentication level allowed to access our secret apps",
  "policyType": "custom",
  "requirementsSatisfied": "mfa",
  "allowedCombinations": [
      "password, hardwareOath",
      "password, sms"
  ],
  "combinationConfigurations": []
}

```

