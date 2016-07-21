using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPlane : vtkImplicitFunction
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlane";

		public new static readonly string MRClassNameKey;

		static vtkPlane()
		{
			vtkPlane.MRClassNameKey = "class vtkPlane";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlane.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlane"));
		}

		public vtkPlane(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPlane_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPlane New()
		{
			vtkPlane result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlane.vtkPlane_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlane)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPlane() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPlane.vtkPlane_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkPlane_DistanceToPlane_01(IntPtr x, IntPtr n, IntPtr p0);

		public static double DistanceToPlane(IntPtr x, IntPtr n, IntPtr p0)
		{
			return vtkPlane.vtkPlane_DistanceToPlane_01(x, n, p0);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkPlane_DistanceToPlane_02(HandleRef pThis, IntPtr x);

		public double DistanceToPlane(IntPtr x)
		{
			return vtkPlane.vtkPlane_DistanceToPlane_02(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkPlane_Evaluate_03(IntPtr normal, IntPtr origin, IntPtr x);

		public static double Evaluate(IntPtr normal, IntPtr origin, IntPtr x)
		{
			return vtkPlane.vtkPlane_Evaluate_03(normal, origin, x);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkPlane_EvaluateFunction_04(HandleRef pThis, IntPtr x);

		public override double EvaluateFunction(IntPtr x)
		{
			return vtkPlane.vtkPlane_EvaluateFunction_04(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkPlane_EvaluateFunction_05(HandleRef pThis, double x, double y, double z);

		public new double EvaluateFunction(double x, double y, double z)
		{
			return vtkPlane.vtkPlane_EvaluateFunction_05(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPlane_EvaluateGradient_06(HandleRef pThis, IntPtr x, IntPtr g);

		public override void EvaluateGradient(IntPtr x, IntPtr g)
		{
			vtkPlane.vtkPlane_EvaluateGradient_06(base.GetCppThis(), x, g);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPlane_GeneralizedProjectPoint_07(IntPtr x, IntPtr origin, IntPtr normal, IntPtr xproj);

		public static void GeneralizedProjectPoint(IntPtr x, IntPtr origin, IntPtr normal, IntPtr xproj)
		{
			vtkPlane.vtkPlane_GeneralizedProjectPoint_07(x, origin, normal, xproj);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPlane_GeneralizedProjectPoint_08(HandleRef pThis, IntPtr x, IntPtr xproj);

		public void GeneralizedProjectPoint(IntPtr x, IntPtr xproj)
		{
			vtkPlane.vtkPlane_GeneralizedProjectPoint_08(base.GetCppThis(), x, xproj);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPlane_GetNormal_09(HandleRef pThis);

		public virtual double[] GetNormal()
		{
			IntPtr intPtr = vtkPlane.vtkPlane_GetNormal_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPlane_GetNormal_10(HandleRef pThis, IntPtr data);

		public virtual void GetNormal(IntPtr data)
		{
			vtkPlane.vtkPlane_GetNormal_10(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPlane_GetOrigin_11(HandleRef pThis);

		public virtual double[] GetOrigin()
		{
			IntPtr intPtr = vtkPlane.vtkPlane_GetOrigin_11(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPlane_GetOrigin_12(HandleRef pThis, IntPtr data);

		public virtual void GetOrigin(IntPtr data)
		{
			vtkPlane.vtkPlane_GetOrigin_12(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkPlane_IntersectWithLine_13(IntPtr p1, IntPtr p2, IntPtr n, IntPtr p0, ref double t, IntPtr x);

		public static int IntersectWithLine(IntPtr p1, IntPtr p2, IntPtr n, IntPtr p0, ref double t, IntPtr x)
		{
			return vtkPlane.vtkPlane_IntersectWithLine_13(p1, p2, n, p0, ref t, x);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkPlane_IntersectWithLine_14(HandleRef pThis, IntPtr p1, IntPtr p2, ref double t, IntPtr x);

		public int IntersectWithLine(IntPtr p1, IntPtr p2, ref double t, IntPtr x)
		{
			return vtkPlane.vtkPlane_IntersectWithLine_14(base.GetCppThis(), p1, p2, ref t, x);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkPlane_IsA_15(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPlane.vtkPlane_IsA_15(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkPlane_IsTypeOf_16(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPlane.vtkPlane_IsTypeOf_16(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPlane_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPlane NewInstance()
		{
			vtkPlane result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlane.vtkPlane_NewInstance_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlane)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPlane_ProjectPoint_19(IntPtr x, IntPtr origin, IntPtr normal, IntPtr xproj);

		public static void ProjectPoint(IntPtr x, IntPtr origin, IntPtr normal, IntPtr xproj)
		{
			vtkPlane.vtkPlane_ProjectPoint_19(x, origin, normal, xproj);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPlane_ProjectPoint_20(HandleRef pThis, IntPtr x, IntPtr xproj);

		public void ProjectPoint(IntPtr x, IntPtr xproj)
		{
			vtkPlane.vtkPlane_ProjectPoint_20(base.GetCppThis(), x, xproj);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPlane_Push_21(HandleRef pThis, double distance);

		public void Push(double distance)
		{
			vtkPlane.vtkPlane_Push_21(base.GetCppThis(), distance);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPlane_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPlane SafeDownCast(vtkObjectBase o)
		{
			vtkPlane vtkPlane = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlane.vtkPlane_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlane = (vtkPlane)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlane.Register(null);
				}
			}
			return vtkPlane;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPlane_SetNormal_23(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetNormal(double _arg1, double _arg2, double _arg3)
		{
			vtkPlane.vtkPlane_SetNormal_23(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPlane_SetNormal_24(HandleRef pThis, IntPtr _arg);

		public virtual void SetNormal(IntPtr _arg)
		{
			vtkPlane.vtkPlane_SetNormal_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPlane_SetOrigin_25(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkPlane.vtkPlane_SetOrigin_25(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPlane_SetOrigin_26(HandleRef pThis, IntPtr _arg);

		public virtual void SetOrigin(IntPtr _arg)
		{
			vtkPlane.vtkPlane_SetOrigin_26(base.GetCppThis(), _arg);
		}
	}
}
