using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOrientedPolygonalHandleRepresentation3D : vtkAbstractPolygonalHandleRepresentation3D
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOrientedPolygonalHandleRepresentation3D";

		public new static readonly string MRClassNameKey;

		static vtkOrientedPolygonalHandleRepresentation3D()
		{
			vtkOrientedPolygonalHandleRepresentation3D.MRClassNameKey = "class vtkOrientedPolygonalHandleRepresentation3D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOrientedPolygonalHandleRepresentation3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOrientedPolygonalHandleRepresentation3D"));
		}

		public vtkOrientedPolygonalHandleRepresentation3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkOrientedPolygonalHandleRepresentation3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOrientedPolygonalHandleRepresentation3D New()
		{
			vtkOrientedPolygonalHandleRepresentation3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOrientedPolygonalHandleRepresentation3D.vtkOrientedPolygonalHandleRepresentation3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOrientedPolygonalHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOrientedPolygonalHandleRepresentation3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOrientedPolygonalHandleRepresentation3D.vtkOrientedPolygonalHandleRepresentation3D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkOrientedPolygonalHandleRepresentation3D_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOrientedPolygonalHandleRepresentation3D.vtkOrientedPolygonalHandleRepresentation3D_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkOrientedPolygonalHandleRepresentation3D_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOrientedPolygonalHandleRepresentation3D.vtkOrientedPolygonalHandleRepresentation3D_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkOrientedPolygonalHandleRepresentation3D_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOrientedPolygonalHandleRepresentation3D NewInstance()
		{
			vtkOrientedPolygonalHandleRepresentation3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOrientedPolygonalHandleRepresentation3D.vtkOrientedPolygonalHandleRepresentation3D_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOrientedPolygonalHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkOrientedPolygonalHandleRepresentation3D_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOrientedPolygonalHandleRepresentation3D SafeDownCast(vtkObjectBase o)
		{
			vtkOrientedPolygonalHandleRepresentation3D vtkOrientedPolygonalHandleRepresentation3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOrientedPolygonalHandleRepresentation3D.vtkOrientedPolygonalHandleRepresentation3D_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOrientedPolygonalHandleRepresentation3D = (vtkOrientedPolygonalHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOrientedPolygonalHandleRepresentation3D.Register(null);
				}
			}
			return vtkOrientedPolygonalHandleRepresentation3D;
		}
	}
}
