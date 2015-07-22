﻿using System;

using Atomix.Kernel_H.devices;

namespace Atomix.Kernel_H.io.FileSystem
{
    public abstract class GenericFileSystem
    {
        protected Storage IDevice;
        protected bool mIsValid;
        protected FileSystemType mFSType;

        public bool IsValid
        { get { return mIsValid; } }

        public FileSystemType FileSystem
        { get { return mFSType; } }

        public abstract bool ReadFile(string[] paths, int c, byte[] xReturnData, int index);
        public abstract byte[] ReadFile(string[] paths, int c);
    }

    public enum FileSystemType : byte
    {
        None    = 0x0,
        FAT     = 0x1
    }
}