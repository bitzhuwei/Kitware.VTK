using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSimpleCellTessellator : vtkGenericCellTessellator
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSimpleCellTessellator";

		public new static readonly string MRClassNameKey;

		static vtkSimpleCellTessellator()
		{
			vtkSimpleCellTessellator.MRClassNameKey = "class vtkSimpleCellTessellator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSimpleCellTessellator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSimpleCellTessellator"));
		}

		public vtkSimpleCellTessellator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkSimpleCellTessellator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSimpleCellTessellator New()
		{
			vtkSimpleCellTessellator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSimpleCellTessellator.vtkSimpleCellTessellator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSimpleCellTessellator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSimpleCellTessellator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSimpleCellTessellator.vtkSimpleCellTessellator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSimpleCellTessellator_GetFixedSubdivisions_01(HandleRef pThis);

		public int GetFixedSubdivisions()
		{
			return vtkSimpleCellTessellator.vtkSimpleCellTessellator_GetFixedSubdivisions_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkSimpleCellTessellator_GetGenericCell_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkGenericAdaptorCell GetGenericCell()
		{
			vtkGenericAdaptorCell vtkGenericAdaptorCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSimpleCellTessellator.vtkSimpleCellTessellator_GetGenericCell_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericAdaptorCell = (vtkGenericAdaptorCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericAdaptorCell.Register(null);
				}
			}
			return vtkGenericAdaptorCell;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSimpleCellTessellator_GetMaxAdaptiveSubdivisions_03(HandleRef pThis);

		public int GetMaxAdaptiveSubdivisions()
		{
			return vtkSimpleCellTessellator.vtkSimpleCellTessellator_GetMaxAdaptiveSubdivisions_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSimpleCellTessellator_GetMaxSubdivisionLevel_04(HandleRef pThis);

		public int GetMaxSubdivisionLevel()
		{
			return vtkSimpleCellTessellator.vtkSimpleCellTessellator_GetMaxSubdivisionLevel_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSimpleCellTessellator_Initialize_05(HandleRef pThis, HandleRef ds);

		public override void Initialize(vtkGenericDataSet ds)
		{
			vtkSimpleCellTessellator.vtkSimpleCellTessellator_Initialize_05(base.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSimpleCellTessellator_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSimpleCellTessellator.vtkSimpleCellTessellator_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSimpleCellTessellator_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSimpleCellTessellator.vtkSimpleCellTessellator_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkSimpleCellTessellator_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSimpleCellTessellator NewInstance()
		{
			vtkSimpleCellTessellator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSimpleCellTessellator.vtkSimpleCellTessellator_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSimpleCellTessellator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSimpleCellTessellator_Reset_10(HandleRef pThis);

		public void Reset()
		{
			vtkSimpleCellTessellator.vtkSimpleCellTessellator_Reset_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkSimpleCellTessellator_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSimpleCellTessellator SafeDownCast(vtkObjectBase o)
		{
			vtkSimpleCellTessellator vtkSimpleCellTessellator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSimpleCellTessellator.vtkSimpleCellTessellator_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSimpleCellTessellator = (vtkSimpleCellTessellator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSimpleCellTessellator.Register(null);
				}
			}
			return vtkSimpleCellTessellator;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSimpleCellTessellator_SetFixedSubdivisions_12(HandleRef pThis, int level);

		public void SetFixedSubdivisions(int level)
		{
			vtkSimpleCellTessellator.vtkSimpleCellTessellator_SetFixedSubdivisions_12(base.GetCppThis(), level);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSimpleCellTessellator_SetMaxSubdivisionLevel_13(HandleRef pThis, int level);

		public void SetMaxSubdivisionLevel(int level)
		{
			vtkSimpleCellTessellator.vtkSimpleCellTessellator_SetMaxSubdivisionLevel_13(base.GetCppThis(), level);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSimpleCellTessellator_SetSubdivisionLevels_14(HandleRef pThis, int arg0, int maxLevel);

		public void SetSubdivisionLevels(int arg0, int maxLevel)
		{
			vtkSimpleCellTessellator.vtkSimpleCellTessellator_SetSubdivisionLevels_14(base.GetCppThis(), arg0, maxLevel);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSimpleCellTessellator_Tessellate_15(HandleRef pThis, HandleRef cell, HandleRef att, HandleRef points, HandleRef cellArray, HandleRef internalPd);

		public override void Tessellate(vtkGenericAdaptorCell cell, vtkGenericAttributeCollection att, vtkDoubleArray points, vtkCellArray cellArray, vtkPointData internalPd)
		{
			vtkSimpleCellTessellator.vtkSimpleCellTessellator_Tessellate_15(base.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis(), (att == null) ? default(HandleRef) : att.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis(), (cellArray == null) ? default(HandleRef) : cellArray.GetCppThis(), (internalPd == null) ? default(HandleRef) : internalPd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSimpleCellTessellator_TessellateFace_16(HandleRef pThis, HandleRef cell, HandleRef att, long index, HandleRef points, HandleRef cellArray, HandleRef internalPd);

		public override void TessellateFace(vtkGenericAdaptorCell cell, vtkGenericAttributeCollection att, long index, vtkDoubleArray points, vtkCellArray cellArray, vtkPointData internalPd)
		{
			vtkSimpleCellTessellator.vtkSimpleCellTessellator_TessellateFace_16(base.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis(), (att == null) ? default(HandleRef) : att.GetCppThis(), index, (points == null) ? default(HandleRef) : points.GetCppThis(), (cellArray == null) ? default(HandleRef) : cellArray.GetCppThis(), (internalPd == null) ? default(HandleRef) : internalPd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSimpleCellTessellator_Triangulate_17(HandleRef pThis, HandleRef cell, HandleRef att, HandleRef points, HandleRef cellArray, HandleRef internalPd);

		public override void Triangulate(vtkGenericAdaptorCell cell, vtkGenericAttributeCollection att, vtkDoubleArray points, vtkCellArray cellArray, vtkPointData internalPd)
		{
			vtkSimpleCellTessellator.vtkSimpleCellTessellator_Triangulate_17(base.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis(), (att == null) ? default(HandleRef) : att.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis(), (cellArray == null) ? default(HandleRef) : cellArray.GetCppThis(), (internalPd == null) ? default(HandleRef) : internalPd.GetCppThis());
		}
	}
}
