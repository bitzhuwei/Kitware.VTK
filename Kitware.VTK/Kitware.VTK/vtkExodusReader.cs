using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExodusReader : vtkUnstructuredGridAlgorithm
	{
		public enum ID_NOT_FOUND_WrapperEnum
		{
			ID_NOT_FOUND = -234121312,
			SEARCH_TYPE_ELEMENT = 0,
			SEARCH_TYPE_ELEMENT_THEN_NODE = 2,
			SEARCH_TYPE_NODE = 1,
			SEARCH_TYPE_NODE_THEN_ELEMENT = 3
		}

		public enum ArrayType
		{
			ASSEMBLY = 5,
			BLOCK = 2,
			CELL = 0,
			HIERARCHY = 6,
			MATERIAL = 4,
			NUM_ARRAY_TYPES = 7,
			PART = 3,
			POINT = 1,
			UNKNOWN_TYPE = 8
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkExodusReader";

		public new static readonly string MRClassNameKey;

		static vtkExodusReader()
		{
			vtkExodusReader.MRClassNameKey = "class vtkExodusReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExodusReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExodusReader"));
		}

		public vtkExodusReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExodusReader New()
		{
			vtkExodusReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExodusReader.vtkExodusReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExodusReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkExodusReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkExodusReader.vtkExodusReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_AddFilter_01(HandleRef pThis, HandleRef a_filter);

		public void AddFilter(vtkDSPFilterDefinition a_filter)
		{
			vtkExodusReader.vtkExodusReader_AddFilter_01(base.GetCppThis(), (a_filter == null) ? default(HandleRef) : a_filter.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_AddFilterDenominatorWeight_02(HandleRef pThis, double weight);

		public void AddFilterDenominatorWeight(double weight)
		{
			vtkExodusReader.vtkExodusReader_AddFilterDenominatorWeight_02(base.GetCppThis(), weight);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_AddFilterForwardNumeratorWeight_03(HandleRef pThis, double weight);

		public void AddFilterForwardNumeratorWeight(double weight)
		{
			vtkExodusReader.vtkExodusReader_AddFilterForwardNumeratorWeight_03(base.GetCppThis(), weight);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_AddFilterInputVar_04(HandleRef pThis, string name);

		public void AddFilterInputVar(string name)
		{
			vtkExodusReader.vtkExodusReader_AddFilterInputVar_04(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_AddFilterNumeratorWeight_05(HandleRef pThis, double weight);

		public void AddFilterNumeratorWeight(double weight)
		{
			vtkExodusReader.vtkExodusReader_AddFilterNumeratorWeight_05(base.GetCppThis(), weight);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_AddFilterOutputVar_06(HandleRef pThis, string name);

		public void AddFilterOutputVar(string name)
		{
			vtkExodusReader.vtkExodusReader_AddFilterOutputVar_06(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_ApplyDisplacementsOff_07(HandleRef pThis);

		public virtual void ApplyDisplacementsOff()
		{
			vtkExodusReader.vtkExodusReader_ApplyDisplacementsOff_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_ApplyDisplacementsOn_08(HandleRef pThis);

		public virtual void ApplyDisplacementsOn()
		{
			vtkExodusReader.vtkExodusReader_ApplyDisplacementsOn_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_CanReadFile_09(HandleRef pThis, string fname);

		public int CanReadFile(string fname)
		{
			return vtkExodusReader.vtkExodusReader_CanReadFile_09(base.GetCppThis(), fname);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_EnableDSPFiltering_10(HandleRef pThis);

		public void EnableDSPFiltering()
		{
			vtkExodusReader.vtkExodusReader_EnableDSPFiltering_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_ExodusModelMetadataOff_11(HandleRef pThis);

		public virtual void ExodusModelMetadataOff()
		{
			vtkExodusReader.vtkExodusReader_ExodusModelMetadataOff_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_ExodusModelMetadataOn_12(HandleRef pThis);

		public virtual void ExodusModelMetadataOn()
		{
			vtkExodusReader.vtkExodusReader_ExodusModelMetadataOn_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_FinishAddingFilter_13(HandleRef pThis);

		public void FinishAddingFilter()
		{
			vtkExodusReader.vtkExodusReader_FinishAddingFilter_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_GenerateBlockIdCellArrayOff_14(HandleRef pThis);

		public virtual void GenerateBlockIdCellArrayOff()
		{
			vtkExodusReader.vtkExodusReader_GenerateBlockIdCellArrayOff_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_GenerateBlockIdCellArrayOn_15(HandleRef pThis);

		public virtual void GenerateBlockIdCellArrayOn()
		{
			vtkExodusReader.vtkExodusReader_GenerateBlockIdCellArrayOn_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_GenerateGlobalElementIdArrayOff_16(HandleRef pThis);

		public virtual void GenerateGlobalElementIdArrayOff()
		{
			vtkExodusReader.vtkExodusReader_GenerateGlobalElementIdArrayOff_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_GenerateGlobalElementIdArrayOn_17(HandleRef pThis);

		public virtual void GenerateGlobalElementIdArrayOn()
		{
			vtkExodusReader.vtkExodusReader_GenerateGlobalElementIdArrayOn_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_GenerateGlobalNodeIdArrayOff_18(HandleRef pThis);

		public virtual void GenerateGlobalNodeIdArrayOff()
		{
			vtkExodusReader.vtkExodusReader_GenerateGlobalNodeIdArrayOff_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_GenerateGlobalNodeIdArrayOn_19(HandleRef pThis);

		public virtual void GenerateGlobalNodeIdArrayOn()
		{
			vtkExodusReader.vtkExodusReader_GenerateGlobalNodeIdArrayOn_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetApplyDisplacements_20(HandleRef pThis);

		public virtual int GetApplyDisplacements()
		{
			return vtkExodusReader.vtkExodusReader_GetApplyDisplacements_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusReader_GetArrayName_21(HandleRef pThis, vtkExodusReader.ArrayType type, int id);

		public string GetArrayName(vtkExodusReader.ArrayType type, int id)
		{
			return Marshal.PtrToStringAnsi(vtkExodusReader.vtkExodusReader_GetArrayName_21(base.GetCppThis(), type, id));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetArrayStatus_22(HandleRef pThis, vtkExodusReader.ArrayType type, string name);

		public int GetArrayStatus(vtkExodusReader.ArrayType type, string name)
		{
			return vtkExodusReader.vtkExodusReader_GetArrayStatus_22(base.GetCppThis(), type, name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetArrayStatus_23(HandleRef pThis, string type, string name);

		public int GetArrayStatus(string type, string name)
		{
			return vtkExodusReader.vtkExodusReader_GetArrayStatus_23(base.GetCppThis(), type, name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern vtkExodusReader.ArrayType vtkExodusReader_GetArrayTypeID_24(HandleRef pThis, string type);

		public vtkExodusReader.ArrayType GetArrayTypeID(string type)
		{
			return vtkExodusReader.vtkExodusReader_GetArrayTypeID_24(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusReader_GetArrayTypeName_25(vtkExodusReader.ArrayType type);

		public static string GetArrayTypeName(vtkExodusReader.ArrayType type)
		{
			return Marshal.PtrToStringAnsi(vtkExodusReader.vtkExodusReader_GetArrayTypeName_25(type));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetAssemblyArrayID_26(HandleRef pThis, string name);

		public int GetAssemblyArrayID(string name)
		{
			return vtkExodusReader.vtkExodusReader_GetAssemblyArrayID_26(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusReader_GetAssemblyArrayName_27(HandleRef pThis, int arrayIdx);

		public string GetAssemblyArrayName(int arrayIdx)
		{
			return Marshal.PtrToStringAnsi(vtkExodusReader.vtkExodusReader_GetAssemblyArrayName_27(base.GetCppThis(), arrayIdx));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetAssemblyArrayStatus_28(HandleRef pThis, int index);

		public int GetAssemblyArrayStatus(int index)
		{
			return vtkExodusReader.vtkExodusReader_GetAssemblyArrayStatus_28(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetAssemblyArrayStatus_29(HandleRef pThis, string arg0);

		public int GetAssemblyArrayStatus(string arg0)
		{
			return vtkExodusReader.vtkExodusReader_GetAssemblyArrayStatus_29(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetBlockArrayID_30(HandleRef pThis, string name);

		public int GetBlockArrayID(string name)
		{
			return vtkExodusReader.vtkExodusReader_GetBlockArrayID_30(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusReader_GetBlockArrayName_31(HandleRef pThis, int index);

		public string GetBlockArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkExodusReader.vtkExodusReader_GetBlockArrayName_31(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetBlockArrayStatus_32(HandleRef pThis, int index);

		public int GetBlockArrayStatus(int index)
		{
			return vtkExodusReader.vtkExodusReader_GetBlockArrayStatus_32(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetBlockArrayStatus_33(HandleRef pThis, string arg0);

		public int GetBlockArrayStatus(string arg0)
		{
			return vtkExodusReader.vtkExodusReader_GetBlockArrayStatus_33(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetBlockId_34(HandleRef pThis, int block_idx);

		public int GetBlockId(int block_idx)
		{
			return vtkExodusReader.vtkExodusReader_GetBlockId_34(base.GetCppThis(), block_idx);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusReader_GetBlockIdArrayName_35(HandleRef pThis);

		public string GetBlockIdArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkExodusReader.vtkExodusReader_GetBlockIdArrayName_35(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetCellArrayID_36(HandleRef pThis, string name);

		public int GetCellArrayID(string name)
		{
			return vtkExodusReader.vtkExodusReader_GetCellArrayID_36(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusReader_GetCellArrayName_37(HandleRef pThis, int index);

		public string GetCellArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkExodusReader.vtkExodusReader_GetCellArrayName_37(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetCellArrayNumberOfComponents_38(HandleRef pThis, int index);

		public int GetCellArrayNumberOfComponents(int index)
		{
			return vtkExodusReader.vtkExodusReader_GetCellArrayNumberOfComponents_38(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetCellArrayStatus_39(HandleRef pThis, int index);

		public int GetCellArrayStatus(int index)
		{
			return vtkExodusReader.vtkExodusReader_GetCellArrayStatus_39(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetCellArrayStatus_40(HandleRef pThis, string arg0);

		public int GetCellArrayStatus(string arg0)
		{
			return vtkExodusReader.vtkExodusReader_GetCellArrayStatus_40(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_GetDSPOutputArrays_41(HandleRef pThis, int exoid, HandleRef output);

		public void GetDSPOutputArrays(int exoid, vtkUnstructuredGrid output)
		{
			vtkExodusReader.vtkExodusReader_GetDSPOutputArrays_41(base.GetCppThis(), exoid, (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetDimensionality_42(HandleRef pThis);

		public virtual int GetDimensionality()
		{
			return vtkExodusReader.vtkExodusReader_GetDimensionality_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern float vtkExodusReader_GetDisplacementMagnitude_43(HandleRef pThis);

		public virtual float GetDisplacementMagnitude()
		{
			return vtkExodusReader.vtkExodusReader_GetDisplacementMagnitude_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetDisplayType_44(HandleRef pThis);

		public virtual int GetDisplayType()
		{
			return vtkExodusReader.vtkExodusReader_GetDisplayType_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusReader_GetExodusModel_45(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkExodusModel GetExodusModel()
		{
			vtkExodusModel vtkExodusModel = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExodusReader.vtkExodusReader_GetExodusModel_45(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExodusModel = (vtkExodusModel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExodusModel.Register(null);
				}
			}
			return vtkExodusModel;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetExodusModelMetadata_46(HandleRef pThis);

		public virtual int GetExodusModelMetadata()
		{
			return vtkExodusReader.vtkExodusReader_GetExodusModelMetadata_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusReader_GetFileName_47(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkExodusReader.vtkExodusReader_GetFileName_47(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetGenerateBlockIdCellArray_48(HandleRef pThis);

		public virtual int GetGenerateBlockIdCellArray()
		{
			return vtkExodusReader.vtkExodusReader_GetGenerateBlockIdCellArray_48(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetGenerateGlobalElementIdArray_49(HandleRef pThis);

		public virtual int GetGenerateGlobalElementIdArray()
		{
			return vtkExodusReader.vtkExodusReader_GetGenerateGlobalElementIdArray_49(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetGenerateGlobalNodeIdArray_50(HandleRef pThis);

		public virtual int GetGenerateGlobalNodeIdArray()
		{
			return vtkExodusReader.vtkExodusReader_GetGenerateGlobalNodeIdArray_50(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetGlobalElementID_51(HandleRef data, int localID);

		public static int GetGlobalElementID(vtkDataSet data, int localID)
		{
			return vtkExodusReader.vtkExodusReader_GetGlobalElementID_51((data == null) ? default(HandleRef) : data.GetCppThis(), localID);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetGlobalElementID_52(HandleRef data, int localID, int searchType);

		public static int GetGlobalElementID(vtkDataSet data, int localID, int searchType)
		{
			return vtkExodusReader.vtkExodusReader_GetGlobalElementID_52((data == null) ? default(HandleRef) : data.GetCppThis(), localID, searchType);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusReader_GetGlobalElementIdArrayName_53();

		public static string GetGlobalElementIdArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkExodusReader.vtkExodusReader_GetGlobalElementIdArrayName_53());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetGlobalNodeID_54(HandleRef data, int localID);

		public static int GetGlobalNodeID(vtkDataSet data, int localID)
		{
			return vtkExodusReader.vtkExodusReader_GetGlobalNodeID_54((data == null) ? default(HandleRef) : data.GetCppThis(), localID);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetGlobalNodeID_55(HandleRef data, int localID, int searchType);

		public static int GetGlobalNodeID(vtkDataSet data, int localID, int searchType)
		{
			return vtkExodusReader.vtkExodusReader_GetGlobalNodeID_55((data == null) ? default(HandleRef) : data.GetCppThis(), localID, searchType);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusReader_GetGlobalNodeIdArrayName_56();

		public static string GetGlobalNodeIdArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkExodusReader.vtkExodusReader_GetGlobalNodeIdArrayName_56());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetHasModeShapes_57(HandleRef pThis);

		public virtual int GetHasModeShapes()
		{
			return vtkExodusReader.vtkExodusReader_GetHasModeShapes_57(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusReader_GetHierarchyArrayName_58(HandleRef pThis, int arrayIdx);

		public string GetHierarchyArrayName(int arrayIdx)
		{
			return Marshal.PtrToStringAnsi(vtkExodusReader.vtkExodusReader_GetHierarchyArrayName_58(base.GetCppThis(), arrayIdx));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetHierarchyArrayStatus_59(HandleRef pThis, int index);

		public int GetHierarchyArrayStatus(int index)
		{
			return vtkExodusReader.vtkExodusReader_GetHierarchyArrayStatus_59(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetHierarchyArrayStatus_60(HandleRef pThis, string arg0);

		public int GetHierarchyArrayStatus(string arg0)
		{
			return vtkExodusReader.vtkExodusReader_GetHierarchyArrayStatus_60(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetMaterialArrayID_61(HandleRef pThis, string name);

		public int GetMaterialArrayID(string name)
		{
			return vtkExodusReader.vtkExodusReader_GetMaterialArrayID_61(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusReader_GetMaterialArrayName_62(HandleRef pThis, int arrayIdx);

		public string GetMaterialArrayName(int arrayIdx)
		{
			return Marshal.PtrToStringAnsi(vtkExodusReader.vtkExodusReader_GetMaterialArrayName_62(base.GetCppThis(), arrayIdx));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetMaterialArrayStatus_63(HandleRef pThis, int index);

		public int GetMaterialArrayStatus(int index)
		{
			return vtkExodusReader.vtkExodusReader_GetMaterialArrayStatus_63(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetMaterialArrayStatus_64(HandleRef pThis, string arg0);

		public int GetMaterialArrayStatus(string arg0)
		{
			return vtkExodusReader.vtkExodusReader_GetMaterialArrayStatus_64(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusReader_GetNodeSetArrayName_65(HandleRef pThis, int index);

		public string GetNodeSetArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkExodusReader.vtkExodusReader_GetNodeSetArrayName_65(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetNodeSetArrayStatus_66(HandleRef pThis, int index);

		public int GetNodeSetArrayStatus(int index)
		{
			return vtkExodusReader.vtkExodusReader_GetNodeSetArrayStatus_66(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetNodeSetArrayStatus_67(HandleRef pThis, string name);

		public int GetNodeSetArrayStatus(string name)
		{
			return vtkExodusReader.vtkExodusReader_GetNodeSetArrayStatus_67(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetNumberOfArrays_68(HandleRef pThis, vtkExodusReader.ArrayType type);

		public int GetNumberOfArrays(vtkExodusReader.ArrayType type)
		{
			return vtkExodusReader.vtkExodusReader_GetNumberOfArrays_68(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetNumberOfAssemblyArrays_69(HandleRef pThis);

		public int GetNumberOfAssemblyArrays()
		{
			return vtkExodusReader.vtkExodusReader_GetNumberOfAssemblyArrays_69(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetNumberOfBlockArrays_70(HandleRef pThis);

		public int GetNumberOfBlockArrays()
		{
			return vtkExodusReader.vtkExodusReader_GetNumberOfBlockArrays_70(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetNumberOfBlocks_71(HandleRef pThis);

		public virtual int GetNumberOfBlocks()
		{
			return vtkExodusReader.vtkExodusReader_GetNumberOfBlocks_71(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetNumberOfCellArrays_72(HandleRef pThis);

		public int GetNumberOfCellArrays()
		{
			return vtkExodusReader.vtkExodusReader_GetNumberOfCellArrays_72(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetNumberOfElements_73(HandleRef pThis);

		public int GetNumberOfElements()
		{
			return vtkExodusReader.vtkExodusReader_GetNumberOfElements_73(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetNumberOfElementsInBlock_74(HandleRef pThis, int block_idx);

		public int GetNumberOfElementsInBlock(int block_idx)
		{
			return vtkExodusReader.vtkExodusReader_GetNumberOfElementsInBlock_74(base.GetCppThis(), block_idx);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetNumberOfHierarchyArrays_75(HandleRef pThis);

		public int GetNumberOfHierarchyArrays()
		{
			return vtkExodusReader.vtkExodusReader_GetNumberOfHierarchyArrays_75(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetNumberOfMaterialArrays_76(HandleRef pThis);

		public int GetNumberOfMaterialArrays()
		{
			return vtkExodusReader.vtkExodusReader_GetNumberOfMaterialArrays_76(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetNumberOfNodeSetArrays_77(HandleRef pThis);

		public int GetNumberOfNodeSetArrays()
		{
			return vtkExodusReader.vtkExodusReader_GetNumberOfNodeSetArrays_77(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetNumberOfNodeSets_78(HandleRef pThis);

		public virtual int GetNumberOfNodeSets()
		{
			return vtkExodusReader.vtkExodusReader_GetNumberOfNodeSets_78(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetNumberOfNodes_79(HandleRef pThis);

		public int GetNumberOfNodes()
		{
			return vtkExodusReader.vtkExodusReader_GetNumberOfNodes_79(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetNumberOfPartArrays_80(HandleRef pThis);

		public int GetNumberOfPartArrays()
		{
			return vtkExodusReader.vtkExodusReader_GetNumberOfPartArrays_80(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetNumberOfPointArrays_81(HandleRef pThis);

		public int GetNumberOfPointArrays()
		{
			return vtkExodusReader.vtkExodusReader_GetNumberOfPointArrays_81(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetNumberOfSideSetArrays_82(HandleRef pThis);

		public int GetNumberOfSideSetArrays()
		{
			return vtkExodusReader.vtkExodusReader_GetNumberOfSideSetArrays_82(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetNumberOfSideSets_83(HandleRef pThis);

		public virtual int GetNumberOfSideSets()
		{
			return vtkExodusReader.vtkExodusReader_GetNumberOfSideSets_83(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetNumberOfTimeSteps_84(HandleRef pThis);

		public virtual int GetNumberOfTimeSteps()
		{
			return vtkExodusReader.vtkExodusReader_GetNumberOfTimeSteps_84(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetNumberOfVariableArrays_85(HandleRef pThis);

		public int GetNumberOfVariableArrays()
		{
			return vtkExodusReader.vtkExodusReader_GetNumberOfVariableArrays_85(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetPackExodusModelOntoOutput_86(HandleRef pThis);

		public virtual int GetPackExodusModelOntoOutput()
		{
			return vtkExodusReader.vtkExodusReader_GetPackExodusModelOntoOutput_86(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetPartArrayID_87(HandleRef pThis, string name);

		public int GetPartArrayID(string name)
		{
			return vtkExodusReader.vtkExodusReader_GetPartArrayID_87(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusReader_GetPartArrayName_88(HandleRef pThis, int arrayIdx);

		public string GetPartArrayName(int arrayIdx)
		{
			return Marshal.PtrToStringAnsi(vtkExodusReader.vtkExodusReader_GetPartArrayName_88(base.GetCppThis(), arrayIdx));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetPartArrayStatus_89(HandleRef pThis, int index);

		public int GetPartArrayStatus(int index)
		{
			return vtkExodusReader.vtkExodusReader_GetPartArrayStatus_89(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetPartArrayStatus_90(HandleRef pThis, string arg0);

		public int GetPartArrayStatus(string arg0)
		{
			return vtkExodusReader.vtkExodusReader_GetPartArrayStatus_90(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusReader_GetPartBlockInfo_91(HandleRef pThis, int arrayIdx);

		public string GetPartBlockInfo(int arrayIdx)
		{
			return Marshal.PtrToStringAnsi(vtkExodusReader.vtkExodusReader_GetPartBlockInfo_91(base.GetCppThis(), arrayIdx));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusReader_GetPedigreeElementIdArrayName_92();

		public static string GetPedigreeElementIdArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkExodusReader.vtkExodusReader_GetPedigreeElementIdArrayName_92());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusReader_GetPedigreeNodeIdArrayName_93();

		public static string GetPedigreeNodeIdArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkExodusReader.vtkExodusReader_GetPedigreeNodeIdArrayName_93());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetPointArrayID_94(HandleRef pThis, string name);

		public int GetPointArrayID(string name)
		{
			return vtkExodusReader.vtkExodusReader_GetPointArrayID_94(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusReader_GetPointArrayName_95(HandleRef pThis, int index);

		public string GetPointArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkExodusReader.vtkExodusReader_GetPointArrayName_95(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetPointArrayNumberOfComponents_96(HandleRef pThis, int index);

		public int GetPointArrayNumberOfComponents(int index)
		{
			return vtkExodusReader.vtkExodusReader_GetPointArrayNumberOfComponents_96(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetPointArrayStatus_97(HandleRef pThis, int index);

		public int GetPointArrayStatus(int index)
		{
			return vtkExodusReader.vtkExodusReader_GetPointArrayStatus_97(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetPointArrayStatus_98(HandleRef pThis, string arg0);

		public int GetPointArrayStatus(string arg0)
		{
			return vtkExodusReader.vtkExodusReader_GetPointArrayStatus_98(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusReader_GetSideSetArrayName_99(HandleRef pThis, int index);

		public string GetSideSetArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkExodusReader.vtkExodusReader_GetSideSetArrayName_99(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetSideSetArrayStatus_100(HandleRef pThis, int index);

		public int GetSideSetArrayStatus(int index)
		{
			return vtkExodusReader.vtkExodusReader_GetSideSetArrayStatus_100(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetSideSetArrayStatus_101(HandleRef pThis, string name);

		public int GetSideSetArrayStatus(string name)
		{
			return vtkExodusReader.vtkExodusReader_GetSideSetArrayStatus_101(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetTimeSeriesData_102(HandleRef pThis, int ID, string vName, string vType, HandleRef result);

		public int GetTimeSeriesData(int ID, string vName, string vType, vtkFloatArray result)
		{
			return vtkExodusReader.vtkExodusReader_GetTimeSeriesData_102(base.GetCppThis(), ID, vName, vType, (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetTimeStep_103(HandleRef pThis);

		public virtual int GetTimeStep()
		{
			return vtkExodusReader.vtkExodusReader_GetTimeStep_103(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusReader_GetTimeStepRange_104(HandleRef pThis);

		public virtual int[] GetTimeStepRange()
		{
			IntPtr intPtr = vtkExodusReader.vtkExodusReader_GetTimeStepRange_104(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_GetTimeStepRange_105(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetTimeStepRange(ref int _arg1, ref int _arg2)
		{
			vtkExodusReader.vtkExodusReader_GetTimeStepRange_105(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_GetTimeStepRange_106(HandleRef pThis, IntPtr _arg);

		public virtual void GetTimeStepRange(IntPtr _arg)
		{
			vtkExodusReader.vtkExodusReader_GetTimeStepRange_106(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusReader_GetTitle_107(HandleRef pThis);

		public virtual string GetTitle()
		{
			return Marshal.PtrToStringAnsi(vtkExodusReader.vtkExodusReader_GetTitle_107(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetTotalNumberOfElements_108(HandleRef pThis);

		public virtual int GetTotalNumberOfElements()
		{
			return vtkExodusReader.vtkExodusReader_GetTotalNumberOfElements_108(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetTotalNumberOfNodes_109(HandleRef pThis);

		public virtual int GetTotalNumberOfNodes()
		{
			return vtkExodusReader.vtkExodusReader_GetTotalNumberOfNodes_109(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusReader_GetVariableArrayName_110(HandleRef pThis, int a_which);

		public string GetVariableArrayName(int a_which)
		{
			return Marshal.PtrToStringAnsi(vtkExodusReader.vtkExodusReader_GetVariableArrayName_110(base.GetCppThis(), a_which));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_GetVariableID_111(HandleRef pThis, string type, string name);

		public int GetVariableID(string type, string name)
		{
			return vtkExodusReader.vtkExodusReader_GetVariableID_111(base.GetCppThis(), type, name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusReader_GetXMLFileName_112(HandleRef pThis);

		public virtual string GetXMLFileName()
		{
			return Marshal.PtrToStringAnsi(vtkExodusReader.vtkExodusReader_GetXMLFileName_112(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_HasModeShapesOff_113(HandleRef pThis);

		public virtual void HasModeShapesOff()
		{
			vtkExodusReader.vtkExodusReader_HasModeShapesOff_113(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_HasModeShapesOn_114(HandleRef pThis);

		public virtual void HasModeShapesOn()
		{
			vtkExodusReader.vtkExodusReader_HasModeShapesOn_114(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_IsA_115(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExodusReader.vtkExodusReader_IsA_115(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_IsTypeOf_116(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExodusReader.vtkExodusReader_IsTypeOf_116(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_IsValidVariable_117(HandleRef pThis, string type, string name);

		public int IsValidVariable(string type, string name)
		{
			return vtkExodusReader.vtkExodusReader_IsValidVariable_117(base.GetCppThis(), type, name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusReader_NewInstance_119(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExodusReader NewInstance()
		{
			vtkExodusReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExodusReader.vtkExodusReader_NewInstance_119(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExodusReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_PackExodusModelOntoOutputOff_120(HandleRef pThis);

		public virtual void PackExodusModelOntoOutputOff()
		{
			vtkExodusReader.vtkExodusReader_PackExodusModelOntoOutputOff_120(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_PackExodusModelOntoOutputOn_121(HandleRef pThis);

		public virtual void PackExodusModelOntoOutputOn()
		{
			vtkExodusReader.vtkExodusReader_PackExodusModelOntoOutputOn_121(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_RemoveFilter_122(HandleRef pThis, string a_outputVariableName);

		public void RemoveFilter(string a_outputVariableName)
		{
			vtkExodusReader.vtkExodusReader_RemoveFilter_122(base.GetCppThis(), a_outputVariableName);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusReader_SafeDownCast_123(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExodusReader SafeDownCast(vtkObjectBase o)
		{
			vtkExodusReader vtkExodusReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExodusReader.vtkExodusReader_SafeDownCast_123((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExodusReader = (vtkExodusReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExodusReader.Register(null);
				}
			}
			return vtkExodusReader;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetAllArrayStatus_124(HandleRef pThis, vtkExodusReader.ArrayType type, int flag);

		public void SetAllArrayStatus(vtkExodusReader.ArrayType type, int flag)
		{
			vtkExodusReader.vtkExodusReader_SetAllArrayStatus_124(base.GetCppThis(), type, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetAllAssemblyArrayStatus_125(HandleRef pThis, int status);

		public void SetAllAssemblyArrayStatus(int status)
		{
			vtkExodusReader.vtkExodusReader_SetAllAssemblyArrayStatus_125(base.GetCppThis(), status);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetAllBlockArrayStatus_126(HandleRef pThis, int status);

		public void SetAllBlockArrayStatus(int status)
		{
			vtkExodusReader.vtkExodusReader_SetAllBlockArrayStatus_126(base.GetCppThis(), status);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetAllCellArrayStatus_127(HandleRef pThis, int status);

		public void SetAllCellArrayStatus(int status)
		{
			vtkExodusReader.vtkExodusReader_SetAllCellArrayStatus_127(base.GetCppThis(), status);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetAllHierarchyArrayStatus_128(HandleRef pThis, int status);

		public void SetAllHierarchyArrayStatus(int status)
		{
			vtkExodusReader.vtkExodusReader_SetAllHierarchyArrayStatus_128(base.GetCppThis(), status);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetAllMaterialArrayStatus_129(HandleRef pThis, int status);

		public void SetAllMaterialArrayStatus(int status)
		{
			vtkExodusReader.vtkExodusReader_SetAllMaterialArrayStatus_129(base.GetCppThis(), status);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetAllPartArrayStatus_130(HandleRef pThis, int status);

		public void SetAllPartArrayStatus(int status)
		{
			vtkExodusReader.vtkExodusReader_SetAllPartArrayStatus_130(base.GetCppThis(), status);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetAllPointArrayStatus_131(HandleRef pThis, int status);

		public void SetAllPointArrayStatus(int status)
		{
			vtkExodusReader.vtkExodusReader_SetAllPointArrayStatus_131(base.GetCppThis(), status);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetApplyDisplacements_132(HandleRef pThis, int _arg);

		public virtual void SetApplyDisplacements(int _arg)
		{
			vtkExodusReader.vtkExodusReader_SetApplyDisplacements_132(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetArrayStatus_133(HandleRef pThis, vtkExodusReader.ArrayType type, string name, int flag);

		public void SetArrayStatus(vtkExodusReader.ArrayType type, string name, int flag)
		{
			vtkExodusReader.vtkExodusReader_SetArrayStatus_133(base.GetCppThis(), type, name, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetArrayStatus_134(HandleRef pThis, string type, string name, int flag);

		public void SetArrayStatus(string type, string name, int flag)
		{
			vtkExodusReader.vtkExodusReader_SetArrayStatus_134(base.GetCppThis(), type, name, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetAssemblyArrayStatus_135(HandleRef pThis, int index, int flag);

		public void SetAssemblyArrayStatus(int index, int flag)
		{
			vtkExodusReader.vtkExodusReader_SetAssemblyArrayStatus_135(base.GetCppThis(), index, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetAssemblyArrayStatus_136(HandleRef pThis, string arg0, int flag);

		public void SetAssemblyArrayStatus(string arg0, int flag)
		{
			vtkExodusReader.vtkExodusReader_SetAssemblyArrayStatus_136(base.GetCppThis(), arg0, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetBlockArrayStatus_137(HandleRef pThis, int index, int flag);

		public void SetBlockArrayStatus(int index, int flag)
		{
			vtkExodusReader.vtkExodusReader_SetBlockArrayStatus_137(base.GetCppThis(), index, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetBlockArrayStatus_138(HandleRef pThis, string arg0, int flag);

		public void SetBlockArrayStatus(string arg0, int flag)
		{
			vtkExodusReader.vtkExodusReader_SetBlockArrayStatus_138(base.GetCppThis(), arg0, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetCellArrayStatus_139(HandleRef pThis, int index, int flag);

		public void SetCellArrayStatus(int index, int flag)
		{
			vtkExodusReader.vtkExodusReader_SetCellArrayStatus_139(base.GetCppThis(), index, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetCellArrayStatus_140(HandleRef pThis, string arg0, int flag);

		public void SetCellArrayStatus(string arg0, int flag)
		{
			vtkExodusReader.vtkExodusReader_SetCellArrayStatus_140(base.GetCppThis(), arg0, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetDisplacementMagnitude_141(HandleRef pThis, float _arg);

		public virtual void SetDisplacementMagnitude(float _arg)
		{
			vtkExodusReader.vtkExodusReader_SetDisplacementMagnitude_141(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetDisplayType_142(HandleRef pThis, int type);

		public virtual void SetDisplayType(int type)
		{
			vtkExodusReader.vtkExodusReader_SetDisplayType_142(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetExodusModelMetadata_143(HandleRef pThis, int _arg);

		public virtual void SetExodusModelMetadata(int _arg)
		{
			vtkExodusReader.vtkExodusReader_SetExodusModelMetadata_143(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetFileName_144(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkExodusReader.vtkExodusReader_SetFileName_144(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetGenerateBlockIdCellArray_145(HandleRef pThis, int _arg);

		public virtual void SetGenerateBlockIdCellArray(int _arg)
		{
			vtkExodusReader.vtkExodusReader_SetGenerateBlockIdCellArray_145(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetGenerateGlobalElementIdArray_146(HandleRef pThis, int _arg);

		public virtual void SetGenerateGlobalElementIdArray(int _arg)
		{
			vtkExodusReader.vtkExodusReader_SetGenerateGlobalElementIdArray_146(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetGenerateGlobalNodeIdArray_147(HandleRef pThis, int _arg);

		public virtual void SetGenerateGlobalNodeIdArray(int _arg)
		{
			vtkExodusReader.vtkExodusReader_SetGenerateGlobalNodeIdArray_147(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetHasModeShapes_148(HandleRef pThis, int _arg);

		public virtual void SetHasModeShapes(int _arg)
		{
			vtkExodusReader.vtkExodusReader_SetHasModeShapes_148(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetHierarchyArrayStatus_149(HandleRef pThis, int index, int flag);

		public void SetHierarchyArrayStatus(int index, int flag)
		{
			vtkExodusReader.vtkExodusReader_SetHierarchyArrayStatus_149(base.GetCppThis(), index, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetHierarchyArrayStatus_150(HandleRef pThis, string arg0, int flag);

		public void SetHierarchyArrayStatus(string arg0, int flag)
		{
			vtkExodusReader.vtkExodusReader_SetHierarchyArrayStatus_150(base.GetCppThis(), arg0, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetMaterialArrayStatus_151(HandleRef pThis, int index, int flag);

		public void SetMaterialArrayStatus(int index, int flag)
		{
			vtkExodusReader.vtkExodusReader_SetMaterialArrayStatus_151(base.GetCppThis(), index, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetMaterialArrayStatus_152(HandleRef pThis, string arg0, int flag);

		public void SetMaterialArrayStatus(string arg0, int flag)
		{
			vtkExodusReader.vtkExodusReader_SetMaterialArrayStatus_152(base.GetCppThis(), arg0, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetNodeSetArrayStatus_153(HandleRef pThis, int index, int flag);

		public void SetNodeSetArrayStatus(int index, int flag)
		{
			vtkExodusReader.vtkExodusReader_SetNodeSetArrayStatus_153(base.GetCppThis(), index, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetNodeSetArrayStatus_154(HandleRef pThis, string name, int flag);

		public void SetNodeSetArrayStatus(string name, int flag)
		{
			vtkExodusReader.vtkExodusReader_SetNodeSetArrayStatus_154(base.GetCppThis(), name, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetPackExodusModelOntoOutput_155(HandleRef pThis, int _arg);

		public virtual void SetPackExodusModelOntoOutput(int _arg)
		{
			vtkExodusReader.vtkExodusReader_SetPackExodusModelOntoOutput_155(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetPartArrayStatus_156(HandleRef pThis, int index, int flag);

		public void SetPartArrayStatus(int index, int flag)
		{
			vtkExodusReader.vtkExodusReader_SetPartArrayStatus_156(base.GetCppThis(), index, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetPartArrayStatus_157(HandleRef pThis, string arg0, int flag);

		public void SetPartArrayStatus(string arg0, int flag)
		{
			vtkExodusReader.vtkExodusReader_SetPartArrayStatus_157(base.GetCppThis(), arg0, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetPointArrayStatus_158(HandleRef pThis, int index, int flag);

		public void SetPointArrayStatus(int index, int flag)
		{
			vtkExodusReader.vtkExodusReader_SetPointArrayStatus_158(base.GetCppThis(), index, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetPointArrayStatus_159(HandleRef pThis, string arg0, int flag);

		public void SetPointArrayStatus(string arg0, int flag)
		{
			vtkExodusReader.vtkExodusReader_SetPointArrayStatus_159(base.GetCppThis(), arg0, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetSideSetArrayStatus_160(HandleRef pThis, int index, int flag);

		public void SetSideSetArrayStatus(int index, int flag)
		{
			vtkExodusReader.vtkExodusReader_SetSideSetArrayStatus_160(base.GetCppThis(), index, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetSideSetArrayStatus_161(HandleRef pThis, string name, int flag);

		public void SetSideSetArrayStatus(string name, int flag)
		{
			vtkExodusReader.vtkExodusReader_SetSideSetArrayStatus_161(base.GetCppThis(), name, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetTimeStep_162(HandleRef pThis, int _arg);

		public virtual void SetTimeStep(int _arg)
		{
			vtkExodusReader.vtkExodusReader_SetTimeStep_162(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetTimeStepRange_163(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetTimeStepRange(int _arg1, int _arg2)
		{
			vtkExodusReader.vtkExodusReader_SetTimeStepRange_163(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetTimeStepRange_164(HandleRef pThis, IntPtr _arg);

		public void SetTimeStepRange(IntPtr _arg)
		{
			vtkExodusReader.vtkExodusReader_SetTimeStepRange_164(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_SetXMLFileName_165(HandleRef pThis, string _arg);

		public virtual void SetXMLFileName(string _arg)
		{
			vtkExodusReader.vtkExodusReader_SetXMLFileName_165(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_StartAddingFilter_166(HandleRef pThis);

		public void StartAddingFilter()
		{
			vtkExodusReader.vtkExodusReader_StartAddingFilter_166(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusReader_StrDupWithNew_167(string s);

		public static string StrDupWithNew(string s)
		{
			return Marshal.PtrToStringAnsi(vtkExodusReader.vtkExodusReader_StrDupWithNew_167(s));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusReader_StringUppercase_168(string str, string upperstr);

		public static void StringUppercase(string str, string upperstr)
		{
			vtkExodusReader.vtkExodusReader_StringUppercase_168(str, upperstr);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusReader_StringsEqual_169(string s1, string s2);

		public static int StringsEqual(string s1, string s2)
		{
			return vtkExodusReader.vtkExodusReader_StringsEqual_169(s1, s2);
		}
	}
}
