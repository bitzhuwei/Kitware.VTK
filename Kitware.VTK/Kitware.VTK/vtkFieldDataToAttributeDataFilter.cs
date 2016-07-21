using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkFieldDataToAttributeDataFilter : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkFieldDataToAttributeDataFilter";

		public new static readonly string MRClassNameKey;

		static vtkFieldDataToAttributeDataFilter()
		{
			vtkFieldDataToAttributeDataFilter.MRClassNameKey = "class vtkFieldDataToAttributeDataFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFieldDataToAttributeDataFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFieldDataToAttributeDataFilter"));
		}

		public vtkFieldDataToAttributeDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkFieldDataToAttributeDataFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFieldDataToAttributeDataFilter New()
		{
			vtkFieldDataToAttributeDataFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFieldDataToAttributeDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkFieldDataToAttributeDataFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkFieldDataToAttributeDataFilter_ConstructArray_01(HandleRef da, int comp, HandleRef frray, int fieldComp, long min, long max, int normalize);

		public static int ConstructArray(vtkDataArray da, int comp, vtkDataArray frray, int fieldComp, long min, long max, int normalize)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_ConstructArray_01((da == null) ? default(HandleRef) : da.GetCppThis(), comp, (frray == null) ? default(HandleRef) : frray.GetCppThis(), fieldComp, min, max, normalize);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFieldDataToAttributeDataFilter_DefaultNormalizeOff_02(HandleRef pThis);

		public virtual void DefaultNormalizeOff()
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_DefaultNormalizeOff_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFieldDataToAttributeDataFilter_DefaultNormalizeOn_03(HandleRef pThis);

		public virtual void DefaultNormalizeOn()
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_DefaultNormalizeOn_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetDefaultNormalize_04(HandleRef pThis);

		public virtual int GetDefaultNormalize()
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetDefaultNormalize_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkFieldDataToAttributeDataFilter_GetFieldArray_05(HandleRef fd, string name, int comp, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkDataArray GetFieldArray(vtkFieldData fd, string name, int comp)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetFieldArray_05((fd == null) ? default(HandleRef) : fd.GetCppThis(), name, comp, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetInputField_06(HandleRef pThis);

		public virtual int GetInputField()
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetInputField_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetNormalComponentArrayComponent_07(HandleRef pThis, int comp);

		public int GetNormalComponentArrayComponent(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetNormalComponentArrayComponent_07(base.GetCppThis(), comp);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkFieldDataToAttributeDataFilter_GetNormalComponentArrayName_08(HandleRef pThis, int comp);

		public string GetNormalComponentArrayName(int comp)
		{
			return Marshal.PtrToStringAnsi(vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetNormalComponentArrayName_08(base.GetCppThis(), comp));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetNormalComponentMaxRange_09(HandleRef pThis, int comp);

		public int GetNormalComponentMaxRange(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetNormalComponentMaxRange_09(base.GetCppThis(), comp);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetNormalComponentMinRange_10(HandleRef pThis, int comp);

		public int GetNormalComponentMinRange(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetNormalComponentMinRange_10(base.GetCppThis(), comp);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetNormalComponentNormalizeFlag_11(HandleRef pThis, int comp);

		public int GetNormalComponentNormalizeFlag(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetNormalComponentNormalizeFlag_11(base.GetCppThis(), comp);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetOutputAttributeData_12(HandleRef pThis);

		public virtual int GetOutputAttributeData()
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetOutputAttributeData_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetScalarComponentArrayComponent_13(HandleRef pThis, int comp);

		public int GetScalarComponentArrayComponent(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetScalarComponentArrayComponent_13(base.GetCppThis(), comp);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkFieldDataToAttributeDataFilter_GetScalarComponentArrayName_14(HandleRef pThis, int comp);

		public string GetScalarComponentArrayName(int comp)
		{
			return Marshal.PtrToStringAnsi(vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetScalarComponentArrayName_14(base.GetCppThis(), comp));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetScalarComponentMaxRange_15(HandleRef pThis, int comp);

		public int GetScalarComponentMaxRange(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetScalarComponentMaxRange_15(base.GetCppThis(), comp);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetScalarComponentMinRange_16(HandleRef pThis, int comp);

		public int GetScalarComponentMinRange(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetScalarComponentMinRange_16(base.GetCppThis(), comp);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetScalarComponentNormalizeFlag_17(HandleRef pThis, int comp);

		public int GetScalarComponentNormalizeFlag(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetScalarComponentNormalizeFlag_17(base.GetCppThis(), comp);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetTCoordComponentArrayComponent_18(HandleRef pThis, int comp);

		public int GetTCoordComponentArrayComponent(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetTCoordComponentArrayComponent_18(base.GetCppThis(), comp);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkFieldDataToAttributeDataFilter_GetTCoordComponentArrayName_19(HandleRef pThis, int comp);

		public string GetTCoordComponentArrayName(int comp)
		{
			return Marshal.PtrToStringAnsi(vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetTCoordComponentArrayName_19(base.GetCppThis(), comp));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetTCoordComponentMaxRange_20(HandleRef pThis, int comp);

		public int GetTCoordComponentMaxRange(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetTCoordComponentMaxRange_20(base.GetCppThis(), comp);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetTCoordComponentMinRange_21(HandleRef pThis, int comp);

		public int GetTCoordComponentMinRange(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetTCoordComponentMinRange_21(base.GetCppThis(), comp);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetTCoordComponentNormalizeFlag_22(HandleRef pThis, int comp);

		public int GetTCoordComponentNormalizeFlag(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetTCoordComponentNormalizeFlag_22(base.GetCppThis(), comp);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetTensorComponentArrayComponent_23(HandleRef pThis, int comp);

		public int GetTensorComponentArrayComponent(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetTensorComponentArrayComponent_23(base.GetCppThis(), comp);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkFieldDataToAttributeDataFilter_GetTensorComponentArrayName_24(HandleRef pThis, int comp);

		public string GetTensorComponentArrayName(int comp)
		{
			return Marshal.PtrToStringAnsi(vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetTensorComponentArrayName_24(base.GetCppThis(), comp));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetTensorComponentMaxRange_25(HandleRef pThis, int comp);

		public int GetTensorComponentMaxRange(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetTensorComponentMaxRange_25(base.GetCppThis(), comp);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetTensorComponentMinRange_26(HandleRef pThis, int comp);

		public int GetTensorComponentMinRange(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetTensorComponentMinRange_26(base.GetCppThis(), comp);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetTensorComponentNormalizeFlag_27(HandleRef pThis, int comp);

		public int GetTensorComponentNormalizeFlag(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetTensorComponentNormalizeFlag_27(base.GetCppThis(), comp);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetVectorComponentArrayComponent_28(HandleRef pThis, int comp);

		public int GetVectorComponentArrayComponent(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetVectorComponentArrayComponent_28(base.GetCppThis(), comp);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkFieldDataToAttributeDataFilter_GetVectorComponentArrayName_29(HandleRef pThis, int comp);

		public string GetVectorComponentArrayName(int comp)
		{
			return Marshal.PtrToStringAnsi(vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetVectorComponentArrayName_29(base.GetCppThis(), comp));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetVectorComponentMaxRange_30(HandleRef pThis, int comp);

		public int GetVectorComponentMaxRange(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetVectorComponentMaxRange_30(base.GetCppThis(), comp);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetVectorComponentMinRange_31(HandleRef pThis, int comp);

		public int GetVectorComponentMinRange(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetVectorComponentMinRange_31(base.GetCppThis(), comp);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetVectorComponentNormalizeFlag_32(HandleRef pThis, int comp);

		public int GetVectorComponentNormalizeFlag(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetVectorComponentNormalizeFlag_32(base.GetCppThis(), comp);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkFieldDataToAttributeDataFilter_IsA_33(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_IsA_33(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkFieldDataToAttributeDataFilter_IsTypeOf_34(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_IsTypeOf_34(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkFieldDataToAttributeDataFilter_NewInstance_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkFieldDataToAttributeDataFilter NewInstance()
		{
			vtkFieldDataToAttributeDataFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_NewInstance_36(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFieldDataToAttributeDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkFieldDataToAttributeDataFilter_SafeDownCast_37(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFieldDataToAttributeDataFilter SafeDownCast(vtkObjectBase o)
		{
			vtkFieldDataToAttributeDataFilter vtkFieldDataToAttributeDataFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_SafeDownCast_37((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFieldDataToAttributeDataFilter = (vtkFieldDataToAttributeDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFieldDataToAttributeDataFilter.Register(null);
				}
			}
			return vtkFieldDataToAttributeDataFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFieldDataToAttributeDataFilter_SetDefaultNormalize_38(HandleRef pThis, int _arg);

		public virtual void SetDefaultNormalize(int _arg)
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_SetDefaultNormalize_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFieldDataToAttributeDataFilter_SetInputField_39(HandleRef pThis, int _arg);

		public virtual void SetInputField(int _arg)
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_SetInputField_39(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFieldDataToAttributeDataFilter_SetInputFieldToCellDataField_40(HandleRef pThis);

		public void SetInputFieldToCellDataField()
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_SetInputFieldToCellDataField_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFieldDataToAttributeDataFilter_SetInputFieldToDataObjectField_41(HandleRef pThis);

		public void SetInputFieldToDataObjectField()
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_SetInputFieldToDataObjectField_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFieldDataToAttributeDataFilter_SetInputFieldToPointDataField_42(HandleRef pThis);

		public void SetInputFieldToPointDataField()
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_SetInputFieldToPointDataField_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFieldDataToAttributeDataFilter_SetNormalComponent_43(HandleRef pThis, int comp, string arrayName, int arrayComp, int min, int max, int normalize);

		public void SetNormalComponent(int comp, string arrayName, int arrayComp, int min, int max, int normalize)
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_SetNormalComponent_43(base.GetCppThis(), comp, arrayName, arrayComp, min, max, normalize);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFieldDataToAttributeDataFilter_SetNormalComponent_44(HandleRef pThis, int comp, string arrayName, int arrayComp);

		public void SetNormalComponent(int comp, string arrayName, int arrayComp)
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_SetNormalComponent_44(base.GetCppThis(), comp, arrayName, arrayComp);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFieldDataToAttributeDataFilter_SetOutputAttributeData_45(HandleRef pThis, int _arg);

		public virtual void SetOutputAttributeData(int _arg)
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_SetOutputAttributeData_45(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFieldDataToAttributeDataFilter_SetOutputAttributeDataToCellData_46(HandleRef pThis);

		public void SetOutputAttributeDataToCellData()
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_SetOutputAttributeDataToCellData_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFieldDataToAttributeDataFilter_SetOutputAttributeDataToPointData_47(HandleRef pThis);

		public void SetOutputAttributeDataToPointData()
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_SetOutputAttributeDataToPointData_47(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFieldDataToAttributeDataFilter_SetScalarComponent_48(HandleRef pThis, int comp, string arrayName, int arrayComp, int min, int max, int normalize);

		public void SetScalarComponent(int comp, string arrayName, int arrayComp, int min, int max, int normalize)
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_SetScalarComponent_48(base.GetCppThis(), comp, arrayName, arrayComp, min, max, normalize);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFieldDataToAttributeDataFilter_SetScalarComponent_49(HandleRef pThis, int comp, string arrayName, int arrayComp);

		public void SetScalarComponent(int comp, string arrayName, int arrayComp)
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_SetScalarComponent_49(base.GetCppThis(), comp, arrayName, arrayComp);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFieldDataToAttributeDataFilter_SetTCoordComponent_50(HandleRef pThis, int comp, string arrayName, int arrayComp, int min, int max, int normalize);

		public void SetTCoordComponent(int comp, string arrayName, int arrayComp, int min, int max, int normalize)
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_SetTCoordComponent_50(base.GetCppThis(), comp, arrayName, arrayComp, min, max, normalize);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFieldDataToAttributeDataFilter_SetTCoordComponent_51(HandleRef pThis, int comp, string arrayName, int arrayComp);

		public void SetTCoordComponent(int comp, string arrayName, int arrayComp)
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_SetTCoordComponent_51(base.GetCppThis(), comp, arrayName, arrayComp);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFieldDataToAttributeDataFilter_SetTensorComponent_52(HandleRef pThis, int comp, string arrayName, int arrayComp, int min, int max, int normalize);

		public void SetTensorComponent(int comp, string arrayName, int arrayComp, int min, int max, int normalize)
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_SetTensorComponent_52(base.GetCppThis(), comp, arrayName, arrayComp, min, max, normalize);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFieldDataToAttributeDataFilter_SetTensorComponent_53(HandleRef pThis, int comp, string arrayName, int arrayComp);

		public void SetTensorComponent(int comp, string arrayName, int arrayComp)
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_SetTensorComponent_53(base.GetCppThis(), comp, arrayName, arrayComp);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFieldDataToAttributeDataFilter_SetVectorComponent_54(HandleRef pThis, int comp, string arrayName, int arrayComp, int min, int max, int normalize);

		public void SetVectorComponent(int comp, string arrayName, int arrayComp, int min, int max, int normalize)
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_SetVectorComponent_54(base.GetCppThis(), comp, arrayName, arrayComp, min, max, normalize);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFieldDataToAttributeDataFilter_SetVectorComponent_55(HandleRef pThis, int comp, string arrayName, int arrayComp);

		public void SetVectorComponent(int comp, string arrayName, int arrayComp)
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_SetVectorComponent_55(base.GetCppThis(), comp, arrayName, arrayComp);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkFieldDataToAttributeDataFilter_UpdateComponentRange_56(HandleRef da, IntPtr compRange);

		public static int UpdateComponentRange(vtkDataArray da, IntPtr compRange)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_UpdateComponentRange_56((da == null) ? default(HandleRef) : da.GetCppThis(), compRange);
		}
	}
}
