using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkBase64Utilities : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkBase64Utilities";

		public new static readonly string MRClassNameKey;

		static vtkBase64Utilities()
		{
			vtkBase64Utilities.MRClassNameKey = "class vtkBase64Utilities";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBase64Utilities.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBase64Utilities"));
		}

		public vtkBase64Utilities(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkBase64Utilities_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBase64Utilities New()
		{
			vtkBase64Utilities result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBase64Utilities.vtkBase64Utilities_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBase64Utilities)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkBase64Utilities() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkBase64Utilities.vtkBase64Utilities_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern uint vtkBase64Utilities_Decode_01(IntPtr input, uint length, IntPtr output, uint max_input_length);

		public static uint Decode(IntPtr input, uint length, IntPtr output, uint max_input_length)
		{
			return vtkBase64Utilities.vtkBase64Utilities_Decode_01(input, length, output, max_input_length);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkBase64Utilities_DecodeTriplet_02(byte i0, byte i1, byte i2, byte i3, IntPtr o0, IntPtr o1, IntPtr o2);

		public static int DecodeTriplet(byte i0, byte i1, byte i2, byte i3, IntPtr o0, IntPtr o1, IntPtr o2)
		{
			return vtkBase64Utilities.vtkBase64Utilities_DecodeTriplet_02(i0, i1, i2, i3, o0, o1, o2);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern uint vtkBase64Utilities_Encode_03(IntPtr input, uint length, IntPtr output, int mark_end);

		public static uint Encode(IntPtr input, uint length, IntPtr output, int mark_end)
		{
			return vtkBase64Utilities.vtkBase64Utilities_Encode_03(input, length, output, mark_end);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkBase64Utilities_EncodePair_04(byte i0, byte i1, IntPtr o0, IntPtr o1, IntPtr o2, IntPtr o3);

		public static void EncodePair(byte i0, byte i1, IntPtr o0, IntPtr o1, IntPtr o2, IntPtr o3)
		{
			vtkBase64Utilities.vtkBase64Utilities_EncodePair_04(i0, i1, o0, o1, o2, o3);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkBase64Utilities_EncodeSingle_05(byte i0, IntPtr o0, IntPtr o1, IntPtr o2, IntPtr o3);

		public static void EncodeSingle(byte i0, IntPtr o0, IntPtr o1, IntPtr o2, IntPtr o3)
		{
			vtkBase64Utilities.vtkBase64Utilities_EncodeSingle_05(i0, o0, o1, o2, o3);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkBase64Utilities_EncodeTriplet_06(byte i0, byte i1, byte i2, IntPtr o0, IntPtr o1, IntPtr o2, IntPtr o3);

		public static void EncodeTriplet(byte i0, byte i1, byte i2, IntPtr o0, IntPtr o1, IntPtr o2, IntPtr o3)
		{
			vtkBase64Utilities.vtkBase64Utilities_EncodeTriplet_06(i0, i1, i2, o0, o1, o2, o3);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkBase64Utilities_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBase64Utilities.vtkBase64Utilities_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkBase64Utilities_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBase64Utilities.vtkBase64Utilities_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkBase64Utilities_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBase64Utilities NewInstance()
		{
			vtkBase64Utilities result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBase64Utilities.vtkBase64Utilities_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBase64Utilities)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkBase64Utilities_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBase64Utilities SafeDownCast(vtkObjectBase o)
		{
			vtkBase64Utilities vtkBase64Utilities = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBase64Utilities.vtkBase64Utilities_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBase64Utilities = (vtkBase64Utilities)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBase64Utilities.Register(null);
				}
			}
			return vtkBase64Utilities;
		}
	}
}
