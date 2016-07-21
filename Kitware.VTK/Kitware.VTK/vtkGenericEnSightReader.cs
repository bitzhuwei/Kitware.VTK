using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGenericEnSightReader : vtkMultiBlockDataSetAlgorithm
	{
		public enum FILE_BIG_ENDIAN_WrapperEnum
		{
			FILE_BIG_ENDIAN,
			FILE_LITTLE_ENDIAN,
			FILE_UNKNOWN_ENDIAN
		}

		public enum FileTypes
		{
			ENSIGHT_6,
			ENSIGHT_6_BINARY,
			ENSIGHT_GOLD,
			ENSIGHT_GOLD_BINARY,
			ENSIGHT_MASTER_SERVER
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericEnSightReader";

		public new static readonly string MRClassNameKey;

		static vtkGenericEnSightReader()
		{
			vtkGenericEnSightReader.MRClassNameKey = "class vtkGenericEnSightReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericEnSightReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericEnSightReader"));
		}

		public vtkGenericEnSightReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericEnSightReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericEnSightReader New()
		{
			vtkGenericEnSightReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericEnSightReader.vtkGenericEnSightReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericEnSightReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGenericEnSightReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGenericEnSightReader.vtkGenericEnSightReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGenericEnSightReader_CanReadFile_01(string casefilename);

		public static int CanReadFile(string casefilename)
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_CanReadFile_01(casefilename);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGenericEnSightReader_DetermineEnSightVersion_02(HandleRef pThis, int quiet);

		public int DetermineEnSightVersion(int quiet)
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_DetermineEnSightVersion_02(base.GetCppThis(), quiet);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGenericEnSightReader_GetByteOrder_03(HandleRef pThis);

		public virtual int GetByteOrder()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetByteOrder_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericEnSightReader_GetByteOrderAsString_04(HandleRef pThis);

		public string GetByteOrderAsString()
		{
			return Marshal.PtrToStringAnsi(vtkGenericEnSightReader.vtkGenericEnSightReader_GetByteOrderAsString_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericEnSightReader_GetCaseFileName_05(HandleRef pThis);

		public virtual string GetCaseFileName()
		{
			return Marshal.PtrToStringAnsi(vtkGenericEnSightReader.vtkGenericEnSightReader_GetCaseFileName_05(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericEnSightReader_GetCellArrayName_06(HandleRef pThis, int index);

		public string GetCellArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkGenericEnSightReader.vtkGenericEnSightReader_GetCellArrayName_06(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGenericEnSightReader_GetCellArrayStatus_07(HandleRef pThis, string name);

		public int GetCellArrayStatus(string name)
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetCellArrayStatus_07(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericEnSightReader_GetCellDataArraySelection_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataArraySelection GetCellDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericEnSightReader.vtkGenericEnSightReader_GetCellDataArraySelection_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericEnSightReader_GetComplexDescription_09(HandleRef pThis, int n);

		public string GetComplexDescription(int n)
		{
			return Marshal.PtrToStringAnsi(vtkGenericEnSightReader.vtkGenericEnSightReader_GetComplexDescription_09(base.GetCppThis(), n));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGenericEnSightReader_GetComplexVariableType_10(HandleRef pThis, int n);

		public int GetComplexVariableType(int n)
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetComplexVariableType_10(base.GetCppThis(), n);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericEnSightReader_GetDescription_11(HandleRef pThis, int n);

		public string GetDescription(int n)
		{
			return Marshal.PtrToStringAnsi(vtkGenericEnSightReader.vtkGenericEnSightReader_GetDescription_11(base.GetCppThis(), n));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericEnSightReader_GetDescription_12(HandleRef pThis, int n, int type);

		public string GetDescription(int n, int type)
		{
			return Marshal.PtrToStringAnsi(vtkGenericEnSightReader.vtkGenericEnSightReader_GetDescription_12(base.GetCppThis(), n, type));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGenericEnSightReader_GetEnSightVersion_13(HandleRef pThis);

		public virtual int GetEnSightVersion()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetEnSightVersion_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericEnSightReader_GetFilePath_14(HandleRef pThis);

		public virtual string GetFilePath()
		{
			return Marshal.PtrToStringAnsi(vtkGenericEnSightReader.vtkGenericEnSightReader_GetFilePath_14(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericEnSightReader_GetGeometryFileName_15(HandleRef pThis);

		public virtual string GetGeometryFileName()
		{
			return Marshal.PtrToStringAnsi(vtkGenericEnSightReader.vtkGenericEnSightReader_GetGeometryFileName_15(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern float vtkGenericEnSightReader_GetMaximumTimeValue_16(HandleRef pThis);

		public virtual float GetMaximumTimeValue()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetMaximumTimeValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern float vtkGenericEnSightReader_GetMinimumTimeValue_17(HandleRef pThis);

		public virtual float GetMinimumTimeValue()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetMinimumTimeValue_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGenericEnSightReader_GetNumberOfCellArrays_18(HandleRef pThis);

		public int GetNumberOfCellArrays()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetNumberOfCellArrays_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGenericEnSightReader_GetNumberOfComplexScalarsPerElement_19(HandleRef pThis);

		public virtual int GetNumberOfComplexScalarsPerElement()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetNumberOfComplexScalarsPerElement_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGenericEnSightReader_GetNumberOfComplexScalarsPerNode_20(HandleRef pThis);

		public virtual int GetNumberOfComplexScalarsPerNode()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetNumberOfComplexScalarsPerNode_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGenericEnSightReader_GetNumberOfComplexVariables_21(HandleRef pThis);

		public virtual int GetNumberOfComplexVariables()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetNumberOfComplexVariables_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGenericEnSightReader_GetNumberOfComplexVectorsPerElement_22(HandleRef pThis);

		public virtual int GetNumberOfComplexVectorsPerElement()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetNumberOfComplexVectorsPerElement_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGenericEnSightReader_GetNumberOfComplexVectorsPerNode_23(HandleRef pThis);

		public virtual int GetNumberOfComplexVectorsPerNode()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetNumberOfComplexVectorsPerNode_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGenericEnSightReader_GetNumberOfPointArrays_24(HandleRef pThis);

		public int GetNumberOfPointArrays()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetNumberOfPointArrays_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGenericEnSightReader_GetNumberOfScalarsPerElement_25(HandleRef pThis);

		public virtual int GetNumberOfScalarsPerElement()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetNumberOfScalarsPerElement_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGenericEnSightReader_GetNumberOfScalarsPerMeasuredNode_26(HandleRef pThis);

		public virtual int GetNumberOfScalarsPerMeasuredNode()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetNumberOfScalarsPerMeasuredNode_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGenericEnSightReader_GetNumberOfScalarsPerNode_27(HandleRef pThis);

		public virtual int GetNumberOfScalarsPerNode()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetNumberOfScalarsPerNode_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGenericEnSightReader_GetNumberOfTensorsSymmPerElement_28(HandleRef pThis);

		public virtual int GetNumberOfTensorsSymmPerElement()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetNumberOfTensorsSymmPerElement_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGenericEnSightReader_GetNumberOfTensorsSymmPerNode_29(HandleRef pThis);

		public virtual int GetNumberOfTensorsSymmPerNode()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetNumberOfTensorsSymmPerNode_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGenericEnSightReader_GetNumberOfVariables_30(HandleRef pThis);

		public virtual int GetNumberOfVariables()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetNumberOfVariables_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGenericEnSightReader_GetNumberOfVariables_31(HandleRef pThis, int type);

		public int GetNumberOfVariables(int type)
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetNumberOfVariables_31(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGenericEnSightReader_GetNumberOfVectorsPerElement_32(HandleRef pThis);

		public virtual int GetNumberOfVectorsPerElement()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetNumberOfVectorsPerElement_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGenericEnSightReader_GetNumberOfVectorsPerMeasuredNode_33(HandleRef pThis);

		public virtual int GetNumberOfVectorsPerMeasuredNode()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetNumberOfVectorsPerMeasuredNode_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGenericEnSightReader_GetNumberOfVectorsPerNode_34(HandleRef pThis);

		public virtual int GetNumberOfVectorsPerNode()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetNumberOfVectorsPerNode_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGenericEnSightReader_GetParticleCoordinatesByIndex_35(HandleRef pThis);

		public virtual int GetParticleCoordinatesByIndex()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetParticleCoordinatesByIndex_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericEnSightReader_GetPointArrayName_36(HandleRef pThis, int index);

		public string GetPointArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkGenericEnSightReader.vtkGenericEnSightReader_GetPointArrayName_36(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGenericEnSightReader_GetPointArrayStatus_37(HandleRef pThis, string name);

		public int GetPointArrayStatus(string name)
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetPointArrayStatus_37(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericEnSightReader_GetPointDataArraySelection_38(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataArraySelection GetPointDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericEnSightReader.vtkGenericEnSightReader_GetPointDataArraySelection_38(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGenericEnSightReader_GetReadAllVariables_39(HandleRef pThis);

		public virtual int GetReadAllVariables()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetReadAllVariables_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericEnSightReader_GetReader_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkGenericEnSightReader GetReader()
		{
			vtkGenericEnSightReader vtkGenericEnSightReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericEnSightReader.vtkGenericEnSightReader_GetReader_40(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericEnSightReader = (vtkGenericEnSightReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericEnSightReader.Register(null);
				}
			}
			return vtkGenericEnSightReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericEnSightReader_GetTimeSets_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataArrayCollection GetTimeSets()
		{
			vtkDataArrayCollection vtkDataArrayCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericEnSightReader.vtkGenericEnSightReader_GetTimeSets_41(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArrayCollection = (vtkDataArrayCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArrayCollection.Register(null);
				}
			}
			return vtkDataArrayCollection;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern float vtkGenericEnSightReader_GetTimeValue_42(HandleRef pThis);

		public virtual float GetTimeValue()
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetTimeValue_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGenericEnSightReader_GetVariableType_43(HandleRef pThis, int n);

		public int GetVariableType(int n)
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_GetVariableType_43(base.GetCppThis(), n);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGenericEnSightReader_IsA_44(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_IsA_44(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkGenericEnSightReader_IsTypeOf_45(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGenericEnSightReader.vtkGenericEnSightReader_IsTypeOf_45(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericEnSightReader_NewInstance_47(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGenericEnSightReader NewInstance()
		{
			vtkGenericEnSightReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericEnSightReader.vtkGenericEnSightReader_NewInstance_47(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericEnSightReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkGenericEnSightReader_ParticleCoordinatesByIndexOff_48(HandleRef pThis);

		public virtual void ParticleCoordinatesByIndexOff()
		{
			vtkGenericEnSightReader.vtkGenericEnSightReader_ParticleCoordinatesByIndexOff_48(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkGenericEnSightReader_ParticleCoordinatesByIndexOn_49(HandleRef pThis);

		public virtual void ParticleCoordinatesByIndexOn()
		{
			vtkGenericEnSightReader.vtkGenericEnSightReader_ParticleCoordinatesByIndexOn_49(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkGenericEnSightReader_ReadAllVariablesOff_50(HandleRef pThis);

		public virtual void ReadAllVariablesOff()
		{
			vtkGenericEnSightReader.vtkGenericEnSightReader_ReadAllVariablesOff_50(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkGenericEnSightReader_ReadAllVariablesOn_51(HandleRef pThis);

		public virtual void ReadAllVariablesOn()
		{
			vtkGenericEnSightReader.vtkGenericEnSightReader_ReadAllVariablesOn_51(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericEnSightReader_SafeDownCast_52(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericEnSightReader SafeDownCast(vtkObjectBase o)
		{
			vtkGenericEnSightReader vtkGenericEnSightReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericEnSightReader.vtkGenericEnSightReader_SafeDownCast_52((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericEnSightReader = (vtkGenericEnSightReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericEnSightReader.Register(null);
				}
			}
			return vtkGenericEnSightReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkGenericEnSightReader_SetByteOrder_53(HandleRef pThis, int _arg);

		public virtual void SetByteOrder(int _arg)
		{
			vtkGenericEnSightReader.vtkGenericEnSightReader_SetByteOrder_53(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkGenericEnSightReader_SetByteOrderToBigEndian_54(HandleRef pThis);

		public void SetByteOrderToBigEndian()
		{
			vtkGenericEnSightReader.vtkGenericEnSightReader_SetByteOrderToBigEndian_54(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkGenericEnSightReader_SetByteOrderToLittleEndian_55(HandleRef pThis);

		public void SetByteOrderToLittleEndian()
		{
			vtkGenericEnSightReader.vtkGenericEnSightReader_SetByteOrderToLittleEndian_55(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkGenericEnSightReader_SetCaseFileName_56(HandleRef pThis, string fileName);

		public void SetCaseFileName(string fileName)
		{
			vtkGenericEnSightReader.vtkGenericEnSightReader_SetCaseFileName_56(base.GetCppThis(), fileName);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkGenericEnSightReader_SetCellArrayStatus_57(HandleRef pThis, string name, int status);

		public void SetCellArrayStatus(string name, int status)
		{
			vtkGenericEnSightReader.vtkGenericEnSightReader_SetCellArrayStatus_57(base.GetCppThis(), name, status);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkGenericEnSightReader_SetFilePath_58(HandleRef pThis, string _arg);

		public virtual void SetFilePath(string _arg)
		{
			vtkGenericEnSightReader.vtkGenericEnSightReader_SetFilePath_58(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkGenericEnSightReader_SetParticleCoordinatesByIndex_59(HandleRef pThis, int _arg);

		public virtual void SetParticleCoordinatesByIndex(int _arg)
		{
			vtkGenericEnSightReader.vtkGenericEnSightReader_SetParticleCoordinatesByIndex_59(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkGenericEnSightReader_SetPointArrayStatus_60(HandleRef pThis, string name, int status);

		public void SetPointArrayStatus(string name, int status)
		{
			vtkGenericEnSightReader.vtkGenericEnSightReader_SetPointArrayStatus_60(base.GetCppThis(), name, status);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkGenericEnSightReader_SetReadAllVariables_61(HandleRef pThis, int _arg);

		public virtual void SetReadAllVariables(int _arg)
		{
			vtkGenericEnSightReader.vtkGenericEnSightReader_SetReadAllVariables_61(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkGenericEnSightReader_SetTimeValue_62(HandleRef pThis, float value);

		public virtual void SetTimeValue(float value)
		{
			vtkGenericEnSightReader.vtkGenericEnSightReader_SetTimeValue_62(base.GetCppThis(), value);
		}
	}
}
