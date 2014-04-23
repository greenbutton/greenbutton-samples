Video Transcoding Sample (FfmpegSample)
=======================================

A simple, minimal example of embarrassingly parallel processing in
the cloud.  This sample defines a job type (FfmpegSample) which
transcodes all its input files in parallel.

The sample task processor invokes the external program ffmpeg --
if you want to actually perform transcoding then you will need to download
ffmpeg.  However you can compile and review the sample code without
doing so.
