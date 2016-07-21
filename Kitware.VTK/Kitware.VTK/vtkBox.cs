using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkBox : vtkImplicitFunction
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkBox";

		public new static readonly string MRClassNameKey;

		static vtkBox()
		{
			vtkBox.MRClassNameKey = "class vtkBox";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBox.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBox"));
		}

		public vtkBox(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkBox_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBox New()
		{
			vtkBox result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBox.vtkBox_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBox)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkBox() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkBox.vtkBox_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBox_AddBounds_01(HandleRef pThis, IntPtr bounds);

		public void AddBounds(IntPtr bounds)
		{
			vtkBox.vtkBox_AddBounds_01(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkBox_EvaluateFunction_02(HandleRef pThis, IntPtr x);

		public override double EvaluateFunction(IntPtr x)
		{
			return vtkBox.vtkBox_EvaluateFunction_02(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkBox_EvaluateFunction_03(HandleRef pThis, double x, double y, double z);

		public new double EvaluateFunction(double x, double y, double z)
		{
			return vtkBox.vtkBox_EvaluateFunction_03(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBox_EvaluateGradient_04(HandleRef pThis, IntPtr x, IntPtr n);

		public override void EvaluateGradient(IntPtr x, IntPtr n)
		{
			vtkBox.vtkBox_EvaluateGradient_04(base.GetCppThis(), x, n);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBox_GetBounds_05(HandleRef pThis, ref double xMin, ref double xMax, ref double yMin, ref double yMax, ref double zMin, ref double zMax);

		public void GetBounds(ref double xMin, ref double xMax, ref double yMin, ref double yMax, ref double zMin, ref double zMax)
		{
			vtkBox.vtkBox_GetBounds_05(base.GetCppThis(), ref xMin, ref xMax, ref yMin, ref yMax, ref zMin, ref zMax);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBox_GetBounds_06(HandleRef pThis, IntPtr bounds);

		public void GetBounds(IntPtr bounds)
		{
			vtkBox.vtkBox_GetBounds_06(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkBox_GetBounds_07(HandleRef pThis);

		public IntPtr GetBounds()
		{
			return vtkBox.vtkBox_GetBounds_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBox_GetXMax_08(HandleRef pThis, IntPtr p);

		public void GetXMax(IntPtr p)
		{
			vtkBox.vtkBox_GetXMax_08(base.GetCppThis(), p);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBox_GetXMax_09(HandleRef pThis, ref double x, ref double y, ref double z);

		public void GetXMax(ref double x, ref double y, ref double z)
		{
			vtkBox.vtkBox_GetXMax_09(base.GetCppThis(), ref x, ref y, ref z);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBox_GetXMin_10(HandleRef pThis, IntPtr p);

		public void GetXMin(IntPtr p)
		{
			vtkBox.vtkBox_GetXMin_10(base.GetCppThis(), p);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBox_GetXMin_11(HandleRef pThis, ref double x, ref double y, ref double z);

		public void GetXMin(ref double x, ref double y, ref double z)
		{
			vtkBox.vtkBox_GetXMin_11(base.GetCppThis(), ref x, ref y, ref z);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern sbyte vtkBox_IntersectBox_12(IntPtr bounds, IntPtr origin, IntPtr dir, IntPtr coord, ref double t);

		public static sbyte IntersectBox(IntPtr bounds, IntPtr origin, IntPtr dir, IntPtr coord, ref double t)
		{
			return vtkBox.vtkBox_IntersectBox_12(bounds, origin, dir, coord, ref t);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkBox_IntersectWithLine_13(IntPtr bounds, IntPtr p1, IntPtr p2, ref double t1, ref double t2, IntPtr x1, IntPtr x2, ref int plane1, ref int plane2);

		public static int IntersectWithLine(IntPtr bounds, IntPtr p1, IntPtr p2, ref double t1, ref double t2, IntPtr x1, IntPtr x2, ref int plane1, ref int plane2)
		{
			return vtkBox.vtkBox_IntersectWithLine_13(bounds, p1, p2, ref t1, ref t2, x1, x2, ref plane1, ref plane2);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkBox_IsA_14(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBox.vtkBox_IsA_14(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkBox_IsTypeOf_15(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBox.vtkBox_IsTypeOf_15(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkBox_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBox NewInstance()
		{
			vtkBox result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBox.vtkBox_NewInstance_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBox)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkBox_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBox SafeDownCast(vtkObjectBase o)
		{
			vtkBox vtkBox = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBox.vtkBox_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBox = (vtkBox)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBox.Register(null);
				}
			}
			return vtkBox;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBox_SetBounds_19(HandleRef pThis, double xMin, double xMax, double yMin, double yMax, double zMin, double zMax);

		public void SetBounds(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax)
		{
			vtkBox.vtkBox_SetBounds_19(base.GetCppThis(), xMin, xMax, yMin, yMax, zMin, zMax);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBox_SetBounds_20(HandleRef pThis, IntPtr bounds);

		public void SetBounds(IntPtr bounds)
		{
			vtkBox.vtkBox_SetBounds_20(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBox_SetXMax_21(HandleRef pThis, IntPtr p);

		public void SetXMax(IntPtr p)
		{
			vtkBox.vtkBox_SetXMax_21(base.GetCppThis(), p);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBox_SetXMax_22(HandleRef pThis, double x, double y, double z);

		public void SetXMax(double x, double y, double z)
		{
			vtkBox.vtkBox_SetXMax_22(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBox_SetXMin_23(HandleRef pThis, IntPtr p);

		public void SetXMin(IntPtr p)
		{
			vtkBox.vtkBox_SetXMin_23(base.GetCppThis(), p);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkBox_SetXMin_24(HandleRef pThis, double x, double y, double z);

		public void SetXMin(double x, double y, double z)
		{
			vtkBox.vtkBox_SetXMin_24(base.GetCppThis(), x, y, z);
		}
	}
}
