using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkClientServerSynchronizedRenderers : vtkSynchronizedRenderers
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkClientServerSynchronizedRenderers";

		public new static readonly string MRClassNameKey;

		static vtkClientServerSynchronizedRenderers()
		{
			vtkClientServerSynchronizedRenderers.MRClassNameKey = "class vtkClientServerSynchronizedRenderers";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkClientServerSynchronizedRenderers.MRClassNameKey, Type.GetType("Kitware.VTK.vtkClientServerSynchronizedRenderers"));
		}

		public vtkClientServerSynchronizedRenderers(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkClientServerSynchronizedRenderers_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkClientServerSynchronizedRenderers New()
		{
			vtkClientServerSynchronizedRenderers result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClientServerSynchronizedRenderers.vtkClientServerSynchronizedRenderers_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClientServerSynchronizedRenderers)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkClientServerSynchronizedRenderers() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkClientServerSynchronizedRenderers.vtkClientServerSynchronizedRenderers_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkClientServerSynchronizedRenderers_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkClientServerSynchronizedRenderers.vtkClientServerSynchronizedRenderers_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkClientServerSynchronizedRenderers_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkClientServerSynchronizedRenderers.vtkClientServerSynchronizedRenderers_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkClientServerSynchronizedRenderers_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkClientServerSynchronizedRenderers NewInstance()
		{
			vtkClientServerSynchronizedRenderers result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClientServerSynchronizedRenderers.vtkClientServerSynchronizedRenderers_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClientServerSynchronizedRenderers)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkClientServerSynchronizedRenderers_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkClientServerSynchronizedRenderers SafeDownCast(vtkObjectBase o)
		{
			vtkClientServerSynchronizedRenderers vtkClientServerSynchronizedRenderers = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClientServerSynchronizedRenderers.vtkClientServerSynchronizedRenderers_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkClientServerSynchronizedRenderers = (vtkClientServerSynchronizedRenderers)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkClientServerSynchronizedRenderers.Register(null);
				}
			}
			return vtkClientServerSynchronizedRenderers;
		}
	}
}
