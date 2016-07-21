using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMapper2D : vtkAbstractMapper
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMapper2D";

		public new static readonly string MRClassNameKey;

		static vtkMapper2D()
		{
			vtkMapper2D.MRClassNameKey = "class vtkMapper2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMapper2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMapper2D"));
		}

		public vtkMapper2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkMapper2D_HasTranslucentPolygonalGeometry_01(HandleRef pThis);

		public virtual int HasTranslucentPolygonalGeometry()
		{
			return vtkMapper2D.vtkMapper2D_HasTranslucentPolygonalGeometry_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkMapper2D_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMapper2D.vtkMapper2D_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkMapper2D_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMapper2D.vtkMapper2D_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkMapper2D_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMapper2D NewInstance()
		{
			vtkMapper2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMapper2D.vtkMapper2D_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMapper2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkMapper2D_RenderOpaqueGeometry_05(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		public virtual void RenderOpaqueGeometry(vtkViewport arg0, vtkActor2D arg1)
		{
			vtkMapper2D.vtkMapper2D_RenderOpaqueGeometry_05(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkMapper2D_RenderOverlay_06(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		public virtual void RenderOverlay(vtkViewport arg0, vtkActor2D arg1)
		{
			vtkMapper2D.vtkMapper2D_RenderOverlay_06(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkMapper2D_RenderTranslucentPolygonalGeometry_07(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		public virtual void RenderTranslucentPolygonalGeometry(vtkViewport arg0, vtkActor2D arg1)
		{
			vtkMapper2D.vtkMapper2D_RenderTranslucentPolygonalGeometry_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkMapper2D_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMapper2D SafeDownCast(vtkObjectBase o)
		{
			vtkMapper2D vtkMapper2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMapper2D.vtkMapper2D_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMapper2D = (vtkMapper2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMapper2D.Register(null);
				}
			}
			return vtkMapper2D;
		}
	}
}
