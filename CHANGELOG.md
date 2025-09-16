## [1.2.1](https://github.com/DNSFilter/ARSoft.Tools.Net/compare/v1.2.0...v1.2.1) (2025-09-16)

### Bug Fixes

* **dns-client-base:** Fixing the logger implementation to use the full namespace of the class instead of just the class name for logging filtering purposes. ([f37c0f4](https://github.com/DNSFilter/ARSoft.Tools.Net/commit/f37c0f443faa73c26b5d26f575f4cb23ecf8699e))

## [1.2.0](https://github.com/DNSFilter/ARSoft.Tools.Net/compare/v1.1.0...v1.2.0) (2025-08-20)

### Features

* **logging:** Adding a mechanism to add log messages without relying on any specific implementation of logging. Added log messages to DnsClient and DnsClientBase. ([65fdcbb](https://github.com/DNSFilter/ARSoft.Tools.Net/commit/65fdcbbeb56f707a1698943e75b31f1b0097594d))
* **logging:** Adding a mechanism to add log messages without relying on any specific implementation of logging. Added log messages to DnsClient and DnsClientBase. This is a duplicate message to 65fdcbbeb56f707a1698943e75b31f1b0097594d because I accidentally made the conventional commit use feature instead of feat. ([81c235c](https://github.com/DNSFilter/ARSoft.Tools.Net/commit/81c235c4def87de80d221faca1ed185dd40fc3d1))

## [1.1.0](https://github.com/DNSFilter/ARSoft.Tools.Net/compare/v1.0.0...v1.1.0) (2025-07-30)

### Features

* **dnsf-extensions:** Added a new DNSF Extension function to expose internal functionality to the Windows Agent. ([3372efe](https://github.com/DNSFilter/ARSoft.Tools.Net/commit/3372efe477766543f0866f418f788613a85aafce))

## 1.0.0 (2025-07-14)

### Features

* **nuget:** Adding support for publishing via NuGet using GitHub Packages and additionally supporting automatically incrementing versions with conventional commits. ([f3ddf5e](https://github.com/DNSFilter/ARSoft.Tools.Net/commit/f3ddf5e0f96994536bd943a7c66824685506d774))

### Bug Fixes

* add build yml ([991d0b9](https://github.com/DNSFilter/ARSoft.Tools.Net/commit/991d0b91f449a60319f87be2b04a284ba5abe8c9))
* add pdbs to debug build ([5f52da7](https://github.com/DNSFilter/ARSoft.Tools.Net/commit/5f52da77cf4d90b0b149b5697333d79d60d06ad7))
* build and publish as github nuget ([d86db92](https://github.com/DNSFilter/ARSoft.Tools.Net/commit/d86db9266c5fca5a80ea7a537cc8bf9ece516813))
* dll path ([450c7a0](https://github.com/DNSFilter/ARSoft.Tools.Net/commit/450c7a0c94e108f92b8b9dc580add5857fbeb012))
* include pdb in zip ([a5a3f1c](https://github.com/DNSFilter/ARSoft.Tools.Net/commit/a5a3f1ca5b27ed10b7b693b9efba0f05811668fa))
* IPV6 detection code invocation ([45a33aa](https://github.com/DNSFilter/ARSoft.Tools.Net/commit/45a33aa464bbea059e4dc53005871e06ee433a53))
* NXDomain should continue to next server if available ([67c83e1](https://github.com/DNSFilter/ARSoft.Tools.Net/commit/67c83e1e4e4d329219bc93bd867799db7451bf9a))
* pipeline ([2831706](https://github.com/DNSFilter/ARSoft.Tools.Net/commit/2831706fd253cf1454546b85f66ebeff3c8e80b3))
* pipeline ([5bbcca0](https://github.com/DNSFilter/ARSoft.Tools.Net/commit/5bbcca0f721132601504542a3b65204632c3a254))
* pipeline ([62b9767](https://github.com/DNSFilter/ARSoft.Tools.Net/commit/62b9767f71a277947fef18216dfc9bc133c503cf))
* pipeline default values ([3e8f234](https://github.com/DNSFilter/ARSoft.Tools.Net/commit/3e8f234db8448396e1b8540e87473ed3dd9b0cb3))
* pipline ([fa3cec1](https://github.com/DNSFilter/ARSoft.Tools.Net/commit/fa3cec10b8e8fcb31d283215da8368e160d26f1b))
* project config ([f4e8e92](https://github.com/DNSFilter/ARSoft.Tools.Net/commit/f4e8e92fc22508bc195f5f0771bf7911fe21961e))
* project dependecies ([e942cb8](https://github.com/DNSFilter/ARSoft.Tools.Net/commit/e942cb8337b6e7df5fd9a3089c535a5b967854df))
* remove doc project ([7572b93](https://github.com/DNSFilter/ARSoft.Tools.Net/commit/7572b9350c4877692a13e5304031e4f2c916c685))
* revert our customizations ([eef961f](https://github.com/DNSFilter/ARSoft.Tools.Net/commit/eef961f7b0e3060af8aaf9e111c4c94fc4aef590))
* solution updates for build ([dbdce1d](https://github.com/DNSFilter/ARSoft.Tools.Net/commit/dbdce1d34d2af5debf48671c410090697121bcb0))
* update to 3.6.1 branch ([e6b06a3](https://github.com/DNSFilter/ARSoft.Tools.Net/commit/e6b06a3433626f0b2007fdaf14bdc06284470704))
