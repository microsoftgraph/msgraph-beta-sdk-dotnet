---
title: "Update authenticationStrengthPolicy"
description: "Update the properties of an authenticationStrengthPolicy object."
author: "mmcla"
ms.localizationpriority: medium
ms.prod: "identity-and-sign-in"
doc_type: apiPageType
---

# Update authenticationStrengthPolicy
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of an [authenticationStrengthPolicy](../resources/authenticationstrengthpolicy.md) object. You cannot update the allowed auth method combinations using this request. To do so, use the [Update allowed combinations](authenticationstrengthpolicy-updateallowedcombinations.md) action.

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
PATCH /policies/authenticationStrengthPolicies/{authenticationStrengthPolicyId}
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply *only* the values for properties that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values.

The following table specifies the properties that can be updated.

|Property|Type|Description|
|:---|:---|:---|
|displayName|String|The display name of the policy to be created. Optional.|
|description|String|The description of the policy to be created. Optional.|

## Response

If successful, this method returns a `204 NO CONTENT` response code.

## Examples

### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_authenticationstrengthpolicy"
}
-->
``` http
PATCH https://graph.microsoft.com/beta/policies/authenticationStrengthPolicies/a34a4c89-c5bf-4c0b-927d-adc396bf1f19
Content-Type: application/json
Content-length: 239

{
  "@odata.type": "#microsoft.graph.authenticationStrengthPolicy",
  "displayName": "FIDO2 only",
  "description": "An auth strength allowing only FIDO2 security keys."
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var authenticationStrengthPolicy = new AuthenticationStrengthPolicy
{
	DisplayName = "FIDO2 only",
	Description = "An auth strength allowing only FIDO2 security keys."
};

await graphClient.Policies.AuthenticationStrengthPolicies["{authenticationStrengthPolicy-id}"]
	.Request()
	.UpdateAsync(authenticationStrengthPolicy);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
The following is an example of the response
<!-- {
  "blockType": "response",
  "truncated": true,
}
-->
``` http
HTTP/1.1 204 No Content
```

