#!/usr/bin/env bash

VERSION=0.1.$GITHUB_RUN_NUMBER

for dir in src/*/
do
    dir=${dir%*/}
    cd $dir
    echo "Packing NuGet package: ${dir##*/}"
    dotnet pack -c release /p:PackageVersion=$VERSION /p:Version=$VERSION --no-restore -o . &
    cd ../
    wait
done

echo "Finished packing NuGet packages."
