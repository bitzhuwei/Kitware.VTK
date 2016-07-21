using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkHyperOctreePointsGrabber : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkHyperOctreePointsGrabber";

		public new static readonly string MRClassNameKey;

		static vtkHyperOctreePointsGrabber()
		{
			vtkHyperOctreePointsGrabber.MRClassNameKey = "class vtkHyperOctreePointsGrabber";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHyperOctreePointsGrabber.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHyperOctreePointsGrabber"));
		}

		public vtkHyperOctreePointsGrabber(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHyperOctreePointsGrabber_GetDimension_01(HandleRef pThis);

		public int GetDimension()
		{
			return vtkHyperOctreePointsGrabber.vtkHyperOctreePointsGrabber_GetDimension_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctreePointsGrabber_InitPointInsertion_02(HandleRef pThis);

		public virtual void InitPointInsertion()
		{
			vtkHyperOctreePointsGrabber.vtkHyperOctreePointsGrabber_InitPointInsertion_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctreePointsGrabber_InsertPoint_03(HandleRef pThis, long ptId, IntPtr pt, IntPtr pcoords, IntPtr ijk);

		public virtual void InsertPoint(long ptId, IntPtr pt, IntPtr pcoords, IntPtr ijk)
		{
			vtkHyperOctreePointsGrabber.vtkHyperOctreePointsGrabber_InsertPoint_03(base.GetCppThis(), ptId, pt, pcoords, ijk);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctreePointsGrabber_InsertPoint2D_04(HandleRef pThis, IntPtr pt, IntPtr ijk);

		public virtual void InsertPoint2D(IntPtr pt, IntPtr ijk)
		{
			vtkHyperOctreePointsGrabber.vtkHyperOctreePointsGrabber_InsertPoint2D_04(base.GetCppThis(), pt, ijk);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctreePointsGrabber_InsertPointWithMerge_05(HandleRef pThis, long ptId, IntPtr pt, IntPtr pcoords, IntPtr ijk);

		public virtual void InsertPointWithMerge(long ptId, IntPtr pt, IntPtr pcoords, IntPtr ijk)
		{
			vtkHyperOctreePointsGrabber.vtkHyperOctreePointsGrabber_InsertPointWithMerge_05(base.GetCppThis(), ptId, pt, pcoords, ijk);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHyperOctreePointsGrabber_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkHyperOctreePointsGrabber.vtkHyperOctreePointsGrabber_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHyperOctreePointsGrabber_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkHyperOctreePointsGrabber.vtkHyperOctreePointsGrabber_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreePointsGrabber_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkHyperOctreePointsGrabber NewInstance()
		{
			vtkHyperOctreePointsGrabber result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreePointsGrabber.vtkHyperOctreePointsGrabber_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperOctreePointsGrabber)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreePointsGrabber_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHyperOctreePointsGrabber SafeDownCast(vtkObjectBase o)
		{
			vtkHyperOctreePointsGrabber vtkHyperOctreePointsGrabber = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreePointsGrabber.vtkHyperOctreePointsGrabber_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHyperOctreePointsGrabber = (vtkHyperOctreePointsGrabber)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHyperOctreePointsGrabber.Register(null);
				}
			}
			return vtkHyperOctreePointsGrabber;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctreePointsGrabber_SetDimension_10(HandleRef pThis, int dim);

		public virtual void SetDimension(int dim)
		{
			vtkHyperOctreePointsGrabber.vtkHyperOctreePointsGrabber_SetDimension_10(base.GetCppThis(), dim);
		}
	}
}
