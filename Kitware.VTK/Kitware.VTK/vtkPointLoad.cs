using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPointLoad : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointLoad";

		public new static readonly string MRClassNameKey;

		static vtkPointLoad()
		{
			vtkPointLoad.MRClassNameKey = "class vtkPointLoad";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointLoad.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointLoad"));
		}

		public vtkPointLoad(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkPointLoad_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPointLoad New()
		{
			vtkPointLoad result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointLoad.vtkPointLoad_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointLoad)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPointLoad() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPointLoad.vtkPointLoad_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkPointLoad_ComputeEffectiveStressOff_01(HandleRef pThis);

		public void ComputeEffectiveStressOff()
		{
			vtkPointLoad.vtkPointLoad_ComputeEffectiveStressOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkPointLoad_ComputeEffectiveStressOn_02(HandleRef pThis);

		public void ComputeEffectiveStressOn()
		{
			vtkPointLoad.vtkPointLoad_ComputeEffectiveStressOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkPointLoad_GetComputeEffectiveStress_03(HandleRef pThis);

		public int GetComputeEffectiveStress()
		{
			return vtkPointLoad.vtkPointLoad_GetComputeEffectiveStress_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkPointLoad_GetLoadValue_04(HandleRef pThis);

		public virtual double GetLoadValue()
		{
			return vtkPointLoad.vtkPointLoad_GetLoadValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkPointLoad_GetModelBounds_05(HandleRef pThis);

		public virtual double[] GetModelBounds()
		{
			IntPtr intPtr = vtkPointLoad.vtkPointLoad_GetModelBounds_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkPointLoad_GetModelBounds_06(HandleRef pThis, IntPtr data);

		public virtual void GetModelBounds(IntPtr data)
		{
			vtkPointLoad.vtkPointLoad_GetModelBounds_06(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkPointLoad_GetPoissonsRatio_07(HandleRef pThis);

		public virtual double GetPoissonsRatio()
		{
			return vtkPointLoad.vtkPointLoad_GetPoissonsRatio_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkPointLoad_GetSampleDimensions_08(HandleRef pThis);

		public virtual int[] GetSampleDimensions()
		{
			IntPtr intPtr = vtkPointLoad.vtkPointLoad_GetSampleDimensions_08(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkPointLoad_GetSampleDimensions_09(HandleRef pThis, IntPtr data);

		public virtual void GetSampleDimensions(IntPtr data)
		{
			vtkPointLoad.vtkPointLoad_GetSampleDimensions_09(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkPointLoad_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPointLoad.vtkPointLoad_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkPointLoad_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPointLoad.vtkPointLoad_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkPointLoad_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPointLoad NewInstance()
		{
			vtkPointLoad result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointLoad.vtkPointLoad_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointLoad)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkPointLoad_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPointLoad SafeDownCast(vtkObjectBase o)
		{
			vtkPointLoad vtkPointLoad = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointLoad.vtkPointLoad_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointLoad = (vtkPointLoad)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointLoad.Register(null);
				}
			}
			return vtkPointLoad;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkPointLoad_SetComputeEffectiveStress_15(HandleRef pThis, int arg0);

		public void SetComputeEffectiveStress(int arg0)
		{
			vtkPointLoad.vtkPointLoad_SetComputeEffectiveStress_15(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkPointLoad_SetLoadValue_16(HandleRef pThis, double _arg);

		public virtual void SetLoadValue(double _arg)
		{
			vtkPointLoad.vtkPointLoad_SetLoadValue_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkPointLoad_SetModelBounds_17(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		public virtual void SetModelBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkPointLoad.vtkPointLoad_SetModelBounds_17(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkPointLoad_SetModelBounds_18(HandleRef pThis, IntPtr _arg);

		public virtual void SetModelBounds(IntPtr _arg)
		{
			vtkPointLoad.vtkPointLoad_SetModelBounds_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkPointLoad_SetPoissonsRatio_19(HandleRef pThis, double _arg);

		public virtual void SetPoissonsRatio(double _arg)
		{
			vtkPointLoad.vtkPointLoad_SetPoissonsRatio_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkPointLoad_SetSampleDimensions_20(HandleRef pThis, int i, int j, int k);

		public void SetSampleDimensions(int i, int j, int k)
		{
			vtkPointLoad.vtkPointLoad_SetSampleDimensions_20(base.GetCppThis(), i, j, k);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkPointLoad_SetSampleDimensions_21(HandleRef pThis, IntPtr dim);

		public void SetSampleDimensions(IntPtr dim)
		{
			vtkPointLoad.vtkPointLoad_SetSampleDimensions_21(base.GetCppThis(), dim);
		}
	}
}
