using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkStructuredGrid : vtkPointSet
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredGrid";

		public new static readonly string MRClassNameKey;

		static vtkStructuredGrid()
		{
			vtkStructuredGrid.MRClassNameKey = "class vtkStructuredGrid";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStructuredGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredGrid"));
		}

		public vtkStructuredGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStructuredGrid New()
		{
			vtkStructuredGrid result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredGrid.vtkStructuredGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkStructuredGrid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkStructuredGrid.vtkStructuredGrid_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkStructuredGrid_BlankCell_01(HandleRef pThis, long ptId);

		public void BlankCell(long ptId)
		{
			vtkStructuredGrid.vtkStructuredGrid_BlankCell_01(base.GetCppThis(), ptId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkStructuredGrid_BlankPoint_02(HandleRef pThis, long ptId);

		public void BlankPoint(long ptId)
		{
			vtkStructuredGrid.vtkStructuredGrid_BlankPoint_02(base.GetCppThis(), ptId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkStructuredGrid_CopyStructure_03(HandleRef pThis, HandleRef ds);

		public override void CopyStructure(vtkDataSet ds)
		{
			vtkStructuredGrid.vtkStructuredGrid_CopyStructure_03(base.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkStructuredGrid_Crop_04(HandleRef pThis);

		public override void Crop()
		{
			vtkStructuredGrid.vtkStructuredGrid_Crop_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkStructuredGrid_DeepCopy_05(HandleRef pThis, HandleRef src);

		public override void DeepCopy(vtkDataObject src)
		{
			vtkStructuredGrid.vtkStructuredGrid_DeepCopy_05(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkStructuredGrid_GetActualMemorySize_06(HandleRef pThis);

		public override uint GetActualMemorySize()
		{
			return vtkStructuredGrid.vtkStructuredGrid_GetActualMemorySize_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredGrid_GetCell_07(HandleRef pThis, long cellId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkCell GetCell(long cellId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredGrid.vtkStructuredGrid_GetCell_07(base.GetCppThis(), cellId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkStructuredGrid_GetCell_08(HandleRef pThis, long cellId, HandleRef cell);

		public override void GetCell(long cellId, vtkGenericCell cell)
		{
			vtkStructuredGrid.vtkStructuredGrid_GetCell_08(base.GetCppThis(), cellId, (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern byte vtkStructuredGrid_GetCellBlanking_09(HandleRef pThis);

		public byte GetCellBlanking()
		{
			return vtkStructuredGrid.vtkStructuredGrid_GetCellBlanking_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkStructuredGrid_GetCellBounds_10(HandleRef pThis, long cellId, IntPtr bounds);

		public override void GetCellBounds(long cellId, IntPtr bounds)
		{
			vtkStructuredGrid.vtkStructuredGrid_GetCellBounds_10(base.GetCppThis(), cellId, bounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkStructuredGrid_GetCellNeighbors_11(HandleRef pThis, long cellId, HandleRef ptIds, HandleRef cellIds);

		public override void GetCellNeighbors(long cellId, vtkIdList ptIds, vtkIdList cellIds)
		{
			vtkStructuredGrid.vtkStructuredGrid_GetCellNeighbors_11(base.GetCppThis(), cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkStructuredGrid_GetCellPoints_12(HandleRef pThis, long cellId, HandleRef ptIds);

		public override void GetCellPoints(long cellId, vtkIdList ptIds)
		{
			vtkStructuredGrid.vtkStructuredGrid_GetCellPoints_12(base.GetCppThis(), cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStructuredGrid_GetCellType_13(HandleRef pThis, long cellId);

		public override int GetCellType(long cellId)
		{
			return vtkStructuredGrid.vtkStructuredGrid_GetCellType_13(base.GetCppThis(), cellId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredGrid_GetCellVisibilityArray_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkUnsignedCharArray GetCellVisibilityArray()
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredGrid.vtkStructuredGrid_GetCellVisibilityArray_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkStructuredGrid_GetData_15(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStructuredGrid GetData(vtkInformation info)
		{
			vtkStructuredGrid vtkStructuredGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredGrid.vtkStructuredGrid_GetData_15((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGrid = (vtkStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGrid.Register(null);
				}
			}
			return vtkStructuredGrid;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredGrid_GetData_16(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStructuredGrid GetData(vtkInformationVector v, int i)
		{
			vtkStructuredGrid vtkStructuredGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredGrid.vtkStructuredGrid_GetData_16((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGrid = (vtkStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGrid.Register(null);
				}
			}
			return vtkStructuredGrid;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStructuredGrid_GetDataDimension_17(HandleRef pThis);

		public int GetDataDimension()
		{
			return vtkStructuredGrid.vtkStructuredGrid_GetDataDimension_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStructuredGrid_GetDataObjectType_18(HandleRef pThis);

		public override int GetDataObjectType()
		{
			return vtkStructuredGrid.vtkStructuredGrid_GetDataObjectType_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredGrid_GetDimensions_19(HandleRef pThis);

		public virtual int[] GetDimensions()
		{
			IntPtr intPtr = vtkStructuredGrid.vtkStructuredGrid_GetDimensions_19(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkStructuredGrid_GetDimensions_20(HandleRef pThis, IntPtr dim);

		public virtual void GetDimensions(IntPtr dim)
		{
			vtkStructuredGrid.vtkStructuredGrid_GetDimensions_20(base.GetCppThis(), dim);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredGrid_GetExtent_21(HandleRef pThis);

		public virtual int[] GetExtent()
		{
			IntPtr intPtr = vtkStructuredGrid.vtkStructuredGrid_GetExtent_21(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkStructuredGrid_GetExtent_22(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		public virtual void GetExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkStructuredGrid.vtkStructuredGrid_GetExtent_22(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkStructuredGrid_GetExtent_23(HandleRef pThis, IntPtr _arg);

		public virtual void GetExtent(IntPtr _arg)
		{
			vtkStructuredGrid.vtkStructuredGrid_GetExtent_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStructuredGrid_GetExtentType_24(HandleRef pThis);

		public override int GetExtentType()
		{
			return vtkStructuredGrid.vtkStructuredGrid_GetExtentType_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStructuredGrid_GetMaxCellSize_25(HandleRef pThis);

		public override int GetMaxCellSize()
		{
			return vtkStructuredGrid.vtkStructuredGrid_GetMaxCellSize_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkStructuredGrid_GetNumberOfCells_26(HandleRef pThis);

		public override long GetNumberOfCells()
		{
			return vtkStructuredGrid.vtkStructuredGrid_GetNumberOfCells_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkStructuredGrid_GetNumberOfPoints_27(HandleRef pThis);

		public override long GetNumberOfPoints()
		{
			return vtkStructuredGrid.vtkStructuredGrid_GetNumberOfPoints_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredGrid_GetPoint_28(HandleRef pThis, long ptId);

		public override double[] GetPoint(long ptId)
		{
			IntPtr intPtr = vtkStructuredGrid.vtkStructuredGrid_GetPoint_28(base.GetCppThis(), ptId);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkStructuredGrid_GetPoint_29(HandleRef pThis, long ptId, IntPtr p);

		public override void GetPoint(long ptId, IntPtr p)
		{
			vtkStructuredGrid.vtkStructuredGrid_GetPoint_29(base.GetCppThis(), ptId, p);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkStructuredGrid_GetPoint_30(HandleRef pThis, int i, int j, int k, IntPtr p, byte adjustForExtent);

		public void GetPoint(int i, int j, int k, IntPtr p, bool adjustForExtent)
		{
			vtkStructuredGrid.vtkStructuredGrid_GetPoint_30(base.GetCppThis(), i, j, k, p, adjustForExtent ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern byte vtkStructuredGrid_GetPointBlanking_31(HandleRef pThis);

		public byte GetPointBlanking()
		{
			return vtkStructuredGrid.vtkStructuredGrid_GetPointBlanking_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkStructuredGrid_GetPointCells_32(HandleRef pThis, long ptId, HandleRef cellIds);

		public override void GetPointCells(long ptId, vtkIdList cellIds)
		{
			vtkStructuredGrid.vtkStructuredGrid_GetPointCells_32(base.GetCppThis(), ptId, (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredGrid_GetPointVisibilityArray_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkUnsignedCharArray GetPointVisibilityArray()
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredGrid.vtkStructuredGrid_GetPointVisibilityArray_33(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkStructuredGrid_GetScalarRange_34(HandleRef pThis, IntPtr range);

		public override void GetScalarRange(IntPtr range)
		{
			vtkStructuredGrid.vtkStructuredGrid_GetScalarRange_34(base.GetCppThis(), range);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredGrid_GetScalarRange_35(HandleRef pThis);

		public new double[] GetScalarRange()
		{
			IntPtr intPtr = vtkStructuredGrid.vtkStructuredGrid_GetScalarRange_35(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkStructuredGrid_Initialize_36(HandleRef pThis);

		public override void Initialize()
		{
			vtkStructuredGrid.vtkStructuredGrid_Initialize_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStructuredGrid_IsA_37(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkStructuredGrid.vtkStructuredGrid_IsA_37(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern byte vtkStructuredGrid_IsCellVisible_38(HandleRef pThis, long cellId);

		public byte IsCellVisible(long cellId)
		{
			return vtkStructuredGrid.vtkStructuredGrid_IsCellVisible_38(base.GetCppThis(), cellId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern byte vtkStructuredGrid_IsPointVisible_39(HandleRef pThis, long ptId);

		public byte IsPointVisible(long ptId)
		{
			return vtkStructuredGrid.vtkStructuredGrid_IsPointVisible_39(base.GetCppThis(), ptId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStructuredGrid_IsTypeOf_40(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkStructuredGrid.vtkStructuredGrid_IsTypeOf_40(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredGrid_NewInstance_42(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkStructuredGrid NewInstance()
		{
			vtkStructuredGrid result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredGrid.vtkStructuredGrid_NewInstance_42(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredGrid_SafeDownCast_43(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStructuredGrid SafeDownCast(vtkObjectBase o)
		{
			vtkStructuredGrid vtkStructuredGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredGrid.vtkStructuredGrid_SafeDownCast_43((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGrid = (vtkStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGrid.Register(null);
				}
			}
			return vtkStructuredGrid;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkStructuredGrid_SetCellVisibilityArray_44(HandleRef pThis, HandleRef pointVisibility);

		public void SetCellVisibilityArray(vtkUnsignedCharArray pointVisibility)
		{
			vtkStructuredGrid.vtkStructuredGrid_SetCellVisibilityArray_44(base.GetCppThis(), (pointVisibility == null) ? default(HandleRef) : pointVisibility.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkStructuredGrid_SetDimensions_45(HandleRef pThis, int i, int j, int k);

		public void SetDimensions(int i, int j, int k)
		{
			vtkStructuredGrid.vtkStructuredGrid_SetDimensions_45(base.GetCppThis(), i, j, k);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkStructuredGrid_SetDimensions_46(HandleRef pThis, IntPtr dim);

		public void SetDimensions(IntPtr dim)
		{
			vtkStructuredGrid.vtkStructuredGrid_SetDimensions_46(base.GetCppThis(), dim);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkStructuredGrid_SetExtent_47(HandleRef pThis, IntPtr extent);

		public void SetExtent(IntPtr extent)
		{
			vtkStructuredGrid.vtkStructuredGrid_SetExtent_47(base.GetCppThis(), extent);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkStructuredGrid_SetExtent_48(HandleRef pThis, int x1, int x2, int y1, int y2, int z1, int z2);

		public void SetExtent(int x1, int x2, int y1, int y2, int z1, int z2)
		{
			vtkStructuredGrid.vtkStructuredGrid_SetExtent_48(base.GetCppThis(), x1, x2, y1, y2, z1, z2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkStructuredGrid_SetPointVisibilityArray_49(HandleRef pThis, HandleRef pointVisibility);

		public void SetPointVisibilityArray(vtkUnsignedCharArray pointVisibility)
		{
			vtkStructuredGrid.vtkStructuredGrid_SetPointVisibilityArray_49(base.GetCppThis(), (pointVisibility == null) ? default(HandleRef) : pointVisibility.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkStructuredGrid_ShallowCopy_50(HandleRef pThis, HandleRef src);

		public override void ShallowCopy(vtkDataObject src)
		{
			vtkStructuredGrid.vtkStructuredGrid_ShallowCopy_50(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkStructuredGrid_UnBlankCell_51(HandleRef pThis, long ptId);

		public void UnBlankCell(long ptId)
		{
			vtkStructuredGrid.vtkStructuredGrid_UnBlankCell_51(base.GetCppThis(), ptId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkStructuredGrid_UnBlankPoint_52(HandleRef pThis, long ptId);

		public void UnBlankPoint(long ptId)
		{
			vtkStructuredGrid.vtkStructuredGrid_UnBlankPoint_52(base.GetCppThis(), ptId);
		}
	}
}
