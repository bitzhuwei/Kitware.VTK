using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkUnstructuredGridVolumeZSweepMapper : vtkUnstructuredGridVolumeMapper
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridVolumeZSweepMapper";

		public new static readonly string MRClassNameKey;

		static vtkUnstructuredGridVolumeZSweepMapper()
		{
			vtkUnstructuredGridVolumeZSweepMapper.MRClassNameKey = "class vtkUnstructuredGridVolumeZSweepMapper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnstructuredGridVolumeZSweepMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridVolumeZSweepMapper"));
		}

		public vtkUnstructuredGridVolumeZSweepMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridVolumeZSweepMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnstructuredGridVolumeZSweepMapper New()
		{
			vtkUnstructuredGridVolumeZSweepMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridVolumeZSweepMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkUnstructuredGridVolumeZSweepMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeZSweepMapper_AutoAdjustSampleDistancesOff_01(HandleRef pThis);

		public virtual void AutoAdjustSampleDistancesOff()
		{
			vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_AutoAdjustSampleDistancesOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeZSweepMapper_AutoAdjustSampleDistancesOn_02(HandleRef pThis);

		public virtual void AutoAdjustSampleDistancesOn()
		{
			vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_AutoAdjustSampleDistancesOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridVolumeZSweepMapper_GetAutoAdjustSampleDistances_03(HandleRef pThis);

		public virtual int GetAutoAdjustSampleDistances()
		{
			return vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetAutoAdjustSampleDistances_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridVolumeZSweepMapper_GetAutoAdjustSampleDistancesMaxValue_04(HandleRef pThis);

		public virtual int GetAutoAdjustSampleDistancesMaxValue()
		{
			return vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetAutoAdjustSampleDistancesMaxValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridVolumeZSweepMapper_GetAutoAdjustSampleDistancesMinValue_05(HandleRef pThis);

		public virtual int GetAutoAdjustSampleDistancesMinValue()
		{
			return vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetAutoAdjustSampleDistancesMinValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridVolumeZSweepMapper_GetImageInUseSize_06(HandleRef pThis);

		public virtual int[] GetImageInUseSize()
		{
			IntPtr intPtr = vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetImageInUseSize_06(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeZSweepMapper_GetImageInUseSize_07(HandleRef pThis, IntPtr data);

		public virtual void GetImageInUseSize(IntPtr data)
		{
			vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetImageInUseSize_07(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridVolumeZSweepMapper_GetImageOrigin_08(HandleRef pThis);

		public virtual int[] GetImageOrigin()
		{
			IntPtr intPtr = vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetImageOrigin_08(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeZSweepMapper_GetImageOrigin_09(HandleRef pThis, IntPtr data);

		public virtual void GetImageOrigin(IntPtr data)
		{
			vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetImageOrigin_09(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkUnstructuredGridVolumeZSweepMapper_GetImageSampleDistance_10(HandleRef pThis);

		public virtual float GetImageSampleDistance()
		{
			return vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetImageSampleDistance_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkUnstructuredGridVolumeZSweepMapper_GetImageSampleDistanceMaxValue_11(HandleRef pThis);

		public virtual float GetImageSampleDistanceMaxValue()
		{
			return vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetImageSampleDistanceMaxValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkUnstructuredGridVolumeZSweepMapper_GetImageSampleDistanceMinValue_12(HandleRef pThis);

		public virtual float GetImageSampleDistanceMinValue()
		{
			return vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetImageSampleDistanceMinValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridVolumeZSweepMapper_GetImageViewportSize_13(HandleRef pThis);

		public virtual int[] GetImageViewportSize()
		{
			IntPtr intPtr = vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetImageViewportSize_13(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeZSweepMapper_GetImageViewportSize_14(HandleRef pThis, IntPtr data);

		public virtual void GetImageViewportSize(IntPtr data)
		{
			vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetImageViewportSize_14(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridVolumeZSweepMapper_GetIntermixIntersectingGeometry_15(HandleRef pThis);

		public virtual int GetIntermixIntersectingGeometry()
		{
			return vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetIntermixIntersectingGeometry_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridVolumeZSweepMapper_GetIntermixIntersectingGeometryMaxValue_16(HandleRef pThis);

		public virtual int GetIntermixIntersectingGeometryMaxValue()
		{
			return vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetIntermixIntersectingGeometryMaxValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridVolumeZSweepMapper_GetIntermixIntersectingGeometryMinValue_17(HandleRef pThis);

		public virtual int GetIntermixIntersectingGeometryMinValue()
		{
			return vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetIntermixIntersectingGeometryMinValue_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridVolumeZSweepMapper_GetMaxPixelListSize_18(HandleRef pThis);

		public int GetMaxPixelListSize()
		{
			return vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetMaxPixelListSize_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkUnstructuredGridVolumeZSweepMapper_GetMaximumImageSampleDistance_19(HandleRef pThis);

		public virtual float GetMaximumImageSampleDistance()
		{
			return vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetMaximumImageSampleDistance_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkUnstructuredGridVolumeZSweepMapper_GetMaximumImageSampleDistanceMaxValue_20(HandleRef pThis);

		public virtual float GetMaximumImageSampleDistanceMaxValue()
		{
			return vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetMaximumImageSampleDistanceMaxValue_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkUnstructuredGridVolumeZSweepMapper_GetMaximumImageSampleDistanceMinValue_21(HandleRef pThis);

		public virtual float GetMaximumImageSampleDistanceMinValue()
		{
			return vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetMaximumImageSampleDistanceMinValue_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkUnstructuredGridVolumeZSweepMapper_GetMinimumImageSampleDistance_22(HandleRef pThis);

		public virtual float GetMinimumImageSampleDistance()
		{
			return vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetMinimumImageSampleDistance_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkUnstructuredGridVolumeZSweepMapper_GetMinimumImageSampleDistanceMaxValue_23(HandleRef pThis);

		public virtual float GetMinimumImageSampleDistanceMaxValue()
		{
			return vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetMinimumImageSampleDistanceMaxValue_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkUnstructuredGridVolumeZSweepMapper_GetMinimumImageSampleDistanceMinValue_24(HandleRef pThis);

		public virtual float GetMinimumImageSampleDistanceMinValue()
		{
			return vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetMinimumImageSampleDistanceMinValue_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridVolumeZSweepMapper_GetRayIntegrator_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkUnstructuredGridVolumeRayIntegrator GetRayIntegrator()
		{
			vtkUnstructuredGridVolumeRayIntegrator vtkUnstructuredGridVolumeRayIntegrator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_GetRayIntegrator_25(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridVolumeRayIntegrator = (vtkUnstructuredGridVolumeRayIntegrator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridVolumeRayIntegrator.Register(null);
				}
			}
			return vtkUnstructuredGridVolumeRayIntegrator;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeZSweepMapper_IntermixIntersectingGeometryOff_26(HandleRef pThis);

		public virtual void IntermixIntersectingGeometryOff()
		{
			vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_IntermixIntersectingGeometryOff_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeZSweepMapper_IntermixIntersectingGeometryOn_27(HandleRef pThis);

		public virtual void IntermixIntersectingGeometryOn()
		{
			vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_IntermixIntersectingGeometryOn_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridVolumeZSweepMapper_IsA_28(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_IsA_28(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridVolumeZSweepMapper_IsTypeOf_29(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_IsTypeOf_29(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridVolumeZSweepMapper_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkUnstructuredGridVolumeZSweepMapper NewInstance()
		{
			vtkUnstructuredGridVolumeZSweepMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_NewInstance_31(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridVolumeZSweepMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeZSweepMapper_Render_32(HandleRef pThis, HandleRef ren, HandleRef vol);

		public override void Render(vtkRenderer ren, vtkVolume vol)
		{
			vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_Render_32(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridVolumeZSweepMapper_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnstructuredGridVolumeZSweepMapper SafeDownCast(vtkObjectBase o)
		{
			vtkUnstructuredGridVolumeZSweepMapper vtkUnstructuredGridVolumeZSweepMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_SafeDownCast_33((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridVolumeZSweepMapper = (vtkUnstructuredGridVolumeZSweepMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridVolumeZSweepMapper.Register(null);
				}
			}
			return vtkUnstructuredGridVolumeZSweepMapper;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeZSweepMapper_SetAutoAdjustSampleDistances_34(HandleRef pThis, int _arg);

		public virtual void SetAutoAdjustSampleDistances(int _arg)
		{
			vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_SetAutoAdjustSampleDistances_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeZSweepMapper_SetImageSampleDistance_35(HandleRef pThis, float _arg);

		public virtual void SetImageSampleDistance(float _arg)
		{
			vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_SetImageSampleDistance_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeZSweepMapper_SetIntermixIntersectingGeometry_36(HandleRef pThis, int _arg);

		public virtual void SetIntermixIntersectingGeometry(int _arg)
		{
			vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_SetIntermixIntersectingGeometry_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeZSweepMapper_SetMaxPixelListSize_37(HandleRef pThis, int size);

		public void SetMaxPixelListSize(int size)
		{
			vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_SetMaxPixelListSize_37(base.GetCppThis(), size);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeZSweepMapper_SetMaximumImageSampleDistance_38(HandleRef pThis, float _arg);

		public virtual void SetMaximumImageSampleDistance(float _arg)
		{
			vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_SetMaximumImageSampleDistance_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeZSweepMapper_SetMinimumImageSampleDistance_39(HandleRef pThis, float _arg);

		public virtual void SetMinimumImageSampleDistance(float _arg)
		{
			vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_SetMinimumImageSampleDistance_39(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeZSweepMapper_SetRayIntegrator_40(HandleRef pThis, HandleRef ri);

		public virtual void SetRayIntegrator(vtkUnstructuredGridVolumeRayIntegrator ri)
		{
			vtkUnstructuredGridVolumeZSweepMapper.vtkUnstructuredGridVolumeZSweepMapper_SetRayIntegrator_40(base.GetCppThis(), (ri == null) ? default(HandleRef) : ri.GetCppThis());
		}
	}
}
