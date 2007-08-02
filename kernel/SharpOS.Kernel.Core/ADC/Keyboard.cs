// 
// (C) 2006-2007 The SharpOS Project Team (http://www.sharpos.org)
//
// Authors:
//	Sander van Rossen <sander.vanrossen@gmail.com>
//	William Lahti <xfurious@gmail.com>
//
// Licensed under the terms of the GNU GPL License version 2.
//

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using SharpOS;
using SharpOS.AOT.X86;
using SharpOS.AOT.IR;
using AOTAttr = SharpOS.AOT.Attributes;

namespace SharpOS.ADC 
{
	public unsafe class Keyboard
	{
		[AOTAttr.ADCStub]
		public static void Setup ()
		{
		}

		[AOTAttr.ADCStub]
		public static EventRegisterStatus RegisterKeyUpEvent (uint address)
		{
			return EventRegisterStatus.NotSupported;
		}
		
		[AOTAttr.ADCStub]
		public static EventRegisterStatus RegisterKeyDownEvent (uint address)
		{
			return EventRegisterStatus.NotSupported;
		}
		
		[AOTAttr.ADCStub]
		public static void SetLEDs (bool capslock, bool numlock, bool scrolllock)
		{
		}
		
		[AOTAttr.ADCStub]
		public static bool LeftShift ()
		{
			return false;
		}
		
		[AOTAttr.ADCStub]
		public static bool RightShift ()
		{
			return false;
		}

		[AOTAttr.ADCStub]
		public static bool LeftAlt ()
		{
			return false;
		}
		
		[AOTAttr.ADCStub]
		public static bool RightAlt ()
		{
			return false;
		}

		[AOTAttr.ADCStub]
		public static bool LeftControl ()
		{
			return false;
		}
		
		[AOTAttr.ADCStub]
		public static bool RightControl ()
		{
			return false;
		}
		[AOTAttr.ADCStub]
		public static bool ScrollLock ()
		{
			return false;
		}
		
		[AOTAttr.ADCStub]
		public static bool CapsLock ()
		{
			return false;
		}
		
		[AOTAttr.ADCStub]
		public static bool NumLock ()
		{
			return false;
		}
	
		[AOTAttr.ADCStub]
		public static void SetKeymap (byte *keymap)
		{
		}
		
		[AOTAttr.ADCStub]
		public static byte Translate (uint scancode)
		{
			return 0;
		}
	}
}
