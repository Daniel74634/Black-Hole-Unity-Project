param(
    [Parameter(Mandatory = $true)][string]$OutputDirectory,
    [Parameter(Mandatory = $true)][string]$CaptionPath,
    [switch]$Rebuild,
    [string]$UnityEditor = 'C:\Program Files\Unity\Hub\Editor\6000.3.25f1\Editor\Unity.exe'
)
$ErrorActionPreference = 'Stop'
$dtetProject = (Resolve-Path (Join-Path $PSScriptRoot '..\BinaryBlackHole')).Path
$dtetCaptions = (Resolve-Path -LiteralPath $CaptionPath).Path
$dtetOutput = [System.IO.Path]::GetFullPath($OutputDirectory)
New-Item -ItemType Directory -Path $dtetOutput -Force | Out-Null
$dtetFfmpeg = (Get-Command ffmpeg -ErrorAction Stop).Source
$dtetFfprobe = (Get-Command ffprobe -ErrorAction Stop).Source

function Wait-DtetProcess([System.Diagnostics.Process]$Process, [int]$TimeoutSeconds) {
    if (!$Process.WaitForExit($TimeoutSeconds * 1000)) {
        throw "Operation still running as PID $($Process.Id). Inspect it; no process was killed."
    }
    if ($Process.ExitCode -ne 0) { throw "Process $($Process.Id) failed with exit code $($Process.ExitCode)" }
}
if ($Rebuild) {
    $dtetBuild = Start-Process -FilePath $UnityEditor -ArgumentList @(
        '-projectPath', ('"' + $dtetProject + '"'), '-executeMethod',
        'DTET.VisualPrototype.Editor.PrototypeBuild.BuildQaPlayer', '-batchmode', '-nographics', '-quit',
        '-logFile', ('"' + (Join-Path $dtetOutput 'unity-build.log') + '"')
    ) -WindowStyle Hidden -PassThru
    Wait-DtetProcess $dtetBuild 300
}
$dtetRaw = Join-Path $dtetOutput 'prototype-raw.mp4'
$dtetVideo = Join-Path $dtetOutput 'DTET_Prototype_Demo.mp4'
$dtetCaptureLog = Join-Path $dtetOutput 'capture.log'
$dtetOldVideoEnv = $env:DTET_VIDEO_PATH
$dtetOldEncoderEnv = $env:DTET_FFMPEG_PATH
try {
    if ($env:DTET_CAPTURE_PATH) { throw 'Unset DTET_CAPTURE_PATH before recording; the screenshot harness would interfere.' }
    $env:DTET_VIDEO_PATH = $dtetRaw
    $env:DTET_FFMPEG_PATH = $dtetFfmpeg
    $dtetPlayer = Start-Process -FilePath (Join-Path $dtetProject 'Builds\VisualQA\BinaryBlackHole_VisualQA.exe') -ArgumentList @(
        '-screen-width', '1600', '-screen-height', '900', '-screen-fullscreen', '0',
        '-logFile', ('"' + $dtetCaptureLog + '"')
    ) -PassThru
    Wait-DtetProcess $dtetPlayer 240
} finally {
    $env:DTET_VIDEO_PATH = $dtetOldVideoEnv
    $env:DTET_FFMPEG_PATH = $dtetOldEncoderEnv
}
if (!(Select-String -LiteralPath $dtetCaptureLog -SimpleMatch 'DTET_VIDEO_PASS')) {
    throw "No completed recording receipt in $dtetCaptureLog"
}
# Relative subtitle filename avoids Windows drive-colon escaping inside ffmpeg filters.
if ($dtetCaptions -ne (Join-Path $dtetOutput 'captions.ass')) {
    Copy-Item -LiteralPath $dtetCaptions -Destination (Join-Path $dtetOutput 'captions.ass')
}
Push-Location -LiteralPath $dtetOutput
try {
    & $dtetFfmpeg -hide_banner -y -i $dtetRaw -vf 'vflip,pad=1600:1000:0:0:color=0x07101f,ass=captions.ass' -an -c:v libx264 -preset slow -crf 20 -pix_fmt yuv420p -movflags +faststart $dtetVideo 2> encode.log
    if ($LASTEXITCODE -ne 0) { throw 'Presentation encoding failed; inspect encode.log' }
    & $dtetFfprobe -v error -count_frames -show_entries 'stream=codec_name,width,height,pix_fmt,r_frame_rate,nb_read_frames:format=duration,size' -of json $dtetVideo | Set-Content -LiteralPath 'video-validation.json'
    if ($LASTEXITCODE -ne 0) { throw 'Video validation failed' }
} finally { Pop-Location }
Write-Output $dtetVideo
