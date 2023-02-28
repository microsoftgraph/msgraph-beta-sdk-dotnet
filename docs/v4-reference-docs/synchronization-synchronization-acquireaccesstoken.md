---
title: "synchronization: acquireAccessToken"
description: "Acquire an OAuth Access token to authorize the Azure AD provisioning service to provision users into an application"
author: "ArvindHarinder1"
ms.localizationpriority: medium
ms.prod: "applications"
doc_type: apiPageType
---

# acquireAccessToken
Namespace: microsoft.graph

Acquire an OAuth Access token to authorize the Azure AD provisioning service to provision users into an application.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|Directory.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Application.ReadWrite.OwnedBy, Directory.ReadWrite.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /applications/{applicationsId}/synchronization/acquireAccessToken
POST /servicePrincipals/{servicePrincipalsId}/synchronization/acquireAccessToken
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply JSON representation of the parameters.

The following table shows the parameters that can be used with this action.

|Parameter|Type|Description|
|:---|:---|:---|
|credentials|[synchronizationSecretKeyStringValuePair](../resources/synchronization-synchronizationsecretkeystringvaluepair.md) collection|Represents a single secret value.|



## Response

If successful, this action returns a `204 No Content` response code.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "synchronization_acquireaccesstoken"
}
-->
``` http
POST https://graph.microsoft.com/beta/applications/{applicationsId}/synchronization/acquireAccessToken
Content-Type: application/json

{
  "credentials": [
    {
      "@odata.type": "microsoft.graph.synchronizationSecretKeyStringValuePair"
    }
  ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var credentials = new List<SynchronizationSecretKeyStringValuePair>()
{
	new SynchronizationSecretKeyStringValuePair
	{
	}
};

await graphClient.Applications["{application-id}"].Synchronization
	.AcquireAccessToken(credentials)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true
}
-->
``` http
HTTP/1.1 204 No Content
```


