# Warrensoft.SecureGuid [![nuget](https://img.shields.io/nuget/v/Warrensoft.SecureGuid?style=flat-square)](https://www.nuget.org/packages/Warrensoft.SecureGuid)

## overview

tl;dr

- targets .net standard 2.1
- blazing-fast performance
- no memory overhead, alloc-free
- thread-safe and lock-free
- uses crypto PRNG to generate random bits

## installation

``` sh
$ dotnet add package Warrensoft.SecureGuid
```

## how to use

Creating a secure GUID:

``` csharp
Guid id = SecureGuid.New();
```

```
01ee4a74-e52c-1c3a-73fd-d35a2974218c
```

## license

This library is open-source software released under the MIT [License](LICENSE).