using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCompositeRenderManager : vtkParallelRenderManager
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCompositeRenderManager";

		public new static readonly string MRClassNameKey;

		static vtkCompositeRenderManager()
		{
			vtkCompositeRenderManager.MRClassNameKey = "class vtkCompositeRenderManager";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCompositeRenderManager.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositeRenderManager"));
		}

		public vtkCompositeRenderManager(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositeRenderManager_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCompositeRenderManager New()
		{
			vtkCompositeRenderManager result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositeRenderManager.vtkCompositeRenderManager_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeRenderManager)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCompositeRenderManager() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCompositeRenderManager.vtkCompositeRenderManager_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositeRenderManager_GetCompositer_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCompositer GetCompositer()
		{
			vtkCompositer vtkCompositer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositeRenderManager.vtkCompositeRenderManager_GetCompositer_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern double vtkCompositeRenderManager_GetImageProcessingTime_02(HandleRef pThis);

		public override double GetImageProcessingTime()
		{
			return vtkCompositeRenderManager.vtkCompositeRenderManager_GetImageProcessingTime_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCompositeRenderManager_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCompositeRenderManager.vtkCompositeRenderManager_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCompositeRenderManager_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCompositeRenderManager.vtkCompositeRenderManager_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositeRenderManager_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCompositeRenderManager NewInstance()
		{
			vtkCompositeRenderManager result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositeRenderManager.vtkCompositeRenderManager_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeRenderManager)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositeRenderManager_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCompositeRenderManager SafeDownCast(vtkObjectBase o)
		{
			vtkCompositeRenderManager vtkCompositeRenderManager = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositeRenderManager.vtkCompositeRenderManager_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeRenderManager = (vtkCompositeRenderManager)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeRenderManager.Register(null);
				}
			}
			return vtkCompositeRenderManager;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkCompositeRenderManager_SetCompositer_08(HandleRef pThis, HandleRef c);

		public void SetCompositer(vtkCompositer c)
		{
			vtkCompositeRenderManager.vtkCompositeRenderManager_SetCompositer_08(base.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis());
		}
	}
}
