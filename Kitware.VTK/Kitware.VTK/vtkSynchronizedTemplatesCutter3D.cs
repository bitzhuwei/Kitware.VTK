using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSynchronizedTemplatesCutter3D : vtkSynchronizedTemplates3D
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSynchronizedTemplatesCutter3D";

		public new static readonly string MRClassNameKey;

		static vtkSynchronizedTemplatesCutter3D()
		{
			vtkSynchronizedTemplatesCutter3D.MRClassNameKey = "class vtkSynchronizedTemplatesCutter3D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSynchronizedTemplatesCutter3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSynchronizedTemplatesCutter3D"));
		}

		public vtkSynchronizedTemplatesCutter3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSynchronizedTemplatesCutter3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSynchronizedTemplatesCutter3D New()
		{
			vtkSynchronizedTemplatesCutter3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSynchronizedTemplatesCutter3D.vtkSynchronizedTemplatesCutter3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSynchronizedTemplatesCutter3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSynchronizedTemplatesCutter3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSynchronizedTemplatesCutter3D.vtkSynchronizedTemplatesCutter3D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSynchronizedTemplatesCutter3D_GetCutFunction_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImplicitFunction GetCutFunction()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSynchronizedTemplatesCutter3D.vtkSynchronizedTemplatesCutter3D_GetCutFunction_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitFunction = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitFunction.Register(null);
				}
			}
			return vtkImplicitFunction;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSynchronizedTemplatesCutter3D_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSynchronizedTemplatesCutter3D.vtkSynchronizedTemplatesCutter3D_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSynchronizedTemplatesCutter3D_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSynchronizedTemplatesCutter3D.vtkSynchronizedTemplatesCutter3D_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSynchronizedTemplatesCutter3D_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSynchronizedTemplatesCutter3D NewInstance()
		{
			vtkSynchronizedTemplatesCutter3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSynchronizedTemplatesCutter3D.vtkSynchronizedTemplatesCutter3D_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSynchronizedTemplatesCutter3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSynchronizedTemplatesCutter3D_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSynchronizedTemplatesCutter3D SafeDownCast(vtkObjectBase o)
		{
			vtkSynchronizedTemplatesCutter3D vtkSynchronizedTemplatesCutter3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSynchronizedTemplatesCutter3D.vtkSynchronizedTemplatesCutter3D_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSynchronizedTemplatesCutter3D = (vtkSynchronizedTemplatesCutter3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSynchronizedTemplatesCutter3D.Register(null);
				}
			}
			return vtkSynchronizedTemplatesCutter3D;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSynchronizedTemplatesCutter3D_SetCutFunction_07(HandleRef pThis, HandleRef arg0);

		public virtual void SetCutFunction(vtkImplicitFunction arg0)
		{
			vtkSynchronizedTemplatesCutter3D.vtkSynchronizedTemplatesCutter3D_SetCutFunction_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSynchronizedTemplatesCutter3D_ThreadedExecute_08(HandleRef pThis, HandleRef data, HandleRef outInfo, IntPtr exExt, int arg3);

		public void ThreadedExecute(vtkImageData data, vtkInformation outInfo, IntPtr exExt, int arg3)
		{
			vtkSynchronizedTemplatesCutter3D.vtkSynchronizedTemplatesCutter3D_ThreadedExecute_08(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), (outInfo == null) ? default(HandleRef) : outInfo.GetCppThis(), exExt, arg3);
		}
	}
}
