using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOpenGLProperty : vtkProperty
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLProperty";

		public new static readonly string MRClassNameKey;

		static vtkOpenGLProperty()
		{
			vtkOpenGLProperty.MRClassNameKey = "class vtkOpenGLProperty";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLProperty.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLProperty"));
		}

		public vtkOpenGLProperty(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLProperty_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLProperty New()
		{
			vtkOpenGLProperty result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLProperty.vtkOpenGLProperty_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOpenGLProperty() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOpenGLProperty.vtkOpenGLProperty_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLProperty_AddShaderVariable_01(HandleRef pThis, string name, int numVars, IntPtr x);

		public override void AddShaderVariable(string name, int numVars, IntPtr x)
		{
			vtkOpenGLProperty.vtkOpenGLProperty_AddShaderVariable_01(base.GetCppThis(), name, numVars, x);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLProperty_BackfaceRender_02(HandleRef pThis, HandleRef a, HandleRef ren);

		public override void BackfaceRender(vtkActor a, vtkRenderer ren)
		{
			vtkOpenGLProperty.vtkOpenGLProperty_BackfaceRender_02(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLProperty_GetShaderDeviceAdapter2_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkGLSLShaderDeviceAdapter2 GetShaderDeviceAdapter2()
		{
			vtkGLSLShaderDeviceAdapter2 vtkGLSLShaderDeviceAdapter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLProperty.vtkOpenGLProperty_GetShaderDeviceAdapter2_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGLSLShaderDeviceAdapter = (vtkGLSLShaderDeviceAdapter2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGLSLShaderDeviceAdapter.Register(null);
				}
			}
			return vtkGLSLShaderDeviceAdapter;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLProperty_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOpenGLProperty.vtkOpenGLProperty_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLProperty_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLProperty.vtkOpenGLProperty_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLProperty_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOpenGLProperty NewInstance()
		{
			vtkOpenGLProperty result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLProperty.vtkOpenGLProperty_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLProperty_PostRender_08(HandleRef pThis, HandleRef a, HandleRef r);

		public override void PostRender(vtkActor a, vtkRenderer r)
		{
			vtkOpenGLProperty.vtkOpenGLProperty_PostRender_08(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLProperty_ReleaseGraphicsResources_09(HandleRef pThis, HandleRef win);

		public override void ReleaseGraphicsResources(vtkWindow win)
		{
			vtkOpenGLProperty.vtkOpenGLProperty_ReleaseGraphicsResources_09(base.GetCppThis(), (win == null) ? default(HandleRef) : win.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLProperty_Render_10(HandleRef pThis, HandleRef a, HandleRef ren);

		public override void Render(vtkActor a, vtkRenderer ren)
		{
			vtkOpenGLProperty.vtkOpenGLProperty_Render_10(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLProperty_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLProperty SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLProperty vtkOpenGLProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLProperty.vtkOpenGLProperty_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLProperty = (vtkOpenGLProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLProperty.Register(null);
				}
			}
			return vtkOpenGLProperty;
		}
	}
}
