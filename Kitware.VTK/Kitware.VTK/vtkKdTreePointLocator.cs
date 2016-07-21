using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkKdTreePointLocator : vtkAbstractPointLocator
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkKdTreePointLocator";

		public new static readonly string MRClassNameKey;

		static vtkKdTreePointLocator()
		{
			vtkKdTreePointLocator.MRClassNameKey = "class vtkKdTreePointLocator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkKdTreePointLocator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkKdTreePointLocator"));
		}

		public vtkKdTreePointLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkKdTreePointLocator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkKdTreePointLocator New()
		{
			vtkKdTreePointLocator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKdTreePointLocator.vtkKdTreePointLocator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkKdTreePointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkKdTreePointLocator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkKdTreePointLocator.vtkKdTreePointLocator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTreePointLocator_BuildLocator_01(HandleRef pThis);

		public override void BuildLocator()
		{
			vtkKdTreePointLocator.vtkKdTreePointLocator_BuildLocator_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTreePointLocator_FindClosestNPoints_02(HandleRef pThis, int N, IntPtr x, HandleRef result);

		public override void FindClosestNPoints(int N, IntPtr x, vtkIdList result)
		{
			vtkKdTreePointLocator.vtkKdTreePointLocator_FindClosestNPoints_02(base.GetCppThis(), N, x, (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkKdTreePointLocator_FindClosestPoint_03(HandleRef pThis, IntPtr x);

		public override long FindClosestPoint(IntPtr x)
		{
			return vtkKdTreePointLocator.vtkKdTreePointLocator_FindClosestPoint_03(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkKdTreePointLocator_FindClosestPointWithinRadius_04(HandleRef pThis, double radius, IntPtr x, ref double dist2);

		public override long FindClosestPointWithinRadius(double radius, IntPtr x, ref double dist2)
		{
			return vtkKdTreePointLocator.vtkKdTreePointLocator_FindClosestPointWithinRadius_04(base.GetCppThis(), radius, x, ref dist2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTreePointLocator_FindPointsWithinRadius_05(HandleRef pThis, double R, IntPtr x, HandleRef result);

		public override void FindPointsWithinRadius(double R, IntPtr x, vtkIdList result)
		{
			vtkKdTreePointLocator.vtkKdTreePointLocator_FindPointsWithinRadius_05(base.GetCppThis(), R, x, (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTreePointLocator_FreeSearchStructure_06(HandleRef pThis);

		public override void FreeSearchStructure()
		{
			vtkKdTreePointLocator.vtkKdTreePointLocator_FreeSearchStructure_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTreePointLocator_GenerateRepresentation_07(HandleRef pThis, int level, HandleRef pd);

		public override void GenerateRepresentation(int level, vtkPolyData pd)
		{
			vtkKdTreePointLocator.vtkKdTreePointLocator_GenerateRepresentation_07(base.GetCppThis(), level, (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkKdTreePointLocator_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkKdTreePointLocator.vtkKdTreePointLocator_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkKdTreePointLocator_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkKdTreePointLocator.vtkKdTreePointLocator_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkKdTreePointLocator_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkKdTreePointLocator NewInstance()
		{
			vtkKdTreePointLocator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKdTreePointLocator.vtkKdTreePointLocator_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkKdTreePointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkKdTreePointLocator_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkKdTreePointLocator SafeDownCast(vtkObjectBase o)
		{
			vtkKdTreePointLocator vtkKdTreePointLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKdTreePointLocator.vtkKdTreePointLocator_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkKdTreePointLocator = (vtkKdTreePointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkKdTreePointLocator.Register(null);
				}
			}
			return vtkKdTreePointLocator;
		}
	}
}
