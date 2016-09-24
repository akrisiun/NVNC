using System;

namespace NVNC
{
    public interface ILastError
    {
        Exception LastError { get; set; }
    }
}