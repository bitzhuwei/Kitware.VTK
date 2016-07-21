using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOpenGLRenderer : vtkRenderer
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLRenderer";

		public new static readonly string MRClassNameKey;

		static vtkOpenGLRenderer()
		{
			vtkOpenGLRenderer.MRClassNameKey = "class vtkOpenGLRenderer";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLRenderer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLRenderer"));
		}

		public vtkOpenGLRenderer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLRenderer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLRenderer New()
		{
			vtkOpenGLRenderer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLRenderer.vtkOpenGLRenderer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOpenGLRenderer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOpenGLRenderer.vtkOpenGLRenderer_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLRenderer_Clear_01(HandleRef pThis);

		public override void Clear()
		{
			vtkOpenGLRenderer.vtkOpenGLRenderer_Clear_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLRenderer_ClearLights_02(HandleRef pThis);

		public void ClearLights()
		{
			vtkOpenGLRenderer.vtkOpenGLRenderer_ClearLights_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLRenderer_DeviceRender_03(HandleRef pThis);

		public override void DeviceRender()
		{
			vtkOpenGLRenderer.vtkOpenGLRenderer_DeviceRender_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLRenderer_DeviceRenderTranslucentPolygonalGeometry_04(HandleRef pThis);

		public override void DeviceRenderTranslucentPolygonalGeometry()
		{
			vtkOpenGLRenderer.vtkOpenGLRenderer_DeviceRenderTranslucentPolygonalGeometry_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLRenderer_GetDepthPeelingHigherLayer_05(HandleRef pThis);

		public int GetDepthPeelingHigherLayer()
		{
			return vtkOpenGLRenderer.vtkOpenGLRenderer_GetDepthPeelingHigherLayer_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLRenderer_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOpenGLRenderer.vtkOpenGLRenderer_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLRenderer_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLRenderer.vtkOpenGLRenderer_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLRenderer_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOpenGLRenderer NewInstance()
		{
			vtkOpenGLRenderer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLRenderer.vtkOpenGLRenderer_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLRenderer_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLRenderer SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLRenderer vtkOpenGLRenderer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLRenderer.vtkOpenGLRenderer_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLRenderer = (vtkOpenGLRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLRenderer.Register(null);
				}
			}
			return vtkOpenGLRenderer;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLRenderer_UpdateLights_11(HandleRef pThis);

		public virtual int UpdateLights()
		{
			return vtkOpenGLRenderer.vtkOpenGLRenderer_UpdateLights_11(base.GetCppThis());
		}
	}
}
