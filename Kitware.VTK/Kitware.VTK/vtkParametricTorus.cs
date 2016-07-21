using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkParametricTorus : vtkParametricFunction
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkParametricTorus";

		public new static readonly string MRClassNameKey;

		static vtkParametricTorus()
		{
			vtkParametricTorus.MRClassNameKey = "class vtkParametricTorus";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParametricTorus.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricTorus"));
		}

		public vtkParametricTorus(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkParametricTorus_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParametricTorus New()
		{
			vtkParametricTorus result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricTorus.vtkParametricTorus_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricTorus)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkParametricTorus() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkParametricTorus.vtkParametricTorus_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricTorus_Evaluate_01(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		public override void Evaluate(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			vtkParametricTorus.vtkParametricTorus_Evaluate_01(base.GetCppThis(), uvw, Pt, Duvw);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricTorus_EvaluateScalar_02(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		public override double EvaluateScalar(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			return vtkParametricTorus.vtkParametricTorus_EvaluateScalar_02(base.GetCppThis(), uvw, Pt, Duvw);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricTorus_GetCrossSectionRadius_03(HandleRef pThis);

		public virtual double GetCrossSectionRadius()
		{
			return vtkParametricTorus.vtkParametricTorus_GetCrossSectionRadius_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkParametricTorus_GetDimension_04(HandleRef pThis);

		public override int GetDimension()
		{
			return vtkParametricTorus.vtkParametricTorus_GetDimension_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricTorus_GetRingRadius_05(HandleRef pThis);

		public virtual double GetRingRadius()
		{
			return vtkParametricTorus.vtkParametricTorus_GetRingRadius_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkParametricTorus_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkParametricTorus.vtkParametricTorus_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkParametricTorus_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkParametricTorus.vtkParametricTorus_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkParametricTorus_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkParametricTorus NewInstance()
		{
			vtkParametricTorus result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricTorus.vtkParametricTorus_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricTorus)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkParametricTorus_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParametricTorus SafeDownCast(vtkObjectBase o)
		{
			vtkParametricTorus vtkParametricTorus = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricTorus.vtkParametricTorus_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricTorus = (vtkParametricTorus)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricTorus.Register(null);
				}
			}
			return vtkParametricTorus;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricTorus_SetCrossSectionRadius_11(HandleRef pThis, double _arg);

		public virtual void SetCrossSectionRadius(double _arg)
		{
			vtkParametricTorus.vtkParametricTorus_SetCrossSectionRadius_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricTorus_SetRingRadius_12(HandleRef pThis, double _arg);

		public virtual void SetRingRadius(double _arg)
		{
			vtkParametricTorus.vtkParametricTorus_SetRingRadius_12(base.GetCppThis(), _arg);
		}
	}
}
