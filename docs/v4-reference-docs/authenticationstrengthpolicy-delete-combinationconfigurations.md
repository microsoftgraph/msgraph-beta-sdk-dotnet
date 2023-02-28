---
title: "Delete authenticationCombinationConfiguration"
description: "Delete an authenticationCombinationConfiguration for a custom authenticationStrengthPolicy object."
author: "mmcla"
ms.localizationpriority: medium
ms.prod: "identity-and-sign-in"
doc_type: apiPageType
---

# Delete authenticationCombinationConfiguration
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Delete an [authenticationCombinationConfiguration](../resources/authenticationcombinationconfiguration.md)  for a custom [authenticationStrengthPolicy](../resources/authenticationstrengthpolicy.md) object.

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
DELETE /identity/conditionalAccess/authenticationStrengths/policies/{authenticationStrengthPolicyId}/combinationConfigurations/{authenticationCombinationConfigurationId}/$ref
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `204 No Content` response code.

## Examples

### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "delete_authenticationcombinationconfiguration"
}
-->
``` http
DELETE https://graph.microsoft.com/beta/identity/conditionalAccess/authenticationStrengths/policies/0e371351-6419-4c8a-8047-61eef0212ffb/combinationConfigurations/6cbbcfd0-5054-4a59-a10e-2d21fe09305d
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Identity.ConditionalAccess.AuthenticationStrengths.Policies["{authenticationStrengthPolicy-id}"].CombinationConfigurations["{authenticationCombinationConfiguration-id}"]
	.Request()
	.DeleteAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
The following is an example of the response
<!-- {
  "blockType": "response",
  "truncated": true
}
-->
``` http
HTTP/1.1 204 No Content
```

