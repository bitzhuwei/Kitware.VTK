using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkAbstractPointLocator : vtkLocator
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractPointLocator";

		public new static readonly string MRClassNameKey;

		static vtkAbstractPointLocator()
		{
			vtkAbstractPointLocator.MRClassNameKey = "class vtkAbstractPointLocator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAbstractPointLocator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractPointLocator"));
		}

		public vtkAbstractPointLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractPointLocator_BuildLocator_01(HandleRef pThis);

		public override void BuildLocator()
		{
			vtkAbstractPointLocator.vtkAbstractPointLocator_BuildLocator_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractPointLocator_FindClosestNPoints_02(HandleRef pThis, int N, IntPtr x, HandleRef result);

		public virtual void FindClosestNPoints(int N, IntPtr x, vtkIdList result)
		{
			vtkAbstractPointLocator.vtkAbstractPointLocator_FindClosestNPoints_02(base.GetCppThis(), N, x, (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractPointLocator_FindClosestNPoints_03(HandleRef pThis, int N, double x, double y, double z, HandleRef result);

		public void FindClosestNPoints(int N, double x, double y, double z, vtkIdList result)
		{
			vtkAbstractPointLocator.vtkAbstractPointLocator_FindClosestNPoints_03(base.GetCppThis(), N, x, y, z, (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkAbstractPointLocator_FindClosestPoint_04(HandleRef pThis, IntPtr x);

		public virtual long FindClosestPoint(IntPtr x)
		{
			return vtkAbstractPointLocator.vtkAbstractPointLocator_FindClosestPoint_04(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkAbstractPointLocator_FindClosestPoint_05(HandleRef pThis, double x, double y, double z);

		public long FindClosestPoint(double x, double y, double z)
		{
			return vtkAbstractPointLocator.vtkAbstractPointLocator_FindClosestPoint_05(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkAbstractPointLocator_FindClosestPointWithinRadius_06(HandleRef pThis, double radius, IntPtr x, ref double dist2);

		public virtual long FindClosestPointWithinRadius(double radius, IntPtr x, ref double dist2)
		{
			return vtkAbstractPointLocator.vtkAbstractPointLocator_FindClosestPointWithinRadius_06(base.GetCppThis(), radius, x, ref dist2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractPointLocator_FindPointsWithinRadius_07(HandleRef pThis, double R, IntPtr x, HandleRef result);

		public virtual void FindPointsWithinRadius(double R, IntPtr x, vtkIdList result)
		{
			vtkAbstractPointLocator.vtkAbstractPointLocator_FindPointsWithinRadius_07(base.GetCppThis(), R, x, (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractPointLocator_FindPointsWithinRadius_08(HandleRef pThis, double R, double x, double y, double z, HandleRef result);

		public void FindPointsWithinRadius(double R, double x, double y, double z, vtkIdList result)
		{
			vtkAbstractPointLocator.vtkAbstractPointLocator_FindPointsWithinRadius_08(base.GetCppThis(), R, x, y, z, (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractPointLocator_FreeSearchStructure_09(HandleRef pThis);

		public override void FreeSearchStructure()
		{
			vtkAbstractPointLocator.vtkAbstractPointLocator_FreeSearchStructure_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractPointLocator_GenerateRepresentation_10(HandleRef pThis, int level, HandleRef pd);

		public override void GenerateRepresentation(int level, vtkPolyData pd)
		{
			vtkAbstractPointLocator.vtkAbstractPointLocator_GenerateRepresentation_10(base.GetCppThis(), level, (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractPointLocator_GetBounds_11(HandleRef pThis);

		public virtual IntPtr GetBounds()
		{
			return vtkAbstractPointLocator.vtkAbstractPointLocator_GetBounds_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractPointLocator_GetBounds_12(HandleRef pThis, IntPtr arg0);

		public virtual void GetBounds(IntPtr arg0)
		{
			vtkAbstractPointLocator.vtkAbstractPointLocator_GetBounds_12(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAbstractPointLocator_IsA_13(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAbstractPointLocator.vtkAbstractPointLocator_IsA_13(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAbstractPointLocator_IsTypeOf_14(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAbstractPointLocator.vtkAbstractPointLocator_IsTypeOf_14(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractPointLocator_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAbstractPointLocator NewInstance()
		{
			vtkAbstractPointLocator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractPointLocator.vtkAbstractPointLocator_NewInstance_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractPointLocator_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAbstractPointLocator SafeDownCast(vtkObjectBase o)
		{
			vtkAbstractPointLocator vtkAbstractPointLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractPointLocator.vtkAbstractPointLocator_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractPointLocator = (vtkAbstractPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractPointLocator.Register(null);
				}
			}
			return vtkAbstractPointLocator;
		}
	}
}
