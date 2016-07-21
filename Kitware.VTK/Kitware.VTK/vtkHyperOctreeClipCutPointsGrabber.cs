using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkHyperOctreeClipCutPointsGrabber : vtkHyperOctreePointsGrabber
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkHyperOctreeClipCutPointsGrabber";

		public new static readonly string MRClassNameKey;

		static vtkHyperOctreeClipCutPointsGrabber()
		{
			vtkHyperOctreeClipCutPointsGrabber.MRClassNameKey = "class vtkHyperOctreeClipCutPointsGrabber";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHyperOctreeClipCutPointsGrabber.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHyperOctreeClipCutPointsGrabber"));
		}

		public vtkHyperOctreeClipCutPointsGrabber(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeClipCutPointsGrabber_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHyperOctreeClipCutPointsGrabber New()
		{
			vtkHyperOctreeClipCutPointsGrabber result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeClipCutPointsGrabber.vtkHyperOctreeClipCutPointsGrabber_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperOctreeClipCutPointsGrabber)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkHyperOctreeClipCutPointsGrabber() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkHyperOctreeClipCutPointsGrabber.vtkHyperOctreeClipCutPointsGrabber_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeClipCutPointsGrabber_GetPolygon_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolygon GetPolygon()
		{
			vtkPolygon vtkPolygon = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeClipCutPointsGrabber.vtkHyperOctreeClipCutPointsGrabber_GetPolygon_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolygon = (vtkPolygon)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolygon.Register(null);
				}
			}
			return vtkPolygon;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeClipCutPointsGrabber_GetTriangulator_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkOrderedTriangulator GetTriangulator()
		{
			vtkOrderedTriangulator vtkOrderedTriangulator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeClipCutPointsGrabber.vtkHyperOctreeClipCutPointsGrabber_GetTriangulator_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOrderedTriangulator = (vtkOrderedTriangulator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOrderedTriangulator.Register(null);
				}
			}
			return vtkOrderedTriangulator;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeClipCutPointsGrabber_InitPointInsertion_03(HandleRef pThis);

		public override void InitPointInsertion()
		{
			vtkHyperOctreeClipCutPointsGrabber.vtkHyperOctreeClipCutPointsGrabber_InitPointInsertion_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeClipCutPointsGrabber_InsertPoint_04(HandleRef pThis, long ptId, IntPtr pt, IntPtr pcoords, IntPtr ijk);

		public override void InsertPoint(long ptId, IntPtr pt, IntPtr pcoords, IntPtr ijk)
		{
			vtkHyperOctreeClipCutPointsGrabber.vtkHyperOctreeClipCutPointsGrabber_InsertPoint_04(base.GetCppThis(), ptId, pt, pcoords, ijk);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeClipCutPointsGrabber_InsertPoint2D_05(HandleRef pThis, IntPtr pt, IntPtr ijk);

		public override void InsertPoint2D(IntPtr pt, IntPtr ijk)
		{
			vtkHyperOctreeClipCutPointsGrabber.vtkHyperOctreeClipCutPointsGrabber_InsertPoint2D_05(base.GetCppThis(), pt, ijk);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeClipCutPointsGrabber_InsertPointWithMerge_06(HandleRef pThis, long ptId, IntPtr pt, IntPtr pcoords, IntPtr ijk);

		public override void InsertPointWithMerge(long ptId, IntPtr pt, IntPtr pcoords, IntPtr ijk)
		{
			vtkHyperOctreeClipCutPointsGrabber.vtkHyperOctreeClipCutPointsGrabber_InsertPointWithMerge_06(base.GetCppThis(), ptId, pt, pcoords, ijk);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeClipCutPointsGrabber_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkHyperOctreeClipCutPointsGrabber.vtkHyperOctreeClipCutPointsGrabber_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeClipCutPointsGrabber_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkHyperOctreeClipCutPointsGrabber.vtkHyperOctreeClipCutPointsGrabber_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeClipCutPointsGrabber_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkHyperOctreeClipCutPointsGrabber NewInstance()
		{
			vtkHyperOctreeClipCutPointsGrabber result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeClipCutPointsGrabber.vtkHyperOctreeClipCutPointsGrabber_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperOctreeClipCutPointsGrabber)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeClipCutPointsGrabber_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHyperOctreeClipCutPointsGrabber SafeDownCast(vtkObjectBase o)
		{
			vtkHyperOctreeClipCutPointsGrabber vtkHyperOctreeClipCutPointsGrabber = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeClipCutPointsGrabber.vtkHyperOctreeClipCutPointsGrabber_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHyperOctreeClipCutPointsGrabber = (vtkHyperOctreeClipCutPointsGrabber)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHyperOctreeClipCutPointsGrabber.Register(null);
				}
			}
			return vtkHyperOctreeClipCutPointsGrabber;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeClipCutPointsGrabber_SetDimension_12(HandleRef pThis, int dim);

		public override void SetDimension(int dim)
		{
			vtkHyperOctreeClipCutPointsGrabber.vtkHyperOctreeClipCutPointsGrabber_SetDimension_12(base.GetCppThis(), dim);
		}
	}
}
