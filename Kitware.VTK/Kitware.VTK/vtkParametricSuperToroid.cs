using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkParametricSuperToroid : vtkParametricFunction
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkParametricSuperToroid";

		public new static readonly string MRClassNameKey;

		static vtkParametricSuperToroid()
		{
			vtkParametricSuperToroid.MRClassNameKey = "class vtkParametricSuperToroid";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParametricSuperToroid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricSuperToroid"));
		}

		public vtkParametricSuperToroid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkParametricSuperToroid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParametricSuperToroid New()
		{
			vtkParametricSuperToroid result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricSuperToroid.vtkParametricSuperToroid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricSuperToroid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkParametricSuperToroid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkParametricSuperToroid.vtkParametricSuperToroid_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricSuperToroid_Evaluate_01(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		public override void Evaluate(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			vtkParametricSuperToroid.vtkParametricSuperToroid_Evaluate_01(base.GetCppThis(), uvw, Pt, Duvw);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricSuperToroid_EvaluateScalar_02(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		public override double EvaluateScalar(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			return vtkParametricSuperToroid.vtkParametricSuperToroid_EvaluateScalar_02(base.GetCppThis(), uvw, Pt, Duvw);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricSuperToroid_GetCrossSectionRadius_03(HandleRef pThis);

		public virtual double GetCrossSectionRadius()
		{
			return vtkParametricSuperToroid.vtkParametricSuperToroid_GetCrossSectionRadius_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkParametricSuperToroid_GetDimension_04(HandleRef pThis);

		public override int GetDimension()
		{
			return vtkParametricSuperToroid.vtkParametricSuperToroid_GetDimension_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricSuperToroid_GetN1_05(HandleRef pThis);

		public virtual double GetN1()
		{
			return vtkParametricSuperToroid.vtkParametricSuperToroid_GetN1_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricSuperToroid_GetN2_06(HandleRef pThis);

		public virtual double GetN2()
		{
			return vtkParametricSuperToroid.vtkParametricSuperToroid_GetN2_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricSuperToroid_GetRingRadius_07(HandleRef pThis);

		public virtual double GetRingRadius()
		{
			return vtkParametricSuperToroid.vtkParametricSuperToroid_GetRingRadius_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricSuperToroid_GetXRadius_08(HandleRef pThis);

		public virtual double GetXRadius()
		{
			return vtkParametricSuperToroid.vtkParametricSuperToroid_GetXRadius_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricSuperToroid_GetYRadius_09(HandleRef pThis);

		public virtual double GetYRadius()
		{
			return vtkParametricSuperToroid.vtkParametricSuperToroid_GetYRadius_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricSuperToroid_GetZRadius_10(HandleRef pThis);

		public virtual double GetZRadius()
		{
			return vtkParametricSuperToroid.vtkParametricSuperToroid_GetZRadius_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkParametricSuperToroid_IsA_11(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkParametricSuperToroid.vtkParametricSuperToroid_IsA_11(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkParametricSuperToroid_IsTypeOf_12(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkParametricSuperToroid.vtkParametricSuperToroid_IsTypeOf_12(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkParametricSuperToroid_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkParametricSuperToroid NewInstance()
		{
			vtkParametricSuperToroid result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricSuperToroid.vtkParametricSuperToroid_NewInstance_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricSuperToroid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkParametricSuperToroid_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParametricSuperToroid SafeDownCast(vtkObjectBase o)
		{
			vtkParametricSuperToroid vtkParametricSuperToroid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricSuperToroid.vtkParametricSuperToroid_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricSuperToroid = (vtkParametricSuperToroid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricSuperToroid.Register(null);
				}
			}
			return vtkParametricSuperToroid;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricSuperToroid_SetCrossSectionRadius_16(HandleRef pThis, double _arg);

		public virtual void SetCrossSectionRadius(double _arg)
		{
			vtkParametricSuperToroid.vtkParametricSuperToroid_SetCrossSectionRadius_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricSuperToroid_SetN1_17(HandleRef pThis, double _arg);

		public virtual void SetN1(double _arg)
		{
			vtkParametricSuperToroid.vtkParametricSuperToroid_SetN1_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricSuperToroid_SetN2_18(HandleRef pThis, double _arg);

		public virtual void SetN2(double _arg)
		{
			vtkParametricSuperToroid.vtkParametricSuperToroid_SetN2_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricSuperToroid_SetRingRadius_19(HandleRef pThis, double _arg);

		public virtual void SetRingRadius(double _arg)
		{
			vtkParametricSuperToroid.vtkParametricSuperToroid_SetRingRadius_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricSuperToroid_SetXRadius_20(HandleRef pThis, double _arg);

		public virtual void SetXRadius(double _arg)
		{
			vtkParametricSuperToroid.vtkParametricSuperToroid_SetXRadius_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricSuperToroid_SetYRadius_21(HandleRef pThis, double _arg);

		public virtual void SetYRadius(double _arg)
		{
			vtkParametricSuperToroid.vtkParametricSuperToroid_SetYRadius_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricSuperToroid_SetZRadius_22(HandleRef pThis, double _arg);

		public virtual void SetZRadius(double _arg)
		{
			vtkParametricSuperToroid.vtkParametricSuperToroid_SetZRadius_22(base.GetCppThis(), _arg);
		}
	}
}
