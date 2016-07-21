using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkVolume : vtkProp3D
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkVolume";

		public new static readonly string MRClassNameKey;

		static vtkVolume()
		{
			vtkVolume.MRClassNameKey = "class vtkVolume";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVolume.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolume"));
		}

		public vtkVolume(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolume_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVolume New()
		{
			vtkVolume result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolume.vtkVolume_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolume)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkVolume() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkVolume.vtkVolume_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern float vtkVolume_GetArraySize_01(HandleRef pThis);

		public float GetArraySize()
		{
			return vtkVolume.vtkVolume_GetArraySize_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolume_GetBounds_02(HandleRef pThis);

		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkVolume.vtkVolume_GetBounds_02(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolume_GetBounds_03(HandleRef pThis, IntPtr bounds);

		public new void GetBounds(IntPtr bounds)
		{
			vtkVolume.vtkVolume_GetBounds_03(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolume_GetCorrectedScalarOpacityArray_04(HandleRef pThis, int arg0);

		public IntPtr GetCorrectedScalarOpacityArray(int arg0)
		{
			return vtkVolume.vtkVolume_GetCorrectedScalarOpacityArray_04(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolume_GetCorrectedScalarOpacityArray_05(HandleRef pThis);

		public IntPtr GetCorrectedScalarOpacityArray()
		{
			return vtkVolume.vtkVolume_GetCorrectedScalarOpacityArray_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolume_GetGradientOpacityArray_06(HandleRef pThis, int arg0);

		public IntPtr GetGradientOpacityArray(int arg0)
		{
			return vtkVolume.vtkVolume_GetGradientOpacityArray_06(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolume_GetGradientOpacityArray_07(HandleRef pThis);

		public IntPtr GetGradientOpacityArray()
		{
			return vtkVolume.vtkVolume_GetGradientOpacityArray_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern float vtkVolume_GetGradientOpacityConstant_08(HandleRef pThis, int arg0);

		public float GetGradientOpacityConstant(int arg0)
		{
			return vtkVolume.vtkVolume_GetGradientOpacityConstant_08(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern float vtkVolume_GetGradientOpacityConstant_09(HandleRef pThis);

		public float GetGradientOpacityConstant()
		{
			return vtkVolume.vtkVolume_GetGradientOpacityConstant_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolume_GetGrayArray_10(HandleRef pThis, int arg0);

		public IntPtr GetGrayArray(int arg0)
		{
			return vtkVolume.vtkVolume_GetGrayArray_10(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolume_GetGrayArray_11(HandleRef pThis);

		public IntPtr GetGrayArray()
		{
			return vtkVolume.vtkVolume_GetGrayArray_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkVolume_GetMTime_12(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkVolume.vtkVolume_GetMTime_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolume_GetMapper_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAbstractVolumeMapper GetMapper()
		{
			vtkAbstractVolumeMapper vtkAbstractVolumeMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolume.vtkVolume_GetMapper_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractVolumeMapper = (vtkAbstractVolumeMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractVolumeMapper.Register(null);
				}
			}
			return vtkAbstractVolumeMapper;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkVolume_GetMaxXBound_14(HandleRef pThis);

		public double GetMaxXBound()
		{
			return vtkVolume.vtkVolume_GetMaxXBound_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkVolume_GetMaxYBound_15(HandleRef pThis);

		public double GetMaxYBound()
		{
			return vtkVolume.vtkVolume_GetMaxYBound_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkVolume_GetMaxZBound_16(HandleRef pThis);

		public double GetMaxZBound()
		{
			return vtkVolume.vtkVolume_GetMaxZBound_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkVolume_GetMinXBound_17(HandleRef pThis);

		public double GetMinXBound()
		{
			return vtkVolume.vtkVolume_GetMinXBound_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkVolume_GetMinYBound_18(HandleRef pThis);

		public double GetMinYBound()
		{
			return vtkVolume.vtkVolume_GetMinYBound_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkVolume_GetMinZBound_19(HandleRef pThis);

		public double GetMinZBound()
		{
			return vtkVolume.vtkVolume_GetMinZBound_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolume_GetProperty_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkVolumeProperty GetProperty()
		{
			vtkVolumeProperty vtkVolumeProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolume.vtkVolume_GetProperty_20(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumeProperty = (vtkVolumeProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumeProperty.Register(null);
				}
			}
			return vtkVolumeProperty;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolume_GetRGBArray_21(HandleRef pThis, int arg0);

		public IntPtr GetRGBArray(int arg0)
		{
			return vtkVolume.vtkVolume_GetRGBArray_21(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolume_GetRGBArray_22(HandleRef pThis);

		public IntPtr GetRGBArray()
		{
			return vtkVolume.vtkVolume_GetRGBArray_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkVolume_GetRedrawMTime_23(HandleRef pThis);

		public override uint GetRedrawMTime()
		{
			return vtkVolume.vtkVolume_GetRedrawMTime_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolume_GetScalarOpacityArray_24(HandleRef pThis, int arg0);

		public IntPtr GetScalarOpacityArray(int arg0)
		{
			return vtkVolume.vtkVolume_GetScalarOpacityArray_24(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolume_GetScalarOpacityArray_25(HandleRef pThis);

		public IntPtr GetScalarOpacityArray()
		{
			return vtkVolume.vtkVolume_GetScalarOpacityArray_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolume_GetVolumes_26(HandleRef pThis, HandleRef vc);

		public override void GetVolumes(vtkPropCollection vc)
		{
			vtkVolume.vtkVolume_GetVolumes_26(base.GetCppThis(), (vc == null) ? default(HandleRef) : vc.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkVolume_IsA_27(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkVolume.vtkVolume_IsA_27(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkVolume_IsTypeOf_28(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkVolume.vtkVolume_IsTypeOf_28(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolume_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkVolume NewInstance()
		{
			vtkVolume result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolume.vtkVolume_NewInstance_30(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolume)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolume_ReleaseGraphicsResources_31(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkVolume.vtkVolume_ReleaseGraphicsResources_31(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkVolume_RenderVolumetricGeometry_32(HandleRef pThis, HandleRef viewport);

		public override int RenderVolumetricGeometry(vtkViewport viewport)
		{
			return vtkVolume.vtkVolume_RenderVolumetricGeometry_32(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolume_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVolume SafeDownCast(vtkObjectBase o)
		{
			vtkVolume vtkVolume = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolume.vtkVolume_SafeDownCast_33((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolume = (vtkVolume)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolume.Register(null);
				}
			}
			return vtkVolume;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolume_SetMapper_34(HandleRef pThis, HandleRef mapper);

		public void SetMapper(vtkAbstractVolumeMapper mapper)
		{
			vtkVolume.vtkVolume_SetMapper_34(base.GetCppThis(), (mapper == null) ? default(HandleRef) : mapper.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolume_SetProperty_35(HandleRef pThis, HandleRef property);

		public void SetProperty(vtkVolumeProperty property)
		{
			vtkVolume.vtkVolume_SetProperty_35(base.GetCppThis(), (property == null) ? default(HandleRef) : property.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolume_ShallowCopy_36(HandleRef pThis, HandleRef prop);

		public override void ShallowCopy(vtkProp prop)
		{
			vtkVolume.vtkVolume_ShallowCopy_36(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolume_Update_37(HandleRef pThis);

		public void Update()
		{
			vtkVolume.vtkVolume_Update_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolume_UpdateScalarOpacityforSampleSize_38(HandleRef pThis, HandleRef ren, float sample_distance);

		public void UpdateScalarOpacityforSampleSize(vtkRenderer ren, float sample_distance)
		{
			vtkVolume.vtkVolume_UpdateScalarOpacityforSampleSize_38(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), sample_distance);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolume_UpdateTransferFunctions_39(HandleRef pThis, HandleRef ren);

		public void UpdateTransferFunctions(vtkRenderer ren)
		{
			vtkVolume.vtkVolume_UpdateTransferFunctions_39(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}
	}
}
