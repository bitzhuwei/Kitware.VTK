using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExodusIIReader : vtkMultiBlockDataSetAlgorithm
	{
		public enum ID_NOT_FOUND_WrapperEnum
		{
			ID_NOT_FOUND = -234121312,
			SEARCH_TYPE_ELEMENT = 0,
			SEARCH_TYPE_ELEMENT_THEN_NODE = 2,
			SEARCH_TYPE_NODE = 1,
			SEARCH_TYPE_NODE_THEN_ELEMENT = 3
		}

		public enum DecorationType
		{
			CORNER_AVERAGED = 2,
			GLYPHS = 1,
			NONE = 0
		}

		public enum ObjectType
		{
			ASSEMBLY = 60,
			EDGE_BLOCK = 6,
			EDGE_BLOCK_ATTRIB = 79,
			EDGE_BLOCK_CONN = 94,
			EDGE_ID = 106,
			EDGE_MAP = 11,
			EDGE_SET = 7,
			EDGE_SET_CONN = 90,
			ELEMENT_ID = 84,
			ELEM_BLOCK = 1,
			ELEM_BLOCK_ATTRIB = 81,
			ELEM_BLOCK_EDGE_CONN = 96,
			ELEM_BLOCK_ELEM_CONN = 98,
			ELEM_BLOCK_FACE_CONN = 97,
			ELEM_BLOCK_TEMPORAL = 100,
			ELEM_MAP = 4,
			ELEM_SET = 10,
			ELEM_SET_CONN = 93,
			ENTITY_COUNTS = 109,
			FACE_BLOCK = 8,
			FACE_BLOCK_ATTRIB = 80,
			FACE_BLOCK_CONN = 95,
			FACE_ID = 105,
			FACE_MAP = 12,
			FACE_SET = 9,
			FACE_SET_CONN = 91,
			GLOBAL = 13,
			GLOBAL_CONN = 99,
			GLOBAL_ELEMENT_ID = 86,
			GLOBAL_NODE_ID = 85,
			GLOBAL_TEMPORAL = 102,
			HIERARCHY = 63,
			IMPLICIT_ELEMENT_ID = 108,
			IMPLICIT_NODE_ID = 107,
			INFO_RECORDS = 104,
			MATERIAL = 62,
			NODAL = 14,
			NODAL_COORDS = 88,
			NODAL_SQUEEZEMAP = 82,
			NODAL_TEMPORAL = 101,
			NODE_ID = 83,
			NODE_MAP = 5,
			NODE_SET = 2,
			NODE_SET_CONN = 89,
			OBJECT_ID = 87,
			PART = 61,
			QA_RECORDS = 103,
			SIDE_SET = 3,
			SIDE_SET_CONN = 92
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkExodusIIReader";

		public new static readonly string MRClassNameKey;

		static vtkExodusIIReader()
		{
			vtkExodusIIReader.MRClassNameKey = "class vtkExodusIIReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExodusIIReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExodusIIReader"));
		}

		public vtkExodusIIReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExodusIIReader New()
		{
			vtkExodusIIReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExodusIIReader.vtkExodusIIReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExodusIIReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkExodusIIReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkExodusIIReader.vtkExodusIIReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_AnimateModeShapesOff_01(HandleRef pThis);

		public virtual void AnimateModeShapesOff()
		{
			vtkExodusIIReader.vtkExodusIIReader_AnimateModeShapesOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_AnimateModeShapesOn_02(HandleRef pThis);

		public virtual void AnimateModeShapesOn()
		{
			vtkExodusIIReader.vtkExodusIIReader_AnimateModeShapesOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_ApplyDisplacementsOff_03(HandleRef pThis);

		public virtual void ApplyDisplacementsOff()
		{
			vtkExodusIIReader.vtkExodusIIReader_ApplyDisplacementsOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_ApplyDisplacementsOn_04(HandleRef pThis);

		public virtual void ApplyDisplacementsOn()
		{
			vtkExodusIIReader.vtkExodusIIReader_ApplyDisplacementsOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_CanReadFile_05(HandleRef pThis, string fname);

		public int CanReadFile(string fname)
		{
			return vtkExodusIIReader.vtkExodusIIReader_CanReadFile_05(base.GetCppThis(), fname);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_Dump_06(HandleRef pThis);

		public virtual void Dump()
		{
			vtkExodusIIReader.vtkExodusIIReader_Dump_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_EdgeFieldDecorationsCornerAveraged_07(HandleRef pThis);

		public void EdgeFieldDecorationsCornerAveraged()
		{
			vtkExodusIIReader.vtkExodusIIReader_EdgeFieldDecorationsCornerAveraged_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_EdgeFieldDecorationsGlyphs_08(HandleRef pThis);

		public void EdgeFieldDecorationsGlyphs()
		{
			vtkExodusIIReader.vtkExodusIIReader_EdgeFieldDecorationsGlyphs_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_EdgeFieldDecorationsNone_09(HandleRef pThis);

		public void EdgeFieldDecorationsNone()
		{
			vtkExodusIIReader.vtkExodusIIReader_EdgeFieldDecorationsNone_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_ExodusModelMetadataOff_10(HandleRef pThis);

		public virtual void ExodusModelMetadataOff()
		{
			vtkExodusIIReader.vtkExodusIIReader_ExodusModelMetadataOff_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_ExodusModelMetadataOn_11(HandleRef pThis);

		public virtual void ExodusModelMetadataOn()
		{
			vtkExodusIIReader.vtkExodusIIReader_ExodusModelMetadataOn_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_FaceFieldDecorationsCornerAveraged_12(HandleRef pThis);

		public void FaceFieldDecorationsCornerAveraged()
		{
			vtkExodusIIReader.vtkExodusIIReader_FaceFieldDecorationsCornerAveraged_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_FaceFieldDecorationsGlyphs_13(HandleRef pThis);

		public void FaceFieldDecorationsGlyphs()
		{
			vtkExodusIIReader.vtkExodusIIReader_FaceFieldDecorationsGlyphs_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_FaceFieldDecorationsNone_14(HandleRef pThis);

		public void FaceFieldDecorationsNone()
		{
			vtkExodusIIReader.vtkExodusIIReader_FaceFieldDecorationsNone_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_GenerateFileIdArrayOff_15(HandleRef pThis);

		public virtual void GenerateFileIdArrayOff()
		{
			vtkExodusIIReader.vtkExodusIIReader_GenerateFileIdArrayOff_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_GenerateFileIdArrayOn_16(HandleRef pThis);

		public virtual void GenerateFileIdArrayOn()
		{
			vtkExodusIIReader.vtkExodusIIReader_GenerateFileIdArrayOn_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_GenerateGlobalElementIdArrayOff_17(HandleRef pThis);

		public virtual void GenerateGlobalElementIdArrayOff()
		{
			vtkExodusIIReader.vtkExodusIIReader_GenerateGlobalElementIdArrayOff_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_GenerateGlobalElementIdArrayOn_18(HandleRef pThis);

		public virtual void GenerateGlobalElementIdArrayOn()
		{
			vtkExodusIIReader.vtkExodusIIReader_GenerateGlobalElementIdArrayOn_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_GenerateGlobalNodeIdArrayOff_19(HandleRef pThis);

		public virtual void GenerateGlobalNodeIdArrayOff()
		{
			vtkExodusIIReader.vtkExodusIIReader_GenerateGlobalNodeIdArrayOff_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_GenerateGlobalNodeIdArrayOn_20(HandleRef pThis);

		public virtual void GenerateGlobalNodeIdArrayOn()
		{
			vtkExodusIIReader.vtkExodusIIReader_GenerateGlobalNodeIdArrayOn_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_GenerateImplicitElementIdArrayOff_21(HandleRef pThis);

		public virtual void GenerateImplicitElementIdArrayOff()
		{
			vtkExodusIIReader.vtkExodusIIReader_GenerateImplicitElementIdArrayOff_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_GenerateImplicitElementIdArrayOn_22(HandleRef pThis);

		public virtual void GenerateImplicitElementIdArrayOn()
		{
			vtkExodusIIReader.vtkExodusIIReader_GenerateImplicitElementIdArrayOn_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_GenerateImplicitNodeIdArrayOff_23(HandleRef pThis);

		public virtual void GenerateImplicitNodeIdArrayOff()
		{
			vtkExodusIIReader.vtkExodusIIReader_GenerateImplicitNodeIdArrayOff_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_GenerateImplicitNodeIdArrayOn_24(HandleRef pThis);

		public virtual void GenerateImplicitNodeIdArrayOn()
		{
			vtkExodusIIReader.vtkExodusIIReader_GenerateImplicitNodeIdArrayOn_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_GenerateObjectIdCellArrayOff_25(HandleRef pThis);

		public virtual void GenerateObjectIdCellArrayOff()
		{
			vtkExodusIIReader.vtkExodusIIReader_GenerateObjectIdCellArrayOff_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_GenerateObjectIdCellArrayOn_26(HandleRef pThis);

		public virtual void GenerateObjectIdCellArrayOn()
		{
			vtkExodusIIReader.vtkExodusIIReader_GenerateObjectIdCellArrayOn_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetAnimateModeShapes_27(HandleRef pThis);

		public int GetAnimateModeShapes()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetAnimateModeShapes_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetApplyDisplacements_28(HandleRef pThis);

		public int GetApplyDisplacements()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetApplyDisplacements_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetAssemblyArrayID_29(HandleRef pThis, string name);

		public int GetAssemblyArrayID(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetAssemblyArrayID_29(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetAssemblyArrayName_30(HandleRef pThis, int arrayIdx);

		public string GetAssemblyArrayName(int arrayIdx)
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetAssemblyArrayName_30(base.GetCppThis(), arrayIdx));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetAssemblyArrayStatus_31(HandleRef pThis, int index);

		public int GetAssemblyArrayStatus(int index)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetAssemblyArrayStatus_31(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetAssemblyArrayStatus_32(HandleRef pThis, string arg0);

		public int GetAssemblyArrayStatus(string arg0)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetAssemblyArrayStatus_32(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetDimensionality_33(HandleRef pThis);

		public int GetDimensionality()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetDimensionality_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern float vtkExodusIIReader_GetDisplacementMagnitude_34(HandleRef pThis);

		public float GetDisplacementMagnitude()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetDisplacementMagnitude_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetDisplayType_35(HandleRef pThis);

		public virtual int GetDisplayType()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetDisplayType_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetEdgeBlockArrayName_36(HandleRef pThis, int index);

		public string GetEdgeBlockArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetEdgeBlockArrayName_36(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetEdgeBlockArrayStatus_37(HandleRef pThis, string name);

		public int GetEdgeBlockArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetEdgeBlockArrayStatus_37(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetEdgeFieldDecorations_38(HandleRef pThis);

		public int GetEdgeFieldDecorations()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetEdgeFieldDecorations_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetEdgeMapArrayName_39(HandleRef pThis, int index);

		public string GetEdgeMapArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetEdgeMapArrayName_39(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetEdgeMapArrayStatus_40(HandleRef pThis, string name);

		public int GetEdgeMapArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetEdgeMapArrayStatus_40(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetEdgeResultArrayName_41(HandleRef pThis, int index);

		public string GetEdgeResultArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetEdgeResultArrayName_41(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetEdgeResultArrayStatus_42(HandleRef pThis, string name);

		public int GetEdgeResultArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetEdgeResultArrayStatus_42(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetEdgeSetArrayName_43(HandleRef pThis, int index);

		public string GetEdgeSetArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetEdgeSetArrayName_43(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetEdgeSetArrayStatus_44(HandleRef pThis, string name);

		public int GetEdgeSetArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetEdgeSetArrayStatus_44(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetEdgeSetResultArrayName_45(HandleRef pThis, int index);

		public string GetEdgeSetResultArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetEdgeSetResultArrayName_45(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetEdgeSetResultArrayStatus_46(HandleRef pThis, string name);

		public int GetEdgeSetResultArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetEdgeSetResultArrayStatus_46(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetElementBlockArrayName_47(HandleRef pThis, int index);

		public string GetElementBlockArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetElementBlockArrayName_47(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetElementBlockArrayStatus_48(HandleRef pThis, string name);

		public int GetElementBlockArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetElementBlockArrayStatus_48(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetElementMapArrayName_49(HandleRef pThis, int index);

		public string GetElementMapArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetElementMapArrayName_49(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetElementMapArrayStatus_50(HandleRef pThis, string name);

		public int GetElementMapArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetElementMapArrayStatus_50(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetElementResultArrayName_51(HandleRef pThis, int index);

		public string GetElementResultArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetElementResultArrayName_51(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetElementResultArrayStatus_52(HandleRef pThis, string name);

		public int GetElementResultArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetElementResultArrayStatus_52(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetElementSetArrayName_53(HandleRef pThis, int index);

		public string GetElementSetArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetElementSetArrayName_53(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetElementSetArrayStatus_54(HandleRef pThis, string name);

		public int GetElementSetArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetElementSetArrayStatus_54(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetElementSetResultArrayName_55(HandleRef pThis, int index);

		public string GetElementSetResultArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetElementSetResultArrayName_55(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetElementSetResultArrayStatus_56(HandleRef pThis, string name);

		public int GetElementSetResultArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetElementSetResultArrayStatus_56(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetExodusModel_57(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkExodusModel GetExodusModel()
		{
			vtkExodusModel vtkExodusModel = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExodusIIReader.vtkExodusIIReader_GetExodusModel_57(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkExodusIIReader_GetExodusModelMetadata_58(HandleRef pThis);

		public virtual int GetExodusModelMetadata()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetExodusModelMetadata_58(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetFaceBlockArrayName_59(HandleRef pThis, int index);

		public string GetFaceBlockArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetFaceBlockArrayName_59(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetFaceBlockArrayStatus_60(HandleRef pThis, string name);

		public int GetFaceBlockArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetFaceBlockArrayStatus_60(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetFaceFieldDecorations_61(HandleRef pThis);

		public int GetFaceFieldDecorations()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetFaceFieldDecorations_61(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetFaceMapArrayName_62(HandleRef pThis, int index);

		public string GetFaceMapArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetFaceMapArrayName_62(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetFaceMapArrayStatus_63(HandleRef pThis, string name);

		public int GetFaceMapArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetFaceMapArrayStatus_63(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetFaceResultArrayName_64(HandleRef pThis, int index);

		public string GetFaceResultArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetFaceResultArrayName_64(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetFaceResultArrayStatus_65(HandleRef pThis, string name);

		public int GetFaceResultArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetFaceResultArrayStatus_65(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetFaceSetArrayName_66(HandleRef pThis, int index);

		public string GetFaceSetArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetFaceSetArrayName_66(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetFaceSetArrayStatus_67(HandleRef pThis, string name);

		public int GetFaceSetArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetFaceSetArrayStatus_67(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetFaceSetResultArrayName_68(HandleRef pThis, int index);

		public string GetFaceSetResultArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetFaceSetResultArrayName_68(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetFaceSetResultArrayStatus_69(HandleRef pThis, string name);

		public int GetFaceSetResultArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetFaceSetResultArrayStatus_69(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetFileId_70(HandleRef pThis);

		public int GetFileId()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetFileId_70(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetFileName_71(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetFileName_71(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetGenerateFileIdArray_72(HandleRef pThis);

		public int GetGenerateFileIdArray()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetGenerateFileIdArray_72(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetGenerateGlobalElementIdArray_73(HandleRef pThis);

		public int GetGenerateGlobalElementIdArray()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetGenerateGlobalElementIdArray_73(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetGenerateGlobalNodeIdArray_74(HandleRef pThis);

		public int GetGenerateGlobalNodeIdArray()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetGenerateGlobalNodeIdArray_74(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetGenerateImplicitElementIdArray_75(HandleRef pThis);

		public int GetGenerateImplicitElementIdArray()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetGenerateImplicitElementIdArray_75(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetGenerateImplicitNodeIdArray_76(HandleRef pThis);

		public int GetGenerateImplicitNodeIdArray()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetGenerateImplicitNodeIdArray_76(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetGenerateObjectIdCellArray_77(HandleRef pThis);

		public int GetGenerateObjectIdCellArray()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetGenerateObjectIdCellArray_77(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetGlobalEdgeID_78(HandleRef data, int localID);

		public static int GetGlobalEdgeID(vtkDataSet data, int localID)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetGlobalEdgeID_78((data == null) ? default(HandleRef) : data.GetCppThis(), localID);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetGlobalEdgeID_79(HandleRef data, int localID, int searchType);

		public static int GetGlobalEdgeID(vtkDataSet data, int localID, int searchType)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetGlobalEdgeID_79((data == null) ? default(HandleRef) : data.GetCppThis(), localID, searchType);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetGlobalEdgeIdArrayName_80();

		public static string GetGlobalEdgeIdArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetGlobalEdgeIdArrayName_80());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetGlobalElementID_81(HandleRef data, int localID);

		public static int GetGlobalElementID(vtkDataSet data, int localID)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetGlobalElementID_81((data == null) ? default(HandleRef) : data.GetCppThis(), localID);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetGlobalElementID_82(HandleRef data, int localID, int searchType);

		public static int GetGlobalElementID(vtkDataSet data, int localID, int searchType)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetGlobalElementID_82((data == null) ? default(HandleRef) : data.GetCppThis(), localID, searchType);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetGlobalElementIdArrayName_83();

		public static string GetGlobalElementIdArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetGlobalElementIdArrayName_83());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetGlobalFaceID_84(HandleRef data, int localID);

		public static int GetGlobalFaceID(vtkDataSet data, int localID)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetGlobalFaceID_84((data == null) ? default(HandleRef) : data.GetCppThis(), localID);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetGlobalFaceID_85(HandleRef data, int localID, int searchType);

		public static int GetGlobalFaceID(vtkDataSet data, int localID, int searchType)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetGlobalFaceID_85((data == null) ? default(HandleRef) : data.GetCppThis(), localID, searchType);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetGlobalFaceIdArrayName_86();

		public static string GetGlobalFaceIdArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetGlobalFaceIdArrayName_86());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetGlobalNodeID_87(HandleRef data, int localID);

		public static int GetGlobalNodeID(vtkDataSet data, int localID)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetGlobalNodeID_87((data == null) ? default(HandleRef) : data.GetCppThis(), localID);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetGlobalNodeID_88(HandleRef data, int localID, int searchType);

		public static int GetGlobalNodeID(vtkDataSet data, int localID, int searchType)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetGlobalNodeID_88((data == null) ? default(HandleRef) : data.GetCppThis(), localID, searchType);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetGlobalNodeIdArrayName_89();

		public static string GetGlobalNodeIdArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetGlobalNodeIdArrayName_89());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetGlobalResultArrayName_90(HandleRef pThis, int index);

		public string GetGlobalResultArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetGlobalResultArrayName_90(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetGlobalResultArrayStatus_91(HandleRef pThis, string name);

		public int GetGlobalResultArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetGlobalResultArrayStatus_91(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetHasModeShapes_92(HandleRef pThis);

		public int GetHasModeShapes()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetHasModeShapes_92(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetHierarchyArrayName_93(HandleRef pThis, int arrayIdx);

		public string GetHierarchyArrayName(int arrayIdx)
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetHierarchyArrayName_93(base.GetCppThis(), arrayIdx));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetHierarchyArrayStatus_94(HandleRef pThis, int index);

		public int GetHierarchyArrayStatus(int index)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetHierarchyArrayStatus_94(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetHierarchyArrayStatus_95(HandleRef pThis, string arg0);

		public int GetHierarchyArrayStatus(string arg0)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetHierarchyArrayStatus_95(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetImplicitEdgeIdArrayName_96();

		public static string GetImplicitEdgeIdArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetImplicitEdgeIdArrayName_96());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetImplicitElementIdArrayName_97();

		public static string GetImplicitElementIdArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetImplicitElementIdArrayName_97());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetImplicitFaceIdArrayName_98();

		public static string GetImplicitFaceIdArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetImplicitFaceIdArrayName_98());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetImplicitNodeIdArrayName_99();

		public static string GetImplicitNodeIdArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetImplicitNodeIdArrayName_99());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern uint vtkExodusIIReader_GetMTime_100(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetMTime_100(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetMaterialArrayID_101(HandleRef pThis, string name);

		public int GetMaterialArrayID(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetMaterialArrayID_101(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetMaterialArrayName_102(HandleRef pThis, int arrayIdx);

		public string GetMaterialArrayName(int arrayIdx)
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetMaterialArrayName_102(base.GetCppThis(), arrayIdx));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetMaterialArrayStatus_103(HandleRef pThis, int index);

		public int GetMaterialArrayStatus(int index)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetMaterialArrayStatus_103(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetMaterialArrayStatus_104(HandleRef pThis, string arg0);

		public int GetMaterialArrayStatus(string arg0)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetMaterialArrayStatus_104(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern uint vtkExodusIIReader_GetMetadataMTime_105(HandleRef pThis);

		public virtual uint GetMetadataMTime()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetMetadataMTime_105(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkExodusIIReader_GetModeShapeTime_106(HandleRef pThis);

		public double GetModeShapeTime()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetModeShapeTime_106(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetNodeMapArrayName_107(HandleRef pThis, int index);

		public string GetNodeMapArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetNodeMapArrayName_107(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNodeMapArrayStatus_108(HandleRef pThis, string name);

		public int GetNodeMapArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNodeMapArrayStatus_108(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetNodeSetArrayName_109(HandleRef pThis, int index);

		public string GetNodeSetArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetNodeSetArrayName_109(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNodeSetArrayStatus_110(HandleRef pThis, string name);

		public int GetNodeSetArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNodeSetArrayStatus_110(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetNodeSetResultArrayName_111(HandleRef pThis, int index);

		public string GetNodeSetResultArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetNodeSetResultArrayName_111(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNodeSetResultArrayStatus_112(HandleRef pThis, string name);

		public int GetNodeSetResultArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNodeSetResultArrayStatus_112(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNumberOfAssemblyArrays_113(HandleRef pThis);

		public int GetNumberOfAssemblyArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfAssemblyArrays_113(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNumberOfEdgeBlockArrays_114(HandleRef pThis);

		public int GetNumberOfEdgeBlockArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfEdgeBlockArrays_114(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNumberOfEdgeMapArrays_115(HandleRef pThis);

		public int GetNumberOfEdgeMapArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfEdgeMapArrays_115(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNumberOfEdgeResultArrays_116(HandleRef pThis);

		public int GetNumberOfEdgeResultArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfEdgeResultArrays_116(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNumberOfEdgeSetArrays_117(HandleRef pThis);

		public int GetNumberOfEdgeSetArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfEdgeSetArrays_117(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNumberOfEdgeSetResultArrays_118(HandleRef pThis);

		public int GetNumberOfEdgeSetResultArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfEdgeSetResultArrays_118(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNumberOfEdgesInFile_119(HandleRef pThis);

		public int GetNumberOfEdgesInFile()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfEdgesInFile_119(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNumberOfElementBlockArrays_120(HandleRef pThis);

		public int GetNumberOfElementBlockArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfElementBlockArrays_120(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNumberOfElementMapArrays_121(HandleRef pThis);

		public int GetNumberOfElementMapArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfElementMapArrays_121(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNumberOfElementResultArrays_122(HandleRef pThis);

		public int GetNumberOfElementResultArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfElementResultArrays_122(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNumberOfElementSetArrays_123(HandleRef pThis);

		public int GetNumberOfElementSetArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfElementSetArrays_123(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNumberOfElementSetResultArrays_124(HandleRef pThis);

		public int GetNumberOfElementSetResultArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfElementSetResultArrays_124(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNumberOfElementsInFile_125(HandleRef pThis);

		public int GetNumberOfElementsInFile()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfElementsInFile_125(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNumberOfEntriesInObject_126(HandleRef pThis, int objectType, int objectIndex);

		public int GetNumberOfEntriesInObject(int objectType, int objectIndex)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfEntriesInObject_126(base.GetCppThis(), objectType, objectIndex);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNumberOfFaceBlockArrays_127(HandleRef pThis);

		public int GetNumberOfFaceBlockArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfFaceBlockArrays_127(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNumberOfFaceMapArrays_128(HandleRef pThis);

		public int GetNumberOfFaceMapArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfFaceMapArrays_128(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNumberOfFaceResultArrays_129(HandleRef pThis);

		public int GetNumberOfFaceResultArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfFaceResultArrays_129(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNumberOfFaceSetArrays_130(HandleRef pThis);

		public int GetNumberOfFaceSetArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfFaceSetArrays_130(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNumberOfFaceSetResultArrays_131(HandleRef pThis);

		public int GetNumberOfFaceSetResultArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfFaceSetResultArrays_131(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNumberOfFacesInFile_132(HandleRef pThis);

		public int GetNumberOfFacesInFile()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfFacesInFile_132(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNumberOfGlobalResultArrays_133(HandleRef pThis);

		public int GetNumberOfGlobalResultArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfGlobalResultArrays_133(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNumberOfHierarchyArrays_134(HandleRef pThis);

		public int GetNumberOfHierarchyArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfHierarchyArrays_134(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNumberOfMaterialArrays_135(HandleRef pThis);

		public int GetNumberOfMaterialArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfMaterialArrays_135(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNumberOfNodeMapArrays_136(HandleRef pThis);

		public int GetNumberOfNodeMapArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfNodeMapArrays_136(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNumberOfNodeSetArrays_137(HandleRef pThis);

		public int GetNumberOfNodeSetArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfNodeSetArrays_137(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNumberOfNodeSetResultArrays_138(HandleRef pThis);

		public int GetNumberOfNodeSetResultArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfNodeSetResultArrays_138(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNumberOfNodes_139(HandleRef pThis);

		public int GetNumberOfNodes()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfNodes_139(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNumberOfNodesInFile_140(HandleRef pThis);

		public int GetNumberOfNodesInFile()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfNodesInFile_140(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNumberOfObjectArrayComponents_141(HandleRef pThis, int objectType, int arrayIndex);

		public int GetNumberOfObjectArrayComponents(int objectType, int arrayIndex)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfObjectArrayComponents_141(base.GetCppThis(), objectType, arrayIndex);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNumberOfObjectArrays_142(HandleRef pThis, int objectType);

		public int GetNumberOfObjectArrays(int objectType)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfObjectArrays_142(base.GetCppThis(), objectType);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNumberOfObjectAttributes_143(HandleRef pThis, int objectType, int objectIndex);

		public int GetNumberOfObjectAttributes(int objectType, int objectIndex)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfObjectAttributes_143(base.GetCppThis(), objectType, objectIndex);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNumberOfObjects_144(HandleRef pThis, int objectType);

		public int GetNumberOfObjects(int objectType)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfObjects_144(base.GetCppThis(), objectType);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNumberOfPartArrays_145(HandleRef pThis);

		public int GetNumberOfPartArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfPartArrays_145(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNumberOfPointResultArrays_146(HandleRef pThis);

		public int GetNumberOfPointResultArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfPointResultArrays_146(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNumberOfSideSetArrays_147(HandleRef pThis);

		public int GetNumberOfSideSetArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfSideSetArrays_147(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNumberOfSideSetResultArrays_148(HandleRef pThis);

		public int GetNumberOfSideSetResultArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfSideSetResultArrays_148(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetNumberOfTimeSteps_149(HandleRef pThis);

		public int GetNumberOfTimeSteps()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfTimeSteps_149(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetObjectArrayIndex_150(HandleRef pThis, int objectType, string arrayName);

		public int GetObjectArrayIndex(int objectType, string arrayName)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetObjectArrayIndex_150(base.GetCppThis(), objectType, arrayName);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetObjectArrayName_151(HandleRef pThis, int objectType, int arrayIndex);

		public string GetObjectArrayName(int objectType, int arrayIndex)
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetObjectArrayName_151(base.GetCppThis(), objectType, arrayIndex));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetObjectArrayStatus_152(HandleRef pThis, int objectType, int arrayIndex);

		public int GetObjectArrayStatus(int objectType, int arrayIndex)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetObjectArrayStatus_152(base.GetCppThis(), objectType, arrayIndex);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetObjectArrayStatus_153(HandleRef pThis, int objectType, string arrayName);

		public int GetObjectArrayStatus(int objectType, string arrayName)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetObjectArrayStatus_153(base.GetCppThis(), objectType, arrayName);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetObjectAttributeIndex_154(HandleRef pThis, int objectType, int objectIndex, string attribName);

		public int GetObjectAttributeIndex(int objectType, int objectIndex, string attribName)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetObjectAttributeIndex_154(base.GetCppThis(), objectType, objectIndex, attribName);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetObjectAttributeName_155(HandleRef pThis, int objectType, int objectIndex, int attribIndex);

		public string GetObjectAttributeName(int objectType, int objectIndex, int attribIndex)
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetObjectAttributeName_155(base.GetCppThis(), objectType, objectIndex, attribIndex));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetObjectAttributeStatus_156(HandleRef pThis, int objectType, int objectIndex, int attribIndex);

		public int GetObjectAttributeStatus(int objectType, int objectIndex, int attribIndex)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetObjectAttributeStatus_156(base.GetCppThis(), objectType, objectIndex, attribIndex);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetObjectAttributeStatus_157(HandleRef pThis, int objectType, int objectIndex, string attribName);

		public int GetObjectAttributeStatus(int objectType, int objectIndex, string attribName)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetObjectAttributeStatus_157(base.GetCppThis(), objectType, objectIndex, attribName);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetObjectId_158(HandleRef pThis, int objectType, int objectIndex);

		public int GetObjectId(int objectType, int objectIndex)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetObjectId_158(base.GetCppThis(), objectType, objectIndex);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetObjectIdArrayName_159();

		public static string GetObjectIdArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetObjectIdArrayName_159());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetObjectIndex_160(HandleRef pThis, int objectType, string objectName);

		public int GetObjectIndex(int objectType, string objectName)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetObjectIndex_160(base.GetCppThis(), objectType, objectName);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetObjectIndex_161(HandleRef pThis, int objectType, int id);

		public int GetObjectIndex(int objectType, int id)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetObjectIndex_161(base.GetCppThis(), objectType, id);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetObjectName_162(HandleRef pThis, int objectType, int objectIndex);

		public string GetObjectName(int objectType, int objectIndex)
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetObjectName_162(base.GetCppThis(), objectType, objectIndex));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetObjectStatus_163(HandleRef pThis, int objectType, int objectIndex);

		public int GetObjectStatus(int objectType, int objectIndex)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetObjectStatus_163(base.GetCppThis(), objectType, objectIndex);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetObjectStatus_164(HandleRef pThis, int objectType, string objectName);

		public int GetObjectStatus(int objectType, string objectName)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetObjectStatus_164(base.GetCppThis(), objectType, objectName);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetObjectTypeFromName_165(HandleRef pThis, string name);

		public int GetObjectTypeFromName(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetObjectTypeFromName_165(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetObjectTypeName_166(HandleRef pThis, int arg0);

		public string GetObjectTypeName(int arg0)
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetObjectTypeName_166(base.GetCppThis(), arg0));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetPackExodusModelOntoOutput_167(HandleRef pThis);

		public virtual int GetPackExodusModelOntoOutput()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetPackExodusModelOntoOutput_167(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetPartArrayID_168(HandleRef pThis, string name);

		public int GetPartArrayID(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetPartArrayID_168(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetPartArrayName_169(HandleRef pThis, int arrayIdx);

		public string GetPartArrayName(int arrayIdx)
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetPartArrayName_169(base.GetCppThis(), arrayIdx));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetPartArrayStatus_170(HandleRef pThis, int index);

		public int GetPartArrayStatus(int index)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetPartArrayStatus_170(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetPartArrayStatus_171(HandleRef pThis, string arg0);

		public int GetPartArrayStatus(string arg0)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetPartArrayStatus_171(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetPartBlockInfo_172(HandleRef pThis, int arrayIdx);

		public string GetPartBlockInfo(int arrayIdx)
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetPartBlockInfo_172(base.GetCppThis(), arrayIdx));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetPedigreeEdgeIdArrayName_173();

		public static string GetPedigreeEdgeIdArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetPedigreeEdgeIdArrayName_173());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetPedigreeElementIdArrayName_174();

		public static string GetPedigreeElementIdArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetPedigreeElementIdArrayName_174());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetPedigreeFaceIdArrayName_175();

		public static string GetPedigreeFaceIdArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetPedigreeFaceIdArrayName_175());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetPedigreeNodeIdArrayName_176();

		public static string GetPedigreeNodeIdArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetPedigreeNodeIdArrayName_176());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetPointResultArrayName_177(HandleRef pThis, int index);

		public string GetPointResultArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetPointResultArrayName_177(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetPointResultArrayStatus_178(HandleRef pThis, string name);

		public int GetPointResultArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetPointResultArrayStatus_178(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern byte vtkExodusIIReader_GetProducedFastPathOutput_179(HandleRef pThis);

		public virtual bool GetProducedFastPathOutput()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetProducedFastPathOutput_179(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetSIL_180(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkGraph GetSIL()
		{
			vtkGraph vtkGraph = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExodusIIReader.vtkExodusIIReader_GetSIL_180(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraph = (vtkGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraph.Register(null);
				}
			}
			return vtkGraph;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetSILUpdateStamp_181(HandleRef pThis);

		public virtual int GetSILUpdateStamp()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetSILUpdateStamp_181(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetSideSetArrayName_182(HandleRef pThis, int index);

		public string GetSideSetArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetSideSetArrayName_182(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetSideSetArrayStatus_183(HandleRef pThis, string name);

		public int GetSideSetArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetSideSetArrayStatus_183(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetSideSetResultArrayName_184(HandleRef pThis, int index);

		public string GetSideSetResultArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetSideSetResultArrayName_184(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetSideSetResultArrayStatus_185(HandleRef pThis, string name);

		public int GetSideSetResultArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetSideSetResultArrayStatus_185(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetTimeSeriesData_186(HandleRef pThis, int ID, string vName, string vType, HandleRef result);

		public int GetTimeSeriesData(int ID, string vName, string vType, vtkFloatArray result)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetTimeSeriesData_186(base.GetCppThis(), ID, vName, vType, (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetTimeStep_187(HandleRef pThis);

		public virtual int GetTimeStep()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetTimeStep_187(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetTimeStepRange_188(HandleRef pThis);

		public virtual int[] GetTimeStepRange()
		{
			IntPtr intPtr = vtkExodusIIReader.vtkExodusIIReader_GetTimeStepRange_188(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_GetTimeStepRange_189(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetTimeStepRange(ref int _arg1, ref int _arg2)
		{
			vtkExodusIIReader.vtkExodusIIReader_GetTimeStepRange_189(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_GetTimeStepRange_190(HandleRef pThis, IntPtr _arg);

		public virtual void GetTimeStepRange(IntPtr _arg)
		{
			vtkExodusIIReader.vtkExodusIIReader_GetTimeStepRange_190(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetTitle_191(HandleRef pThis);

		public string GetTitle()
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetTitle_191(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern long vtkExodusIIReader_GetTotalNumberOfEdges_192(HandleRef pThis);

		public virtual long GetTotalNumberOfEdges()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetTotalNumberOfEdges_192(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern long vtkExodusIIReader_GetTotalNumberOfElements_193(HandleRef pThis);

		public virtual long GetTotalNumberOfElements()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetTotalNumberOfElements_193(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern long vtkExodusIIReader_GetTotalNumberOfFaces_194(HandleRef pThis);

		public virtual long GetTotalNumberOfFaces()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetTotalNumberOfFaces_194(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern long vtkExodusIIReader_GetTotalNumberOfNodes_195(HandleRef pThis);

		public virtual long GetTotalNumberOfNodes()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetTotalNumberOfNodes_195(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_GetVariableID_196(HandleRef pThis, string type, string name);

		public int GetVariableID(string type, string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetVariableID_196(base.GetCppThis(), type, name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_GetXMLFileName_197(HandleRef pThis);

		public virtual string GetXMLFileName()
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetXMLFileName_197(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_HasModeShapesOff_198(HandleRef pThis);

		public virtual void HasModeShapesOff()
		{
			vtkExodusIIReader.vtkExodusIIReader_HasModeShapesOff_198(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_HasModeShapesOn_199(HandleRef pThis);

		public virtual void HasModeShapesOn()
		{
			vtkExodusIIReader.vtkExodusIIReader_HasModeShapesOn_199(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_IsA_200(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExodusIIReader.vtkExodusIIReader_IsA_200(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_IsTypeOf_201(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExodusIIReader.vtkExodusIIReader_IsTypeOf_201(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIIReader_IsValidVariable_202(HandleRef pThis, string type, string name);

		public int IsValidVariable(string type, string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_IsValidVariable_202(base.GetCppThis(), type, name);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_NewInstance_204(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExodusIIReader NewInstance()
		{
			vtkExodusIIReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExodusIIReader.vtkExodusIIReader_NewInstance_204(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExodusIIReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_PackExodusModelOntoOutputOff_205(HandleRef pThis);

		public virtual void PackExodusModelOntoOutputOff()
		{
			vtkExodusIIReader.vtkExodusIIReader_PackExodusModelOntoOutputOff_205(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_PackExodusModelOntoOutputOn_206(HandleRef pThis);

		public virtual void PackExodusModelOntoOutputOn()
		{
			vtkExodusIIReader.vtkExodusIIReader_PackExodusModelOntoOutputOn_206(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_Reset_207(HandleRef pThis);

		public void Reset()
		{
			vtkExodusIIReader.vtkExodusIIReader_Reset_207(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_ResetCache_208(HandleRef pThis);

		public void ResetCache()
		{
			vtkExodusIIReader.vtkExodusIIReader_ResetCache_208(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_ResetSettings_209(HandleRef pThis);

		public void ResetSettings()
		{
			vtkExodusIIReader.vtkExodusIIReader_ResetSettings_209(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIReader_SafeDownCast_210(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExodusIIReader SafeDownCast(vtkObjectBase o)
		{
			vtkExodusIIReader vtkExodusIIReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExodusIIReader.vtkExodusIIReader_SafeDownCast_210((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExodusIIReader = (vtkExodusIIReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExodusIIReader.Register(null);
				}
			}
			return vtkExodusIIReader;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetAllArrayStatus_211(HandleRef pThis, int otype, int status);

		public void SetAllArrayStatus(int otype, int status)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetAllArrayStatus_211(base.GetCppThis(), otype, status);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetAnimateModeShapes_212(HandleRef pThis, int flag);

		public virtual void SetAnimateModeShapes(int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetAnimateModeShapes_212(base.GetCppThis(), flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetApplyDisplacements_213(HandleRef pThis, int d);

		public virtual void SetApplyDisplacements(int d)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetApplyDisplacements_213(base.GetCppThis(), d);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetAssemblyArrayStatus_214(HandleRef pThis, int index, int flag);

		public void SetAssemblyArrayStatus(int index, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetAssemblyArrayStatus_214(base.GetCppThis(), index, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetAssemblyArrayStatus_215(HandleRef pThis, string arg0, int flag);

		public void SetAssemblyArrayStatus(string arg0, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetAssemblyArrayStatus_215(base.GetCppThis(), arg0, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetDisplacementMagnitude_216(HandleRef pThis, float s);

		public virtual void SetDisplacementMagnitude(float s)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetDisplacementMagnitude_216(base.GetCppThis(), s);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetDisplayType_217(HandleRef pThis, int type);

		public virtual void SetDisplayType(int type)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetDisplayType_217(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetEdgeBlockArrayStatus_218(HandleRef pThis, string name, int flag);

		public void SetEdgeBlockArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetEdgeBlockArrayStatus_218(base.GetCppThis(), name, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetEdgeFieldDecorations_219(HandleRef pThis, int d);

		public virtual void SetEdgeFieldDecorations(int d)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetEdgeFieldDecorations_219(base.GetCppThis(), d);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetEdgeMapArrayStatus_220(HandleRef pThis, string name, int flag);

		public void SetEdgeMapArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetEdgeMapArrayStatus_220(base.GetCppThis(), name, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetEdgeResultArrayStatus_221(HandleRef pThis, string name, int flag);

		public void SetEdgeResultArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetEdgeResultArrayStatus_221(base.GetCppThis(), name, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetEdgeSetArrayStatus_222(HandleRef pThis, string name, int flag);

		public void SetEdgeSetArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetEdgeSetArrayStatus_222(base.GetCppThis(), name, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetEdgeSetResultArrayStatus_223(HandleRef pThis, string name, int flag);

		public void SetEdgeSetResultArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetEdgeSetResultArrayStatus_223(base.GetCppThis(), name, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetElementBlockArrayStatus_224(HandleRef pThis, string name, int flag);

		public void SetElementBlockArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetElementBlockArrayStatus_224(base.GetCppThis(), name, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetElementMapArrayStatus_225(HandleRef pThis, string name, int flag);

		public void SetElementMapArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetElementMapArrayStatus_225(base.GetCppThis(), name, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetElementResultArrayStatus_226(HandleRef pThis, string name, int flag);

		public void SetElementResultArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetElementResultArrayStatus_226(base.GetCppThis(), name, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetElementSetArrayStatus_227(HandleRef pThis, string name, int flag);

		public void SetElementSetArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetElementSetArrayStatus_227(base.GetCppThis(), name, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetElementSetResultArrayStatus_228(HandleRef pThis, string name, int flag);

		public void SetElementSetResultArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetElementSetResultArrayStatus_228(base.GetCppThis(), name, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetExodusModelMetadata_229(HandleRef pThis, int _arg);

		public virtual void SetExodusModelMetadata(int _arg)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetExodusModelMetadata_229(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetFaceBlockArrayStatus_230(HandleRef pThis, string name, int flag);

		public void SetFaceBlockArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetFaceBlockArrayStatus_230(base.GetCppThis(), name, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetFaceFieldDecorations_231(HandleRef pThis, int d);

		public virtual void SetFaceFieldDecorations(int d)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetFaceFieldDecorations_231(base.GetCppThis(), d);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetFaceMapArrayStatus_232(HandleRef pThis, string name, int flag);

		public void SetFaceMapArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetFaceMapArrayStatus_232(base.GetCppThis(), name, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetFaceResultArrayStatus_233(HandleRef pThis, string name, int flag);

		public void SetFaceResultArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetFaceResultArrayStatus_233(base.GetCppThis(), name, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetFaceSetArrayStatus_234(HandleRef pThis, string name, int flag);

		public void SetFaceSetArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetFaceSetArrayStatus_234(base.GetCppThis(), name, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetFaceSetResultArrayStatus_235(HandleRef pThis, string name, int flag);

		public void SetFaceSetResultArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetFaceSetResultArrayStatus_235(base.GetCppThis(), name, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetFastPathIdType_236(HandleRef pThis, string type);

		public void SetFastPathIdType(string type)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetFastPathIdType_236(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetFastPathObjectId_237(HandleRef pThis, long id);

		public void SetFastPathObjectId(long id)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetFastPathObjectId_237(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetFastPathObjectType_238(HandleRef pThis, string type);

		public void SetFastPathObjectType(string type)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetFastPathObjectType_238(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetFileId_239(HandleRef pThis, int f);

		public virtual void SetFileId(int f)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetFileId_239(base.GetCppThis(), f);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetFileName_240(HandleRef pThis, string fname);

		public virtual void SetFileName(string fname)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetFileName_240(base.GetCppThis(), fname);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetGenerateFileIdArray_241(HandleRef pThis, int f);

		public virtual void SetGenerateFileIdArray(int f)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetGenerateFileIdArray_241(base.GetCppThis(), f);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetGenerateGlobalElementIdArray_242(HandleRef pThis, int g);

		public virtual void SetGenerateGlobalElementIdArray(int g)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetGenerateGlobalElementIdArray_242(base.GetCppThis(), g);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetGenerateGlobalNodeIdArray_243(HandleRef pThis, int g);

		public virtual void SetGenerateGlobalNodeIdArray(int g)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetGenerateGlobalNodeIdArray_243(base.GetCppThis(), g);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetGenerateImplicitElementIdArray_244(HandleRef pThis, int g);

		public virtual void SetGenerateImplicitElementIdArray(int g)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetGenerateImplicitElementIdArray_244(base.GetCppThis(), g);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetGenerateImplicitNodeIdArray_245(HandleRef pThis, int g);

		public virtual void SetGenerateImplicitNodeIdArray(int g)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetGenerateImplicitNodeIdArray_245(base.GetCppThis(), g);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetGenerateObjectIdCellArray_246(HandleRef pThis, int g);

		public virtual void SetGenerateObjectIdCellArray(int g)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetGenerateObjectIdCellArray_246(base.GetCppThis(), g);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetGlobalResultArrayStatus_247(HandleRef pThis, string name, int flag);

		public void SetGlobalResultArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetGlobalResultArrayStatus_247(base.GetCppThis(), name, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetHasModeShapes_248(HandleRef pThis, int ms);

		public virtual void SetHasModeShapes(int ms)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetHasModeShapes_248(base.GetCppThis(), ms);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetHierarchyArrayStatus_249(HandleRef pThis, int index, int flag);

		public void SetHierarchyArrayStatus(int index, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetHierarchyArrayStatus_249(base.GetCppThis(), index, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetHierarchyArrayStatus_250(HandleRef pThis, string arg0, int flag);

		public void SetHierarchyArrayStatus(string arg0, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetHierarchyArrayStatus_250(base.GetCppThis(), arg0, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetMaterialArrayStatus_251(HandleRef pThis, int index, int flag);

		public void SetMaterialArrayStatus(int index, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetMaterialArrayStatus_251(base.GetCppThis(), index, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetMaterialArrayStatus_252(HandleRef pThis, string arg0, int flag);

		public void SetMaterialArrayStatus(string arg0, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetMaterialArrayStatus_252(base.GetCppThis(), arg0, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetModeShape_253(HandleRef pThis, int val);

		public void SetModeShape(int val)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetModeShape_253(base.GetCppThis(), val);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetModeShapeTime_254(HandleRef pThis, double phase);

		public virtual void SetModeShapeTime(double phase)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetModeShapeTime_254(base.GetCppThis(), phase);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetNodeMapArrayStatus_255(HandleRef pThis, string name, int flag);

		public void SetNodeMapArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetNodeMapArrayStatus_255(base.GetCppThis(), name, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetNodeSetArrayStatus_256(HandleRef pThis, string name, int flag);

		public void SetNodeSetArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetNodeSetArrayStatus_256(base.GetCppThis(), name, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetNodeSetResultArrayStatus_257(HandleRef pThis, string name, int flag);

		public void SetNodeSetResultArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetNodeSetResultArrayStatus_257(base.GetCppThis(), name, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetObjectArrayStatus_258(HandleRef pThis, int objectType, int arrayIndex, int status);

		public void SetObjectArrayStatus(int objectType, int arrayIndex, int status)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetObjectArrayStatus_258(base.GetCppThis(), objectType, arrayIndex, status);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetObjectArrayStatus_259(HandleRef pThis, int objectType, string arrayName, int status);

		public void SetObjectArrayStatus(int objectType, string arrayName, int status)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetObjectArrayStatus_259(base.GetCppThis(), objectType, arrayName, status);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetObjectAttributeStatus_260(HandleRef pThis, int objectType, int objectIndex, int attribIndex, int status);

		public void SetObjectAttributeStatus(int objectType, int objectIndex, int attribIndex, int status)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetObjectAttributeStatus_260(base.GetCppThis(), objectType, objectIndex, attribIndex, status);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetObjectAttributeStatus_261(HandleRef pThis, int objectType, int objectIndex, string attribName, int status);

		public void SetObjectAttributeStatus(int objectType, int objectIndex, string attribName, int status)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetObjectAttributeStatus_261(base.GetCppThis(), objectType, objectIndex, attribName, status);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetObjectStatus_262(HandleRef pThis, int objectType, int objectIndex, int status);

		public void SetObjectStatus(int objectType, int objectIndex, int status)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetObjectStatus_262(base.GetCppThis(), objectType, objectIndex, status);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetObjectStatus_263(HandleRef pThis, int objectType, string objectName, int status);

		public void SetObjectStatus(int objectType, string objectName, int status)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetObjectStatus_263(base.GetCppThis(), objectType, objectName, status);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetPackExodusModelOntoOutput_264(HandleRef pThis, int _arg);

		public virtual void SetPackExodusModelOntoOutput(int _arg)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetPackExodusModelOntoOutput_264(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetPartArrayStatus_265(HandleRef pThis, int index, int flag);

		public void SetPartArrayStatus(int index, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetPartArrayStatus_265(base.GetCppThis(), index, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetPartArrayStatus_266(HandleRef pThis, string arg0, int flag);

		public void SetPartArrayStatus(string arg0, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetPartArrayStatus_266(base.GetCppThis(), arg0, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetPointResultArrayStatus_267(HandleRef pThis, string name, int flag);

		public void SetPointResultArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetPointResultArrayStatus_267(base.GetCppThis(), name, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetSideSetArrayStatus_268(HandleRef pThis, string name, int flag);

		public void SetSideSetArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetSideSetArrayStatus_268(base.GetCppThis(), name, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetSideSetResultArrayStatus_269(HandleRef pThis, string name, int flag);

		public void SetSideSetResultArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetSideSetResultArrayStatus_269(base.GetCppThis(), name, flag);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetTimeStep_270(HandleRef pThis, int _arg);

		public virtual void SetTimeStep(int _arg)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetTimeStep_270(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetTimeStepRange_271(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetTimeStepRange(int _arg1, int _arg2)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetTimeStepRange_271(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetTimeStepRange_272(HandleRef pThis, IntPtr _arg);

		public void SetTimeStepRange(IntPtr _arg)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetTimeStepRange_272(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_SetXMLFileName_273(HandleRef pThis, string fname);

		public virtual void SetXMLFileName(string fname)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetXMLFileName_273(base.GetCppThis(), fname);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIIReader_UpdateTimeInformation_274(HandleRef pThis);

		public virtual void UpdateTimeInformation()
		{
			vtkExodusIIReader.vtkExodusIIReader_UpdateTimeInformation_274(base.GetCppThis());
		}
	}
}
