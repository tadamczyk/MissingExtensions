#!/usr/bin/env bash

for dir in src/*/
do
    dir=${dir%*/}
    cd $dir
    echo "Packing NuGet package: ${dir##*/}"
    dotnet pack -c release /p:PackageVersion=0.1.$GITHUB_RUN_NUMBER --no-restore -o . &
    cd ../
    wait
done

echo "Finished packing NuGet packages."