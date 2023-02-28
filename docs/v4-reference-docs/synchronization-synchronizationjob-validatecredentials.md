---
title: "synchronizationJob: validateCredentials"
description: "Validate that the credentials are valid in the tenant."
ms.localizationpriority: medium
doc_type: apiPageType
author: "ArvindHarinder1"
ms.prod: "applications"
---

# synchronizationJob: validateCredentials

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Validate that the credentials are valid in the tenant.

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
POST /servicePrincipals/{id}/synchronization/jobs/{id}/validateCredentials

```
## Request headers
| Name       | Description|
|:---------------|:----------|
| Authorization  | Bearer {code}|

## Request body
In the request body, provide a JSON object with the following parameters.

| Parameter	   | Type	|Description|
|:---------------|:--------|:----------|
|useSavedCredentials|Boolean|When `true`, the `credentials` parameter will be ignored and the previously saved credentials (if any) will be validated instead. |
|credentials|[synchronizationSecretKeyStringValuePair](../resources/synchronization-synchronizationsecretkeystringvaluepair.md) collection|Credentials to validate. Ignored when the `useSavedCredentials` parameter is `true`.|

## Response
If validation is successful, this method returns a `204, No Content` response code. It does not return anything in the response body.

## Example

##### Request
The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "synchronizationjob_validatecredentials"
}-->
```http
POST https://graph.microsoft.com/beta/servicePrincipals/{id}/synchronization/jobs/{id}/validateCredentials
Content-type: application/json

{ 
    credentials: [ 
        { key: "UserName", value: "user@domain.com" },
        { key: "Password", value: "password-value" }
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
		Key = SynchronizationSecret.UserName,
		Value = "user@domain.com"
	},
	new SynchronizationSecretKeyStringValuePair
	{
		Key = SynchronizationSecret.Password,
		Value = "password-value"
	}
};

await graphClient.ServicePrincipals["{servicePrincipal-id}"].Synchronization.Jobs["{synchronizationJob-id}"]
	.ValidateCredentials(null,null,null,credentials)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

