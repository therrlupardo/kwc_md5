#!/bin/sh
rm -rf result
mkdir result

dotnet publish GoodProgram -r linux-x64 -p:PublishSingleFile=true --self-contained false
mv GoodProgram/bin/Debug/net5.0/linux-x64/publish/GoodProgram ./result/

dotnet publish EvilProgram -r linux-x64 -p:PublishSingleFile=true --self-contained false
mv EvilProgram/bin/Debug/net5.0/linux-x64/publish/EvilProgram ./result/

dotnet publish MD5CollisionGenerator -r linux-x64 -p:PublishSingleFile=true --self-contained false
mv MD5CollisionGenerator/bin/Debug/net5.0/linux-x64/publish/MD5CollisionGenerator ./result/

dotnet publish Runner -r linux-x64 -p:PublishSingleFile=true --self-contained false
mv Runner/bin/Debug/net5.0/linux-x64/publish/Runner ./result/