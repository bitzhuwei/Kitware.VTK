using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSpiderPlotActor : vtkActor2D
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSpiderPlotActor";

		public new static readonly string MRClassNameKey;

		static vtkSpiderPlotActor()
		{
			vtkSpiderPlotActor.MRClassNameKey = "class vtkSpiderPlotActor";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSpiderPlotActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSpiderPlotActor"));
		}

		public vtkSpiderPlotActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkSpiderPlotActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSpiderPlotActor New()
		{
			vtkSpiderPlotActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSpiderPlotActor.vtkSpiderPlotActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSpiderPlotActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSpiderPlotActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSpiderPlotActor.vtkSpiderPlotActor_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkSpiderPlotActor_GetAxisLabel_01(HandleRef pThis, int i);

		public string GetAxisLabel(int i)
		{
			return Marshal.PtrToStringAnsi(vtkSpiderPlotActor.vtkSpiderPlotActor_GetAxisLabel_01(base.GetCppThis(), i));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkSpiderPlotActor_GetAxisRange_02(HandleRef pThis, int i, IntPtr range);

		public void GetAxisRange(int i, IntPtr range)
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_GetAxisRange_02(base.GetCppThis(), i, range);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkSpiderPlotActor_GetIndependentVariables_03(HandleRef pThis);

		public virtual int GetIndependentVariables()
		{
			return vtkSpiderPlotActor.vtkSpiderPlotActor_GetIndependentVariables_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkSpiderPlotActor_GetIndependentVariablesMaxValue_04(HandleRef pThis);

		public virtual int GetIndependentVariablesMaxValue()
		{
			return vtkSpiderPlotActor.vtkSpiderPlotActor_GetIndependentVariablesMaxValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkSpiderPlotActor_GetIndependentVariablesMinValue_05(HandleRef pThis);

		public virtual int GetIndependentVariablesMinValue()
		{
			return vtkSpiderPlotActor.vtkSpiderPlotActor_GetIndependentVariablesMinValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkSpiderPlotActor_GetInput_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataObject GetInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSpiderPlotActor.vtkSpiderPlotActor_GetInput_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkSpiderPlotActor_GetLabelTextProperty_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetLabelTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSpiderPlotActor.vtkSpiderPlotActor_GetLabelTextProperty_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkSpiderPlotActor_GetLabelVisibility_08(HandleRef pThis);

		public virtual int GetLabelVisibility()
		{
			return vtkSpiderPlotActor.vtkSpiderPlotActor_GetLabelVisibility_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkSpiderPlotActor_GetLegendActor_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkLegendBoxActor GetLegendActor()
		{
			vtkLegendBoxActor vtkLegendBoxActor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSpiderPlotActor.vtkSpiderPlotActor_GetLegendActor_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLegendBoxActor = (vtkLegendBoxActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLegendBoxActor.Register(null);
				}
			}
			return vtkLegendBoxActor;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkSpiderPlotActor_GetLegendVisibility_10(HandleRef pThis);

		public virtual int GetLegendVisibility()
		{
			return vtkSpiderPlotActor.vtkSpiderPlotActor_GetLegendVisibility_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkSpiderPlotActor_GetNumberOfRings_11(HandleRef pThis);

		public virtual int GetNumberOfRings()
		{
			return vtkSpiderPlotActor.vtkSpiderPlotActor_GetNumberOfRings_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkSpiderPlotActor_GetNumberOfRingsMaxValue_12(HandleRef pThis);

		public virtual int GetNumberOfRingsMaxValue()
		{
			return vtkSpiderPlotActor.vtkSpiderPlotActor_GetNumberOfRingsMaxValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkSpiderPlotActor_GetNumberOfRingsMinValue_13(HandleRef pThis);

		public virtual int GetNumberOfRingsMinValue()
		{
			return vtkSpiderPlotActor.vtkSpiderPlotActor_GetNumberOfRingsMinValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkSpiderPlotActor_GetPlotColor_14(HandleRef pThis, int i);

		public IntPtr GetPlotColor(int i)
		{
			return vtkSpiderPlotActor.vtkSpiderPlotActor_GetPlotColor_14(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkSpiderPlotActor_GetTitle_15(HandleRef pThis);

		public virtual string GetTitle()
		{
			return Marshal.PtrToStringAnsi(vtkSpiderPlotActor.vtkSpiderPlotActor_GetTitle_15(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkSpiderPlotActor_GetTitleTextProperty_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetTitleTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSpiderPlotActor.vtkSpiderPlotActor_GetTitleTextProperty_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkSpiderPlotActor_GetTitleVisibility_17(HandleRef pThis);

		public virtual int GetTitleVisibility()
		{
			return vtkSpiderPlotActor.vtkSpiderPlotActor_GetTitleVisibility_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkSpiderPlotActor_HasTranslucentPolygonalGeometry_18(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkSpiderPlotActor.vtkSpiderPlotActor_HasTranslucentPolygonalGeometry_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkSpiderPlotActor_IsA_19(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSpiderPlotActor.vtkSpiderPlotActor_IsA_19(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkSpiderPlotActor_IsTypeOf_20(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSpiderPlotActor.vtkSpiderPlotActor_IsTypeOf_20(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkSpiderPlotActor_LabelVisibilityOff_21(HandleRef pThis);

		public virtual void LabelVisibilityOff()
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_LabelVisibilityOff_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkSpiderPlotActor_LabelVisibilityOn_22(HandleRef pThis);

		public virtual void LabelVisibilityOn()
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_LabelVisibilityOn_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkSpiderPlotActor_LegendVisibilityOff_23(HandleRef pThis);

		public virtual void LegendVisibilityOff()
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_LegendVisibilityOff_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkSpiderPlotActor_LegendVisibilityOn_24(HandleRef pThis);

		public virtual void LegendVisibilityOn()
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_LegendVisibilityOn_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkSpiderPlotActor_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSpiderPlotActor NewInstance()
		{
			vtkSpiderPlotActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSpiderPlotActor.vtkSpiderPlotActor_NewInstance_26(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSpiderPlotActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkSpiderPlotActor_ReleaseGraphicsResources_27(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_ReleaseGraphicsResources_27(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkSpiderPlotActor_RenderOpaqueGeometry_28(HandleRef pThis, HandleRef arg0);

		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkSpiderPlotActor.vtkSpiderPlotActor_RenderOpaqueGeometry_28(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkSpiderPlotActor_RenderOverlay_29(HandleRef pThis, HandleRef arg0);

		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkSpiderPlotActor.vtkSpiderPlotActor_RenderOverlay_29(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkSpiderPlotActor_RenderTranslucentPolygonalGeometry_30(HandleRef pThis, HandleRef arg0);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkSpiderPlotActor.vtkSpiderPlotActor_RenderTranslucentPolygonalGeometry_30(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkSpiderPlotActor_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSpiderPlotActor SafeDownCast(vtkObjectBase o)
		{
			vtkSpiderPlotActor vtkSpiderPlotActor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSpiderPlotActor.vtkSpiderPlotActor_SafeDownCast_31((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSpiderPlotActor = (vtkSpiderPlotActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSpiderPlotActor.Register(null);
				}
			}
			return vtkSpiderPlotActor;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkSpiderPlotActor_SetAxisLabel_32(HandleRef pThis, int i, string arg1);

		public void SetAxisLabel(int i, string arg1)
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_SetAxisLabel_32(base.GetCppThis(), i, arg1);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkSpiderPlotActor_SetAxisRange_33(HandleRef pThis, int i, double min, double max);

		public void SetAxisRange(int i, double min, double max)
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_SetAxisRange_33(base.GetCppThis(), i, min, max);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkSpiderPlotActor_SetAxisRange_34(HandleRef pThis, int i, IntPtr range);

		public void SetAxisRange(int i, IntPtr range)
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_SetAxisRange_34(base.GetCppThis(), i, range);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkSpiderPlotActor_SetIndependentVariables_35(HandleRef pThis, int _arg);

		public virtual void SetIndependentVariables(int _arg)
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_SetIndependentVariables_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkSpiderPlotActor_SetIndependentVariablesToColumns_36(HandleRef pThis);

		public void SetIndependentVariablesToColumns()
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_SetIndependentVariablesToColumns_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkSpiderPlotActor_SetIndependentVariablesToRows_37(HandleRef pThis);

		public void SetIndependentVariablesToRows()
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_SetIndependentVariablesToRows_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkSpiderPlotActor_SetInput_38(HandleRef pThis, HandleRef arg0);

		public virtual void SetInput(vtkDataObject arg0)
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_SetInput_38(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkSpiderPlotActor_SetLabelTextProperty_39(HandleRef pThis, HandleRef p);

		public virtual void SetLabelTextProperty(vtkTextProperty p)
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_SetLabelTextProperty_39(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkSpiderPlotActor_SetLabelVisibility_40(HandleRef pThis, int _arg);

		public virtual void SetLabelVisibility(int _arg)
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_SetLabelVisibility_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkSpiderPlotActor_SetLegendVisibility_41(HandleRef pThis, int _arg);

		public virtual void SetLegendVisibility(int _arg)
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_SetLegendVisibility_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkSpiderPlotActor_SetNumberOfRings_42(HandleRef pThis, int _arg);

		public virtual void SetNumberOfRings(int _arg)
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_SetNumberOfRings_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkSpiderPlotActor_SetPlotColor_43(HandleRef pThis, int i, double r, double g, double b);

		public void SetPlotColor(int i, double r, double g, double b)
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_SetPlotColor_43(base.GetCppThis(), i, r, g, b);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkSpiderPlotActor_SetPlotColor_44(HandleRef pThis, int i, IntPtr color);

		public void SetPlotColor(int i, IntPtr color)
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_SetPlotColor_44(base.GetCppThis(), i, color);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkSpiderPlotActor_SetTitle_45(HandleRef pThis, string _arg);

		public virtual void SetTitle(string _arg)
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_SetTitle_45(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkSpiderPlotActor_SetTitleTextProperty_46(HandleRef pThis, HandleRef p);

		public virtual void SetTitleTextProperty(vtkTextProperty p)
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_SetTitleTextProperty_46(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkSpiderPlotActor_SetTitleVisibility_47(HandleRef pThis, int _arg);

		public virtual void SetTitleVisibility(int _arg)
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_SetTitleVisibility_47(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkSpiderPlotActor_TitleVisibilityOff_48(HandleRef pThis);

		public virtual void TitleVisibilityOff()
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_TitleVisibilityOff_48(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkSpiderPlotActor_TitleVisibilityOn_49(HandleRef pThis);

		public virtual void TitleVisibilityOn()
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_TitleVisibilityOn_49(base.GetCppThis());
		}
	}
}
