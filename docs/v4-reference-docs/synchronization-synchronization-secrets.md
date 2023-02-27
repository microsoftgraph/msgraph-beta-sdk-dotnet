---
title: "synchronization: secrets"
description: "Provide credentials for establishing connectivity with the target system."
ms.localizationpriority: medium
doc_type: apiPageType
author: "ArvindHarinder1"
ms.prod: "applications"
---

# synchronization: secrets

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Provide credentials for establishing connectivity with the target system.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type                        | Permissions (from least to most privileged)              |
|:--------------------------------------|:---------------------------------------------------------|
|Delegated (work or school account)     |Directory.ReadWrite.All  |
|Delegated (personal Microsoft account) |Not supported. |
|Application                            |Application.ReadWrite.OwnedBy, Directory.ReadWrite.All | 

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
PUT /servicePrincipals/{id}/synchronization/secrets
```

## Request headers
| Name       | Description|
|:---------------|:----------|
| Authorization  | Bearer {code}|

## Request body
In the request body, provide a JSON object with the following parameters.

| Parameter	   | Type	|Description|
|:---------------|:--------|:----------|
|credentials|[synchronizationSecretKeyStringValuePair](../resources/synchronization-synchronizationsecretkeystringvaluepair.md) collection|Credentials to validate. Ignored when the **useSavedCredentials** parameter is `true`.|

## Response
If the secrets are successfully saved, this method returns a `204 No Content` response code. It does not return anything in the response body.

## Example

### Request
The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "synchronization_secrets"
}-->
```http
PUT https://graph.microsoft.com/beta/servicePrincipals/{id}/synchronization/secrets
Content-type: application/json

{
    "value": [
        {
            "key": "BaseAddress",
            "value": "user@domain.com"
        },
        {
            "key": "SecretToken",
            "value": "password-value"
        },
        {
            "key": "SyncNotificationSettings",
            "value": "{\"Enabled\":false,\"DeleteThresholdEnabled\":false}"
        },
        {
            "key": "SyncAll",
            "value": "false"
        }
    ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var secrets = new SynchronizationSecretKeyStringValuePair
{
	Value = new List<String>()
	{
		"",
		"",
		"",
		""
	}
};

await graphClient.ServicePrincipals["{servicePrincipal-id}"].Synchronization
	.Request()
	.PutAsync(secrets);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
The following is an example of the response. 
<!-- {
  "blockType": "response"
} -->
```http
HTTP/1.1 204 No Content
```

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "synchronization: secrets",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->
