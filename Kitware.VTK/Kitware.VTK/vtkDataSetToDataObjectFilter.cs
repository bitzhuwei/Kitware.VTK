using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDataSetToDataObjectFilter : vtkDataObjectAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataSetToDataObjectFilter";

		public new static readonly string MRClassNameKey;

		static vtkDataSetToDataObjectFilter()
		{
			vtkDataSetToDataObjectFilter.MRClassNameKey = "class vtkDataSetToDataObjectFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataSetToDataObjectFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataSetToDataObjectFilter"));
		}

		public vtkDataSetToDataObjectFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetToDataObjectFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataSetToDataObjectFilter New()
		{
			vtkDataSetToDataObjectFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetToDataObjectFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDataSetToDataObjectFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataSetToDataObjectFilter_CellDataOff_01(HandleRef pThis);

		public virtual void CellDataOff()
		{
			vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_CellDataOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataSetToDataObjectFilter_CellDataOn_02(HandleRef pThis);

		public virtual void CellDataOn()
		{
			vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_CellDataOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataSetToDataObjectFilter_FieldDataOff_03(HandleRef pThis);

		public virtual void FieldDataOff()
		{
			vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_FieldDataOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataSetToDataObjectFilter_FieldDataOn_04(HandleRef pThis);

		public virtual void FieldDataOn()
		{
			vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_FieldDataOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataSetToDataObjectFilter_GeometryOff_05(HandleRef pThis);

		public virtual void GeometryOff()
		{
			vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_GeometryOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataSetToDataObjectFilter_GeometryOn_06(HandleRef pThis);

		public virtual void GeometryOn()
		{
			vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_GeometryOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataSetToDataObjectFilter_GetCellData_07(HandleRef pThis);

		public virtual int GetCellData()
		{
			return vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_GetCellData_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataSetToDataObjectFilter_GetFieldData_08(HandleRef pThis);

		public virtual int GetFieldData()
		{
			return vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_GetFieldData_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataSetToDataObjectFilter_GetGeometry_09(HandleRef pThis);

		public virtual int GetGeometry()
		{
			return vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_GetGeometry_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataSetToDataObjectFilter_GetPointData_10(HandleRef pThis);

		public virtual int GetPointData()
		{
			return vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_GetPointData_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataSetToDataObjectFilter_GetTopology_11(HandleRef pThis);

		public virtual int GetTopology()
		{
			return vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_GetTopology_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataSetToDataObjectFilter_IsA_12(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_IsA_12(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataSetToDataObjectFilter_IsTypeOf_13(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_IsTypeOf_13(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetToDataObjectFilter_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDataSetToDataObjectFilter NewInstance()
		{
			vtkDataSetToDataObjectFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_NewInstance_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetToDataObjectFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataSetToDataObjectFilter_PointDataOff_16(HandleRef pThis);

		public virtual void PointDataOff()
		{
			vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_PointDataOff_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataSetToDataObjectFilter_PointDataOn_17(HandleRef pThis);

		public virtual void PointDataOn()
		{
			vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_PointDataOn_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetToDataObjectFilter_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataSetToDataObjectFilter SafeDownCast(vtkObjectBase o)
		{
			vtkDataSetToDataObjectFilter vtkDataSetToDataObjectFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetToDataObjectFilter = (vtkDataSetToDataObjectFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetToDataObjectFilter.Register(null);
				}
			}
			return vtkDataSetToDataObjectFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataSetToDataObjectFilter_SetCellData_19(HandleRef pThis, int _arg);

		public virtual void SetCellData(int _arg)
		{
			vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_SetCellData_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataSetToDataObjectFilter_SetFieldData_20(HandleRef pThis, int _arg);

		public virtual void SetFieldData(int _arg)
		{
			vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_SetFieldData_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataSetToDataObjectFilter_SetGeometry_21(HandleRef pThis, int _arg);

		public virtual void SetGeometry(int _arg)
		{
			vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_SetGeometry_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataSetToDataObjectFilter_SetPointData_22(HandleRef pThis, int _arg);

		public virtual void SetPointData(int _arg)
		{
			vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_SetPointData_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataSetToDataObjectFilter_SetTopology_23(HandleRef pThis, int _arg);

		public virtual void SetTopology(int _arg)
		{
			vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_SetTopology_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataSetToDataObjectFilter_TopologyOff_24(HandleRef pThis);

		public virtual void TopologyOff()
		{
			vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_TopologyOff_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataSetToDataObjectFilter_TopologyOn_25(HandleRef pThis);

		public virtual void TopologyOn()
		{
			vtkDataSetToDataObjectFilter.vtkDataSetToDataObjectFilter_TopologyOn_25(base.GetCppThis());
		}
	}
}
