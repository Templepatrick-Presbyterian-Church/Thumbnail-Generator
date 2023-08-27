# Thumbnail Generator

## About

This is the code that is used to generate the thumbnails that are seen on our [YouTube channel](https://www.youtube.com/@TemplepatrickPCI)

This is the legacy branch for the old version that only generated thumbnails via a very simple command-line tool. Please see the main branch for the modern, generic version.

When you compile and run the executable, it'll generate a thumbnail for the nearest Sunday. For example: if today is Wednesday 2nd August 2023, it will generate a thumbnail for Sunday 6th August 2023. If today is Sunday 6th August 2023, it will generate a thumbnail for 13th August 2023.

## Why not just use an image editor?

This program in intended for non-technical people who just want to set and forget; who don't know how to use image editors. It works very well for our needs - it generates an thumbnail very quickly and can just be uploaded to YouTube. However, because it's so simple, it can't be easily modified (by a non-technical person). That's why we have the modern, main branch that has a better editor.
