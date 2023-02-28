---
title: Update printershare
description: Update the properties of printer share. This method can be used to "swap" printers.
author: braedenp-msft
ms.localizationpriority: medium
ms.prod: cloud-printing
doc_type: apiPageType
---

# Update printershare

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of a printer share. This method can be used to swap [printers](../resources/printer.md).

For example, if a physical printer device breaks, an administrator can register a new [printer](../resources/printer.md) device and update this [printerShare](../resources/printerShare.md) to point to the new printer without requiring users to take any action.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

In addition to the following permissions, the user or app's tenant must have an active Universal Print subscription. The signed in user must be a [Printer Administrator](/azure/active-directory/users-groups-roles/directory-assign-admin-roles#printer-administrator).

|Permission type | Permissions (from least to most privileged) |
|:---------------|:--------------------------------------------|
|Delegated (work or school account)| PrinterShare.ReadWrite.All |
|Delegated (personal Microsoft account)|Not Supported.|
|Application|Not Supported.|

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
PATCH /print/shares/{id}
```

## Request headers
| Name       | Description|
|:-----------|:-----------|
| Authorization | Bearer {token}. Required. |
| Content-type  | application/json. Required.|

## Request body
In the request body, supply the values for relevant [printerShare](../resources/printershare.md) fields that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values. For best performance, don't include existing values that haven't changed.

Following properties can be updated: 

| Property     | Type        | Description |
|:-------------|:------------|:------------|
|printer|microsoft.graph.printer|The printer that this printer share is related to. Use the `printer@odata.bind` syntax as shown in the following example to update which printer this printer share is associated with.|
|displayName|String|The name of the printer share that print clients should display.|
|allowAllUsers|Boolean|	If true, all users and groups will be granted access to this printer share. This supersedes the allow lists defined by the allowedUsers and allowedGroups navigation properties.|

## Response
If successful, this method returns a `200 OK` response code and an updated [printerShare](../resources/printershare.md) object in the response body.
## Example
##### Request
The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_printershare"
}-->
```http
PATCH https://graph.microsoft.com/beta/print/shares/{id}
Content-type: application/json

{
  "displayName": "ShareName",
  "allowAllUsers": true,
  "printer@odata.bind": "https://graph.microsoft.com/beta/print/printers/{id}"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var printerShare = new PrinterShare
{
	DisplayName = "ShareName",
	AllowAllUsers = true,
	AdditionalData = new Dictionary<string, object>()
	{
		{"printer@odata.bind", "https://graph.microsoft.com/beta/print/printers/{id}"}
	}
};

await graphClient.Print.Shares["{printerShare-id}"]
	.Request()
	.UpdateAsync(printerShare);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

