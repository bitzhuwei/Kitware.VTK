using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPolyData : vtkPointSet
	{
		public enum ERR_INCORRECT_FIELD_WrapperEnum
		{
			ERR_INCORRECT_FIELD = -3,
			ERR_NON_MANIFOLD_STAR,
			ERR_NO_SUCH_FIELD = -4,
			MAXIMUM = 2,
			MINIMUM = 0,
			REGULAR_POINT = -1,
			SADDLE = 1
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyData";

		public new static readonly string MRClassNameKey;

		static vtkPolyData()
		{
			vtkPolyData.MRClassNameKey = "class vtkPolyData";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyData"));
		}

		public vtkPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolyData New()
		{
			vtkPolyData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyData.vtkPolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPolyData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPolyData.vtkPolyData_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_AddCellReference_01(HandleRef pThis, long cellId);

		public void AddCellReference(long cellId)
		{
			vtkPolyData.vtkPolyData_AddCellReference_01(base.GetCppThis(), cellId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_AddReferenceToCell_02(HandleRef pThis, long ptId, long cellId);

		public void AddReferenceToCell(long ptId, long cellId)
		{
			vtkPolyData.vtkPolyData_AddReferenceToCell_02(base.GetCppThis(), ptId, cellId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_Allocate_03(HandleRef pThis, long numCells, int extSize);

		public void Allocate(long numCells, int extSize)
		{
			vtkPolyData.vtkPolyData_Allocate_03(base.GetCppThis(), numCells, extSize);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_Allocate_04(HandleRef pThis, HandleRef inPolyData, long numCells, int extSize);

		public void Allocate(vtkPolyData inPolyData, long numCells, int extSize)
		{
			vtkPolyData.vtkPolyData_Allocate_04(base.GetCppThis(), (inPolyData == null) ? default(HandleRef) : inPolyData.GetCppThis(), numCells, extSize);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_BuildCells_05(HandleRef pThis);

		public void BuildCells()
		{
			vtkPolyData.vtkPolyData_BuildCells_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_BuildLinks_06(HandleRef pThis, int initialSize);

		public void BuildLinks(int initialSize)
		{
			vtkPolyData.vtkPolyData_BuildLinks_06(base.GetCppThis(), initialSize);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_ComputeBounds_07(HandleRef pThis);

		public override void ComputeBounds()
		{
			vtkPolyData.vtkPolyData_ComputeBounds_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_CopyCells_08(HandleRef pThis, HandleRef pd, HandleRef idList, HandleRef locator);

		public void CopyCells(vtkPolyData pd, vtkIdList idList, vtkPointLocator locator)
		{
			vtkPolyData.vtkPolyData_CopyCells_08(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis(), (idList == null) ? default(HandleRef) : idList.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_CopyStructure_09(HandleRef pThis, HandleRef ds);

		public override void CopyStructure(vtkDataSet ds)
		{
			vtkPolyData.vtkPolyData_CopyStructure_09(base.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_DeepCopy_10(HandleRef pThis, HandleRef src);

		public override void DeepCopy(vtkDataObject src)
		{
			vtkPolyData.vtkPolyData_DeepCopy_10(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_DeleteCell_11(HandleRef pThis, long cellId);

		public void DeleteCell(long cellId)
		{
			vtkPolyData.vtkPolyData_DeleteCell_11(base.GetCppThis(), cellId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_DeleteCells_12(HandleRef pThis);

		public void DeleteCells()
		{
			vtkPolyData.vtkPolyData_DeleteCells_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_DeleteLinks_13(HandleRef pThis);

		public void DeleteLinks()
		{
			vtkPolyData.vtkPolyData_DeleteLinks_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_DeletePoint_14(HandleRef pThis, long ptId);

		public void DeletePoint(long ptId)
		{
			vtkPolyData.vtkPolyData_DeletePoint_14(base.GetCppThis(), ptId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkPolyData_GetActualMemorySize_15(HandleRef pThis);

		public override uint GetActualMemorySize()
		{
			return vtkPolyData.vtkPolyData_GetActualMemorySize_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyData_GetCell_16(HandleRef pThis, long cellId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkCell GetCell(long cellId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyData.vtkPolyData_GetCell_16(base.GetCppThis(), cellId, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCell = (vtkCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCell.Register(null);
				}
			}
			return vtkCell;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_GetCell_17(HandleRef pThis, long cellId, HandleRef cell);

		public override void GetCell(long cellId, vtkGenericCell cell)
		{
			vtkPolyData.vtkPolyData_GetCell_17(base.GetCppThis(), cellId, (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_GetCellBounds_18(HandleRef pThis, long cellId, IntPtr bounds);

		public override void GetCellBounds(long cellId, IntPtr bounds)
		{
			vtkPolyData.vtkPolyData_GetCellBounds_18(base.GetCppThis(), cellId, bounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_GetCellEdgeNeighbors_19(HandleRef pThis, long cellId, long p1, long p2, HandleRef cellIds);

		public void GetCellEdgeNeighbors(long cellId, long p1, long p2, vtkIdList cellIds)
		{
			vtkPolyData.vtkPolyData_GetCellEdgeNeighbors_19(base.GetCppThis(), cellId, p1, p2, (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_GetCellNeighbors_20(HandleRef pThis, long cellId, HandleRef ptIds, HandleRef cellIds);

		public override void GetCellNeighbors(long cellId, vtkIdList ptIds, vtkIdList cellIds)
		{
			vtkPolyData.vtkPolyData_GetCellNeighbors_20(base.GetCppThis(), cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_GetCellPoints_21(HandleRef pThis, long cellId, HandleRef ptIds);

		public override void GetCellPoints(long cellId, vtkIdList ptIds)
		{
			vtkPolyData.vtkPolyData_GetCellPoints_21(base.GetCppThis(), cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolyData_GetCellType_22(HandleRef pThis, long cellId);

		public override int GetCellType(long cellId)
		{
			return vtkPolyData.vtkPolyData_GetCellType_22(base.GetCppThis(), cellId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyData_GetData_23(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolyData GetData(vtkInformation info)
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyData.vtkPolyData_GetData_23((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyData_GetData_24(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolyData GetData(vtkInformationVector v, int i)
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyData.vtkPolyData_GetData_24((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolyData_GetDataObjectType_25(HandleRef pThis);

		public override int GetDataObjectType()
		{
			return vtkPolyData.vtkPolyData_GetDataObjectType_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolyData_GetGhostLevel_26(HandleRef pThis);

		public virtual int GetGhostLevel()
		{
			return vtkPolyData.vtkPolyData_GetGhostLevel_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyData_GetLines_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkCellArray GetLines()
		{
			vtkCellArray vtkCellArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyData.vtkPolyData_GetLines_27(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellArray = (vtkCellArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellArray.Register(null);
				}
			}
			return vtkCellArray;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolyData_GetMaxCellSize_28(HandleRef pThis);

		public override int GetMaxCellSize()
		{
			return vtkPolyData.vtkPolyData_GetMaxCellSize_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkPolyData_GetNumberOfCells_29(HandleRef pThis);

		public override long GetNumberOfCells()
		{
			return vtkPolyData.vtkPolyData_GetNumberOfCells_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkPolyData_GetNumberOfLines_30(HandleRef pThis);

		public long GetNumberOfLines()
		{
			return vtkPolyData.vtkPolyData_GetNumberOfLines_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolyData_GetNumberOfPieces_31(HandleRef pThis);

		public virtual int GetNumberOfPieces()
		{
			return vtkPolyData.vtkPolyData_GetNumberOfPieces_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkPolyData_GetNumberOfPolys_32(HandleRef pThis);

		public long GetNumberOfPolys()
		{
			return vtkPolyData.vtkPolyData_GetNumberOfPolys_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkPolyData_GetNumberOfStrips_33(HandleRef pThis);

		public long GetNumberOfStrips()
		{
			return vtkPolyData.vtkPolyData_GetNumberOfStrips_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkPolyData_GetNumberOfVerts_34(HandleRef pThis);

		public long GetNumberOfVerts()
		{
			return vtkPolyData.vtkPolyData_GetNumberOfVerts_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolyData_GetPiece_35(HandleRef pThis);

		public virtual int GetPiece()
		{
			return vtkPolyData.vtkPolyData_GetPiece_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_GetPointCells_36(HandleRef pThis, long ptId, HandleRef cellIds);

		public override void GetPointCells(long ptId, vtkIdList cellIds)
		{
			vtkPolyData.vtkPolyData_GetPointCells_36(base.GetCppThis(), ptId, (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyData_GetPolys_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkCellArray GetPolys()
		{
			vtkCellArray vtkCellArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyData.vtkPolyData_GetPolys_37(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellArray = (vtkCellArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellArray.Register(null);
				}
			}
			return vtkCellArray;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolyData_GetScalarFieldCriticalIndex_38(HandleRef pThis, long pointId, HandleRef scalarField);

		public int GetScalarFieldCriticalIndex(long pointId, vtkDataArray scalarField)
		{
			return vtkPolyData.vtkPolyData_GetScalarFieldCriticalIndex_38(base.GetCppThis(), pointId, (scalarField == null) ? default(HandleRef) : scalarField.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolyData_GetScalarFieldCriticalIndex_39(HandleRef pThis, long pointId, int fieldId);

		public int GetScalarFieldCriticalIndex(long pointId, int fieldId)
		{
			return vtkPolyData.vtkPolyData_GetScalarFieldCriticalIndex_39(base.GetCppThis(), pointId, fieldId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolyData_GetScalarFieldCriticalIndex_40(HandleRef pThis, long pointId, string fieldName);

		public int GetScalarFieldCriticalIndex(long pointId, string fieldName)
		{
			return vtkPolyData.vtkPolyData_GetScalarFieldCriticalIndex_40(base.GetCppThis(), pointId, fieldName);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyData_GetStrips_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkCellArray GetStrips()
		{
			vtkCellArray vtkCellArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyData.vtkPolyData_GetStrips_41(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellArray = (vtkCellArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellArray.Register(null);
				}
			}
			return vtkCellArray;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_GetUpdateExtent_42(HandleRef pThis, ref int piece, ref int numPieces, ref int ghostLevel);

		public void GetUpdateExtent(ref int piece, ref int numPieces, ref int ghostLevel)
		{
			vtkPolyData.vtkPolyData_GetUpdateExtent_42(base.GetCppThis(), ref piece, ref numPieces, ref ghostLevel);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyData_GetUpdateExtent_43(HandleRef pThis);

		public override int[] GetUpdateExtent()
		{
			IntPtr intPtr = vtkPolyData.vtkPolyData_GetUpdateExtent_43(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_GetUpdateExtent_44(HandleRef pThis, ref int x0, ref int x1, ref int y0, ref int y1, ref int z0, ref int z1);

		public override void GetUpdateExtent(ref int x0, ref int x1, ref int y0, ref int y1, ref int z0, ref int z1)
		{
			vtkPolyData.vtkPolyData_GetUpdateExtent_44(base.GetCppThis(), ref x0, ref x1, ref y0, ref y1, ref z0, ref z1);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_GetUpdateExtent_45(HandleRef pThis, IntPtr extent);

		public override void GetUpdateExtent(IntPtr extent)
		{
			vtkPolyData.vtkPolyData_GetUpdateExtent_45(base.GetCppThis(), extent);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyData_GetVerts_46(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkCellArray GetVerts()
		{
			vtkCellArray vtkCellArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyData.vtkPolyData_GetVerts_46(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellArray = (vtkCellArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellArray.Register(null);
				}
			}
			return vtkCellArray;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_Initialize_47(HandleRef pThis);

		public override void Initialize()
		{
			vtkPolyData.vtkPolyData_Initialize_47(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolyData_InsertNextCell_48(HandleRef pThis, int type, int npts, IntPtr pts);

		public int InsertNextCell(int type, int npts, IntPtr pts)
		{
			return vtkPolyData.vtkPolyData_InsertNextCell_48(base.GetCppThis(), type, npts, pts);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolyData_InsertNextCell_49(HandleRef pThis, int type, HandleRef pts);

		public int InsertNextCell(int type, vtkIdList pts)
		{
			return vtkPolyData.vtkPolyData_InsertNextCell_49(base.GetCppThis(), type, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolyData_InsertNextLinkedCell_50(HandleRef pThis, int type, int npts, IntPtr pts);

		public int InsertNextLinkedCell(int type, int npts, IntPtr pts)
		{
			return vtkPolyData.vtkPolyData_InsertNextLinkedCell_50(base.GetCppThis(), type, npts, pts);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolyData_InsertNextLinkedPoint_51(HandleRef pThis, int numLinks);

		public int InsertNextLinkedPoint(int numLinks)
		{
			return vtkPolyData.vtkPolyData_InsertNextLinkedPoint_51(base.GetCppThis(), numLinks);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolyData_InsertNextLinkedPoint_52(HandleRef pThis, IntPtr x, int numLinks);

		public int InsertNextLinkedPoint(IntPtr x, int numLinks)
		{
			return vtkPolyData.vtkPolyData_InsertNextLinkedPoint_52(base.GetCppThis(), x, numLinks);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolyData_IsA_53(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPolyData.vtkPolyData_IsA_53(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolyData_IsEdge_54(HandleRef pThis, long p1, long p2);

		public int IsEdge(long p1, long p2)
		{
			return vtkPolyData.vtkPolyData_IsEdge_54(base.GetCppThis(), p1, p2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolyData_IsPointUsedByCell_55(HandleRef pThis, long ptId, long cellId);

		public int IsPointUsedByCell(long ptId, long cellId)
		{
			return vtkPolyData.vtkPolyData_IsPointUsedByCell_55(base.GetCppThis(), ptId, cellId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolyData_IsTriangle_56(HandleRef pThis, int v1, int v2, int v3);

		public int IsTriangle(int v1, int v2, int v3)
		{
			return vtkPolyData.vtkPolyData_IsTriangle_56(base.GetCppThis(), v1, v2, v3);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolyData_IsTypeOf_57(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPolyData.vtkPolyData_IsTypeOf_57(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyData_NewInstance_59(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPolyData NewInstance()
		{
			vtkPolyData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyData.vtkPolyData_NewInstance_59(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_RemoveCellReference_60(HandleRef pThis, long cellId);

		public void RemoveCellReference(long cellId)
		{
			vtkPolyData.vtkPolyData_RemoveCellReference_60(base.GetCppThis(), cellId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_RemoveDeletedCells_61(HandleRef pThis);

		public void RemoveDeletedCells()
		{
			vtkPolyData.vtkPolyData_RemoveDeletedCells_61(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_RemoveGhostCells_62(HandleRef pThis, int level);

		public void RemoveGhostCells(int level)
		{
			vtkPolyData.vtkPolyData_RemoveGhostCells_62(base.GetCppThis(), level);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_RemoveReferenceToCell_63(HandleRef pThis, long ptId, long cellId);

		public void RemoveReferenceToCell(long ptId, long cellId)
		{
			vtkPolyData.vtkPolyData_RemoveReferenceToCell_63(base.GetCppThis(), ptId, cellId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_ReplaceCell_64(HandleRef pThis, long cellId, int npts, IntPtr pts);

		public void ReplaceCell(long cellId, int npts, IntPtr pts)
		{
			vtkPolyData.vtkPolyData_ReplaceCell_64(base.GetCppThis(), cellId, npts, pts);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_ReplaceCellPoint_65(HandleRef pThis, long cellId, long oldPtId, long newPtId);

		public void ReplaceCellPoint(long cellId, long oldPtId, long newPtId)
		{
			vtkPolyData.vtkPolyData_ReplaceCellPoint_65(base.GetCppThis(), cellId, oldPtId, newPtId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_ReplaceLinkedCell_66(HandleRef pThis, long cellId, int npts, IntPtr pts);

		public void ReplaceLinkedCell(long cellId, int npts, IntPtr pts)
		{
			vtkPolyData.vtkPolyData_ReplaceLinkedCell_66(base.GetCppThis(), cellId, npts, pts);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_Reset_67(HandleRef pThis);

		public void Reset()
		{
			vtkPolyData.vtkPolyData_Reset_67(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_ResizeCellList_68(HandleRef pThis, long ptId, int size);

		public void ResizeCellList(long ptId, int size)
		{
			vtkPolyData.vtkPolyData_ResizeCellList_68(base.GetCppThis(), ptId, size);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_ReverseCell_69(HandleRef pThis, long cellId);

		public void ReverseCell(long cellId)
		{
			vtkPolyData.vtkPolyData_ReverseCell_69(base.GetCppThis(), cellId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyData_SafeDownCast_70(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolyData SafeDownCast(vtkObjectBase o)
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyData.vtkPolyData_SafeDownCast_70((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_SetLines_71(HandleRef pThis, HandleRef l);

		public void SetLines(vtkCellArray l)
		{
			vtkPolyData.vtkPolyData_SetLines_71(base.GetCppThis(), (l == null) ? default(HandleRef) : l.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_SetPolys_72(HandleRef pThis, HandleRef p);

		public void SetPolys(vtkCellArray p)
		{
			vtkPolyData.vtkPolyData_SetPolys_72(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_SetStrips_73(HandleRef pThis, HandleRef s);

		public void SetStrips(vtkCellArray s)
		{
			vtkPolyData.vtkPolyData_SetStrips_73(base.GetCppThis(), (s == null) ? default(HandleRef) : s.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_SetVerts_74(HandleRef pThis, HandleRef v);

		public void SetVerts(vtkCellArray v)
		{
			vtkPolyData.vtkPolyData_SetVerts_74(base.GetCppThis(), (v == null) ? default(HandleRef) : v.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_ShallowCopy_75(HandleRef pThis, HandleRef src);

		public override void ShallowCopy(vtkDataObject src)
		{
			vtkPolyData.vtkPolyData_ShallowCopy_75(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyData_Squeeze_76(HandleRef pThis);

		public override void Squeeze()
		{
			vtkPolyData.vtkPolyData_Squeeze_76(base.GetCppThis());
		}
	}
}
