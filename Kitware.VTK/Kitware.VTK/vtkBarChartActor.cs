using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkBarChartActor : vtkActor2D
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkBarChartActor";

		public new static readonly string MRClassNameKey;

		static vtkBarChartActor()
		{
			vtkBarChartActor.MRClassNameKey = "class vtkBarChartActor";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBarChartActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBarChartActor"));
		}

		public vtkBarChartActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkBarChartActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBarChartActor New()
		{
			vtkBarChartActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBarChartActor.vtkBarChartActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBarChartActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkBarChartActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkBarChartActor.vtkBarChartActor_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkBarChartActor_GetBarColor_01(HandleRef pThis, int i);

		public IntPtr GetBarColor(int i)
		{
			return vtkBarChartActor.vtkBarChartActor_GetBarColor_01(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkBarChartActor_GetBarLabel_02(HandleRef pThis, int i);

		public string GetBarLabel(int i)
		{
			return Marshal.PtrToStringAnsi(vtkBarChartActor.vtkBarChartActor_GetBarLabel_02(base.GetCppThis(), i));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkBarChartActor_GetInput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataObject GetInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBarChartActor.vtkBarChartActor_GetInput_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkBarChartActor_GetLabelTextProperty_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetLabelTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBarChartActor.vtkBarChartActor_GetLabelTextProperty_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkBarChartActor_GetLabelVisibility_05(HandleRef pThis);

		public virtual int GetLabelVisibility()
		{
			return vtkBarChartActor.vtkBarChartActor_GetLabelVisibility_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkBarChartActor_GetLegendActor_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkLegendBoxActor GetLegendActor()
		{
			vtkLegendBoxActor vtkLegendBoxActor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBarChartActor.vtkBarChartActor_GetLegendActor_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkBarChartActor_GetLegendVisibility_07(HandleRef pThis);

		public virtual int GetLegendVisibility()
		{
			return vtkBarChartActor.vtkBarChartActor_GetLegendVisibility_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkBarChartActor_GetTitle_08(HandleRef pThis);

		public virtual string GetTitle()
		{
			return Marshal.PtrToStringAnsi(vtkBarChartActor.vtkBarChartActor_GetTitle_08(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkBarChartActor_GetTitleTextProperty_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetTitleTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBarChartActor.vtkBarChartActor_GetTitleTextProperty_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkBarChartActor_GetTitleVisibility_10(HandleRef pThis);

		public virtual int GetTitleVisibility()
		{
			return vtkBarChartActor.vtkBarChartActor_GetTitleVisibility_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkBarChartActor_GetYTitle_11(HandleRef pThis);

		public virtual string GetYTitle()
		{
			return Marshal.PtrToStringAnsi(vtkBarChartActor.vtkBarChartActor_GetYTitle_11(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkBarChartActor_HasTranslucentPolygonalGeometry_12(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkBarChartActor.vtkBarChartActor_HasTranslucentPolygonalGeometry_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkBarChartActor_IsA_13(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBarChartActor.vtkBarChartActor_IsA_13(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkBarChartActor_IsTypeOf_14(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBarChartActor.vtkBarChartActor_IsTypeOf_14(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkBarChartActor_LabelVisibilityOff_15(HandleRef pThis);

		public virtual void LabelVisibilityOff()
		{
			vtkBarChartActor.vtkBarChartActor_LabelVisibilityOff_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkBarChartActor_LabelVisibilityOn_16(HandleRef pThis);

		public virtual void LabelVisibilityOn()
		{
			vtkBarChartActor.vtkBarChartActor_LabelVisibilityOn_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkBarChartActor_LegendVisibilityOff_17(HandleRef pThis);

		public virtual void LegendVisibilityOff()
		{
			vtkBarChartActor.vtkBarChartActor_LegendVisibilityOff_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkBarChartActor_LegendVisibilityOn_18(HandleRef pThis);

		public virtual void LegendVisibilityOn()
		{
			vtkBarChartActor.vtkBarChartActor_LegendVisibilityOn_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkBarChartActor_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBarChartActor NewInstance()
		{
			vtkBarChartActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBarChartActor.vtkBarChartActor_NewInstance_20(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBarChartActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkBarChartActor_ReleaseGraphicsResources_21(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkBarChartActor.vtkBarChartActor_ReleaseGraphicsResources_21(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkBarChartActor_RenderOpaqueGeometry_22(HandleRef pThis, HandleRef arg0);

		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkBarChartActor.vtkBarChartActor_RenderOpaqueGeometry_22(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkBarChartActor_RenderOverlay_23(HandleRef pThis, HandleRef arg0);

		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkBarChartActor.vtkBarChartActor_RenderOverlay_23(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkBarChartActor_RenderTranslucentPolygonalGeometry_24(HandleRef pThis, HandleRef arg0);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkBarChartActor.vtkBarChartActor_RenderTranslucentPolygonalGeometry_24(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkBarChartActor_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBarChartActor SafeDownCast(vtkObjectBase o)
		{
			vtkBarChartActor vtkBarChartActor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBarChartActor.vtkBarChartActor_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBarChartActor = (vtkBarChartActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBarChartActor.Register(null);
				}
			}
			return vtkBarChartActor;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkBarChartActor_SetBarColor_26(HandleRef pThis, int i, double r, double g, double b);

		public void SetBarColor(int i, double r, double g, double b)
		{
			vtkBarChartActor.vtkBarChartActor_SetBarColor_26(base.GetCppThis(), i, r, g, b);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkBarChartActor_SetBarColor_27(HandleRef pThis, int i, IntPtr color);

		public void SetBarColor(int i, IntPtr color)
		{
			vtkBarChartActor.vtkBarChartActor_SetBarColor_27(base.GetCppThis(), i, color);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkBarChartActor_SetBarLabel_28(HandleRef pThis, int i, string arg1);

		public void SetBarLabel(int i, string arg1)
		{
			vtkBarChartActor.vtkBarChartActor_SetBarLabel_28(base.GetCppThis(), i, arg1);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkBarChartActor_SetInput_29(HandleRef pThis, HandleRef arg0);

		public virtual void SetInput(vtkDataObject arg0)
		{
			vtkBarChartActor.vtkBarChartActor_SetInput_29(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkBarChartActor_SetLabelTextProperty_30(HandleRef pThis, HandleRef p);

		public virtual void SetLabelTextProperty(vtkTextProperty p)
		{
			vtkBarChartActor.vtkBarChartActor_SetLabelTextProperty_30(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkBarChartActor_SetLabelVisibility_31(HandleRef pThis, int _arg);

		public virtual void SetLabelVisibility(int _arg)
		{
			vtkBarChartActor.vtkBarChartActor_SetLabelVisibility_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkBarChartActor_SetLegendVisibility_32(HandleRef pThis, int _arg);

		public virtual void SetLegendVisibility(int _arg)
		{
			vtkBarChartActor.vtkBarChartActor_SetLegendVisibility_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkBarChartActor_SetTitle_33(HandleRef pThis, string _arg);

		public virtual void SetTitle(string _arg)
		{
			vtkBarChartActor.vtkBarChartActor_SetTitle_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkBarChartActor_SetTitleTextProperty_34(HandleRef pThis, HandleRef p);

		public virtual void SetTitleTextProperty(vtkTextProperty p)
		{
			vtkBarChartActor.vtkBarChartActor_SetTitleTextProperty_34(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkBarChartActor_SetTitleVisibility_35(HandleRef pThis, int _arg);

		public virtual void SetTitleVisibility(int _arg)
		{
			vtkBarChartActor.vtkBarChartActor_SetTitleVisibility_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkBarChartActor_SetYTitle_36(HandleRef pThis, string _arg);

		public virtual void SetYTitle(string _arg)
		{
			vtkBarChartActor.vtkBarChartActor_SetYTitle_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkBarChartActor_TitleVisibilityOff_37(HandleRef pThis);

		public virtual void TitleVisibilityOff()
		{
			vtkBarChartActor.vtkBarChartActor_TitleVisibilityOff_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkBarChartActor_TitleVisibilityOn_38(HandleRef pThis);

		public virtual void TitleVisibilityOn()
		{
			vtkBarChartActor.vtkBarChartActor_TitleVisibilityOn_38(base.GetCppThis());
		}
	}
}
