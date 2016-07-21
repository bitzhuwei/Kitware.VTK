using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkGenericSubdivisionErrorMetric : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericSubdivisionErrorMetric";

		public new static readonly string MRClassNameKey;

		static vtkGenericSubdivisionErrorMetric()
		{
			vtkGenericSubdivisionErrorMetric.MRClassNameKey = "class vtkGenericSubdivisionErrorMetric";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericSubdivisionErrorMetric.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericSubdivisionErrorMetric"));
		}

		public vtkGenericSubdivisionErrorMetric(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericSubdivisionErrorMetric_GetDataSet_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkGenericDataSet GetDataSet()
		{
			vtkGenericDataSet vtkGenericDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericSubdivisionErrorMetric.vtkGenericSubdivisionErrorMetric_GetDataSet_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern double vtkGenericSubdivisionErrorMetric_GetError_02(HandleRef pThis, IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha);

		public virtual double GetError(IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha)
		{
			return vtkGenericSubdivisionErrorMetric.vtkGenericSubdivisionErrorMetric_GetError_02(base.GetCppThis(), leftPoint, midPoint, rightPoint, alpha);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericSubdivisionErrorMetric_GetGenericCell_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkGenericAdaptorCell GetGenericCell()
		{
			vtkGenericAdaptorCell vtkGenericAdaptorCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericSubdivisionErrorMetric.vtkGenericSubdivisionErrorMetric_GetGenericCell_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkGenericSubdivisionErrorMetric_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGenericSubdivisionErrorMetric.vtkGenericSubdivisionErrorMetric_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericSubdivisionErrorMetric_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGenericSubdivisionErrorMetric.vtkGenericSubdivisionErrorMetric_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericSubdivisionErrorMetric_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGenericSubdivisionErrorMetric NewInstance()
		{
			vtkGenericSubdivisionErrorMetric result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericSubdivisionErrorMetric.vtkGenericSubdivisionErrorMetric_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericSubdivisionErrorMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericSubdivisionErrorMetric_RequiresEdgeSubdivision_07(HandleRef pThis, IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha);

		public virtual int RequiresEdgeSubdivision(IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha)
		{
			return vtkGenericSubdivisionErrorMetric.vtkGenericSubdivisionErrorMetric_RequiresEdgeSubdivision_07(base.GetCppThis(), leftPoint, midPoint, rightPoint, alpha);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericSubdivisionErrorMetric_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericSubdivisionErrorMetric SafeDownCast(vtkObjectBase o)
		{
			vtkGenericSubdivisionErrorMetric vtkGenericSubdivisionErrorMetric = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericSubdivisionErrorMetric.vtkGenericSubdivisionErrorMetric_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericSubdivisionErrorMetric = (vtkGenericSubdivisionErrorMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericSubdivisionErrorMetric.Register(null);
				}
			}
			return vtkGenericSubdivisionErrorMetric;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericSubdivisionErrorMetric_SetDataSet_09(HandleRef pThis, HandleRef ds);

		public void SetDataSet(vtkGenericDataSet ds)
		{
			vtkGenericSubdivisionErrorMetric.vtkGenericSubdivisionErrorMetric_SetDataSet_09(base.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericSubdivisionErrorMetric_SetGenericCell_10(HandleRef pThis, HandleRef cell);

		public void SetGenericCell(vtkGenericAdaptorCell cell)
		{
			vtkGenericSubdivisionErrorMetric.vtkGenericSubdivisionErrorMetric_SetGenericCell_10(base.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}
	}
}
