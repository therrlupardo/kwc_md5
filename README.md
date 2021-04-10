# Generating executables with same MD5 hash
## Little backstory
You are distributing software as binary files. User can obviously check if file is what you say it
is by manually checking hash of binary. Here we are using **not recommended** solution - MD5.
After confirming that binary file is valid, user runs it with runner.
We have here 4 projects:
- GoodProgram and EvilProgram - they can be anything, here they are just printing stuff to console
- MD5CollisionGenerator - core of "breaking MD5". It changes 2 binaries, so they have same MD5 hash. It uses fact about MD5:
`if MD5(x) == MD5(y) then MD5(x + sth) == MD5(y + sth)` (of course sth is the same on both sides). In this scenario, `x` and `y` are byte arrays 
  taken from [Dan Kaminsky](http://www.doxpara.com/md5_someday.pdf), and `sth` is byte array of content of files, which names are given as arguments.
  So basically it joins both files with slightly different prefix :)
- Runner - executioner of binaries. Checks prefix of binary and extracts part of it (*good* or *evil* part) as final output.   


## Requirements
- dotnet in version minimum 5.0.201

## Build
Build all files using `./build_programs.sh`
All files you need are now in directory `result`

## Running

1. Go to `result` directory
2. Here you can try GoodProgram and EvilProgram just by using `./GoodProgram` or `./EvilProgram`.
3. To generate binary files use `./MD5CollisionGenerator GoodProgram EvilProgram`. As you can see, generated binaries have the same MD5 hashes.
4. Generate final executables by running `./Runner {binary_file} {output_file_name}` with both binaries generated in previous step.
5. Run executables, as you can see they have different outputs (even though binaries you gave as first argument have same MD5 hash)
