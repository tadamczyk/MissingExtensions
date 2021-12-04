#!/usr/bin/env bash

for dir in src/*/
do
    dir=${dir%*/}
    cd src/$dir
    echo "Packing NuGet package: ${dir##*/}"
    dotnet pack -c release /p:PackageVersion=0.1.$GITHUB_RUN_NUMBER --no-restore -o .
    cd -
done

echo "Finished packing NuGet packages."