using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkFastNumericConversion : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkFastNumericConversion";

		public new static readonly string MRClassNameKey;

		static vtkFastNumericConversion()
		{
			vtkFastNumericConversion.MRClassNameKey = "class vtkFastNumericConversion";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFastNumericConversion.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFastNumericConversion"));
		}

		public vtkFastNumericConversion(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkFastNumericConversion_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFastNumericConversion New()
		{
			vtkFastNumericConversion result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFastNumericConversion.vtkFastNumericConversion_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFastNumericConversion)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkFastNumericConversion() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkFastNumericConversion.vtkFastNumericConversion_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkFastNumericConversion_ConvertFixedPoint_01(HandleRef pThis, ref double val, ref int fracPart);

		public int ConvertFixedPoint(ref double val, ref int fracPart)
		{
			return vtkFastNumericConversion.vtkFastNumericConversion_ConvertFixedPoint_01(base.GetCppThis(), ref val, ref fracPart);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkFastNumericConversion_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkFastNumericConversion.vtkFastNumericConversion_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkFastNumericConversion_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkFastNumericConversion.vtkFastNumericConversion_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkFastNumericConversion_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkFastNumericConversion NewInstance()
		{
			vtkFastNumericConversion result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFastNumericConversion.vtkFastNumericConversion_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFastNumericConversion)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkFastNumericConversion_QuickFloor_06(ref double val);

		public static int QuickFloor(ref double val)
		{
			return vtkFastNumericConversion.vtkFastNumericConversion_QuickFloor_06(ref val);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkFastNumericConversion_Round_07(ref double val);

		public static int Round(ref double val)
		{
			return vtkFastNumericConversion.vtkFastNumericConversion_Round_07(ref val);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkFastNumericConversion_RoundingTieBreaker_08();

		public static double RoundingTieBreaker()
		{
			return vtkFastNumericConversion.vtkFastNumericConversion_RoundingTieBreaker_08();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkFastNumericConversion_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFastNumericConversion SafeDownCast(vtkObjectBase o)
		{
			vtkFastNumericConversion vtkFastNumericConversion = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFastNumericConversion.vtkFastNumericConversion_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFastNumericConversion = (vtkFastNumericConversion)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFastNumericConversion.Register(null);
				}
			}
			return vtkFastNumericConversion;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkFastNumericConversion_SafeFloor_10(ref double val);

		public static int SafeFloor(ref double val)
		{
			return vtkFastNumericConversion.vtkFastNumericConversion_SafeFloor_10(ref val);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkFastNumericConversion_SetReservedFracBits_11(HandleRef pThis, int bits);

		public void SetReservedFracBits(int bits)
		{
			vtkFastNumericConversion.vtkFastNumericConversion_SetReservedFracBits_11(base.GetCppThis(), bits);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkFastNumericConversion_TestConvertFixedPointFracPart_12(HandleRef pThis, double val);

		public int TestConvertFixedPointFracPart(double val)
		{
			return vtkFastNumericConversion.vtkFastNumericConversion_TestConvertFixedPointFracPart_12(base.GetCppThis(), val);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkFastNumericConversion_TestConvertFixedPointIntPart_13(HandleRef pThis, double val);

		public int TestConvertFixedPointIntPart(double val)
		{
			return vtkFastNumericConversion.vtkFastNumericConversion_TestConvertFixedPointIntPart_13(base.GetCppThis(), val);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkFastNumericConversion_TestQuickFloor_14(HandleRef pThis, double val);

		public int TestQuickFloor(double val)
		{
			return vtkFastNumericConversion.vtkFastNumericConversion_TestQuickFloor_14(base.GetCppThis(), val);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkFastNumericConversion_TestRound_15(HandleRef pThis, double val);

		public int TestRound(double val)
		{
			return vtkFastNumericConversion.vtkFastNumericConversion_TestRound_15(base.GetCppThis(), val);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkFastNumericConversion_TestSafeFloor_16(HandleRef pThis, double val);

		public int TestSafeFloor(double val)
		{
			return vtkFastNumericConversion.vtkFastNumericConversion_TestSafeFloor_16(base.GetCppThis(), val);
		}
	}
}
