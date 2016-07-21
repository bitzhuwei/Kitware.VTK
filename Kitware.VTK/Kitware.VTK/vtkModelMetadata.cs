using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkModelMetadata : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkModelMetadata";

		public new static readonly string MRClassNameKey;

		static vtkModelMetadata()
		{
			vtkModelMetadata.MRClassNameKey = "class vtkModelMetadata";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkModelMetadata.MRClassNameKey, Type.GetType("Kitware.VTK.vtkModelMetadata"));
		}

		public vtkModelMetadata(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkModelMetadata New()
		{
			vtkModelMetadata result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkModelMetadata.vtkModelMetadata_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkModelMetadata)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkModelMetadata() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkModelMetadata.vtkModelMetadata_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_AddInformationLine_01(HandleRef pThis, string info);

		public void AddInformationLine(string info)
		{
			vtkModelMetadata.vtkModelMetadata_AddInformationLine_01(base.GetCppThis(), info);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_AddQARecord_02(HandleRef pThis, string name, string version, string date, string time);

		public void AddQARecord(string name, string version, string date, string time)
		{
			vtkModelMetadata.vtkModelMetadata_AddQARecord_02(base.GetCppThis(), name, version, date, time);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_AddUGridElementVariable_03(HandleRef pThis, string ugridVarName, string origName, int numComponents);

		public int AddUGridElementVariable(string ugridVarName, string origName, int numComponents)
		{
			return vtkModelMetadata.vtkModelMetadata_AddUGridElementVariable_03(base.GetCppThis(), ugridVarName, origName, numComponents);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_AddUGridNodeVariable_04(HandleRef pThis, string ugridVarName, string origName, int numComponents);

		public int AddUGridNodeVariable(string ugridVarName, string origName, int numComponents)
		{
			return vtkModelMetadata.vtkModelMetadata_AddUGridNodeVariable_04(base.GetCppThis(), ugridVarName, origName, numComponents);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_AllVariablesDefinedInAllBlocksOff_05(HandleRef pThis);

		public virtual void AllVariablesDefinedInAllBlocksOff()
		{
			vtkModelMetadata.vtkModelMetadata_AllVariablesDefinedInAllBlocksOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_AllVariablesDefinedInAllBlocksOn_06(HandleRef pThis);

		public virtual void AllVariablesDefinedInAllBlocksOn()
		{
			vtkModelMetadata.vtkModelMetadata_AllVariablesDefinedInAllBlocksOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_ElementVariableIsDefinedInBlock_07(HandleRef pThis, string varname, int blockId);

		public int ElementVariableIsDefinedInBlock(string varname, int blockId)
		{
			return vtkModelMetadata.vtkModelMetadata_ElementVariableIsDefinedInBlock_07(base.GetCppThis(), varname, blockId);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_ExtractGlobalMetadata_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkModelMetadata ExtractGlobalMetadata()
		{
			vtkModelMetadata vtkModelMetadata = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkModelMetadata.vtkModelMetadata_ExtractGlobalMetadata_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkModelMetadata = (vtkModelMetadata)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkModelMetadata.Register(null);
				}
			}
			return vtkModelMetadata;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_ExtractModelMetadata_09(HandleRef pThis, HandleRef globalCellIdList, HandleRef grid, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkModelMetadata ExtractModelMetadata(vtkIdTypeArray globalCellIdList, vtkDataSet grid)
		{
			vtkModelMetadata vtkModelMetadata = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkModelMetadata.vtkModelMetadata_ExtractModelMetadata_09(base.GetCppThis(), (globalCellIdList == null) ? default(HandleRef) : globalCellIdList.GetCppThis(), (grid == null) ? default(HandleRef) : grid.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkModelMetadata = (vtkModelMetadata)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkModelMetadata.Register(null);
				}
			}
			return vtkModelMetadata;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_FindOriginalElementVariableName_10(HandleRef pThis, string name, int component);

		public string FindOriginalElementVariableName(string name, int component)
		{
			return Marshal.PtrToStringAnsi(vtkModelMetadata.vtkModelMetadata_FindOriginalElementVariableName_10(base.GetCppThis(), name, component));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_FindOriginalNodeVariableName_11(HandleRef pThis, string name, int component);

		public string FindOriginalNodeVariableName(string name, int component)
		{
			return Marshal.PtrToStringAnsi(vtkModelMetadata.vtkModelMetadata_FindOriginalNodeVariableName_11(base.GetCppThis(), name, component));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_FreeAllGlobalData_12(HandleRef pThis);

		public void FreeAllGlobalData()
		{
			vtkModelMetadata.vtkModelMetadata_FreeAllGlobalData_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_FreeAllLocalData_13(HandleRef pThis);

		public void FreeAllLocalData()
		{
			vtkModelMetadata.vtkModelMetadata_FreeAllLocalData_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_FreeBlockDependentData_14(HandleRef pThis);

		public void FreeBlockDependentData()
		{
			vtkModelMetadata.vtkModelMetadata_FreeBlockDependentData_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_FreeOriginalElementVariableNames_15(HandleRef pThis);

		public void FreeOriginalElementVariableNames()
		{
			vtkModelMetadata.vtkModelMetadata_FreeOriginalElementVariableNames_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_FreeOriginalNodeVariableNames_16(HandleRef pThis);

		public void FreeOriginalNodeVariableNames()
		{
			vtkModelMetadata.vtkModelMetadata_FreeOriginalNodeVariableNames_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_FreeUsedElementVariableNames_17(HandleRef pThis);

		public void FreeUsedElementVariableNames()
		{
			vtkModelMetadata.vtkModelMetadata_FreeUsedElementVariableNames_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_FreeUsedElementVariables_18(HandleRef pThis);

		public void FreeUsedElementVariables()
		{
			vtkModelMetadata.vtkModelMetadata_FreeUsedElementVariables_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_FreeUsedNodeVariableNames_19(HandleRef pThis);

		public void FreeUsedNodeVariableNames()
		{
			vtkModelMetadata.vtkModelMetadata_FreeUsedNodeVariableNames_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_FreeUsedNodeVariables_20(HandleRef pThis);

		public void FreeUsedNodeVariables()
		{
			vtkModelMetadata.vtkModelMetadata_FreeUsedNodeVariables_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_GetAllVariablesDefinedInAllBlocks_21(HandleRef pThis);

		public int GetAllVariablesDefinedInAllBlocks()
		{
			return vtkModelMetadata.vtkModelMetadata_GetAllVariablesDefinedInAllBlocks_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_GetBlockAttributes_22(HandleRef pThis);

		public IntPtr GetBlockAttributes()
		{
			return vtkModelMetadata.vtkModelMetadata_GetBlockAttributes_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_GetBlockAttributesIndex_23(HandleRef pThis);

		public IntPtr GetBlockAttributesIndex()
		{
			return vtkModelMetadata.vtkModelMetadata_GetBlockAttributesIndex_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_GetBlockElementIdList_24(HandleRef pThis);

		public IntPtr GetBlockElementIdList()
		{
			return vtkModelMetadata.vtkModelMetadata_GetBlockElementIdList_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_GetBlockElementIdListIndex_25(HandleRef pThis);

		public IntPtr GetBlockElementIdListIndex()
		{
			return vtkModelMetadata.vtkModelMetadata_GetBlockElementIdListIndex_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_GetBlockIds_26(HandleRef pThis);

		public IntPtr GetBlockIds()
		{
			return vtkModelMetadata.vtkModelMetadata_GetBlockIds_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_GetBlockLocalIndex_27(HandleRef pThis, int id);

		public int GetBlockLocalIndex(int id)
		{
			return vtkModelMetadata.vtkModelMetadata_GetBlockLocalIndex_27(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_GetBlockNodesPerElement_28(HandleRef pThis);

		public IntPtr GetBlockNodesPerElement()
		{
			return vtkModelMetadata.vtkModelMetadata_GetBlockNodesPerElement_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_GetBlockNumberOfAttributesPerElement_29(HandleRef pThis);

		public IntPtr GetBlockNumberOfAttributesPerElement()
		{
			return vtkModelMetadata.vtkModelMetadata_GetBlockNumberOfAttributesPerElement_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_GetBlockNumberOfElements_30(HandleRef pThis);

		public IntPtr GetBlockNumberOfElements()
		{
			return vtkModelMetadata.vtkModelMetadata_GetBlockNumberOfElements_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_GetBlockPropertyValue_31(HandleRef pThis);

		public IntPtr GetBlockPropertyValue()
		{
			return vtkModelMetadata.vtkModelMetadata_GetBlockPropertyValue_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_GetDimension_32(HandleRef pThis);

		public int GetDimension()
		{
			return vtkModelMetadata.vtkModelMetadata_GetDimension_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_GetElementVariableNumberOfComponents_33(HandleRef pThis);

		public IntPtr GetElementVariableNumberOfComponents()
		{
			return vtkModelMetadata.vtkModelMetadata_GetElementVariableNumberOfComponents_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_GetElementVariableTruthTable_34(HandleRef pThis);

		public IntPtr GetElementVariableTruthTable()
		{
			return vtkModelMetadata.vtkModelMetadata_GetElementVariableTruthTable_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_GetGlobalVariableValue_35(HandleRef pThis);

		public IntPtr GetGlobalVariableValue()
		{
			return vtkModelMetadata.vtkModelMetadata_GetGlobalVariableValue_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_GetMapToOriginalElementVariableNames_36(HandleRef pThis);

		public IntPtr GetMapToOriginalElementVariableNames()
		{
			return vtkModelMetadata.vtkModelMetadata_GetMapToOriginalElementVariableNames_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_GetMapToOriginalNodeVariableNames_37(HandleRef pThis);

		public IntPtr GetMapToOriginalNodeVariableNames()
		{
			return vtkModelMetadata.vtkModelMetadata_GetMapToOriginalNodeVariableNames_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_GetNodeSetDistributionFactorIndex_38(HandleRef pThis);

		public IntPtr GetNodeSetDistributionFactorIndex()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNodeSetDistributionFactorIndex_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_GetNodeSetDistributionFactors_39(HandleRef pThis);

		public IntPtr GetNodeSetDistributionFactors()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNodeSetDistributionFactors_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_GetNodeSetIds_40(HandleRef pThis);

		public IntPtr GetNodeSetIds()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNodeSetIds_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_GetNodeSetNodeIdList_41(HandleRef pThis);

		public IntPtr GetNodeSetNodeIdList()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNodeSetNodeIdList_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_GetNodeSetNodeIdListIndex_42(HandleRef pThis);

		public IntPtr GetNodeSetNodeIdListIndex()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNodeSetNodeIdListIndex_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_GetNodeSetNumberOfDistributionFactors_43(HandleRef pThis);

		public IntPtr GetNodeSetNumberOfDistributionFactors()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNodeSetNumberOfDistributionFactors_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_GetNodeSetPropertyValue_44(HandleRef pThis);

		public IntPtr GetNodeSetPropertyValue()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNodeSetPropertyValue_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_GetNodeSetSize_45(HandleRef pThis);

		public IntPtr GetNodeSetSize()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNodeSetSize_45(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_GetNodeVariableNumberOfComponents_46(HandleRef pThis);

		public IntPtr GetNodeVariableNumberOfComponents()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNodeVariableNumberOfComponents_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_GetNumberOfBlockProperties_47(HandleRef pThis);

		public int GetNumberOfBlockProperties()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNumberOfBlockProperties_47(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_GetNumberOfBlocks_48(HandleRef pThis);

		public int GetNumberOfBlocks()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNumberOfBlocks_48(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_GetNumberOfElementVariables_49(HandleRef pThis);

		public int GetNumberOfElementVariables()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNumberOfElementVariables_49(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_GetNumberOfGlobalVariables_50(HandleRef pThis);

		public int GetNumberOfGlobalVariables()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNumberOfGlobalVariables_50(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_GetNumberOfInformationLines_51(HandleRef pThis);

		public int GetNumberOfInformationLines()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNumberOfInformationLines_51(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_GetNumberOfNodeSetProperties_52(HandleRef pThis);

		public int GetNumberOfNodeSetProperties()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNumberOfNodeSetProperties_52(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_GetNumberOfNodeSets_53(HandleRef pThis);

		public int GetNumberOfNodeSets()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNumberOfNodeSets_53(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_GetNumberOfNodeVariables_54(HandleRef pThis);

		public int GetNumberOfNodeVariables()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNumberOfNodeVariables_54(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_GetNumberOfQARecords_55(HandleRef pThis);

		public int GetNumberOfQARecords()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNumberOfQARecords_55(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_GetNumberOfSideSetProperties_56(HandleRef pThis);

		public int GetNumberOfSideSetProperties()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNumberOfSideSetProperties_56(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_GetNumberOfSideSets_57(HandleRef pThis);

		public int GetNumberOfSideSets()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNumberOfSideSets_57(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_GetNumberOfTimeSteps_58(HandleRef pThis);

		public int GetNumberOfTimeSteps()
		{
			return vtkModelMetadata.vtkModelMetadata_GetNumberOfTimeSteps_58(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_GetOriginalNumberOfElementVariables_59(HandleRef pThis);

		public int GetOriginalNumberOfElementVariables()
		{
			return vtkModelMetadata.vtkModelMetadata_GetOriginalNumberOfElementVariables_59(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_GetOriginalNumberOfNodeVariables_60(HandleRef pThis);

		public int GetOriginalNumberOfNodeVariables()
		{
			return vtkModelMetadata.vtkModelMetadata_GetOriginalNumberOfNodeVariables_60(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_GetSideSetDistributionFactorIndex_61(HandleRef pThis);

		public IntPtr GetSideSetDistributionFactorIndex()
		{
			return vtkModelMetadata.vtkModelMetadata_GetSideSetDistributionFactorIndex_61(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_GetSideSetDistributionFactors_62(HandleRef pThis);

		public IntPtr GetSideSetDistributionFactors()
		{
			return vtkModelMetadata.vtkModelMetadata_GetSideSetDistributionFactors_62(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_GetSideSetElementList_63(HandleRef pThis);

		public IntPtr GetSideSetElementList()
		{
			return vtkModelMetadata.vtkModelMetadata_GetSideSetElementList_63(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_GetSideSetIds_64(HandleRef pThis);

		public IntPtr GetSideSetIds()
		{
			return vtkModelMetadata.vtkModelMetadata_GetSideSetIds_64(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_GetSideSetListIndex_65(HandleRef pThis);

		public IntPtr GetSideSetListIndex()
		{
			return vtkModelMetadata.vtkModelMetadata_GetSideSetListIndex_65(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_GetSideSetNumDFPerSide_66(HandleRef pThis);

		public IntPtr GetSideSetNumDFPerSide()
		{
			return vtkModelMetadata.vtkModelMetadata_GetSideSetNumDFPerSide_66(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_GetSideSetNumberOfDistributionFactors_67(HandleRef pThis);

		public IntPtr GetSideSetNumberOfDistributionFactors()
		{
			return vtkModelMetadata.vtkModelMetadata_GetSideSetNumberOfDistributionFactors_67(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_GetSideSetPropertyValue_68(HandleRef pThis);

		public IntPtr GetSideSetPropertyValue()
		{
			return vtkModelMetadata.vtkModelMetadata_GetSideSetPropertyValue_68(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_GetSideSetSideList_69(HandleRef pThis);

		public IntPtr GetSideSetSideList()
		{
			return vtkModelMetadata.vtkModelMetadata_GetSideSetSideList_69(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_GetSideSetSize_70(HandleRef pThis);

		public IntPtr GetSideSetSize()
		{
			return vtkModelMetadata.vtkModelMetadata_GetSideSetSize_70(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_GetSizeBlockAttributeArray_71(HandleRef pThis);

		public int GetSizeBlockAttributeArray()
		{
			return vtkModelMetadata.vtkModelMetadata_GetSizeBlockAttributeArray_71(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_GetSumDistFactPerNodeSet_72(HandleRef pThis);

		public int GetSumDistFactPerNodeSet()
		{
			return vtkModelMetadata.vtkModelMetadata_GetSumDistFactPerNodeSet_72(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_GetSumDistFactPerSideSet_73(HandleRef pThis);

		public int GetSumDistFactPerSideSet()
		{
			return vtkModelMetadata.vtkModelMetadata_GetSumDistFactPerSideSet_73(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_GetSumElementsPerBlock_74(HandleRef pThis);

		public int GetSumElementsPerBlock()
		{
			return vtkModelMetadata.vtkModelMetadata_GetSumElementsPerBlock_74(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_GetSumNodesPerNodeSet_75(HandleRef pThis);

		public int GetSumNodesPerNodeSet()
		{
			return vtkModelMetadata.vtkModelMetadata_GetSumNodesPerNodeSet_75(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_GetSumSidesPerSideSet_76(HandleRef pThis);

		public int GetSumSidesPerSideSet()
		{
			return vtkModelMetadata.vtkModelMetadata_GetSumSidesPerSideSet_76(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_GetTimeStepIndex_77(HandleRef pThis);

		public int GetTimeStepIndex()
		{
			return vtkModelMetadata.vtkModelMetadata_GetTimeStepIndex_77(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_GetTimeStepValues_78(HandleRef pThis);

		public IntPtr GetTimeStepValues()
		{
			return vtkModelMetadata.vtkModelMetadata_GetTimeStepValues_78(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_GetTitle_79(HandleRef pThis);

		public string GetTitle()
		{
			return Marshal.PtrToStringAnsi(vtkModelMetadata.vtkModelMetadata_GetTitle_79(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_HasMetadata_80(HandleRef grid);

		public static int HasMetadata(vtkDataSet grid)
		{
			return vtkModelMetadata.vtkModelMetadata_HasMetadata_80((grid == null) ? default(HandleRef) : grid.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_IsA_81(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkModelMetadata.vtkModelMetadata_IsA_81(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_IsTypeOf_82(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkModelMetadata.vtkModelMetadata_IsTypeOf_82(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_MergeGlobalInformation_83(HandleRef pThis, HandleRef em);

		public int MergeGlobalInformation(vtkModelMetadata em)
		{
			return vtkModelMetadata.vtkModelMetadata_MergeGlobalInformation_83(base.GetCppThis(), (em == null) ? default(HandleRef) : em.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_MergeModelMetadata_84(HandleRef pThis, HandleRef em);

		public int MergeModelMetadata(vtkModelMetadata em)
		{
			return vtkModelMetadata.vtkModelMetadata_MergeModelMetadata_84(base.GetCppThis(), (em == null) ? default(HandleRef) : em.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_NewInstance_86(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkModelMetadata NewInstance()
		{
			vtkModelMetadata result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkModelMetadata.vtkModelMetadata_NewInstance_86(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkModelMetadata)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_Pack_87(HandleRef pThis, HandleRef ugrid);

		public void Pack(vtkDataSet ugrid)
		{
			vtkModelMetadata.vtkModelMetadata_Pack_87(base.GetCppThis(), (ugrid == null) ? default(HandleRef) : ugrid.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_PrintGlobalInformation_88(HandleRef pThis);

		public virtual void PrintGlobalInformation()
		{
			vtkModelMetadata.vtkModelMetadata_PrintGlobalInformation_88(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_PrintLocalInformation_89(HandleRef pThis);

		public virtual void PrintLocalInformation()
		{
			vtkModelMetadata.vtkModelMetadata_PrintLocalInformation_89(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_RemoveMetadata_90(HandleRef grid);

		public static void RemoveMetadata(vtkDataSet grid)
		{
			vtkModelMetadata.vtkModelMetadata_RemoveMetadata_90((grid == null) ? default(HandleRef) : grid.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_RemoveUGridElementVariable_91(HandleRef pThis, string ugridVarName);

		public int RemoveUGridElementVariable(string ugridVarName)
		{
			return vtkModelMetadata.vtkModelMetadata_RemoveUGridElementVariable_91(base.GetCppThis(), ugridVarName);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_RemoveUGridNodeVariable_92(HandleRef pThis, string ugridVarName);

		public int RemoveUGridNodeVariable(string ugridVarName)
		{
			return vtkModelMetadata.vtkModelMetadata_RemoveUGridNodeVariable_92(base.GetCppThis(), ugridVarName);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_Reset_93(HandleRef pThis);

		public void Reset()
		{
			vtkModelMetadata.vtkModelMetadata_Reset_93(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModelMetadata_SafeDownCast_94(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkModelMetadata SafeDownCast(vtkObjectBase o)
		{
			vtkModelMetadata vtkModelMetadata = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkModelMetadata.vtkModelMetadata_SafeDownCast_94((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkModelMetadata = (vtkModelMetadata)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkModelMetadata.Register(null);
				}
			}
			return vtkModelMetadata;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_SetAllVariablesDefinedInAllBlocks_95(HandleRef pThis, int _arg);

		public virtual void SetAllVariablesDefinedInAllBlocks(int _arg)
		{
			vtkModelMetadata.vtkModelMetadata_SetAllVariablesDefinedInAllBlocks_95(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_SetBlockAttributes_96(HandleRef pThis, IntPtr arg0);

		public void SetBlockAttributes(IntPtr arg0)
		{
			vtkModelMetadata.vtkModelMetadata_SetBlockAttributes_96(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_SetBlockElementIdList_97(HandleRef pThis, IntPtr arg0);

		public void SetBlockElementIdList(IntPtr arg0)
		{
			vtkModelMetadata.vtkModelMetadata_SetBlockElementIdList_97(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_SetBlockIds_98(HandleRef pThis, IntPtr arg0);

		public void SetBlockIds(IntPtr arg0)
		{
			vtkModelMetadata.vtkModelMetadata_SetBlockIds_98(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_SetBlockNodesPerElement_99(HandleRef pThis, IntPtr arg0);

		public void SetBlockNodesPerElement(IntPtr arg0)
		{
			vtkModelMetadata.vtkModelMetadata_SetBlockNodesPerElement_99(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_SetBlockNumberOfAttributesPerElement_100(HandleRef pThis, IntPtr natts);

		public int SetBlockNumberOfAttributesPerElement(IntPtr natts)
		{
			return vtkModelMetadata.vtkModelMetadata_SetBlockNumberOfAttributesPerElement_100(base.GetCppThis(), natts);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_SetBlockNumberOfElements_101(HandleRef pThis, IntPtr nelts);

		public int SetBlockNumberOfElements(IntPtr nelts)
		{
			return vtkModelMetadata.vtkModelMetadata_SetBlockNumberOfElements_101(base.GetCppThis(), nelts);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_SetBlockPropertyValue_102(HandleRef pThis, IntPtr arg0);

		public void SetBlockPropertyValue(IntPtr arg0)
		{
			vtkModelMetadata.vtkModelMetadata_SetBlockPropertyValue_102(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_SetElementVariableTruthTable_103(HandleRef pThis, IntPtr arg0);

		public void SetElementVariableTruthTable(IntPtr arg0)
		{
			vtkModelMetadata.vtkModelMetadata_SetElementVariableTruthTable_103(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_SetGlobalVariableValue_104(HandleRef pThis, IntPtr f);

		public void SetGlobalVariableValue(IntPtr f)
		{
			vtkModelMetadata.vtkModelMetadata_SetGlobalVariableValue_104(base.GetCppThis(), f);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_SetNodeSetDistributionFactors_105(HandleRef pThis, IntPtr arg0);

		public void SetNodeSetDistributionFactors(IntPtr arg0)
		{
			vtkModelMetadata.vtkModelMetadata_SetNodeSetDistributionFactors_105(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_SetNodeSetIds_106(HandleRef pThis, IntPtr arg0);

		public void SetNodeSetIds(IntPtr arg0)
		{
			vtkModelMetadata.vtkModelMetadata_SetNodeSetIds_106(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_SetNodeSetNodeIdList_107(HandleRef pThis, IntPtr arg0);

		public void SetNodeSetNodeIdList(IntPtr arg0)
		{
			vtkModelMetadata.vtkModelMetadata_SetNodeSetNodeIdList_107(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_SetNodeSetNumberOfDistributionFactors_108(HandleRef pThis, IntPtr arg0);

		public int SetNodeSetNumberOfDistributionFactors(IntPtr arg0)
		{
			return vtkModelMetadata.vtkModelMetadata_SetNodeSetNumberOfDistributionFactors_108(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_SetNodeSetPropertyValue_109(HandleRef pThis, IntPtr arg0);

		public void SetNodeSetPropertyValue(IntPtr arg0)
		{
			vtkModelMetadata.vtkModelMetadata_SetNodeSetPropertyValue_109(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_SetNodeSetSize_110(HandleRef pThis, IntPtr arg0);

		public int SetNodeSetSize(IntPtr arg0)
		{
			return vtkModelMetadata.vtkModelMetadata_SetNodeSetSize_110(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_SetNumberOfBlocks_111(HandleRef pThis, int _arg);

		public virtual void SetNumberOfBlocks(int _arg)
		{
			vtkModelMetadata.vtkModelMetadata_SetNumberOfBlocks_111(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_SetNumberOfNodeSets_112(HandleRef pThis, int _arg);

		public virtual void SetNumberOfNodeSets(int _arg)
		{
			vtkModelMetadata.vtkModelMetadata_SetNumberOfNodeSets_112(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_SetNumberOfSideSets_113(HandleRef pThis, int _arg);

		public virtual void SetNumberOfSideSets(int _arg)
		{
			vtkModelMetadata.vtkModelMetadata_SetNumberOfSideSets_113(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_SetSideSetDistributionFactors_114(HandleRef pThis, IntPtr arg0);

		public void SetSideSetDistributionFactors(IntPtr arg0)
		{
			vtkModelMetadata.vtkModelMetadata_SetSideSetDistributionFactors_114(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_SetSideSetElementList_115(HandleRef pThis, IntPtr arg0);

		public void SetSideSetElementList(IntPtr arg0)
		{
			vtkModelMetadata.vtkModelMetadata_SetSideSetElementList_115(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_SetSideSetIds_116(HandleRef pThis, IntPtr arg0);

		public void SetSideSetIds(IntPtr arg0)
		{
			vtkModelMetadata.vtkModelMetadata_SetSideSetIds_116(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_SetSideSetNumDFPerSide_117(HandleRef pThis, IntPtr numNodes);

		public void SetSideSetNumDFPerSide(IntPtr numNodes)
		{
			vtkModelMetadata.vtkModelMetadata_SetSideSetNumDFPerSide_117(base.GetCppThis(), numNodes);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_SetSideSetNumberOfDistributionFactors_118(HandleRef pThis, IntPtr df);

		public int SetSideSetNumberOfDistributionFactors(IntPtr df)
		{
			return vtkModelMetadata.vtkModelMetadata_SetSideSetNumberOfDistributionFactors_118(base.GetCppThis(), df);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_SetSideSetPropertyValue_119(HandleRef pThis, IntPtr arg0);

		public void SetSideSetPropertyValue(IntPtr arg0)
		{
			vtkModelMetadata.vtkModelMetadata_SetSideSetPropertyValue_119(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_SetSideSetSideList_120(HandleRef pThis, IntPtr arg0);

		public void SetSideSetSideList(IntPtr arg0)
		{
			vtkModelMetadata.vtkModelMetadata_SetSideSetSideList_120(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_SetSideSetSize_121(HandleRef pThis, IntPtr sizes);

		public int SetSideSetSize(IntPtr sizes)
		{
			return vtkModelMetadata.vtkModelMetadata_SetSideSetSize_121(base.GetCppThis(), sizes);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_SetTimeStepIndex_122(HandleRef pThis, int _arg);

		public virtual void SetTimeStepIndex(int _arg)
		{
			vtkModelMetadata.vtkModelMetadata_SetTimeStepIndex_122(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_SetTimeSteps_123(HandleRef pThis, int numberOfTimeSteps, IntPtr timeStepValues);

		public void SetTimeSteps(int numberOfTimeSteps, IntPtr timeStepValues)
		{
			vtkModelMetadata.vtkModelMetadata_SetTimeSteps_123(base.GetCppThis(), numberOfTimeSteps, timeStepValues);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModelMetadata_SetTitle_124(HandleRef pThis, string _arg);

		public virtual void SetTitle(string _arg)
		{
			vtkModelMetadata.vtkModelMetadata_SetTitle_124(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModelMetadata_Unpack_125(HandleRef pThis, HandleRef ugrid, int deleteIt);

		public int Unpack(vtkDataSet ugrid, int deleteIt)
		{
			return vtkModelMetadata.vtkModelMetadata_Unpack_125(base.GetCppThis(), (ugrid == null) ? default(HandleRef) : ugrid.GetCppThis(), deleteIt);
		}
	}
}
