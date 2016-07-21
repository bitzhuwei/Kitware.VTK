using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCompositedSynchronizedRenderers : vtkSynchronizedRenderers
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCompositedSynchronizedRenderers";

		public new static readonly string MRClassNameKey;

		static vtkCompositedSynchronizedRenderers()
		{
			vtkCompositedSynchronizedRenderers.MRClassNameKey = "class vtkCompositedSynchronizedRenderers";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCompositedSynchronizedRenderers.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositedSynchronizedRenderers"));
		}

		public vtkCompositedSynchronizedRenderers(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositedSynchronizedRenderers_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCompositedSynchronizedRenderers New()
		{
			vtkCompositedSynchronizedRenderers result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositedSynchronizedRenderers.vtkCompositedSynchronizedRenderers_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositedSynchronizedRenderers)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCompositedSynchronizedRenderers() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCompositedSynchronizedRenderers.vtkCompositedSynchronizedRenderers_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositedSynchronizedRenderers_GetCompositer_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCompositer GetCompositer()
		{
			vtkCompositer vtkCompositer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositedSynchronizedRenderers.vtkCompositedSynchronizedRenderers_GetCompositer_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositer = (vtkCompositer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositer.Register(null);
				}
			}
			return vtkCompositer;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCompositedSynchronizedRenderers_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCompositedSynchronizedRenderers.vtkCompositedSynchronizedRenderers_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCompositedSynchronizedRenderers_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCompositedSynchronizedRenderers.vtkCompositedSynchronizedRenderers_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositedSynchronizedRenderers_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCompositedSynchronizedRenderers NewInstance()
		{
			vtkCompositedSynchronizedRenderers result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositedSynchronizedRenderers.vtkCompositedSynchronizedRenderers_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositedSynchronizedRenderers)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositedSynchronizedRenderers_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCompositedSynchronizedRenderers SafeDownCast(vtkObjectBase o)
		{
			vtkCompositedSynchronizedRenderers vtkCompositedSynchronizedRenderers = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositedSynchronizedRenderers.vtkCompositedSynchronizedRenderers_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositedSynchronizedRenderers = (vtkCompositedSynchronizedRenderers)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositedSynchronizedRenderers.Register(null);
				}
			}
			return vtkCompositedSynchronizedRenderers;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkCompositedSynchronizedRenderers_SetCompositer_07(HandleRef pThis, HandleRef arg0);

		public void SetCompositer(vtkCompositer arg0)
		{
			vtkCompositedSynchronizedRenderers.vtkCompositedSynchronizedRenderers_SetCompositer_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
