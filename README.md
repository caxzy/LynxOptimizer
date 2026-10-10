# Lynx Optimizer

A free, open-source tweak panel for Windows 10 and 11. It puts the usual performance tweaks in one place so you don't have to hunt through the registry, services and settings yourself.

[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)
[![Discord](https://img.shields.io/badge/Discord-join-5865F2?logo=discord&logoColor=white)](https://discord.gg/JVEWR9CGk5)

Website: https://lynxoptimizer.netlify.app

Discord: https://discord.gg/JVEWR9CGk5

> Heads up: updates to this repo are on hold for now. For news, check the website or Discord.

## What it does

- Applies performance tweaks aimed at better FPS and lower latency
- Cuts down on unneeded background stuff and junk files
- Has options that are useful for gaming
- Works on Windows 10 and 11
- MIT licensed, so you can read it, use it and change it

## Requirements

- Windows 10 or 11 (64-bit)
- Admin rights, since it changes system settings

## How to use it

1. Download it from this repo or from the official website or github. Nowhere else.
2. Check the SHA256 hash (optional).
3. Right-click, **Run as administrator**.
4. Pick the tweaks you want and apply them.

## Check your download

Since this tool changes system settings, make sure the file you're about to run is the real one. Every release has a SHA256 hash. If yours doesn't match, don't run it.

| File | SHA256 |
|------|--------|
| `LynxOptimizer.exe` | `2FB8BF1C536C41982EF5A47B8DCC42904B738660D025459E62113FC1D1BEE017` |

To get the hash of your file, open PowerShell in the folder where you downloaded it:

```powershell
Get-FileHash .\LynxOptimizer.exe -Algorithm SHA256
```

Or with Command Prompt:

```cmd
certutil -hashfile LynxOptimizer.exe SHA256
```

The result has to match the table exactly, character for character.

A few more tips:

- Only download from this repo or the official site. Ignore reuploads and links from random people.
- You can also scan the file on [VirusTotal](https://www.virustotal.com/). Tweak tools sometimes get flagged by antivirus even when they're fine, so a false positive isn't unusual.
- Make a restore point before applying anything.

Found a security problem? Message me on Discord or open an issue (just don't post anything sensitive in public).

## Disclaimer

Changing system settings always has some risk. This is provided as-is with no warranty, so back up or make a restore point first. Use it at your own risk.

## Contributing

Bugs, ideas and pull requests are welcome. Fork the repo, make your changes on a branch and open a PR. If you're not sure about something, just ask on [Discord](https://discord.gg/JVEWR9CGk5) or open an [issue](https://github.com/caxzy/LynxOptimizer/issues).

## License

MIT. See [LICENSE](LICENSE).
