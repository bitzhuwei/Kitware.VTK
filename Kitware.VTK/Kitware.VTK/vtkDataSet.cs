using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkDataSet : vtkDataObject
	{
		public enum FieldDataType
		{
			CELL_DATA_FIELD = 2,
			DATA_OBJECT_FIELD = 0,
			POINT_DATA_FIELD
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkDataSet";

		public new static readonly string MRClassNameKey;

		static vtkDataSet()
		{
			vtkDataSet.MRClassNameKey = "class vtkDataSet";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataSet.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataSet"));
		}

		public vtkDataSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataSet_CheckAttributes_01(HandleRef pThis);

		public int CheckAttributes()
		{
			return vtkDataSet.vtkDataSet_CheckAttributes_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSet_ComputeBounds_02(HandleRef pThis);

		public virtual void ComputeBounds()
		{
			vtkDataSet.vtkDataSet_ComputeBounds_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSet_CopyAttributes_03(HandleRef pThis, HandleRef ds);

		public virtual void CopyAttributes(vtkDataSet ds)
		{
			vtkDataSet.vtkDataSet_CopyAttributes_03(base.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSet_CopyStructure_04(HandleRef pThis, HandleRef ds);

		public virtual void CopyStructure(vtkDataSet ds)
		{
			vtkDataSet.vtkDataSet_CopyStructure_04(base.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSet_DeepCopy_05(HandleRef pThis, HandleRef src);

		public override void DeepCopy(vtkDataObject src)
		{
			vtkDataSet.vtkDataSet_DeepCopy_05(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSet_FindAndGetCell_06(HandleRef pThis, IntPtr x, HandleRef cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCell FindAndGetCell(IntPtr x, vtkCell cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSet.vtkDataSet_FindAndGetCell_06(base.GetCppThis(), x, (cell == null) ? default(HandleRef) : cell.GetCppThis(), cellId, tol2, ref subId, pcoords, weights, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern long vtkDataSet_FindCell_07(HandleRef pThis, IntPtr x, HandleRef cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights);

		public virtual long FindCell(IntPtr x, vtkCell cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
		{
			return vtkDataSet.vtkDataSet_FindCell_07(base.GetCppThis(), x, (cell == null) ? default(HandleRef) : cell.GetCppThis(), cellId, tol2, ref subId, pcoords, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkDataSet_FindCell_08(HandleRef pThis, IntPtr x, HandleRef cell, HandleRef gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights);

		public virtual long FindCell(IntPtr x, vtkCell cell, vtkGenericCell gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
		{
			return vtkDataSet.vtkDataSet_FindCell_08(base.GetCppThis(), x, (cell == null) ? default(HandleRef) : cell.GetCppThis(), (gencell == null) ? default(HandleRef) : gencell.GetCppThis(), cellId, tol2, ref subId, pcoords, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkDataSet_FindPoint_09(HandleRef pThis, double x, double y, double z);

		public long FindPoint(double x, double y, double z)
		{
			return vtkDataSet.vtkDataSet_FindPoint_09(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkDataSet_FindPoint_10(HandleRef pThis, IntPtr x);

		public virtual long FindPoint(IntPtr x)
		{
			return vtkDataSet.vtkDataSet_FindPoint_10(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSet_GenerateGhostLevelArray_11(HandleRef pThis);

		public virtual void GenerateGhostLevelArray()
		{
			vtkDataSet.vtkDataSet_GenerateGhostLevelArray_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkDataSet_GetActualMemorySize_12(HandleRef pThis);

		public override uint GetActualMemorySize()
		{
			return vtkDataSet.vtkDataSet_GetActualMemorySize_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSet_GetAttributesAsFieldData_13(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkFieldData GetAttributesAsFieldData(int type)
		{
			vtkFieldData vtkFieldData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSet.vtkDataSet_GetAttributesAsFieldData_13(base.GetCppThis(), type, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFieldData = (vtkFieldData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFieldData.Register(null);
				}
			}
			return vtkFieldData;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSet_GetBounds_14(HandleRef pThis);

		public double[] GetBounds()
		{
			IntPtr intPtr = vtkDataSet.vtkDataSet_GetBounds_14(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSet_GetBounds_15(HandleRef pThis, IntPtr bounds);

		public void GetBounds(IntPtr bounds)
		{
			vtkDataSet.vtkDataSet_GetBounds_15(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSet_GetCell_16(HandleRef pThis, long cellId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCell GetCell(long cellId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSet.vtkDataSet_GetCell_16(base.GetCppThis(), cellId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkDataSet_GetCell_17(HandleRef pThis, long cellId, HandleRef cell);

		public virtual void GetCell(long cellId, vtkGenericCell cell)
		{
			vtkDataSet.vtkDataSet_GetCell_17(base.GetCppThis(), cellId, (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSet_GetCellBounds_18(HandleRef pThis, long cellId, IntPtr bounds);

		public virtual void GetCellBounds(long cellId, IntPtr bounds)
		{
			vtkDataSet.vtkDataSet_GetCellBounds_18(base.GetCppThis(), cellId, bounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSet_GetCellData_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkCellData GetCellData()
		{
			vtkCellData vtkCellData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSet.vtkDataSet_GetCellData_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellData = (vtkCellData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellData.Register(null);
				}
			}
			return vtkCellData;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSet_GetCellNeighbors_20(HandleRef pThis, long cellId, HandleRef ptIds, HandleRef cellIds);

		public virtual void GetCellNeighbors(long cellId, vtkIdList ptIds, vtkIdList cellIds)
		{
			vtkDataSet.vtkDataSet_GetCellNeighbors_20(base.GetCppThis(), cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSet_GetCellPoints_21(HandleRef pThis, long cellId, HandleRef ptIds);

		public virtual void GetCellPoints(long cellId, vtkIdList ptIds)
		{
			vtkDataSet.vtkDataSet_GetCellPoints_21(base.GetCppThis(), cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataSet_GetCellType_22(HandleRef pThis, long cellId);

		public virtual int GetCellType(long cellId)
		{
			return vtkDataSet.vtkDataSet_GetCellType_22(base.GetCppThis(), cellId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSet_GetCellTypes_23(HandleRef pThis, HandleRef types);

		public virtual void GetCellTypes(vtkCellTypes types)
		{
			vtkDataSet.vtkDataSet_GetCellTypes_23(base.GetCppThis(), (types == null) ? default(HandleRef) : types.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSet_GetCenter_24(HandleRef pThis);

		public double[] GetCenter()
		{
			IntPtr intPtr = vtkDataSet.vtkDataSet_GetCenter_24(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSet_GetCenter_25(HandleRef pThis, IntPtr center);

		public void GetCenter(IntPtr center)
		{
			vtkDataSet.vtkDataSet_GetCenter_25(base.GetCppThis(), center);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSet_GetData_26(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataSet GetData(vtkInformation info)
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSet.vtkDataSet_GetData_26((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSet_GetData_27(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataSet GetData(vtkInformationVector v, int i)
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSet.vtkDataSet_GetData_27((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataSet_GetDataObjectType_28(HandleRef pThis);

		public override int GetDataObjectType()
		{
			return vtkDataSet.vtkDataSet_GetDataObjectType_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkDataSet_GetLength_29(HandleRef pThis);

		public double GetLength()
		{
			return vtkDataSet.vtkDataSet_GetLength_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkDataSet_GetMTime_30(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkDataSet.vtkDataSet_GetMTime_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataSet_GetMaxCellSize_31(HandleRef pThis);

		public virtual int GetMaxCellSize()
		{
			return vtkDataSet.vtkDataSet_GetMaxCellSize_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkDataSet_GetNumberOfCells_32(HandleRef pThis);

		public virtual long GetNumberOfCells()
		{
			return vtkDataSet.vtkDataSet_GetNumberOfCells_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkDataSet_GetNumberOfElements_33(HandleRef pThis, int type);

		public override long GetNumberOfElements(int type)
		{
			return vtkDataSet.vtkDataSet_GetNumberOfElements_33(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkDataSet_GetNumberOfPoints_34(HandleRef pThis);

		public virtual long GetNumberOfPoints()
		{
			return vtkDataSet.vtkDataSet_GetNumberOfPoints_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSet_GetPoint_35(HandleRef pThis, long ptId);

		public virtual double[] GetPoint(long ptId)
		{
			IntPtr intPtr = vtkDataSet.vtkDataSet_GetPoint_35(base.GetCppThis(), ptId);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSet_GetPoint_36(HandleRef pThis, long id, IntPtr x);

		public virtual void GetPoint(long id, IntPtr x)
		{
			vtkDataSet.vtkDataSet_GetPoint_36(base.GetCppThis(), id, x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSet_GetPointCells_37(HandleRef pThis, long ptId, HandleRef cellIds);

		public virtual void GetPointCells(long ptId, vtkIdList cellIds)
		{
			vtkDataSet.vtkDataSet_GetPointCells_37(base.GetCppThis(), ptId, (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSet_GetPointData_38(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPointData GetPointData()
		{
			vtkPointData vtkPointData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSet.vtkDataSet_GetPointData_38(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointData = (vtkPointData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointData.Register(null);
				}
			}
			return vtkPointData;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSet_GetScalarRange_39(HandleRef pThis, IntPtr range);

		public virtual void GetScalarRange(IntPtr range)
		{
			vtkDataSet.vtkDataSet_GetScalarRange_39(base.GetCppThis(), range);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSet_GetScalarRange_40(HandleRef pThis);

		public double[] GetScalarRange()
		{
			IntPtr intPtr = vtkDataSet.vtkDataSet_GetScalarRange_40(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSet_Initialize_41(HandleRef pThis);

		public override void Initialize()
		{
			vtkDataSet.vtkDataSet_Initialize_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataSet_IsA_42(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDataSet.vtkDataSet_IsA_42(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataSet_IsTypeOf_43(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDataSet.vtkDataSet_IsTypeOf_43(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSet_NewInstance_44(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDataSet NewInstance()
		{
			vtkDataSet result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSet.vtkDataSet_NewInstance_44(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSet_SafeDownCast_45(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataSet SafeDownCast(vtkObjectBase o)
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSet.vtkDataSet_SafeDownCast_45((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSet_ShallowCopy_46(HandleRef pThis, HandleRef src);

		public override void ShallowCopy(vtkDataObject src)
		{
			vtkDataSet.vtkDataSet_ShallowCopy_46(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSet_Squeeze_47(HandleRef pThis);

		public virtual void Squeeze()
		{
			vtkDataSet.vtkDataSet_Squeeze_47(base.GetCppThis());
		}
	}
}
