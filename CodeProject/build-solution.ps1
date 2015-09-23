param (
    [string]$CONFIG = "Release",
    [string]$SOLUTION = "CodeProject.sln"
)

Write-Host ""
Write-Host "***********************************************************************"
Write-Host "* Building $SOLUTION...IN $CONFIG Mode"
Write-Host "***********************************************************************"
Write-Host ""

msbuild.exe /maxcpucount /m /p:Configuration=$CONFIG $SOLUTION /p:TreatWarningsAsErrors=true /verbosity:m
exit $LastExitCode