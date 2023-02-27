---
title: "Update authenticationCombinationConfiguration"
description: "Update the properties of an authenticationCombinationConfiguration object."
author: "mmcla"
ms.localizationpriority: medium
ms.prod: "identity-and-sign-in"
doc_type: apiPageType
---

# Update authenticationCombinationConfiguration
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of an [authenticationCombinationConfiguration](../resources/authenticationcombinationconfiguration.md) object. In use, only [fido2combinationConfigurations](../resources/fido2combinationconfiguration.md) may be updated as they are the only type of [authenticationCombinationConfiguration](../resources/authenticationcombinationconfiguration.md) that may be created.

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
PATCH /identity/conditionalAccess/authenticationStrengths/policies/{authenticationStrengthPolicyId}/combinationConfigurations/{authenticationCombinationConfigurationId}
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
|appliesToCombinations|authenticationMethodModes collection|The combinations to which this configuration applies. The only possible value for fido2combinationConfigurations is `fido2`. Required.|



## Response

If successful, this method returns a `204 NO CONTENT` response code.

## Examples

### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_authenticationcombinationconfiguration"
}
-->
``` http
PATCH https://graph.microsoft.com/beta/identity/conditionalAccess/authenticationStrengths/policies/0e371351-6419-4c8a-8047-61eef0212ffb/combinationConfigurations/4643f174-fe85-42b8-8b84-516775750a30
Content-Type: application/json
Content-length: 130

{
  "appliesToCombinations": ["fido2"]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var authenticationCombinationConfiguration = new AuthenticationCombinationConfiguration
{
	AppliesToCombinations = new List<AuthenticationMethodModes>()
	{
		AuthenticationMethodModes.Fido2
	}
};

await graphClient.Identity.ConditionalAccess.AuthenticationStrengths.Policies["{authenticationStrengthPolicy-id}"].CombinationConfigurations["{authenticationCombinationConfiguration-id}"]
	.Request()
	.UpdateAsync(authenticationCombinationConfiguration);

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

