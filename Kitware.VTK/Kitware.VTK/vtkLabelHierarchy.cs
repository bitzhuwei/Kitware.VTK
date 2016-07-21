using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkLabelHierarchy : vtkPointSet
	{
		public enum IteratorType
		{
			DEPTH_FIRST = 2,
			FRUSTUM,
			FULL_SORT = 0,
			QUEUE
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkLabelHierarchy";

		public new static readonly string MRClassNameKey;

		static vtkLabelHierarchy()
		{
			vtkLabelHierarchy.MRClassNameKey = "class vtkLabelHierarchy";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLabelHierarchy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLabelHierarchy"));
		}

		public vtkLabelHierarchy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelHierarchy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLabelHierarchy New()
		{
			vtkLabelHierarchy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabelHierarchy.vtkLabelHierarchy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLabelHierarchy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkLabelHierarchy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkLabelHierarchy.vtkLabelHierarchy_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelHierarchy_ComputeHierarchy_01(HandleRef pThis);

		public virtual void ComputeHierarchy()
		{
			vtkLabelHierarchy.vtkLabelHierarchy_ComputeHierarchy_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern long vtkLabelHierarchy_FindCell_02(HandleRef pThis, IntPtr arg0, HandleRef arg1, long arg2, double arg3, ref int arg4, IntPtr arg5, IntPtr arg6);

		public override long FindCell(IntPtr arg0, vtkCell arg1, long arg2, double arg3, ref int arg4, IntPtr arg5, IntPtr arg6)
		{
			return vtkLabelHierarchy.vtkLabelHierarchy_FindCell_02(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), arg2, arg3, ref arg4, arg5, arg6);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern long vtkLabelHierarchy_FindCell_03(HandleRef pThis, IntPtr arg0, HandleRef arg1, HandleRef arg2, long arg3, double arg4, ref int arg5, IntPtr arg6, IntPtr arg7);

		public override long FindCell(IntPtr arg0, vtkCell arg1, vtkGenericCell arg2, long arg3, double arg4, ref int arg5, IntPtr arg6, IntPtr arg7)
		{
			return vtkLabelHierarchy.vtkLabelHierarchy_FindCell_03(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), (arg2 == null) ? default(HandleRef) : arg2.GetCppThis(), arg3, arg4, ref arg5, arg6, arg7);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelHierarchy_GetBoundedSizes_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataArray GetBoundedSizes()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabelHierarchy.vtkLabelHierarchy_GetBoundedSizes_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelHierarchy_GetCell_05(HandleRef pThis, long arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkCell GetCell(long arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabelHierarchy.vtkLabelHierarchy_GetCell_05(base.GetCppThis(), arg0, ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelHierarchy_GetCell_06(HandleRef pThis, long arg0, HandleRef arg1);

		public override void GetCell(long arg0, vtkGenericCell arg1)
		{
			vtkLabelHierarchy.vtkLabelHierarchy_GetCell_06(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelHierarchy_GetCellPoints_07(HandleRef pThis, long arg0, HandleRef arg1);

		public override void GetCellPoints(long arg0, vtkIdList arg1)
		{
			vtkLabelHierarchy.vtkLabelHierarchy_GetCellPoints_07(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabelHierarchy_GetCellType_08(HandleRef pThis, long arg0);

		public override int GetCellType(long arg0)
		{
			return vtkLabelHierarchy.vtkLabelHierarchy_GetCellType_08(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelHierarchy_GetCenterPts_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPoints GetCenterPts()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabelHierarchy.vtkLabelHierarchy_GetCenterPts_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelHierarchy_GetCoincidentPoints_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCoincidentPoints GetCoincidentPoints()
		{
			vtkCoincidentPoints vtkCoincidentPoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabelHierarchy.vtkLabelHierarchy_GetCoincidentPoints_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCoincidentPoints = (vtkCoincidentPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCoincidentPoints.Register(null);
				}
			}
			return vtkCoincidentPoints;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelHierarchy_GetDiscreteNodeCoordinatesFromWorldPoint_11(HandleRef pThis, IntPtr ijk, IntPtr pt, int level);

		public void GetDiscreteNodeCoordinatesFromWorldPoint(IntPtr ijk, IntPtr pt, int level)
		{
			vtkLabelHierarchy.vtkLabelHierarchy_GetDiscreteNodeCoordinatesFromWorldPoint_11(base.GetCppThis(), ijk, pt, level);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelHierarchy_GetIconIndices_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIntArray GetIconIndices()
		{
			vtkIntArray vtkIntArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabelHierarchy.vtkLabelHierarchy_GetIconIndices_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIntArray = (vtkIntArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIntArray.Register(null);
				}
			}
			return vtkIntArray;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelHierarchy_GetLabels_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAbstractArray GetLabels()
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabelHierarchy.vtkLabelHierarchy_GetLabels_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractArray = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractArray.Register(null);
				}
			}
			return vtkAbstractArray;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabelHierarchy_GetMaxCellSize_14(HandleRef pThis);

		public override int GetMaxCellSize()
		{
			return vtkLabelHierarchy.vtkLabelHierarchy_GetMaxCellSize_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabelHierarchy_GetMaximumDepth_15(HandleRef pThis);

		public virtual int GetMaximumDepth()
		{
			return vtkLabelHierarchy.vtkLabelHierarchy_GetMaximumDepth_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern long vtkLabelHierarchy_GetNumberOfCells_16(HandleRef pThis);

		public override long GetNumberOfCells()
		{
			return vtkLabelHierarchy.vtkLabelHierarchy_GetNumberOfCells_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelHierarchy_GetOrientations_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataArray GetOrientations()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabelHierarchy.vtkLabelHierarchy_GetOrientations_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkLabelHierarchy_GetPathForNodalCoordinates_18(IntPtr path, IntPtr ijk, int level);

		public static bool GetPathForNodalCoordinates(IntPtr path, IntPtr ijk, int level)
		{
			return vtkLabelHierarchy.vtkLabelHierarchy_GetPathForNodalCoordinates_18(path, ijk, level) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelHierarchy_GetPointCells_19(HandleRef pThis, long arg0, HandleRef arg1);

		public override void GetPointCells(long arg0, vtkIdList arg1)
		{
			vtkLabelHierarchy.vtkLabelHierarchy_GetPointCells_19(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelHierarchy_GetPriorities_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataArray GetPriorities()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabelHierarchy.vtkLabelHierarchy_GetPriorities_20(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelHierarchy_GetSizes_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataArray GetSizes()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabelHierarchy.vtkLabelHierarchy_GetSizes_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabelHierarchy_GetTargetLabelCount_22(HandleRef pThis);

		public virtual int GetTargetLabelCount()
		{
			return vtkLabelHierarchy.vtkLabelHierarchy_GetTargetLabelCount_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelHierarchy_GetTextProperty_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabelHierarchy.vtkLabelHierarchy_GetTextProperty_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabelHierarchy_IsA_24(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkLabelHierarchy.vtkLabelHierarchy_IsA_24(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabelHierarchy_IsTypeOf_25(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkLabelHierarchy.vtkLabelHierarchy_IsTypeOf_25(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelHierarchy_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkLabelHierarchy NewInstance()
		{
			vtkLabelHierarchy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabelHierarchy.vtkLabelHierarchy_NewInstance_27(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLabelHierarchy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelHierarchy_NewIterator_28(HandleRef pThis, int type, HandleRef ren, HandleRef cam, IntPtr frustumPlanes, byte positionsAsNormals, IntPtr bucketSize, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkLabelHierarchyIterator NewIterator(int type, vtkRenderer ren, vtkCamera cam, IntPtr frustumPlanes, bool positionsAsNormals, IntPtr bucketSize)
		{
			vtkLabelHierarchyIterator vtkLabelHierarchyIterator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabelHierarchy.vtkLabelHierarchy_NewIterator_28(base.GetCppThis(), type, (ren == null) ? default(HandleRef) : ren.GetCppThis(), (cam == null) ? default(HandleRef) : cam.GetCppThis(), frustumPlanes, positionsAsNormals ? (byte)1 : (byte)0, bucketSize, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLabelHierarchyIterator = (vtkLabelHierarchyIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLabelHierarchyIterator.Register(null);
				}
			}
			return vtkLabelHierarchyIterator;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelHierarchy_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLabelHierarchy SafeDownCast(vtkObjectBase o)
		{
			vtkLabelHierarchy vtkLabelHierarchy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabelHierarchy.vtkLabelHierarchy_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLabelHierarchy = (vtkLabelHierarchy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLabelHierarchy.Register(null);
				}
			}
			return vtkLabelHierarchy;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelHierarchy_SetBoundedSizes_30(HandleRef pThis, HandleRef arr);

		public virtual void SetBoundedSizes(vtkDataArray arr)
		{
			vtkLabelHierarchy.vtkLabelHierarchy_SetBoundedSizes_30(base.GetCppThis(), (arr == null) ? default(HandleRef) : arr.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelHierarchy_SetIconIndices_31(HandleRef pThis, HandleRef arr);

		public virtual void SetIconIndices(vtkIntArray arr)
		{
			vtkLabelHierarchy.vtkLabelHierarchy_SetIconIndices_31(base.GetCppThis(), (arr == null) ? default(HandleRef) : arr.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelHierarchy_SetLabels_32(HandleRef pThis, HandleRef arr);

		public virtual void SetLabels(vtkAbstractArray arr)
		{
			vtkLabelHierarchy.vtkLabelHierarchy_SetLabels_32(base.GetCppThis(), (arr == null) ? default(HandleRef) : arr.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelHierarchy_SetMaximumDepth_33(HandleRef pThis, int _arg);

		public virtual void SetMaximumDepth(int _arg)
		{
			vtkLabelHierarchy.vtkLabelHierarchy_SetMaximumDepth_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelHierarchy_SetOrientations_34(HandleRef pThis, HandleRef arr);

		public virtual void SetOrientations(vtkDataArray arr)
		{
			vtkLabelHierarchy.vtkLabelHierarchy_SetOrientations_34(base.GetCppThis(), (arr == null) ? default(HandleRef) : arr.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelHierarchy_SetPoints_35(HandleRef pThis, HandleRef arg0);

		public override void SetPoints(vtkPoints arg0)
		{
			vtkLabelHierarchy.vtkLabelHierarchy_SetPoints_35(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelHierarchy_SetPriorities_36(HandleRef pThis, HandleRef arr);

		public virtual void SetPriorities(vtkDataArray arr)
		{
			vtkLabelHierarchy.vtkLabelHierarchy_SetPriorities_36(base.GetCppThis(), (arr == null) ? default(HandleRef) : arr.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelHierarchy_SetSizes_37(HandleRef pThis, HandleRef arr);

		public virtual void SetSizes(vtkDataArray arr)
		{
			vtkLabelHierarchy.vtkLabelHierarchy_SetSizes_37(base.GetCppThis(), (arr == null) ? default(HandleRef) : arr.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelHierarchy_SetTargetLabelCount_38(HandleRef pThis, int _arg);

		public virtual void SetTargetLabelCount(int _arg)
		{
			vtkLabelHierarchy.vtkLabelHierarchy_SetTargetLabelCount_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelHierarchy_SetTextProperty_39(HandleRef pThis, HandleRef tprop);

		public virtual void SetTextProperty(vtkTextProperty tprop)
		{
			vtkLabelHierarchy.vtkLabelHierarchy_SetTextProperty_39(base.GetCppThis(), (tprop == null) ? default(HandleRef) : tprop.GetCppThis());
		}
	}
}
