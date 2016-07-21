using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImagePlaneWidget : vtkPolyDataSourceWidget
	{
		public enum VTK_CURSOR_ACTION_WrapperEnum
		{
			VTK_CURSOR_ACTION,
			VTK_SLICE_MOTION_ACTION,
			VTK_WINDOW_LEVEL_ACTION
		}

		public enum VTK_CONTROL_MODIFIER_WrapperEnum
		{
			VTK_CONTROL_MODIFIER = 2,
			VTK_NO_MODIFIER = 0,
			VTK_SHIFT_MODIFIER
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkImagePlaneWidget";

		public new static readonly string MRClassNameKey;

		static vtkImagePlaneWidget()
		{
			vtkImagePlaneWidget.MRClassNameKey = "class vtkImagePlaneWidget";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImagePlaneWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImagePlaneWidget"));
		}

		public vtkImagePlaneWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImagePlaneWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImagePlaneWidget New()
		{
			vtkImagePlaneWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImagePlaneWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImagePlaneWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImagePlaneWidget.vtkImagePlaneWidget_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_DisplayTextOff_01(HandleRef pThis);

		public virtual void DisplayTextOff()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_DisplayTextOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_DisplayTextOn_02(HandleRef pThis);

		public virtual void DisplayTextOn()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_DisplayTextOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_GetCenter_03(HandleRef pThis, IntPtr xyz);

		public void GetCenter(IntPtr xyz)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_GetCenter_03(base.GetCppThis(), xyz);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImagePlaneWidget_GetCenter_04(HandleRef pThis);

		public double[] GetCenter()
		{
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_GetCenter_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImagePlaneWidget_GetColorMap_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImageMapToColors GetColorMap()
		{
			vtkImageMapToColors vtkImageMapToColors = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_GetColorMap_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageMapToColors = (vtkImageMapToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageMapToColors.Register(null);
				}
			}
			return vtkImageMapToColors;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImagePlaneWidget_GetCurrentCursorPosition_06(HandleRef pThis);

		public virtual double[] GetCurrentCursorPosition()
		{
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_GetCurrentCursorPosition_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_GetCurrentCursorPosition_07(HandleRef pThis, IntPtr data);

		public virtual void GetCurrentCursorPosition(IntPtr data)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_GetCurrentCursorPosition_07(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkImagePlaneWidget_GetCurrentImageValue_08(HandleRef pThis);

		public virtual double GetCurrentImageValue()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetCurrentImageValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImagePlaneWidget_GetCursorData_09(HandleRef pThis, IntPtr xyzv);

		public int GetCursorData(IntPtr xyzv)
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetCursorData_09(base.GetCppThis(), xyzv);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImagePlaneWidget_GetCursorDataStatus_10(HandleRef pThis);

		public int GetCursorDataStatus()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetCursorDataStatus_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImagePlaneWidget_GetCursorProperty_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetCursorProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_GetCursorProperty_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkImagePlaneWidget_GetDisplayText_12(HandleRef pThis);

		public virtual int GetDisplayText()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetDisplayText_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImagePlaneWidget_GetInteraction_13(HandleRef pThis);

		public virtual int GetInteraction()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetInteraction_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImagePlaneWidget_GetLeftButtonAction_14(HandleRef pThis);

		public virtual int GetLeftButtonAction()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetLeftButtonAction_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImagePlaneWidget_GetLeftButtonActionMaxValue_15(HandleRef pThis);

		public virtual int GetLeftButtonActionMaxValue()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetLeftButtonActionMaxValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImagePlaneWidget_GetLeftButtonActionMinValue_16(HandleRef pThis);

		public virtual int GetLeftButtonActionMinValue()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetLeftButtonActionMinValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImagePlaneWidget_GetLeftButtonAutoModifier_17(HandleRef pThis);

		public virtual int GetLeftButtonAutoModifier()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetLeftButtonAutoModifier_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImagePlaneWidget_GetLeftButtonAutoModifierMaxValue_18(HandleRef pThis);

		public virtual int GetLeftButtonAutoModifierMaxValue()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetLeftButtonAutoModifierMaxValue_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImagePlaneWidget_GetLeftButtonAutoModifierMinValue_19(HandleRef pThis);

		public virtual int GetLeftButtonAutoModifierMinValue()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetLeftButtonAutoModifierMinValue_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkImagePlaneWidget_GetLevel_20(HandleRef pThis);

		public double GetLevel()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetLevel_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImagePlaneWidget_GetLookupTable_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkLookupTable GetLookupTable()
		{
			vtkLookupTable vtkLookupTable = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_GetLookupTable_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLookupTable = (vtkLookupTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLookupTable.Register(null);
				}
			}
			return vtkLookupTable;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImagePlaneWidget_GetMarginProperty_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetMarginProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_GetMarginProperty_22(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern double vtkImagePlaneWidget_GetMarginSizeX_23(HandleRef pThis);

		public virtual double GetMarginSizeX()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetMarginSizeX_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkImagePlaneWidget_GetMarginSizeXMaxValue_24(HandleRef pThis);

		public virtual double GetMarginSizeXMaxValue()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetMarginSizeXMaxValue_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkImagePlaneWidget_GetMarginSizeXMinValue_25(HandleRef pThis);

		public virtual double GetMarginSizeXMinValue()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetMarginSizeXMinValue_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkImagePlaneWidget_GetMarginSizeY_26(HandleRef pThis);

		public virtual double GetMarginSizeY()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetMarginSizeY_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkImagePlaneWidget_GetMarginSizeYMaxValue_27(HandleRef pThis);

		public virtual double GetMarginSizeYMaxValue()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetMarginSizeYMaxValue_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkImagePlaneWidget_GetMarginSizeYMinValue_28(HandleRef pThis);

		public virtual double GetMarginSizeYMinValue()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetMarginSizeYMinValue_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImagePlaneWidget_GetMiddleButtonAction_29(HandleRef pThis);

		public virtual int GetMiddleButtonAction()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetMiddleButtonAction_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImagePlaneWidget_GetMiddleButtonActionMaxValue_30(HandleRef pThis);

		public virtual int GetMiddleButtonActionMaxValue()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetMiddleButtonActionMaxValue_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImagePlaneWidget_GetMiddleButtonActionMinValue_31(HandleRef pThis);

		public virtual int GetMiddleButtonActionMinValue()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetMiddleButtonActionMinValue_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImagePlaneWidget_GetMiddleButtonAutoModifier_32(HandleRef pThis);

		public virtual int GetMiddleButtonAutoModifier()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetMiddleButtonAutoModifier_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImagePlaneWidget_GetMiddleButtonAutoModifierMaxValue_33(HandleRef pThis);

		public virtual int GetMiddleButtonAutoModifierMaxValue()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetMiddleButtonAutoModifierMaxValue_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImagePlaneWidget_GetMiddleButtonAutoModifierMinValue_34(HandleRef pThis);

		public virtual int GetMiddleButtonAutoModifierMinValue()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetMiddleButtonAutoModifierMinValue_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImagePlaneWidget_GetNormal_35(HandleRef pThis);

		public double[] GetNormal()
		{
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_GetNormal_35(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_GetNormal_36(HandleRef pThis, IntPtr xyz);

		public void GetNormal(IntPtr xyz)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_GetNormal_36(base.GetCppThis(), xyz);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImagePlaneWidget_GetOrigin_37(HandleRef pThis);

		public double[] GetOrigin()
		{
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_GetOrigin_37(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_GetOrigin_38(HandleRef pThis, IntPtr xyz);

		public void GetOrigin(IntPtr xyz)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_GetOrigin_38(base.GetCppThis(), xyz);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImagePlaneWidget_GetPlaneOrientation_39(HandleRef pThis);

		public virtual int GetPlaneOrientation()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetPlaneOrientation_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImagePlaneWidget_GetPlaneProperty_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetPlaneProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_GetPlaneProperty_40(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkImagePlaneWidget_GetPoint1_41(HandleRef pThis);

		public double[] GetPoint1()
		{
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_GetPoint1_41(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_GetPoint1_42(HandleRef pThis, IntPtr xyz);

		public void GetPoint1(IntPtr xyz)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_GetPoint1_42(base.GetCppThis(), xyz);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImagePlaneWidget_GetPoint2_43(HandleRef pThis);

		public double[] GetPoint2()
		{
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_GetPoint2_43(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_GetPoint2_44(HandleRef pThis, IntPtr xyz);

		public void GetPoint2(IntPtr xyz)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_GetPoint2_44(base.GetCppThis(), xyz);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_GetPolyData_45(HandleRef pThis, HandleRef pd);

		public void GetPolyData(vtkPolyData pd)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_GetPolyData_45(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImagePlaneWidget_GetPolyDataAlgorithm_46(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkPolyDataAlgorithm GetPolyDataAlgorithm()
		{
			vtkPolyDataAlgorithm vtkPolyDataAlgorithm = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_GetPolyDataAlgorithm_46(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataAlgorithm = (vtkPolyDataAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataAlgorithm.Register(null);
				}
			}
			return vtkPolyDataAlgorithm;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImagePlaneWidget_GetReslice_47(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImageReslice GetReslice()
		{
			vtkImageReslice vtkImageReslice = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_GetReslice_47(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageReslice = (vtkImageReslice)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageReslice.Register(null);
				}
			}
			return vtkImageReslice;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImagePlaneWidget_GetResliceAxes_48(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMatrix4x4 GetResliceAxes()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_GetResliceAxes_48(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImagePlaneWidget_GetResliceInterpolate_49(HandleRef pThis);

		public virtual int GetResliceInterpolate()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetResliceInterpolate_49(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImagePlaneWidget_GetResliceOutput_50(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkImageData GetResliceOutput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_GetResliceOutput_50(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImagePlaneWidget_GetRestrictPlaneToVolume_51(HandleRef pThis);

		public virtual int GetRestrictPlaneToVolume()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetRestrictPlaneToVolume_51(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImagePlaneWidget_GetRightButtonAction_52(HandleRef pThis);

		public virtual int GetRightButtonAction()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetRightButtonAction_52(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImagePlaneWidget_GetRightButtonActionMaxValue_53(HandleRef pThis);

		public virtual int GetRightButtonActionMaxValue()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetRightButtonActionMaxValue_53(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImagePlaneWidget_GetRightButtonActionMinValue_54(HandleRef pThis);

		public virtual int GetRightButtonActionMinValue()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetRightButtonActionMinValue_54(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImagePlaneWidget_GetRightButtonAutoModifier_55(HandleRef pThis);

		public virtual int GetRightButtonAutoModifier()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetRightButtonAutoModifier_55(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImagePlaneWidget_GetRightButtonAutoModifierMaxValue_56(HandleRef pThis);

		public virtual int GetRightButtonAutoModifierMaxValue()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetRightButtonAutoModifierMaxValue_56(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImagePlaneWidget_GetRightButtonAutoModifierMinValue_57(HandleRef pThis);

		public virtual int GetRightButtonAutoModifierMinValue()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetRightButtonAutoModifierMinValue_57(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImagePlaneWidget_GetSelectedPlaneProperty_58(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectedPlaneProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_GetSelectedPlaneProperty_58(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkImagePlaneWidget_GetSliceIndex_59(HandleRef pThis);

		public int GetSliceIndex()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetSliceIndex_59(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkImagePlaneWidget_GetSlicePosition_60(HandleRef pThis);

		public double GetSlicePosition()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetSlicePosition_60(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImagePlaneWidget_GetTextProperty_61(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkTextProperty GetTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_GetTextProperty_61(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImagePlaneWidget_GetTexture_62(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkTexture GetTexture()
		{
			vtkTexture vtkTexture = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_GetTexture_62(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTexture = (vtkTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTexture.Register(null);
				}
			}
			return vtkTexture;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImagePlaneWidget_GetTextureInterpolate_63(HandleRef pThis);

		public virtual int GetTextureInterpolate()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetTextureInterpolate_63(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImagePlaneWidget_GetTexturePlaneProperty_64(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetTexturePlaneProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_GetTexturePlaneProperty_64(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkImagePlaneWidget_GetTextureVisibility_65(HandleRef pThis);

		public virtual int GetTextureVisibility()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetTextureVisibility_65(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImagePlaneWidget_GetUseContinuousCursor_66(HandleRef pThis);

		public virtual int GetUseContinuousCursor()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetUseContinuousCursor_66(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImagePlaneWidget_GetUserControlledLookupTable_67(HandleRef pThis);

		public virtual int GetUserControlledLookupTable()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetUserControlledLookupTable_67(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_GetVector1_68(HandleRef pThis, IntPtr v1);

		public void GetVector1(IntPtr v1)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_GetVector1_68(base.GetCppThis(), v1);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_GetVector2_69(HandleRef pThis, IntPtr v2);

		public void GetVector2(IntPtr v2)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_GetVector2_69(base.GetCppThis(), v2);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkImagePlaneWidget_GetWindow_70(HandleRef pThis);

		public double GetWindow()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetWindow_70(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_GetWindowLevel_71(HandleRef pThis, IntPtr wl);

		public void GetWindowLevel(IntPtr wl)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_GetWindowLevel_71(base.GetCppThis(), wl);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_InteractionOff_72(HandleRef pThis);

		public virtual void InteractionOff()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_InteractionOff_72(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_InteractionOn_73(HandleRef pThis);

		public virtual void InteractionOn()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_InteractionOn_73(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImagePlaneWidget_IsA_74(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_IsA_74(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImagePlaneWidget_IsTypeOf_75(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_IsTypeOf_75(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImagePlaneWidget_NewInstance_77(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImagePlaneWidget NewInstance()
		{
			vtkImagePlaneWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_NewInstance_77(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImagePlaneWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_PlaceWidget_78(HandleRef pThis, IntPtr bounds);

		public override void PlaceWidget(IntPtr bounds)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_PlaceWidget_78(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_PlaceWidget_79(HandleRef pThis);

		public override void PlaceWidget()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_PlaceWidget_79(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_PlaceWidget_80(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		public override void PlaceWidget(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_PlaceWidget_80(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_RestrictPlaneToVolumeOff_81(HandleRef pThis);

		public virtual void RestrictPlaneToVolumeOff()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_RestrictPlaneToVolumeOff_81(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_RestrictPlaneToVolumeOn_82(HandleRef pThis);

		public virtual void RestrictPlaneToVolumeOn()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_RestrictPlaneToVolumeOn_82(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImagePlaneWidget_SafeDownCast_83(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImagePlaneWidget SafeDownCast(vtkObjectBase o)
		{
			vtkImagePlaneWidget vtkImagePlaneWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_SafeDownCast_83((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImagePlaneWidget = (vtkImagePlaneWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImagePlaneWidget.Register(null);
				}
			}
			return vtkImagePlaneWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetColorMap_84(HandleRef pThis, HandleRef arg0);

		public virtual void SetColorMap(vtkImageMapToColors arg0)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetColorMap_84(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetCursorProperty_85(HandleRef pThis, HandleRef arg0);

		public virtual void SetCursorProperty(vtkProperty arg0)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetCursorProperty_85(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetDisplayText_86(HandleRef pThis, int _arg);

		public virtual void SetDisplayText(int _arg)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetDisplayText_86(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetEnabled_87(HandleRef pThis, int arg0);

		public override void SetEnabled(int arg0)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetEnabled_87(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetInput_88(HandleRef pThis, HandleRef input);

		public override void SetInput(vtkDataSet input)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetInput_88(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetInteraction_89(HandleRef pThis, int interact);

		public void SetInteraction(int interact)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetInteraction_89(base.GetCppThis(), interact);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetLeftButtonAction_90(HandleRef pThis, int _arg);

		public virtual void SetLeftButtonAction(int _arg)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetLeftButtonAction_90(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetLeftButtonAutoModifier_91(HandleRef pThis, int _arg);

		public virtual void SetLeftButtonAutoModifier(int _arg)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetLeftButtonAutoModifier_91(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetLookupTable_92(HandleRef pThis, HandleRef arg0);

		public virtual void SetLookupTable(vtkLookupTable arg0)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetLookupTable_92(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetMarginProperty_93(HandleRef pThis, HandleRef arg0);

		public virtual void SetMarginProperty(vtkProperty arg0)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetMarginProperty_93(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetMarginSizeX_94(HandleRef pThis, double _arg);

		public virtual void SetMarginSizeX(double _arg)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetMarginSizeX_94(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetMarginSizeY_95(HandleRef pThis, double _arg);

		public virtual void SetMarginSizeY(double _arg)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetMarginSizeY_95(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetMiddleButtonAction_96(HandleRef pThis, int _arg);

		public virtual void SetMiddleButtonAction(int _arg)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetMiddleButtonAction_96(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetMiddleButtonAutoModifier_97(HandleRef pThis, int _arg);

		public virtual void SetMiddleButtonAutoModifier(int _arg)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetMiddleButtonAutoModifier_97(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetOrigin_98(HandleRef pThis, double x, double y, double z);

		public void SetOrigin(double x, double y, double z)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetOrigin_98(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetOrigin_99(HandleRef pThis, IntPtr xyz);

		public void SetOrigin(IntPtr xyz)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetOrigin_99(base.GetCppThis(), xyz);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetPicker_100(HandleRef pThis, HandleRef arg0);

		public void SetPicker(vtkAbstractPropPicker arg0)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetPicker_100(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetPlaneOrientation_101(HandleRef pThis, int arg0);

		public void SetPlaneOrientation(int arg0)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetPlaneOrientation_101(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetPlaneOrientationToXAxes_102(HandleRef pThis);

		public void SetPlaneOrientationToXAxes()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetPlaneOrientationToXAxes_102(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetPlaneOrientationToYAxes_103(HandleRef pThis);

		public void SetPlaneOrientationToYAxes()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetPlaneOrientationToYAxes_103(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetPlaneOrientationToZAxes_104(HandleRef pThis);

		public void SetPlaneOrientationToZAxes()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetPlaneOrientationToZAxes_104(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetPlaneProperty_105(HandleRef pThis, HandleRef arg0);

		public virtual void SetPlaneProperty(vtkProperty arg0)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetPlaneProperty_105(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetPoint1_106(HandleRef pThis, double x, double y, double z);

		public void SetPoint1(double x, double y, double z)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetPoint1_106(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetPoint1_107(HandleRef pThis, IntPtr xyz);

		public void SetPoint1(IntPtr xyz)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetPoint1_107(base.GetCppThis(), xyz);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetPoint2_108(HandleRef pThis, double x, double y, double z);

		public void SetPoint2(double x, double y, double z)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetPoint2_108(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetPoint2_109(HandleRef pThis, IntPtr xyz);

		public void SetPoint2(IntPtr xyz)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetPoint2_109(base.GetCppThis(), xyz);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetResliceInterpolate_110(HandleRef pThis, int arg0);

		public void SetResliceInterpolate(int arg0)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetResliceInterpolate_110(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetResliceInterpolateToCubic_111(HandleRef pThis);

		public void SetResliceInterpolateToCubic()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetResliceInterpolateToCubic_111(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetResliceInterpolateToLinear_112(HandleRef pThis);

		public void SetResliceInterpolateToLinear()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetResliceInterpolateToLinear_112(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetResliceInterpolateToNearestNeighbour_113(HandleRef pThis);

		public void SetResliceInterpolateToNearestNeighbour()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetResliceInterpolateToNearestNeighbour_113(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetRestrictPlaneToVolume_114(HandleRef pThis, int _arg);

		public virtual void SetRestrictPlaneToVolume(int _arg)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetRestrictPlaneToVolume_114(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetRightButtonAction_115(HandleRef pThis, int _arg);

		public virtual void SetRightButtonAction(int _arg)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetRightButtonAction_115(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetRightButtonAutoModifier_116(HandleRef pThis, int _arg);

		public virtual void SetRightButtonAutoModifier(int _arg)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetRightButtonAutoModifier_116(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetSelectedPlaneProperty_117(HandleRef pThis, HandleRef arg0);

		public virtual void SetSelectedPlaneProperty(vtkProperty arg0)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetSelectedPlaneProperty_117(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetSliceIndex_118(HandleRef pThis, int index);

		public void SetSliceIndex(int index)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetSliceIndex_118(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetSlicePosition_119(HandleRef pThis, double position);

		public void SetSlicePosition(double position)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetSlicePosition_119(base.GetCppThis(), position);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetTextProperty_120(HandleRef pThis, HandleRef tprop);

		public void SetTextProperty(vtkTextProperty tprop)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetTextProperty_120(base.GetCppThis(), (tprop == null) ? default(HandleRef) : tprop.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetTextureInterpolate_121(HandleRef pThis, int _arg);

		public virtual void SetTextureInterpolate(int _arg)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetTextureInterpolate_121(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetTexturePlaneProperty_122(HandleRef pThis, HandleRef arg0);

		public virtual void SetTexturePlaneProperty(vtkProperty arg0)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetTexturePlaneProperty_122(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetTextureVisibility_123(HandleRef pThis, int arg0);

		public virtual void SetTextureVisibility(int arg0)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetTextureVisibility_123(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetUseContinuousCursor_124(HandleRef pThis, int _arg);

		public virtual void SetUseContinuousCursor(int _arg)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetUseContinuousCursor_124(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetUserControlledLookupTable_125(HandleRef pThis, int _arg);

		public virtual void SetUserControlledLookupTable(int _arg)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetUserControlledLookupTable_125(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_SetWindowLevel_126(HandleRef pThis, double window, double level, int copy);

		public void SetWindowLevel(double window, double level, int copy)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetWindowLevel_126(base.GetCppThis(), window, level, copy);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_TextureInterpolateOff_127(HandleRef pThis);

		public virtual void TextureInterpolateOff()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_TextureInterpolateOff_127(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_TextureInterpolateOn_128(HandleRef pThis);

		public virtual void TextureInterpolateOn()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_TextureInterpolateOn_128(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_TextureVisibilityOff_129(HandleRef pThis);

		public virtual void TextureVisibilityOff()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_TextureVisibilityOff_129(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_TextureVisibilityOn_130(HandleRef pThis);

		public virtual void TextureVisibilityOn()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_TextureVisibilityOn_130(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_UpdatePlacement_131(HandleRef pThis);

		public override void UpdatePlacement()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_UpdatePlacement_131(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_UseContinuousCursorOff_132(HandleRef pThis);

		public virtual void UseContinuousCursorOff()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_UseContinuousCursorOff_132(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_UseContinuousCursorOn_133(HandleRef pThis);

		public virtual void UseContinuousCursorOn()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_UseContinuousCursorOn_133(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_UserControlledLookupTableOff_134(HandleRef pThis);

		public virtual void UserControlledLookupTableOff()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_UserControlledLookupTableOff_134(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImagePlaneWidget_UserControlledLookupTableOn_135(HandleRef pThis);

		public virtual void UserControlledLookupTableOn()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_UserControlledLookupTableOn_135(base.GetCppThis());
		}
	}
}
