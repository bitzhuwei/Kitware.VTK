using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTextActor3D : vtkProp3D
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTextActor3D";

		public new static readonly string MRClassNameKey;

		static vtkTextActor3D()
		{
			vtkTextActor3D.MRClassNameKey = "class vtkTextActor3D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTextActor3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextActor3D"));
		}

		public vtkTextActor3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTextActor3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTextActor3D New()
		{
			vtkTextActor3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextActor3D.vtkTextActor3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextActor3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTextActor3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTextActor3D.vtkTextActor3D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextActor3D_GetBoundingBox_01(HandleRef pThis, IntPtr bbox);

		public int GetBoundingBox(IntPtr bbox)
		{
			return vtkTextActor3D.vtkTextActor3D_GetBoundingBox_01(base.GetCppThis(), bbox);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTextActor3D_GetBounds_02(HandleRef pThis);

		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkTextActor3D.vtkTextActor3D_GetBounds_02(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTextActor3D_GetInput_03(HandleRef pThis);

		public virtual string GetInput()
		{
			return Marshal.PtrToStringAnsi(vtkTextActor3D.vtkTextActor3D_GetInput_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTextActor3D_GetTextProperty_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextActor3D.vtkTextActor3D_GetTextProperty_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextActor3D_HasTranslucentPolygonalGeometry_05(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkTextActor3D.vtkTextActor3D_HasTranslucentPolygonalGeometry_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextActor3D_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTextActor3D.vtkTextActor3D_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextActor3D_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTextActor3D.vtkTextActor3D_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTextActor3D_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTextActor3D NewInstance()
		{
			vtkTextActor3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextActor3D.vtkTextActor3D_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextActor3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextActor3D_ReleaseGraphicsResources_10(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkTextActor3D.vtkTextActor3D_ReleaseGraphicsResources_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextActor3D_RenderOpaqueGeometry_11(HandleRef pThis, HandleRef viewport);

		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkTextActor3D.vtkTextActor3D_RenderOpaqueGeometry_11(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextActor3D_RenderOverlay_12(HandleRef pThis, HandleRef viewport);

		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkTextActor3D.vtkTextActor3D_RenderOverlay_12(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextActor3D_RenderTranslucentPolygonalGeometry_13(HandleRef pThis, HandleRef viewport);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkTextActor3D.vtkTextActor3D_RenderTranslucentPolygonalGeometry_13(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTextActor3D_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTextActor3D SafeDownCast(vtkObjectBase o)
		{
			vtkTextActor3D vtkTextActor3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextActor3D.vtkTextActor3D_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextActor3D = (vtkTextActor3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextActor3D.Register(null);
				}
			}
			return vtkTextActor3D;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextActor3D_SetInput_15(HandleRef pThis, string _arg);

		public virtual void SetInput(string _arg)
		{
			vtkTextActor3D.vtkTextActor3D_SetInput_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextActor3D_SetTextProperty_16(HandleRef pThis, HandleRef p);

		public virtual void SetTextProperty(vtkTextProperty p)
		{
			vtkTextActor3D.vtkTextActor3D_SetTextProperty_16(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextActor3D_ShallowCopy_17(HandleRef pThis, HandleRef prop);

		public override void ShallowCopy(vtkProp prop)
		{
			vtkTextActor3D.vtkTextActor3D_ShallowCopy_17(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}
	}
}
