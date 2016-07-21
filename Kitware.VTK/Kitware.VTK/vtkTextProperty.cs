using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTextProperty : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTextProperty";

		public new static readonly string MRClassNameKey;

		static vtkTextProperty()
		{
			vtkTextProperty.MRClassNameKey = "class vtkTextProperty";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTextProperty.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextProperty"));
		}

		public vtkTextProperty(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTextProperty_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTextProperty New()
		{
			vtkTextProperty result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextProperty.vtkTextProperty_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTextProperty() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTextProperty.vtkTextProperty_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextProperty_BoldOff_01(HandleRef pThis);

		public virtual void BoldOff()
		{
			vtkTextProperty.vtkTextProperty_BoldOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextProperty_BoldOn_02(HandleRef pThis);

		public virtual void BoldOn()
		{
			vtkTextProperty.vtkTextProperty_BoldOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextProperty_GetBold_03(HandleRef pThis);

		public virtual int GetBold()
		{
			return vtkTextProperty.vtkTextProperty_GetBold_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTextProperty_GetColor_04(HandleRef pThis);

		public virtual double[] GetColor()
		{
			IntPtr intPtr = vtkTextProperty.vtkTextProperty_GetColor_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextProperty_GetColor_05(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkTextProperty.vtkTextProperty_GetColor_05(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextProperty_GetColor_06(HandleRef pThis, IntPtr _arg);

		public virtual void GetColor(IntPtr _arg)
		{
			vtkTextProperty.vtkTextProperty_GetColor_06(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextProperty_GetFontFamily_07(HandleRef pThis);

		public int GetFontFamily()
		{
			return vtkTextProperty.vtkTextProperty_GetFontFamily_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTextProperty_GetFontFamilyAsString_08(HandleRef pThis);

		public virtual string GetFontFamilyAsString()
		{
			return Marshal.PtrToStringAnsi(vtkTextProperty.vtkTextProperty_GetFontFamilyAsString_08(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTextProperty_GetFontFamilyAsString_09(int f);

		public static string GetFontFamilyAsString(int f)
		{
			return Marshal.PtrToStringAnsi(vtkTextProperty.vtkTextProperty_GetFontFamilyAsString_09(f));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextProperty_GetFontFamilyFromString_10(string f);

		public static int GetFontFamilyFromString(string f)
		{
			return vtkTextProperty.vtkTextProperty_GetFontFamilyFromString_10(f);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextProperty_GetFontFamilyMinValue_11(HandleRef pThis);

		public int GetFontFamilyMinValue()
		{
			return vtkTextProperty.vtkTextProperty_GetFontFamilyMinValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextProperty_GetFontSize_12(HandleRef pThis);

		public virtual int GetFontSize()
		{
			return vtkTextProperty.vtkTextProperty_GetFontSize_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextProperty_GetFontSizeMaxValue_13(HandleRef pThis);

		public virtual int GetFontSizeMaxValue()
		{
			return vtkTextProperty.vtkTextProperty_GetFontSizeMaxValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextProperty_GetFontSizeMinValue_14(HandleRef pThis);

		public virtual int GetFontSizeMinValue()
		{
			return vtkTextProperty.vtkTextProperty_GetFontSizeMinValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextProperty_GetItalic_15(HandleRef pThis);

		public virtual int GetItalic()
		{
			return vtkTextProperty.vtkTextProperty_GetItalic_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextProperty_GetJustification_16(HandleRef pThis);

		public virtual int GetJustification()
		{
			return vtkTextProperty.vtkTextProperty_GetJustification_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTextProperty_GetJustificationAsString_17(HandleRef pThis);

		public string GetJustificationAsString()
		{
			return Marshal.PtrToStringAnsi(vtkTextProperty.vtkTextProperty_GetJustificationAsString_17(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextProperty_GetJustificationMaxValue_18(HandleRef pThis);

		public virtual int GetJustificationMaxValue()
		{
			return vtkTextProperty.vtkTextProperty_GetJustificationMaxValue_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextProperty_GetJustificationMinValue_19(HandleRef pThis);

		public virtual int GetJustificationMinValue()
		{
			return vtkTextProperty.vtkTextProperty_GetJustificationMinValue_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkTextProperty_GetLineOffset_20(HandleRef pThis);

		public virtual double GetLineOffset()
		{
			return vtkTextProperty.vtkTextProperty_GetLineOffset_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkTextProperty_GetLineSpacing_21(HandleRef pThis);

		public virtual double GetLineSpacing()
		{
			return vtkTextProperty.vtkTextProperty_GetLineSpacing_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkTextProperty_GetOpacity_22(HandleRef pThis);

		public virtual double GetOpacity()
		{
			return vtkTextProperty.vtkTextProperty_GetOpacity_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkTextProperty_GetOrientation_23(HandleRef pThis);

		public virtual double GetOrientation()
		{
			return vtkTextProperty.vtkTextProperty_GetOrientation_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextProperty_GetShadow_24(HandleRef pThis);

		public virtual int GetShadow()
		{
			return vtkTextProperty.vtkTextProperty_GetShadow_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextProperty_GetShadowColor_25(HandleRef pThis, IntPtr color);

		public void GetShadowColor(IntPtr color)
		{
			vtkTextProperty.vtkTextProperty_GetShadowColor_25(base.GetCppThis(), color);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTextProperty_GetShadowOffset_26(HandleRef pThis);

		public virtual int[] GetShadowOffset()
		{
			IntPtr intPtr = vtkTextProperty.vtkTextProperty_GetShadowOffset_26(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextProperty_GetShadowOffset_27(HandleRef pThis, IntPtr data);

		public virtual void GetShadowOffset(IntPtr data)
		{
			vtkTextProperty.vtkTextProperty_GetShadowOffset_27(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextProperty_GetVerticalJustification_28(HandleRef pThis);

		public virtual int GetVerticalJustification()
		{
			return vtkTextProperty.vtkTextProperty_GetVerticalJustification_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTextProperty_GetVerticalJustificationAsString_29(HandleRef pThis);

		public string GetVerticalJustificationAsString()
		{
			return Marshal.PtrToStringAnsi(vtkTextProperty.vtkTextProperty_GetVerticalJustificationAsString_29(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextProperty_GetVerticalJustificationMaxValue_30(HandleRef pThis);

		public virtual int GetVerticalJustificationMaxValue()
		{
			return vtkTextProperty.vtkTextProperty_GetVerticalJustificationMaxValue_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextProperty_GetVerticalJustificationMinValue_31(HandleRef pThis);

		public virtual int GetVerticalJustificationMinValue()
		{
			return vtkTextProperty.vtkTextProperty_GetVerticalJustificationMinValue_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextProperty_IsA_32(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTextProperty.vtkTextProperty_IsA_32(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextProperty_IsTypeOf_33(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTextProperty.vtkTextProperty_IsTypeOf_33(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextProperty_ItalicOff_34(HandleRef pThis);

		public virtual void ItalicOff()
		{
			vtkTextProperty.vtkTextProperty_ItalicOff_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextProperty_ItalicOn_35(HandleRef pThis);

		public virtual void ItalicOn()
		{
			vtkTextProperty.vtkTextProperty_ItalicOn_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTextProperty_NewInstance_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTextProperty NewInstance()
		{
			vtkTextProperty result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextProperty.vtkTextProperty_NewInstance_37(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTextProperty_SafeDownCast_38(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTextProperty SafeDownCast(vtkObjectBase o)
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextProperty.vtkTextProperty_SafeDownCast_38((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextProperty_SetBold_39(HandleRef pThis, int _arg);

		public virtual void SetBold(int _arg)
		{
			vtkTextProperty.vtkTextProperty_SetBold_39(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextProperty_SetColor_40(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetColor(double _arg1, double _arg2, double _arg3)
		{
			vtkTextProperty.vtkTextProperty_SetColor_40(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextProperty_SetColor_41(HandleRef pThis, IntPtr _arg);

		public virtual void SetColor(IntPtr _arg)
		{
			vtkTextProperty.vtkTextProperty_SetColor_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextProperty_SetFontFamily_42(HandleRef pThis, int t);

		public void SetFontFamily(int t)
		{
			vtkTextProperty.vtkTextProperty_SetFontFamily_42(base.GetCppThis(), t);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextProperty_SetFontFamilyAsString_43(HandleRef pThis, string _arg);

		public virtual void SetFontFamilyAsString(string _arg)
		{
			vtkTextProperty.vtkTextProperty_SetFontFamilyAsString_43(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextProperty_SetFontFamilyToArial_44(HandleRef pThis);

		public void SetFontFamilyToArial()
		{
			vtkTextProperty.vtkTextProperty_SetFontFamilyToArial_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextProperty_SetFontFamilyToCourier_45(HandleRef pThis);

		public void SetFontFamilyToCourier()
		{
			vtkTextProperty.vtkTextProperty_SetFontFamilyToCourier_45(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextProperty_SetFontFamilyToTimes_46(HandleRef pThis);

		public void SetFontFamilyToTimes()
		{
			vtkTextProperty.vtkTextProperty_SetFontFamilyToTimes_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextProperty_SetFontSize_47(HandleRef pThis, int _arg);

		public virtual void SetFontSize(int _arg)
		{
			vtkTextProperty.vtkTextProperty_SetFontSize_47(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextProperty_SetItalic_48(HandleRef pThis, int _arg);

		public virtual void SetItalic(int _arg)
		{
			vtkTextProperty.vtkTextProperty_SetItalic_48(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextProperty_SetJustification_49(HandleRef pThis, int _arg);

		public virtual void SetJustification(int _arg)
		{
			vtkTextProperty.vtkTextProperty_SetJustification_49(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextProperty_SetJustificationToCentered_50(HandleRef pThis);

		public void SetJustificationToCentered()
		{
			vtkTextProperty.vtkTextProperty_SetJustificationToCentered_50(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextProperty_SetJustificationToLeft_51(HandleRef pThis);

		public void SetJustificationToLeft()
		{
			vtkTextProperty.vtkTextProperty_SetJustificationToLeft_51(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextProperty_SetJustificationToRight_52(HandleRef pThis);

		public void SetJustificationToRight()
		{
			vtkTextProperty.vtkTextProperty_SetJustificationToRight_52(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextProperty_SetLineOffset_53(HandleRef pThis, double _arg);

		public virtual void SetLineOffset(double _arg)
		{
			vtkTextProperty.vtkTextProperty_SetLineOffset_53(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextProperty_SetLineSpacing_54(HandleRef pThis, double _arg);

		public virtual void SetLineSpacing(double _arg)
		{
			vtkTextProperty.vtkTextProperty_SetLineSpacing_54(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextProperty_SetOpacity_55(HandleRef pThis, double _arg);

		public virtual void SetOpacity(double _arg)
		{
			vtkTextProperty.vtkTextProperty_SetOpacity_55(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextProperty_SetOrientation_56(HandleRef pThis, double _arg);

		public virtual void SetOrientation(double _arg)
		{
			vtkTextProperty.vtkTextProperty_SetOrientation_56(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextProperty_SetShadow_57(HandleRef pThis, int _arg);

		public virtual void SetShadow(int _arg)
		{
			vtkTextProperty.vtkTextProperty_SetShadow_57(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextProperty_SetShadowOffset_58(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetShadowOffset(int _arg1, int _arg2)
		{
			vtkTextProperty.vtkTextProperty_SetShadowOffset_58(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextProperty_SetShadowOffset_59(HandleRef pThis, IntPtr _arg);

		public void SetShadowOffset(IntPtr _arg)
		{
			vtkTextProperty.vtkTextProperty_SetShadowOffset_59(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextProperty_SetVerticalJustification_60(HandleRef pThis, int _arg);

		public virtual void SetVerticalJustification(int _arg)
		{
			vtkTextProperty.vtkTextProperty_SetVerticalJustification_60(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextProperty_SetVerticalJustificationToBottom_61(HandleRef pThis);

		public void SetVerticalJustificationToBottom()
		{
			vtkTextProperty.vtkTextProperty_SetVerticalJustificationToBottom_61(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextProperty_SetVerticalJustificationToCentered_62(HandleRef pThis);

		public void SetVerticalJustificationToCentered()
		{
			vtkTextProperty.vtkTextProperty_SetVerticalJustificationToCentered_62(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextProperty_SetVerticalJustificationToTop_63(HandleRef pThis);

		public void SetVerticalJustificationToTop()
		{
			vtkTextProperty.vtkTextProperty_SetVerticalJustificationToTop_63(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextProperty_ShadowOff_64(HandleRef pThis);

		public virtual void ShadowOff()
		{
			vtkTextProperty.vtkTextProperty_ShadowOff_64(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextProperty_ShadowOn_65(HandleRef pThis);

		public virtual void ShadowOn()
		{
			vtkTextProperty.vtkTextProperty_ShadowOn_65(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextProperty_ShallowCopy_66(HandleRef pThis, HandleRef tprop);

		public void ShallowCopy(vtkTextProperty tprop)
		{
			vtkTextProperty.vtkTextProperty_ShallowCopy_66(base.GetCppThis(), (tprop == null) ? default(HandleRef) : tprop.GetCppThis());
		}
	}
}
