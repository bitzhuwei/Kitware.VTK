using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOpenGLLight : vtkLight
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLLight";

		public new static readonly string MRClassNameKey;

		static vtkOpenGLLight()
		{
			vtkOpenGLLight.MRClassNameKey = "class vtkOpenGLLight";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLLight.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLLight"));
		}

		public vtkOpenGLLight(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLLight_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLLight New()
		{
			vtkOpenGLLight result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLLight.vtkOpenGLLight_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLLight)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOpenGLLight() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOpenGLLight.vtkOpenGLLight_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLLight_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOpenGLLight.vtkOpenGLLight_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLLight_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLLight.vtkOpenGLLight_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLLight_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOpenGLLight NewInstance()
		{
			vtkOpenGLLight result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLLight.vtkOpenGLLight_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLLight)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLLight_Render_05(HandleRef pThis, HandleRef ren, int light_index);

		public override void Render(vtkRenderer ren, int light_index)
		{
			vtkOpenGLLight.vtkOpenGLLight_Render_05(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), light_index);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLLight_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLLight SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLLight vtkOpenGLLight = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLLight.vtkOpenGLLight_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLLight = (vtkOpenGLLight)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLLight.Register(null);
				}
			}
			return vtkOpenGLLight;
		}
	}
}
