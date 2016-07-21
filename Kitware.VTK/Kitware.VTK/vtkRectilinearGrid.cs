using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRectilinearGrid : vtkDataSet
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRectilinearGrid";

		public new static readonly string MRClassNameKey;

		static vtkRectilinearGrid()
		{
			vtkRectilinearGrid.MRClassNameKey = "class vtkRectilinearGrid";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRectilinearGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRectilinearGrid"));
		}

		public vtkRectilinearGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkRectilinearGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRectilinearGrid New()
		{
			vtkRectilinearGrid result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRectilinearGrid.vtkRectilinearGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectilinearGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRectilinearGrid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRectilinearGrid.vtkRectilinearGrid_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkRectilinearGrid_ComputeBounds_01(HandleRef pThis);

		public override void ComputeBounds()
		{
			vtkRectilinearGrid.vtkRectilinearGrid_ComputeBounds_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkRectilinearGrid_ComputeCellId_02(HandleRef pThis, IntPtr ijk);

		public long ComputeCellId(IntPtr ijk)
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_ComputeCellId_02(base.GetCppThis(), ijk);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkRectilinearGrid_ComputePointId_03(HandleRef pThis, IntPtr ijk);

		public long ComputePointId(IntPtr ijk)
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_ComputePointId_03(base.GetCppThis(), ijk);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkRectilinearGrid_ComputeStructuredCoordinates_04(HandleRef pThis, IntPtr x, IntPtr ijk, IntPtr pcoords);

		public int ComputeStructuredCoordinates(IntPtr x, IntPtr ijk, IntPtr pcoords)
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_ComputeStructuredCoordinates_04(base.GetCppThis(), x, ijk, pcoords);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkRectilinearGrid_CopyStructure_05(HandleRef pThis, HandleRef ds);

		public override void CopyStructure(vtkDataSet ds)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_CopyStructure_05(base.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkRectilinearGrid_Crop_06(HandleRef pThis);

		public override void Crop()
		{
			vtkRectilinearGrid.vtkRectilinearGrid_Crop_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkRectilinearGrid_DeepCopy_07(HandleRef pThis, HandleRef src);

		public override void DeepCopy(vtkDataObject src)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_DeepCopy_07(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkRectilinearGrid_FindAndGetCell_08(HandleRef pThis, IntPtr x, HandleRef cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkCell FindAndGetCell(IntPtr x, vtkCell cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRectilinearGrid.vtkRectilinearGrid_FindAndGetCell_08(base.GetCppThis(), x, (cell == null) ? default(HandleRef) : cell.GetCppThis(), cellId, tol2, ref subId, pcoords, weights, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern long vtkRectilinearGrid_FindCell_09(HandleRef pThis, IntPtr x, HandleRef cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights);

		public override long FindCell(IntPtr x, vtkCell cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_FindCell_09(base.GetCppThis(), x, (cell == null) ? default(HandleRef) : cell.GetCppThis(), cellId, tol2, ref subId, pcoords, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkRectilinearGrid_FindCell_10(HandleRef pThis, IntPtr x, HandleRef cell, HandleRef gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights);

		public override long FindCell(IntPtr x, vtkCell cell, vtkGenericCell gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_FindCell_10(base.GetCppThis(), x, (cell == null) ? default(HandleRef) : cell.GetCppThis(), (gencell == null) ? default(HandleRef) : gencell.GetCppThis(), cellId, tol2, ref subId, pcoords, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkRectilinearGrid_FindPoint_11(HandleRef pThis, double x, double y, double z);

		public new long FindPoint(double x, double y, double z)
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_FindPoint_11(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkRectilinearGrid_FindPoint_12(HandleRef pThis, IntPtr x);

		public override long FindPoint(IntPtr x)
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_FindPoint_12(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkRectilinearGrid_GetActualMemorySize_13(HandleRef pThis);

		public override uint GetActualMemorySize()
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_GetActualMemorySize_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkRectilinearGrid_GetCell_14(HandleRef pThis, long cellId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkCell GetCell(long cellId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRectilinearGrid.vtkRectilinearGrid_GetCell_14(base.GetCppThis(), cellId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkRectilinearGrid_GetCell_15(HandleRef pThis, long cellId, HandleRef cell);

		public override void GetCell(long cellId, vtkGenericCell cell)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_GetCell_15(base.GetCppThis(), cellId, (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkRectilinearGrid_GetCellBounds_16(HandleRef pThis, long cellId, IntPtr bounds);

		public override void GetCellBounds(long cellId, IntPtr bounds)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_GetCellBounds_16(base.GetCppThis(), cellId, bounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkRectilinearGrid_GetCellNeighbors_17(HandleRef pThis, long cellId, HandleRef ptIds, HandleRef cellIds);

		public override void GetCellNeighbors(long cellId, vtkIdList ptIds, vtkIdList cellIds)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_GetCellNeighbors_17(base.GetCppThis(), cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkRectilinearGrid_GetCellPoints_18(HandleRef pThis, long cellId, HandleRef ptIds);

		public override void GetCellPoints(long cellId, vtkIdList ptIds)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_GetCellPoints_18(base.GetCppThis(), cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkRectilinearGrid_GetCellType_19(HandleRef pThis, long cellId);

		public override int GetCellType(long cellId)
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_GetCellType_19(base.GetCppThis(), cellId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkRectilinearGrid_GetData_20(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRectilinearGrid GetData(vtkInformation info)
		{
			vtkRectilinearGrid vtkRectilinearGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRectilinearGrid.vtkRectilinearGrid_GetData_20((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectilinearGrid = (vtkRectilinearGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectilinearGrid.Register(null);
				}
			}
			return vtkRectilinearGrid;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkRectilinearGrid_GetData_21(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRectilinearGrid GetData(vtkInformationVector v, int i)
		{
			vtkRectilinearGrid vtkRectilinearGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRectilinearGrid.vtkRectilinearGrid_GetData_21((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectilinearGrid = (vtkRectilinearGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectilinearGrid.Register(null);
				}
			}
			return vtkRectilinearGrid;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkRectilinearGrid_GetDataDimension_22(HandleRef pThis);

		public int GetDataDimension()
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_GetDataDimension_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkRectilinearGrid_GetDataObjectType_23(HandleRef pThis);

		public override int GetDataObjectType()
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_GetDataObjectType_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkRectilinearGrid_GetDimensions_24(HandleRef pThis);

		public virtual int[] GetDimensions()
		{
			IntPtr intPtr = vtkRectilinearGrid.vtkRectilinearGrid_GetDimensions_24(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkRectilinearGrid_GetDimensions_25(HandleRef pThis, IntPtr data);

		public virtual void GetDimensions(IntPtr data)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_GetDimensions_25(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkRectilinearGrid_GetExtent_26(HandleRef pThis);

		public virtual int[] GetExtent()
		{
			IntPtr intPtr = vtkRectilinearGrid.vtkRectilinearGrid_GetExtent_26(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkRectilinearGrid_GetExtent_27(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		public virtual void GetExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_GetExtent_27(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkRectilinearGrid_GetExtent_28(HandleRef pThis, IntPtr _arg);

		public virtual void GetExtent(IntPtr _arg)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_GetExtent_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkRectilinearGrid_GetExtentType_29(HandleRef pThis);

		public override int GetExtentType()
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_GetExtentType_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkRectilinearGrid_GetMaxCellSize_30(HandleRef pThis);

		public override int GetMaxCellSize()
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_GetMaxCellSize_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkRectilinearGrid_GetNumberOfCells_31(HandleRef pThis);

		public override long GetNumberOfCells()
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_GetNumberOfCells_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkRectilinearGrid_GetNumberOfPoints_32(HandleRef pThis);

		public override long GetNumberOfPoints()
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_GetNumberOfPoints_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkRectilinearGrid_GetPoint_33(HandleRef pThis, long ptId);

		public override double[] GetPoint(long ptId)
		{
			IntPtr intPtr = vtkRectilinearGrid.vtkRectilinearGrid_GetPoint_33(base.GetCppThis(), ptId);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkRectilinearGrid_GetPoint_34(HandleRef pThis, long id, IntPtr x);

		public override void GetPoint(long id, IntPtr x)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_GetPoint_34(base.GetCppThis(), id, x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkRectilinearGrid_GetPointCells_35(HandleRef pThis, long ptId, HandleRef cellIds);

		public override void GetPointCells(long ptId, vtkIdList cellIds)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_GetPointCells_35(base.GetCppThis(), ptId, (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkRectilinearGrid_GetXCoordinates_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataArray GetXCoordinates()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRectilinearGrid.vtkRectilinearGrid_GetXCoordinates_36(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkRectilinearGrid_GetYCoordinates_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataArray GetYCoordinates()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRectilinearGrid.vtkRectilinearGrid_GetYCoordinates_37(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkRectilinearGrid_GetZCoordinates_38(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataArray GetZCoordinates()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRectilinearGrid.vtkRectilinearGrid_GetZCoordinates_38(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkRectilinearGrid_Initialize_39(HandleRef pThis);

		public override void Initialize()
		{
			vtkRectilinearGrid.vtkRectilinearGrid_Initialize_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkRectilinearGrid_IsA_40(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_IsA_40(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkRectilinearGrid_IsTypeOf_41(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRectilinearGrid.vtkRectilinearGrid_IsTypeOf_41(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkRectilinearGrid_NewInstance_43(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRectilinearGrid NewInstance()
		{
			vtkRectilinearGrid result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRectilinearGrid.vtkRectilinearGrid_NewInstance_43(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectilinearGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkRectilinearGrid_SafeDownCast_44(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRectilinearGrid SafeDownCast(vtkObjectBase o)
		{
			vtkRectilinearGrid vtkRectilinearGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRectilinearGrid.vtkRectilinearGrid_SafeDownCast_44((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectilinearGrid = (vtkRectilinearGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectilinearGrid.Register(null);
				}
			}
			return vtkRectilinearGrid;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkRectilinearGrid_SetDimensions_45(HandleRef pThis, int i, int j, int k);

		public void SetDimensions(int i, int j, int k)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_SetDimensions_45(base.GetCppThis(), i, j, k);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkRectilinearGrid_SetDimensions_46(HandleRef pThis, IntPtr dim);

		public void SetDimensions(IntPtr dim)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_SetDimensions_46(base.GetCppThis(), dim);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkRectilinearGrid_SetExtent_47(HandleRef pThis, IntPtr extent);

		public void SetExtent(IntPtr extent)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_SetExtent_47(base.GetCppThis(), extent);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkRectilinearGrid_SetExtent_48(HandleRef pThis, int x1, int x2, int y1, int y2, int z1, int z2);

		public void SetExtent(int x1, int x2, int y1, int y2, int z1, int z2)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_SetExtent_48(base.GetCppThis(), x1, x2, y1, y2, z1, z2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkRectilinearGrid_SetXCoordinates_49(HandleRef pThis, HandleRef arg0);

		public virtual void SetXCoordinates(vtkDataArray arg0)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_SetXCoordinates_49(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkRectilinearGrid_SetYCoordinates_50(HandleRef pThis, HandleRef arg0);

		public virtual void SetYCoordinates(vtkDataArray arg0)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_SetYCoordinates_50(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkRectilinearGrid_SetZCoordinates_51(HandleRef pThis, HandleRef arg0);

		public virtual void SetZCoordinates(vtkDataArray arg0)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_SetZCoordinates_51(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkRectilinearGrid_ShallowCopy_52(HandleRef pThis, HandleRef src);

		public override void ShallowCopy(vtkDataObject src)
		{
			vtkRectilinearGrid.vtkRectilinearGrid_ShallowCopy_52(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}
	}
}
