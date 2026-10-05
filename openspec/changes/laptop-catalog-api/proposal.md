# Proposal: Laptop Catalog API with Clean Architecture & Feature Flags

## Summary
Implement a RESTful Laptop Catalog API built with ASP.NET Core using Clean Architecture (4-layer structure) and Microsoft Feature Management.

## Objectives
- Structure solution into `Domain`, `Application`, `Infrastructure`, and `Api` layers.
- Expose endpoints to query laptop items with optional dynamic discounts based on feature flags.
- Gate experimental/beta endpoints via `[FeatureGate]`.
- Provide an OpenSpec API specification compatible with Postman.