using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGLSLShaderDeviceAdapter2 : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGLSLShaderDeviceAdapter2";

		public new static readonly string MRClassNameKey;

		static vtkGLSLShaderDeviceAdapter2()
		{
			vtkGLSLShaderDeviceAdapter2.MRClassNameKey = "class vtkGLSLShaderDeviceAdapter2";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGLSLShaderDeviceAdapter2.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGLSLShaderDeviceAdapter2"));
		}

		public vtkGLSLShaderDeviceAdapter2(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGLSLShaderDeviceAdapter2_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGLSLShaderDeviceAdapter2 New()
		{
			vtkGLSLShaderDeviceAdapter2 result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGLSLShaderDeviceAdapter2.vtkGLSLShaderDeviceAdapter2_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGLSLShaderDeviceAdapter2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGLSLShaderDeviceAdapter2() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGLSLShaderDeviceAdapter2.vtkGLSLShaderDeviceAdapter2_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGLSLShaderDeviceAdapter2_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGLSLShaderDeviceAdapter2.vtkGLSLShaderDeviceAdapter2_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGLSLShaderDeviceAdapter2_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGLSLShaderDeviceAdapter2.vtkGLSLShaderDeviceAdapter2_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGLSLShaderDeviceAdapter2_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGLSLShaderDeviceAdapter2 NewInstance()
		{
			vtkGLSLShaderDeviceAdapter2 result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGLSLShaderDeviceAdapter2.vtkGLSLShaderDeviceAdapter2_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGLSLShaderDeviceAdapter2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGLSLShaderDeviceAdapter2_PrepareForRender_05(HandleRef pThis);

		public virtual void PrepareForRender()
		{
			vtkGLSLShaderDeviceAdapter2.vtkGLSLShaderDeviceAdapter2_PrepareForRender_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGLSLShaderDeviceAdapter2_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGLSLShaderDeviceAdapter2 SafeDownCast(vtkObjectBase o)
		{
			vtkGLSLShaderDeviceAdapter2 vtkGLSLShaderDeviceAdapter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGLSLShaderDeviceAdapter2.vtkGLSLShaderDeviceAdapter2_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkGLSLShaderDeviceAdapter2_SendAttribute_07(HandleRef pThis, string attrname, int components, int type, IntPtr attribute, uint offset);

		public virtual void SendAttribute(string attrname, int components, int type, IntPtr attribute, uint offset)
		{
			vtkGLSLShaderDeviceAdapter2.vtkGLSLShaderDeviceAdapter2_SendAttribute_07(base.GetCppThis(), attrname, components, type, attribute, offset);
		}
	}
}
