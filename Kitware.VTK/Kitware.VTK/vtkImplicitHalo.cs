using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImplicitHalo : vtkImplicitFunction
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitHalo";

		public new static readonly string MRClassNameKey;

		static vtkImplicitHalo()
		{
			vtkImplicitHalo.MRClassNameKey = "class vtkImplicitHalo";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImplicitHalo.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitHalo"));
		}

		public vtkImplicitHalo(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitHalo_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImplicitHalo New()
		{
			vtkImplicitHalo result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitHalo.vtkImplicitHalo_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitHalo)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImplicitHalo() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImplicitHalo.vtkImplicitHalo_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkImplicitHalo_EvaluateFunction_01(HandleRef pThis, IntPtr x);

		public override double EvaluateFunction(IntPtr x)
		{
			return vtkImplicitHalo.vtkImplicitHalo_EvaluateFunction_01(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkImplicitHalo_EvaluateFunction_02(HandleRef pThis, double x, double y, double z);

		public new virtual double EvaluateFunction(double x, double y, double z)
		{
			return vtkImplicitHalo.vtkImplicitHalo_EvaluateFunction_02(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitHalo_EvaluateGradient_03(HandleRef pThis, IntPtr x, IntPtr g);

		public override void EvaluateGradient(IntPtr x, IntPtr g)
		{
			vtkImplicitHalo.vtkImplicitHalo_EvaluateGradient_03(base.GetCppThis(), x, g);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitHalo_GetCenter_04(HandleRef pThis);

		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkImplicitHalo.vtkImplicitHalo_GetCenter_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitHalo_GetCenter_05(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetCenter(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImplicitHalo.vtkImplicitHalo_GetCenter_05(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitHalo_GetCenter_06(HandleRef pThis, IntPtr _arg);

		public virtual void GetCenter(IntPtr _arg)
		{
			vtkImplicitHalo.vtkImplicitHalo_GetCenter_06(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkImplicitHalo_GetFadeOut_07(HandleRef pThis);

		public virtual double GetFadeOut()
		{
			return vtkImplicitHalo.vtkImplicitHalo_GetFadeOut_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkImplicitHalo_GetRadius_08(HandleRef pThis);

		public virtual double GetRadius()
		{
			return vtkImplicitHalo.vtkImplicitHalo_GetRadius_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImplicitHalo_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImplicitHalo.vtkImplicitHalo_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImplicitHalo_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImplicitHalo.vtkImplicitHalo_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitHalo_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImplicitHalo NewInstance()
		{
			vtkImplicitHalo result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitHalo.vtkImplicitHalo_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitHalo)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitHalo_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImplicitHalo SafeDownCast(vtkObjectBase o)
		{
			vtkImplicitHalo vtkImplicitHalo = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitHalo.vtkImplicitHalo_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitHalo = (vtkImplicitHalo)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitHalo.Register(null);
				}
			}
			return vtkImplicitHalo;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitHalo_SetCenter_14(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkImplicitHalo.vtkImplicitHalo_SetCenter_14(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitHalo_SetCenter_15(HandleRef pThis, IntPtr _arg);

		public virtual void SetCenter(IntPtr _arg)
		{
			vtkImplicitHalo.vtkImplicitHalo_SetCenter_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitHalo_SetFadeOut_16(HandleRef pThis, double _arg);

		public virtual void SetFadeOut(double _arg)
		{
			vtkImplicitHalo.vtkImplicitHalo_SetFadeOut_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitHalo_SetRadius_17(HandleRef pThis, double _arg);

		public virtual void SetRadius(double _arg)
		{
			vtkImplicitHalo.vtkImplicitHalo_SetRadius_17(base.GetCppThis(), _arg);
		}
	}
}
