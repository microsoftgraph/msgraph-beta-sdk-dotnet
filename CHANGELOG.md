# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project does NOT adhere to [Semantic Versioning](https://semver.org/spec/v2.0.0.html) and packages shipped from the beta service library will always be in `preview` as changes to the API are for non production use and commonly ship breaking changes.

## [Unreleased]

### Added

### Changed

- Latest metadata updates from latest snapshot
- Fix incorrected nested paths that would point to incorrect request builders.

## [5.10.0-preview] - 2022-07-20

### Added

- Latest metadata updates from 19th July 2022 snapshot
- Fix for missing @odata.type properties in models

## [5.9.0-preview] - 2022-07-13

### Added

- Adds support for cancellation token support on large file uploads.

### Changed

- Latest metadata updates from 12th July 2022 snapshot
- Fixed incorrect casing of some properties on serialization [#483]

## [5.8.0-preview] - 2022-06-30

### Changed

- Latest metadata updates from 29th June 2022 snapshot
- Fixed missing derived models not directly referenced in openApi paths

## [5.7.0-preview] - 2022-06-21

### Added

- Latest metadata updates from 21st June 2022 snapshot

### Changed

- Fixed missing derived models not directly referenced in openApi paths

## [5.6.0-preview] - 2022-06-09

### Added

- Latest metadata updates from 7th June 2022 snapshot
- Adds missing odata cast paths for the places API
- Adds functionality to send the relevant accept header request execution

### Changed

- Fixed missing response error mappings for OData functions/actions
- Fixed missing actions/functions defined on collection navigation properties
- Fixed missing derived models not directly referenced in openApi paths
- Fixed paging for odata functions/actions e.g. delta requests

## [5.5.0-preview] - 2022-06-02

### Added

- Adds missing odata cast paths to enable requests for specific kind of objects

### Changed

- Fixes exceptions on deserialization of payload that do not have @odata.type
- Fixes instances with missing key values for path parameters

## [5.4.0-preview] - 2022-05-20

### Changed

- [Breaking] Adds support CAE in the authentication provider
- [Breaking] Generated request parameter objects renamed to include http method name
- Enables the backing store to enable dirty tracking of objects

## [5.3.0-preview] - 2022-05-06

### Changed

- [Breaking] Request configuration revamp to support [Kiota #1494](https://github.com/microsoft/kiota/issues/1494)

## [5.2.0-preview] - 2022-04-20

### Changed

- Rename queryOptions parameters to be more descriptive

## [5.1.0-preview] - 2022-04-05

### Added

- Added support for vendor specific content types
- Added support for 204 no content responses

### Changed

- Update namespaces to be more discoverable (beta lib uses Microsoft.Graph.Beta namespace)
- Rename queryOptions parameters to be more descriptive

## [5.0.0-preview] - 2022-03-24

### Added

- Initial Kiota generated SDK version