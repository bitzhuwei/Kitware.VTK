using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkUnstructuredGrid : vtkPointSet
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGrid";

		public new static readonly string MRClassNameKey;

		static vtkUnstructuredGrid()
		{
			vtkUnstructuredGrid.MRClassNameKey = "class vtkUnstructuredGrid";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnstructuredGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGrid"));
		}

		public vtkUnstructuredGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnstructuredGrid New()
		{
			vtkUnstructuredGrid result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGrid.vtkUnstructuredGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkUnstructuredGrid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkUnstructuredGrid.vtkUnstructuredGrid_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGrid_AddReferenceToCell_01(HandleRef pThis, long ptId, long cellId);

		public void AddReferenceToCell(long ptId, long cellId)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_AddReferenceToCell_01(base.GetCppThis(), ptId, cellId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGrid_Allocate_02(HandleRef pThis, long numCells, int extSize);

		public virtual void Allocate(long numCells, int extSize)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_Allocate_02(base.GetCppThis(), numCells, extSize);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGrid_BuildLinks_03(HandleRef pThis);

		public void BuildLinks()
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_BuildLinks_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGrid_ConvertFaceStreamPointIds_04(HandleRef faceStream, IntPtr idMap);

		public static void ConvertFaceStreamPointIds(vtkIdList faceStream, IntPtr idMap)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_ConvertFaceStreamPointIds_04((faceStream == null) ? default(HandleRef) : faceStream.GetCppThis(), idMap);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGrid_ConvertFaceStreamPointIds_05(long nfaces, IntPtr faceStream, IntPtr idMap);

		public static void ConvertFaceStreamPointIds(long nfaces, IntPtr faceStream, IntPtr idMap)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_ConvertFaceStreamPointIds_05(nfaces, faceStream, idMap);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGrid_CopyStructure_06(HandleRef pThis, HandleRef ds);

		public override void CopyStructure(vtkDataSet ds)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_CopyStructure_06(base.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGrid_DecomposeAPolyhedronCell_07(HandleRef polyhedronCellArray, ref long nCellpts, ref long nCellfaces, HandleRef cellArray, HandleRef faces);

		public static void DecomposeAPolyhedronCell(vtkCellArray polyhedronCellArray, ref long nCellpts, ref long nCellfaces, vtkCellArray cellArray, vtkIdTypeArray faces)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_DecomposeAPolyhedronCell_07((polyhedronCellArray == null) ? default(HandleRef) : polyhedronCellArray.GetCppThis(), ref nCellpts, ref nCellfaces, (cellArray == null) ? default(HandleRef) : cellArray.GetCppThis(), (faces == null) ? default(HandleRef) : faces.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGrid_DecomposeAPolyhedronCell_08(IntPtr polyhedronCellStream, ref long nCellpts, ref long nCellfaces, HandleRef cellArray, HandleRef faces);

		public static void DecomposeAPolyhedronCell(IntPtr polyhedronCellStream, ref long nCellpts, ref long nCellfaces, vtkCellArray cellArray, vtkIdTypeArray faces)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_DecomposeAPolyhedronCell_08(polyhedronCellStream, ref nCellpts, ref nCellfaces, (cellArray == null) ? default(HandleRef) : cellArray.GetCppThis(), (faces == null) ? default(HandleRef) : faces.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGrid_DecomposeAPolyhedronCell_09(long nCellFaces, IntPtr inFaceStream, ref long nCellpts, HandleRef cellArray, HandleRef faces);

		public static void DecomposeAPolyhedronCell(long nCellFaces, IntPtr inFaceStream, ref long nCellpts, vtkCellArray cellArray, vtkIdTypeArray faces)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_DecomposeAPolyhedronCell_09(nCellFaces, inFaceStream, ref nCellpts, (cellArray == null) ? default(HandleRef) : cellArray.GetCppThis(), (faces == null) ? default(HandleRef) : faces.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGrid_DeepCopy_10(HandleRef pThis, HandleRef src);

		public override void DeepCopy(vtkDataObject src)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_DeepCopy_10(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkUnstructuredGrid_GetActualMemorySize_11(HandleRef pThis);

		public override uint GetActualMemorySize()
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_GetActualMemorySize_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGrid_GetCell_12(HandleRef pThis, long cellId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkCell GetCell(long cellId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGrid.vtkUnstructuredGrid_GetCell_12(base.GetCppThis(), cellId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkUnstructuredGrid_GetCell_13(HandleRef pThis, long cellId, HandleRef cell);

		public override void GetCell(long cellId, vtkGenericCell cell)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_GetCell_13(base.GetCppThis(), cellId, (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGrid_GetCellBounds_14(HandleRef pThis, long cellId, IntPtr bounds);

		public override void GetCellBounds(long cellId, IntPtr bounds)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_GetCellBounds_14(base.GetCppThis(), cellId, bounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGrid_GetCellLinks_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkCellLinks GetCellLinks()
		{
			vtkCellLinks vtkCellLinks = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGrid.vtkUnstructuredGrid_GetCellLinks_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellLinks = (vtkCellLinks)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellLinks.Register(null);
				}
			}
			return vtkCellLinks;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGrid_GetCellLocationsArray_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkIdTypeArray GetCellLocationsArray()
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGrid.vtkUnstructuredGrid_GetCellLocationsArray_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdTypeArray = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdTypeArray.Register(null);
				}
			}
			return vtkIdTypeArray;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGrid_GetCellNeighbors_17(HandleRef pThis, long cellId, HandleRef ptIds, HandleRef cellIds);

		public override void GetCellNeighbors(long cellId, vtkIdList ptIds, vtkIdList cellIds)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_GetCellNeighbors_17(base.GetCppThis(), cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGrid_GetCellPoints_18(HandleRef pThis, long cellId, HandleRef ptIds);

		public override void GetCellPoints(long cellId, vtkIdList ptIds)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_GetCellPoints_18(base.GetCppThis(), cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGrid_GetCellType_19(HandleRef pThis, long cellId);

		public override int GetCellType(long cellId)
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_GetCellType_19(base.GetCppThis(), cellId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGrid_GetCellTypesArray_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkUnsignedCharArray GetCellTypesArray()
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGrid.vtkUnstructuredGrid_GetCellTypesArray_20(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedCharArray = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedCharArray.Register(null);
				}
			}
			return vtkUnsignedCharArray;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGrid_GetCells_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkCellArray GetCells()
		{
			vtkCellArray vtkCellArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGrid.vtkUnstructuredGrid_GetCells_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkUnstructuredGrid_GetData_22(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnstructuredGrid GetData(vtkInformation info)
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGrid.vtkUnstructuredGrid_GetData_22((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGrid = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGrid.Register(null);
				}
			}
			return vtkUnstructuredGrid;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGrid_GetData_23(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnstructuredGrid GetData(vtkInformationVector v, int i)
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGrid.vtkUnstructuredGrid_GetData_23((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGrid = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGrid.Register(null);
				}
			}
			return vtkUnstructuredGrid;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGrid_GetDataObjectType_24(HandleRef pThis);

		public override int GetDataObjectType()
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_GetDataObjectType_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGrid_GetFaceLocations_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkIdTypeArray GetFaceLocations()
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGrid.vtkUnstructuredGrid_GetFaceLocations_25(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdTypeArray = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdTypeArray.Register(null);
				}
			}
			return vtkIdTypeArray;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGrid_GetFaceStream_26(HandleRef pThis, long cellId, HandleRef ptIds);

		public void GetFaceStream(long cellId, vtkIdList ptIds)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_GetFaceStream_26(base.GetCppThis(), cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGrid_GetFaces_27(HandleRef pThis, long cellId);

		public IntPtr GetFaces(long cellId)
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_GetFaces_27(base.GetCppThis(), cellId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGrid_GetFaces_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkIdTypeArray GetFaces()
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGrid.vtkUnstructuredGrid_GetFaces_28(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdTypeArray = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdTypeArray.Register(null);
				}
			}
			return vtkIdTypeArray;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGrid_GetGhostLevel_29(HandleRef pThis);

		public virtual int GetGhostLevel()
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_GetGhostLevel_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGrid_GetIdsOfCellsOfType_30(HandleRef pThis, int type, HandleRef array);

		public void GetIdsOfCellsOfType(int type, vtkIdTypeArray array)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_GetIdsOfCellsOfType_30(base.GetCppThis(), type, (array == null) ? default(HandleRef) : array.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGrid_GetMaxCellSize_31(HandleRef pThis);

		public override int GetMaxCellSize()
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_GetMaxCellSize_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkUnstructuredGrid_GetNumberOfCells_32(HandleRef pThis);

		public override long GetNumberOfCells()
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_GetNumberOfCells_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGrid_GetNumberOfPieces_33(HandleRef pThis);

		public virtual int GetNumberOfPieces()
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_GetNumberOfPieces_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGrid_GetPiece_34(HandleRef pThis);

		public virtual int GetPiece()
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_GetPiece_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGrid_GetPointCells_35(HandleRef pThis, long ptId, HandleRef cellIds);

		public override void GetPointCells(long ptId, vtkIdList cellIds)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_GetPointCells_35(base.GetCppThis(), ptId, (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGrid_GetUpdateExtent_36(HandleRef pThis, ref int x0, ref int x1, ref int y0, ref int y1, ref int z0, ref int z1);

		public override void GetUpdateExtent(ref int x0, ref int x1, ref int y0, ref int y1, ref int z0, ref int z1)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_GetUpdateExtent_36(base.GetCppThis(), ref x0, ref x1, ref y0, ref y1, ref z0, ref z1);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGrid_GetUpdateExtent_37(HandleRef pThis, IntPtr extent);

		public override void GetUpdateExtent(IntPtr extent)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_GetUpdateExtent_37(base.GetCppThis(), extent);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGrid_GetUpdateExtent_38(HandleRef pThis, ref int piece, ref int numPieces, ref int ghostLevel);

		public void GetUpdateExtent(ref int piece, ref int numPieces, ref int ghostLevel)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_GetUpdateExtent_38(base.GetCppThis(), ref piece, ref numPieces, ref ghostLevel);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGrid_GetUpdateExtent_39(HandleRef pThis);

		public override int[] GetUpdateExtent()
		{
			IntPtr intPtr = vtkUnstructuredGrid.vtkUnstructuredGrid_GetUpdateExtent_39(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGrid_Initialize_40(HandleRef pThis);

		public override void Initialize()
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_Initialize_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGrid_InitializeFacesRepresentation_41(HandleRef pThis, long numPrevCells);

		public int InitializeFacesRepresentation(long numPrevCells)
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_InitializeFacesRepresentation_41(base.GetCppThis(), numPrevCells);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkUnstructuredGrid_InsertNextCell_42(HandleRef pThis, int type, long npts, IntPtr ptIds);

		public long InsertNextCell(int type, long npts, IntPtr ptIds)
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_InsertNextCell_42(base.GetCppThis(), type, npts, ptIds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkUnstructuredGrid_InsertNextCell_43(HandleRef pThis, int type, HandleRef ptIds);

		public long InsertNextCell(int type, vtkIdList ptIds)
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_InsertNextCell_43(base.GetCppThis(), type, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkUnstructuredGrid_InsertNextCell_44(HandleRef pThis, int type, long npts, IntPtr ptIds, long nfaces, IntPtr faces);

		public long InsertNextCell(int type, long npts, IntPtr ptIds, long nfaces, IntPtr faces)
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_InsertNextCell_44(base.GetCppThis(), type, npts, ptIds, nfaces, faces);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkUnstructuredGrid_InsertNextLinkedCell_45(HandleRef pThis, int type, int npts, IntPtr pts);

		public long InsertNextLinkedCell(int type, int npts, IntPtr pts)
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_InsertNextLinkedCell_45(base.GetCppThis(), type, npts, pts);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGrid_IsA_46(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_IsA_46(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGrid_IsHomogeneous_47(HandleRef pThis);

		public int IsHomogeneous()
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_IsHomogeneous_47(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGrid_IsTypeOf_48(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkUnstructuredGrid.vtkUnstructuredGrid_IsTypeOf_48(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGrid_NewInstance_50(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkUnstructuredGrid NewInstance()
		{
			vtkUnstructuredGrid result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGrid.vtkUnstructuredGrid_NewInstance_50(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGrid_RemoveGhostCells_51(HandleRef pThis, int level);

		public void RemoveGhostCells(int level)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_RemoveGhostCells_51(base.GetCppThis(), level);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGrid_RemoveReferenceToCell_52(HandleRef pThis, long ptId, long cellId);

		public void RemoveReferenceToCell(long ptId, long cellId)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_RemoveReferenceToCell_52(base.GetCppThis(), ptId, cellId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGrid_ReplaceCell_53(HandleRef pThis, long cellId, int npts, IntPtr pts);

		public void ReplaceCell(long cellId, int npts, IntPtr pts)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_ReplaceCell_53(base.GetCppThis(), cellId, npts, pts);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGrid_Reset_54(HandleRef pThis);

		public void Reset()
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_Reset_54(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGrid_ResizeCellList_55(HandleRef pThis, long ptId, int size);

		public void ResizeCellList(long ptId, int size)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_ResizeCellList_55(base.GetCppThis(), ptId, size);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGrid_SafeDownCast_56(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnstructuredGrid SafeDownCast(vtkObjectBase o)
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGrid.vtkUnstructuredGrid_SafeDownCast_56((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGrid = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGrid.Register(null);
				}
			}
			return vtkUnstructuredGrid;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGrid_SetCells_57(HandleRef pThis, int type, HandleRef cells);

		public void SetCells(int type, vtkCellArray cells)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_SetCells_57(base.GetCppThis(), type, (cells == null) ? default(HandleRef) : cells.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGrid_SetCells_58(HandleRef pThis, IntPtr types, HandleRef cells);

		public void SetCells(IntPtr types, vtkCellArray cells)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_SetCells_58(base.GetCppThis(), types, (cells == null) ? default(HandleRef) : cells.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGrid_SetCells_59(HandleRef pThis, HandleRef cellTypes, HandleRef cellLocations, HandleRef cells);

		public void SetCells(vtkUnsignedCharArray cellTypes, vtkIdTypeArray cellLocations, vtkCellArray cells)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_SetCells_59(base.GetCppThis(), (cellTypes == null) ? default(HandleRef) : cellTypes.GetCppThis(), (cellLocations == null) ? default(HandleRef) : cellLocations.GetCppThis(), (cells == null) ? default(HandleRef) : cells.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGrid_SetCells_60(HandleRef pThis, HandleRef cellTypes, HandleRef cellLocations, HandleRef cells, HandleRef faceLocations, HandleRef faces);

		public void SetCells(vtkUnsignedCharArray cellTypes, vtkIdTypeArray cellLocations, vtkCellArray cells, vtkIdTypeArray faceLocations, vtkIdTypeArray faces)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_SetCells_60(base.GetCppThis(), (cellTypes == null) ? default(HandleRef) : cellTypes.GetCppThis(), (cellLocations == null) ? default(HandleRef) : cellLocations.GetCppThis(), (cells == null) ? default(HandleRef) : cells.GetCppThis(), (faceLocations == null) ? default(HandleRef) : faceLocations.GetCppThis(), (faces == null) ? default(HandleRef) : faces.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGrid_ShallowCopy_61(HandleRef pThis, HandleRef src);

		public override void ShallowCopy(vtkDataObject src)
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_ShallowCopy_61(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGrid_Squeeze_62(HandleRef pThis);

		public override void Squeeze()
		{
			vtkUnstructuredGrid.vtkUnstructuredGrid_Squeeze_62(base.GetCppThis());
		}
	}
}
