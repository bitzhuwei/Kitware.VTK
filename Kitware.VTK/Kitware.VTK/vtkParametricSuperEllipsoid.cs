using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkParametricSuperEllipsoid : vtkParametricFunction
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkParametricSuperEllipsoid";

		public new static readonly string MRClassNameKey;

		static vtkParametricSuperEllipsoid()
		{
			vtkParametricSuperEllipsoid.MRClassNameKey = "class vtkParametricSuperEllipsoid";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParametricSuperEllipsoid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricSuperEllipsoid"));
		}

		public vtkParametricSuperEllipsoid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkParametricSuperEllipsoid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParametricSuperEllipsoid New()
		{
			vtkParametricSuperEllipsoid result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricSuperEllipsoid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkParametricSuperEllipsoid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricSuperEllipsoid_Evaluate_01(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		public override void Evaluate(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_Evaluate_01(base.GetCppThis(), uvw, Pt, Duvw);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricSuperEllipsoid_EvaluateScalar_02(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		public override double EvaluateScalar(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			return vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_EvaluateScalar_02(base.GetCppThis(), uvw, Pt, Duvw);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkParametricSuperEllipsoid_GetDimension_03(HandleRef pThis);

		public override int GetDimension()
		{
			return vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_GetDimension_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricSuperEllipsoid_GetN1_04(HandleRef pThis);

		public virtual double GetN1()
		{
			return vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_GetN1_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricSuperEllipsoid_GetN2_05(HandleRef pThis);

		public virtual double GetN2()
		{
			return vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_GetN2_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricSuperEllipsoid_GetXRadius_06(HandleRef pThis);

		public virtual double GetXRadius()
		{
			return vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_GetXRadius_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricSuperEllipsoid_GetYRadius_07(HandleRef pThis);

		public virtual double GetYRadius()
		{
			return vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_GetYRadius_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricSuperEllipsoid_GetZRadius_08(HandleRef pThis);

		public virtual double GetZRadius()
		{
			return vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_GetZRadius_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkParametricSuperEllipsoid_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkParametricSuperEllipsoid_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkParametricSuperEllipsoid_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkParametricSuperEllipsoid NewInstance()
		{
			vtkParametricSuperEllipsoid result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricSuperEllipsoid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkParametricSuperEllipsoid_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParametricSuperEllipsoid SafeDownCast(vtkObjectBase o)
		{
			vtkParametricSuperEllipsoid vtkParametricSuperEllipsoid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricSuperEllipsoid = (vtkParametricSuperEllipsoid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricSuperEllipsoid.Register(null);
				}
			}
			return vtkParametricSuperEllipsoid;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricSuperEllipsoid_SetN1_14(HandleRef pThis, double _arg);

		public virtual void SetN1(double _arg)
		{
			vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_SetN1_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricSuperEllipsoid_SetN2_15(HandleRef pThis, double _arg);

		public virtual void SetN2(double _arg)
		{
			vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_SetN2_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricSuperEllipsoid_SetXRadius_16(HandleRef pThis, double _arg);

		public virtual void SetXRadius(double _arg)
		{
			vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_SetXRadius_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricSuperEllipsoid_SetYRadius_17(HandleRef pThis, double _arg);

		public virtual void SetYRadius(double _arg)
		{
			vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_SetYRadius_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricSuperEllipsoid_SetZRadius_18(HandleRef pThis, double _arg);

		public virtual void SetZRadius(double _arg)
		{
			vtkParametricSuperEllipsoid.vtkParametricSuperEllipsoid_SetZRadius_18(base.GetCppThis(), _arg);
		}
	}
}
