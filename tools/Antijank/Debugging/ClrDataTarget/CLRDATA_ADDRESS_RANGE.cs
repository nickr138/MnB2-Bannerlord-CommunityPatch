﻿using System;
using System.Runtime.InteropServices;
using JetBrains.Annotations;

namespace Antijank.Debugging {

  [Serializable]
  [StructLayout(LayoutKind.Sequential, Pack = 8)]
  [PublicAPI]
  public struct CLRDATA_ADDRESS_RANGE {

    public ulong startAddress;

    public ulong endAddress;

  }

}