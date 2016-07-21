using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPieChartActor : vtkActor2D
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPieChartActor";

		public new static readonly string MRClassNameKey;

		static vtkPieChartActor()
		{
			vtkPieChartActor.MRClassNameKey = "class vtkPieChartActor";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPieChartActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPieChartActor"));
		}

		public vtkPieChartActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkPieChartActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPieChartActor New()
		{
			vtkPieChartActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPieChartActor.vtkPieChartActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPieChartActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPieChartActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPieChartActor.vtkPieChartActor_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkPieChartActor_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataObject GetInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPieChartActor.vtkPieChartActor_GetInput_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkPieChartActor_GetLabelTextProperty_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetLabelTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPieChartActor.vtkPieChartActor_GetLabelTextProperty_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkPieChartActor_GetLabelVisibility_03(HandleRef pThis);

		public virtual int GetLabelVisibility()
		{
			return vtkPieChartActor.vtkPieChartActor_GetLabelVisibility_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkPieChartActor_GetLegendActor_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkLegendBoxActor GetLegendActor()
		{
			vtkLegendBoxActor vtkLegendBoxActor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPieChartActor.vtkPieChartActor_GetLegendActor_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkPieChartActor_GetLegendVisibility_05(HandleRef pThis);

		public virtual int GetLegendVisibility()
		{
			return vtkPieChartActor.vtkPieChartActor_GetLegendVisibility_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkPieChartActor_GetPieceColor_06(HandleRef pThis, int i);

		public IntPtr GetPieceColor(int i)
		{
			return vtkPieChartActor.vtkPieChartActor_GetPieceColor_06(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkPieChartActor_GetPieceLabel_07(HandleRef pThis, int i);

		public string GetPieceLabel(int i)
		{
			return Marshal.PtrToStringAnsi(vtkPieChartActor.vtkPieChartActor_GetPieceLabel_07(base.GetCppThis(), i));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkPieChartActor_GetTitle_08(HandleRef pThis);

		public virtual string GetTitle()
		{
			return Marshal.PtrToStringAnsi(vtkPieChartActor.vtkPieChartActor_GetTitle_08(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkPieChartActor_GetTitleTextProperty_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetTitleTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPieChartActor.vtkPieChartActor_GetTitleTextProperty_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkPieChartActor_GetTitleVisibility_10(HandleRef pThis);

		public virtual int GetTitleVisibility()
		{
			return vtkPieChartActor.vtkPieChartActor_GetTitleVisibility_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkPieChartActor_HasTranslucentPolygonalGeometry_11(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkPieChartActor.vtkPieChartActor_HasTranslucentPolygonalGeometry_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkPieChartActor_IsA_12(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPieChartActor.vtkPieChartActor_IsA_12(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkPieChartActor_IsTypeOf_13(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPieChartActor.vtkPieChartActor_IsTypeOf_13(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPieChartActor_LabelVisibilityOff_14(HandleRef pThis);

		public virtual void LabelVisibilityOff()
		{
			vtkPieChartActor.vtkPieChartActor_LabelVisibilityOff_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPieChartActor_LabelVisibilityOn_15(HandleRef pThis);

		public virtual void LabelVisibilityOn()
		{
			vtkPieChartActor.vtkPieChartActor_LabelVisibilityOn_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPieChartActor_LegendVisibilityOff_16(HandleRef pThis);

		public virtual void LegendVisibilityOff()
		{
			vtkPieChartActor.vtkPieChartActor_LegendVisibilityOff_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPieChartActor_LegendVisibilityOn_17(HandleRef pThis);

		public virtual void LegendVisibilityOn()
		{
			vtkPieChartActor.vtkPieChartActor_LegendVisibilityOn_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkPieChartActor_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPieChartActor NewInstance()
		{
			vtkPieChartActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPieChartActor.vtkPieChartActor_NewInstance_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPieChartActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPieChartActor_ReleaseGraphicsResources_20(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkPieChartActor.vtkPieChartActor_ReleaseGraphicsResources_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkPieChartActor_RenderOpaqueGeometry_21(HandleRef pThis, HandleRef arg0);

		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkPieChartActor.vtkPieChartActor_RenderOpaqueGeometry_21(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkPieChartActor_RenderOverlay_22(HandleRef pThis, HandleRef arg0);

		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkPieChartActor.vtkPieChartActor_RenderOverlay_22(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkPieChartActor_RenderTranslucentPolygonalGeometry_23(HandleRef pThis, HandleRef arg0);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkPieChartActor.vtkPieChartActor_RenderTranslucentPolygonalGeometry_23(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkPieChartActor_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPieChartActor SafeDownCast(vtkObjectBase o)
		{
			vtkPieChartActor vtkPieChartActor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPieChartActor.vtkPieChartActor_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPieChartActor = (vtkPieChartActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPieChartActor.Register(null);
				}
			}
			return vtkPieChartActor;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPieChartActor_SetInput_25(HandleRef pThis, HandleRef arg0);

		public virtual void SetInput(vtkDataObject arg0)
		{
			vtkPieChartActor.vtkPieChartActor_SetInput_25(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPieChartActor_SetLabelTextProperty_26(HandleRef pThis, HandleRef p);

		public virtual void SetLabelTextProperty(vtkTextProperty p)
		{
			vtkPieChartActor.vtkPieChartActor_SetLabelTextProperty_26(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPieChartActor_SetLabelVisibility_27(HandleRef pThis, int _arg);

		public virtual void SetLabelVisibility(int _arg)
		{
			vtkPieChartActor.vtkPieChartActor_SetLabelVisibility_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPieChartActor_SetLegendVisibility_28(HandleRef pThis, int _arg);

		public virtual void SetLegendVisibility(int _arg)
		{
			vtkPieChartActor.vtkPieChartActor_SetLegendVisibility_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPieChartActor_SetPieceColor_29(HandleRef pThis, int i, double r, double g, double b);

		public void SetPieceColor(int i, double r, double g, double b)
		{
			vtkPieChartActor.vtkPieChartActor_SetPieceColor_29(base.GetCppThis(), i, r, g, b);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPieChartActor_SetPieceColor_30(HandleRef pThis, int i, IntPtr color);

		public void SetPieceColor(int i, IntPtr color)
		{
			vtkPieChartActor.vtkPieChartActor_SetPieceColor_30(base.GetCppThis(), i, color);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPieChartActor_SetPieceLabel_31(HandleRef pThis, int i, string arg1);

		public void SetPieceLabel(int i, string arg1)
		{
			vtkPieChartActor.vtkPieChartActor_SetPieceLabel_31(base.GetCppThis(), i, arg1);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPieChartActor_SetTitle_32(HandleRef pThis, string _arg);

		public virtual void SetTitle(string _arg)
		{
			vtkPieChartActor.vtkPieChartActor_SetTitle_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPieChartActor_SetTitleTextProperty_33(HandleRef pThis, HandleRef p);

		public virtual void SetTitleTextProperty(vtkTextProperty p)
		{
			vtkPieChartActor.vtkPieChartActor_SetTitleTextProperty_33(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPieChartActor_SetTitleVisibility_34(HandleRef pThis, int _arg);

		public virtual void SetTitleVisibility(int _arg)
		{
			vtkPieChartActor.vtkPieChartActor_SetTitleVisibility_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPieChartActor_TitleVisibilityOff_35(HandleRef pThis);

		public virtual void TitleVisibilityOff()
		{
			vtkPieChartActor.vtkPieChartActor_TitleVisibilityOff_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPieChartActor_TitleVisibilityOn_36(HandleRef pThis);

		public virtual void TitleVisibilityOn()
		{
			vtkPieChartActor.vtkPieChartActor_TitleVisibilityOn_36(base.GetCppThis());
		}
	}
}
