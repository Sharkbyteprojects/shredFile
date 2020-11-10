<img src="https://fire-engine-icons.github.io/shbyte-logopublishers/sharkbytelogo.svg" height="300">

# Shredder
Use `shredFile "path to file/file"`


## Changelog Since First release
```diff

+ MORE SECURE WITH RANDOM BYTES

+ Add welcome text

+ Wait 1000 ms before unlink files

+ Write 20 bytes more as the file byte length! | +2 per Iteration!

+ Repead Shred for 10 Iterations

+ Can Delete full directorys with content, also if it include more directorys

! Detect your os, if you run it under windows, it wait for key after execution
```

## DevChangeLog
- Add `experimental` branch!

---

For linux/mac download the exe file and install [mono](https://www.mono-project.com/download/stable/) then run it with `mono ./shredFile pathToFile`, if it dosn't work run `chmod +x ./shredFile`

For windows you can download all versions and run it normally, also you can drag on windows a file on the icon of `shredFile` and the file will be removed!

If you can't run it like a av blocks it, Install mono, download the [program file](https://raw.githubusercontent.com/Sharkbyteprojects/shredFile/master/shredFile/Program.cs) then compile it with `csc Program.cs`. Rename it then to `shredFile`

[RELEASES](https://github.com/Sharkbyteprojects/shredFile/releases/latest)
