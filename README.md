# Failure

```
Started VNC Server at port: 5900                                                                
192.168.1.14                                                                                    
Version is 3.8                                                                                  
Wrote Protocol Version                                                                          
Read Protocol Version                                                                           
Awaiting Authentication                                                                         
Authentication successfull !                                                                    
Share: True                                                                                     
Server name:                                                                                    
Read SetEncodings                                                                               
Read SetPixelFormat                                                                             
Read FrameBufferUpdateRequest                                                                   
Writing padding?                                                                                
Writing padding success, rectanges 1                                                            
Unable to read data from the transport connection: An existing connection was forcibly closed by
 the remote host.                                                                               
Read SetPixelFormat                                                                             
Unable to read data from the transport connection: An existing connection was forcibly closed by
 the remote host.                                                                               
 
Failure2:
Authentication successfull !
ReadClientInit failure
Unable to read beyond the end of the stream.
Share: False
Server name: admin
WriteServerInit failed
Unable to write data to the transport connection: A request to send or receive data was disallowed because the socket is not connected and (when sending on a datagram socket using a sendto call) no address was supplied.
host.isRunning = false 
```


# NVNC

The first open-source .NET VNC Server written entirely in the C# programming language.

### Features
* Very small and stable NET VNC Server library
* Supports the standard VNC Authentication with a password
* Supports the following encodings: Raw, RRE, Hextile, CopyRect, ZRLE
* Supports the following pseudo-encodings: Zlib
* The first .NET VNC Server, proving that high speed is possible
* Minimum .NET Framework version: 2.0
* Built for both x86 and x64 architectures
* Supports Windows, Linux and Mac OS X via the Mono Framework
* Tested and compatible with TightVNC, RealVNC, UltraVNC and all Java viewers

**If you found NVNC useful in any way, please rate it, and share the project**


