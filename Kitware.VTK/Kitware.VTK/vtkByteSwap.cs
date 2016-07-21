using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkByteSwap : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkByteSwap";

		public new static readonly string MRClassNameKey;

		static vtkByteSwap()
		{
			vtkByteSwap.MRClassNameKey = "class vtkByteSwap";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkByteSwap.MRClassNameKey, Type.GetType("Kitware.VTK.vtkByteSwap"));
		}

		public vtkByteSwap(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkByteSwap_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkByteSwap New()
		{
			vtkByteSwap result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkByteSwap.vtkByteSwap_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkByteSwap)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkByteSwap() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkByteSwap.vtkByteSwap_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkByteSwap_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkByteSwap.vtkByteSwap_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkByteSwap_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkByteSwap.vtkByteSwap_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkByteSwap_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkByteSwap NewInstance()
		{
			vtkByteSwap result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkByteSwap.vtkByteSwap_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkByteSwap)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkByteSwap_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkByteSwap SafeDownCast(vtkObjectBase o)
		{
			vtkByteSwap vtkByteSwap = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkByteSwap.vtkByteSwap_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkByteSwap = (vtkByteSwap)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkByteSwap.Register(null);
				}
			}
			return vtkByteSwap;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkByteSwap_Swap2BE_06(IntPtr p);

		public static void Swap2BE(IntPtr p)
		{
			vtkByteSwap.vtkByteSwap_Swap2BE_06(p);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkByteSwap_Swap2BERange_07(IntPtr p, int num);

		public static void Swap2BERange(IntPtr p, int num)
		{
			vtkByteSwap.vtkByteSwap_Swap2BERange_07(p, num);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkByteSwap_Swap2LE_08(IntPtr p);

		public static void Swap2LE(IntPtr p)
		{
			vtkByteSwap.vtkByteSwap_Swap2LE_08(p);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkByteSwap_Swap2LERange_09(IntPtr p, int num);

		public static void Swap2LERange(IntPtr p, int num)
		{
			vtkByteSwap.vtkByteSwap_Swap2LERange_09(p, num);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkByteSwap_Swap4BE_10(IntPtr p);

		public static void Swap4BE(IntPtr p)
		{
			vtkByteSwap.vtkByteSwap_Swap4BE_10(p);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkByteSwap_Swap4BERange_11(IntPtr p, int num);

		public static void Swap4BERange(IntPtr p, int num)
		{
			vtkByteSwap.vtkByteSwap_Swap4BERange_11(p, num);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkByteSwap_Swap4LE_12(IntPtr p);

		public static void Swap4LE(IntPtr p)
		{
			vtkByteSwap.vtkByteSwap_Swap4LE_12(p);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkByteSwap_Swap4LERange_13(IntPtr p, int num);

		public static void Swap4LERange(IntPtr p, int num)
		{
			vtkByteSwap.vtkByteSwap_Swap4LERange_13(p, num);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkByteSwap_Swap8BE_14(IntPtr p);

		public static void Swap8BE(IntPtr p)
		{
			vtkByteSwap.vtkByteSwap_Swap8BE_14(p);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkByteSwap_Swap8BERange_15(IntPtr p, int num);

		public static void Swap8BERange(IntPtr p, int num)
		{
			vtkByteSwap.vtkByteSwap_Swap8BERange_15(p, num);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkByteSwap_Swap8LE_16(IntPtr p);

		public static void Swap8LE(IntPtr p)
		{
			vtkByteSwap.vtkByteSwap_Swap8LE_16(p);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkByteSwap_Swap8LERange_17(IntPtr p, int num);

		public static void Swap8LERange(IntPtr p, int num)
		{
			vtkByteSwap.vtkByteSwap_Swap8LERange_17(p, num);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkByteSwap_SwapBE_18(IntPtr p);

		public static void SwapBE(IntPtr p)
		{
			vtkByteSwap.vtkByteSwap_SwapBE_18(p);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkByteSwap_SwapBE_19(string p);

		public static void SwapBE(string p)
		{
			vtkByteSwap.vtkByteSwap_SwapBE_19(p);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkByteSwap_SwapBERange_20(IntPtr p, long num);

		public static void SwapBERange(IntPtr p, long num)
		{
			vtkByteSwap.vtkByteSwap_SwapBERange_20(p, num);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkByteSwap_SwapBERange_21(string p, long num);

		public static void SwapBERange(string p, long num)
		{
			vtkByteSwap.vtkByteSwap_SwapBERange_21(p, num);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkByteSwap_SwapLE_22(IntPtr p);

		public static void SwapLE(IntPtr p)
		{
			vtkByteSwap.vtkByteSwap_SwapLE_22(p);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkByteSwap_SwapLE_23(string p);

		public static void SwapLE(string p)
		{
			vtkByteSwap.vtkByteSwap_SwapLE_23(p);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkByteSwap_SwapLERange_24(IntPtr p, long num);

		public static void SwapLERange(IntPtr p, long num)
		{
			vtkByteSwap.vtkByteSwap_SwapLERange_24(p, num);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkByteSwap_SwapLERange_25(string p, long num);

		public static void SwapLERange(string p, long num)
		{
			vtkByteSwap.vtkByteSwap_SwapLERange_25(p, num);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkByteSwap_SwapVoidRange_26(IntPtr buffer, int numWords, int wordSize);

		public static void SwapVoidRange(IntPtr buffer, int numWords, int wordSize)
		{
			vtkByteSwap.vtkByteSwap_SwapVoidRange_26(buffer, numWords, wordSize);
		}
	}
}
