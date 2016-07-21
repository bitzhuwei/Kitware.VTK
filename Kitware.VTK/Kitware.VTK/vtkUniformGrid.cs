using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkUniformGrid : vtkImageData
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkUniformGrid";

		public new static readonly string MRClassNameKey;

		static vtkUniformGrid()
		{
			vtkUniformGrid.MRClassNameKey = "class vtkUniformGrid";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUniformGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUniformGrid"));
		}

		public vtkUniformGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUniformGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUniformGrid New()
		{
			vtkUniformGrid result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUniformGrid.vtkUniformGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUniformGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkUniformGrid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkUniformGrid.vtkUniformGrid_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUniformGrid_BlankCell_01(HandleRef pThis, long ptId);

		public virtual void BlankCell(long ptId)
		{
			vtkUniformGrid.vtkUniformGrid_BlankCell_01(base.GetCppThis(), ptId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUniformGrid_BlankPoint_02(HandleRef pThis, long ptId);

		public virtual void BlankPoint(long ptId)
		{
			vtkUniformGrid.vtkUniformGrid_BlankPoint_02(base.GetCppThis(), ptId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUniformGrid_CopyStructure_03(HandleRef pThis, HandleRef ds);

		public override void CopyStructure(vtkDataSet ds)
		{
			vtkUniformGrid.vtkUniformGrid_CopyStructure_03(base.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUniformGrid_DeepCopy_04(HandleRef pThis, HandleRef src);

		public override void DeepCopy(vtkDataObject src)
		{
			vtkUniformGrid.vtkUniformGrid_DeepCopy_04(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUniformGrid_FindAndGetCell_05(HandleRef pThis, IntPtr x, HandleRef cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkCell FindAndGetCell(IntPtr x, vtkCell cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUniformGrid.vtkUniformGrid_FindAndGetCell_05(base.GetCppThis(), x, (cell == null) ? default(HandleRef) : cell.GetCppThis(), cellId, tol2, ref subId, pcoords, weights, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern long vtkUniformGrid_FindCell_06(HandleRef pThis, IntPtr x, HandleRef cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights);

		public override long FindCell(IntPtr x, vtkCell cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
		{
			return vtkUniformGrid.vtkUniformGrid_FindCell_06(base.GetCppThis(), x, (cell == null) ? default(HandleRef) : cell.GetCppThis(), cellId, tol2, ref subId, pcoords, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkUniformGrid_FindCell_07(HandleRef pThis, IntPtr x, HandleRef cell, HandleRef gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights);

		public override long FindCell(IntPtr x, vtkCell cell, vtkGenericCell gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
		{
			return vtkUniformGrid.vtkUniformGrid_FindCell_07(base.GetCppThis(), x, (cell == null) ? default(HandleRef) : cell.GetCppThis(), (gencell == null) ? default(HandleRef) : gencell.GetCppThis(), cellId, tol2, ref subId, pcoords, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUniformGrid_GetCell_08(HandleRef pThis, long cellId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkCell GetCell(long cellId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUniformGrid.vtkUniformGrid_GetCell_08(base.GetCppThis(), cellId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkUniformGrid_GetCell_09(HandleRef pThis, long cellId, HandleRef cell);

		public override void GetCell(long cellId, vtkGenericCell cell)
		{
			vtkUniformGrid.vtkUniformGrid_GetCell_09(base.GetCppThis(), cellId, (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern byte vtkUniformGrid_GetCellBlanking_10(HandleRef pThis);

		public virtual byte GetCellBlanking()
		{
			return vtkUniformGrid.vtkUniformGrid_GetCellBlanking_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUniformGrid_GetCellPoints_11(HandleRef pThis, long cellId, HandleRef ptIds);

		public override void GetCellPoints(long cellId, vtkIdList ptIds)
		{
			vtkUniformGrid.vtkUniformGrid_GetCellPoints_11(base.GetCppThis(), cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkUniformGrid_GetCellType_12(HandleRef pThis, long cellId);

		public override int GetCellType(long cellId)
		{
			return vtkUniformGrid.vtkUniformGrid_GetCellType_12(base.GetCppThis(), cellId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUniformGrid_GetCellVisibilityArray_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkUnsignedCharArray GetCellVisibilityArray()
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUniformGrid.vtkUniformGrid_GetCellVisibilityArray_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkUniformGrid_GetData_14(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUniformGrid GetData(vtkInformation info)
		{
			vtkUniformGrid vtkUniformGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUniformGrid.vtkUniformGrid_GetData_14((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUniformGrid = (vtkUniformGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUniformGrid.Register(null);
				}
			}
			return vtkUniformGrid;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUniformGrid_GetData_15(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUniformGrid GetData(vtkInformationVector v, int i)
		{
			vtkUniformGrid vtkUniformGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUniformGrid.vtkUniformGrid_GetData_15((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUniformGrid = (vtkUniformGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUniformGrid.Register(null);
				}
			}
			return vtkUniformGrid;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkUniformGrid_GetDataObjectType_16(HandleRef pThis);

		public override int GetDataObjectType()
		{
			return vtkUniformGrid.vtkUniformGrid_GetDataObjectType_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkUniformGrid_GetMaxCellSize_17(HandleRef pThis);

		public override int GetMaxCellSize()
		{
			return vtkUniformGrid.vtkUniformGrid_GetMaxCellSize_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern byte vtkUniformGrid_GetPointBlanking_18(HandleRef pThis);

		public virtual byte GetPointBlanking()
		{
			return vtkUniformGrid.vtkUniformGrid_GetPointBlanking_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUniformGrid_GetPointCells_19(HandleRef pThis, long ptId, HandleRef cellIds);

		public override void GetPointCells(long ptId, vtkIdList cellIds)
		{
			vtkUniformGrid.vtkUniformGrid_GetPointCells_19(base.GetCppThis(), ptId, (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUniformGrid_GetPointVisibilityArray_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkUnsignedCharArray GetPointVisibilityArray()
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUniformGrid.vtkUniformGrid_GetPointVisibilityArray_20(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkUniformGrid_Initialize_21(HandleRef pThis);

		public override void Initialize()
		{
			vtkUniformGrid.vtkUniformGrid_Initialize_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkUniformGrid_IsA_22(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkUniformGrid.vtkUniformGrid_IsA_22(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern byte vtkUniformGrid_IsCellVisible_23(HandleRef pThis, long cellId);

		public virtual byte IsCellVisible(long cellId)
		{
			return vtkUniformGrid.vtkUniformGrid_IsCellVisible_23(base.GetCppThis(), cellId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern byte vtkUniformGrid_IsPointVisible_24(HandleRef pThis, long ptId);

		public virtual byte IsPointVisible(long ptId)
		{
			return vtkUniformGrid.vtkUniformGrid_IsPointVisible_24(base.GetCppThis(), ptId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkUniformGrid_IsTypeOf_25(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkUniformGrid.vtkUniformGrid_IsTypeOf_25(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUniformGrid_NewImageDataCopy_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImageData NewImageDataCopy()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUniformGrid.vtkUniformGrid_NewImageDataCopy_27(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUniformGrid_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkUniformGrid NewInstance()
		{
			vtkUniformGrid result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUniformGrid.vtkUniformGrid_NewInstance_28(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUniformGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUniformGrid_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUniformGrid SafeDownCast(vtkObjectBase o)
		{
			vtkUniformGrid vtkUniformGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUniformGrid.vtkUniformGrid_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUniformGrid = (vtkUniformGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUniformGrid.Register(null);
				}
			}
			return vtkUniformGrid;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUniformGrid_SetCellVisibilityArray_30(HandleRef pThis, HandleRef pointVisibility);

		public virtual void SetCellVisibilityArray(vtkUnsignedCharArray pointVisibility)
		{
			vtkUniformGrid.vtkUniformGrid_SetCellVisibilityArray_30(base.GetCppThis(), (pointVisibility == null) ? default(HandleRef) : pointVisibility.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUniformGrid_SetPointVisibilityArray_31(HandleRef pThis, HandleRef pointVisibility);

		public virtual void SetPointVisibilityArray(vtkUnsignedCharArray pointVisibility)
		{
			vtkUniformGrid.vtkUniformGrid_SetPointVisibilityArray_31(base.GetCppThis(), (pointVisibility == null) ? default(HandleRef) : pointVisibility.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUniformGrid_ShallowCopy_32(HandleRef pThis, HandleRef src);

		public override void ShallowCopy(vtkDataObject src)
		{
			vtkUniformGrid.vtkUniformGrid_ShallowCopy_32(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUniformGrid_UnBlankCell_33(HandleRef pThis, long ptId);

		public virtual void UnBlankCell(long ptId)
		{
			vtkUniformGrid.vtkUniformGrid_UnBlankCell_33(base.GetCppThis(), ptId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUniformGrid_UnBlankPoint_34(HandleRef pThis, long ptId);

		public virtual void UnBlankPoint(long ptId)
		{
			vtkUniformGrid.vtkUniformGrid_UnBlankPoint_34(base.GetCppThis(), ptId);
		}
	}
}
