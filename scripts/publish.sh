#!/usr/bin/env bash

for dir in src/*/
do
    dir=${dir%*/}
    cd src/$dir
    echo "Publishing NuGet package: ${dir##*/}"
    dotnet nuget push *.nupkg -k $NUGET_API_KEY -s https://api.nuget.org/v3/index.json
    cd -
done

echo "Finished publishing NuGet packages."