---
title: "Update adminReportSettings"
description: "Update tenant-level settings for Microsoft 365 reports."
ms.localizationpriority: medium
author: "qiwhuang"
ms.prod: "reports"
doc_type: apiPageType
---

# Update adminReportSettings

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update tenant-level settings for Microsoft 365 reports.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|----------------------------------------|---------------------------------------------|
| Delegated (work or school account)     | ReportSettings.ReadWrite.All                |
| Delegated (personal Microsoft account) | Not supported.                              |
| Application                            | ReportSettings.ReadWrite.All                |

> **Note:** For delegated permissions to allow apps to update report settings on behalf of a user, the tenant administrator must have assigned the user the appropriate Azure Active Directory limited administrator role. For more details, see [Authorization for APIs to read Microsoft 365 usage reports](/graph/reportroot-authorization).

## HTTP request
<!-- { "blockType": "ignored" } --> 
```http
PATCH /admin/reportSettings
```

## Request headers

| Name          | Description                |
| :------------ | :--------------------------|
| Authorization | Bearer {token}. Required.  |
| Content-Type  | application/json. Required.|

## Request body

In the request body, supply *only* the values for properties that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values.

The following table specifies the properties that can be updated.

| Property       | Type           | Description                                 |
| -------------- | -------------- | ------------------------------------------- |
| displayConcealedNames | Boolean | If set to `true`, all reports will conceal user information such as usernames, groups, and sites. If `false`, all reports will show identifiable information. This property represents a setting in the Microsoft 365 admin center. Required. |

## Response

If successful, this method returns a `204 No Content` response code.

## Examples

The following is an example of a request that updates a tenant-level setting for Microsoft 365 reports.

### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_adminreportsettings"
}
-->
``` http
PATCH https://graph.microsoft.com/beta/admin/reportSettings
Content-Type: application/json
Content-length: 37

{
  "displayConcealedNames": true
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var adminReportSettings = new AdminReportSettings
{
	DisplayConcealedNames = true
};

await graphClient.Admin.ReportSettings
	.Request()
	.UpdateAsync(adminReportSettings);

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
