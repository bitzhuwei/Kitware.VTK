using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkGenericDataSet : vtkDataObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericDataSet";

		public new static readonly string MRClassNameKey;

		static vtkGenericDataSet()
		{
			vtkGenericDataSet.MRClassNameKey = "class vtkGenericDataSet";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericDataSet.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericDataSet"));
		}

		public vtkGenericDataSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericDataSet_ComputeBounds_01(HandleRef pThis);

		public virtual void ComputeBounds()
		{
			vtkGenericDataSet.vtkGenericDataSet_ComputeBounds_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericDataSet_FindCell_02(HandleRef pThis, IntPtr x, HandleRef cell, double tol2, ref int subId, IntPtr pcoords);

		public virtual int FindCell(IntPtr x, vtkGenericCellIterator cell, double tol2, ref int subId, IntPtr pcoords)
		{
			return vtkGenericDataSet.vtkGenericDataSet_FindCell_02(base.GetCppThis(), x, (cell == null) ? default(HandleRef) : cell.GetCppThis(), tol2, ref subId, pcoords);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericDataSet_FindPoint_03(HandleRef pThis, IntPtr x, HandleRef p);

		public virtual void FindPoint(IntPtr x, vtkGenericPointIterator p)
		{
			vtkGenericDataSet.vtkGenericDataSet_FindPoint_03(base.GetCppThis(), x, (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkGenericDataSet_GetActualMemorySize_04(HandleRef pThis);

		public override uint GetActualMemorySize()
		{
			return vtkGenericDataSet.vtkGenericDataSet_GetActualMemorySize_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericDataSet_GetAttributes_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkGenericAttributeCollection GetAttributes()
		{
			vtkGenericAttributeCollection vtkGenericAttributeCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericDataSet.vtkGenericDataSet_GetAttributes_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericAttributeCollection = (vtkGenericAttributeCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericAttributeCollection.Register(null);
				}
			}
			return vtkGenericAttributeCollection;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericDataSet_GetAttributes_06(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkDataSetAttributes GetAttributes(int type)
		{
			vtkDataSetAttributes vtkDataSetAttributes = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericDataSet.vtkGenericDataSet_GetAttributes_06(base.GetCppThis(), type, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetAttributes = (vtkDataSetAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetAttributes.Register(null);
				}
			}
			return vtkDataSetAttributes;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericDataSet_GetBounds_07(HandleRef pThis);

		public virtual IntPtr GetBounds()
		{
			return vtkGenericDataSet.vtkGenericDataSet_GetBounds_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericDataSet_GetBounds_08(HandleRef pThis, IntPtr bounds);

		public virtual void GetBounds(IntPtr bounds)
		{
			vtkGenericDataSet.vtkGenericDataSet_GetBounds_08(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericDataSet_GetCellDimension_09(HandleRef pThis);

		public virtual int GetCellDimension()
		{
			return vtkGenericDataSet.vtkGenericDataSet_GetCellDimension_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericDataSet_GetCellTypes_10(HandleRef pThis, HandleRef types);

		public virtual void GetCellTypes(vtkCellTypes types)
		{
			vtkGenericDataSet.vtkGenericDataSet_GetCellTypes_10(base.GetCppThis(), (types == null) ? default(HandleRef) : types.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericDataSet_GetCenter_11(HandleRef pThis);

		public virtual IntPtr GetCenter()
		{
			return vtkGenericDataSet.vtkGenericDataSet_GetCenter_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericDataSet_GetCenter_12(HandleRef pThis, IntPtr center);

		public virtual void GetCenter(IntPtr center)
		{
			vtkGenericDataSet.vtkGenericDataSet_GetCenter_12(base.GetCppThis(), center);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericDataSet_GetData_13(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericDataSet GetData(vtkInformation info)
		{
			vtkGenericDataSet vtkGenericDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericDataSet.vtkGenericDataSet_GetData_13((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericDataSet = (vtkGenericDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericDataSet.Register(null);
				}
			}
			return vtkGenericDataSet;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericDataSet_GetData_14(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericDataSet GetData(vtkInformationVector v, int i)
		{
			vtkGenericDataSet vtkGenericDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericDataSet.vtkGenericDataSet_GetData_14((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericDataSet = (vtkGenericDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericDataSet.Register(null);
				}
			}
			return vtkGenericDataSet;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericDataSet_GetDataObjectType_15(HandleRef pThis);

		public override int GetDataObjectType()
		{
			return vtkGenericDataSet.vtkGenericDataSet_GetDataObjectType_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkGenericDataSet_GetEstimatedSize_16(HandleRef pThis);

		public virtual long GetEstimatedSize()
		{
			return vtkGenericDataSet.vtkGenericDataSet_GetEstimatedSize_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkGenericDataSet_GetLength_17(HandleRef pThis);

		public virtual double GetLength()
		{
			return vtkGenericDataSet.vtkGenericDataSet_GetLength_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkGenericDataSet_GetMTime_18(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkGenericDataSet.vtkGenericDataSet_GetMTime_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkGenericDataSet_GetNumberOfCells_19(HandleRef pThis, int dim);

		public virtual long GetNumberOfCells(int dim)
		{
			return vtkGenericDataSet.vtkGenericDataSet_GetNumberOfCells_19(base.GetCppThis(), dim);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkGenericDataSet_GetNumberOfPoints_20(HandleRef pThis);

		public virtual long GetNumberOfPoints()
		{
			return vtkGenericDataSet.vtkGenericDataSet_GetNumberOfPoints_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericDataSet_GetTessellator_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkGenericCellTessellator GetTessellator()
		{
			vtkGenericCellTessellator vtkGenericCellTessellator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericDataSet.vtkGenericDataSet_GetTessellator_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericCellTessellator = (vtkGenericCellTessellator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericCellTessellator.Register(null);
				}
			}
			return vtkGenericCellTessellator;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericDataSet_IsA_22(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGenericDataSet.vtkGenericDataSet_IsA_22(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericDataSet_IsTypeOf_23(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGenericDataSet.vtkGenericDataSet_IsTypeOf_23(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericDataSet_NewBoundaryIterator_24(HandleRef pThis, int dim, int exteriorOnly, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkGenericCellIterator NewBoundaryIterator(int dim, int exteriorOnly)
		{
			vtkGenericCellIterator vtkGenericCellIterator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericDataSet.vtkGenericDataSet_NewBoundaryIterator_24(base.GetCppThis(), dim, exteriorOnly, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericCellIterator = (vtkGenericCellIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericCellIterator.Register(null);
				}
			}
			return vtkGenericCellIterator;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericDataSet_NewCellIterator_25(HandleRef pThis, int dim, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkGenericCellIterator NewCellIterator(int dim)
		{
			vtkGenericCellIterator vtkGenericCellIterator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericDataSet.vtkGenericDataSet_NewCellIterator_25(base.GetCppThis(), dim, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericCellIterator = (vtkGenericCellIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericCellIterator.Register(null);
				}
			}
			return vtkGenericCellIterator;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericDataSet_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGenericDataSet NewInstance()
		{
			vtkGenericDataSet result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericDataSet.vtkGenericDataSet_NewInstance_26(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericDataSet_NewPointIterator_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkGenericPointIterator NewPointIterator()
		{
			vtkGenericPointIterator vtkGenericPointIterator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericDataSet.vtkGenericDataSet_NewPointIterator_27(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericPointIterator = (vtkGenericPointIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericPointIterator.Register(null);
				}
			}
			return vtkGenericPointIterator;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericDataSet_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericDataSet SafeDownCast(vtkObjectBase o)
		{
			vtkGenericDataSet vtkGenericDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericDataSet.vtkGenericDataSet_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericDataSet = (vtkGenericDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericDataSet.Register(null);
				}
			}
			return vtkGenericDataSet;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericDataSet_SetTessellator_29(HandleRef pThis, HandleRef tessellator);

		public virtual void SetTessellator(vtkGenericCellTessellator tessellator)
		{
			vtkGenericDataSet.vtkGenericDataSet_SetTessellator_29(base.GetCppThis(), (tessellator == null) ? default(HandleRef) : tessellator.GetCppThis());
		}
	}
}
