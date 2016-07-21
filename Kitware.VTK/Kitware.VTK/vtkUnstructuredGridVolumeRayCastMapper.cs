using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkUnstructuredGridVolumeRayCastMapper : vtkUnstructuredGridVolumeMapper
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridVolumeRayCastMapper";

		public new static readonly string MRClassNameKey;

		static vtkUnstructuredGridVolumeRayCastMapper()
		{
			vtkUnstructuredGridVolumeRayCastMapper.MRClassNameKey = "class vtkUnstructuredGridVolumeRayCastMapper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnstructuredGridVolumeRayCastMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridVolumeRayCastMapper"));
		}

		public vtkUnstructuredGridVolumeRayCastMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridVolumeRayCastMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnstructuredGridVolumeRayCastMapper New()
		{
			vtkUnstructuredGridVolumeRayCastMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridVolumeRayCastMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkUnstructuredGridVolumeRayCastMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeRayCastMapper_AutoAdjustSampleDistancesOff_01(HandleRef pThis);

		public virtual void AutoAdjustSampleDistancesOff()
		{
			vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_AutoAdjustSampleDistancesOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeRayCastMapper_AutoAdjustSampleDistancesOn_02(HandleRef pThis);

		public virtual void AutoAdjustSampleDistancesOn()
		{
			vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_AutoAdjustSampleDistancesOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeRayCastMapper_CastRays_03(HandleRef pThis, int threadID, int threadCount);

		public void CastRays(int threadID, int threadCount)
		{
			vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_CastRays_03(base.GetCppThis(), threadID, threadCount);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridVolumeRayCastMapper_GetAutoAdjustSampleDistances_04(HandleRef pThis);

		public virtual int GetAutoAdjustSampleDistances()
		{
			return vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetAutoAdjustSampleDistances_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridVolumeRayCastMapper_GetAutoAdjustSampleDistancesMaxValue_05(HandleRef pThis);

		public virtual int GetAutoAdjustSampleDistancesMaxValue()
		{
			return vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetAutoAdjustSampleDistancesMaxValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridVolumeRayCastMapper_GetAutoAdjustSampleDistancesMinValue_06(HandleRef pThis);

		public virtual int GetAutoAdjustSampleDistancesMinValue()
		{
			return vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetAutoAdjustSampleDistancesMinValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridVolumeRayCastMapper_GetImageInUseSize_07(HandleRef pThis);

		public virtual int[] GetImageInUseSize()
		{
			IntPtr intPtr = vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetImageInUseSize_07(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeRayCastMapper_GetImageInUseSize_08(HandleRef pThis, IntPtr data);

		public virtual void GetImageInUseSize(IntPtr data)
		{
			vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetImageInUseSize_08(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridVolumeRayCastMapper_GetImageOrigin_09(HandleRef pThis);

		public virtual int[] GetImageOrigin()
		{
			IntPtr intPtr = vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetImageOrigin_09(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeRayCastMapper_GetImageOrigin_10(HandleRef pThis, IntPtr data);

		public virtual void GetImageOrigin(IntPtr data)
		{
			vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetImageOrigin_10(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkUnstructuredGridVolumeRayCastMapper_GetImageSampleDistance_11(HandleRef pThis);

		public virtual float GetImageSampleDistance()
		{
			return vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetImageSampleDistance_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkUnstructuredGridVolumeRayCastMapper_GetImageSampleDistanceMaxValue_12(HandleRef pThis);

		public virtual float GetImageSampleDistanceMaxValue()
		{
			return vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetImageSampleDistanceMaxValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkUnstructuredGridVolumeRayCastMapper_GetImageSampleDistanceMinValue_13(HandleRef pThis);

		public virtual float GetImageSampleDistanceMinValue()
		{
			return vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetImageSampleDistanceMinValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridVolumeRayCastMapper_GetImageViewportSize_14(HandleRef pThis);

		public virtual int[] GetImageViewportSize()
		{
			IntPtr intPtr = vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetImageViewportSize_14(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeRayCastMapper_GetImageViewportSize_15(HandleRef pThis, IntPtr data);

		public virtual void GetImageViewportSize(IntPtr data)
		{
			vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetImageViewportSize_15(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridVolumeRayCastMapper_GetIntermixIntersectingGeometry_16(HandleRef pThis);

		public virtual int GetIntermixIntersectingGeometry()
		{
			return vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetIntermixIntersectingGeometry_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridVolumeRayCastMapper_GetIntermixIntersectingGeometryMaxValue_17(HandleRef pThis);

		public virtual int GetIntermixIntersectingGeometryMaxValue()
		{
			return vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetIntermixIntersectingGeometryMaxValue_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridVolumeRayCastMapper_GetIntermixIntersectingGeometryMinValue_18(HandleRef pThis);

		public virtual int GetIntermixIntersectingGeometryMinValue()
		{
			return vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetIntermixIntersectingGeometryMinValue_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkUnstructuredGridVolumeRayCastMapper_GetMaximumImageSampleDistance_19(HandleRef pThis);

		public virtual float GetMaximumImageSampleDistance()
		{
			return vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetMaximumImageSampleDistance_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkUnstructuredGridVolumeRayCastMapper_GetMaximumImageSampleDistanceMaxValue_20(HandleRef pThis);

		public virtual float GetMaximumImageSampleDistanceMaxValue()
		{
			return vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetMaximumImageSampleDistanceMaxValue_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkUnstructuredGridVolumeRayCastMapper_GetMaximumImageSampleDistanceMinValue_21(HandleRef pThis);

		public virtual float GetMaximumImageSampleDistanceMinValue()
		{
			return vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetMaximumImageSampleDistanceMinValue_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkUnstructuredGridVolumeRayCastMapper_GetMinimumImageSampleDistance_22(HandleRef pThis);

		public virtual float GetMinimumImageSampleDistance()
		{
			return vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetMinimumImageSampleDistance_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkUnstructuredGridVolumeRayCastMapper_GetMinimumImageSampleDistanceMaxValue_23(HandleRef pThis);

		public virtual float GetMinimumImageSampleDistanceMaxValue()
		{
			return vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetMinimumImageSampleDistanceMaxValue_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkUnstructuredGridVolumeRayCastMapper_GetMinimumImageSampleDistanceMinValue_24(HandleRef pThis);

		public virtual float GetMinimumImageSampleDistanceMinValue()
		{
			return vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetMinimumImageSampleDistanceMinValue_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridVolumeRayCastMapper_GetNumberOfThreads_25(HandleRef pThis);

		public virtual int GetNumberOfThreads()
		{
			return vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetNumberOfThreads_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridVolumeRayCastMapper_GetRayCastFunction_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkUnstructuredGridVolumeRayCastFunction GetRayCastFunction()
		{
			vtkUnstructuredGridVolumeRayCastFunction vtkUnstructuredGridVolumeRayCastFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetRayCastFunction_26(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridVolumeRayCastFunction = (vtkUnstructuredGridVolumeRayCastFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridVolumeRayCastFunction.Register(null);
				}
			}
			return vtkUnstructuredGridVolumeRayCastFunction;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridVolumeRayCastMapper_GetRayIntegrator_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkUnstructuredGridVolumeRayIntegrator GetRayIntegrator()
		{
			vtkUnstructuredGridVolumeRayIntegrator vtkUnstructuredGridVolumeRayIntegrator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_GetRayIntegrator_27(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkUnstructuredGridVolumeRayCastMapper_IntermixIntersectingGeometryOff_28(HandleRef pThis);

		public virtual void IntermixIntersectingGeometryOff()
		{
			vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_IntermixIntersectingGeometryOff_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeRayCastMapper_IntermixIntersectingGeometryOn_29(HandleRef pThis);

		public virtual void IntermixIntersectingGeometryOn()
		{
			vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_IntermixIntersectingGeometryOn_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridVolumeRayCastMapper_IsA_30(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_IsA_30(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridVolumeRayCastMapper_IsTypeOf_31(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_IsTypeOf_31(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridVolumeRayCastMapper_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkUnstructuredGridVolumeRayCastMapper NewInstance()
		{
			vtkUnstructuredGridVolumeRayCastMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_NewInstance_33(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridVolumeRayCastMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeRayCastMapper_ReleaseGraphicsResources_34(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_ReleaseGraphicsResources_34(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeRayCastMapper_Render_35(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		public override void Render(vtkRenderer arg0, vtkVolume arg1)
		{
			vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_Render_35(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridVolumeRayCastMapper_SafeDownCast_36(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnstructuredGridVolumeRayCastMapper SafeDownCast(vtkObjectBase o)
		{
			vtkUnstructuredGridVolumeRayCastMapper vtkUnstructuredGridVolumeRayCastMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_SafeDownCast_36((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridVolumeRayCastMapper = (vtkUnstructuredGridVolumeRayCastMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridVolumeRayCastMapper.Register(null);
				}
			}
			return vtkUnstructuredGridVolumeRayCastMapper;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeRayCastMapper_SetAutoAdjustSampleDistances_37(HandleRef pThis, int _arg);

		public virtual void SetAutoAdjustSampleDistances(int _arg)
		{
			vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_SetAutoAdjustSampleDistances_37(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeRayCastMapper_SetImageSampleDistance_38(HandleRef pThis, float _arg);

		public virtual void SetImageSampleDistance(float _arg)
		{
			vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_SetImageSampleDistance_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeRayCastMapper_SetIntermixIntersectingGeometry_39(HandleRef pThis, int _arg);

		public virtual void SetIntermixIntersectingGeometry(int _arg)
		{
			vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_SetIntermixIntersectingGeometry_39(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeRayCastMapper_SetMaximumImageSampleDistance_40(HandleRef pThis, float _arg);

		public virtual void SetMaximumImageSampleDistance(float _arg)
		{
			vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_SetMaximumImageSampleDistance_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeRayCastMapper_SetMinimumImageSampleDistance_41(HandleRef pThis, float _arg);

		public virtual void SetMinimumImageSampleDistance(float _arg)
		{
			vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_SetMinimumImageSampleDistance_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeRayCastMapper_SetNumberOfThreads_42(HandleRef pThis, int _arg);

		public virtual void SetNumberOfThreads(int _arg)
		{
			vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_SetNumberOfThreads_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeRayCastMapper_SetRayCastFunction_43(HandleRef pThis, HandleRef f);

		public virtual void SetRayCastFunction(vtkUnstructuredGridVolumeRayCastFunction f)
		{
			vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_SetRayCastFunction_43(base.GetCppThis(), (f == null) ? default(HandleRef) : f.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeRayCastMapper_SetRayIntegrator_44(HandleRef pThis, HandleRef ri);

		public virtual void SetRayIntegrator(vtkUnstructuredGridVolumeRayIntegrator ri)
		{
			vtkUnstructuredGridVolumeRayCastMapper.vtkUnstructuredGridVolumeRayCastMapper_SetRayIntegrator_44(base.GetCppThis(), (ri == null) ? default(HandleRef) : ri.GetCppThis());
		}
	}
}
