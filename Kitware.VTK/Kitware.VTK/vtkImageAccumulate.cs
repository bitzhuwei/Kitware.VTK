using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageAccumulate : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageAccumulate";

		public new static readonly string MRClassNameKey;

		static vtkImageAccumulate()
		{
			vtkImageAccumulate.MRClassNameKey = "class vtkImageAccumulate";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageAccumulate.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageAccumulate"));
		}

		public vtkImageAccumulate(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageAccumulate_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageAccumulate New()
		{
			vtkImageAccumulate result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageAccumulate.vtkImageAccumulate_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageAccumulate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageAccumulate() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageAccumulate.vtkImageAccumulate_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAccumulate_GetComponentExtent_01(HandleRef pThis, IntPtr extent);

		public void GetComponentExtent(IntPtr extent)
		{
			vtkImageAccumulate.vtkImageAccumulate_GetComponentExtent_01(base.GetCppThis(), extent);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageAccumulate_GetComponentExtent_02(HandleRef pThis);

		public int[] GetComponentExtent()
		{
			IntPtr intPtr = vtkImageAccumulate.vtkImageAccumulate_GetComponentExtent_02(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageAccumulate_GetComponentOrigin_03(HandleRef pThis);

		public virtual double[] GetComponentOrigin()
		{
			IntPtr intPtr = vtkImageAccumulate.vtkImageAccumulate_GetComponentOrigin_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAccumulate_GetComponentOrigin_04(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetComponentOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageAccumulate.vtkImageAccumulate_GetComponentOrigin_04(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAccumulate_GetComponentOrigin_05(HandleRef pThis, IntPtr _arg);

		public virtual void GetComponentOrigin(IntPtr _arg)
		{
			vtkImageAccumulate.vtkImageAccumulate_GetComponentOrigin_05(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageAccumulate_GetComponentSpacing_06(HandleRef pThis);

		public virtual double[] GetComponentSpacing()
		{
			IntPtr intPtr = vtkImageAccumulate.vtkImageAccumulate_GetComponentSpacing_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAccumulate_GetComponentSpacing_07(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetComponentSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageAccumulate.vtkImageAccumulate_GetComponentSpacing_07(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAccumulate_GetComponentSpacing_08(HandleRef pThis, IntPtr _arg);

		public virtual void GetComponentSpacing(IntPtr _arg)
		{
			vtkImageAccumulate.vtkImageAccumulate_GetComponentSpacing_08(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageAccumulate_GetIgnoreZero_09(HandleRef pThis);

		public virtual int GetIgnoreZero()
		{
			return vtkImageAccumulate.vtkImageAccumulate_GetIgnoreZero_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageAccumulate_GetIgnoreZeroMaxValue_10(HandleRef pThis);

		public virtual int GetIgnoreZeroMaxValue()
		{
			return vtkImageAccumulate.vtkImageAccumulate_GetIgnoreZeroMaxValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageAccumulate_GetIgnoreZeroMinValue_11(HandleRef pThis);

		public virtual int GetIgnoreZeroMinValue()
		{
			return vtkImageAccumulate.vtkImageAccumulate_GetIgnoreZeroMinValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageAccumulate_GetMax_12(HandleRef pThis);

		public virtual double[] GetMax()
		{
			IntPtr intPtr = vtkImageAccumulate.vtkImageAccumulate_GetMax_12(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAccumulate_GetMax_13(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetMax(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageAccumulate.vtkImageAccumulate_GetMax_13(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAccumulate_GetMax_14(HandleRef pThis, IntPtr _arg);

		public virtual void GetMax(IntPtr _arg)
		{
			vtkImageAccumulate.vtkImageAccumulate_GetMax_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageAccumulate_GetMean_15(HandleRef pThis);

		public virtual double[] GetMean()
		{
			IntPtr intPtr = vtkImageAccumulate.vtkImageAccumulate_GetMean_15(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAccumulate_GetMean_16(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetMean(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageAccumulate.vtkImageAccumulate_GetMean_16(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAccumulate_GetMean_17(HandleRef pThis, IntPtr _arg);

		public virtual void GetMean(IntPtr _arg)
		{
			vtkImageAccumulate.vtkImageAccumulate_GetMean_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageAccumulate_GetMin_18(HandleRef pThis);

		public virtual double[] GetMin()
		{
			IntPtr intPtr = vtkImageAccumulate.vtkImageAccumulate_GetMin_18(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAccumulate_GetMin_19(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetMin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageAccumulate.vtkImageAccumulate_GetMin_19(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAccumulate_GetMin_20(HandleRef pThis, IntPtr _arg);

		public virtual void GetMin(IntPtr _arg)
		{
			vtkImageAccumulate.vtkImageAccumulate_GetMin_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageAccumulate_GetReverseStencil_21(HandleRef pThis);

		public virtual int GetReverseStencil()
		{
			return vtkImageAccumulate.vtkImageAccumulate_GetReverseStencil_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageAccumulate_GetReverseStencilMaxValue_22(HandleRef pThis);

		public virtual int GetReverseStencilMaxValue()
		{
			return vtkImageAccumulate.vtkImageAccumulate_GetReverseStencilMaxValue_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageAccumulate_GetReverseStencilMinValue_23(HandleRef pThis);

		public virtual int GetReverseStencilMinValue()
		{
			return vtkImageAccumulate.vtkImageAccumulate_GetReverseStencilMinValue_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageAccumulate_GetStandardDeviation_24(HandleRef pThis);

		public virtual double[] GetStandardDeviation()
		{
			IntPtr intPtr = vtkImageAccumulate.vtkImageAccumulate_GetStandardDeviation_24(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAccumulate_GetStandardDeviation_25(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetStandardDeviation(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageAccumulate.vtkImageAccumulate_GetStandardDeviation_25(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAccumulate_GetStandardDeviation_26(HandleRef pThis, IntPtr _arg);

		public virtual void GetStandardDeviation(IntPtr _arg)
		{
			vtkImageAccumulate.vtkImageAccumulate_GetStandardDeviation_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageAccumulate_GetStencil_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkImageStencilData GetStencil()
		{
			vtkImageStencilData vtkImageStencilData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageAccumulate.vtkImageAccumulate_GetStencil_27(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageStencilData = (vtkImageStencilData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageStencilData.Register(null);
				}
			}
			return vtkImageStencilData;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern long vtkImageAccumulate_GetVoxelCount_28(HandleRef pThis);

		public virtual long GetVoxelCount()
		{
			return vtkImageAccumulate.vtkImageAccumulate_GetVoxelCount_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAccumulate_IgnoreZeroOff_29(HandleRef pThis);

		public virtual void IgnoreZeroOff()
		{
			vtkImageAccumulate.vtkImageAccumulate_IgnoreZeroOff_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAccumulate_IgnoreZeroOn_30(HandleRef pThis);

		public virtual void IgnoreZeroOn()
		{
			vtkImageAccumulate.vtkImageAccumulate_IgnoreZeroOn_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageAccumulate_IsA_31(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageAccumulate.vtkImageAccumulate_IsA_31(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageAccumulate_IsTypeOf_32(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageAccumulate.vtkImageAccumulate_IsTypeOf_32(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageAccumulate_NewInstance_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageAccumulate NewInstance()
		{
			vtkImageAccumulate result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageAccumulate.vtkImageAccumulate_NewInstance_34(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageAccumulate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAccumulate_ReverseStencilOff_35(HandleRef pThis);

		public virtual void ReverseStencilOff()
		{
			vtkImageAccumulate.vtkImageAccumulate_ReverseStencilOff_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAccumulate_ReverseStencilOn_36(HandleRef pThis);

		public virtual void ReverseStencilOn()
		{
			vtkImageAccumulate.vtkImageAccumulate_ReverseStencilOn_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageAccumulate_SafeDownCast_37(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageAccumulate SafeDownCast(vtkObjectBase o)
		{
			vtkImageAccumulate vtkImageAccumulate = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageAccumulate.vtkImageAccumulate_SafeDownCast_37((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageAccumulate = (vtkImageAccumulate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageAccumulate.Register(null);
				}
			}
			return vtkImageAccumulate;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAccumulate_SetComponentExtent_38(HandleRef pThis, IntPtr extent);

		public void SetComponentExtent(IntPtr extent)
		{
			vtkImageAccumulate.vtkImageAccumulate_SetComponentExtent_38(base.GetCppThis(), extent);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAccumulate_SetComponentExtent_39(HandleRef pThis, int minX, int maxX, int minY, int maxY, int minZ, int maxZ);

		public void SetComponentExtent(int minX, int maxX, int minY, int maxY, int minZ, int maxZ)
		{
			vtkImageAccumulate.vtkImageAccumulate_SetComponentExtent_39(base.GetCppThis(), minX, maxX, minY, maxY, minZ, maxZ);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAccumulate_SetComponentOrigin_40(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetComponentOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkImageAccumulate.vtkImageAccumulate_SetComponentOrigin_40(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAccumulate_SetComponentOrigin_41(HandleRef pThis, IntPtr _arg);

		public virtual void SetComponentOrigin(IntPtr _arg)
		{
			vtkImageAccumulate.vtkImageAccumulate_SetComponentOrigin_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAccumulate_SetComponentSpacing_42(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetComponentSpacing(double _arg1, double _arg2, double _arg3)
		{
			vtkImageAccumulate.vtkImageAccumulate_SetComponentSpacing_42(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAccumulate_SetComponentSpacing_43(HandleRef pThis, IntPtr _arg);

		public virtual void SetComponentSpacing(IntPtr _arg)
		{
			vtkImageAccumulate.vtkImageAccumulate_SetComponentSpacing_43(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAccumulate_SetIgnoreZero_44(HandleRef pThis, int _arg);

		public virtual void SetIgnoreZero(int _arg)
		{
			vtkImageAccumulate.vtkImageAccumulate_SetIgnoreZero_44(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAccumulate_SetReverseStencil_45(HandleRef pThis, int _arg);

		public virtual void SetReverseStencil(int _arg)
		{
			vtkImageAccumulate.vtkImageAccumulate_SetReverseStencil_45(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAccumulate_SetStencil_46(HandleRef pThis, HandleRef stencil);

		public void SetStencil(vtkImageStencilData stencil)
		{
			vtkImageAccumulate.vtkImageAccumulate_SetStencil_46(base.GetCppThis(), (stencil == null) ? default(HandleRef) : stencil.GetCppThis());
		}
	}
}
