using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkArrayCalculator : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkArrayCalculator";

		public new static readonly string MRClassNameKey;

		static vtkArrayCalculator()
		{
			vtkArrayCalculator.MRClassNameKey = "class vtkArrayCalculator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkArrayCalculator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkArrayCalculator"));
		}

		public vtkArrayCalculator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkArrayCalculator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkArrayCalculator New()
		{
			vtkArrayCalculator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArrayCalculator.vtkArrayCalculator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArrayCalculator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkArrayCalculator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkArrayCalculator.vtkArrayCalculator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArrayCalculator_AddCoordinateScalarVariable_01(HandleRef pThis, string variableName, int component);

		public void AddCoordinateScalarVariable(string variableName, int component)
		{
			vtkArrayCalculator.vtkArrayCalculator_AddCoordinateScalarVariable_01(base.GetCppThis(), variableName, component);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArrayCalculator_AddCoordinateVectorVariable_02(HandleRef pThis, string variableName, int component0, int component1, int component2);

		public void AddCoordinateVectorVariable(string variableName, int component0, int component1, int component2)
		{
			vtkArrayCalculator.vtkArrayCalculator_AddCoordinateVectorVariable_02(base.GetCppThis(), variableName, component0, component1, component2);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArrayCalculator_AddScalarArrayName_03(HandleRef pThis, string arrayName, int component);

		public void AddScalarArrayName(string arrayName, int component)
		{
			vtkArrayCalculator.vtkArrayCalculator_AddScalarArrayName_03(base.GetCppThis(), arrayName, component);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArrayCalculator_AddScalarVariable_04(HandleRef pThis, string variableName, string arrayName, int component);

		public void AddScalarVariable(string variableName, string arrayName, int component)
		{
			vtkArrayCalculator.vtkArrayCalculator_AddScalarVariable_04(base.GetCppThis(), variableName, arrayName, component);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArrayCalculator_AddVectorArrayName_05(HandleRef pThis, string arrayName, int component0, int component1, int component2);

		public void AddVectorArrayName(string arrayName, int component0, int component1, int component2)
		{
			vtkArrayCalculator.vtkArrayCalculator_AddVectorArrayName_05(base.GetCppThis(), arrayName, component0, component1, component2);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArrayCalculator_AddVectorVariable_06(HandleRef pThis, string variableName, string arrayName, int component0, int component1, int component2);

		public void AddVectorVariable(string variableName, string arrayName, int component0, int component1, int component2)
		{
			vtkArrayCalculator.vtkArrayCalculator_AddVectorVariable_06(base.GetCppThis(), variableName, arrayName, component0, component1, component2);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArrayCalculator_CoordinateResultsOff_07(HandleRef pThis);

		public virtual void CoordinateResultsOff()
		{
			vtkArrayCalculator.vtkArrayCalculator_CoordinateResultsOff_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArrayCalculator_CoordinateResultsOn_08(HandleRef pThis);

		public virtual void CoordinateResultsOn()
		{
			vtkArrayCalculator.vtkArrayCalculator_CoordinateResultsOn_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkArrayCalculator_GetAttributeMode_09(HandleRef pThis);

		public virtual int GetAttributeMode()
		{
			return vtkArrayCalculator.vtkArrayCalculator_GetAttributeMode_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkArrayCalculator_GetAttributeModeAsString_10(HandleRef pThis);

		public string GetAttributeModeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkArrayCalculator.vtkArrayCalculator_GetAttributeModeAsString_10(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkArrayCalculator_GetCoordinateResults_11(HandleRef pThis);

		public virtual int GetCoordinateResults()
		{
			return vtkArrayCalculator.vtkArrayCalculator_GetCoordinateResults_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkArrayCalculator_GetFunction_12(HandleRef pThis);

		public virtual string GetFunction()
		{
			return Marshal.PtrToStringAnsi(vtkArrayCalculator.vtkArrayCalculator_GetFunction_12(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkArrayCalculator_GetNumberOfScalarArrays_13(HandleRef pThis);

		public virtual int GetNumberOfScalarArrays()
		{
			return vtkArrayCalculator.vtkArrayCalculator_GetNumberOfScalarArrays_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkArrayCalculator_GetNumberOfVectorArrays_14(HandleRef pThis);

		public virtual int GetNumberOfVectorArrays()
		{
			return vtkArrayCalculator.vtkArrayCalculator_GetNumberOfVectorArrays_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkArrayCalculator_GetReplaceInvalidValues_15(HandleRef pThis);

		public virtual int GetReplaceInvalidValues()
		{
			return vtkArrayCalculator.vtkArrayCalculator_GetReplaceInvalidValues_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkArrayCalculator_GetReplacementValue_16(HandleRef pThis);

		public virtual double GetReplacementValue()
		{
			return vtkArrayCalculator.vtkArrayCalculator_GetReplacementValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkArrayCalculator_GetResultArrayName_17(HandleRef pThis);

		public virtual string GetResultArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkArrayCalculator.vtkArrayCalculator_GetResultArrayName_17(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkArrayCalculator_GetResultArrayType_18(HandleRef pThis);

		public virtual int GetResultArrayType()
		{
			return vtkArrayCalculator.vtkArrayCalculator_GetResultArrayType_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkArrayCalculator_GetScalarArrayName_19(HandleRef pThis, int i);

		public string GetScalarArrayName(int i)
		{
			return Marshal.PtrToStringAnsi(vtkArrayCalculator.vtkArrayCalculator_GetScalarArrayName_19(base.GetCppThis(), i));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkArrayCalculator_GetScalarVariableName_20(HandleRef pThis, int i);

		public string GetScalarVariableName(int i)
		{
			return Marshal.PtrToStringAnsi(vtkArrayCalculator.vtkArrayCalculator_GetScalarVariableName_20(base.GetCppThis(), i));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkArrayCalculator_GetSelectedScalarComponent_21(HandleRef pThis, int i);

		public int GetSelectedScalarComponent(int i)
		{
			return vtkArrayCalculator.vtkArrayCalculator_GetSelectedScalarComponent_21(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkArrayCalculator_GetSelectedScalarComponents_22(HandleRef pThis);

		public IntPtr GetSelectedScalarComponents()
		{
			return vtkArrayCalculator.vtkArrayCalculator_GetSelectedScalarComponents_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkArrayCalculator_GetSelectedVectorComponents_23(HandleRef pThis, int i);

		public IntPtr GetSelectedVectorComponents(int i)
		{
			return vtkArrayCalculator.vtkArrayCalculator_GetSelectedVectorComponents_23(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkArrayCalculator_GetVectorArrayName_24(HandleRef pThis, int i);

		public string GetVectorArrayName(int i)
		{
			return Marshal.PtrToStringAnsi(vtkArrayCalculator.vtkArrayCalculator_GetVectorArrayName_24(base.GetCppThis(), i));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkArrayCalculator_GetVectorVariableName_25(HandleRef pThis, int i);

		public string GetVectorVariableName(int i)
		{
			return Marshal.PtrToStringAnsi(vtkArrayCalculator.vtkArrayCalculator_GetVectorVariableName_25(base.GetCppThis(), i));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkArrayCalculator_IsA_26(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkArrayCalculator.vtkArrayCalculator_IsA_26(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkArrayCalculator_IsTypeOf_27(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkArrayCalculator.vtkArrayCalculator_IsTypeOf_27(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkArrayCalculator_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkArrayCalculator NewInstance()
		{
			vtkArrayCalculator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArrayCalculator.vtkArrayCalculator_NewInstance_29(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArrayCalculator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArrayCalculator_RemoveAllVariables_30(HandleRef pThis);

		public void RemoveAllVariables()
		{
			vtkArrayCalculator.vtkArrayCalculator_RemoveAllVariables_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArrayCalculator_RemoveCoordinateScalarVariables_31(HandleRef pThis);

		public virtual void RemoveCoordinateScalarVariables()
		{
			vtkArrayCalculator.vtkArrayCalculator_RemoveCoordinateScalarVariables_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArrayCalculator_RemoveCoordinateVectorVariables_32(HandleRef pThis);

		public virtual void RemoveCoordinateVectorVariables()
		{
			vtkArrayCalculator.vtkArrayCalculator_RemoveCoordinateVectorVariables_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArrayCalculator_RemoveScalarVariables_33(HandleRef pThis);

		public virtual void RemoveScalarVariables()
		{
			vtkArrayCalculator.vtkArrayCalculator_RemoveScalarVariables_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArrayCalculator_RemoveVectorVariables_34(HandleRef pThis);

		public virtual void RemoveVectorVariables()
		{
			vtkArrayCalculator.vtkArrayCalculator_RemoveVectorVariables_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArrayCalculator_ReplaceInvalidValuesOff_35(HandleRef pThis);

		public virtual void ReplaceInvalidValuesOff()
		{
			vtkArrayCalculator.vtkArrayCalculator_ReplaceInvalidValuesOff_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArrayCalculator_ReplaceInvalidValuesOn_36(HandleRef pThis);

		public virtual void ReplaceInvalidValuesOn()
		{
			vtkArrayCalculator.vtkArrayCalculator_ReplaceInvalidValuesOn_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkArrayCalculator_SafeDownCast_37(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkArrayCalculator SafeDownCast(vtkObjectBase o)
		{
			vtkArrayCalculator vtkArrayCalculator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArrayCalculator.vtkArrayCalculator_SafeDownCast_37((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArrayCalculator = (vtkArrayCalculator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArrayCalculator.Register(null);
				}
			}
			return vtkArrayCalculator;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArrayCalculator_SetAttributeMode_38(HandleRef pThis, int _arg);

		public virtual void SetAttributeMode(int _arg)
		{
			vtkArrayCalculator.vtkArrayCalculator_SetAttributeMode_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArrayCalculator_SetAttributeModeToDefault_39(HandleRef pThis);

		public void SetAttributeModeToDefault()
		{
			vtkArrayCalculator.vtkArrayCalculator_SetAttributeModeToDefault_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArrayCalculator_SetAttributeModeToUseCellData_40(HandleRef pThis);

		public void SetAttributeModeToUseCellData()
		{
			vtkArrayCalculator.vtkArrayCalculator_SetAttributeModeToUseCellData_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArrayCalculator_SetAttributeModeToUseEdgeData_41(HandleRef pThis);

		public void SetAttributeModeToUseEdgeData()
		{
			vtkArrayCalculator.vtkArrayCalculator_SetAttributeModeToUseEdgeData_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArrayCalculator_SetAttributeModeToUsePointData_42(HandleRef pThis);

		public void SetAttributeModeToUsePointData()
		{
			vtkArrayCalculator.vtkArrayCalculator_SetAttributeModeToUsePointData_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArrayCalculator_SetAttributeModeToUseVertexData_43(HandleRef pThis);

		public void SetAttributeModeToUseVertexData()
		{
			vtkArrayCalculator.vtkArrayCalculator_SetAttributeModeToUseVertexData_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArrayCalculator_SetCoordinateResults_44(HandleRef pThis, int _arg);

		public virtual void SetCoordinateResults(int _arg)
		{
			vtkArrayCalculator.vtkArrayCalculator_SetCoordinateResults_44(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArrayCalculator_SetFunction_45(HandleRef pThis, string function);

		public virtual void SetFunction(string function)
		{
			vtkArrayCalculator.vtkArrayCalculator_SetFunction_45(base.GetCppThis(), function);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArrayCalculator_SetReplaceInvalidValues_46(HandleRef pThis, int _arg);

		public virtual void SetReplaceInvalidValues(int _arg)
		{
			vtkArrayCalculator.vtkArrayCalculator_SetReplaceInvalidValues_46(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArrayCalculator_SetReplacementValue_47(HandleRef pThis, double _arg);

		public virtual void SetReplacementValue(double _arg)
		{
			vtkArrayCalculator.vtkArrayCalculator_SetReplacementValue_47(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArrayCalculator_SetResultArrayName_48(HandleRef pThis, string name);

		public void SetResultArrayName(string name)
		{
			vtkArrayCalculator.vtkArrayCalculator_SetResultArrayName_48(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkArrayCalculator_SetResultArrayType_49(HandleRef pThis, int _arg);

		public virtual void SetResultArrayType(int _arg)
		{
			vtkArrayCalculator.vtkArrayCalculator_SetResultArrayType_49(base.GetCppThis(), _arg);
		}
	}
}
