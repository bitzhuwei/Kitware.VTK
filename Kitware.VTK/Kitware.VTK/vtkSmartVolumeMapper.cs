using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSmartVolumeMapper : vtkVolumeMapper
	{
		public enum DefaultRenderMode_WrapperEnum
		{
			DefaultRenderMode,
			GPURenderMode = 4,
			InvalidRenderMode = 6,
			RayCastAndTextureRenderMode = 1,
			RayCastRenderMode,
			TextureRenderMode,
			UndefinedRenderMode = 5
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkSmartVolumeMapper";

		public new static readonly string MRClassNameKey;

		static vtkSmartVolumeMapper()
		{
			vtkSmartVolumeMapper.MRClassNameKey = "class vtkSmartVolumeMapper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSmartVolumeMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSmartVolumeMapper"));
		}

		public vtkSmartVolumeMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkSmartVolumeMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSmartVolumeMapper New()
		{
			vtkSmartVolumeMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSmartVolumeMapper.vtkSmartVolumeMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSmartVolumeMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSmartVolumeMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSmartVolumeMapper.vtkSmartVolumeMapper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkSmartVolumeMapper_CreateCanonicalView_01(HandleRef pThis, HandleRef ren, HandleRef volume, HandleRef volume2, HandleRef image, int blend_mode, IntPtr viewDirection, IntPtr viewUp);

		public void CreateCanonicalView(vtkRenderer ren, vtkVolume volume, vtkVolume volume2, vtkImageData image, int blend_mode, IntPtr viewDirection, IntPtr viewUp)
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_CreateCanonicalView_01(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (volume == null) ? default(HandleRef) : volume.GetCppThis(), (volume2 == null) ? default(HandleRef) : volume2.GetCppThis(), (image == null) ? default(HandleRef) : image.GetCppThis(), blend_mode, viewDirection, viewUp);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkSmartVolumeMapper_GetFinalColorLevel_02(HandleRef pThis);

		public virtual float GetFinalColorLevel()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetFinalColorLevel_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkSmartVolumeMapper_GetFinalColorWindow_03(HandleRef pThis);

		public virtual float GetFinalColorWindow()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetFinalColorWindow_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern double vtkSmartVolumeMapper_GetInteractiveUpdateRate_04(HandleRef pThis);

		public virtual double GetInteractiveUpdateRate()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetInteractiveUpdateRate_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern double vtkSmartVolumeMapper_GetInteractiveUpdateRateMaxValue_05(HandleRef pThis);

		public virtual double GetInteractiveUpdateRateMaxValue()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetInteractiveUpdateRateMaxValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern double vtkSmartVolumeMapper_GetInteractiveUpdateRateMinValue_06(HandleRef pThis);

		public virtual double GetInteractiveUpdateRateMinValue()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetInteractiveUpdateRateMinValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkSmartVolumeMapper_GetInterpolationMode_07(HandleRef pThis);

		public virtual int GetInterpolationMode()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetInterpolationMode_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkSmartVolumeMapper_GetInterpolationModeMaxValue_08(HandleRef pThis);

		public virtual int GetInterpolationModeMaxValue()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetInterpolationModeMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkSmartVolumeMapper_GetInterpolationModeMinValue_09(HandleRef pThis);

		public virtual int GetInterpolationModeMinValue()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetInterpolationModeMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkSmartVolumeMapper_GetLastUsedRenderMode_10(HandleRef pThis);

		public int GetLastUsedRenderMode()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetLastUsedRenderMode_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkSmartVolumeMapper_GetMaxMemoryFraction_11(HandleRef pThis);

		public virtual float GetMaxMemoryFraction()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetMaxMemoryFraction_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkSmartVolumeMapper_GetMaxMemoryFractionMaxValue_12(HandleRef pThis);

		public virtual float GetMaxMemoryFractionMaxValue()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetMaxMemoryFractionMaxValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkSmartVolumeMapper_GetMaxMemoryFractionMinValue_13(HandleRef pThis);

		public virtual float GetMaxMemoryFractionMinValue()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetMaxMemoryFractionMinValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern long vtkSmartVolumeMapper_GetMaxMemoryInBytes_14(HandleRef pThis);

		public virtual long GetMaxMemoryInBytes()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetMaxMemoryInBytes_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkSmartVolumeMapper_GetRequestedRenderMode_15(HandleRef pThis);

		public virtual int GetRequestedRenderMode()
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_GetRequestedRenderMode_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkSmartVolumeMapper_IsA_16(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_IsA_16(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkSmartVolumeMapper_IsTypeOf_17(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSmartVolumeMapper.vtkSmartVolumeMapper_IsTypeOf_17(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkSmartVolumeMapper_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSmartVolumeMapper NewInstance()
		{
			vtkSmartVolumeMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSmartVolumeMapper.vtkSmartVolumeMapper_NewInstance_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSmartVolumeMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkSmartVolumeMapper_ReleaseGraphicsResources_20(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_ReleaseGraphicsResources_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkSmartVolumeMapper_Render_21(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		public override void Render(vtkRenderer arg0, vtkVolume arg1)
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_Render_21(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkSmartVolumeMapper_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSmartVolumeMapper SafeDownCast(vtkObjectBase o)
		{
			vtkSmartVolumeMapper vtkSmartVolumeMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSmartVolumeMapper.vtkSmartVolumeMapper_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSmartVolumeMapper = (vtkSmartVolumeMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSmartVolumeMapper.Register(null);
				}
			}
			return vtkSmartVolumeMapper;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkSmartVolumeMapper_SetFinalColorLevel_23(HandleRef pThis, float _arg);

		public virtual void SetFinalColorLevel(float _arg)
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_SetFinalColorLevel_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkSmartVolumeMapper_SetFinalColorWindow_24(HandleRef pThis, float _arg);

		public virtual void SetFinalColorWindow(float _arg)
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_SetFinalColorWindow_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkSmartVolumeMapper_SetInteractiveUpdateRate_25(HandleRef pThis, double _arg);

		public virtual void SetInteractiveUpdateRate(double _arg)
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_SetInteractiveUpdateRate_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkSmartVolumeMapper_SetInterpolationMode_26(HandleRef pThis, int _arg);

		public virtual void SetInterpolationMode(int _arg)
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_SetInterpolationMode_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkSmartVolumeMapper_SetInterpolationModeToCubic_27(HandleRef pThis);

		public void SetInterpolationModeToCubic()
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_SetInterpolationModeToCubic_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkSmartVolumeMapper_SetInterpolationModeToLinear_28(HandleRef pThis);

		public void SetInterpolationModeToLinear()
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_SetInterpolationModeToLinear_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkSmartVolumeMapper_SetInterpolationModeToNearestNeighbor_29(HandleRef pThis);

		public void SetInterpolationModeToNearestNeighbor()
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_SetInterpolationModeToNearestNeighbor_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkSmartVolumeMapper_SetMaxMemoryFraction_30(HandleRef pThis, float _arg);

		public virtual void SetMaxMemoryFraction(float _arg)
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_SetMaxMemoryFraction_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkSmartVolumeMapper_SetMaxMemoryInBytes_31(HandleRef pThis, long _arg);

		public virtual void SetMaxMemoryInBytes(long _arg)
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_SetMaxMemoryInBytes_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkSmartVolumeMapper_SetRequestedRenderMode_32(HandleRef pThis, int mode);

		public void SetRequestedRenderMode(int mode)
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_SetRequestedRenderMode_32(base.GetCppThis(), mode);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkSmartVolumeMapper_SetRequestedRenderModeToDefault_33(HandleRef pThis);

		public void SetRequestedRenderModeToDefault()
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_SetRequestedRenderModeToDefault_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkSmartVolumeMapper_SetRequestedRenderModeToRayCast_34(HandleRef pThis);

		public void SetRequestedRenderModeToRayCast()
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_SetRequestedRenderModeToRayCast_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkSmartVolumeMapper_SetRequestedRenderModeToRayCastAndTexture_35(HandleRef pThis);

		public void SetRequestedRenderModeToRayCastAndTexture()
		{
			vtkSmartVolumeMapper.vtkSmartVolumeMapper_SetRequestedRenderModeToRayCastAndTexture_35(base.GetCppThis());
		}
	}
}
