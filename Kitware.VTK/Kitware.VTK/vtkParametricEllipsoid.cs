using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkParametricEllipsoid : vtkParametricFunction
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkParametricEllipsoid";

		public new static readonly string MRClassNameKey;

		static vtkParametricEllipsoid()
		{
			vtkParametricEllipsoid.MRClassNameKey = "class vtkParametricEllipsoid";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParametricEllipsoid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricEllipsoid"));
		}

		public vtkParametricEllipsoid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkParametricEllipsoid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParametricEllipsoid New()
		{
			vtkParametricEllipsoid result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricEllipsoid.vtkParametricEllipsoid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricEllipsoid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkParametricEllipsoid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkParametricEllipsoid.vtkParametricEllipsoid_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricEllipsoid_Evaluate_01(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		public override void Evaluate(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			vtkParametricEllipsoid.vtkParametricEllipsoid_Evaluate_01(base.GetCppThis(), uvw, Pt, Duvw);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricEllipsoid_EvaluateScalar_02(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		public override double EvaluateScalar(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			return vtkParametricEllipsoid.vtkParametricEllipsoid_EvaluateScalar_02(base.GetCppThis(), uvw, Pt, Duvw);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkParametricEllipsoid_GetDimension_03(HandleRef pThis);

		public override int GetDimension()
		{
			return vtkParametricEllipsoid.vtkParametricEllipsoid_GetDimension_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricEllipsoid_GetXRadius_04(HandleRef pThis);

		public virtual double GetXRadius()
		{
			return vtkParametricEllipsoid.vtkParametricEllipsoid_GetXRadius_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricEllipsoid_GetYRadius_05(HandleRef pThis);

		public virtual double GetYRadius()
		{
			return vtkParametricEllipsoid.vtkParametricEllipsoid_GetYRadius_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricEllipsoid_GetZRadius_06(HandleRef pThis);

		public virtual double GetZRadius()
		{
			return vtkParametricEllipsoid.vtkParametricEllipsoid_GetZRadius_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkParametricEllipsoid_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkParametricEllipsoid.vtkParametricEllipsoid_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkParametricEllipsoid_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkParametricEllipsoid.vtkParametricEllipsoid_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkParametricEllipsoid_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkParametricEllipsoid NewInstance()
		{
			vtkParametricEllipsoid result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricEllipsoid.vtkParametricEllipsoid_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricEllipsoid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkParametricEllipsoid_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParametricEllipsoid SafeDownCast(vtkObjectBase o)
		{
			vtkParametricEllipsoid vtkParametricEllipsoid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricEllipsoid.vtkParametricEllipsoid_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricEllipsoid = (vtkParametricEllipsoid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricEllipsoid.Register(null);
				}
			}
			return vtkParametricEllipsoid;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricEllipsoid_SetXRadius_12(HandleRef pThis, double _arg);

		public virtual void SetXRadius(double _arg)
		{
			vtkParametricEllipsoid.vtkParametricEllipsoid_SetXRadius_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricEllipsoid_SetYRadius_13(HandleRef pThis, double _arg);

		public virtual void SetYRadius(double _arg)
		{
			vtkParametricEllipsoid.vtkParametricEllipsoid_SetYRadius_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricEllipsoid_SetZRadius_14(HandleRef pThis, double _arg);

		public virtual void SetZRadius(double _arg)
		{
			vtkParametricEllipsoid.vtkParametricEllipsoid_SetZRadius_14(base.GetCppThis(), _arg);
		}
	}
}
