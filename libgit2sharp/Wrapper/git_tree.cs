﻿using System.Runtime.InteropServices;

namespace libgit2sharp.Wrapper
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct git_tree
    {
        public git_object tree;
        public git_vector entries;
    }
}