XInputDotNetPure is available in both x86 and x64 versions but requires the correct bitness of the native XInputInterface.dll - hence this project is set to x86 and the x86 version of this dll is included by default.

The native dll needs to be copied to the root and to not bother with post-build-steps it's just added to the project root as content for now.