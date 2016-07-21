using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkVolumeMapper : vtkAbstractVolumeMapper
	{
		public enum ADDITIVE_BLEND_WrapperEnum
		{
			ADDITIVE_BLEND = 3,
			COMPOSITE_BLEND = 0,
			MAXIMUM_INTENSITY_BLEND,
			MINIMUM_INTENSITY_BLEND
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkVolumeMapper";

		public new static readonly string MRClassNameKey;

		static vtkVolumeMapper()
		{
			vtkVolumeMapper.MRClassNameKey = "class vtkVolumeMapper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVolumeMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolumeMapper"));
		}

		public vtkVolumeMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeMapper_CroppingOff_01(HandleRef pThis);

		public virtual void CroppingOff()
		{
			vtkVolumeMapper.vtkVolumeMapper_CroppingOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeMapper_CroppingOn_02(HandleRef pThis);

		public virtual void CroppingOn()
		{
			vtkVolumeMapper.vtkVolumeMapper_CroppingOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeMapper_GetBlendMode_03(HandleRef pThis);

		public virtual int GetBlendMode()
		{
			return vtkVolumeMapper.vtkVolumeMapper_GetBlendMode_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeMapper_GetCropping_04(HandleRef pThis);

		public virtual int GetCropping()
		{
			return vtkVolumeMapper.vtkVolumeMapper_GetCropping_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeMapper_GetCroppingMaxValue_05(HandleRef pThis);

		public virtual int GetCroppingMaxValue()
		{
			return vtkVolumeMapper.vtkVolumeMapper_GetCroppingMaxValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeMapper_GetCroppingMinValue_06(HandleRef pThis);

		public virtual int GetCroppingMinValue()
		{
			return vtkVolumeMapper.vtkVolumeMapper_GetCroppingMinValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeMapper_GetCroppingRegionFlags_07(HandleRef pThis);

		public virtual int GetCroppingRegionFlags()
		{
			return vtkVolumeMapper.vtkVolumeMapper_GetCroppingRegionFlags_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeMapper_GetCroppingRegionFlagsMaxValue_08(HandleRef pThis);

		public virtual int GetCroppingRegionFlagsMaxValue()
		{
			return vtkVolumeMapper.vtkVolumeMapper_GetCroppingRegionFlagsMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeMapper_GetCroppingRegionFlagsMinValue_09(HandleRef pThis);

		public virtual int GetCroppingRegionFlagsMinValue()
		{
			return vtkVolumeMapper.vtkVolumeMapper_GetCroppingRegionFlagsMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeMapper_GetCroppingRegionPlanes_10(HandleRef pThis);

		public virtual double[] GetCroppingRegionPlanes()
		{
			IntPtr intPtr = vtkVolumeMapper.vtkVolumeMapper_GetCroppingRegionPlanes_10(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeMapper_GetCroppingRegionPlanes_11(HandleRef pThis, IntPtr data);

		public virtual void GetCroppingRegionPlanes(IntPtr data)
		{
			vtkVolumeMapper.vtkVolumeMapper_GetCroppingRegionPlanes_11(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeMapper_GetInput_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkImageData GetInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeMapper.vtkVolumeMapper_GetInput_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkVolumeMapper_GetVoxelCroppingRegionPlanes_13(HandleRef pThis);

		public virtual double[] GetVoxelCroppingRegionPlanes()
		{
			IntPtr intPtr = vtkVolumeMapper.vtkVolumeMapper_GetVoxelCroppingRegionPlanes_13(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeMapper_GetVoxelCroppingRegionPlanes_14(HandleRef pThis, IntPtr data);

		public virtual void GetVoxelCroppingRegionPlanes(IntPtr data)
		{
			vtkVolumeMapper.vtkVolumeMapper_GetVoxelCroppingRegionPlanes_14(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeMapper_IsA_15(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkVolumeMapper.vtkVolumeMapper_IsA_15(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeMapper_IsTypeOf_16(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkVolumeMapper.vtkVolumeMapper_IsTypeOf_16(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeMapper_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkVolumeMapper NewInstance()
		{
			vtkVolumeMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeMapper.vtkVolumeMapper_NewInstance_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeMapper_ReleaseGraphicsResources_18(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkVolumeMapper.vtkVolumeMapper_ReleaseGraphicsResources_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeMapper_Render_19(HandleRef pThis, HandleRef ren, HandleRef vol);

		public override void Render(vtkRenderer ren, vtkVolume vol)
		{
			vtkVolumeMapper.vtkVolumeMapper_Render_19(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeMapper_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVolumeMapper SafeDownCast(vtkObjectBase o)
		{
			vtkVolumeMapper vtkVolumeMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeMapper.vtkVolumeMapper_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumeMapper = (vtkVolumeMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumeMapper.Register(null);
				}
			}
			return vtkVolumeMapper;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeMapper_SetBlendMode_21(HandleRef pThis, int _arg);

		public virtual void SetBlendMode(int _arg)
		{
			vtkVolumeMapper.vtkVolumeMapper_SetBlendMode_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeMapper_SetBlendModeToAdditive_22(HandleRef pThis);

		public void SetBlendModeToAdditive()
		{
			vtkVolumeMapper.vtkVolumeMapper_SetBlendModeToAdditive_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeMapper_SetBlendModeToComposite_23(HandleRef pThis);

		public void SetBlendModeToComposite()
		{
			vtkVolumeMapper.vtkVolumeMapper_SetBlendModeToComposite_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeMapper_SetBlendModeToMaximumIntensity_24(HandleRef pThis);

		public void SetBlendModeToMaximumIntensity()
		{
			vtkVolumeMapper.vtkVolumeMapper_SetBlendModeToMaximumIntensity_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeMapper_SetBlendModeToMinimumIntensity_25(HandleRef pThis);

		public void SetBlendModeToMinimumIntensity()
		{
			vtkVolumeMapper.vtkVolumeMapper_SetBlendModeToMinimumIntensity_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeMapper_SetCropping_26(HandleRef pThis, int _arg);

		public virtual void SetCropping(int _arg)
		{
			vtkVolumeMapper.vtkVolumeMapper_SetCropping_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeMapper_SetCroppingRegionFlags_27(HandleRef pThis, int _arg);

		public virtual void SetCroppingRegionFlags(int _arg)
		{
			vtkVolumeMapper.vtkVolumeMapper_SetCroppingRegionFlags_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeMapper_SetCroppingRegionFlagsToCross_28(HandleRef pThis);

		public void SetCroppingRegionFlagsToCross()
		{
			vtkVolumeMapper.vtkVolumeMapper_SetCroppingRegionFlagsToCross_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeMapper_SetCroppingRegionFlagsToFence_29(HandleRef pThis);

		public void SetCroppingRegionFlagsToFence()
		{
			vtkVolumeMapper.vtkVolumeMapper_SetCroppingRegionFlagsToFence_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeMapper_SetCroppingRegionFlagsToInvertedCross_30(HandleRef pThis);

		public void SetCroppingRegionFlagsToInvertedCross()
		{
			vtkVolumeMapper.vtkVolumeMapper_SetCroppingRegionFlagsToInvertedCross_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeMapper_SetCroppingRegionFlagsToInvertedFence_31(HandleRef pThis);

		public void SetCroppingRegionFlagsToInvertedFence()
		{
			vtkVolumeMapper.vtkVolumeMapper_SetCroppingRegionFlagsToInvertedFence_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeMapper_SetCroppingRegionFlagsToSubVolume_32(HandleRef pThis);

		public void SetCroppingRegionFlagsToSubVolume()
		{
			vtkVolumeMapper.vtkVolumeMapper_SetCroppingRegionFlagsToSubVolume_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeMapper_SetCroppingRegionPlanes_33(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		public virtual void SetCroppingRegionPlanes(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkVolumeMapper.vtkVolumeMapper_SetCroppingRegionPlanes_33(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeMapper_SetCroppingRegionPlanes_34(HandleRef pThis, IntPtr _arg);

		public virtual void SetCroppingRegionPlanes(IntPtr _arg)
		{
			vtkVolumeMapper.vtkVolumeMapper_SetCroppingRegionPlanes_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeMapper_SetInput_35(HandleRef pThis, HandleRef arg0);

		public virtual void SetInput(vtkImageData arg0)
		{
			vtkVolumeMapper.vtkVolumeMapper_SetInput_35(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeMapper_SetInput_36(HandleRef pThis, HandleRef arg0);

		public override void SetInput(vtkDataSet arg0)
		{
			vtkVolumeMapper.vtkVolumeMapper_SetInput_36(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
