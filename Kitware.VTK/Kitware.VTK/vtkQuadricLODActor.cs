using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkQuadricLODActor : vtkActor
	{
		public enum DataConfigurationEnum
		{
			UNKNOWN,
			XLINE,
			XYPLANE = 4,
			XYZVOLUME = 7,
			XZPLANE = 5,
			YLINE = 2,
			YZPLANE = 6,
			ZLINE = 3
		}

		public enum PropTypeEnum
		{
			ACTOR = 1,
			FOLLOWER = 0
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkQuadricLODActor";

		public new static readonly string MRClassNameKey;

		static vtkQuadricLODActor()
		{
			vtkQuadricLODActor.MRClassNameKey = "class vtkQuadricLODActor";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkQuadricLODActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkQuadricLODActor"));
		}

		public vtkQuadricLODActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadricLODActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkQuadricLODActor New()
		{
			vtkQuadricLODActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuadricLODActor.vtkQuadricLODActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadricLODActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkQuadricLODActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkQuadricLODActor.vtkQuadricLODActor_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkQuadricLODActor_DeferLODConstructionOff_01(HandleRef pThis);

		public virtual void DeferLODConstructionOff()
		{
			vtkQuadricLODActor.vtkQuadricLODActor_DeferLODConstructionOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkQuadricLODActor_DeferLODConstructionOn_02(HandleRef pThis);

		public virtual void DeferLODConstructionOn()
		{
			vtkQuadricLODActor.vtkQuadricLODActor_DeferLODConstructionOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadricLODActor_GetCamera_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCamera GetCamera()
		{
			vtkCamera vtkCamera = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuadricLODActor.vtkQuadricLODActor_GetCamera_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCamera = (vtkCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCamera.Register(null);
				}
			}
			return vtkCamera;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkQuadricLODActor_GetCollapseDimensionRatio_04(HandleRef pThis);

		public virtual double GetCollapseDimensionRatio()
		{
			return vtkQuadricLODActor.vtkQuadricLODActor_GetCollapseDimensionRatio_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkQuadricLODActor_GetCollapseDimensionRatioMaxValue_05(HandleRef pThis);

		public virtual double GetCollapseDimensionRatioMaxValue()
		{
			return vtkQuadricLODActor.vtkQuadricLODActor_GetCollapseDimensionRatioMaxValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkQuadricLODActor_GetCollapseDimensionRatioMinValue_06(HandleRef pThis);

		public virtual double GetCollapseDimensionRatioMinValue()
		{
			return vtkQuadricLODActor.vtkQuadricLODActor_GetCollapseDimensionRatioMinValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkQuadricLODActor_GetDataConfiguration_07(HandleRef pThis);

		public virtual int GetDataConfiguration()
		{
			return vtkQuadricLODActor.vtkQuadricLODActor_GetDataConfiguration_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkQuadricLODActor_GetDataConfigurationMaxValue_08(HandleRef pThis);

		public virtual int GetDataConfigurationMaxValue()
		{
			return vtkQuadricLODActor.vtkQuadricLODActor_GetDataConfigurationMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkQuadricLODActor_GetDataConfigurationMinValue_09(HandleRef pThis);

		public virtual int GetDataConfigurationMinValue()
		{
			return vtkQuadricLODActor.vtkQuadricLODActor_GetDataConfigurationMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkQuadricLODActor_GetDeferLODConstruction_10(HandleRef pThis);

		public virtual int GetDeferLODConstruction()
		{
			return vtkQuadricLODActor.vtkQuadricLODActor_GetDeferLODConstruction_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadricLODActor_GetLODFilter_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkQuadricClustering GetLODFilter()
		{
			vtkQuadricClustering vtkQuadricClustering = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuadricLODActor.vtkQuadricLODActor_GetLODFilter_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkQuadricClustering = (vtkQuadricClustering)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkQuadricClustering.Register(null);
				}
			}
			return vtkQuadricClustering;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkQuadricLODActor_GetMaximumDisplayListSize_12(HandleRef pThis);

		public virtual int GetMaximumDisplayListSize()
		{
			return vtkQuadricLODActor.vtkQuadricLODActor_GetMaximumDisplayListSize_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkQuadricLODActor_GetMaximumDisplayListSizeMaxValue_13(HandleRef pThis);

		public virtual int GetMaximumDisplayListSizeMaxValue()
		{
			return vtkQuadricLODActor.vtkQuadricLODActor_GetMaximumDisplayListSizeMaxValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkQuadricLODActor_GetMaximumDisplayListSizeMinValue_14(HandleRef pThis);

		public virtual int GetMaximumDisplayListSizeMinValue()
		{
			return vtkQuadricLODActor.vtkQuadricLODActor_GetMaximumDisplayListSizeMinValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkQuadricLODActor_GetPropType_15(HandleRef pThis);

		public virtual int GetPropType()
		{
			return vtkQuadricLODActor.vtkQuadricLODActor_GetPropType_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkQuadricLODActor_GetPropTypeMaxValue_16(HandleRef pThis);

		public virtual int GetPropTypeMaxValue()
		{
			return vtkQuadricLODActor.vtkQuadricLODActor_GetPropTypeMaxValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkQuadricLODActor_GetPropTypeMinValue_17(HandleRef pThis);

		public virtual int GetPropTypeMinValue()
		{
			return vtkQuadricLODActor.vtkQuadricLODActor_GetPropTypeMinValue_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkQuadricLODActor_GetStatic_18(HandleRef pThis);

		public virtual int GetStatic()
		{
			return vtkQuadricLODActor.vtkQuadricLODActor_GetStatic_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkQuadricLODActor_IsA_19(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkQuadricLODActor.vtkQuadricLODActor_IsA_19(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkQuadricLODActor_IsTypeOf_20(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkQuadricLODActor.vtkQuadricLODActor_IsTypeOf_20(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadricLODActor_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkQuadricLODActor NewInstance()
		{
			vtkQuadricLODActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuadricLODActor.vtkQuadricLODActor_NewInstance_22(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadricLODActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkQuadricLODActor_ReleaseGraphicsResources_23(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkQuadricLODActor.vtkQuadricLODActor_ReleaseGraphicsResources_23(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkQuadricLODActor_Render_24(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		public override void Render(vtkRenderer arg0, vtkMapper arg1)
		{
			vtkQuadricLODActor.vtkQuadricLODActor_Render_24(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkQuadricLODActor_RenderOpaqueGeometry_25(HandleRef pThis, HandleRef viewport);

		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkQuadricLODActor.vtkQuadricLODActor_RenderOpaqueGeometry_25(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadricLODActor_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkQuadricLODActor SafeDownCast(vtkObjectBase o)
		{
			vtkQuadricLODActor vtkQuadricLODActor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuadricLODActor.vtkQuadricLODActor_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkQuadricLODActor = (vtkQuadricLODActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkQuadricLODActor.Register(null);
				}
			}
			return vtkQuadricLODActor;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkQuadricLODActor_SetCamera_27(HandleRef pThis, HandleRef arg0);

		public void SetCamera(vtkCamera arg0)
		{
			vtkQuadricLODActor.vtkQuadricLODActor_SetCamera_27(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkQuadricLODActor_SetCollapseDimensionRatio_28(HandleRef pThis, double _arg);

		public virtual void SetCollapseDimensionRatio(double _arg)
		{
			vtkQuadricLODActor.vtkQuadricLODActor_SetCollapseDimensionRatio_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkQuadricLODActor_SetDataConfiguration_29(HandleRef pThis, int _arg);

		public virtual void SetDataConfiguration(int _arg)
		{
			vtkQuadricLODActor.vtkQuadricLODActor_SetDataConfiguration_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkQuadricLODActor_SetDataConfigurationToUnknown_30(HandleRef pThis);

		public void SetDataConfigurationToUnknown()
		{
			vtkQuadricLODActor.vtkQuadricLODActor_SetDataConfigurationToUnknown_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkQuadricLODActor_SetDataConfigurationToXLine_31(HandleRef pThis);

		public void SetDataConfigurationToXLine()
		{
			vtkQuadricLODActor.vtkQuadricLODActor_SetDataConfigurationToXLine_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkQuadricLODActor_SetDataConfigurationToXYPlane_32(HandleRef pThis);

		public void SetDataConfigurationToXYPlane()
		{
			vtkQuadricLODActor.vtkQuadricLODActor_SetDataConfigurationToXYPlane_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkQuadricLODActor_SetDataConfigurationToXYZVolume_33(HandleRef pThis);

		public void SetDataConfigurationToXYZVolume()
		{
			vtkQuadricLODActor.vtkQuadricLODActor_SetDataConfigurationToXYZVolume_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkQuadricLODActor_SetDataConfigurationToXZPlane_34(HandleRef pThis);

		public void SetDataConfigurationToXZPlane()
		{
			vtkQuadricLODActor.vtkQuadricLODActor_SetDataConfigurationToXZPlane_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkQuadricLODActor_SetDataConfigurationToYLine_35(HandleRef pThis);

		public void SetDataConfigurationToYLine()
		{
			vtkQuadricLODActor.vtkQuadricLODActor_SetDataConfigurationToYLine_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkQuadricLODActor_SetDataConfigurationToYZPlane_36(HandleRef pThis);

		public void SetDataConfigurationToYZPlane()
		{
			vtkQuadricLODActor.vtkQuadricLODActor_SetDataConfigurationToYZPlane_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkQuadricLODActor_SetDataConfigurationToZLine_37(HandleRef pThis);

		public void SetDataConfigurationToZLine()
		{
			vtkQuadricLODActor.vtkQuadricLODActor_SetDataConfigurationToZLine_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkQuadricLODActor_SetDeferLODConstruction_38(HandleRef pThis, int _arg);

		public virtual void SetDeferLODConstruction(int _arg)
		{
			vtkQuadricLODActor.vtkQuadricLODActor_SetDeferLODConstruction_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkQuadricLODActor_SetLODFilter_39(HandleRef pThis, HandleRef lodFilter);

		public void SetLODFilter(vtkQuadricClustering lodFilter)
		{
			vtkQuadricLODActor.vtkQuadricLODActor_SetLODFilter_39(base.GetCppThis(), (lodFilter == null) ? default(HandleRef) : lodFilter.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkQuadricLODActor_SetMaximumDisplayListSize_40(HandleRef pThis, int _arg);

		public virtual void SetMaximumDisplayListSize(int _arg)
		{
			vtkQuadricLODActor.vtkQuadricLODActor_SetMaximumDisplayListSize_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkQuadricLODActor_SetPropType_41(HandleRef pThis, int _arg);

		public virtual void SetPropType(int _arg)
		{
			vtkQuadricLODActor.vtkQuadricLODActor_SetPropType_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkQuadricLODActor_SetPropTypeToActor_42(HandleRef pThis);

		public void SetPropTypeToActor()
		{
			vtkQuadricLODActor.vtkQuadricLODActor_SetPropTypeToActor_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkQuadricLODActor_SetPropTypeToFollower_43(HandleRef pThis);

		public void SetPropTypeToFollower()
		{
			vtkQuadricLODActor.vtkQuadricLODActor_SetPropTypeToFollower_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkQuadricLODActor_SetStatic_44(HandleRef pThis, int _arg);

		public virtual void SetStatic(int _arg)
		{
			vtkQuadricLODActor.vtkQuadricLODActor_SetStatic_44(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkQuadricLODActor_ShallowCopy_45(HandleRef pThis, HandleRef prop);

		public override void ShallowCopy(vtkProp prop)
		{
			vtkQuadricLODActor.vtkQuadricLODActor_ShallowCopy_45(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkQuadricLODActor_StaticOff_46(HandleRef pThis);

		public virtual void StaticOff()
		{
			vtkQuadricLODActor.vtkQuadricLODActor_StaticOff_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkQuadricLODActor_StaticOn_47(HandleRef pThis);

		public virtual void StaticOn()
		{
			vtkQuadricLODActor.vtkQuadricLODActor_StaticOn_47(base.GetCppThis());
		}
	}
}
