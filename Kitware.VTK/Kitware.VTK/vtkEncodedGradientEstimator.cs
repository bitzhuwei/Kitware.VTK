using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkEncodedGradientEstimator : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkEncodedGradientEstimator";

		public new static readonly string MRClassNameKey;

		static vtkEncodedGradientEstimator()
		{
			vtkEncodedGradientEstimator.MRClassNameKey = "class vtkEncodedGradientEstimator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEncodedGradientEstimator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEncodedGradientEstimator"));
		}

		public vtkEncodedGradientEstimator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkEncodedGradientEstimator_BoundsClipOff_01(HandleRef pThis);

		public virtual void BoundsClipOff()
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_BoundsClipOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkEncodedGradientEstimator_BoundsClipOn_02(HandleRef pThis);

		public virtual void BoundsClipOn()
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_BoundsClipOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkEncodedGradientEstimator_ComputeGradientMagnitudesOff_03(HandleRef pThis);

		public virtual void ComputeGradientMagnitudesOff()
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_ComputeGradientMagnitudesOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkEncodedGradientEstimator_ComputeGradientMagnitudesOn_04(HandleRef pThis);

		public virtual void ComputeGradientMagnitudesOn()
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_ComputeGradientMagnitudesOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkEncodedGradientEstimator_CylinderClipOff_05(HandleRef pThis);

		public virtual void CylinderClipOff()
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_CylinderClipOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkEncodedGradientEstimator_CylinderClipOn_06(HandleRef pThis);

		public virtual void CylinderClipOn()
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_CylinderClipOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkEncodedGradientEstimator_GetBounds_07(HandleRef pThis);

		public virtual int[] GetBounds()
		{
			IntPtr intPtr = vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetBounds_07(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkEncodedGradientEstimator_GetBounds_08(HandleRef pThis, IntPtr data);

		public virtual void GetBounds(IntPtr data)
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetBounds_08(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkEncodedGradientEstimator_GetBoundsClip_09(HandleRef pThis);

		public virtual int GetBoundsClip()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetBoundsClip_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkEncodedGradientEstimator_GetBoundsClipMaxValue_10(HandleRef pThis);

		public virtual int GetBoundsClipMaxValue()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetBoundsClipMaxValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkEncodedGradientEstimator_GetBoundsClipMinValue_11(HandleRef pThis);

		public virtual int GetBoundsClipMinValue()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetBoundsClipMinValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkEncodedGradientEstimator_GetCircleLimits_12(HandleRef pThis);

		public IntPtr GetCircleLimits()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetCircleLimits_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkEncodedGradientEstimator_GetComputeGradientMagnitudes_13(HandleRef pThis);

		public virtual int GetComputeGradientMagnitudes()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetComputeGradientMagnitudes_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkEncodedGradientEstimator_GetCylinderClip_14(HandleRef pThis);

		public virtual int GetCylinderClip()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetCylinderClip_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkEncodedGradientEstimator_GetDirectionEncoder_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDirectionEncoder GetDirectionEncoder()
		{
			vtkDirectionEncoder vtkDirectionEncoder = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetDirectionEncoder_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDirectionEncoder = (vtkDirectionEncoder)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDirectionEncoder.Register(null);
				}
			}
			return vtkDirectionEncoder;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkEncodedGradientEstimator_GetEncodedNormalIndex_16(HandleRef pThis, int xyz_index);

		public int GetEncodedNormalIndex(int xyz_index)
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetEncodedNormalIndex_16(base.GetCppThis(), xyz_index);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkEncodedGradientEstimator_GetEncodedNormalIndex_17(HandleRef pThis, int x_index, int y_index, int z_index);

		public int GetEncodedNormalIndex(int x_index, int y_index, int z_index)
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetEncodedNormalIndex_17(base.GetCppThis(), x_index, y_index, z_index);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkEncodedGradientEstimator_GetEncodedNormals_18(HandleRef pThis);

		public IntPtr GetEncodedNormals()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetEncodedNormals_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkEncodedGradientEstimator_GetGradientMagnitudeBias_19(HandleRef pThis);

		public virtual float GetGradientMagnitudeBias()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetGradientMagnitudeBias_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkEncodedGradientEstimator_GetGradientMagnitudeScale_20(HandleRef pThis);

		public virtual float GetGradientMagnitudeScale()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetGradientMagnitudeScale_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkEncodedGradientEstimator_GetGradientMagnitudes_21(HandleRef pThis);

		public IntPtr GetGradientMagnitudes()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetGradientMagnitudes_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkEncodedGradientEstimator_GetInput_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImageData GetInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetInput_22(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkEncodedGradientEstimator_GetInputAspect_23(HandleRef pThis);

		public virtual float[] GetInputAspect()
		{
			IntPtr intPtr = vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetInputAspect_23(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkEncodedGradientEstimator_GetInputAspect_24(HandleRef pThis, IntPtr data);

		public virtual void GetInputAspect(IntPtr data)
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetInputAspect_24(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkEncodedGradientEstimator_GetInputSize_25(HandleRef pThis);

		public virtual int[] GetInputSize()
		{
			IntPtr intPtr = vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetInputSize_25(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkEncodedGradientEstimator_GetInputSize_26(HandleRef pThis, IntPtr data);

		public virtual void GetInputSize(IntPtr data)
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetInputSize_26(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkEncodedGradientEstimator_GetLastUpdateTimeInCPUSeconds_27(HandleRef pThis);

		public virtual float GetLastUpdateTimeInCPUSeconds()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetLastUpdateTimeInCPUSeconds_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkEncodedGradientEstimator_GetLastUpdateTimeInSeconds_28(HandleRef pThis);

		public virtual float GetLastUpdateTimeInSeconds()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetLastUpdateTimeInSeconds_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkEncodedGradientEstimator_GetNumberOfThreads_29(HandleRef pThis);

		public virtual int GetNumberOfThreads()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetNumberOfThreads_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkEncodedGradientEstimator_GetNumberOfThreadsMaxValue_30(HandleRef pThis);

		public virtual int GetNumberOfThreadsMaxValue()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetNumberOfThreadsMaxValue_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkEncodedGradientEstimator_GetNumberOfThreadsMinValue_31(HandleRef pThis);

		public virtual int GetNumberOfThreadsMinValue()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetNumberOfThreadsMinValue_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkEncodedGradientEstimator_GetUseCylinderClip_32(HandleRef pThis);

		public virtual int GetUseCylinderClip()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetUseCylinderClip_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkEncodedGradientEstimator_GetZeroNormalThreshold_33(HandleRef pThis);

		public virtual float GetZeroNormalThreshold()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetZeroNormalThreshold_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkEncodedGradientEstimator_GetZeroPad_34(HandleRef pThis);

		public virtual int GetZeroPad()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetZeroPad_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkEncodedGradientEstimator_GetZeroPadMaxValue_35(HandleRef pThis);

		public virtual int GetZeroPadMaxValue()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetZeroPadMaxValue_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkEncodedGradientEstimator_GetZeroPadMinValue_36(HandleRef pThis);

		public virtual int GetZeroPadMinValue()
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_GetZeroPadMinValue_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkEncodedGradientEstimator_IsA_37(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_IsA_37(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkEncodedGradientEstimator_IsTypeOf_38(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_IsTypeOf_38(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkEncodedGradientEstimator_NewInstance_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkEncodedGradientEstimator NewInstance()
		{
			vtkEncodedGradientEstimator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_NewInstance_39(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEncodedGradientEstimator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkEncodedGradientEstimator_SafeDownCast_40(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkEncodedGradientEstimator SafeDownCast(vtkObjectBase o)
		{
			vtkEncodedGradientEstimator vtkEncodedGradientEstimator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_SafeDownCast_40((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEncodedGradientEstimator = (vtkEncodedGradientEstimator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEncodedGradientEstimator.Register(null);
				}
			}
			return vtkEncodedGradientEstimator;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkEncodedGradientEstimator_SetBounds_41(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		public virtual void SetBounds(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_SetBounds_41(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkEncodedGradientEstimator_SetBounds_42(HandleRef pThis, IntPtr _arg);

		public virtual void SetBounds(IntPtr _arg)
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_SetBounds_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkEncodedGradientEstimator_SetBoundsClip_43(HandleRef pThis, int _arg);

		public virtual void SetBoundsClip(int _arg)
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_SetBoundsClip_43(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkEncodedGradientEstimator_SetComputeGradientMagnitudes_44(HandleRef pThis, int _arg);

		public virtual void SetComputeGradientMagnitudes(int _arg)
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_SetComputeGradientMagnitudes_44(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkEncodedGradientEstimator_SetCylinderClip_45(HandleRef pThis, int _arg);

		public virtual void SetCylinderClip(int _arg)
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_SetCylinderClip_45(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkEncodedGradientEstimator_SetDirectionEncoder_46(HandleRef pThis, HandleRef direnc);

		public void SetDirectionEncoder(vtkDirectionEncoder direnc)
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_SetDirectionEncoder_46(base.GetCppThis(), (direnc == null) ? default(HandleRef) : direnc.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkEncodedGradientEstimator_SetGradientMagnitudeBias_47(HandleRef pThis, float _arg);

		public virtual void SetGradientMagnitudeBias(float _arg)
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_SetGradientMagnitudeBias_47(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkEncodedGradientEstimator_SetGradientMagnitudeScale_48(HandleRef pThis, float _arg);

		public virtual void SetGradientMagnitudeScale(float _arg)
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_SetGradientMagnitudeScale_48(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkEncodedGradientEstimator_SetInput_49(HandleRef pThis, HandleRef arg0);

		public virtual void SetInput(vtkImageData arg0)
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_SetInput_49(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkEncodedGradientEstimator_SetNumberOfThreads_50(HandleRef pThis, int _arg);

		public virtual void SetNumberOfThreads(int _arg)
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_SetNumberOfThreads_50(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkEncodedGradientEstimator_SetZeroNormalThreshold_51(HandleRef pThis, float v);

		public void SetZeroNormalThreshold(float v)
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_SetZeroNormalThreshold_51(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkEncodedGradientEstimator_SetZeroPad_52(HandleRef pThis, int _arg);

		public virtual void SetZeroPad(int _arg)
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_SetZeroPad_52(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkEncodedGradientEstimator_Update_53(HandleRef pThis);

		public void Update()
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_Update_53(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkEncodedGradientEstimator_ZeroPadOff_54(HandleRef pThis);

		public virtual void ZeroPadOff()
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_ZeroPadOff_54(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkEncodedGradientEstimator_ZeroPadOn_55(HandleRef pThis);

		public virtual void ZeroPadOn()
		{
			vtkEncodedGradientEstimator.vtkEncodedGradientEstimator_ZeroPadOn_55(base.GetCppThis());
		}
	}
}
