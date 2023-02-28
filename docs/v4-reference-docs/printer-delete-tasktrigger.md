---
title: Delete taskTrigger
description: Delete a printer's task trigger.
author: braedenp-msft
ms.localizationpriority: medium
ms.prod: cloud-printing
doc_type: apiPageType
---

# Delete taskTrigger

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Delete a [printer](../resources/printer.md)'s [task trigger](../resources/printtasktrigger.md) to prevent related print events from triggering tasks on the specified printer.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

In addition to the following permissions, the user's tenant must have an active Universal Print subscription.

|Permission type | Permissions (from least to most privileged) |
|:---------------|:--------------------------------------------|
|Delegated (work or school account)| Printer.ReadWrite.All, Printer.FullControl.All |
|Delegated (personal Microsoft account)|Not Supported.|
|Application|Not Supported.|

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
DELETE /print/printers/{id}/taskTriggers/{id}
```
## Request headers
| Name          | Description   |
|:--------------|:--------------|
| Authorization | Bearer {token}. Required. |

## Request body
Do not supply a request body for this method.

## Response
If successful, this method returns a `204 No Content` response code. It does not return anything in the response body.

## Example
##### Request
The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "delete_printer_tasktrigger"
}-->
```http
DELETE https://graph.microsoft.com/beta/print/printers/1a5f91a7-9bd1-4d5f-bb86-f43554cac51c/taskTriggers/25be207e-1154-491f-aa68-a9f7007d4bec
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Print.Printers["{printer-id}"].TaskTriggers["{printTaskTrigger-id}"]
	.Request()
	.DeleteAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

