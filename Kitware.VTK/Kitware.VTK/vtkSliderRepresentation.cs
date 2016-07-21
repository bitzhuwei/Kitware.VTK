using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkSliderRepresentation : vtkWidgetRepresentation
	{
		public enum _InteractionState
		{
			LeftCap = 2,
			Outside = 0,
			RightCap = 3,
			Slider,
			Tube = 1
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkSliderRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkSliderRepresentation()
		{
			vtkSliderRepresentation.MRClassNameKey = "class vtkSliderRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSliderRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSliderRepresentation"));
		}

		public vtkSliderRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkSliderRepresentation_GetCurrentT_01(HandleRef pThis);

		public virtual double GetCurrentT()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetCurrentT_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkSliderRepresentation_GetEndCapLength_02(HandleRef pThis);

		public virtual double GetEndCapLength()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetEndCapLength_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkSliderRepresentation_GetEndCapLengthMaxValue_03(HandleRef pThis);

		public virtual double GetEndCapLengthMaxValue()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetEndCapLengthMaxValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkSliderRepresentation_GetEndCapLengthMinValue_04(HandleRef pThis);

		public virtual double GetEndCapLengthMinValue()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetEndCapLengthMinValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkSliderRepresentation_GetEndCapWidth_05(HandleRef pThis);

		public virtual double GetEndCapWidth()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetEndCapWidth_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkSliderRepresentation_GetEndCapWidthMaxValue_06(HandleRef pThis);

		public virtual double GetEndCapWidthMaxValue()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetEndCapWidthMaxValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkSliderRepresentation_GetEndCapWidthMinValue_07(HandleRef pThis);

		public virtual double GetEndCapWidthMinValue()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetEndCapWidthMinValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSliderRepresentation_GetLabelFormat_08(HandleRef pThis);

		public virtual string GetLabelFormat()
		{
			return Marshal.PtrToStringAnsi(vtkSliderRepresentation.vtkSliderRepresentation_GetLabelFormat_08(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkSliderRepresentation_GetLabelHeight_09(HandleRef pThis);

		public virtual double GetLabelHeight()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetLabelHeight_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkSliderRepresentation_GetLabelHeightMaxValue_10(HandleRef pThis);

		public virtual double GetLabelHeightMaxValue()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetLabelHeightMaxValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkSliderRepresentation_GetLabelHeightMinValue_11(HandleRef pThis);

		public virtual double GetLabelHeightMinValue()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetLabelHeightMinValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkSliderRepresentation_GetMaximumValue_12(HandleRef pThis);

		public virtual double GetMaximumValue()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetMaximumValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkSliderRepresentation_GetMinimumValue_13(HandleRef pThis);

		public virtual double GetMinimumValue()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetMinimumValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkSliderRepresentation_GetPickedT_14(HandleRef pThis);

		public virtual double GetPickedT()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetPickedT_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSliderRepresentation_GetShowSliderLabel_15(HandleRef pThis);

		public virtual int GetShowSliderLabel()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetShowSliderLabel_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkSliderRepresentation_GetSliderLength_16(HandleRef pThis);

		public virtual double GetSliderLength()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetSliderLength_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkSliderRepresentation_GetSliderLengthMaxValue_17(HandleRef pThis);

		public virtual double GetSliderLengthMaxValue()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetSliderLengthMaxValue_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkSliderRepresentation_GetSliderLengthMinValue_18(HandleRef pThis);

		public virtual double GetSliderLengthMinValue()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetSliderLengthMinValue_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkSliderRepresentation_GetSliderWidth_19(HandleRef pThis);

		public virtual double GetSliderWidth()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetSliderWidth_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkSliderRepresentation_GetSliderWidthMaxValue_20(HandleRef pThis);

		public virtual double GetSliderWidthMaxValue()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetSliderWidthMaxValue_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkSliderRepresentation_GetSliderWidthMinValue_21(HandleRef pThis);

		public virtual double GetSliderWidthMinValue()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetSliderWidthMinValue_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkSliderRepresentation_GetTitleHeight_22(HandleRef pThis);

		public virtual double GetTitleHeight()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetTitleHeight_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkSliderRepresentation_GetTitleHeightMaxValue_23(HandleRef pThis);

		public virtual double GetTitleHeightMaxValue()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetTitleHeightMaxValue_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkSliderRepresentation_GetTitleHeightMinValue_24(HandleRef pThis);

		public virtual double GetTitleHeightMinValue()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetTitleHeightMinValue_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSliderRepresentation_GetTitleText_25(HandleRef pThis);

		public virtual string GetTitleText()
		{
			return Marshal.PtrToStringAnsi(vtkSliderRepresentation.vtkSliderRepresentation_GetTitleText_25(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkSliderRepresentation_GetTubeWidth_26(HandleRef pThis);

		public virtual double GetTubeWidth()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetTubeWidth_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkSliderRepresentation_GetTubeWidthMaxValue_27(HandleRef pThis);

		public virtual double GetTubeWidthMaxValue()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetTubeWidthMaxValue_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkSliderRepresentation_GetTubeWidthMinValue_28(HandleRef pThis);

		public virtual double GetTubeWidthMinValue()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetTubeWidthMinValue_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkSliderRepresentation_GetValue_29(HandleRef pThis);

		public virtual double GetValue()
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_GetValue_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSliderRepresentation_IsA_30(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_IsA_30(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSliderRepresentation_IsTypeOf_31(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSliderRepresentation.vtkSliderRepresentation_IsTypeOf_31(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSliderRepresentation_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSliderRepresentation NewInstance()
		{
			vtkSliderRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSliderRepresentation.vtkSliderRepresentation_NewInstance_32(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSliderRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSliderRepresentation_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSliderRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkSliderRepresentation vtkSliderRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSliderRepresentation.vtkSliderRepresentation_SafeDownCast_33((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSliderRepresentation = (vtkSliderRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSliderRepresentation.Register(null);
				}
			}
			return vtkSliderRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSliderRepresentation_SetEndCapLength_34(HandleRef pThis, double _arg);

		public virtual void SetEndCapLength(double _arg)
		{
			vtkSliderRepresentation.vtkSliderRepresentation_SetEndCapLength_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSliderRepresentation_SetEndCapWidth_35(HandleRef pThis, double _arg);

		public virtual void SetEndCapWidth(double _arg)
		{
			vtkSliderRepresentation.vtkSliderRepresentation_SetEndCapWidth_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSliderRepresentation_SetLabelFormat_36(HandleRef pThis, string _arg);

		public virtual void SetLabelFormat(string _arg)
		{
			vtkSliderRepresentation.vtkSliderRepresentation_SetLabelFormat_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSliderRepresentation_SetLabelHeight_37(HandleRef pThis, double _arg);

		public virtual void SetLabelHeight(double _arg)
		{
			vtkSliderRepresentation.vtkSliderRepresentation_SetLabelHeight_37(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSliderRepresentation_SetMaximumValue_38(HandleRef pThis, double value);

		public void SetMaximumValue(double value)
		{
			vtkSliderRepresentation.vtkSliderRepresentation_SetMaximumValue_38(base.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSliderRepresentation_SetMinimumValue_39(HandleRef pThis, double value);

		public void SetMinimumValue(double value)
		{
			vtkSliderRepresentation.vtkSliderRepresentation_SetMinimumValue_39(base.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSliderRepresentation_SetShowSliderLabel_40(HandleRef pThis, int _arg);

		public virtual void SetShowSliderLabel(int _arg)
		{
			vtkSliderRepresentation.vtkSliderRepresentation_SetShowSliderLabel_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSliderRepresentation_SetSliderLength_41(HandleRef pThis, double _arg);

		public virtual void SetSliderLength(double _arg)
		{
			vtkSliderRepresentation.vtkSliderRepresentation_SetSliderLength_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSliderRepresentation_SetSliderWidth_42(HandleRef pThis, double _arg);

		public virtual void SetSliderWidth(double _arg)
		{
			vtkSliderRepresentation.vtkSliderRepresentation_SetSliderWidth_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSliderRepresentation_SetTitleHeight_43(HandleRef pThis, double _arg);

		public virtual void SetTitleHeight(double _arg)
		{
			vtkSliderRepresentation.vtkSliderRepresentation_SetTitleHeight_43(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSliderRepresentation_SetTitleText_44(HandleRef pThis, string arg0);

		public virtual void SetTitleText(string arg0)
		{
			vtkSliderRepresentation.vtkSliderRepresentation_SetTitleText_44(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSliderRepresentation_SetTubeWidth_45(HandleRef pThis, double _arg);

		public virtual void SetTubeWidth(double _arg)
		{
			vtkSliderRepresentation.vtkSliderRepresentation_SetTubeWidth_45(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSliderRepresentation_SetValue_46(HandleRef pThis, double value);

		public void SetValue(double value)
		{
			vtkSliderRepresentation.vtkSliderRepresentation_SetValue_46(base.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSliderRepresentation_ShowSliderLabelOff_47(HandleRef pThis);

		public virtual void ShowSliderLabelOff()
		{
			vtkSliderRepresentation.vtkSliderRepresentation_ShowSliderLabelOff_47(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSliderRepresentation_ShowSliderLabelOn_48(HandleRef pThis);

		public virtual void ShowSliderLabelOn()
		{
			vtkSliderRepresentation.vtkSliderRepresentation_ShowSliderLabelOn_48(base.GetCppThis());
		}
	}
}
