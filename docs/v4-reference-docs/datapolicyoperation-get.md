---
title: "Get dataPolicyOperation"
description: "Retrieve the properties of the dataPolicyOperation object."
ms.localizationpriority: medium
author: "dkershaw10"
ms.prod: "identity-and-sign-in"
doc_type: apiPageType
---

# Get dataPolicyOperation

Namespace: microsoft.graph

Retrieve the properties of the dataPolicyOperation object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) |  User.Export.All and User.Read.All  |
|Delegated (personal Microsoft account) |  Not applicable  |
|Application | User.Export.All and User.Read.All | 

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
GET /dataPolicyOperations/{id}
```

## Request headers
| Name      |Description|
|:----------|:----------|
| Authorization  | Bearer {token}|

## Request body
Do not supply a request body for this method.
## Response
If successful, this method returns a `200 OK` response code and [dataPolicyOperation](../resources/datapolicyoperation.md) object in the response body.
## Example
##### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_datapolicyoperation"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/dataPolicyOperations/{id}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var dataPolicyOperation = await graphClient.DataPolicyOperations["{dataPolicyOperation-id}"]
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

