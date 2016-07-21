using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkFunctionParser : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkFunctionParser";

		public new static readonly string MRClassNameKey;

		static vtkFunctionParser()
		{
			vtkFunctionParser.MRClassNameKey = "class vtkFunctionParser";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFunctionParser.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFunctionParser"));
		}

		public vtkFunctionParser(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkFunctionParser_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFunctionParser New()
		{
			vtkFunctionParser result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFunctionParser.vtkFunctionParser_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFunctionParser)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkFunctionParser() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkFunctionParser.vtkFunctionParser_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkFunctionParser_GetFunction_01(HandleRef pThis);

		public virtual string GetFunction()
		{
			return Marshal.PtrToStringAnsi(vtkFunctionParser.vtkFunctionParser_GetFunction_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkFunctionParser_GetNumberOfScalarVariables_02(HandleRef pThis);

		public virtual int GetNumberOfScalarVariables()
		{
			return vtkFunctionParser.vtkFunctionParser_GetNumberOfScalarVariables_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkFunctionParser_GetNumberOfVectorVariables_03(HandleRef pThis);

		public virtual int GetNumberOfVectorVariables()
		{
			return vtkFunctionParser.vtkFunctionParser_GetNumberOfVectorVariables_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkFunctionParser_GetReplaceInvalidValues_04(HandleRef pThis);

		public virtual int GetReplaceInvalidValues()
		{
			return vtkFunctionParser.vtkFunctionParser_GetReplaceInvalidValues_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkFunctionParser_GetReplacementValue_05(HandleRef pThis);

		public virtual double GetReplacementValue()
		{
			return vtkFunctionParser.vtkFunctionParser_GetReplacementValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkFunctionParser_GetScalarResult_06(HandleRef pThis);

		public double GetScalarResult()
		{
			return vtkFunctionParser.vtkFunctionParser_GetScalarResult_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkFunctionParser_GetScalarVariableName_07(HandleRef pThis, int i);

		public string GetScalarVariableName(int i)
		{
			return Marshal.PtrToStringAnsi(vtkFunctionParser.vtkFunctionParser_GetScalarVariableName_07(base.GetCppThis(), i));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkFunctionParser_GetScalarVariableValue_08(HandleRef pThis, string variableName);

		public double GetScalarVariableValue(string variableName)
		{
			return vtkFunctionParser.vtkFunctionParser_GetScalarVariableValue_08(base.GetCppThis(), variableName);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkFunctionParser_GetScalarVariableValue_09(HandleRef pThis, int i);

		public double GetScalarVariableValue(int i)
		{
			return vtkFunctionParser.vtkFunctionParser_GetScalarVariableValue_09(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkFunctionParser_GetVectorResult_10(HandleRef pThis);

		public double[] GetVectorResult()
		{
			IntPtr intPtr = vtkFunctionParser.vtkFunctionParser_GetVectorResult_10(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkFunctionParser_GetVectorResult_11(HandleRef pThis, IntPtr result);

		public void GetVectorResult(IntPtr result)
		{
			vtkFunctionParser.vtkFunctionParser_GetVectorResult_11(base.GetCppThis(), result);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkFunctionParser_GetVectorVariableName_12(HandleRef pThis, int i);

		public string GetVectorVariableName(int i)
		{
			return Marshal.PtrToStringAnsi(vtkFunctionParser.vtkFunctionParser_GetVectorVariableName_12(base.GetCppThis(), i));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkFunctionParser_GetVectorVariableValue_13(HandleRef pThis, string variableName);

		public double[] GetVectorVariableValue(string variableName)
		{
			IntPtr intPtr = vtkFunctionParser.vtkFunctionParser_GetVectorVariableValue_13(base.GetCppThis(), variableName);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkFunctionParser_GetVectorVariableValue_14(HandleRef pThis, string variableName, IntPtr value);

		public void GetVectorVariableValue(string variableName, IntPtr value)
		{
			vtkFunctionParser.vtkFunctionParser_GetVectorVariableValue_14(base.GetCppThis(), variableName, value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkFunctionParser_GetVectorVariableValue_15(HandleRef pThis, int i);

		public double[] GetVectorVariableValue(int i)
		{
			IntPtr intPtr = vtkFunctionParser.vtkFunctionParser_GetVectorVariableValue_15(base.GetCppThis(), i);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkFunctionParser_GetVectorVariableValue_16(HandleRef pThis, int i, IntPtr value);

		public void GetVectorVariableValue(int i, IntPtr value)
		{
			vtkFunctionParser.vtkFunctionParser_GetVectorVariableValue_16(base.GetCppThis(), i, value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkFunctionParser_IsA_17(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkFunctionParser.vtkFunctionParser_IsA_17(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkFunctionParser_IsScalarResult_18(HandleRef pThis);

		public int IsScalarResult()
		{
			return vtkFunctionParser.vtkFunctionParser_IsScalarResult_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkFunctionParser_IsTypeOf_19(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkFunctionParser.vtkFunctionParser_IsTypeOf_19(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkFunctionParser_IsVectorResult_20(HandleRef pThis);

		public int IsVectorResult()
		{
			return vtkFunctionParser.vtkFunctionParser_IsVectorResult_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkFunctionParser_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkFunctionParser NewInstance()
		{
			vtkFunctionParser result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFunctionParser.vtkFunctionParser_NewInstance_22(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFunctionParser)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkFunctionParser_RemoveAllVariables_23(HandleRef pThis);

		public void RemoveAllVariables()
		{
			vtkFunctionParser.vtkFunctionParser_RemoveAllVariables_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkFunctionParser_RemoveScalarVariables_24(HandleRef pThis);

		public void RemoveScalarVariables()
		{
			vtkFunctionParser.vtkFunctionParser_RemoveScalarVariables_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkFunctionParser_RemoveVectorVariables_25(HandleRef pThis);

		public void RemoveVectorVariables()
		{
			vtkFunctionParser.vtkFunctionParser_RemoveVectorVariables_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkFunctionParser_ReplaceInvalidValuesOff_26(HandleRef pThis);

		public virtual void ReplaceInvalidValuesOff()
		{
			vtkFunctionParser.vtkFunctionParser_ReplaceInvalidValuesOff_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkFunctionParser_ReplaceInvalidValuesOn_27(HandleRef pThis);

		public virtual void ReplaceInvalidValuesOn()
		{
			vtkFunctionParser.vtkFunctionParser_ReplaceInvalidValuesOn_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkFunctionParser_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFunctionParser SafeDownCast(vtkObjectBase o)
		{
			vtkFunctionParser vtkFunctionParser = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFunctionParser.vtkFunctionParser_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFunctionParser = (vtkFunctionParser)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFunctionParser.Register(null);
				}
			}
			return vtkFunctionParser;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkFunctionParser_SetFunction_29(HandleRef pThis, string function);

		public void SetFunction(string function)
		{
			vtkFunctionParser.vtkFunctionParser_SetFunction_29(base.GetCppThis(), function);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkFunctionParser_SetReplaceInvalidValues_30(HandleRef pThis, int _arg);

		public virtual void SetReplaceInvalidValues(int _arg)
		{
			vtkFunctionParser.vtkFunctionParser_SetReplaceInvalidValues_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkFunctionParser_SetReplacementValue_31(HandleRef pThis, double _arg);

		public virtual void SetReplacementValue(double _arg)
		{
			vtkFunctionParser.vtkFunctionParser_SetReplacementValue_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkFunctionParser_SetScalarVariableValue_32(HandleRef pThis, string variableName, double value);

		public void SetScalarVariableValue(string variableName, double value)
		{
			vtkFunctionParser.vtkFunctionParser_SetScalarVariableValue_32(base.GetCppThis(), variableName, value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkFunctionParser_SetScalarVariableValue_33(HandleRef pThis, int i, double value);

		public void SetScalarVariableValue(int i, double value)
		{
			vtkFunctionParser.vtkFunctionParser_SetScalarVariableValue_33(base.GetCppThis(), i, value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkFunctionParser_SetVectorVariableValue_34(HandleRef pThis, string variableName, double xValue, double yValue, double zValue);

		public void SetVectorVariableValue(string variableName, double xValue, double yValue, double zValue)
		{
			vtkFunctionParser.vtkFunctionParser_SetVectorVariableValue_34(base.GetCppThis(), variableName, xValue, yValue, zValue);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkFunctionParser_SetVectorVariableValue_35(HandleRef pThis, string variableName, IntPtr values);

		public void SetVectorVariableValue(string variableName, IntPtr values)
		{
			vtkFunctionParser.vtkFunctionParser_SetVectorVariableValue_35(base.GetCppThis(), variableName, values);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkFunctionParser_SetVectorVariableValue_36(HandleRef pThis, int i, double xValue, double yValue, double zValue);

		public void SetVectorVariableValue(int i, double xValue, double yValue, double zValue)
		{
			vtkFunctionParser.vtkFunctionParser_SetVectorVariableValue_36(base.GetCppThis(), i, xValue, yValue, zValue);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkFunctionParser_SetVectorVariableValue_37(HandleRef pThis, int i, IntPtr values);

		public void SetVectorVariableValue(int i, IntPtr values)
		{
			vtkFunctionParser.vtkFunctionParser_SetVectorVariableValue_37(base.GetCppThis(), i, values);
		}
	}
}
