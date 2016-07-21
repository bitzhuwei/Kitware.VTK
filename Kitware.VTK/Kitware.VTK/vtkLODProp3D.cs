using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkLODProp3D : vtkProp3D
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkLODProp3D";

		public new static readonly string MRClassNameKey;

		static vtkLODProp3D()
		{
			vtkLODProp3D.MRClassNameKey = "class vtkLODProp3D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLODProp3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLODProp3D"));
		}

		public vtkLODProp3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLODProp3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLODProp3D New()
		{
			vtkLODProp3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLODProp3D.vtkLODProp3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLODProp3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkLODProp3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkLODProp3D.vtkLODProp3D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLODProp3D_AddEstimatedRenderTime_01(HandleRef pThis, double t, HandleRef vp);

		public override void AddEstimatedRenderTime(double t, vtkViewport vp)
		{
			vtkLODProp3D.vtkLODProp3D_AddEstimatedRenderTime_01(base.GetCppThis(), t, (vp == null) ? default(HandleRef) : vp.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLODProp3D_AddLOD_02(HandleRef pThis, HandleRef m, HandleRef p, HandleRef back, HandleRef t, double time);

		public int AddLOD(vtkMapper m, vtkProperty p, vtkProperty back, vtkTexture t, double time)
		{
			return vtkLODProp3D.vtkLODProp3D_AddLOD_02(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis(), (back == null) ? default(HandleRef) : back.GetCppThis(), (t == null) ? default(HandleRef) : t.GetCppThis(), time);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLODProp3D_AddLOD_03(HandleRef pThis, HandleRef m, HandleRef p, HandleRef t, double time);

		public int AddLOD(vtkMapper m, vtkProperty p, vtkTexture t, double time)
		{
			return vtkLODProp3D.vtkLODProp3D_AddLOD_03(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis(), (t == null) ? default(HandleRef) : t.GetCppThis(), time);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLODProp3D_AddLOD_04(HandleRef pThis, HandleRef m, HandleRef p, HandleRef back, double time);

		public int AddLOD(vtkMapper m, vtkProperty p, vtkProperty back, double time)
		{
			return vtkLODProp3D.vtkLODProp3D_AddLOD_04(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis(), (back == null) ? default(HandleRef) : back.GetCppThis(), time);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLODProp3D_AddLOD_05(HandleRef pThis, HandleRef m, HandleRef p, double time);

		public int AddLOD(vtkMapper m, vtkProperty p, double time)
		{
			return vtkLODProp3D.vtkLODProp3D_AddLOD_05(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis(), time);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLODProp3D_AddLOD_06(HandleRef pThis, HandleRef m, HandleRef t, double time);

		public int AddLOD(vtkMapper m, vtkTexture t, double time)
		{
			return vtkLODProp3D.vtkLODProp3D_AddLOD_06(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis(), (t == null) ? default(HandleRef) : t.GetCppThis(), time);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLODProp3D_AddLOD_07(HandleRef pThis, HandleRef m, double time);

		public int AddLOD(vtkMapper m, double time)
		{
			return vtkLODProp3D.vtkLODProp3D_AddLOD_07(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis(), time);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLODProp3D_AddLOD_08(HandleRef pThis, HandleRef m, HandleRef p, double time);

		public int AddLOD(vtkAbstractVolumeMapper m, vtkVolumeProperty p, double time)
		{
			return vtkLODProp3D.vtkLODProp3D_AddLOD_08(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis(), time);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLODProp3D_AddLOD_09(HandleRef pThis, HandleRef m, double time);

		public int AddLOD(vtkAbstractVolumeMapper m, double time)
		{
			return vtkLODProp3D.vtkLODProp3D_AddLOD_09(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis(), time);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLODProp3D_AutomaticLODSelectionOff_10(HandleRef pThis);

		public virtual void AutomaticLODSelectionOff()
		{
			vtkLODProp3D.vtkLODProp3D_AutomaticLODSelectionOff_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLODProp3D_AutomaticLODSelectionOn_11(HandleRef pThis);

		public virtual void AutomaticLODSelectionOn()
		{
			vtkLODProp3D.vtkLODProp3D_AutomaticLODSelectionOn_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLODProp3D_AutomaticPickLODSelectionOff_12(HandleRef pThis);

		public virtual void AutomaticPickLODSelectionOff()
		{
			vtkLODProp3D.vtkLODProp3D_AutomaticPickLODSelectionOff_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLODProp3D_AutomaticPickLODSelectionOn_13(HandleRef pThis);

		public virtual void AutomaticPickLODSelectionOn()
		{
			vtkLODProp3D.vtkLODProp3D_AutomaticPickLODSelectionOn_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLODProp3D_DisableLOD_14(HandleRef pThis, int id);

		public void DisableLOD(int id)
		{
			vtkLODProp3D.vtkLODProp3D_DisableLOD_14(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLODProp3D_EnableLOD_15(HandleRef pThis, int id);

		public void EnableLOD(int id)
		{
			vtkLODProp3D.vtkLODProp3D_EnableLOD_15(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLODProp3D_GetActors_16(HandleRef pThis, HandleRef arg0);

		public override void GetActors(vtkPropCollection arg0)
		{
			vtkLODProp3D.vtkLODProp3D_GetActors_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLODProp3D_GetAutomaticLODSelection_17(HandleRef pThis);

		public virtual int GetAutomaticLODSelection()
		{
			return vtkLODProp3D.vtkLODProp3D_GetAutomaticLODSelection_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLODProp3D_GetAutomaticLODSelectionMaxValue_18(HandleRef pThis);

		public virtual int GetAutomaticLODSelectionMaxValue()
		{
			return vtkLODProp3D.vtkLODProp3D_GetAutomaticLODSelectionMaxValue_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLODProp3D_GetAutomaticLODSelectionMinValue_19(HandleRef pThis);

		public virtual int GetAutomaticLODSelectionMinValue()
		{
			return vtkLODProp3D.vtkLODProp3D_GetAutomaticLODSelectionMinValue_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLODProp3D_GetAutomaticPickLODSelection_20(HandleRef pThis);

		public virtual int GetAutomaticPickLODSelection()
		{
			return vtkLODProp3D.vtkLODProp3D_GetAutomaticPickLODSelection_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLODProp3D_GetAutomaticPickLODSelectionMaxValue_21(HandleRef pThis);

		public virtual int GetAutomaticPickLODSelectionMaxValue()
		{
			return vtkLODProp3D.vtkLODProp3D_GetAutomaticPickLODSelectionMaxValue_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLODProp3D_GetAutomaticPickLODSelectionMinValue_22(HandleRef pThis);

		public virtual int GetAutomaticPickLODSelectionMinValue()
		{
			return vtkLODProp3D.vtkLODProp3D_GetAutomaticPickLODSelectionMinValue_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLODProp3D_GetBounds_23(HandleRef pThis);

		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkLODProp3D.vtkLODProp3D_GetBounds_23(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLODProp3D_GetBounds_24(HandleRef pThis, IntPtr bounds);

		public new void GetBounds(IntPtr bounds)
		{
			vtkLODProp3D.vtkLODProp3D_GetBounds_24(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLODProp3D_GetCurrentIndex_25(HandleRef pThis);

		public virtual int GetCurrentIndex()
		{
			return vtkLODProp3D.vtkLODProp3D_GetCurrentIndex_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLODProp3D_GetLODEstimatedRenderTime_26(HandleRef pThis, int id);

		public double GetLODEstimatedRenderTime(int id)
		{
			return vtkLODProp3D.vtkLODProp3D_GetLODEstimatedRenderTime_26(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLODProp3D_GetLODIndexEstimatedRenderTime_27(HandleRef pThis, int index);

		public double GetLODIndexEstimatedRenderTime(int index)
		{
			return vtkLODProp3D.vtkLODProp3D_GetLODIndexEstimatedRenderTime_27(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLODProp3D_GetLODIndexLevel_28(HandleRef pThis, int index);

		public double GetLODIndexLevel(int index)
		{
			return vtkLODProp3D.vtkLODProp3D_GetLODIndexLevel_28(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLODProp3D_GetLODLevel_29(HandleRef pThis, int id);

		public double GetLODLevel(int id)
		{
			return vtkLODProp3D.vtkLODProp3D_GetLODLevel_29(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLODProp3D_GetLODMapper_30(HandleRef pThis, int id, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAbstractMapper3D GetLODMapper(int id)
		{
			vtkAbstractMapper3D vtkAbstractMapper3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLODProp3D.vtkLODProp3D_GetLODMapper_30(base.GetCppThis(), id, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractMapper3D = (vtkAbstractMapper3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractMapper3D.Register(null);
				}
			}
			return vtkAbstractMapper3D;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLODProp3D_GetLastRenderedLODID_31(HandleRef pThis);

		public int GetLastRenderedLODID()
		{
			return vtkLODProp3D.vtkLODProp3D_GetLastRenderedLODID_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLODProp3D_GetNumberOfLODs_32(HandleRef pThis);

		public virtual int GetNumberOfLODs()
		{
			return vtkLODProp3D.vtkLODProp3D_GetNumberOfLODs_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLODProp3D_GetPickLODID_33(HandleRef pThis);

		public int GetPickLODID()
		{
			return vtkLODProp3D.vtkLODProp3D_GetPickLODID_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLODProp3D_GetSelectedLODID_34(HandleRef pThis);

		public virtual int GetSelectedLODID()
		{
			return vtkLODProp3D.vtkLODProp3D_GetSelectedLODID_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLODProp3D_GetSelectedPickLODID_35(HandleRef pThis);

		public virtual int GetSelectedPickLODID()
		{
			return vtkLODProp3D.vtkLODProp3D_GetSelectedPickLODID_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLODProp3D_GetVolumes_36(HandleRef pThis, HandleRef arg0);

		public override void GetVolumes(vtkPropCollection arg0)
		{
			vtkLODProp3D.vtkLODProp3D_GetVolumes_36(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLODProp3D_HasTranslucentPolygonalGeometry_37(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkLODProp3D.vtkLODProp3D_HasTranslucentPolygonalGeometry_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLODProp3D_IsA_38(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkLODProp3D.vtkLODProp3D_IsA_38(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLODProp3D_IsLODEnabled_39(HandleRef pThis, int id);

		public int IsLODEnabled(int id)
		{
			return vtkLODProp3D.vtkLODProp3D_IsLODEnabled_39(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLODProp3D_IsTypeOf_40(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkLODProp3D.vtkLODProp3D_IsTypeOf_40(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLODProp3D_NewInstance_42(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkLODProp3D NewInstance()
		{
			vtkLODProp3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLODProp3D.vtkLODProp3D_NewInstance_42(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLODProp3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLODProp3D_ReleaseGraphicsResources_43(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkLODProp3D.vtkLODProp3D_ReleaseGraphicsResources_43(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLODProp3D_RemoveLOD_44(HandleRef pThis, int id);

		public void RemoveLOD(int id)
		{
			vtkLODProp3D.vtkLODProp3D_RemoveLOD_44(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLODProp3D_RenderOpaqueGeometry_45(HandleRef pThis, HandleRef viewport);

		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkLODProp3D.vtkLODProp3D_RenderOpaqueGeometry_45(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLODProp3D_RenderTranslucentPolygonalGeometry_46(HandleRef pThis, HandleRef ren);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport ren)
		{
			return vtkLODProp3D.vtkLODProp3D_RenderTranslucentPolygonalGeometry_46(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLODProp3D_RenderVolumetricGeometry_47(HandleRef pThis, HandleRef ren);

		public override int RenderVolumetricGeometry(vtkViewport ren)
		{
			return vtkLODProp3D.vtkLODProp3D_RenderVolumetricGeometry_47(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLODProp3D_RestoreEstimatedRenderTime_48(HandleRef pThis);

		public override void RestoreEstimatedRenderTime()
		{
			vtkLODProp3D.vtkLODProp3D_RestoreEstimatedRenderTime_48(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLODProp3D_SafeDownCast_49(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLODProp3D SafeDownCast(vtkObjectBase o)
		{
			vtkLODProp3D vtkLODProp3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLODProp3D.vtkLODProp3D_SafeDownCast_49((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLODProp3D = (vtkLODProp3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLODProp3D.Register(null);
				}
			}
			return vtkLODProp3D;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLODProp3D_SetAllocatedRenderTime_50(HandleRef pThis, double t, HandleRef vp);

		public override void SetAllocatedRenderTime(double t, vtkViewport vp)
		{
			vtkLODProp3D.vtkLODProp3D_SetAllocatedRenderTime_50(base.GetCppThis(), t, (vp == null) ? default(HandleRef) : vp.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLODProp3D_SetAutomaticLODSelection_51(HandleRef pThis, int _arg);

		public virtual void SetAutomaticLODSelection(int _arg)
		{
			vtkLODProp3D.vtkLODProp3D_SetAutomaticLODSelection_51(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLODProp3D_SetAutomaticPickLODSelection_52(HandleRef pThis, int _arg);

		public virtual void SetAutomaticPickLODSelection(int _arg)
		{
			vtkLODProp3D.vtkLODProp3D_SetAutomaticPickLODSelection_52(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLODProp3D_SetLODBackfaceProperty_53(HandleRef pThis, int id, HandleRef t);

		public void SetLODBackfaceProperty(int id, vtkProperty t)
		{
			vtkLODProp3D.vtkLODProp3D_SetLODBackfaceProperty_53(base.GetCppThis(), id, (t == null) ? default(HandleRef) : t.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLODProp3D_SetLODLevel_54(HandleRef pThis, int id, double level);

		public void SetLODLevel(int id, double level)
		{
			vtkLODProp3D.vtkLODProp3D_SetLODLevel_54(base.GetCppThis(), id, level);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLODProp3D_SetLODMapper_55(HandleRef pThis, int id, HandleRef m);

		public void SetLODMapper(int id, vtkMapper m)
		{
			vtkLODProp3D.vtkLODProp3D_SetLODMapper_55(base.GetCppThis(), id, (m == null) ? default(HandleRef) : m.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLODProp3D_SetLODMapper_56(HandleRef pThis, int id, HandleRef m);

		public void SetLODMapper(int id, vtkAbstractVolumeMapper m)
		{
			vtkLODProp3D.vtkLODProp3D_SetLODMapper_56(base.GetCppThis(), id, (m == null) ? default(HandleRef) : m.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLODProp3D_SetLODProperty_57(HandleRef pThis, int id, HandleRef p);

		public void SetLODProperty(int id, vtkProperty p)
		{
			vtkLODProp3D.vtkLODProp3D_SetLODProperty_57(base.GetCppThis(), id, (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLODProp3D_SetLODProperty_58(HandleRef pThis, int id, HandleRef p);

		public void SetLODProperty(int id, vtkVolumeProperty p)
		{
			vtkLODProp3D.vtkLODProp3D_SetLODProperty_58(base.GetCppThis(), id, (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLODProp3D_SetLODTexture_59(HandleRef pThis, int id, HandleRef t);

		public void SetLODTexture(int id, vtkTexture t)
		{
			vtkLODProp3D.vtkLODProp3D_SetLODTexture_59(base.GetCppThis(), id, (t == null) ? default(HandleRef) : t.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLODProp3D_SetSelectedLODID_60(HandleRef pThis, int _arg);

		public virtual void SetSelectedLODID(int _arg)
		{
			vtkLODProp3D.vtkLODProp3D_SetSelectedLODID_60(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLODProp3D_SetSelectedPickLODID_61(HandleRef pThis, int id);

		public void SetSelectedPickLODID(int id)
		{
			vtkLODProp3D.vtkLODProp3D_SetSelectedPickLODID_61(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLODProp3D_ShallowCopy_62(HandleRef pThis, HandleRef prop);

		public override void ShallowCopy(vtkProp prop)
		{
			vtkLODProp3D.vtkLODProp3D_ShallowCopy_62(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}
	}
}
