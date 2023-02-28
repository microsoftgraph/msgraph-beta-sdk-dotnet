---
title: Create printerShare
description: Creates a new printer share for the specified printer.
author: braedenp-msft
ms.localizationpriority: medium
ms.prod: cloud-printing
doc_type: apiPageType
---

# Create printerShare

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new **printerShare** for the specified [printer](../resources/printer.md).

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

To use the Universal Print service, the user or app's tenant must have an active Universal Print subscription, in addition to the permissions listed in the following table. The signed in user must be a [Printer Administrator](/azure/active-directory/users-groups-roles/directory-assign-admin-roles#printer-administrator).

|Permission type | Permissions (from least to most privileged) |
|:---------------|:--------------------------------------------|
|Delegated (work or school account)| PrinterShare.ReadWrite.All |
|Delegated (personal Microsoft account)|Not Supported.|
|Application|Not Supported.|

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /print/shares
```
## Request headers
| Name          | Description   |
|:--------------|:--------------|
| Authorization | Bearer {token}. Required. |
| Content-type  | application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [printerShare](../resources/printershare.md) object.

The following table shows the properties that can be provided when you create the [printerShare](../resources/printershare.md).

|Property|Type|Description|Required?|
|:---|:---|:---|:---|
|printer|microsoft.graph.printer|The printer that this printer share is related to. Use the `printer@odata.bind` syntax as shown in the following example.|Yes|
|displayName|String|The name of the printer share that print clients should display. Maximum length allowed is 50 characters.|Yes|
|allowAllUsers|Boolean|	If true, all users and groups will be granted access to this printer share. This supersedes the allow lists defined by the allowedUsers and allowedGroups navigation properties.|No|

## Response
If successful, this method returns a `201 Created` response code and a [printerShare](../resources/printershare.md) object in the response body.

## Example
##### Request
The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_printershare_from_print"
}-->
```http
POST https://graph.microsoft.com/beta/print/shares
Content-type: application/json

{
  "name": "name-value",
  "printer@odata.bind": "https://graph.microsoft.com/beta/print/printers/{id}"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var printerShare = new PrinterShare
{
	Name = "name-value",
	AdditionalData = new Dictionary<string, object>()
	{
		{"printer@odata.bind", "https://graph.microsoft.com/beta/print/printers/{id}"}
	}
};

await graphClient.Print.Shares
	.Request()
	.AddAsync(printerShare);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

