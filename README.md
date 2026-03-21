# Nnng
[![NuGet](https://img.shields.io/nuget/v/Nnng.svg)](https://www.nuget.org/packages/Nnng/) [![Downloads](https://img.shields.io/nuget/dt/Nnng)](https://www.nuget.org/packages/Nnng) [![Build](https://github.com/myd7349/Nnng/actions/workflows/build.yml/badge.svg)](https://github.com/myd7349/Nnng/actions) ![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/myd7349/Nnng) ![GitHub repo size](https://img.shields.io/github/repo-size/myd7349/Nnng) [![License](https://img.shields.io/github/license/myd7349/Nnng)](https://github.com/myd7349/Nnng/blob/main/LICENSE)

Nnng is a cross-platform C# binding of [nng](https://github.com/nanomsg/nng).

# Usage
Nnng is available as a convenient NuGet package. You can install Nnng using any of the following methods:

.NET CLI:
```
dotnet add package Nnng --version <version>
```

NuGet package manager:
```
Install-Package Nnng -Version <version>
```

PackageReference:
```
<PackageReference Include="Nnng" Version="<version>" />
```

Replace `<version>` with the specific version number of Nnng you wish to use.

In addition to installing Nnng, you will need to install the appropriate nng runtime package(s) for your target platform(s). Nnng offers separate NuGet packages for these platforms, named `Nnng.Runtime.[RID]`, where `[RID]` represents the runtime identifier for the specific platform. For details on runtime identifiers, refer to the [RID catalog](https://learn.microsoft.com/en-us/dotnet/core/rid-catalog). You can find the list of available runtime packages and their platform mappings in the [Nnng.Runtime README](https://github.com/myd7349/Nnng/blob/main/src/Nnng.Runtime/README.md).

# Related Projects
| Project  | Stars |  Description | License |
|--- | ---| ---|--- |
| [NanomsgNG.NET](https://github.com/rodrigo455/NanomsgNG.NET)  | [![GitHub stars](https://img.shields.io/github/stars/rodrigo455/NanomsgNG.NET?style=social)](https://github.com/rodrigo455/NanomsgNG.NET/stargazers/) | Fork of nng.NET/NETCore. | [![MIT-badge]][MIT-link] |
| [NanomsgRPC](https://github.com/mhowlett/NanomsgRPC)  | [![GitHub stars](https://img.shields.io/github/stars/mhowlett/NanomsgRPC?style=social)](https://github.com/mhowlett/NanomsgRPC/stargazers/) | Lightweight RPC framework for .NET that utilizes NNanomsg. |  |
| [NNanomsg](https://github.com/mhowlett/NNanomsg)  | [![GitHub stars](https://img.shields.io/github/stars/mhowlett/NNanomsg?style=social)](https://github.com/mhowlett/NNanomsg/stargazers/) | .NET binding for nanomsg. | [![MIT-badge]][MIT-link] |
| [NNG.NET](https://github.com/jpostels/NNG.NET)  | [![GitHub stars](https://img.shields.io/github/stars/jpostels/NNG.NET?style=social)](https://github.com/jpostels/NNG.NET/stargazers/) | NNG.NET is a .NET Core binding for nng. | [![MIT-badge]][MIT-link] |
| [nng.NET/NETCore](https://github.com/jeikabu/nng.NETCore)  | [![GitHub stars](https://img.shields.io/github/stars/jeikabu/nng.NETCore?style=social)](https://github.com/jeikabu/nng.NETCore/stargazers/) | .NET bindings to NNG. | [![MIT-badge]][MIT-link] |
| [Rebus.nng](https://github.com/bkempinski/Rebus.nng)  | [![GitHub stars](https://img.shields.io/github/stars/bkempinski/Rebus.nng?style=social)](https://github.com/bkempinski/Rebus.nng/stargazers/) | NNG transport for Rebus. | [![MIT-badge]][MIT-link] |
| [SharpNng](https://github.com/xoofx/SharpNng)  | [![GitHub stars](https://img.shields.io/github/stars/xoofx/SharpNng?style=social)](https://github.com/xoofx/SharpNng/stargazers/) | A lightweight low-level managed wrapper around the nng library. | [![BSD-2-Clause-badge]][BSD-2-Clause-link] |

[BSD-2-Clause-badge]: https://img.shields.io/badge/License-BSD%202--Clause-blue.svg
[BSD-2-Clause-link]: https://opensource.org/licenses/BSD-2-Clause
[MIT-badge]: https://img.shields.io/badge/License-MIT-blue.svg
[MIT-link]: https://opensource.org/licenses/MIT
