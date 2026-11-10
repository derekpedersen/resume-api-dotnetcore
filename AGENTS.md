# AGENTS.md

This repository is the resume API for a .NET Core application that exposes resume data over HTTP and includes a focused test suite.

## Project purpose

- Primary app: `api/`
- Test project: `tests/`
- Deployment assets: `.helm/`, `Dockerfile`, Jenkins pipeline files, and Makefile

## Repository conventions

- Use the Makefile as the source of truth for build, test, and deployment commands.
- Keep changes small and repo-specific. This project is a simple API and does not need broad framework churn.
- When modifying models, controllers, or service/repository code, update or add tests in `tests/` where relevant.
- Favor targeted fixes over large refactors.

## Key folders

- `api/` — ASP.NET Core application code.
  - `Controllers/` — HTTP endpoints
  - `Models/` — resume-related data models
  - `Repository/` — data access implementations
  - `Service/` — business logic
- `tests/` — xUnit-based tests covering controllers and services
- `.helm/` — Helm deployment configuration
- `docs/` — supporting documentation and artifacts

## Standard commands

Run the project’s actual validation commands from the repository root:

- `make test` — run tests in the test project
- `make build` — restore and publish the API
- `make run` — run the compiled API
- `make docker` — build the container image

## Validation expectations

Before finishing work, verify the change with the most relevant command available:

- For code changes, prefer `make test`
- For build-related or deployment-related changes, also run `make build`
- If a change affects runtime behavior, validate the API behavior with the relevant tests or a targeted local run

## Notes for agents

- Follow the existing repo layout and naming patterns.
- Do not invent extra build systems or alternative workflows when the Makefile already defines the standard path.
- Keep README and repo docs in sync with behavior changes when they materially affect local setup or deployment.
