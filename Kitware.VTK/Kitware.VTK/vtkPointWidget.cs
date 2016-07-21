using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPointWidget : vtk3DWidget
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointWidget";

		public new static readonly string MRClassNameKey;

		static vtkPointWidget()
		{
			vtkPointWidget.MRClassNameKey = "class vtkPointWidget";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointWidget"));
		}

		public vtkPointWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPointWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPointWidget New()
		{
			vtkPointWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointWidget.vtkPointWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPointWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPointWidget.vtkPointWidget_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointWidget_AllOff_01(HandleRef pThis);

		public void AllOff()
		{
			vtkPointWidget.vtkPointWidget_AllOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointWidget_AllOn_02(HandleRef pThis);

		public void AllOn()
		{
			vtkPointWidget.vtkPointWidget_AllOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkPointWidget_GetHotSpotSize_03(HandleRef pThis);

		public virtual double GetHotSpotSize()
		{
			return vtkPointWidget.vtkPointWidget_GetHotSpotSize_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkPointWidget_GetHotSpotSizeMaxValue_04(HandleRef pThis);

		public virtual double GetHotSpotSizeMaxValue()
		{
			return vtkPointWidget.vtkPointWidget_GetHotSpotSizeMaxValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkPointWidget_GetHotSpotSizeMinValue_05(HandleRef pThis);

		public virtual double GetHotSpotSizeMinValue()
		{
			return vtkPointWidget.vtkPointWidget_GetHotSpotSizeMinValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPointWidget_GetOutline_06(HandleRef pThis);

		public int GetOutline()
		{
			return vtkPointWidget.vtkPointWidget_GetOutline_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointWidget_GetPolyData_07(HandleRef pThis, HandleRef pd);

		public void GetPolyData(vtkPolyData pd)
		{
			vtkPointWidget.vtkPointWidget_GetPolyData_07(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPointWidget_GetPosition_08(HandleRef pThis);

		public double[] GetPosition()
		{
			IntPtr intPtr = vtkPointWidget.vtkPointWidget_GetPosition_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointWidget_GetPosition_09(HandleRef pThis, IntPtr xyz);

		public void GetPosition(IntPtr xyz)
		{
			vtkPointWidget.vtkPointWidget_GetPosition_09(base.GetCppThis(), xyz);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPointWidget_GetProperty_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointWidget.vtkPointWidget_GetProperty_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPointWidget_GetSelectedProperty_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectedProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointWidget.vtkPointWidget_GetSelectedProperty_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPointWidget_GetTranslationMode_12(HandleRef pThis);

		public int GetTranslationMode()
		{
			return vtkPointWidget.vtkPointWidget_GetTranslationMode_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPointWidget_GetXShadows_13(HandleRef pThis);

		public int GetXShadows()
		{
			return vtkPointWidget.vtkPointWidget_GetXShadows_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPointWidget_GetYShadows_14(HandleRef pThis);

		public int GetYShadows()
		{
			return vtkPointWidget.vtkPointWidget_GetYShadows_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPointWidget_GetZShadows_15(HandleRef pThis);

		public int GetZShadows()
		{
			return vtkPointWidget.vtkPointWidget_GetZShadows_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPointWidget_IsA_16(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPointWidget.vtkPointWidget_IsA_16(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPointWidget_IsTypeOf_17(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPointWidget.vtkPointWidget_IsTypeOf_17(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPointWidget_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPointWidget NewInstance()
		{
			vtkPointWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointWidget.vtkPointWidget_NewInstance_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointWidget_OutlineOff_20(HandleRef pThis);

		public void OutlineOff()
		{
			vtkPointWidget.vtkPointWidget_OutlineOff_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointWidget_OutlineOn_21(HandleRef pThis);

		public void OutlineOn()
		{
			vtkPointWidget.vtkPointWidget_OutlineOn_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointWidget_PlaceWidget_22(HandleRef pThis, IntPtr bounds);

		public override void PlaceWidget(IntPtr bounds)
		{
			vtkPointWidget.vtkPointWidget_PlaceWidget_22(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointWidget_PlaceWidget_23(HandleRef pThis);

		public override void PlaceWidget()
		{
			vtkPointWidget.vtkPointWidget_PlaceWidget_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointWidget_PlaceWidget_24(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		public override void PlaceWidget(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtkPointWidget.vtkPointWidget_PlaceWidget_24(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPointWidget_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPointWidget SafeDownCast(vtkObjectBase o)
		{
			vtkPointWidget vtkPointWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointWidget.vtkPointWidget_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointWidget = (vtkPointWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointWidget.Register(null);
				}
			}
			return vtkPointWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointWidget_SetEnabled_26(HandleRef pThis, int arg0);

		public override void SetEnabled(int arg0)
		{
			vtkPointWidget.vtkPointWidget_SetEnabled_26(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointWidget_SetHotSpotSize_27(HandleRef pThis, double _arg);

		public virtual void SetHotSpotSize(double _arg)
		{
			vtkPointWidget.vtkPointWidget_SetHotSpotSize_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointWidget_SetOutline_28(HandleRef pThis, int o);

		public void SetOutline(int o)
		{
			vtkPointWidget.vtkPointWidget_SetOutline_28(base.GetCppThis(), o);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointWidget_SetPosition_29(HandleRef pThis, double x, double y, double z);

		public void SetPosition(double x, double y, double z)
		{
			vtkPointWidget.vtkPointWidget_SetPosition_29(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointWidget_SetPosition_30(HandleRef pThis, IntPtr x);

		public void SetPosition(IntPtr x)
		{
			vtkPointWidget.vtkPointWidget_SetPosition_30(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointWidget_SetTranslationMode_31(HandleRef pThis, int mode);

		public void SetTranslationMode(int mode)
		{
			vtkPointWidget.vtkPointWidget_SetTranslationMode_31(base.GetCppThis(), mode);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointWidget_SetXShadows_32(HandleRef pThis, int o);

		public void SetXShadows(int o)
		{
			vtkPointWidget.vtkPointWidget_SetXShadows_32(base.GetCppThis(), o);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointWidget_SetYShadows_33(HandleRef pThis, int o);

		public void SetYShadows(int o)
		{
			vtkPointWidget.vtkPointWidget_SetYShadows_33(base.GetCppThis(), o);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointWidget_SetZShadows_34(HandleRef pThis, int o);

		public void SetZShadows(int o)
		{
			vtkPointWidget.vtkPointWidget_SetZShadows_34(base.GetCppThis(), o);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointWidget_TranslationModeOff_35(HandleRef pThis);

		public void TranslationModeOff()
		{
			vtkPointWidget.vtkPointWidget_TranslationModeOff_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointWidget_TranslationModeOn_36(HandleRef pThis);

		public void TranslationModeOn()
		{
			vtkPointWidget.vtkPointWidget_TranslationModeOn_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointWidget_XShadowsOff_37(HandleRef pThis);

		public void XShadowsOff()
		{
			vtkPointWidget.vtkPointWidget_XShadowsOff_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointWidget_XShadowsOn_38(HandleRef pThis);

		public void XShadowsOn()
		{
			vtkPointWidget.vtkPointWidget_XShadowsOn_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointWidget_YShadowsOff_39(HandleRef pThis);

		public void YShadowsOff()
		{
			vtkPointWidget.vtkPointWidget_YShadowsOff_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointWidget_YShadowsOn_40(HandleRef pThis);

		public void YShadowsOn()
		{
			vtkPointWidget.vtkPointWidget_YShadowsOn_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointWidget_ZShadowsOff_41(HandleRef pThis);

		public void ZShadowsOff()
		{
			vtkPointWidget.vtkPointWidget_ZShadowsOff_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointWidget_ZShadowsOn_42(HandleRef pThis);

		public void ZShadowsOn()
		{
			vtkPointWidget.vtkPointWidget_ZShadowsOn_42(base.GetCppThis());
		}
	}
}
