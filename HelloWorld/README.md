# Hello World
This repository contains hello world example.
It is based on .NET Core 2.2 including dockerfile.
To run application:
- run cmd
- go to folder with dockerfile
- build
```
docker build . -t helloworld:latest
```
- run
```
docker run helloworld:latest
```
