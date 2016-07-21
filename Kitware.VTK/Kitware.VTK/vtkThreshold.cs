using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkThreshold : vtkUnstructuredGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkThreshold";

		public new static readonly string MRClassNameKey;

		static vtkThreshold()
		{
			vtkThreshold.MRClassNameKey = "class vtkThreshold";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkThreshold.MRClassNameKey, Type.GetType("Kitware.VTK.vtkThreshold"));
		}

		public vtkThreshold(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkThreshold_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkThreshold New()
		{
			vtkThreshold result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkThreshold.vtkThreshold_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkThreshold)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkThreshold() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkThreshold.vtkThreshold_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkThreshold_AllScalarsOff_01(HandleRef pThis);

		public virtual void AllScalarsOff()
		{
			vtkThreshold.vtkThreshold_AllScalarsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkThreshold_AllScalarsOn_02(HandleRef pThis);

		public virtual void AllScalarsOn()
		{
			vtkThreshold.vtkThreshold_AllScalarsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkThreshold_GetAllScalars_03(HandleRef pThis);

		public virtual int GetAllScalars()
		{
			return vtkThreshold.vtkThreshold_GetAllScalars_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkThreshold_GetAttributeMode_04(HandleRef pThis);

		public virtual int GetAttributeMode()
		{
			return vtkThreshold.vtkThreshold_GetAttributeMode_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkThreshold_GetAttributeModeAsString_05(HandleRef pThis);

		public string GetAttributeModeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkThreshold.vtkThreshold_GetAttributeModeAsString_05(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkThreshold_GetComponentMode_06(HandleRef pThis);

		public virtual int GetComponentMode()
		{
			return vtkThreshold.vtkThreshold_GetComponentMode_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkThreshold_GetComponentModeAsString_07(HandleRef pThis);

		public string GetComponentModeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkThreshold.vtkThreshold_GetComponentModeAsString_07(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkThreshold_GetComponentModeMaxValue_08(HandleRef pThis);

		public virtual int GetComponentModeMaxValue()
		{
			return vtkThreshold.vtkThreshold_GetComponentModeMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkThreshold_GetComponentModeMinValue_09(HandleRef pThis);

		public virtual int GetComponentModeMinValue()
		{
			return vtkThreshold.vtkThreshold_GetComponentModeMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkThreshold_GetLowerThreshold_10(HandleRef pThis);

		public virtual double GetLowerThreshold()
		{
			return vtkThreshold.vtkThreshold_GetLowerThreshold_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkThreshold_GetPointsDataType_11(HandleRef pThis);

		public virtual int GetPointsDataType()
		{
			return vtkThreshold.vtkThreshold_GetPointsDataType_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkThreshold_GetSelectedComponent_12(HandleRef pThis);

		public virtual int GetSelectedComponent()
		{
			return vtkThreshold.vtkThreshold_GetSelectedComponent_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkThreshold_GetSelectedComponentMaxValue_13(HandleRef pThis);

		public virtual int GetSelectedComponentMaxValue()
		{
			return vtkThreshold.vtkThreshold_GetSelectedComponentMaxValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkThreshold_GetSelectedComponentMinValue_14(HandleRef pThis);

		public virtual int GetSelectedComponentMinValue()
		{
			return vtkThreshold.vtkThreshold_GetSelectedComponentMinValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkThreshold_GetUpperThreshold_15(HandleRef pThis);

		public virtual double GetUpperThreshold()
		{
			return vtkThreshold.vtkThreshold_GetUpperThreshold_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkThreshold_IsA_16(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkThreshold.vtkThreshold_IsA_16(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkThreshold_IsTypeOf_17(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkThreshold.vtkThreshold_IsTypeOf_17(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkThreshold_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkThreshold NewInstance()
		{
			vtkThreshold result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkThreshold.vtkThreshold_NewInstance_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkThreshold)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkThreshold_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkThreshold SafeDownCast(vtkObjectBase o)
		{
			vtkThreshold vtkThreshold = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkThreshold.vtkThreshold_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkThreshold = (vtkThreshold)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkThreshold.Register(null);
				}
			}
			return vtkThreshold;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkThreshold_SetAllScalars_21(HandleRef pThis, int _arg);

		public virtual void SetAllScalars(int _arg)
		{
			vtkThreshold.vtkThreshold_SetAllScalars_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkThreshold_SetAttributeMode_22(HandleRef pThis, int _arg);

		public virtual void SetAttributeMode(int _arg)
		{
			vtkThreshold.vtkThreshold_SetAttributeMode_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkThreshold_SetAttributeModeToDefault_23(HandleRef pThis);

		public void SetAttributeModeToDefault()
		{
			vtkThreshold.vtkThreshold_SetAttributeModeToDefault_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkThreshold_SetAttributeModeToUseCellData_24(HandleRef pThis);

		public void SetAttributeModeToUseCellData()
		{
			vtkThreshold.vtkThreshold_SetAttributeModeToUseCellData_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkThreshold_SetAttributeModeToUsePointData_25(HandleRef pThis);

		public void SetAttributeModeToUsePointData()
		{
			vtkThreshold.vtkThreshold_SetAttributeModeToUsePointData_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkThreshold_SetComponentMode_26(HandleRef pThis, int _arg);

		public virtual void SetComponentMode(int _arg)
		{
			vtkThreshold.vtkThreshold_SetComponentMode_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkThreshold_SetComponentModeToUseAll_27(HandleRef pThis);

		public void SetComponentModeToUseAll()
		{
			vtkThreshold.vtkThreshold_SetComponentModeToUseAll_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkThreshold_SetComponentModeToUseAny_28(HandleRef pThis);

		public void SetComponentModeToUseAny()
		{
			vtkThreshold.vtkThreshold_SetComponentModeToUseAny_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkThreshold_SetComponentModeToUseSelected_29(HandleRef pThis);

		public void SetComponentModeToUseSelected()
		{
			vtkThreshold.vtkThreshold_SetComponentModeToUseSelected_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkThreshold_SetPointsDataType_30(HandleRef pThis, int _arg);

		public virtual void SetPointsDataType(int _arg)
		{
			vtkThreshold.vtkThreshold_SetPointsDataType_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkThreshold_SetPointsDataTypeToDouble_31(HandleRef pThis);

		public void SetPointsDataTypeToDouble()
		{
			vtkThreshold.vtkThreshold_SetPointsDataTypeToDouble_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkThreshold_SetPointsDataTypeToFloat_32(HandleRef pThis);

		public void SetPointsDataTypeToFloat()
		{
			vtkThreshold.vtkThreshold_SetPointsDataTypeToFloat_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkThreshold_SetSelectedComponent_33(HandleRef pThis, int _arg);

		public virtual void SetSelectedComponent(int _arg)
		{
			vtkThreshold.vtkThreshold_SetSelectedComponent_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkThreshold_ThresholdBetween_34(HandleRef pThis, double lower, double upper);

		public void ThresholdBetween(double lower, double upper)
		{
			vtkThreshold.vtkThreshold_ThresholdBetween_34(base.GetCppThis(), lower, upper);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkThreshold_ThresholdByLower_35(HandleRef pThis, double lower);

		public void ThresholdByLower(double lower)
		{
			vtkThreshold.vtkThreshold_ThresholdByLower_35(base.GetCppThis(), lower);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkThreshold_ThresholdByUpper_36(HandleRef pThis, double upper);

		public void ThresholdByUpper(double upper)
		{
			vtkThreshold.vtkThreshold_ThresholdByUpper_36(base.GetCppThis(), upper);
		}
	}
}
