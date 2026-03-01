This is a common directory structure in .NET applications, and is intented to be used as a template for development.


## Explaination
### `artifacts/`
Build outputs go in here.
- `build.cmd`/`build.sh` generates artifacts here (`.nupkgs`, `.dlls`, `.pdbs`, etc.)

### `build/`
Build customisation files are stored here.

### `deploy/`
System and container orchestration deployment configurations and templates (docker-compose, kubernetes/helm, mesos, terraform, bosh).
- More common to **Software/Product/Infrastructure as a Service**.

### `docs/`
Documentations and helper files (text, markdown, etc) are stored here.

### `lib/`
This directory stores any non-3rd party dependencies that is not tightly coupled with the application.
- i.e. class libraries, components.

### `packages/`
NuGet packages and other 3rd party dependencies are stored here.

### `samples/` (optional)
Project samples are stored here.
- Use this directory to place demonstrations of the project's features.

### `src/`
This directory stores the actual application code.

### `scripts/`
This directory stores scripts for installations, analysis and operations.
- These scripts can be combined with `Makefile` at the root level.

### `tests/`
This directory is used for storing application testing.
- Unit tests and integration tests.
- The directory may be structured in anyway you want.


## Source
- David Fowl [dotnetlayout.md](https://gist.github.com/davidfowl/ed7564297c61fe9ab814)
- Golang-standards [project-layout](https://github.com/golang-standards/project-layout)
- dotnet-template[project-layout](https://github.com/dotnet-template/project-layout/tree/main)