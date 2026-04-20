# RegistryChecker

`RegistryChecker` is a small command-line utility for quickly updating a proxy setting via the Windows registry.

## Purpose

This tool was created to simplify changing proxy configuration by applying the required registry edits from the command line.

## Usage

The built executable is named `rc` and supports these options:

- `rc -l` or `rc -local` — sets `AutoConfigURL` to the local PAC file at `C:\Utils\proxy.pac`
- `rc -m` or `rc -moa` — sets `AutoConfigURL` to `http://pacfile.mutual.local/proxy.pac`
- `rc -s` or `rc -show` — displays the current `AutoConfigURL` registry value

Example:

    rc -s

## PATH requirements

To use `rc` from any command prompt, add the folder containing the compiled executable to your `PATH` environment variable.

On Windows PowerShell, you can update `PATH` for the current session like this:

    $env:Path += ";C:\path\to\rc\folder"

Or permanently via System Properties / Environment Variables.

## Notes

- Designed for quick proxy updates.
- Operates by modifying registry entries.
- Intended for use on Windows systems.
