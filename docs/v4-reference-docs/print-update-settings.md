---
title: Update printSettings
description: Update tenant-wide settings for the Universal Print service.
author: braedenp-msft
ms.localizationpriority: medium
ms.prod: cloud-printing
doc_type: apiPageType
---

# Update printSettings

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update tenant-wide settings for the Universal Print service.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

To use the Universal Print service, the user or app's tenant must have an active Universal Print subscription, in addition to the permissions listed in the following table. The signed in user must be a [Printer Administrator](/azure/active-directory/users-groups-roles/directory-assign-admin-roles#printer-administrator).

|Permission type | Permissions (from least to most privileged) |
|:---------------|:--------------------------------------------|
|Delegated (work or school account)| PrintSettings.ReadWrite.All |
|Delegated (personal Microsoft account)|Not Supported.|
|Application|Not Supported.|

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
PATCH /print/settings
```

## Optional request headers
| Name       | Description|
|:-----------|:-----------|
| Authorization | Bearer {token}. Required. |
| Content-type  | application/json. Required.|

## Request body
In the request body, supply the values for the relevant [printSettings](../resources/printsettings.md) fields that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values. For best performance, don't include existing values that haven't changed.

| Property     | Type        | Description |
|:-------------|:------------|:------------|
|documentConversionEnabled|Boolean|Specifies whether document conversion is enabled for the tenant. If document conversion is enabled, Universal Print service will automatically convert documents into a format compatible with the printer (for example, XPS to PDF) when needed.|

## Response
If successful, this method returns a `204 No Content` response code and an empty response body.

## Example
##### Request
The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_settings_for_print"
}-->
```http
PATCH https://graph.microsoft.com/beta/print/settings
Content-type: application/json

{
  "documentConversionEnabled": true
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var printSettings = new PrintSettings
{
	DocumentConversionEnabled = true
};

var print = new Print();
print.Settings = printSettings;

await graphClient.Print
	.Request()
	.UpdateAsync(print);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

