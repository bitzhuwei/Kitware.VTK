using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRandomAttributeGenerator : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRandomAttributeGenerator";

		public new static readonly string MRClassNameKey;

		static vtkRandomAttributeGenerator()
		{
			vtkRandomAttributeGenerator.MRClassNameKey = "class vtkRandomAttributeGenerator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRandomAttributeGenerator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRandomAttributeGenerator"));
		}

		public vtkRandomAttributeGenerator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRandomAttributeGenerator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRandomAttributeGenerator New()
		{
			vtkRandomAttributeGenerator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRandomAttributeGenerator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRandomAttributeGenerator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_GenerateAllCellDataOff_01(HandleRef pThis);

		public void GenerateAllCellDataOff()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateAllCellDataOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_GenerateAllCellDataOn_02(HandleRef pThis);

		public void GenerateAllCellDataOn()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateAllCellDataOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_GenerateAllDataOff_03(HandleRef pThis);

		public void GenerateAllDataOff()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateAllDataOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_GenerateAllDataOn_04(HandleRef pThis);

		public void GenerateAllDataOn()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateAllDataOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_GenerateAllPointDataOff_05(HandleRef pThis);

		public void GenerateAllPointDataOff()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateAllPointDataOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_GenerateAllPointDataOn_06(HandleRef pThis);

		public void GenerateAllPointDataOn()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateAllPointDataOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_GenerateCellArrayOff_07(HandleRef pThis);

		public virtual void GenerateCellArrayOff()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateCellArrayOff_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_GenerateCellArrayOn_08(HandleRef pThis);

		public virtual void GenerateCellArrayOn()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateCellArrayOn_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_GenerateCellNormalsOff_09(HandleRef pThis);

		public virtual void GenerateCellNormalsOff()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateCellNormalsOff_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_GenerateCellNormalsOn_10(HandleRef pThis);

		public virtual void GenerateCellNormalsOn()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateCellNormalsOn_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_GenerateCellScalarsOff_11(HandleRef pThis);

		public virtual void GenerateCellScalarsOff()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateCellScalarsOff_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_GenerateCellScalarsOn_12(HandleRef pThis);

		public virtual void GenerateCellScalarsOn()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateCellScalarsOn_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_GenerateCellTCoordsOff_13(HandleRef pThis);

		public virtual void GenerateCellTCoordsOff()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateCellTCoordsOff_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_GenerateCellTCoordsOn_14(HandleRef pThis);

		public virtual void GenerateCellTCoordsOn()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateCellTCoordsOn_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_GenerateCellTensorsOff_15(HandleRef pThis);

		public virtual void GenerateCellTensorsOff()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateCellTensorsOff_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_GenerateCellTensorsOn_16(HandleRef pThis);

		public virtual void GenerateCellTensorsOn()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateCellTensorsOn_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_GenerateCellVectorsOff_17(HandleRef pThis);

		public virtual void GenerateCellVectorsOff()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateCellVectorsOff_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_GenerateCellVectorsOn_18(HandleRef pThis);

		public virtual void GenerateCellVectorsOn()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateCellVectorsOn_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_GenerateFieldArrayOff_19(HandleRef pThis);

		public virtual void GenerateFieldArrayOff()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateFieldArrayOff_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_GenerateFieldArrayOn_20(HandleRef pThis);

		public virtual void GenerateFieldArrayOn()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateFieldArrayOn_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_GeneratePointArrayOff_21(HandleRef pThis);

		public virtual void GeneratePointArrayOff()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GeneratePointArrayOff_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_GeneratePointArrayOn_22(HandleRef pThis);

		public virtual void GeneratePointArrayOn()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GeneratePointArrayOn_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_GeneratePointNormalsOff_23(HandleRef pThis);

		public virtual void GeneratePointNormalsOff()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GeneratePointNormalsOff_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_GeneratePointNormalsOn_24(HandleRef pThis);

		public virtual void GeneratePointNormalsOn()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GeneratePointNormalsOn_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_GeneratePointScalarsOff_25(HandleRef pThis);

		public virtual void GeneratePointScalarsOff()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GeneratePointScalarsOff_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_GeneratePointScalarsOn_26(HandleRef pThis);

		public virtual void GeneratePointScalarsOn()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GeneratePointScalarsOn_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_GeneratePointTCoordsOff_27(HandleRef pThis);

		public virtual void GeneratePointTCoordsOff()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GeneratePointTCoordsOff_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_GeneratePointTCoordsOn_28(HandleRef pThis);

		public virtual void GeneratePointTCoordsOn()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GeneratePointTCoordsOn_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_GeneratePointTensorsOff_29(HandleRef pThis);

		public virtual void GeneratePointTensorsOff()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GeneratePointTensorsOff_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_GeneratePointTensorsOn_30(HandleRef pThis);

		public virtual void GeneratePointTensorsOn()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GeneratePointTensorsOn_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_GeneratePointVectorsOff_31(HandleRef pThis);

		public virtual void GeneratePointVectorsOff()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GeneratePointVectorsOff_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_GeneratePointVectorsOn_32(HandleRef pThis);

		public virtual void GeneratePointVectorsOn()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GeneratePointVectorsOn_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRandomAttributeGenerator_GetDataType_33(HandleRef pThis);

		public virtual int GetDataType()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetDataType_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRandomAttributeGenerator_GetGenerateCellArray_34(HandleRef pThis);

		public virtual int GetGenerateCellArray()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetGenerateCellArray_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRandomAttributeGenerator_GetGenerateCellNormals_35(HandleRef pThis);

		public virtual int GetGenerateCellNormals()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetGenerateCellNormals_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRandomAttributeGenerator_GetGenerateCellScalars_36(HandleRef pThis);

		public virtual int GetGenerateCellScalars()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetGenerateCellScalars_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRandomAttributeGenerator_GetGenerateCellTCoords_37(HandleRef pThis);

		public virtual int GetGenerateCellTCoords()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetGenerateCellTCoords_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRandomAttributeGenerator_GetGenerateCellTensors_38(HandleRef pThis);

		public virtual int GetGenerateCellTensors()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetGenerateCellTensors_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRandomAttributeGenerator_GetGenerateCellVectors_39(HandleRef pThis);

		public virtual int GetGenerateCellVectors()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetGenerateCellVectors_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRandomAttributeGenerator_GetGenerateFieldArray_40(HandleRef pThis);

		public virtual int GetGenerateFieldArray()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetGenerateFieldArray_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRandomAttributeGenerator_GetGeneratePointArray_41(HandleRef pThis);

		public virtual int GetGeneratePointArray()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetGeneratePointArray_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRandomAttributeGenerator_GetGeneratePointNormals_42(HandleRef pThis);

		public virtual int GetGeneratePointNormals()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetGeneratePointNormals_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRandomAttributeGenerator_GetGeneratePointScalars_43(HandleRef pThis);

		public virtual int GetGeneratePointScalars()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetGeneratePointScalars_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRandomAttributeGenerator_GetGeneratePointTCoords_44(HandleRef pThis);

		public virtual int GetGeneratePointTCoords()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetGeneratePointTCoords_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRandomAttributeGenerator_GetGeneratePointTensors_45(HandleRef pThis);

		public virtual int GetGeneratePointTensors()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetGeneratePointTensors_45(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRandomAttributeGenerator_GetGeneratePointVectors_46(HandleRef pThis);

		public virtual int GetGeneratePointVectors()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetGeneratePointVectors_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRandomAttributeGenerator_GetMaximumComponentValue_47(HandleRef pThis);

		public virtual double GetMaximumComponentValue()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetMaximumComponentValue_47(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRandomAttributeGenerator_GetMinimumComponentValue_48(HandleRef pThis);

		public virtual double GetMinimumComponentValue()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetMinimumComponentValue_48(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRandomAttributeGenerator_GetNumberOfComponents_49(HandleRef pThis);

		public virtual int GetNumberOfComponents()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetNumberOfComponents_49(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRandomAttributeGenerator_GetNumberOfComponentsMaxValue_50(HandleRef pThis);

		public virtual int GetNumberOfComponentsMaxValue()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetNumberOfComponentsMaxValue_50(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRandomAttributeGenerator_GetNumberOfComponentsMinValue_51(HandleRef pThis);

		public virtual int GetNumberOfComponentsMinValue()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetNumberOfComponentsMinValue_51(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkRandomAttributeGenerator_GetNumberOfTuples_52(HandleRef pThis);

		public virtual long GetNumberOfTuples()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetNumberOfTuples_52(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkRandomAttributeGenerator_GetNumberOfTuplesMaxValue_53(HandleRef pThis);

		public virtual long GetNumberOfTuplesMaxValue()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetNumberOfTuplesMaxValue_53(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkRandomAttributeGenerator_GetNumberOfTuplesMinValue_54(HandleRef pThis);

		public virtual long GetNumberOfTuplesMinValue()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetNumberOfTuplesMinValue_54(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRandomAttributeGenerator_IsA_55(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_IsA_55(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRandomAttributeGenerator_IsTypeOf_56(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_IsTypeOf_56(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRandomAttributeGenerator_NewInstance_58(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRandomAttributeGenerator NewInstance()
		{
			vtkRandomAttributeGenerator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_NewInstance_58(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRandomAttributeGenerator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRandomAttributeGenerator_SafeDownCast_59(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRandomAttributeGenerator SafeDownCast(vtkObjectBase o)
		{
			vtkRandomAttributeGenerator vtkRandomAttributeGenerator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SafeDownCast_59((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRandomAttributeGenerator = (vtkRandomAttributeGenerator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRandomAttributeGenerator.Register(null);
				}
			}
			return vtkRandomAttributeGenerator;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_SetDataType_60(HandleRef pThis, int _arg);

		public virtual void SetDataType(int _arg)
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetDataType_60(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_SetDataTypeToBit_61(HandleRef pThis);

		public void SetDataTypeToBit()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetDataTypeToBit_61(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_SetDataTypeToChar_62(HandleRef pThis);

		public void SetDataTypeToChar()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetDataTypeToChar_62(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_SetDataTypeToDouble_63(HandleRef pThis);

		public void SetDataTypeToDouble()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetDataTypeToDouble_63(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_SetDataTypeToFloat_64(HandleRef pThis);

		public void SetDataTypeToFloat()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetDataTypeToFloat_64(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_SetDataTypeToInt_65(HandleRef pThis);

		public void SetDataTypeToInt()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetDataTypeToInt_65(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_SetDataTypeToLong_66(HandleRef pThis);

		public void SetDataTypeToLong()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetDataTypeToLong_66(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_SetDataTypeToShort_67(HandleRef pThis);

		public void SetDataTypeToShort()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetDataTypeToShort_67(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_SetDataTypeToUnsignedChar_68(HandleRef pThis);

		public void SetDataTypeToUnsignedChar()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetDataTypeToUnsignedChar_68(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_SetDataTypeToUnsignedInt_69(HandleRef pThis);

		public void SetDataTypeToUnsignedInt()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetDataTypeToUnsignedInt_69(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_SetDataTypeToUnsignedLong_70(HandleRef pThis);

		public void SetDataTypeToUnsignedLong()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetDataTypeToUnsignedLong_70(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_SetDataTypeToUnsignedShort_71(HandleRef pThis);

		public void SetDataTypeToUnsignedShort()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetDataTypeToUnsignedShort_71(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_SetGenerateCellArray_72(HandleRef pThis, int _arg);

		public virtual void SetGenerateCellArray(int _arg)
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetGenerateCellArray_72(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_SetGenerateCellNormals_73(HandleRef pThis, int _arg);

		public virtual void SetGenerateCellNormals(int _arg)
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetGenerateCellNormals_73(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_SetGenerateCellScalars_74(HandleRef pThis, int _arg);

		public virtual void SetGenerateCellScalars(int _arg)
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetGenerateCellScalars_74(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_SetGenerateCellTCoords_75(HandleRef pThis, int _arg);

		public virtual void SetGenerateCellTCoords(int _arg)
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetGenerateCellTCoords_75(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_SetGenerateCellTensors_76(HandleRef pThis, int _arg);

		public virtual void SetGenerateCellTensors(int _arg)
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetGenerateCellTensors_76(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_SetGenerateCellVectors_77(HandleRef pThis, int _arg);

		public virtual void SetGenerateCellVectors(int _arg)
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetGenerateCellVectors_77(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_SetGenerateFieldArray_78(HandleRef pThis, int _arg);

		public virtual void SetGenerateFieldArray(int _arg)
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetGenerateFieldArray_78(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_SetGeneratePointArray_79(HandleRef pThis, int _arg);

		public virtual void SetGeneratePointArray(int _arg)
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetGeneratePointArray_79(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_SetGeneratePointNormals_80(HandleRef pThis, int _arg);

		public virtual void SetGeneratePointNormals(int _arg)
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetGeneratePointNormals_80(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_SetGeneratePointScalars_81(HandleRef pThis, int _arg);

		public virtual void SetGeneratePointScalars(int _arg)
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetGeneratePointScalars_81(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_SetGeneratePointTCoords_82(HandleRef pThis, int _arg);

		public virtual void SetGeneratePointTCoords(int _arg)
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetGeneratePointTCoords_82(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_SetGeneratePointTensors_83(HandleRef pThis, int _arg);

		public virtual void SetGeneratePointTensors(int _arg)
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetGeneratePointTensors_83(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_SetGeneratePointVectors_84(HandleRef pThis, int _arg);

		public virtual void SetGeneratePointVectors(int _arg)
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetGeneratePointVectors_84(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_SetMaximumComponentValue_85(HandleRef pThis, double _arg);

		public virtual void SetMaximumComponentValue(double _arg)
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetMaximumComponentValue_85(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_SetMinimumComponentValue_86(HandleRef pThis, double _arg);

		public virtual void SetMinimumComponentValue(double _arg)
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetMinimumComponentValue_86(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_SetNumberOfComponents_87(HandleRef pThis, int _arg);

		public virtual void SetNumberOfComponents(int _arg)
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetNumberOfComponents_87(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRandomAttributeGenerator_SetNumberOfTuples_88(HandleRef pThis, long _arg);

		public virtual void SetNumberOfTuples(long _arg)
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetNumberOfTuples_88(base.GetCppThis(), _arg);
		}
	}
}
