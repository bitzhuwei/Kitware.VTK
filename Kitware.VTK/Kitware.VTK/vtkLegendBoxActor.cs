using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkLegendBoxActor : vtkActor2D
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkLegendBoxActor";

		public new static readonly string MRClassNameKey;

		static vtkLegendBoxActor()
		{
			vtkLegendBoxActor.MRClassNameKey = "class vtkLegendBoxActor";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLegendBoxActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLegendBoxActor"));
		}

		public vtkLegendBoxActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLegendBoxActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLegendBoxActor New()
		{
			vtkLegendBoxActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLegendBoxActor.vtkLegendBoxActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLegendBoxActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkLegendBoxActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkLegendBoxActor.vtkLegendBoxActor_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendBoxActor_BorderOff_01(HandleRef pThis);

		public virtual void BorderOff()
		{
			vtkLegendBoxActor.vtkLegendBoxActor_BorderOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendBoxActor_BorderOn_02(HandleRef pThis);

		public virtual void BorderOn()
		{
			vtkLegendBoxActor.vtkLegendBoxActor_BorderOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendBoxActor_BoxOff_03(HandleRef pThis);

		public virtual void BoxOff()
		{
			vtkLegendBoxActor.vtkLegendBoxActor_BoxOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendBoxActor_BoxOn_04(HandleRef pThis);

		public virtual void BoxOn()
		{
			vtkLegendBoxActor.vtkLegendBoxActor_BoxOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLegendBoxActor_GetBackgroundColor_05(HandleRef pThis);

		public virtual double[] GetBackgroundColor()
		{
			IntPtr intPtr = vtkLegendBoxActor.vtkLegendBoxActor_GetBackgroundColor_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendBoxActor_GetBackgroundColor_06(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetBackgroundColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_GetBackgroundColor_06(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendBoxActor_GetBackgroundColor_07(HandleRef pThis, IntPtr _arg);

		public virtual void GetBackgroundColor(IntPtr _arg)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_GetBackgroundColor_07(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkLegendBoxActor_GetBackgroundOpacity_08(HandleRef pThis);

		public virtual double GetBackgroundOpacity()
		{
			return vtkLegendBoxActor.vtkLegendBoxActor_GetBackgroundOpacity_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkLegendBoxActor_GetBackgroundOpacityMaxValue_09(HandleRef pThis);

		public virtual double GetBackgroundOpacityMaxValue()
		{
			return vtkLegendBoxActor.vtkLegendBoxActor_GetBackgroundOpacityMaxValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkLegendBoxActor_GetBackgroundOpacityMinValue_10(HandleRef pThis);

		public virtual double GetBackgroundOpacityMinValue()
		{
			return vtkLegendBoxActor.vtkLegendBoxActor_GetBackgroundOpacityMinValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLegendBoxActor_GetBorder_11(HandleRef pThis);

		public virtual int GetBorder()
		{
			return vtkLegendBoxActor.vtkLegendBoxActor_GetBorder_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLegendBoxActor_GetBox_12(HandleRef pThis);

		public virtual int GetBox()
		{
			return vtkLegendBoxActor.vtkLegendBoxActor_GetBox_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLegendBoxActor_GetBoxProperty_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkProperty2D GetBoxProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLegendBoxActor.vtkLegendBoxActor_GetBoxProperty_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty2D = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty2D.Register(null);
				}
			}
			return vtkProperty2D;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLegendBoxActor_GetEntryColor_14(HandleRef pThis, int i);

		public double[] GetEntryColor(int i)
		{
			IntPtr intPtr = vtkLegendBoxActor.vtkLegendBoxActor_GetEntryColor_14(base.GetCppThis(), i);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLegendBoxActor_GetEntryIcon_15(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkImageData GetEntryIcon(int i)
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLegendBoxActor.vtkLegendBoxActor_GetEntryIcon_15(base.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLegendBoxActor_GetEntryString_16(HandleRef pThis, int i);

		public string GetEntryString(int i)
		{
			return Marshal.PtrToStringAnsi(vtkLegendBoxActor.vtkLegendBoxActor_GetEntryString_16(base.GetCppThis(), i));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLegendBoxActor_GetEntrySymbol_17(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolyData GetEntrySymbol(int i)
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLegendBoxActor.vtkLegendBoxActor_GetEntrySymbol_17(base.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLegendBoxActor_GetEntryTextProperty_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetEntryTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLegendBoxActor.vtkLegendBoxActor_GetEntryTextProperty_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkLegendBoxActor_GetLockBorder_19(HandleRef pThis);

		public virtual int GetLockBorder()
		{
			return vtkLegendBoxActor.vtkLegendBoxActor_GetLockBorder_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLegendBoxActor_GetNumberOfEntries_20(HandleRef pThis);

		public int GetNumberOfEntries()
		{
			return vtkLegendBoxActor.vtkLegendBoxActor_GetNumberOfEntries_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLegendBoxActor_GetPadding_21(HandleRef pThis);

		public virtual int GetPadding()
		{
			return vtkLegendBoxActor.vtkLegendBoxActor_GetPadding_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLegendBoxActor_GetPaddingMaxValue_22(HandleRef pThis);

		public virtual int GetPaddingMaxValue()
		{
			return vtkLegendBoxActor.vtkLegendBoxActor_GetPaddingMaxValue_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLegendBoxActor_GetPaddingMinValue_23(HandleRef pThis);

		public virtual int GetPaddingMinValue()
		{
			return vtkLegendBoxActor.vtkLegendBoxActor_GetPaddingMinValue_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLegendBoxActor_GetScalarVisibility_24(HandleRef pThis);

		public virtual int GetScalarVisibility()
		{
			return vtkLegendBoxActor.vtkLegendBoxActor_GetScalarVisibility_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLegendBoxActor_GetUseBackground_25(HandleRef pThis);

		public virtual int GetUseBackground()
		{
			return vtkLegendBoxActor.vtkLegendBoxActor_GetUseBackground_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLegendBoxActor_HasTranslucentPolygonalGeometry_26(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkLegendBoxActor.vtkLegendBoxActor_HasTranslucentPolygonalGeometry_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLegendBoxActor_IsA_27(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkLegendBoxActor.vtkLegendBoxActor_IsA_27(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLegendBoxActor_IsTypeOf_28(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkLegendBoxActor.vtkLegendBoxActor_IsTypeOf_28(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendBoxActor_LockBorderOff_29(HandleRef pThis);

		public virtual void LockBorderOff()
		{
			vtkLegendBoxActor.vtkLegendBoxActor_LockBorderOff_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendBoxActor_LockBorderOn_30(HandleRef pThis);

		public virtual void LockBorderOn()
		{
			vtkLegendBoxActor.vtkLegendBoxActor_LockBorderOn_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLegendBoxActor_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkLegendBoxActor NewInstance()
		{
			vtkLegendBoxActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLegendBoxActor.vtkLegendBoxActor_NewInstance_32(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLegendBoxActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendBoxActor_ReleaseGraphicsResources_33(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_ReleaseGraphicsResources_33(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLegendBoxActor_RenderOpaqueGeometry_34(HandleRef pThis, HandleRef viewport);

		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkLegendBoxActor.vtkLegendBoxActor_RenderOpaqueGeometry_34(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLegendBoxActor_RenderOverlay_35(HandleRef pThis, HandleRef viewport);

		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkLegendBoxActor.vtkLegendBoxActor_RenderOverlay_35(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLegendBoxActor_RenderTranslucentPolygonalGeometry_36(HandleRef pThis, HandleRef arg0);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkLegendBoxActor.vtkLegendBoxActor_RenderTranslucentPolygonalGeometry_36(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLegendBoxActor_SafeDownCast_37(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLegendBoxActor SafeDownCast(vtkObjectBase o)
		{
			vtkLegendBoxActor vtkLegendBoxActor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLegendBoxActor.vtkLegendBoxActor_SafeDownCast_37((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkLegendBoxActor_ScalarVisibilityOff_38(HandleRef pThis);

		public virtual void ScalarVisibilityOff()
		{
			vtkLegendBoxActor.vtkLegendBoxActor_ScalarVisibilityOff_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendBoxActor_ScalarVisibilityOn_39(HandleRef pThis);

		public virtual void ScalarVisibilityOn()
		{
			vtkLegendBoxActor.vtkLegendBoxActor_ScalarVisibilityOn_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendBoxActor_SetBackgroundColor_40(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetBackgroundColor(double _arg1, double _arg2, double _arg3)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_SetBackgroundColor_40(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendBoxActor_SetBackgroundColor_41(HandleRef pThis, IntPtr _arg);

		public virtual void SetBackgroundColor(IntPtr _arg)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_SetBackgroundColor_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendBoxActor_SetBackgroundOpacity_42(HandleRef pThis, double _arg);

		public virtual void SetBackgroundOpacity(double _arg)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_SetBackgroundOpacity_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendBoxActor_SetBorder_43(HandleRef pThis, int _arg);

		public virtual void SetBorder(int _arg)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_SetBorder_43(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendBoxActor_SetBox_44(HandleRef pThis, int _arg);

		public virtual void SetBox(int _arg)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_SetBox_44(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendBoxActor_SetEntry_45(HandleRef pThis, int i, HandleRef symbol, string arg2, IntPtr color);

		public void SetEntry(int i, vtkPolyData symbol, string arg2, IntPtr color)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_SetEntry_45(base.GetCppThis(), i, (symbol == null) ? default(HandleRef) : symbol.GetCppThis(), arg2, color);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendBoxActor_SetEntry_46(HandleRef pThis, int i, HandleRef symbol, string arg2, IntPtr color);

		public void SetEntry(int i, vtkImageData symbol, string arg2, IntPtr color)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_SetEntry_46(base.GetCppThis(), i, (symbol == null) ? default(HandleRef) : symbol.GetCppThis(), arg2, color);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendBoxActor_SetEntry_47(HandleRef pThis, int i, HandleRef symbol, HandleRef icon, string arg3, IntPtr color);

		public void SetEntry(int i, vtkPolyData symbol, vtkImageData icon, string arg3, IntPtr color)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_SetEntry_47(base.GetCppThis(), i, (symbol == null) ? default(HandleRef) : symbol.GetCppThis(), (icon == null) ? default(HandleRef) : icon.GetCppThis(), arg3, color);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendBoxActor_SetEntryColor_48(HandleRef pThis, int i, IntPtr color);

		public void SetEntryColor(int i, IntPtr color)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_SetEntryColor_48(base.GetCppThis(), i, color);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendBoxActor_SetEntryColor_49(HandleRef pThis, int i, double r, double g, double b);

		public void SetEntryColor(int i, double r, double g, double b)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_SetEntryColor_49(base.GetCppThis(), i, r, g, b);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendBoxActor_SetEntryIcon_50(HandleRef pThis, int i, HandleRef icon);

		public void SetEntryIcon(int i, vtkImageData icon)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_SetEntryIcon_50(base.GetCppThis(), i, (icon == null) ? default(HandleRef) : icon.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendBoxActor_SetEntryString_51(HandleRef pThis, int i, string arg1);

		public void SetEntryString(int i, string arg1)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_SetEntryString_51(base.GetCppThis(), i, arg1);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendBoxActor_SetEntrySymbol_52(HandleRef pThis, int i, HandleRef symbol);

		public void SetEntrySymbol(int i, vtkPolyData symbol)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_SetEntrySymbol_52(base.GetCppThis(), i, (symbol == null) ? default(HandleRef) : symbol.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendBoxActor_SetEntryTextProperty_53(HandleRef pThis, HandleRef p);

		public virtual void SetEntryTextProperty(vtkTextProperty p)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_SetEntryTextProperty_53(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendBoxActor_SetLockBorder_54(HandleRef pThis, int _arg);

		public virtual void SetLockBorder(int _arg)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_SetLockBorder_54(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendBoxActor_SetNumberOfEntries_55(HandleRef pThis, int num);

		public void SetNumberOfEntries(int num)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_SetNumberOfEntries_55(base.GetCppThis(), num);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendBoxActor_SetPadding_56(HandleRef pThis, int _arg);

		public virtual void SetPadding(int _arg)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_SetPadding_56(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendBoxActor_SetScalarVisibility_57(HandleRef pThis, int _arg);

		public virtual void SetScalarVisibility(int _arg)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_SetScalarVisibility_57(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendBoxActor_SetUseBackground_58(HandleRef pThis, int _arg);

		public virtual void SetUseBackground(int _arg)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_SetUseBackground_58(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendBoxActor_ShallowCopy_59(HandleRef pThis, HandleRef prop);

		public override void ShallowCopy(vtkProp prop)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_ShallowCopy_59(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendBoxActor_UseBackgroundOff_60(HandleRef pThis);

		public virtual void UseBackgroundOff()
		{
			vtkLegendBoxActor.vtkLegendBoxActor_UseBackgroundOff_60(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendBoxActor_UseBackgroundOn_61(HandleRef pThis);

		public virtual void UseBackgroundOn()
		{
			vtkLegendBoxActor.vtkLegendBoxActor_UseBackgroundOn_61(base.GetCppThis());
		}
	}
}
