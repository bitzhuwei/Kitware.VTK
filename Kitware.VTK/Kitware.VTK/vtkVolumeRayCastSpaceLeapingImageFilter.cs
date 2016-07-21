using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkVolumeRayCastSpaceLeapingImageFilter : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkVolumeRayCastSpaceLeapingImageFilter";

		public new static readonly string MRClassNameKey;

		static vtkVolumeRayCastSpaceLeapingImageFilter()
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.MRClassNameKey = "class vtkVolumeRayCastSpaceLeapingImageFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVolumeRayCastSpaceLeapingImageFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolumeRayCastSpaceLeapingImageFilter"));
		}

		public vtkVolumeRayCastSpaceLeapingImageFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeRayCastSpaceLeapingImageFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVolumeRayCastSpaceLeapingImageFilter New()
		{
			vtkVolumeRayCastSpaceLeapingImageFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeRayCastSpaceLeapingImageFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkVolumeRayCastSpaceLeapingImageFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_ComputeGradientOpacityOff_01(HandleRef pThis);

		public virtual void ComputeGradientOpacityOff()
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_ComputeGradientOpacityOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_ComputeGradientOpacityOn_02(HandleRef pThis);

		public virtual void ComputeGradientOpacityOn()
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_ComputeGradientOpacityOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_ComputeInputExtentsForOutput_03(IntPtr inExt, IntPtr inDim, IntPtr outExt, HandleRef inData);

		public static void ComputeInputExtentsForOutput(IntPtr inExt, IntPtr inDim, IntPtr outExt, vtkImageData inData)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_ComputeInputExtentsForOutput_03(inExt, inDim, outExt, (inData == null) ? default(HandleRef) : inData.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_ComputeMinMaxOff_04(HandleRef pThis);

		public virtual void ComputeMinMaxOff()
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_ComputeMinMaxOff_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_ComputeMinMaxOn_05(HandleRef pThis);

		public virtual void ComputeMinMaxOn()
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_ComputeMinMaxOn_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern uint vtkVolumeRayCastSpaceLeapingImageFilter_ComputeOffset_06(HandleRef pThis, IntPtr ext, IntPtr wholeExt, int nComponents);

		public uint ComputeOffset(IntPtr ext, IntPtr wholeExt, int nComponents)
		{
			return vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_ComputeOffset_06(base.GetCppThis(), ext, wholeExt, nComponents);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeRayCastSpaceLeapingImageFilter_GetComputeGradientOpacity_07(HandleRef pThis);

		public virtual int GetComputeGradientOpacity()
		{
			return vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetComputeGradientOpacity_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeRayCastSpaceLeapingImageFilter_GetComputeMinMax_08(HandleRef pThis);

		public virtual int GetComputeMinMax()
		{
			return vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetComputeMinMax_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeRayCastSpaceLeapingImageFilter_GetCurrentScalars_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataArray GetCurrentScalars()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetCurrentScalars_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeRayCastSpaceLeapingImageFilter_GetIndependentComponents_10(HandleRef pThis);

		public virtual int GetIndependentComponents()
		{
			return vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetIndependentComponents_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern uint vtkVolumeRayCastSpaceLeapingImageFilter_GetLastMinMaxBuildTime_11(HandleRef pThis);

		public uint GetLastMinMaxBuildTime()
		{
			return vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetLastMinMaxBuildTime_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern uint vtkVolumeRayCastSpaceLeapingImageFilter_GetLastMinMaxFlagTime_12(HandleRef pThis);

		public uint GetLastMinMaxFlagTime()
		{
			return vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetLastMinMaxFlagTime_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeRayCastSpaceLeapingImageFilter_GetMinMaxVolume_13(HandleRef pThis, IntPtr dims);

		public IntPtr GetMinMaxVolume(IntPtr dims)
		{
			return vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetMinMaxVolume_13(base.GetCppThis(), dims);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeRayCastSpaceLeapingImageFilter_GetMinNonZeroGradientMagnitudeIndex_14(HandleRef pThis);

		public IntPtr GetMinNonZeroGradientMagnitudeIndex()
		{
			return vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetMinNonZeroGradientMagnitudeIndex_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeRayCastSpaceLeapingImageFilter_GetMinNonZeroScalarIndex_15(HandleRef pThis);

		public IntPtr GetMinNonZeroScalarIndex()
		{
			return vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetMinNonZeroScalarIndex_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeRayCastSpaceLeapingImageFilter_GetNumberOfIndependentComponents_16(HandleRef pThis);

		public int GetNumberOfIndependentComponents()
		{
			return vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetNumberOfIndependentComponents_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeRayCastSpaceLeapingImageFilter_GetTableScale_17(HandleRef pThis);

		public virtual float[] GetTableScale()
		{
			IntPtr intPtr = vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetTableScale_17(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_GetTableScale_18(HandleRef pThis, ref float _arg1, ref float _arg2, ref float _arg3, ref float _arg4);

		public virtual void GetTableScale(ref float _arg1, ref float _arg2, ref float _arg3, ref float _arg4)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetTableScale_18(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_GetTableScale_19(HandleRef pThis, IntPtr _arg);

		public virtual void GetTableScale(IntPtr _arg)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetTableScale_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeRayCastSpaceLeapingImageFilter_GetTableShift_20(HandleRef pThis);

		public virtual float[] GetTableShift()
		{
			IntPtr intPtr = vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetTableShift_20(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_GetTableShift_21(HandleRef pThis, ref float _arg1, ref float _arg2, ref float _arg3, ref float _arg4);

		public virtual void GetTableShift(ref float _arg1, ref float _arg2, ref float _arg3, ref float _arg4)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetTableShift_21(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_GetTableShift_22(HandleRef pThis, IntPtr _arg);

		public virtual void GetTableShift(IntPtr _arg)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetTableShift_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeRayCastSpaceLeapingImageFilter_GetTableSize_23(HandleRef pThis);

		public virtual int[] GetTableSize()
		{
			IntPtr intPtr = vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetTableSize_23(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_GetTableSize_24(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4);

		public virtual void GetTableSize(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetTableSize_24(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_GetTableSize_25(HandleRef pThis, IntPtr _arg);

		public virtual void GetTableSize(IntPtr _arg)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetTableSize_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeRayCastSpaceLeapingImageFilter_GetUpdateGradientOpacityFlags_26(HandleRef pThis);

		public virtual int GetUpdateGradientOpacityFlags()
		{
			return vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetUpdateGradientOpacityFlags_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeRayCastSpaceLeapingImageFilter_IsA_27(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_IsA_27(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeRayCastSpaceLeapingImageFilter_IsTypeOf_28(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_IsTypeOf_28(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeRayCastSpaceLeapingImageFilter_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkVolumeRayCastSpaceLeapingImageFilter NewInstance()
		{
			vtkVolumeRayCastSpaceLeapingImageFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_NewInstance_30(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeRayCastSpaceLeapingImageFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeRayCastSpaceLeapingImageFilter_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVolumeRayCastSpaceLeapingImageFilter SafeDownCast(vtkObjectBase o)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter vtkVolumeRayCastSpaceLeapingImageFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_SafeDownCast_31((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumeRayCastSpaceLeapingImageFilter = (vtkVolumeRayCastSpaceLeapingImageFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumeRayCastSpaceLeapingImageFilter.Register(null);
				}
			}
			return vtkVolumeRayCastSpaceLeapingImageFilter;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetCache_32(HandleRef pThis, HandleRef imageCache);

		public virtual void SetCache(vtkImageData imageCache)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_SetCache_32(base.GetCppThis(), (imageCache == null) ? default(HandleRef) : imageCache.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetComputeGradientOpacity_33(HandleRef pThis, int _arg);

		public virtual void SetComputeGradientOpacity(int _arg)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_SetComputeGradientOpacity_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetComputeMinMax_34(HandleRef pThis, int _arg);

		public virtual void SetComputeMinMax(int _arg)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_SetComputeMinMax_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetCurrentScalars_35(HandleRef pThis, HandleRef arg0);

		public virtual void SetCurrentScalars(vtkDataArray arg0)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_SetCurrentScalars_35(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetGradientOpacityTable_36(HandleRef pThis, int c, IntPtr t);

		public void SetGradientOpacityTable(int c, IntPtr t)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_SetGradientOpacityTable_36(base.GetCppThis(), c, t);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetIndependentComponents_37(HandleRef pThis, int _arg);

		public virtual void SetIndependentComponents(int _arg)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_SetIndependentComponents_37(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetScalarOpacityTable_38(HandleRef pThis, int c, IntPtr t);

		public void SetScalarOpacityTable(int c, IntPtr t)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_SetScalarOpacityTable_38(base.GetCppThis(), c, t);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetTableScale_39(HandleRef pThis, float _arg1, float _arg2, float _arg3, float _arg4);

		public virtual void SetTableScale(float _arg1, float _arg2, float _arg3, float _arg4)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_SetTableScale_39(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetTableScale_40(HandleRef pThis, IntPtr _arg);

		public virtual void SetTableScale(IntPtr _arg)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_SetTableScale_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetTableShift_41(HandleRef pThis, float _arg1, float _arg2, float _arg3, float _arg4);

		public virtual void SetTableShift(float _arg1, float _arg2, float _arg3, float _arg4)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_SetTableShift_41(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetTableShift_42(HandleRef pThis, IntPtr _arg);

		public virtual void SetTableShift(IntPtr _arg)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_SetTableShift_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetTableSize_43(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4);

		public virtual void SetTableSize(int _arg1, int _arg2, int _arg3, int _arg4)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_SetTableSize_43(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetTableSize_44(HandleRef pThis, IntPtr _arg);

		public virtual void SetTableSize(IntPtr _arg)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_SetTableSize_44(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetUpdateGradientOpacityFlags_45(HandleRef pThis, int _arg);

		public virtual void SetUpdateGradientOpacityFlags(int _arg)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_SetUpdateGradientOpacityFlags_45(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_UpdateGradientOpacityFlagsOff_46(HandleRef pThis);

		public virtual void UpdateGradientOpacityFlagsOff()
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_UpdateGradientOpacityFlagsOff_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_UpdateGradientOpacityFlagsOn_47(HandleRef pThis);

		public virtual void UpdateGradientOpacityFlagsOn()
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_UpdateGradientOpacityFlagsOn_47(base.GetCppThis());
		}
	}
}
