using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkIncrementalPointLocator : vtkAbstractPointLocator
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkIncrementalPointLocator";

		public new static readonly string MRClassNameKey;

		static vtkIncrementalPointLocator()
		{
			vtkIncrementalPointLocator.MRClassNameKey = "class vtkIncrementalPointLocator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkIncrementalPointLocator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkIncrementalPointLocator"));
		}

		public vtkIncrementalPointLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkIncrementalPointLocator_FindClosestInsertedPoint_01(HandleRef pThis, IntPtr x);

		public virtual long FindClosestInsertedPoint(IntPtr x)
		{
			return vtkIncrementalPointLocator.vtkIncrementalPointLocator_FindClosestInsertedPoint_01(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkIncrementalPointLocator_InitPointInsertion_02(HandleRef pThis, HandleRef newPts, IntPtr bounds);

		public virtual int InitPointInsertion(vtkPoints newPts, IntPtr bounds)
		{
			return vtkIncrementalPointLocator.vtkIncrementalPointLocator_InitPointInsertion_02(base.GetCppThis(), (newPts == null) ? default(HandleRef) : newPts.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkIncrementalPointLocator_InitPointInsertion_03(HandleRef pThis, HandleRef newPts, IntPtr bounds, long estSize);

		public virtual int InitPointInsertion(vtkPoints newPts, IntPtr bounds, long estSize)
		{
			return vtkIncrementalPointLocator.vtkIncrementalPointLocator_InitPointInsertion_03(base.GetCppThis(), (newPts == null) ? default(HandleRef) : newPts.GetCppThis(), bounds, estSize);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkIncrementalPointLocator_Initialize_04(HandleRef pThis);

		public override void Initialize()
		{
			vtkIncrementalPointLocator.vtkIncrementalPointLocator_Initialize_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkIncrementalPointLocator_InsertNextPoint_05(HandleRef pThis, IntPtr x);

		public virtual long InsertNextPoint(IntPtr x)
		{
			return vtkIncrementalPointLocator.vtkIncrementalPointLocator_InsertNextPoint_05(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkIncrementalPointLocator_InsertPoint_06(HandleRef pThis, long ptId, IntPtr x);

		public virtual void InsertPoint(long ptId, IntPtr x)
		{
			vtkIncrementalPointLocator.vtkIncrementalPointLocator_InsertPoint_06(base.GetCppThis(), ptId, x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkIncrementalPointLocator_InsertUniquePoint_07(HandleRef pThis, IntPtr x, ref long ptId);

		public virtual int InsertUniquePoint(IntPtr x, ref long ptId)
		{
			return vtkIncrementalPointLocator.vtkIncrementalPointLocator_InsertUniquePoint_07(base.GetCppThis(), x, ref ptId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkIncrementalPointLocator_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkIncrementalPointLocator.vtkIncrementalPointLocator_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkIncrementalPointLocator_IsInsertedPoint_09(HandleRef pThis, double x, double y, double z);

		public virtual long IsInsertedPoint(double x, double y, double z)
		{
			return vtkIncrementalPointLocator.vtkIncrementalPointLocator_IsInsertedPoint_09(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkIncrementalPointLocator_IsInsertedPoint_10(HandleRef pThis, IntPtr x);

		public virtual long IsInsertedPoint(IntPtr x)
		{
			return vtkIncrementalPointLocator.vtkIncrementalPointLocator_IsInsertedPoint_10(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkIncrementalPointLocator_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkIncrementalPointLocator.vtkIncrementalPointLocator_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkIncrementalPointLocator_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkIncrementalPointLocator NewInstance()
		{
			vtkIncrementalPointLocator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkIncrementalPointLocator.vtkIncrementalPointLocator_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIncrementalPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkIncrementalPointLocator_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkIncrementalPointLocator SafeDownCast(vtkObjectBase o)
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkIncrementalPointLocator.vtkIncrementalPointLocator_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIncrementalPointLocator = (vtkIncrementalPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIncrementalPointLocator.Register(null);
				}
			}
			return vtkIncrementalPointLocator;
		}
	}
}
