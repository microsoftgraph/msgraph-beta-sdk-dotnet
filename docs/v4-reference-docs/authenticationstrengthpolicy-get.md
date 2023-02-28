---
title: "Get authenticationStrengthPolicy"
description: "Read the properties and relationships of an authenticationStrengthPolicy object."
author: "mmcla"
ms.localizationpriority: medium
ms.prod: "identity-and-sign-in"
doc_type: apiPageType
---

# Get authenticationStrengthPolicy
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Read the properties and relationships of an [authenticationStrengthPolicy](../resources/authenticationstrengthpolicy.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|Policy.Read.All, Policy.ReadWrite.ConditionalAccess, Policy.ReadWrite.AuthenticationMethod|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Policy.Read.All, Policy.ReadWrite.ConditionalAccess, Policy.ReadWrite.AuthenticationMethod|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /policies/authenticationStrengthPolicies/{authenticationStrengthPolicyId}
```

## Optional query parameters
This method does not support OData query parameters.

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and an [authenticationStrengthPolicy](../resources/authenticationstrengthpolicy.md) object in the response body.

## Examples

### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_authenticationstrengthpolicy"
}
-->
``` http
GET https://graph.microsoft.com/beta/policies/authenticationStrengthPolicies/00000000-0000-0000-0000-000000000004
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var authenticationStrengthPolicy = await graphClient.Policies.AuthenticationStrengthPolicies["{authenticationStrengthPolicy-id}"]
	.Request()
	.GetAsync();

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
HTTP/1.1 200 OK
Content-Type: application/json

{
  "@odata.type" : "#microsoft.graph.authenticationStrengthPolicy",
  "id": "00000000-0000-0000-0000-000000000004",
  "createdDateTime": "2017-10-30T10:59:01Z",
  "modifiedDateTime": "2017-10-30T10:59:01Z",
  "displayName": "Phishing resistant MFA",
  "description": "Phishing-resistant, Passwordless methods for the strongest authentication, such as a FIDO2 security key",
  "policyType": "builtIn",
  "requirementsSatisfied": "mfa",
  "allowedCombinations": [
      "windowsHelloForBusiness",
      "fido2",
      "x509CertificateMultiFactor"
  ],
  "combinationConfigurations": []
}
```

