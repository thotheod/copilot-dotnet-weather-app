#!/bin/bash

echo "::step::Restoring packages from CFS..."
cd ./SampleApp
export VSS_NUGET_ACCESSTOKEN=$(${HOME}/ado-auth-helper get-access-token)
export VSS_NUGET_URI_PREFIXES="https://pkgs.dev.azure.com/"
dotnet restore || true