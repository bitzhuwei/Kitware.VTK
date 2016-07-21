using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkGenericCellTessellator : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericCellTessellator";

		public new static readonly string MRClassNameKey;

		static vtkGenericCellTessellator()
		{
			vtkGenericCellTessellator.MRClassNameKey = "class vtkGenericCellTessellator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericCellTessellator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericCellTessellator"));
		}

		public vtkGenericCellTessellator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericCellTessellator_GetErrorMetrics_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCollection GetErrorMetrics()
		{
			vtkCollection vtkCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericCellTessellator.vtkGenericCellTessellator_GetErrorMetrics_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCollection = (vtkCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCollection.Register(null);
				}
			}
			return vtkCollection;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCellTessellator_GetMaxErrors_02(HandleRef pThis, IntPtr errors);

		public void GetMaxErrors(IntPtr errors)
		{
			vtkGenericCellTessellator.vtkGenericCellTessellator_GetMaxErrors_02(base.GetCppThis(), errors);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericCellTessellator_GetMeasurement_03(HandleRef pThis);

		public virtual int GetMeasurement()
		{
			return vtkGenericCellTessellator.vtkGenericCellTessellator_GetMeasurement_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCellTessellator_InitErrorMetrics_04(HandleRef pThis, HandleRef ds);

		public void InitErrorMetrics(vtkGenericDataSet ds)
		{
			vtkGenericCellTessellator.vtkGenericCellTessellator_InitErrorMetrics_04(base.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCellTessellator_Initialize_05(HandleRef pThis, HandleRef ds);

		public virtual void Initialize(vtkGenericDataSet ds)
		{
			vtkGenericCellTessellator.vtkGenericCellTessellator_Initialize_05(base.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericCellTessellator_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGenericCellTessellator.vtkGenericCellTessellator_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericCellTessellator_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGenericCellTessellator.vtkGenericCellTessellator_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericCellTessellator_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGenericCellTessellator NewInstance()
		{
			vtkGenericCellTessellator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericCellTessellator.vtkGenericCellTessellator_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericCellTessellator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericCellTessellator_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericCellTessellator SafeDownCast(vtkObjectBase o)
		{
			vtkGenericCellTessellator vtkGenericCellTessellator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericCellTessellator.vtkGenericCellTessellator_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkGenericCellTessellator_SetErrorMetrics_10(HandleRef pThis, HandleRef someErrorMetrics);

		public virtual void SetErrorMetrics(vtkCollection someErrorMetrics)
		{
			vtkGenericCellTessellator.vtkGenericCellTessellator_SetErrorMetrics_10(base.GetCppThis(), (someErrorMetrics == null) ? default(HandleRef) : someErrorMetrics.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCellTessellator_SetMeasurement_11(HandleRef pThis, int _arg);

		public virtual void SetMeasurement(int _arg)
		{
			vtkGenericCellTessellator.vtkGenericCellTessellator_SetMeasurement_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCellTessellator_Tessellate_12(HandleRef pThis, HandleRef cell, HandleRef att, HandleRef points, HandleRef cellArray, HandleRef internalPd);

		public virtual void Tessellate(vtkGenericAdaptorCell cell, vtkGenericAttributeCollection att, vtkDoubleArray points, vtkCellArray cellArray, vtkPointData internalPd)
		{
			vtkGenericCellTessellator.vtkGenericCellTessellator_Tessellate_12(base.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis(), (att == null) ? default(HandleRef) : att.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis(), (cellArray == null) ? default(HandleRef) : cellArray.GetCppThis(), (internalPd == null) ? default(HandleRef) : internalPd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCellTessellator_TessellateFace_13(HandleRef pThis, HandleRef cell, HandleRef att, long index, HandleRef points, HandleRef cellArray, HandleRef internalPd);

		public virtual void TessellateFace(vtkGenericAdaptorCell cell, vtkGenericAttributeCollection att, long index, vtkDoubleArray points, vtkCellArray cellArray, vtkPointData internalPd)
		{
			vtkGenericCellTessellator.vtkGenericCellTessellator_TessellateFace_13(base.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis(), (att == null) ? default(HandleRef) : att.GetCppThis(), index, (points == null) ? default(HandleRef) : points.GetCppThis(), (cellArray == null) ? default(HandleRef) : cellArray.GetCppThis(), (internalPd == null) ? default(HandleRef) : internalPd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCellTessellator_Triangulate_14(HandleRef pThis, HandleRef cell, HandleRef att, HandleRef points, HandleRef cellArray, HandleRef internalPd);

		public virtual void Triangulate(vtkGenericAdaptorCell cell, vtkGenericAttributeCollection att, vtkDoubleArray points, vtkCellArray cellArray, vtkPointData internalPd)
		{
			vtkGenericCellTessellator.vtkGenericCellTessellator_Triangulate_14(base.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis(), (att == null) ? default(HandleRef) : att.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis(), (cellArray == null) ? default(HandleRef) : cellArray.GetCppThis(), (internalPd == null) ? default(HandleRef) : internalPd.GetCppThis());
		}
	}
}
