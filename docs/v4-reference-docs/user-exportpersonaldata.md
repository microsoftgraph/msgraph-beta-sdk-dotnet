---
title: "user: exportPersonalData"
description: "Submits a data policy operation request, made by a Company Administrator to export an organizational user's data."
ms.localizationpriority: medium
author: "yyuank"
ms.prod: "users"
doc_type: apiPageType
---

# user: exportPersonalData

Namespace: microsoft.graph

Submit a data policy operation request from a company administrator or an application to export an organizational user's data. This data includes the user's data stored in OneDrive and their activity reports. For more guidance about exporting data while complying with regulations, see [Data Subject Requests and the GDPR and CCPA](/compliance/regulatory/gdpr-data-subject-requests).

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) |  User.Export.All  |
|Delegated (personal Microsoft account) |  Not applicable  |
|Application | User.Export.All |

>**Note:** Export can only be performed by a company administrator when the delegated permission is used.

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /users/{id}/exportPersonalData

```
## Request headers
| Name       | Description |
|:---------------|:----------|
| Authorization  | Bearer {token}|

## Request body
In the request body, provide a JSON object with the following parameters.

| Parameter	   | Type	|Description |
|:---------------|:--------|:----------|
|storageLocation|String|This is a shared access signature (SAS) URL to an Azure Storage account, to where data should be exported.|

## Response
If successful, this method returns a `202 Accepted` response code. It does not return anything in the response body. The response contains the following headers.

| Name       | Description |
|:---------------|:----------|
| Location  | URL to check on the status of the Request. |
| Retry-After  | Time period in seconds. Request maker should wait this long after submitting a request to check for the status. |


## Example
##### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "user_exportpersonaldata"
}-->
```http
POST https://graph.microsoft.com/beta/users/{id}/exportPersonalData
Content-type: application/json

{
  "storageLocation": "storageLocation-value"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var storageLocation = "storageLocation-value";

await graphClient.Users["{user-id}"]
	.ExportPersonalData(storageLocation)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

